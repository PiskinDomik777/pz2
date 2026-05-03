using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AVTOV.Models;

namespace AVTOV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("Пользователь не авторизован.");
                Close();
                return;
            }

            lblTitle.Text = $"Учет заявок на ремонт автомобилей | {Session.CurrentUser.Fio} ({Session.CurrentUser.Type})";

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Все статусы");
            cmbStatus.Items.Add("Новая заявка");
            cmbStatus.Items.Add("В процессе ремонта");
            cmbStatus.Items.Add("Готова к выдаче");
            cmbStatus.Items.Add("Ожидание автозапчастей");
            cmbStatus.SelectedIndex = 0;

            ApplyRoleAccess();
            LoadRequests();
        }

        private void ApplyRoleAccess()
        {
            string role = Session.CurrentUser!.Type;

            btnAddRequest.Enabled = role == "Оператор" || role == "Заказчик";
            btnEditRequest.Enabled = role == "Оператор" || role == "Менеджер" || role == "Автомеханик" || role == "Заказчик";
            btnComments.Enabled = role == "Менеджер" || role == "Автомеханик";
            btnStats.Enabled = role == "Менеджер";
            btnUsers.Enabled = role == "Менеджер";
        }

        private void LoadRequests()
        {
            using (var db = new Ispr2524LinkovNIAvtooContext())
            {
                var query = db.Requests
                    .Include(x => x.Client)
                    .Include(x => x.Master)
                    .AsQueryable();

                string search = txtSearch.Text.Trim();
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(x =>
                        x.RequestId.ToString().Contains(search) ||
                        x.CarType.Contains(search) ||
                        x.CarModel.Contains(search) ||
                        x.ProblemDescryption.Contains(search));
                }

                string? selectedStatus = cmbStatus.SelectedItem?.ToString();
                if (!string.IsNullOrWhiteSpace(selectedStatus) && selectedStatus != "Все статусы")
                {
                    query = query.Where(x => x.RequestStatus == selectedStatus);
                }

                if (Session.CurrentUser!.Type == "Заказчик")
                {
                    query = query.Where(x => x.ClientId == Session.CurrentUser.UserId);
                }

                if (Session.CurrentUser.Type == "Автомеханик")
                {
                    query = query.Where(x => x.MasterId == Session.CurrentUser.UserId || x.MasterId == null);
                }

                var data = query
                    .ToList()
                    .Select(x => new
                    {
                        x.RequestId,
                        StartDate = x.StartDate.ToString("yyyy-MM-dd"),
                        x.CarType,
                        x.CarModel,
                        x.ProblemDescryption,
                        x.RequestStatus,
                        CompletionDate = x.CompletionDate.HasValue ? x.CompletionDate.Value.ToString("yyyy-MM-dd") : "",
                        x.RepairParts,
                        Master = x.Master != null ? x.Master.Fio : "",
                        Client = x.Client != null ? x.Client.Fio : ""
                    })
                    .ToList();

                dgvRequests.DataSource = data;
            }
        }

        private int? GetSelectedRequestId()
        {
            if (dgvRequests.CurrentRow == null || dgvRequests.CurrentRow.Cells["RequestId"].Value == null)
                return null;

            return Convert.ToInt32(dgvRequests.CurrentRow.Cells["RequestId"].Value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatus.SelectedIndex = 0;
            LoadRequests();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            RequestForm form = new RequestForm(null);
            form.ShowDialog();
            LoadRequests();
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedRequestId();
            if (id == null)
            {
                MessageBox.Show("Выберите заявку.");
                return;
            }

            RequestForm form = new RequestForm(id.Value);
            form.ShowDialog();
            LoadRequests();
        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedRequestId();
            if (id == null)
            {
                MessageBox.Show("Выберите заявку.");
                return;
            }

            CommentForm form = new CommentForm(id.Value);
            form.ShowDialog();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            StatsForm form = new StatsForm();
            form.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
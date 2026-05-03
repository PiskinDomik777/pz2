using System;
using System.Linq;
using System.Windows.Forms;
using AVTOV.Models;

namespace AVTOV
{
    public partial class RequestForm : Form
    {
        private readonly int? _requestId;

        public RequestForm(int? requestId)
        {
            InitializeComponent();
            _requestId = requestId;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Новая заявка");
            cmbStatus.Items.Add("В процессе ремонта");
            cmbStatus.Items.Add("Готова к выдаче");
            cmbStatus.Items.Add("Ожидание автозапчастей");
            cmbStatus.SelectedIndex = 0;

            using (var db = new Ispr2524LinkovNIAvtooContext())
            {
                var masters = db.Users
                    .Where(x => x.Type == "Автомеханик")
                    .ToList();

                cmbMaster.DataSource = masters;
                cmbMaster.DisplayMember = "Fio";
                cmbMaster.ValueMember = "UserId";
                cmbMaster.SelectedIndex = -1;

                if (_requestId.HasValue)
                {
                    var req = db.Requests.FirstOrDefault(x => x.RequestId == _requestId.Value);

                    if (req != null)
                    {
                        txtRequestNumber.Text = req.RequestId.ToString();
                        dtpStartDate.Value = req.StartDate.ToDateTime(TimeOnly.MinValue);
                        txtCarType.Text = req.CarType;
                        txtCarModel.Text = req.CarModel;
                        txtProblem.Text = req.ProblemDescryption;
                        cmbStatus.SelectedItem = req.RequestStatus;
                        txtRepairParts.Text = req.RepairParts ?? string.Empty;
                        txtClientId.Text = req.ClientId.ToString();

                        if (req.CompletionDate.HasValue)
                            dtpCompletionDate.Value = req.CompletionDate.Value.ToDateTime(TimeOnly.MinValue);

                        if (req.MasterId.HasValue)
                            cmbMaster.SelectedValue = req.MasterId.Value;
                    }
                }
                else
                {
                    txtRequestNumber.Text = "Новая";
                    if (Session.CurrentUser != null && Session.CurrentUser.Type == "Заказчик")
                    {
                        txtClientId.Text = Session.CurrentUser.UserId.ToString();
                        txtClientId.ReadOnly = true;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarType.Text) ||
                string.IsNullOrWhiteSpace(txtCarModel.Text) ||
                string.IsNullOrWhiteSpace(txtProblem.Text) ||
                string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                MessageBox.Show("Заполните обязательные поля.");
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Выберите статус.");
                return;
            }

            using (var db = new Ispr2524LinkovNIAvtooContext())
            {
                string selectedStatus = cmbStatus.SelectedItem.ToString() ?? string.Empty;
                int? selectedMasterId = cmbMaster.SelectedValue == null
                    ? null
                    : Convert.ToInt32(cmbMaster.SelectedValue);

                if (_requestId.HasValue)
                {
                    var req = db.Requests.FirstOrDefault(x => x.RequestId == _requestId.Value);

                    if (req == null)
                    {
                        MessageBox.Show("Заявка не найдена.");
                        return;
                    }

                    req.StartDate = DateOnly.FromDateTime(dtpStartDate.Value);
                    req.CarType = txtCarType.Text.Trim();
                    req.CarModel = txtCarModel.Text.Trim();
                    req.ProblemDescryption = txtProblem.Text.Trim();
                    req.RequestStatus = selectedStatus;
                    req.RepairParts = string.IsNullOrWhiteSpace(txtRepairParts.Text) ? null : txtRepairParts.Text.Trim();
                    req.MasterId = selectedMasterId;
                    req.ClientId = Convert.ToInt32(txtClientId.Text);

                    if (selectedStatus == "Готова к выдаче")
                        req.CompletionDate = DateOnly.FromDateTime(dtpCompletionDate.Value);
                    else
                        req.CompletionDate = null;
                }
                else
                {
                    int newId = db.Requests.Any() ? db.Requests.Max(x => x.RequestId) + 1 : 1;

                    Request req = new Request
                    {
                        RequestId = newId,
                        StartDate = DateOnly.FromDateTime(dtpStartDate.Value),
                        CarType = txtCarType.Text.Trim(),
                        CarModel = txtCarModel.Text.Trim(),
                        ProblemDescryption = txtProblem.Text.Trim(),
                        RequestStatus = selectedStatus,
                        CompletionDate = selectedStatus == "Готова к выдаче"
                            ? DateOnly.FromDateTime(dtpCompletionDate.Value)
                            : null,
                        RepairParts = string.IsNullOrWhiteSpace(txtRepairParts.Text) ? null : txtRepairParts.Text.Trim(),
                        MasterId = selectedMasterId,
                        ClientId = Convert.ToInt32(txtClientId.Text)
                    };

                    db.Requests.Add(req);
                }

                db.SaveChanges();
            }

            MessageBox.Show("Сохранено.");
            Close();
        }
    }
}
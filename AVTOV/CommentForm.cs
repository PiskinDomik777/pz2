using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AVTOV.Models;

namespace AVTOV
{
    public partial class CommentForm : Form
    {
        private readonly int _requestId;

        public CommentForm(int requestId)
        {
            InitializeComponent();
            _requestId = requestId;
        }

        private void CommentForm_Load(object sender, EventArgs e)
        {
            LoadComments();
        }

        private void LoadComments()
        {
            using (var db = new Ispr2524LinkovNIAvtooContext())
            {
                var data = db.Comments
                    .Include(x => x.Master)
                    .Where(x => x.RequestId == _requestId)
                    .ToList()
                    .Select(x => new
                    {
                        x.CommentId,
                        x.Message,
                        Master = x.Master.Fio
                    })
                    .ToList();

                dgvComments.DataSource = data;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("Пользователь не авторизован.");
                return;
            }

            if (Session.CurrentUser.Type != "Автомеханик" && Session.CurrentUser.Type != "Менеджер")
            {
                MessageBox.Show("Недостаточно прав.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Введите комментарий.");
                return;
            }

            using (var db = new Ispr2524LinkovNIAvtooContext())
            {
                int newId = db.Comments.Any() ? db.Comments.Max(x => x.CommentId) + 1 : 1;

                Comment comment = new Comment
                {
                    CommentId = newId,
                    Message = txtComment.Text.Trim(),
                    MasterId = Session.CurrentUser.UserId,
                    RequestId = _requestId
                };

                db.Comments.Add(comment);
                db.SaveChanges();
            }

            txtComment.Clear();
            LoadComments();
        }
    }
}
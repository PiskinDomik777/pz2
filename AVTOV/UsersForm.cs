using System;
using System.Linq;
using System.Windows.Forms;
using AVTOV.Models;

namespace AVTOV
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            using (var db = new Ispr2524LinkovNIAvtooContext())
            {
                var data = db.Users
                    .Select(x => new
                    {
                        x.UserId,
                        x.Fio,
                        x.Phone,
                        x.Login,
                        x.Password,
                        x.Type
                    })
                    .ToList();

                dgvUsers.DataSource = data;
            }
        }
    }
}
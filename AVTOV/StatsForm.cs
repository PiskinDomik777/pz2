using System;
using System.Linq;
using System.Windows.Forms;
using AVTOV.Models;

namespace AVTOV
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            using (var db = new Ispr2524LinkovNIAvtooContext())
            {
                int completedCount = db.Requests.Count(x => x.RequestStatus == "Готова к выдаче");

                var completedRequests = db.Requests
                    .Where(x => x.CompletionDate != null)
                    .ToList();

                double avgDays = 0;
                if (completedRequests.Any())
                {
                    avgDays = completedRequests.Average(x =>
                        x.CompletionDate!.Value.DayNumber - x.StartDate.DayNumber);
                }

                var stats = db.Requests
                    .GroupBy(x => x.ProblemDescryption)
                    .Select(x => new
                    {
                        Проблема = x.Key,
                        Количество = x.Count()
                    })
                    .ToList();

                lblCompleted.Text = "Количество выполненных заявок: " + completedCount;
                lblAverage.Text = "Среднее время выполнения: " + avgDays.ToString("F2") + " дней";
                dgvStats.DataSource = stats;
            }
        }
    }
}
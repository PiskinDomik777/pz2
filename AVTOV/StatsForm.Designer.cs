namespace AVTOV
{
    partial class StatsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.DataGridView dgvStats;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCompleted = new Label();
            lblAverage = new Label();
            dgvStats = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            SuspendLayout();
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(18, 18);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(258, 20);
            lblCompleted.TabIndex = 0;
            lblCompleted.Text = "Количество выполненных заявок: 0";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(18, 48);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(261, 20);
            lblAverage.TabIndex = 1;
            lblAverage.Text = "Среднее время выполнения: 0 дней";
            // 
            // dgvStats
            // 
            dgvStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStats.Location = new Point(21, 82);
            dgvStats.Name = "dgvStats";
            dgvStats.RowHeadersWidth = 51;
            dgvStats.RowTemplate.Height = 24;
            dgvStats.Size = new Size(532, 136);
            dgvStats.TabIndex = 2;
            // 
            // StatsForm
            // 
            ClientSize = new Size(575, 243);
            Controls.Add(dgvStats);
            Controls.Add(lblAverage);
            Controls.Add(lblCompleted);
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += StatsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
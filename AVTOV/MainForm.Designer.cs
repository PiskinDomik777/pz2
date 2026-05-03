namespace AVTOV
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnEditRequest;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvRequests;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtSearch = new TextBox();
            cmbStatus = new ComboBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnAddRequest = new Button();
            btnEditRequest = new Button();
            btnComments = new Button();
            btnStats = new Button();
            btnUsers = new Button();
            btnExit = new Button();
            dgvRequests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(478, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Учет заявок на ремонт автомобилей";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 53);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 27);
            txtSearch.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Все статусы", "Новая заявка", "В процессе ремонта", "Готова к выдаче", "Ожидание автозапчастей" });
            cmbStatus.Location = new Point(671, 53);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(221, 28);
            cmbStatus.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(334, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 28);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(511, 52);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(91, 28);
            btnReset.TabIndex = 4;
            btnReset.Text = "Сброс";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAddRequest
            // 
            btnAddRequest.Location = new Point(12, 338);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(160, 33);
            btnAddRequest.TabIndex = 5;
            btnAddRequest.Text = "Добавить заявку";
            btnAddRequest.UseVisualStyleBackColor = true;
            btnAddRequest.Click += btnAddRequest_Click;
            // 
            // btnEditRequest
            // 
            btnEditRequest.Location = new Point(178, 338);
            btnEditRequest.Name = "btnEditRequest";
            btnEditRequest.Size = new Size(170, 33);
            btnEditRequest.TabIndex = 6;
            btnEditRequest.Text = "Редактировать";
            btnEditRequest.UseVisualStyleBackColor = true;
            btnEditRequest.Click += btnEditRequest_Click;
            // 
            // btnComments
            // 
            btnComments.Location = new Point(354, 338);
            btnComments.Name = "btnComments";
            btnComments.Size = new Size(151, 33);
            btnComments.TabIndex = 7;
            btnComments.Text = "Комментарии";
            btnComments.UseVisualStyleBackColor = true;
            btnComments.Click += btnComments_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(511, 338);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(117, 33);
            btnStats.TabIndex = 8;
            btnStats.Text = "Статистика";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(634, 338);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(142, 33);
            btnUsers.TabIndex = 9;
            btnUsers.Text = "Пользователи";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(795, 477);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 33);
            btnExit.TabIndex = 10;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(17, 86);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.RowTemplate.Height = 24;
            dgvRequests.Size = new Size(875, 246);
            dgvRequests.TabIndex = 11;
            // 
            // MainForm
            // 
            ClientSize = new Size(912, 522);
            Controls.Add(dgvRequests);
            Controls.Add(btnExit);
            Controls.Add(btnUsers);
            Controls.Add(btnStats);
            Controls.Add(btnComments);
            Controls.Add(btnEditRequest);
            Controls.Add(btnAddRequest);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(cmbStatus);
            Controls.Add(txtSearch);
            Controls.Add(lblTitle);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
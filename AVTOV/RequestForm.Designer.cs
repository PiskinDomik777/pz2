namespace AVTOV
{
    partial class RequestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRequestNumber;
        private System.Windows.Forms.TextBox txtRequestNumber;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.DateTimePicker dtpCompletionDate;
        private System.Windows.Forms.Label lblRepairParts;
        private System.Windows.Forms.TextBox txtRepairParts;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.ComboBox cmbMaster;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblRequestNumber = new Label();
            txtRequestNumber = new TextBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblCarType = new Label();
            txtCarType = new TextBox();
            lblCarModel = new Label();
            txtCarModel = new TextBox();
            lblProblem = new Label();
            txtProblem = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblCompletionDate = new Label();
            dtpCompletionDate = new DateTimePicker();
            lblRepairParts = new Label();
            txtRepairParts = new TextBox();
            lblMaster = new Label();
            cmbMaster = new ComboBox();
            lblClientId = new Label();
            txtClientId = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblRequestNumber
            // 
            lblRequestNumber.AutoSize = true;
            lblRequestNumber.Location = new Point(24, 25);
            lblRequestNumber.Name = "lblRequestNumber";
            lblRequestNumber.Size = new Size(77, 20);
            lblRequestNumber.TabIndex = 0;
            lblRequestNumber.Text = "№ заявки";
            // 
            // txtRequestNumber
            // 
            txtRequestNumber.Location = new Point(27, 49);
            txtRequestNumber.Margin = new Padding(3, 4, 3, 4);
            txtRequestNumber.Name = "txtRequestNumber";
            txtRequestNumber.ReadOnly = true;
            txtRequestNumber.Size = new Size(220, 27);
            txtRequestNumber.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(24, 80);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(129, 20);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Дата добавления";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(27, 104);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(220, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // lblCarType
            // 
            lblCarType.AutoSize = true;
            lblCarType.Location = new Point(24, 135);
            lblCarType.Name = "lblCarType";
            lblCarType.Size = new Size(70, 20);
            lblCarType.TabIndex = 4;
            lblCarType.Text = "Вид авто";
            // 
            // txtCarType
            // 
            txtCarType.Location = new Point(27, 159);
            txtCarType.Margin = new Padding(3, 4, 3, 4);
            txtCarType.Name = "txtCarType";
            txtCarType.Size = new Size(220, 27);
            txtCarType.TabIndex = 5;
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Location = new Point(24, 190);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(98, 20);
            lblCarModel.TabIndex = 6;
            lblCarModel.Text = "Модель авто";
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(27, 214);
            txtCarModel.Margin = new Padding(3, 4, 3, 4);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(442, 27);
            txtCarModel.TabIndex = 7;
            // 
            // lblProblem
            // 
            lblProblem.AutoSize = true;
            lblProblem.Location = new Point(24, 245);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new Size(157, 20);
            lblProblem.TabIndex = 8;
            lblProblem.Text = "Описание проблемы";
            // 
            // txtProblem
            // 
            txtProblem.Location = new Point(27, 269);
            txtProblem.Margin = new Padding(3, 4, 3, 4);
            txtProblem.Multiline = true;
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new Size(442, 62);
            txtProblem.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(24, 335);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Статус";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(27, 359);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(220, 28);
            cmbStatus.TabIndex = 11;
            // 
            // lblCompletionDate
            // 
            lblCompletionDate.AutoSize = true;
            lblCompletionDate.Location = new Point(267, 335);
            lblCompletionDate.Name = "lblCompletionDate";
            lblCompletionDate.Size = new Size(131, 20);
            lblCompletionDate.TabIndex = 12;
            lblCompletionDate.Text = "Дата завершения";
            // 
            // dtpCompletionDate
            // 
            dtpCompletionDate.Location = new Point(267, 360);
            dtpCompletionDate.Margin = new Padding(3, 4, 3, 4);
            dtpCompletionDate.Name = "dtpCompletionDate";
            dtpCompletionDate.Size = new Size(199, 27);
            dtpCompletionDate.TabIndex = 13;
            // 
            // lblRepairParts
            // 
            lblRepairParts.AutoSize = true;
            lblRepairParts.Location = new Point(24, 391);
            lblRepairParts.Name = "lblRepairParts";
            lblRepairParts.Size = new Size(175, 20);
            lblRepairParts.TabIndex = 14;
            lblRepairParts.Text = "Необходимые запчасти";
            // 
            // txtRepairParts
            // 
            txtRepairParts.Location = new Point(27, 415);
            txtRepairParts.Margin = new Padding(3, 4, 3, 4);
            txtRepairParts.Multiline = true;
            txtRepairParts.Name = "txtRepairParts";
            txtRepairParts.Size = new Size(442, 76);
            txtRepairParts.TabIndex = 15;
            // 
            // lblMaster
            // 
            lblMaster.AutoSize = true;
            lblMaster.Location = new Point(24, 495);
            lblMaster.Name = "lblMaster";
            lblMaster.Size = new Size(101, 20);
            lblMaster.TabIndex = 16;
            lblMaster.Text = "Автомеханик";
            // 
            // cmbMaster
            // 
            cmbMaster.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaster.FormattingEnabled = true;
            cmbMaster.Location = new Point(27, 519);
            cmbMaster.Margin = new Padding(3, 4, 3, 4);
            cmbMaster.Name = "cmbMaster";
            cmbMaster.Size = new Size(220, 28);
            cmbMaster.TabIndex = 17;
            // 
            // lblClientId
            // 
            lblClientId.AutoSize = true;
            lblClientId.Location = new Point(267, 495);
            lblClientId.Name = "lblClientId";
            lblClientId.Size = new Size(83, 20);
            lblClientId.TabIndex = 18;
            lblClientId.Text = "ID клиента";
            // 
            // txtClientId
            // 
            txtClientId.Location = new Point(267, 519);
            txtClientId.Margin = new Padding(3, 4, 3, 4);
            txtClientId.Name = "txtClientId";
            txtClientId.Size = new Size(199, 27);
            txtClientId.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(27, 555);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(442, 42);
            btnSave.TabIndex = 20;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 618);
            Controls.Add(btnSave);
            Controls.Add(txtClientId);
            Controls.Add(lblClientId);
            Controls.Add(cmbMaster);
            Controls.Add(lblMaster);
            Controls.Add(txtRepairParts);
            Controls.Add(lblRepairParts);
            Controls.Add(dtpCompletionDate);
            Controls.Add(lblCompletionDate);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtProblem);
            Controls.Add(lblProblem);
            Controls.Add(txtCarModel);
            Controls.Add(lblCarModel);
            Controls.Add(txtCarType);
            Controls.Add(lblCarType);
            Controls.Add(dtpStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(txtRequestNumber);
            Controls.Add(lblRequestNumber);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заявка";
            Load += RequestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
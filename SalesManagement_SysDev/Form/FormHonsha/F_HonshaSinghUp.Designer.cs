namespace SalesManagement_SysDev
{
    partial class F_HonshaSinghUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSinghup = new System.Windows.Forms.Label();
            this.pnlHonsha = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.lblClientFax = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txbSinghUpPass = new System.Windows.Forms.TextBox();
            this.lblCilentPhone = new System.Windows.Forms.Label();
            this.txbSinghUpPhone = new System.Windows.Forms.TextBox();
            this.lblSalesOfficeID = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbPositionID = new System.Windows.Forms.ComboBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.txbEmployeeID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.pnlHonsha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSinghup
            // 
            this.lblSinghup.AutoSize = true;
            this.lblSinghup.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSinghup.ForeColor = System.Drawing.Color.White;
            this.lblSinghup.Location = new System.Drawing.Point(758, 38);
            this.lblSinghup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinghup.Name = "lblSinghup";
            this.lblSinghup.Size = new System.Drawing.Size(288, 64);
            this.lblSinghup.TabIndex = 23;
            this.lblSinghup.Text = "新規登録";
            // 
            // pnlHonsha
            // 
            this.pnlHonsha.BackColor = System.Drawing.Color.Lime;
            this.pnlHonsha.Controls.Add(this.pctHint);
            this.pnlHonsha.Controls.Add(this.btnClose);
            this.pnlHonsha.Controls.Add(this.lblSinghup);
            this.pnlHonsha.Controls.Add(this.btnReturn);
            this.pnlHonsha.Location = new System.Drawing.Point(1, -1);
            this.pnlHonsha.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHonsha.Name = "pnlHonsha";
            this.pnlHonsha.Size = new System.Drawing.Size(1920, 150);
            this.pnlHonsha.TabIndex = 54;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnClose.Location = new System.Drawing.Point(1707, 38);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(34, 38);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(739, 738);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(570, 620);
            this.cmbSalesOfficeID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(220, 32);
            this.cmbSalesOfficeID.TabIndex = 52;
            // 
            // lblClientFax
            // 
            this.lblClientFax.AutoSize = true;
            this.lblClientFax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientFax.Location = new System.Drawing.Point(383, 620);
            this.lblClientFax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientFax.Name = "lblClientFax";
            this.lblClientFax.Size = new System.Drawing.Size(106, 24);
            this.lblClientFax.TabIndex = 46;
            this.lblClientFax.Text = "営業所名";
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientAddress.Location = new System.Drawing.Point(386, 499);
            this.lblClientAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(103, 24);
            this.lblClientAddress.TabIndex = 44;
            this.lblClientAddress.Text = "パスワード";
            // 
            // txbSinghUpPass
            // 
            this.txbSinghUpPass.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSinghUpPass.Location = new System.Drawing.Point(570, 493);
            this.txbSinghUpPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbSinghUpPass.Name = "txbSinghUpPass";
            this.txbSinghUpPass.Size = new System.Drawing.Size(220, 31);
            this.txbSinghUpPass.TabIndex = 43;
            // 
            // lblCilentPhone
            // 
            this.lblCilentPhone.AutoSize = true;
            this.lblCilentPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCilentPhone.Location = new System.Drawing.Point(963, 623);
            this.lblCilentPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCilentPhone.Name = "lblCilentPhone";
            this.lblCilentPhone.Size = new System.Drawing.Size(106, 24);
            this.lblCilentPhone.TabIndex = 41;
            this.lblCilentPhone.Text = "電話番号";
            // 
            // txbSinghUpPhone
            // 
            this.txbSinghUpPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSinghUpPhone.Location = new System.Drawing.Point(1136, 620);
            this.txbSinghUpPhone.Name = "txbSinghUpPhone";
            this.txbSinghUpPhone.Size = new System.Drawing.Size(220, 31);
            this.txbSinghUpPhone.TabIndex = 39;
            // 
            // lblSalesOfficeID
            // 
            this.lblSalesOfficeID.AutoSize = true;
            this.lblSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSalesOfficeID.Location = new System.Drawing.Point(993, 369);
            this.lblSalesOfficeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesOfficeID.Name = "lblSalesOfficeID";
            this.lblSalesOfficeID.Size = new System.Drawing.Size(82, 24);
            this.lblSalesOfficeID.TabIndex = 38;
            this.lblSalesOfficeID.Text = "役職名";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientName.Location = new System.Drawing.Point(413, 369);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(82, 24);
            this.lblClientName.TabIndex = 36;
            this.lblClientName.Text = "社員名";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeName.Location = new System.Drawing.Point(570, 366);
            this.txbEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeName.TabIndex = 35;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientID.Location = new System.Drawing.Point(933, 496);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(130, 24);
            this.lblClientID.TabIndex = 34;
            this.lblClientID.Text = "入社年月日";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1019, 738);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 51;
            this.btnDone.Text = "登録";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbPositionID
            // 
            this.cmbPositionID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbPositionID.ForeColor = System.Drawing.Color.Black;
            this.cmbPositionID.FormattingEnabled = true;
            this.cmbPositionID.Location = new System.Drawing.Point(1136, 366);
            this.cmbPositionID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPositionID.Name = "cmbPositionID";
            this.cmbPositionID.Size = new System.Drawing.Size(220, 32);
            this.cmbPositionID.TabIndex = 55;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpHireDate.Location = new System.Drawing.Point(1136, 493);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(220, 29);
            this.dtpHireDate.TabIndex = 56;
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeID.Location = new System.Drawing.Point(570, 237);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeID.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(413, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "社員ID";
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1620, 42);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 61;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // F_HonshaSinghUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmployeeID);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.cmbPositionID);
            this.Controls.Add(this.pnlHonsha);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.lblClientFax);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txbSinghUpPass);
            this.Controls.Add(this.lblCilentPhone);
            this.Controls.Add(this.txbSinghUpPhone);
            this.Controls.Add(this.lblSalesOfficeID);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.btnDone);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "F_HonshaSinghUp";
            this.Text = "F_HonshaSinghUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_HonshaSinghUp_Load);
            this.pnlHonsha.ResumeLayout(false);
            this.pnlHonsha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSinghup;
        private System.Windows.Forms.Panel pnlHonsha;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.Label lblClientFax;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox txbSinghUpPass;
        private System.Windows.Forms.Label lblCilentPhone;
        private System.Windows.Forms.TextBox txbSinghUpPhone;
        private System.Windows.Forms.Label lblSalesOfficeID;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbPositionID;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.MaskedTextBox txbEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctHint;
    }
}
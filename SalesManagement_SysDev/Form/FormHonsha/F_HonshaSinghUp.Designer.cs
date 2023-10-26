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
            this.lblClient = new System.Windows.Forms.Label();
            this.pnlHonsha = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.txbClientFAX = new System.Windows.Forms.TextBox();
            this.lblClientFax = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txbClientPostal = new System.Windows.Forms.TextBox();
            this.lblClientPostal = new System.Windows.Forms.Label();
            this.lblCilentPhone = new System.Windows.Forms.Label();
            this.txbClientPhone = new System.Windows.Forms.TextBox();
            this.lblSalesOfficeID = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.pnlHonsha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(470, 21);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(195, 43);
            this.lblClient.TabIndex = 23;
            this.lblClient.Text = "新規登録";
            this.lblClient.Click += new System.EventHandler(this.lblClient_Click);
            // 
            // pnlHonsha
            // 
            this.pnlHonsha.BackColor = System.Drawing.Color.Lime;
            this.pnlHonsha.Controls.Add(this.lblClient);
            this.pnlHonsha.Controls.Add(this.btnReturn);
            this.pnlHonsha.Location = new System.Drawing.Point(-9, -19);
            this.pnlHonsha.Name = "pnlHonsha";
            this.pnlHonsha.Size = new System.Drawing.Size(1230, 90);
            this.pnlHonsha.TabIndex = 54;
            this.pnlHonsha.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHonsha_Paint);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(15, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 50);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(412, 585);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 50);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(333, 479);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(150, 26);
            this.cmbHidden.TabIndex = 52;
            this.cmbHidden.SelectedIndexChanged += new System.EventHandler(this.cmbHidden_SelectedIndexChanged);
            // 
            // txbClientFAX
            // 
            this.txbClientFAX.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientFAX.Location = new System.Drawing.Point(647, 378);
            this.txbClientFAX.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientFAX.Name = "txbClientFAX";
            this.txbClientFAX.Size = new System.Drawing.Size(150, 25);
            this.txbClientFAX.TabIndex = 47;
            this.txbClientFAX.TextChanged += new System.EventHandler(this.txbClientFAX_TextChanged);
            // 
            // lblClientFax
            // 
            this.lblClientFax.AutoSize = true;
            this.lblClientFax.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientFax.Location = new System.Drawing.Point(909, 228);
            this.lblClientFax.Name = "lblClientFax";
            this.lblClientFax.Size = new System.Drawing.Size(42, 19);
            this.lblClientFax.TabIndex = 46;
            this.lblClientFax.Text = "FAX";
            this.lblClientFax.Click += new System.EventHandler(this.lblClientFax_Click);
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientAddress.Location = new System.Drawing.Point(263, 232);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(47, 19);
            this.lblClientAddress.TabIndex = 44;
            this.lblClientAddress.Text = "住所";
            this.lblClientAddress.Click += new System.EventHandler(this.lblClientAddress_Click);
            // 
            // txbClientPostal
            // 
            this.txbClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientPostal.Location = new System.Drawing.Point(333, 378);
            this.txbClientPostal.Name = "txbClientPostal";
            this.txbClientPostal.Size = new System.Drawing.Size(150, 25);
            this.txbClientPostal.TabIndex = 43;
            this.txbClientPostal.TextChanged += new System.EventHandler(this.txbClientPostal_TextChanged);
            // 
            // lblClientPostal
            // 
            this.lblClientPostal.AutoSize = true;
            this.lblClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientPostal.Location = new System.Drawing.Point(3, 236);
            this.lblClientPostal.Name = "lblClientPostal";
            this.lblClientPostal.Size = new System.Drawing.Size(85, 19);
            this.lblClientPostal.TabIndex = 42;
            this.lblClientPostal.Text = "郵便番号";
            this.lblClientPostal.Click += new System.EventHandler(this.lblClientPostal_Click);
            // 
            // lblCilentPhone
            // 
            this.lblCilentPhone.AutoSize = true;
            this.lblCilentPhone.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCilentPhone.Location = new System.Drawing.Point(904, 162);
            this.lblCilentPhone.Name = "lblCilentPhone";
            this.lblCilentPhone.Size = new System.Drawing.Size(85, 19);
            this.lblCilentPhone.TabIndex = 41;
            this.lblCilentPhone.Text = "電話番号";
            this.lblCilentPhone.Click += new System.EventHandler(this.lblCilentPhone_Click);
            // 
            // txbClientPhone
            // 
            this.txbClientPhone.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientPhone.Location = new System.Drawing.Point(647, 491);
            this.txbClientPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientPhone.Name = "txbClientPhone";
            this.txbClientPhone.Size = new System.Drawing.Size(150, 25);
            this.txbClientPhone.TabIndex = 39;
            this.txbClientPhone.TextChanged += new System.EventHandler(this.txbClientPhone_TextChanged);
            // 
            // lblSalesOfficeID
            // 
            this.lblSalesOfficeID.AutoSize = true;
            this.lblSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSalesOfficeID.Location = new System.Drawing.Point(569, 161);
            this.lblSalesOfficeID.Name = "lblSalesOfficeID";
            this.lblSalesOfficeID.Size = new System.Drawing.Size(83, 19);
            this.lblSalesOfficeID.TabIndex = 38;
            this.lblSalesOfficeID.Text = "営業所ID";
            this.lblSalesOfficeID.Click += new System.EventHandler(this.lblSalesOfficeID_Click);
            // 
            // txbClientName
            // 
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientName.Location = new System.Drawing.Point(647, 251);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.Size = new System.Drawing.Size(150, 25);
            this.txbClientName.TabIndex = 37;
            this.txbClientName.TextChanged += new System.EventHandler(this.txbClientName_TextChanged);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientName.Location = new System.Drawing.Point(263, 162);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(66, 19);
            this.lblClientName.TabIndex = 36;
            this.lblClientName.Text = "顧客名";
            this.lblClientName.Click += new System.EventHandler(this.lblClientName_Click);
            // 
            // txbClientID
            // 
            this.txbClientID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientID.Location = new System.Drawing.Point(333, 251);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(150, 25);
            this.txbClientID.TabIndex = 35;
            this.txbClientID.TextChanged += new System.EventHandler(this.txbClientID_TextChanged);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientID.Location = new System.Drawing.Point(3, 162);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(64, 19);
            this.lblClientID.TabIndex = 34;
            this.lblClientID.Text = "顧客ID";
            this.lblClientID.Click += new System.EventHandler(this.lblClientID_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(647, 585);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(110, 50);
            this.btnDone.TabIndex = 51;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // F_HonshaSinghUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 753);
            this.Controls.Add(this.pnlHonsha);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.txbClientFAX);
            this.Controls.Add(this.lblClientFax);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txbClientPostal);
            this.Controls.Add(this.lblClientPostal);
            this.Controls.Add(this.lblCilentPhone);
            this.Controls.Add(this.txbClientPhone);
            this.Controls.Add(this.lblSalesOfficeID);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txbClientID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.btnDone);
            this.Name = "F_HonshaSinghUp";
            this.Text = "F_HonshaSinghUp";
            this.pnlHonsha.ResumeLayout(false);
            this.pnlHonsha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel pnlHonsha;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.TextBox txbClientFAX;
        private System.Windows.Forms.Label lblClientFax;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox txbClientPostal;
        private System.Windows.Forms.Label lblClientPostal;
        private System.Windows.Forms.Label lblCilentPhone;
        private System.Windows.Forms.TextBox txbClientPhone;
        private System.Windows.Forms.Label lblSalesOfficeID;
        private System.Windows.Forms.TextBox txbClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txbClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnDone;
    }
}
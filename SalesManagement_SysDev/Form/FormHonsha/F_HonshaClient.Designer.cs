namespace SalesManagement_SysDev
{
    partial class F_HonshaClient
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbRegister = new System.Windows.Forms.RadioButton();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.lblSalesOfficeID = new System.Windows.Forms.Label();
            this.txbCilentPhone = new System.Windows.Forms.TextBox();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.lblCilentPhone = new System.Windows.Forms.Label();
            this.lblClientPostal = new System.Windows.Forms.Label();
            this.txbClientPostal = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txbClientAddress = new System.Windows.Forms.TextBox();
            this.lblClientFax = new System.Windows.Forms.Label();
            this.txbClientFax = new System.Windows.Forms.TextBox();
            this.lblClientHidden = new System.Windows.Forms.Label();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(15, 14);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(118, 46);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlSelect.Controls.Add(this.rdbSearch);
            this.pnlSelect.Controls.Add(this.rdbUpdate);
            this.pnlSelect.Controls.Add(this.rdbRegister);
            this.pnlSelect.Location = new System.Drawing.Point(198, 14);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(335, 44);
            this.pnlSelect.TabIndex = 1;
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(231, 10);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(79, 26);
            this.rdbSearch.TabIndex = 2;
            this.rdbSearch.TabStop = true;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(121, 10);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(79, 26);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbRegister
            // 
            this.rdbRegister.AutoSize = true;
            this.rdbRegister.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbRegister.Location = new System.Drawing.Point(19, 10);
            this.rdbRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbRegister.Name = "rdbRegister";
            this.rdbRegister.Size = new System.Drawing.Size(79, 26);
            this.rdbRegister.TabIndex = 0;
            this.rdbRegister.TabStop = true;
            this.rdbRegister.Text = "登録";
            this.rdbRegister.UseVisualStyleBackColor = true;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientID.Location = new System.Drawing.Point(16, 95);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(73, 22);
            this.lblClientID.TabIndex = 2;
            this.lblClientID.Text = "顧客ID";
            // 
            // txbClientID
            // 
            this.txbClientID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientID.Location = new System.Drawing.Point(99, 91);
            this.txbClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(124, 29);
            this.txbClientID.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientName.Location = new System.Drawing.Point(286, 95);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(76, 22);
            this.lblClientName.TabIndex = 4;
            this.lblClientName.Text = "顧客名";
            // 
            // txbClientName
            // 
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientName.Location = new System.Drawing.Point(371, 91);
            this.txbClientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.Size = new System.Drawing.Size(183, 29);
            this.txbClientName.TabIndex = 5;
            // 
            // lblSalesOfficeID
            // 
            this.lblSalesOfficeID.AutoSize = true;
            this.lblSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSalesOfficeID.Location = new System.Drawing.Point(606, 95);
            this.lblSalesOfficeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesOfficeID.Name = "lblSalesOfficeID";
            this.lblSalesOfficeID.Size = new System.Drawing.Size(95, 22);
            this.lblSalesOfficeID.TabIndex = 6;
            this.lblSalesOfficeID.Text = "営業所ID";
            // 
            // txbCilentPhone
            // 
            this.txbCilentPhone.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbCilentPhone.Location = new System.Drawing.Point(1084, 91);
            this.txbCilentPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCilentPhone.Name = "txbCilentPhone";
            this.txbCilentPhone.Size = new System.Drawing.Size(183, 29);
            this.txbCilentPhone.TabIndex = 7;
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Items.AddRange(new object[] {
            "北大阪営業所",
            "兵庫営業所",
            "鹿営業所",
            "京都営業所",
            "和歌山営業所"});
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(711, 91);
            this.cmbSalesOfficeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(194, 30);
            this.cmbSalesOfficeID.TabIndex = 8;
            // 
            // lblCilentPhone
            // 
            this.lblCilentPhone.AutoSize = true;
            this.lblCilentPhone.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCilentPhone.Location = new System.Drawing.Point(976, 95);
            this.lblCilentPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCilentPhone.Name = "lblCilentPhone";
            this.lblCilentPhone.Size = new System.Drawing.Size(98, 22);
            this.lblCilentPhone.TabIndex = 9;
            this.lblCilentPhone.Text = "電話番号";
            // 
            // lblClientPostal
            // 
            this.lblClientPostal.AutoSize = true;
            this.lblClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientPostal.Location = new System.Drawing.Point(16, 145);
            this.lblClientPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientPostal.Name = "lblClientPostal";
            this.lblClientPostal.Size = new System.Drawing.Size(98, 22);
            this.lblClientPostal.TabIndex = 10;
            this.lblClientPostal.Text = "郵便番号";
            // 
            // txbClientPostal
            // 
            this.txbClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientPostal.Location = new System.Drawing.Point(124, 142);
            this.txbClientPostal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbClientPostal.Name = "txbClientPostal";
            this.txbClientPostal.Size = new System.Drawing.Size(124, 29);
            this.txbClientPostal.TabIndex = 11;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientAddress.Location = new System.Drawing.Point(286, 145);
            this.lblClientAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(54, 22);
            this.lblClientAddress.TabIndex = 12;
            this.lblClientAddress.Text = "住所";
            // 
            // txbClientAddress
            // 
            this.txbClientAddress.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientAddress.Location = new System.Drawing.Point(371, 142);
            this.txbClientAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbClientAddress.Name = "txbClientAddress";
            this.txbClientAddress.Size = new System.Drawing.Size(534, 29);
            this.txbClientAddress.TabIndex = 13;
            // 
            // lblClientFax
            // 
            this.lblClientFax.AutoSize = true;
            this.lblClientFax.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientFax.Location = new System.Drawing.Point(976, 145);
            this.lblClientFax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientFax.Name = "lblClientFax";
            this.lblClientFax.Size = new System.Drawing.Size(49, 22);
            this.lblClientFax.TabIndex = 14;
            this.lblClientFax.Text = "FAX";
            // 
            // txbClientFax
            // 
            this.txbClientFax.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientFax.Location = new System.Drawing.Point(1084, 142);
            this.txbClientFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbClientFax.Name = "txbClientFax";
            this.txbClientFax.Size = new System.Drawing.Size(183, 29);
            this.txbClientFax.TabIndex = 15;
            // 
            // lblClientHidden
            // 
            this.lblClientHidden.AutoSize = true;
            this.lblClientHidden.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientHidden.Location = new System.Drawing.Point(286, 193);
            this.lblClientHidden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientHidden.Name = "lblClientHidden";
            this.lblClientHidden.Size = new System.Drawing.Size(120, 22);
            this.lblClientHidden.TabIndex = 16;
            this.lblClientHidden.Text = "非表示理由";
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbHidden.Location = new System.Drawing.Point(416, 190);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(850, 29);
            this.txbHidden.TabIndex = 17;
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(15, 235);
            this.dgvClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(1302, 343);
            this.dgvClient.TabIndex = 18;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordEditing_CellClick);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1200, 14);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(118, 46);
            this.btnDone.TabIndex = 19;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbHidden
            // 
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(20, 188);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(194, 30);
            this.cmbHidden.TabIndex = 20;
            // 
            // F_HonshaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 593);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblClientHidden);
            this.Controls.Add(this.txbClientFax);
            this.Controls.Add(this.lblClientFax);
            this.Controls.Add(this.txbClientAddress);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txbClientPostal);
            this.Controls.Add(this.lblClientPostal);
            this.Controls.Add(this.lblCilentPhone);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.txbCilentPhone);
            this.Controls.Add(this.lblSalesOfficeID);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txbClientID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_HonshaClient";
            this.Text = "F_Client";
            this.Load += new System.EventHandler(this.F_HonshaClient_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbRegister;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txbClientID;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txbClientName;
        private System.Windows.Forms.Label lblSalesOfficeID;
        private System.Windows.Forms.TextBox txbCilentPhone;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.Label lblCilentPhone;
        private System.Windows.Forms.Label lblClientPostal;
        private System.Windows.Forms.TextBox txbClientPostal;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox txbClientAddress;
        private System.Windows.Forms.Label lblClientFax;
        private System.Windows.Forms.TextBox txbClientFax;
        private System.Windows.Forms.Label lblClientHidden;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbHidden;
    }
}
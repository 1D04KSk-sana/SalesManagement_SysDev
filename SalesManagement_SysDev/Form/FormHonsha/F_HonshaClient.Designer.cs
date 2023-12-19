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
            this.txbClientPhone = new System.Windows.Forms.TextBox();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.lblCilentPhone = new System.Windows.Forms.Label();
            this.lblClientPostal = new System.Windows.Forms.Label();
            this.txbClientPostal = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txbClientAddress = new System.Windows.Forms.TextBox();
            this.lblClientFax = new System.Windows.Forms.Label();
            this.txbClientFAX = new System.Windows.Forms.TextBox();
            this.lblClientHidden = new System.Windows.Forms.Label();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlHonsha = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.lblHidden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.pnlHonsha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnReturn.Location = new System.Drawing.Point(20, 30);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 80);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSelect.Controls.Add(this.rdbSearch);
            this.pnlSelect.Controls.Add(this.rdbUpdate);
            this.pnlSelect.Controls.Add(this.rdbRegister);
            this.pnlSelect.Location = new System.Drawing.Point(12, 168);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(448, 74);
            this.pnlSelect.TabIndex = 1;
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbSearch.Location = new System.Drawing.Point(313, 16);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 2;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbUpdate.Location = new System.Drawing.Point(159, 15);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(103, 39);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.Text = "更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbRegister
            // 
            this.rdbRegister.AutoSize = true;
            this.rdbRegister.Checked = true;
            this.rdbRegister.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbRegister.Location = new System.Drawing.Point(29, 16);
            this.rdbRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbRegister.Name = "rdbRegister";
            this.rdbRegister.Size = new System.Drawing.Size(103, 39);
            this.rdbRegister.TabIndex = 0;
            this.rdbRegister.TabStop = true;
            this.rdbRegister.Text = "登録";
            this.rdbRegister.UseVisualStyleBackColor = true;
            this.rdbRegister.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientID.Location = new System.Drawing.Point(70, 290);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(80, 24);
            this.lblClientID.TabIndex = 2;
            this.lblClientID.Text = "顧客ID";
            // 
            // txbClientID
            // 
            this.txbClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbClientID.Location = new System.Drawing.Point(240, 287);
            this.txbClientID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(220, 31);
            this.txbClientID.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientName.Location = new System.Drawing.Point(561, 290);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(82, 24);
            this.lblClientName.TabIndex = 4;
            this.lblClientName.Text = "顧客名";
            // 
            // txbClientName
            // 
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbClientName.Location = new System.Drawing.Point(712, 287);
            this.txbClientName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.Size = new System.Drawing.Size(220, 31);
            this.txbClientName.TabIndex = 5;
            // 
            // lblSalesOfficeID
            // 
            this.lblSalesOfficeID.AutoSize = true;
            this.lblSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblSalesOfficeID.Location = new System.Drawing.Point(1006, 290);
            this.lblSalesOfficeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesOfficeID.Name = "lblSalesOfficeID";
            this.lblSalesOfficeID.Size = new System.Drawing.Size(104, 24);
            this.lblSalesOfficeID.TabIndex = 6;
            this.lblSalesOfficeID.Text = "営業所ID";
            // 
            // txbClientPhone
            // 
            this.txbClientPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbClientPhone.Location = new System.Drawing.Point(1595, 287);
            this.txbClientPhone.Margin = new System.Windows.Forms.Padding(1);
            this.txbClientPhone.Name = "txbClientPhone";
            this.txbClientPhone.Size = new System.Drawing.Size(220, 31);
            this.txbClientPhone.TabIndex = 7;
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(1145, 287);
            this.cmbSalesOfficeID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(220, 32);
            this.cmbSalesOfficeID.TabIndex = 8;
            // 
            // lblCilentPhone
            // 
            this.lblCilentPhone.AutoSize = true;
            this.lblCilentPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblCilentPhone.Location = new System.Drawing.Point(1434, 290);
            this.lblCilentPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCilentPhone.Name = "lblCilentPhone";
            this.lblCilentPhone.Size = new System.Drawing.Size(106, 24);
            this.lblCilentPhone.TabIndex = 9;
            this.lblCilentPhone.Text = "電話番号";
            // 
            // lblClientPostal
            // 
            this.lblClientPostal.AutoSize = true;
            this.lblClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientPostal.Location = new System.Drawing.Point(52, 370);
            this.lblClientPostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientPostal.Name = "lblClientPostal";
            this.lblClientPostal.Size = new System.Drawing.Size(106, 24);
            this.lblClientPostal.TabIndex = 10;
            this.lblClientPostal.Text = "郵便番号";
            // 
            // txbClientPostal
            // 
            this.txbClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbClientPostal.Location = new System.Drawing.Point(240, 367);
            this.txbClientPostal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbClientPostal.Name = "txbClientPostal";
            this.txbClientPostal.Size = new System.Drawing.Size(220, 31);
            this.txbClientPostal.TabIndex = 11;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientAddress.Location = new System.Drawing.Point(585, 370);
            this.lblClientAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(58, 24);
            this.lblClientAddress.TabIndex = 12;
            this.lblClientAddress.Text = "住所";
            // 
            // txbClientAddress
            // 
            this.txbClientAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbClientAddress.Location = new System.Drawing.Point(712, 367);
            this.txbClientAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbClientAddress.Name = "txbClientAddress";
            this.txbClientAddress.Size = new System.Drawing.Size(653, 31);
            this.txbClientAddress.TabIndex = 13;
            // 
            // lblClientFax
            // 
            this.lblClientFax.Location = new System.Drawing.Point(0, 0);
            this.lblClientFax.Name = "lblClientFax";
            this.lblClientFax.Size = new System.Drawing.Size(100, 23);
            this.lblClientFax.TabIndex = 33;
            // 
            // txbClientFAX
            // 
            this.txbClientFAX.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbClientFAX.Location = new System.Drawing.Point(1595, 367);
            this.txbClientFAX.Margin = new System.Windows.Forms.Padding(1);
            this.txbClientFAX.Name = "txbClientFAX";
            this.txbClientFAX.Size = new System.Drawing.Size(220, 31);
            this.txbClientFAX.TabIndex = 15;
            // 
            // lblClientHidden
            // 
            this.lblClientHidden.AutoSize = true;
            this.lblClientHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientHidden.Location = new System.Drawing.Point(513, 453);
            this.lblClientHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientHidden.Name = "lblClientHidden";
            this.lblClientHidden.Size = new System.Drawing.Size(130, 24);
            this.lblClientHidden.TabIndex = 16;
            this.lblClientHidden.Text = "非表示理由";
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbHidden.Location = new System.Drawing.Point(712, 450);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(1103, 31);
            this.txbHidden.TabIndex = 17;
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvClient.Location = new System.Drawing.Point(9, 528);
            this.dgvClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(1900, 495);
            this.dgvClient.TabIndex = 18;
            this.dgvClient.TabStop = false;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordEditing_CellClick);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.btnDone.Location = new System.Drawing.Point(1740, 168);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 19;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(240, 450);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 20;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.btnClear.Location = new System.Drawing.Point(1545, 168);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlHonsha
            // 
            this.pnlHonsha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(112)))));
            this.pnlHonsha.Controls.Add(this.pctHint);
            this.pnlHonsha.Controls.Add(this.btnClose);
            this.pnlHonsha.Controls.Add(this.lblClient);
            this.pnlHonsha.Controls.Add(this.btnReturn);
            this.pnlHonsha.Location = new System.Drawing.Point(1, 1);
            this.pnlHonsha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHonsha.Name = "pnlHonsha";
            this.pnlHonsha.Size = new System.Drawing.Size(1920, 150);
            this.pnlHonsha.TabIndex = 22;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1632, 46);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 34;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1725, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 26;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClient.ForeColor = System.Drawing.Color.Black;
            this.lblClient.Location = new System.Drawing.Point(816, 46);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(288, 64);
            this.lblClient.TabIndex = 23;
            this.lblClient.Text = "顧客管理";
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1156, 183);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 23;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbPageSize.Location = new System.Drawing.Point(148, 1038);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 29);
            this.txbPageSize.TabIndex = 24;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPageSizeID_KeyPress);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lblPageSize.Location = new System.Drawing.Point(17, 1041);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(119, 22);
            this.lblPageSize.TabIndex = 25;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // btnPageSize
            // 
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageSize.Location = new System.Drawing.Point(219, 1031);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 26;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = true;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageMax.Location = new System.Drawing.Point(1810, 1031);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 27;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnNext.Location = new System.Drawing.Point(1758, 1031);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnBack.Location = new System.Drawing.Point(1706, 1031);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageMin.Location = new System.Drawing.Point(1654, 1031);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 30;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbNumPage.Location = new System.Drawing.Point(1501, 1038);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(1);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 29);
            this.txbNumPage.TabIndex = 31;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumPage_KeyPress);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lblNumPage.Location = new System.Drawing.Point(1566, 1039);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(64, 22);
            this.lblNumPage.TabIndex = 32;
            this.lblNumPage.Text = "ページ";
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHidden.Location = new System.Drawing.Point(16, 453);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(142, 24);
            this.lblHidden.TabIndex = 125;
            this.lblHidden.Text = "表示/非表示";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(1488, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 126;
            this.label1.Text = "FAX";
            // 
            // F_HonshaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.pnlHonsha);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblClientHidden);
            this.Controls.Add(this.txbClientFAX);
            this.Controls.Add(this.lblClientFax);
            this.Controls.Add(this.txbClientAddress);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txbClientPostal);
            this.Controls.Add(this.lblClientPostal);
            this.Controls.Add(this.lblCilentPhone);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.txbClientPhone);
            this.Controls.Add(this.lblSalesOfficeID);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txbClientID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "F_HonshaClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_HonshaClient_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.pnlHonsha.ResumeLayout(false);
            this.pnlHonsha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
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
        private System.Windows.Forms.TextBox txbClientPhone;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.Label lblCilentPhone;
        private System.Windows.Forms.Label lblClientPostal;
        private System.Windows.Forms.TextBox txbClientPostal;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox txbClientAddress;
        private System.Windows.Forms.Label lblClientFax;
        private System.Windows.Forms.TextBox txbClientFAX;
        private System.Windows.Forms.Label lblClientHidden;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlHonsha;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctHint;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Label label1;
    }
}
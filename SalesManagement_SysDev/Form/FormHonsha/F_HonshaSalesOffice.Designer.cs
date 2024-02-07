
namespace SalesManagement_SysDev
{
    partial class F_HonshaSalesOffice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.lblSalesOffice = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbRegister = new System.Windows.Forms.RadioButton();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblClientHidden = new System.Windows.Forms.Label();
            this.txbSalesOfficeFAX = new System.Windows.Forms.TextBox();
            this.txbSalesOfficeAddress = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txbSalesOfficePostal = new System.Windows.Forms.TextBox();
            this.lblClientPostal = new System.Windows.Forms.Label();
            this.lblCilentPhone = new System.Windows.Forms.Label();
            this.txbSalesOfficePhone = new System.Windows.Forms.TextBox();
            this.lblSalesOfficeName = new System.Windows.Forms.Label();
            this.txbSalesOfficeID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSalesOffice = new System.Windows.Forms.DataGridView();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.txbSalesOfficeName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOffice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.pctHint);
            this.panel1.Controls.Add(this.lblSalesOffice);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1643, 43);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 56;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // lblSalesOffice
            // 
            this.lblSalesOffice.AutoSize = true;
            this.lblSalesOffice.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSalesOffice.ForeColor = System.Drawing.Color.Black;
            this.lblSalesOffice.Location = new System.Drawing.Point(778, 45);
            this.lblSalesOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesOffice.Name = "lblSalesOffice";
            this.lblSalesOffice.Size = new System.Drawing.Size(352, 64);
            this.lblSalesOffice.TabIndex = 24;
            this.lblSalesOffice.Text = "営業所管理";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnClose.Location = new System.Drawing.Point(1727, 39);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnReturn.Location = new System.Drawing.Point(40, 33);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseCompatibleTextRendering = true;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.pnlSelect.Controls.Add(this.rdbSearch);
            this.pnlSelect.Controls.Add(this.rdbUpdate);
            this.pnlSelect.Controls.Add(this.rdbRegister);
            this.pnlSelect.Location = new System.Drawing.Point(40, 199);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(577, 74);
            this.pnlSelect.TabIndex = 2;
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbSearch.Location = new System.Drawing.Point(424, 16);
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
            this.rdbUpdate.Location = new System.Drawing.Point(218, 16);
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
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1129, 218);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 26;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.btnClear.Location = new System.Drawing.Point(1518, 203);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 25;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.btnDone.Location = new System.Drawing.Point(1713, 203);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 24;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(257, 471);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 42;
            this.cmbHidden.TabStop = false;
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbHidden.Location = new System.Drawing.Point(707, 471);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(1076, 31);
            this.txbHidden.TabIndex = 41;
            this.txbHidden.TabStop = false;
            // 
            // lblClientHidden
            // 
            this.lblClientHidden.AutoSize = true;
            this.lblClientHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientHidden.Location = new System.Drawing.Point(556, 474);
            this.lblClientHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientHidden.Name = "lblClientHidden";
            this.lblClientHidden.Size = new System.Drawing.Size(130, 24);
            this.lblClientHidden.TabIndex = 40;
            this.lblClientHidden.Text = "非表示理由";
            // 
            // txbSalesOfficeFAX
            // 
            this.txbSalesOfficeFAX.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbSalesOfficeFAX.Location = new System.Drawing.Point(1514, 304);
            this.txbSalesOfficeFAX.Margin = new System.Windows.Forms.Padding(1);
            this.txbSalesOfficeFAX.Name = "txbSalesOfficeFAX";
            this.txbSalesOfficeFAX.Size = new System.Drawing.Size(220, 31);
            this.txbSalesOfficeFAX.TabIndex = 39;
            this.txbSalesOfficeFAX.TabStop = false;
            // 
            // txbSalesOfficeAddress
            // 
            this.txbSalesOfficeAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbSalesOfficeAddress.Location = new System.Drawing.Point(707, 388);
            this.txbSalesOfficeAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSalesOfficeAddress.Name = "txbSalesOfficeAddress";
            this.txbSalesOfficeAddress.Size = new System.Drawing.Size(653, 31);
            this.txbSalesOfficeAddress.TabIndex = 38;
            this.txbSalesOfficeAddress.TabStop = false;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientAddress.Location = new System.Drawing.Point(556, 391);
            this.lblClientAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(58, 24);
            this.lblClientAddress.TabIndex = 37;
            this.lblClientAddress.Text = "住所";
            // 
            // txbSalesOfficePostal
            // 
            this.txbSalesOfficePostal.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbSalesOfficePostal.Location = new System.Drawing.Point(257, 388);
            this.txbSalesOfficePostal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSalesOfficePostal.Name = "txbSalesOfficePostal";
            this.txbSalesOfficePostal.Size = new System.Drawing.Size(220, 31);
            this.txbSalesOfficePostal.TabIndex = 36;
            this.txbSalesOfficePostal.TabStop = false;
            // 
            // lblClientPostal
            // 
            this.lblClientPostal.AutoSize = true;
            this.lblClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientPostal.Location = new System.Drawing.Point(130, 391);
            this.lblClientPostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientPostal.Name = "lblClientPostal";
            this.lblClientPostal.Size = new System.Drawing.Size(106, 24);
            this.lblClientPostal.TabIndex = 35;
            this.lblClientPostal.Text = "郵便番号";
            // 
            // lblCilentPhone
            // 
            this.lblCilentPhone.AutoSize = true;
            this.lblCilentPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblCilentPhone.Location = new System.Drawing.Point(973, 311);
            this.lblCilentPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCilentPhone.Name = "lblCilentPhone";
            this.lblCilentPhone.Size = new System.Drawing.Size(106, 24);
            this.lblCilentPhone.TabIndex = 34;
            this.lblCilentPhone.Text = "電話番号";
            // 
            // txbSalesOfficePhone
            // 
            this.txbSalesOfficePhone.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbSalesOfficePhone.Location = new System.Drawing.Point(1107, 308);
            this.txbSalesOfficePhone.Margin = new System.Windows.Forms.Padding(1);
            this.txbSalesOfficePhone.Name = "txbSalesOfficePhone";
            this.txbSalesOfficePhone.Size = new System.Drawing.Size(220, 31);
            this.txbSalesOfficePhone.TabIndex = 32;
            this.txbSalesOfficePhone.TabStop = false;
            // 
            // lblSalesOfficeName
            // 
            this.lblSalesOfficeName.AutoSize = true;
            this.lblSalesOfficeName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblSalesOfficeName.Location = new System.Drawing.Point(545, 311);
            this.lblSalesOfficeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesOfficeName.Name = "lblSalesOfficeName";
            this.lblSalesOfficeName.Size = new System.Drawing.Size(106, 24);
            this.lblSalesOfficeName.TabIndex = 31;
            this.lblSalesOfficeName.Text = "営業所名";
            // 
            // txbSalesOfficeID
            // 
            this.txbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbSalesOfficeID.Location = new System.Drawing.Point(257, 308);
            this.txbSalesOfficeID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSalesOfficeID.Name = "txbSalesOfficeID";
            this.txbSalesOfficeID.Size = new System.Drawing.Size(220, 31);
            this.txbSalesOfficeID.TabIndex = 28;
            this.txbSalesOfficeID.TabStop = false;
            this.txbSalesOfficeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientID.Location = new System.Drawing.Point(130, 311);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(104, 24);
            this.lblClientID.TabIndex = 27;
            this.lblClientID.Text = "営業所ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(1433, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "FAX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(80, 479);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "非表示/表示";
            // 
            // dgvSalesOffice
            // 
            this.dgvSalesOffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOffice.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvSalesOffice.Location = new System.Drawing.Point(9, 522);
            this.dgvSalesOffice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvSalesOffice.Name = "dgvSalesOffice";
            this.dgvSalesOffice.RowHeadersWidth = 51;
            this.dgvSalesOffice.RowTemplate.Height = 24;
            this.dgvSalesOffice.Size = new System.Drawing.Size(1900, 495);
            this.dgvSalesOffice.TabIndex = 45;
            this.dgvSalesOffice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOffice_CellClick);
            // 
            // btnPageSize
            // 
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageSize.Location = new System.Drawing.Point(210, 1030);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 48;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = true;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lblPageSize.Location = new System.Drawing.Point(11, 1039);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(119, 22);
            this.lblPageSize.TabIndex = 47;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbPageSize.Location = new System.Drawing.Point(133, 1036);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 29);
            this.txbPageSize.TabIndex = 46;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lblNumPage.Location = new System.Drawing.Point(1555, 1038);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(64, 22);
            this.lblNumPage.TabIndex = 54;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Enabled = false;
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbNumPage.Location = new System.Drawing.Point(1490, 1037);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(1);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.ReadOnly = true;
            this.txbNumPage.Size = new System.Drawing.Size(50, 29);
            this.txbNumPage.TabIndex = 53;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageMin.Location = new System.Drawing.Point(1643, 1030);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 52;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnBack.Location = new System.Drawing.Point(1715, 1030);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 51;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnNext.Location = new System.Drawing.Point(1782, 1030);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 50;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageMax.Location = new System.Drawing.Point(1848, 1030);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 49;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // txbSalesOfficeName
            // 
            this.txbSalesOfficeName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbSalesOfficeName.Location = new System.Drawing.Point(681, 308);
            this.txbSalesOfficeName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSalesOfficeName.Name = "txbSalesOfficeName";
            this.txbSalesOfficeName.Size = new System.Drawing.Size(220, 31);
            this.txbSalesOfficeName.TabIndex = 55;
            this.txbSalesOfficeName.TabStop = false;
            // 
            // F_HonshaSalesOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.txbSalesOfficeName);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.dgvSalesOffice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblClientHidden);
            this.Controls.Add(this.txbSalesOfficeFAX);
            this.Controls.Add(this.txbSalesOfficeAddress);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txbSalesOfficePostal);
            this.Controls.Add(this.lblClientPostal);
            this.Controls.Add(this.lblCilentPhone);
            this.Controls.Add(this.txbSalesOfficePhone);
            this.Controls.Add(this.lblSalesOfficeName);
            this.Controls.Add(this.txbSalesOfficeID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_HonshaSalesOffice";
            this.Text = "営業所管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_HonshaSalesOffice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOffice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblSalesOffice;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbRegister;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Label lblClientHidden;
        private System.Windows.Forms.TextBox txbSalesOfficeFAX;
        private System.Windows.Forms.TextBox txbSalesOfficeAddress;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox txbSalesOfficePostal;
        private System.Windows.Forms.Label lblClientPostal;
        private System.Windows.Forms.Label lblCilentPhone;
        private System.Windows.Forms.TextBox txbSalesOfficePhone;
        private System.Windows.Forms.Label lblSalesOfficeName;
        private System.Windows.Forms.TextBox txbSalesOfficeID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSalesOffice;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.TextBox txbSalesOfficeName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctHint;
    }
}

namespace SalesManagement_SysDev
{
    partial class F_HonshaMaker
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
            this.lblMaker = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbRegister = new System.Windows.Forms.RadioButton();
            this.txbMakerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblClientHidden = new System.Windows.Forms.Label();
            this.txbMakerFAX = new System.Windows.Forms.TextBox();
            this.txbMakerAddress = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txbMakerPostal = new System.Windows.Forms.TextBox();
            this.lblClientPostal = new System.Windows.Forms.Label();
            this.lblCilentPhone = new System.Windows.Forms.Label();
            this.txbMakerPhone = new System.Windows.Forms.TextBox();
            this.lblSalesOfficeName = new System.Windows.Forms.Label();
            this.txbMakerID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.dgvMaker = new System.Windows.Forms.DataGridView();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.pctHint);
            this.panel1.Controls.Add(this.lblMaker);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1617, 37);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 35;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMaker.ForeColor = System.Drawing.Color.Black;
            this.lblMaker.Location = new System.Drawing.Point(778, 33);
            this.lblMaker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(355, 64);
            this.lblMaker.TabIndex = 24;
            this.lblMaker.Text = "メーカー管理";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnClose.Location = new System.Drawing.Point(1713, 33);
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
            this.btnReturn.Location = new System.Drawing.Point(40, 39);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseCompatibleTextRendering = true;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.cmbView.Location = new System.Drawing.Point(1100, 201);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 29;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.btnClear.Location = new System.Drawing.Point(1489, 186);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 28;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.btnDone.Location = new System.Drawing.Point(1684, 186);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 27;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.pnlSelect.Controls.Add(this.rdbSearch);
            this.pnlSelect.Controls.Add(this.rdbUpdate);
            this.pnlSelect.Controls.Add(this.rdbRegister);
            this.pnlSelect.Location = new System.Drawing.Point(42, 186);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(577, 74);
            this.pnlSelect.TabIndex = 30;
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
            // txbMakerName
            // 
            this.txbMakerName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbMakerName.Location = new System.Drawing.Point(711, 289);
            this.txbMakerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbMakerName.Name = "txbMakerName";
            this.txbMakerName.Size = new System.Drawing.Size(220, 31);
            this.txbMakerName.TabIndex = 71;
            this.txbMakerName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(84, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "非表示/表示";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(1437, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "FAX";
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
            this.cmbHidden.Location = new System.Drawing.Point(261, 452);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 68;
            this.cmbHidden.TabStop = false;
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbHidden.Location = new System.Drawing.Point(711, 452);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(1076, 31);
            this.txbHidden.TabIndex = 67;
            this.txbHidden.TabStop = false;
            // 
            // lblClientHidden
            // 
            this.lblClientHidden.AutoSize = true;
            this.lblClientHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientHidden.Location = new System.Drawing.Point(560, 455);
            this.lblClientHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientHidden.Name = "lblClientHidden";
            this.lblClientHidden.Size = new System.Drawing.Size(130, 24);
            this.lblClientHidden.TabIndex = 66;
            this.lblClientHidden.Text = "非表示理由";
            // 
            // txbMakerFAX
            // 
            this.txbMakerFAX.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbMakerFAX.Location = new System.Drawing.Point(1518, 285);
            this.txbMakerFAX.Margin = new System.Windows.Forms.Padding(1);
            this.txbMakerFAX.Name = "txbMakerFAX";
            this.txbMakerFAX.Size = new System.Drawing.Size(220, 31);
            this.txbMakerFAX.TabIndex = 65;
            this.txbMakerFAX.TabStop = false;
            // 
            // txbMakerAddress
            // 
            this.txbMakerAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbMakerAddress.Location = new System.Drawing.Point(711, 369);
            this.txbMakerAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbMakerAddress.Name = "txbMakerAddress";
            this.txbMakerAddress.Size = new System.Drawing.Size(653, 31);
            this.txbMakerAddress.TabIndex = 64;
            this.txbMakerAddress.TabStop = false;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientAddress.Location = new System.Drawing.Point(560, 372);
            this.lblClientAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(58, 24);
            this.lblClientAddress.TabIndex = 63;
            this.lblClientAddress.Text = "住所";
            // 
            // txbMakerPostal
            // 
            this.txbMakerPostal.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbMakerPostal.Location = new System.Drawing.Point(261, 369);
            this.txbMakerPostal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbMakerPostal.Name = "txbMakerPostal";
            this.txbMakerPostal.Size = new System.Drawing.Size(220, 31);
            this.txbMakerPostal.TabIndex = 62;
            this.txbMakerPostal.TabStop = false;
            // 
            // lblClientPostal
            // 
            this.lblClientPostal.AutoSize = true;
            this.lblClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientPostal.Location = new System.Drawing.Point(134, 372);
            this.lblClientPostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientPostal.Name = "lblClientPostal";
            this.lblClientPostal.Size = new System.Drawing.Size(106, 24);
            this.lblClientPostal.TabIndex = 61;
            this.lblClientPostal.Text = "郵便番号";
            // 
            // lblCilentPhone
            // 
            this.lblCilentPhone.AutoSize = true;
            this.lblCilentPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblCilentPhone.Location = new System.Drawing.Point(1007, 292);
            this.lblCilentPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCilentPhone.Name = "lblCilentPhone";
            this.lblCilentPhone.Size = new System.Drawing.Size(106, 24);
            this.lblCilentPhone.TabIndex = 60;
            this.lblCilentPhone.Text = "電話番号";
            // 
            // txbMakerPhone
            // 
            this.txbMakerPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbMakerPhone.Location = new System.Drawing.Point(1144, 289);
            this.txbMakerPhone.Margin = new System.Windows.Forms.Padding(1);
            this.txbMakerPhone.Name = "txbMakerPhone";
            this.txbMakerPhone.Size = new System.Drawing.Size(220, 31);
            this.txbMakerPhone.TabIndex = 59;
            this.txbMakerPhone.TabStop = false;
            // 
            // lblSalesOfficeName
            // 
            this.lblSalesOfficeName.AutoSize = true;
            this.lblSalesOfficeName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblSalesOfficeName.Location = new System.Drawing.Point(549, 292);
            this.lblSalesOfficeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesOfficeName.Name = "lblSalesOfficeName";
            this.lblSalesOfficeName.Size = new System.Drawing.Size(108, 24);
            this.lblSalesOfficeName.TabIndex = 58;
            this.lblSalesOfficeName.Text = "メーカー名";
            // 
            // txbMakerID
            // 
            this.txbMakerID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbMakerID.Location = new System.Drawing.Point(261, 289);
            this.txbMakerID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbMakerID.Name = "txbMakerID";
            this.txbMakerID.Size = new System.Drawing.Size(220, 31);
            this.txbMakerID.TabIndex = 57;
            this.txbMakerID.TabStop = false;
            this.txbMakerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientID.Location = new System.Drawing.Point(134, 292);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(106, 24);
            this.lblClientID.TabIndex = 56;
            this.lblClientID.Text = "メーカーID";
            // 
            // dgvMaker
            // 
            this.dgvMaker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaker.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvMaker.Location = new System.Drawing.Point(11, 516);
            this.dgvMaker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvMaker.Name = "dgvMaker";
            this.dgvMaker.RowHeadersWidth = 51;
            this.dgvMaker.RowTemplate.Height = 24;
            this.dgvMaker.Size = new System.Drawing.Size(1900, 495);
            this.dgvMaker.TabIndex = 72;
            this.dgvMaker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaker_CellClick);
            // 
            // btnPageSize
            // 
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageSize.Location = new System.Drawing.Point(223, 1030);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 75;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = true;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lblPageSize.Location = new System.Drawing.Point(24, 1039);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(119, 22);
            this.lblPageSize.TabIndex = 74;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbPageSize.Location = new System.Drawing.Point(146, 1036);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 29);
            this.txbPageSize.TabIndex = 73;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lblNumPage.Location = new System.Drawing.Point(1541, 1037);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(64, 22);
            this.lblNumPage.TabIndex = 81;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Enabled = false;
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbNumPage.Location = new System.Drawing.Point(1476, 1036);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(1);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.ReadOnly = true;
            this.txbNumPage.Size = new System.Drawing.Size(50, 29);
            this.txbNumPage.TabIndex = 80;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageMin.Location = new System.Drawing.Point(1629, 1029);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 79;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnBack.Location = new System.Drawing.Point(1701, 1029);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 78;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnNext.Location = new System.Drawing.Point(1768, 1029);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 77;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageMax.Location = new System.Drawing.Point(1834, 1029);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 76;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // F_HonshaMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.dgvMaker);
            this.Controls.Add(this.txbMakerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblClientHidden);
            this.Controls.Add(this.txbMakerFAX);
            this.Controls.Add(this.txbMakerAddress);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txbMakerPostal);
            this.Controls.Add(this.lblClientPostal);
            this.Controls.Add(this.lblCilentPhone);
            this.Controls.Add(this.txbMakerPhone);
            this.Controls.Add(this.lblSalesOfficeName);
            this.Controls.Add(this.txbMakerID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_HonshaMaker";
            this.Text = "メーカー管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_HonshaMaker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbRegister;
        private System.Windows.Forms.TextBox txbMakerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Label lblClientHidden;
        private System.Windows.Forms.TextBox txbMakerFAX;
        private System.Windows.Forms.TextBox txbMakerAddress;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox txbMakerPostal;
        private System.Windows.Forms.Label lblClientPostal;
        private System.Windows.Forms.Label lblCilentPhone;
        private System.Windows.Forms.TextBox txbMakerPhone;
        private System.Windows.Forms.Label lblSalesOfficeName;
        private System.Windows.Forms.TextBox txbMakerID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.DataGridView dgvMaker;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.PictureBox pctHint;
    }
}
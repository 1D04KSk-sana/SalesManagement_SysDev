namespace SalesManagement_SysDev
{
    partial class F_HonshaProdact
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbRegister = new System.Windows.Forms.RadioButton();
            this.lblProdactID = new System.Windows.Forms.Label();
            this.txbProdactID = new System.Windows.Forms.TextBox();
            this.txbProdactName = new System.Windows.Forms.TextBox();
            this.lblProdactName = new System.Windows.Forms.Label();
            this.lblMajorID = new System.Windows.Forms.Label();
            this.lblSmallID = new System.Windows.Forms.Label();
            this.txbProdactColor = new System.Windows.Forms.TextBox();
            this.lblProdactColor = new System.Windows.Forms.Label();
            this.txbModelNumber = new System.Windows.Forms.TextBox();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.txbProdactPrice = new System.Windows.Forms.TextBox();
            this.lblProdactPrice = new System.Windows.Forms.Label();
            this.lblMakerName = new System.Windows.Forms.Label();
            this.txbProdactSafetyStock = new System.Windows.Forms.TextBox();
            this.lblProdactSafetyStock = new System.Windows.Forms.Label();
            this.txbProdactReleaseDate = new System.Windows.Forms.TextBox();
            this.lblProdactReleaseDate = new System.Windows.Forms.Label();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.lblProdactHidden = new System.Windows.Forms.Label();
            this.tbxProdactHidden = new System.Windows.Forms.TextBox();
            this.dgvProdact = new System.Windows.Forms.DataGridView();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.btnPagesize = new System.Windows.Forms.Button();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.pnlProdact = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProdact = new System.Windows.Forms.Label();
            this.txbProdactJanCode = new System.Windows.Forms.TextBox();
            this.lblProdactJanCode = new System.Windows.Forms.Label();
            this.cmbMakerName = new System.Windows.Forms.ComboBox();
            this.cmbMajorID = new System.Windows.Forms.ComboBox();
            this.cmbSmallID = new System.Windows.Forms.ComboBox();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdact)).BeginInit();
            this.pnlProdact.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(25, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 50);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(926, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 50);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1050, 93);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(110, 50);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbView
            // 
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(681, 105);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(200, 31);
            this.cmbView.TabIndex = 3;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.rdbSearch);
            this.pnlSelect.Controls.Add(this.rdbUpdate);
            this.pnlSelect.Controls.Add(this.rdbRegister);
            this.pnlSelect.Location = new System.Drawing.Point(26, 102);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(349, 51);
            this.pnlSelect.TabIndex = 4;
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(232, 12);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(77, 27);
            this.rdbSearch.TabIndex = 2;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(138, 12);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(77, 27);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.Text = "更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbRegister
            // 
            this.rdbRegister.AutoSize = true;
            this.rdbRegister.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbRegister.Location = new System.Drawing.Point(41, 12);
            this.rdbRegister.Name = "rdbRegister";
            this.rdbRegister.Size = new System.Drawing.Size(77, 27);
            this.rdbRegister.TabIndex = 0;
            this.rdbRegister.Text = "登録";
            this.rdbRegister.UseVisualStyleBackColor = true;
            // 
            // lblProdactID
            // 
            this.lblProdactID.AutoSize = true;
            this.lblProdactID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactID.Location = new System.Drawing.Point(26, 161);
            this.lblProdactID.Name = "lblProdactID";
            this.lblProdactID.Size = new System.Drawing.Size(60, 18);
            this.lblProdactID.TabIndex = 5;
            this.lblProdactID.Text = "商品ID";
            // 
            // txbProdactID
            // 
            this.txbProdactID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactID.Location = new System.Drawing.Point(96, 159);
            this.txbProdactID.Name = "txbProdactID";
            this.txbProdactID.Size = new System.Drawing.Size(200, 25);
            this.txbProdactID.TabIndex = 6;
            // 
            // txbProdactName
            // 
            this.txbProdactName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactName.Location = new System.Drawing.Point(379, 159);
            this.txbProdactName.Name = "txbProdactName";
            this.txbProdactName.Size = new System.Drawing.Size(200, 25);
            this.txbProdactName.TabIndex = 8;
            // 
            // lblProdactName
            // 
            this.lblProdactName.AutoSize = true;
            this.lblProdactName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactName.Location = new System.Drawing.Point(313, 162);
            this.lblProdactName.Name = "lblProdactName";
            this.lblProdactName.Size = new System.Drawing.Size(62, 18);
            this.lblProdactName.TabIndex = 7;
            this.lblProdactName.Text = "商品名";
            // 
            // lblMajorID
            // 
            this.lblMajorID.AutoSize = true;
            this.lblMajorID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMajorID.Location = new System.Drawing.Point(597, 161);
            this.lblMajorID.Name = "lblMajorID";
            this.lblMajorID.Size = new System.Drawing.Size(78, 18);
            this.lblMajorID.TabIndex = 9;
            this.lblMajorID.Text = "大分類ID";
            // 
            // lblSmallID
            // 
            this.lblSmallID.AutoSize = true;
            this.lblSmallID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSmallID.Location = new System.Drawing.Point(887, 162);
            this.lblSmallID.Name = "lblSmallID";
            this.lblSmallID.Size = new System.Drawing.Size(78, 18);
            this.lblSmallID.TabIndex = 17;
            this.lblSmallID.Text = "小分類ID";
            // 
            // txbProdactColor
            // 
            this.txbProdactColor.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactColor.Location = new System.Drawing.Point(379, 207);
            this.txbProdactColor.Name = "txbProdactColor";
            this.txbProdactColor.Size = new System.Drawing.Size(200, 25);
            this.txbProdactColor.TabIndex = 16;
            // 
            // lblProdactColor
            // 
            this.lblProdactColor.AutoSize = true;
            this.lblProdactColor.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactColor.Location = new System.Drawing.Point(347, 210);
            this.lblProdactColor.Name = "lblProdactColor";
            this.lblProdactColor.Size = new System.Drawing.Size(26, 18);
            this.lblProdactColor.TabIndex = 15;
            this.lblProdactColor.Text = "色";
            // 
            // txbModelNumber
            // 
            this.txbModelNumber.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbModelNumber.Location = new System.Drawing.Point(96, 207);
            this.txbModelNumber.Name = "txbModelNumber";
            this.txbModelNumber.Size = new System.Drawing.Size(200, 25);
            this.txbModelNumber.TabIndex = 14;
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblModelNumber.Location = new System.Drawing.Point(42, 209);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(44, 18);
            this.lblModelNumber.TabIndex = 13;
            this.lblModelNumber.Text = "型番";
            // 
            // txbProdactPrice
            // 
            this.txbProdactPrice.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactPrice.Location = new System.Drawing.Point(379, 255);
            this.txbProdactPrice.Name = "txbProdactPrice";
            this.txbProdactPrice.Size = new System.Drawing.Size(200, 25);
            this.txbProdactPrice.TabIndex = 24;
            // 
            // lblProdactPrice
            // 
            this.lblProdactPrice.AutoSize = true;
            this.lblProdactPrice.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactPrice.Location = new System.Drawing.Point(329, 258);
            this.lblProdactPrice.Name = "lblProdactPrice";
            this.lblProdactPrice.Size = new System.Drawing.Size(44, 18);
            this.lblProdactPrice.TabIndex = 23;
            this.lblProdactPrice.Text = "価格";
            // 
            // lblMakerName
            // 
            this.lblMakerName.AutoSize = true;
            this.lblMakerName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMakerName.Location = new System.Drawing.Point(12, 257);
            this.lblMakerName.Name = "lblMakerName";
            this.lblMakerName.Size = new System.Drawing.Size(81, 18);
            this.lblMakerName.TabIndex = 21;
            this.lblMakerName.Text = "メーカー名";
            // 
            // txbProdactSafetyStock
            // 
            this.txbProdactSafetyStock.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactSafetyStock.Location = new System.Drawing.Point(681, 254);
            this.txbProdactSafetyStock.Name = "txbProdactSafetyStock";
            this.txbProdactSafetyStock.Size = new System.Drawing.Size(200, 25);
            this.txbProdactSafetyStock.TabIndex = 28;
            // 
            // lblProdactSafetyStock
            // 
            this.lblProdactSafetyStock.AutoSize = true;
            this.lblProdactSafetyStock.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactSafetyStock.Location = new System.Drawing.Point(579, 257);
            this.lblProdactSafetyStock.Name = "lblProdactSafetyStock";
            this.lblProdactSafetyStock.Size = new System.Drawing.Size(98, 18);
            this.lblProdactSafetyStock.TabIndex = 27;
            this.lblProdactSafetyStock.Text = "安全在庫数";
            // 
            // txbProdactReleaseDate
            // 
            this.txbProdactReleaseDate.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactReleaseDate.Location = new System.Drawing.Point(681, 209);
            this.txbProdactReleaseDate.Name = "txbProdactReleaseDate";
            this.txbProdactReleaseDate.Size = new System.Drawing.Size(200, 25);
            this.txbProdactReleaseDate.TabIndex = 26;
            // 
            // lblProdactReleaseDate
            // 
            this.lblProdactReleaseDate.AutoSize = true;
            this.lblProdactReleaseDate.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactReleaseDate.Location = new System.Drawing.Point(613, 212);
            this.lblProdactReleaseDate.Name = "lblProdactReleaseDate";
            this.lblProdactReleaseDate.Size = new System.Drawing.Size(62, 18);
            this.lblProdactReleaseDate.TabIndex = 25;
            this.lblProdactReleaseDate.Text = "発売日";
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(96, 319);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(150, 26);
            this.cmbHidden.TabIndex = 29;
            // 
            // lblProdactHidden
            // 
            this.lblProdactHidden.AutoSize = true;
            this.lblProdactHidden.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactHidden.Location = new System.Drawing.Point(282, 319);
            this.lblProdactHidden.Name = "lblProdactHidden";
            this.lblProdactHidden.Size = new System.Drawing.Size(98, 18);
            this.lblProdactHidden.TabIndex = 30;
            this.lblProdactHidden.Text = "非表示理由";
            // 
            // tbxProdactHidden
            // 
            this.tbxProdactHidden.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxProdactHidden.Location = new System.Drawing.Point(379, 316);
            this.tbxProdactHidden.Name = "tbxProdactHidden";
            this.tbxProdactHidden.Size = new System.Drawing.Size(812, 25);
            this.tbxProdactHidden.TabIndex = 31;
            // 
            // dgvProdact
            // 
            this.dgvProdact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdact.Location = new System.Drawing.Point(9, 360);
            this.dgvProdact.Name = "dgvProdact";
            this.dgvProdact.RowHeadersWidth = 51;
            this.dgvProdact.RowTemplate.Height = 24;
            this.dgvProdact.Size = new System.Drawing.Size(1191, 336);
            this.dgvProdact.TabIndex = 32;
            this.dgvProdact.TabStop = false;
            this.dgvProdact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdact_CellClick);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(12, 718);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(98, 18);
            this.lblPageSize.TabIndex = 33;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(116, 714);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 25);
            this.txbPageSize.TabIndex = 34;
            // 
            // btnPagesize
            // 
            this.btnPagesize.BackColor = System.Drawing.Color.White;
            this.btnPagesize.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPagesize.Location = new System.Drawing.Point(172, 709);
            this.btnPagesize.Name = "btnPagesize";
            this.btnPagesize.Size = new System.Drawing.Size(120, 35);
            this.btnPagesize.TabIndex = 35;
            this.btnPagesize.Text = "行数変更";
            this.btnPagesize.UseVisualStyleBackColor = false;
            this.btnPagesize.Click += new System.EventHandler(this.btnPagesize_Click);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(955, 717);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(53, 18);
            this.lblNumPage.TabIndex = 36;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(911, 714);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(38, 25);
            this.txbNumPage.TabIndex = 37;
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(1014, 709);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(42, 36);
            this.btnPageMin.TabIndex = 38;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1062, 709);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 36);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1110, 708);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 36);
            this.btnNext.TabIndex = 40;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1158, 708);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(42, 36);
            this.btnPageMax.TabIndex = 41;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // pnlProdact
            // 
            this.pnlProdact.BackColor = System.Drawing.Color.Lime;
            this.pnlProdact.Controls.Add(this.btnClose);
            this.pnlProdact.Controls.Add(this.lblProdact);
            this.pnlProdact.Controls.Add(this.btnReturn);
            this.pnlProdact.Location = new System.Drawing.Point(1, 0);
            this.pnlProdact.Name = "pnlProdact";
            this.pnlProdact.Size = new System.Drawing.Size(1206, 90);
            this.pnlProdact.TabIndex = 42;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1049, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblProdact
            // 
            this.lblProdact.AutoSize = true;
            this.lblProdact.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdact.Location = new System.Drawing.Point(448, 27);
            this.lblProdact.Name = "lblProdact";
            this.lblProdact.Size = new System.Drawing.Size(283, 43);
            this.lblProdact.TabIndex = 1;
            this.lblProdact.Text = "商品管理画面";
            // 
            // txbProdactJanCode
            // 
            this.txbProdactJanCode.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactJanCode.Location = new System.Drawing.Point(974, 202);
            this.txbProdactJanCode.Name = "txbProdactJanCode";
            this.txbProdactJanCode.Size = new System.Drawing.Size(200, 25);
            this.txbProdactJanCode.TabIndex = 43;
            // 
            // lblProdactJanCode
            // 
            this.lblProdactJanCode.AutoSize = true;
            this.lblProdactJanCode.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactJanCode.Location = new System.Drawing.Point(887, 210);
            this.lblProdactJanCode.Name = "lblProdactJanCode";
            this.lblProdactJanCode.Size = new System.Drawing.Size(81, 18);
            this.lblProdactJanCode.TabIndex = 44;
            this.lblProdactJanCode.Text = "JANコード";
            // 
            // cmbMakerName
            // 
            this.cmbMakerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMakerName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbMakerName.FormattingEnabled = true;
            this.cmbMakerName.Items.AddRange(new object[] {
            "Aメーカ",
            "Bメーカ",
            "Cメーカ",
            "Dメーカ"});
            this.cmbMakerName.Location = new System.Drawing.Point(97, 253);
            this.cmbMakerName.Name = "cmbMakerName";
            this.cmbMakerName.Size = new System.Drawing.Size(150, 26);
            this.cmbMakerName.TabIndex = 45;
            // 
            // cmbMajorID
            // 
            this.cmbMajorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajorID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbMajorID.FormattingEnabled = true;
            this.cmbMajorID.Items.AddRange(new object[] {
            "テレビ・レコーダー",
            "エアコン・冷蔵庫・洗濯機",
            "オーディオ・イヤホン・ヘッドホン",
            "携帯電話・スマートフォン"});
            this.cmbMajorID.Location = new System.Drawing.Point(681, 158);
            this.cmbMajorID.Name = "cmbMajorID";
            this.cmbMajorID.Size = new System.Drawing.Size(150, 26);
            this.cmbMajorID.TabIndex = 46;
            // 
            // cmbSmallID
            // 
            this.cmbSmallID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmallID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSmallID.FormattingEnabled = true;
            this.cmbSmallID.Items.AddRange(new object[] {
            "テレビ",
            "レコーダー",
            "エアコン",
            "冷蔵庫",
            "洗濯機",
            "オーディオ",
            "イヤホン",
            "ヘッドホン",
            "携帯電話",
            "スマートフォン"});
            this.cmbSmallID.Location = new System.Drawing.Point(974, 154);
            this.cmbSmallID.Name = "cmbSmallID";
            this.cmbSmallID.Size = new System.Drawing.Size(150, 26);
            this.cmbSmallID.TabIndex = 47;
            // 
            // F_HonshaProdact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1212, 753);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSmallID);
            this.Controls.Add(this.cmbMajorID);
            this.Controls.Add(this.cmbMakerName);
            this.Controls.Add(this.lblProdactJanCode);
            this.Controls.Add(this.txbProdactJanCode);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.pnlProdact);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.btnPagesize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.dgvProdact);
            this.Controls.Add(this.tbxProdactHidden);
            this.Controls.Add(this.lblProdactHidden);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.txbProdactSafetyStock);
            this.Controls.Add(this.lblProdactSafetyStock);
            this.Controls.Add(this.txbProdactReleaseDate);
            this.Controls.Add(this.lblProdactReleaseDate);
            this.Controls.Add(this.txbProdactPrice);
            this.Controls.Add(this.lblProdactPrice);
            this.Controls.Add(this.lblMakerName);
            this.Controls.Add(this.lblSmallID);
            this.Controls.Add(this.txbProdactColor);
            this.Controls.Add(this.lblProdactColor);
            this.Controls.Add(this.txbModelNumber);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.lblMajorID);
            this.Controls.Add(this.txbProdactName);
            this.Controls.Add(this.lblProdactName);
            this.Controls.Add(this.txbProdactID);
            this.Controls.Add(this.lblProdactID);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_HonshaProdact";
            this.Text = "F_HonshaProdact";
            this.Load += new System.EventHandler(this.F_HonshaProdact_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdact)).EndInit();
            this.pnlProdact.ResumeLayout(false);
            this.pnlProdact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.RadioButton rdbRegister;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.Label lblProdactID;
        private System.Windows.Forms.TextBox txbProdactID;
        private System.Windows.Forms.TextBox txbProdactName;
        private System.Windows.Forms.Label lblProdactName;
        private System.Windows.Forms.Label lblMajorID;
        private System.Windows.Forms.Label lblSmallID;
        private System.Windows.Forms.TextBox txbProdactColor;
        private System.Windows.Forms.Label lblProdactColor;
        private System.Windows.Forms.TextBox txbModelNumber;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.TextBox txbProdactPrice;
        private System.Windows.Forms.Label lblProdactPrice;
        private System.Windows.Forms.Label lblMakerName;
        private System.Windows.Forms.TextBox txbProdactSafetyStock;
        private System.Windows.Forms.Label lblProdactSafetyStock;
        private System.Windows.Forms.TextBox txbProdactReleaseDate;
        private System.Windows.Forms.Label lblProdactReleaseDate;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.Label lblProdactHidden;
        private System.Windows.Forms.TextBox tbxProdactHidden;
        private System.Windows.Forms.DataGridView dgvProdact;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Button btnPagesize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Panel pnlProdact;
        private System.Windows.Forms.Label lblProdact;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txbProdactJanCode;
        private System.Windows.Forms.Label lblProdactJanCode;
        private System.Windows.Forms.ComboBox cmbMakerName;
        private System.Windows.Forms.ComboBox cmbMajorID;
        private System.Windows.Forms.ComboBox cmbSmallID;
    }
}
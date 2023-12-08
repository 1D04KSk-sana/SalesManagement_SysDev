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
            this.button1 = new System.Windows.Forms.Button();
            this.lblProdact = new System.Windows.Forms.Label();
            this.txbProdactJanCode = new System.Windows.Forms.TextBox();
            this.lblProdactJanCode = new System.Windows.Forms.Label();
            this.cmbMakerName = new System.Windows.Forms.ComboBox();
            this.cmbMajorID = new System.Windows.Forms.ComboBox();
            this.cmbSmallID = new System.Windows.Forms.ComboBox();
            this.dtpProdactReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblprodactdspHidden = new System.Windows.Forms.Label();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdact)).BeginInit();
            this.pnlProdact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(54, 46);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 56);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1599, 170);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 56);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1755, 170);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(120, 56);
            this.btnDone.TabIndex = 2;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1291, 186);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(271, 32);
            this.cmbView.TabIndex = 3;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.rdbSearch);
            this.pnlSelect.Controls.Add(this.rdbUpdate);
            this.pnlSelect.Controls.Add(this.rdbRegister);
            this.pnlSelect.Location = new System.Drawing.Point(55, 170);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(352, 73);
            this.pnlSelect.TabIndex = 4;
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(231, 17);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 2;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(116, 17);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(103, 39);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.Text = "更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbRegister
            // 
            this.rdbRegister.AutoSize = true;
            this.rdbRegister.Checked = true;
            this.rdbRegister.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbRegister.Location = new System.Drawing.Point(9, 17);
            this.rdbRegister.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRegister.Name = "rdbRegister";
            this.rdbRegister.Size = new System.Drawing.Size(103, 39);
            this.rdbRegister.TabIndex = 0;
            this.rdbRegister.TabStop = true;
            this.rdbRegister.Text = "登録";
            this.rdbRegister.UseVisualStyleBackColor = true;
            // 
            // lblProdactID
            // 
            this.lblProdactID.AutoSize = true;
            this.lblProdactID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactID.Location = new System.Drawing.Point(51, 285);
            this.lblProdactID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactID.Name = "lblProdactID";
            this.lblProdactID.Size = new System.Drawing.Size(80, 24);
            this.lblProdactID.TabIndex = 5;
            this.lblProdactID.Text = "商品ID";
            // 
            // txbProdactID
            // 
            this.txbProdactID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactID.Location = new System.Drawing.Point(146, 282);
            this.txbProdactID.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactID.Name = "txbProdactID";
            this.txbProdactID.Size = new System.Drawing.Size(166, 31);
            this.txbProdactID.TabIndex = 6;
            // 
            // txbProdactName
            // 
            this.txbProdactName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactName.Location = new System.Drawing.Point(553, 279);
            this.txbProdactName.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactName.Name = "txbProdactName";
            this.txbProdactName.Size = new System.Drawing.Size(166, 31);
            this.txbProdactName.TabIndex = 8;
            // 
            // lblProdactName
            // 
            this.lblProdactName.AutoSize = true;
            this.lblProdactName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactName.Location = new System.Drawing.Point(467, 282);
            this.lblProdactName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactName.Name = "lblProdactName";
            this.lblProdactName.Size = new System.Drawing.Size(82, 24);
            this.lblProdactName.TabIndex = 7;
            this.lblProdactName.Text = "商品名";
            // 
            // lblMajorID
            // 
            this.lblMajorID.AutoSize = true;
            this.lblMajorID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMajorID.Location = new System.Drawing.Point(1183, 278);
            this.lblMajorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMajorID.Name = "lblMajorID";
            this.lblMajorID.Size = new System.Drawing.Size(104, 24);
            this.lblMajorID.TabIndex = 9;
            this.lblMajorID.Text = "大分類ID";
            // 
            // lblSmallID
            // 
            this.lblSmallID.AutoSize = true;
            this.lblSmallID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSmallID.Location = new System.Drawing.Point(1535, 273);
            this.lblSmallID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSmallID.Name = "lblSmallID";
            this.lblSmallID.Size = new System.Drawing.Size(104, 24);
            this.lblSmallID.TabIndex = 17;
            this.lblSmallID.Text = "小分類ID";
            // 
            // txbProdactColor
            // 
            this.txbProdactColor.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactColor.Location = new System.Drawing.Point(553, 344);
            this.txbProdactColor.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactColor.Name = "txbProdactColor";
            this.txbProdactColor.Size = new System.Drawing.Size(166, 31);
            this.txbProdactColor.TabIndex = 16;
            // 
            // lblProdactColor
            // 
            this.lblProdactColor.AutoSize = true;
            this.lblProdactColor.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactColor.Location = new System.Drawing.Point(515, 351);
            this.lblProdactColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactColor.Name = "lblProdactColor";
            this.lblProdactColor.Size = new System.Drawing.Size(34, 24);
            this.lblProdactColor.TabIndex = 15;
            this.lblProdactColor.Text = "色";
            // 
            // txbModelNumber
            // 
            this.txbModelNumber.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbModelNumber.Location = new System.Drawing.Point(146, 347);
            this.txbModelNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txbModelNumber.Name = "txbModelNumber";
            this.txbModelNumber.Size = new System.Drawing.Size(166, 31);
            this.txbModelNumber.TabIndex = 14;
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblModelNumber.Location = new System.Drawing.Point(73, 350);
            this.lblModelNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(58, 24);
            this.lblModelNumber.TabIndex = 13;
            this.lblModelNumber.Text = "型番";
            // 
            // txbProdactPrice
            // 
            this.txbProdactPrice.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactPrice.Location = new System.Drawing.Point(897, 344);
            this.txbProdactPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactPrice.Name = "txbProdactPrice";
            this.txbProdactPrice.Size = new System.Drawing.Size(166, 31);
            this.txbProdactPrice.TabIndex = 24;
            // 
            // lblProdactPrice
            // 
            this.lblProdactPrice.AutoSize = true;
            this.lblProdactPrice.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactPrice.Location = new System.Drawing.Point(835, 350);
            this.lblProdactPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactPrice.Name = "lblProdactPrice";
            this.lblProdactPrice.Size = new System.Drawing.Size(58, 24);
            this.lblProdactPrice.TabIndex = 23;
            this.lblProdactPrice.Text = "価格";
            // 
            // lblMakerName
            // 
            this.lblMakerName.AutoSize = true;
            this.lblMakerName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMakerName.Location = new System.Drawing.Point(28, 408);
            this.lblMakerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMakerName.Name = "lblMakerName";
            this.lblMakerName.Size = new System.Drawing.Size(108, 24);
            this.lblMakerName.TabIndex = 21;
            this.lblMakerName.Text = "メーカー名";
            // 
            // txbProdactSafetyStock
            // 
            this.txbProdactSafetyStock.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactSafetyStock.Location = new System.Drawing.Point(553, 405);
            this.txbProdactSafetyStock.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactSafetyStock.Name = "txbProdactSafetyStock";
            this.txbProdactSafetyStock.Size = new System.Drawing.Size(166, 31);
            this.txbProdactSafetyStock.TabIndex = 28;
            // 
            // lblProdactSafetyStock
            // 
            this.lblProdactSafetyStock.AutoSize = true;
            this.lblProdactSafetyStock.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactSafetyStock.Location = new System.Drawing.Point(419, 408);
            this.lblProdactSafetyStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactSafetyStock.Name = "lblProdactSafetyStock";
            this.lblProdactSafetyStock.Size = new System.Drawing.Size(130, 24);
            this.lblProdactSafetyStock.TabIndex = 27;
            this.lblProdactSafetyStock.Text = "安全在庫数";
            // 
            // lblProdactReleaseDate
            // 
            this.lblProdactReleaseDate.AutoSize = true;
            this.lblProdactReleaseDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactReleaseDate.Location = new System.Drawing.Point(811, 408);
            this.lblProdactReleaseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactReleaseDate.Name = "lblProdactReleaseDate";
            this.lblProdactReleaseDate.Size = new System.Drawing.Size(82, 24);
            this.lblProdactReleaseDate.TabIndex = 25;
            this.lblProdactReleaseDate.Text = "発売日";
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(1291, 344);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(166, 32);
            this.cmbHidden.TabIndex = 29;
            // 
            // lblProdactHidden
            // 
            this.lblProdactHidden.AutoSize = true;
            this.lblProdactHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactHidden.Location = new System.Drawing.Point(1157, 413);
            this.lblProdactHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactHidden.Name = "lblProdactHidden";
            this.lblProdactHidden.Size = new System.Drawing.Size(130, 24);
            this.lblProdactHidden.TabIndex = 30;
            this.lblProdactHidden.Text = "非表示理由";
            // 
            // tbxProdactHidden
            // 
            this.tbxProdactHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxProdactHidden.Location = new System.Drawing.Point(1291, 410);
            this.tbxProdactHidden.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProdactHidden.Name = "tbxProdactHidden";
            this.tbxProdactHidden.Size = new System.Drawing.Size(606, 31);
            this.tbxProdactHidden.TabIndex = 31;
            // 
            // dgvProdact
            // 
            this.dgvProdact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdact.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvProdact.Location = new System.Drawing.Point(11, 476);
            this.dgvProdact.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdact.Name = "dgvProdact";
            this.dgvProdact.RowHeadersWidth = 51;
            this.dgvProdact.RowTemplate.Height = 24;
            this.dgvProdact.Size = new System.Drawing.Size(1900, 528);
            this.dgvProdact.TabIndex = 32;
            this.dgvProdact.TabStop = false;
            this.dgvProdact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdact_CellClick);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(18, 1030);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(125, 22);
            this.lblPageSize.TabIndex = 33;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(146, 1024);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(38, 29);
            this.txbPageSize.TabIndex = 34;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPagesize
            // 
            this.btnPagesize.BackColor = System.Drawing.Color.White;
            this.btnPagesize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPagesize.Location = new System.Drawing.Point(206, 1024);
            this.btnPagesize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagesize.Name = "btnPagesize";
            this.btnPagesize.Size = new System.Drawing.Size(137, 32);
            this.btnPagesize.TabIndex = 35;
            this.btnPagesize.TabStop = false;
            this.btnPagesize.Text = "行数変更";
            this.btnPagesize.UseVisualStyleBackColor = false;
            this.btnPagesize.Click += new System.EventHandler(this.btnPagesize_Click);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(1585, 1034);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(67, 22);
            this.lblNumPage.TabIndex = 36;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(1551, 1027);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(30, 29);
            this.txbNumPage.TabIndex = 37;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(1681, 1024);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(38, 32);
            this.btnPageMin.TabIndex = 38;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1737, 1024);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 32);
            this.btnBack.TabIndex = 39;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1804, 1024);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 32);
            this.btnNext.TabIndex = 40;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1859, 1024);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(38, 32);
            this.btnPageMax.TabIndex = 41;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // pnlProdact
            // 
            this.pnlProdact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(112)))));
            this.pnlProdact.Controls.Add(this.pctHint);
            this.pnlProdact.Controls.Add(this.button1);
            this.pnlProdact.Controls.Add(this.lblProdact);
            this.pnlProdact.Controls.Add(this.btnReturn);
            this.pnlProdact.Location = new System.Drawing.Point(1, 0);
            this.pnlProdact.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProdact.Name = "pnlProdact";
            this.pnlProdact.Size = new System.Drawing.Size(1920, 150);
            this.pnlProdact.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1724, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 70);
            this.button1.TabIndex = 50;
            this.button1.TabStop = false;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProdact
            // 
            this.lblProdact.AutoSize = true;
            this.lblProdact.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdact.Location = new System.Drawing.Point(778, 58);
            this.lblProdact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdact.Name = "lblProdact";
            this.lblProdact.Size = new System.Drawing.Size(418, 64);
            this.lblProdact.TabIndex = 1;
            this.lblProdact.Text = "商品管理画面";
            // 
            // txbProdactJanCode
            // 
            this.txbProdactJanCode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactJanCode.Location = new System.Drawing.Point(897, 275);
            this.txbProdactJanCode.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactJanCode.Name = "txbProdactJanCode";
            this.txbProdactJanCode.Size = new System.Drawing.Size(166, 31);
            this.txbProdactJanCode.TabIndex = 43;
            // 
            // lblProdactJanCode
            // 
            this.lblProdactJanCode.AutoSize = true;
            this.lblProdactJanCode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactJanCode.Location = new System.Drawing.Point(786, 282);
            this.lblProdactJanCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactJanCode.Name = "lblProdactJanCode";
            this.lblProdactJanCode.Size = new System.Drawing.Size(107, 24);
            this.lblProdactJanCode.TabIndex = 44;
            this.lblProdactJanCode.Text = "JANコード";
            // 
            // cmbMakerName
            // 
            this.cmbMakerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMakerName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbMakerName.FormattingEnabled = true;
            this.cmbMakerName.Location = new System.Drawing.Point(146, 405);
            this.cmbMakerName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMakerName.Name = "cmbMakerName";
            this.cmbMakerName.Size = new System.Drawing.Size(166, 32);
            this.cmbMakerName.TabIndex = 45;
            // 
            // cmbMajorID
            // 
            this.cmbMajorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajorID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbMajorID.FormattingEnabled = true;
            this.cmbMajorID.Items.AddRange(new object[] {
            "テレビ・レコーダー",
            "エアコン・冷蔵庫・洗濯機",
            "オーディオ・イヤホン・ヘッドホン",
            "携帯電話・スマートフォン"});
            this.cmbMajorID.Location = new System.Drawing.Point(1291, 270);
            this.cmbMajorID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMajorID.Name = "cmbMajorID";
            this.cmbMajorID.Size = new System.Drawing.Size(166, 32);
            this.cmbMajorID.TabIndex = 46;
            // 
            // cmbSmallID
            // 
            this.cmbSmallID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmallID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSmallID.FormattingEnabled = true;
            this.cmbSmallID.Location = new System.Drawing.Point(1643, 270);
            this.cmbSmallID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSmallID.Name = "cmbSmallID";
            this.cmbSmallID.Size = new System.Drawing.Size(166, 32);
            this.cmbSmallID.TabIndex = 47;
            // 
            // dtpProdactReleaseDate
            // 
            this.dtpProdactReleaseDate.CalendarFont = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpProdactReleaseDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpProdactReleaseDate.Location = new System.Drawing.Point(897, 403);
            this.dtpProdactReleaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpProdactReleaseDate.Name = "dtpProdactReleaseDate";
            this.dtpProdactReleaseDate.Size = new System.Drawing.Size(187, 31);
            this.dtpProdactReleaseDate.TabIndex = 48;
            this.dtpProdactReleaseDate.TabStop = false;
            // 
            // lblprodactdspHidden
            // 
            this.lblprodactdspHidden.AutoSize = true;
            this.lblprodactdspHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblprodactdspHidden.Location = new System.Drawing.Point(1145, 347);
            this.lblprodactdspHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprodactdspHidden.Name = "lblprodactdspHidden";
            this.lblprodactdspHidden.Size = new System.Drawing.Size(142, 24);
            this.lblprodactdspHidden.TabIndex = 49;
            this.lblprodactdspHidden.Text = "表示/非表示";
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1621, 42);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 73;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // F_HonshaProdact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.lblprodactdspHidden);
            this.Controls.Add(this.dtpProdactReleaseDate);
            this.Controls.Add(this.cmbSmallID);
            this.Controls.Add(this.cmbMajorID);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cmbMakerName);
            this.Controls.Add(this.btnClear);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "F_HonshaProdact";
            this.Text = "F_HonshaProdact";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_HonshaProdact_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdact)).EndInit();
            this.pnlProdact.ResumeLayout(false);
            this.pnlProdact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
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
        private System.Windows.Forms.TextBox txbProdactJanCode;
        private System.Windows.Forms.Label lblProdactJanCode;
        private System.Windows.Forms.ComboBox cmbMakerName;
        private System.Windows.Forms.ComboBox cmbMajorID;
        private System.Windows.Forms.ComboBox cmbSmallID;
        private System.Windows.Forms.DateTimePicker dtpProdactReleaseDate;
        private System.Windows.Forms.Label lblprodactdspHidden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctHint;
    }
}
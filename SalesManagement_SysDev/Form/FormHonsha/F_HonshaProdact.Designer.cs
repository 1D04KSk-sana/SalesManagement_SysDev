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
            this.txbMajorID = new System.Windows.Forms.TextBox();
            this.lblMajorID = new System.Windows.Forms.Label();
            this.txbMajorName = new System.Windows.Forms.TextBox();
            this.lblMajorName = new System.Windows.Forms.Label();
            this.txbSmallName = new System.Windows.Forms.TextBox();
            this.lblSmallName = new System.Windows.Forms.Label();
            this.txbSmallID = new System.Windows.Forms.TextBox();
            this.lblSmallID = new System.Windows.Forms.Label();
            this.txbProdactColor = new System.Windows.Forms.TextBox();
            this.lblProdactColor = new System.Windows.Forms.Label();
            this.txbModelNumber = new System.Windows.Forms.TextBox();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.txbProdactPrice = new System.Windows.Forms.TextBox();
            this.lblProdactPrice = new System.Windows.Forms.Label();
            this.lblMakerName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.lblProdactHidden = new System.Windows.Forms.Label();
            this.tbxProdactHidden = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbMakerName = new System.Windows.Forms.TextBox();
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
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cmbView.Location = new System.Drawing.Point(681, 105);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(200, 31);
            this.cmbView.TabIndex = 3;
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
            // txbMajorID
            // 
            this.txbMajorID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbMajorID.Location = new System.Drawing.Point(681, 158);
            this.txbMajorID.Name = "txbMajorID";
            this.txbMajorID.Size = new System.Drawing.Size(200, 25);
            this.txbMajorID.TabIndex = 10;
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
            // txbMajorName
            // 
            this.txbMajorName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbMajorName.Location = new System.Drawing.Point(991, 158);
            this.txbMajorName.Name = "txbMajorName";
            this.txbMajorName.Size = new System.Drawing.Size(200, 25);
            this.txbMajorName.TabIndex = 12;
            // 
            // lblMajorName
            // 
            this.lblMajorName.AutoSize = true;
            this.lblMajorName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMajorName.Location = new System.Drawing.Point(907, 161);
            this.lblMajorName.Name = "lblMajorName";
            this.lblMajorName.Size = new System.Drawing.Size(80, 18);
            this.lblMajorName.TabIndex = 11;
            this.lblMajorName.Text = "大分類名";
            // 
            // txbSmallName
            // 
            this.txbSmallName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSmallName.Location = new System.Drawing.Point(991, 206);
            this.txbSmallName.Name = "txbSmallName";
            this.txbSmallName.Size = new System.Drawing.Size(200, 25);
            this.txbSmallName.TabIndex = 20;
            // 
            // lblSmallName
            // 
            this.lblSmallName.AutoSize = true;
            this.lblSmallName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSmallName.Location = new System.Drawing.Point(907, 209);
            this.lblSmallName.Name = "lblSmallName";
            this.lblSmallName.Size = new System.Drawing.Size(80, 18);
            this.lblSmallName.TabIndex = 19;
            this.lblSmallName.Text = "小分類名";
            // 
            // txbSmallID
            // 
            this.txbSmallID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSmallID.Location = new System.Drawing.Point(681, 206);
            this.txbSmallID.Name = "txbSmallID";
            this.txbSmallID.Size = new System.Drawing.Size(200, 25);
            this.txbSmallID.TabIndex = 18;
            // 
            // lblSmallID
            // 
            this.lblSmallID.AutoSize = true;
            this.lblSmallID.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSmallID.Location = new System.Drawing.Point(597, 209);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(991, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 25);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(889, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "安全在庫数";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(677, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 25);
            this.textBox2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(605, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "発売日";
            // 
            // cmbHidden
            // 
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 336);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // txbMakerName
            // 
            this.txbMakerName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbMakerName.Location = new System.Drawing.Point(96, 255);
            this.txbMakerName.Name = "txbMakerName";
            this.txbMakerName.Size = new System.Drawing.Size(200, 25);
            this.txbMakerName.TabIndex = 22;
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
            // F_HonshaProdact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1212, 753);
            this.ControlBox = false;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxProdactHidden);
            this.Controls.Add(this.lblProdactHidden);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbProdactPrice);
            this.Controls.Add(this.lblProdactPrice);
            this.Controls.Add(this.txbMakerName);
            this.Controls.Add(this.lblMakerName);
            this.Controls.Add(this.txbSmallName);
            this.Controls.Add(this.lblSmallName);
            this.Controls.Add(this.txbSmallID);
            this.Controls.Add(this.lblSmallID);
            this.Controls.Add(this.txbProdactColor);
            this.Controls.Add(this.lblProdactColor);
            this.Controls.Add(this.txbModelNumber);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.txbMajorName);
            this.Controls.Add(this.lblMajorName);
            this.Controls.Add(this.txbMajorID);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txbMajorID;
        private System.Windows.Forms.Label lblMajorID;
        private System.Windows.Forms.TextBox txbMajorName;
        private System.Windows.Forms.Label lblMajorName;
        private System.Windows.Forms.TextBox txbSmallName;
        private System.Windows.Forms.Label lblSmallName;
        private System.Windows.Forms.TextBox txbSmallID;
        private System.Windows.Forms.Label lblSmallID;
        private System.Windows.Forms.TextBox txbProdactColor;
        private System.Windows.Forms.Label lblProdactColor;
        private System.Windows.Forms.TextBox txbModelNumber;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.TextBox txbProdactPrice;
        private System.Windows.Forms.Label lblProdactPrice;
        private System.Windows.Forms.Label lblMakerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.Label lblProdactHidden;
        private System.Windows.Forms.TextBox tbxProdactHidden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbMakerName;
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
    }
}
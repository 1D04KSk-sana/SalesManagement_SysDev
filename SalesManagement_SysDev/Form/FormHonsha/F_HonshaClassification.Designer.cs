namespace SalesManagement_SysDev
{
    partial class F_HonshaClassification
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
            this.pnlClassification = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbRegister = new System.Windows.Forms.RadioButton();
            this.txbMajorName = new System.Windows.Forms.TextBox();
            this.lblMajorName = new System.Windows.Forms.Label();
            this.txbMajorID = new System.Windows.Forms.TextBox();
            this.lblMajorID = new System.Windows.Forms.Label();
            this.lblHidden = new System.Windows.Forms.Label();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblButuryuHidden = new System.Windows.Forms.Label();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.dgvMajor = new System.Windows.Forms.DataGridView();
            this.dgvSmall = new System.Windows.Forms.DataGridView();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.cmbClassfication = new System.Windows.Forms.ComboBox();
            this.lblISmallD = new System.Windows.Forms.Label();
            this.txbSmallName = new System.Windows.Forms.TextBox();
            this.lblSmallName = new System.Windows.Forms.Label();
            this.txbSmallID = new System.Windows.Forms.TextBox();
            this.pnlClassification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClassification
            // 
            this.pnlClassification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(112)))));
            this.pnlClassification.Controls.Add(this.pctHint);
            this.pnlClassification.Controls.Add(this.btnClose);
            this.pnlClassification.Controls.Add(this.lblClient);
            this.pnlClassification.Controls.Add(this.btnReturn);
            this.pnlClassification.Location = new System.Drawing.Point(0, 1);
            this.pnlClassification.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlClassification.Name = "pnlClassification";
            this.pnlClassification.Size = new System.Drawing.Size(1920, 150);
            this.pnlClassification.TabIndex = 23;
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
            this.lblClient.Location = new System.Drawing.Point(720, 46);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(417, 64);
            this.lblClient.TabIndex = 23;
            this.lblClient.Text = "分類管理画面";
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
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(469, 193);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(103, 39);
            this.rdbUpdate.TabIndex = 127;
            this.rdbUpdate.Text = "更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(624, 193);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 126;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // rdbRegister
            // 
            this.rdbRegister.AutoSize = true;
            this.rdbRegister.Checked = true;
            this.rdbRegister.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbRegister.Location = new System.Drawing.Point(321, 193);
            this.rdbRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbRegister.Name = "rdbRegister";
            this.rdbRegister.Size = new System.Drawing.Size(103, 39);
            this.rdbRegister.TabIndex = 125;
            this.rdbRegister.TabStop = true;
            this.rdbRegister.Text = "登録";
            this.rdbRegister.UseVisualStyleBackColor = true;
            // 
            // txbMajorName
            // 
            this.txbMajorName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbMajorName.Location = new System.Drawing.Point(642, 304);
            this.txbMajorName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbMajorName.Name = "txbMajorName";
            this.txbMajorName.Size = new System.Drawing.Size(220, 31);
            this.txbMajorName.TabIndex = 133;
            // 
            // lblMajorName
            // 
            this.lblMajorName.AutoSize = true;
            this.lblMajorName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblMajorName.Location = new System.Drawing.Point(516, 307);
            this.lblMajorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMajorName.Name = "lblMajorName";
            this.lblMajorName.Size = new System.Drawing.Size(106, 24);
            this.lblMajorName.TabIndex = 131;
            this.lblMajorName.Text = "大分類名";
            // 
            // txbMajorID
            // 
            this.txbMajorID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbMajorID.Location = new System.Drawing.Point(194, 304);
            this.txbMajorID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbMajorID.Name = "txbMajorID";
            this.txbMajorID.Size = new System.Drawing.Size(220, 31);
            this.txbMajorID.TabIndex = 130;
            this.txbMajorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblMajorID
            // 
            this.lblMajorID.AutoSize = true;
            this.lblMajorID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblMajorID.Location = new System.Drawing.Point(68, 307);
            this.lblMajorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMajorID.Name = "lblMajorID";
            this.lblMajorID.Size = new System.Drawing.Size(104, 24);
            this.lblMajorID.TabIndex = 136;
            this.lblMajorID.Text = "大分類ID";
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHidden.Location = new System.Drawing.Point(30, 397);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(142, 24);
            this.lblHidden.TabIndex = 141;
            this.lblHidden.Text = "表示/非表示";
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbHidden.Location = new System.Drawing.Point(642, 394);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(1093, 31);
            this.txbHidden.TabIndex = 138;
            // 
            // lblButuryuHidden
            // 
            this.lblButuryuHidden.AutoSize = true;
            this.lblButuryuHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblButuryuHidden.Location = new System.Drawing.Point(492, 397);
            this.lblButuryuHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButuryuHidden.Name = "lblButuryuHidden";
            this.lblButuryuHidden.Size = new System.Drawing.Size(130, 24);
            this.lblButuryuHidden.TabIndex = 140;
            this.lblButuryuHidden.Text = "非表示理由";
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(195, 394);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 139;
            this.cmbHidden.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1532, 180);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 143;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1725, 180);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 142;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1144, 195);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 144;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // dgvMajor
            // 
            this.dgvMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMajor.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvMajor.Location = new System.Drawing.Point(47, 491);
            this.dgvMajor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMajor.Name = "dgvMajor";
            this.dgvMajor.RowHeadersWidth = 51;
            this.dgvMajor.RowTemplate.Height = 24;
            this.dgvMajor.Size = new System.Drawing.Size(900, 480);
            this.dgvMajor.StandardTab = true;
            this.dgvMajor.TabIndex = 145;
            this.dgvMajor.TabStop = false;
            this.dgvMajor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMajor_CellClick);
            // 
            // dgvSmall
            // 
            this.dgvSmall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSmall.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvSmall.Location = new System.Drawing.Point(971, 491);
            this.dgvSmall.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSmall.Name = "dgvSmall";
            this.dgvSmall.RowHeadersWidth = 51;
            this.dgvSmall.RowTemplate.Height = 24;
            this.dgvSmall.Size = new System.Drawing.Size(900, 480);
            this.dgvSmall.TabIndex = 146;
            this.dgvSmall.TabStop = false;
            this.dgvSmall.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSmall_CellClick);
            // 
            // btnPageSize
            // 
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(284, 990);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 149;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = true;
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(21, 1000);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(114, 21);
            this.lblPageSize.TabIndex = 148;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(183, 994);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 147;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(621, 1000);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(61, 21);
            this.lblNumPage.TabIndex = 155;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(553, 997);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 154;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(708, 990);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 153;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(762, 990);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 152;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(816, 990);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 151;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(870, 990);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 150;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // cmbClassfication
            // 
            this.cmbClassfication.AutoCompleteCustomSource.AddRange(new string[] {
            "大分類",
            "小分類"});
            this.cmbClassfication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassfication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassfication.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbClassfication.FormattingEnabled = true;
            this.cmbClassfication.Items.AddRange(new object[] {
            "大分類",
            "小分類"});
            this.cmbClassfication.Location = new System.Drawing.Point(25, 192);
            this.cmbClassfication.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClassfication.Name = "cmbClassfication";
            this.cmbClassfication.Size = new System.Drawing.Size(259, 43);
            this.cmbClassfication.TabIndex = 156;
            this.cmbClassfication.TabStop = false;
            // 
            // lblISmallD
            // 
            this.lblISmallD.AutoSize = true;
            this.lblISmallD.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblISmallD.Location = new System.Drawing.Point(949, 307);
            this.lblISmallD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISmallD.Name = "lblISmallD";
            this.lblISmallD.Size = new System.Drawing.Size(104, 24);
            this.lblISmallD.TabIndex = 160;
            this.lblISmallD.Text = "小分類ID";
            // 
            // txbSmallName
            // 
            this.txbSmallName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbSmallName.Location = new System.Drawing.Point(1515, 304);
            this.txbSmallName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSmallName.Name = "txbSmallName";
            this.txbSmallName.Size = new System.Drawing.Size(220, 31);
            this.txbSmallName.TabIndex = 159;
            // 
            // lblSmallName
            // 
            this.lblSmallName.AutoSize = true;
            this.lblSmallName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblSmallName.Location = new System.Drawing.Point(1398, 307);
            this.lblSmallName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSmallName.Name = "lblSmallName";
            this.lblSmallName.Size = new System.Drawing.Size(106, 24);
            this.lblSmallName.TabIndex = 158;
            this.lblSmallName.Text = "小分類名";
            // 
            // txbSmallID
            // 
            this.txbSmallID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbSmallID.Location = new System.Drawing.Point(1067, 304);
            this.txbSmallID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSmallID.Name = "txbSmallID";
            this.txbSmallID.Size = new System.Drawing.Size(220, 31);
            this.txbSmallID.TabIndex = 157;
            // 
            // F_HonshaClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblISmallD);
            this.Controls.Add(this.txbSmallName);
            this.Controls.Add(this.lblSmallName);
            this.Controls.Add(this.txbSmallID);
            this.Controls.Add(this.cmbClassfication);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.dgvSmall);
            this.Controls.Add(this.dgvMajor);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblButuryuHidden);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.lblMajorID);
            this.Controls.Add(this.txbMajorName);
            this.Controls.Add(this.lblMajorName);
            this.Controls.Add(this.txbMajorID);
            this.Controls.Add(this.rdbUpdate);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.rdbRegister);
            this.Controls.Add(this.pnlClassification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_HonshaClassification";
            this.Text = "F_HonshaClassification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_HonshaClassification_Load);
            this.pnlClassification.ResumeLayout(false);
            this.pnlClassification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlClassification;
        private System.Windows.Forms.PictureBox pctHint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbRegister;
        private System.Windows.Forms.TextBox txbMajorName;
        private System.Windows.Forms.Label lblMajorName;
        private System.Windows.Forms.TextBox txbMajorID;
        private System.Windows.Forms.Label lblMajorID;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Label lblButuryuHidden;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.DataGridView dgvMajor;
        private System.Windows.Forms.DataGridView dgvSmall;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.ComboBox cmbClassfication;
        private System.Windows.Forms.Label lblISmallD;
        private System.Windows.Forms.TextBox txbSmallName;
        private System.Windows.Forms.Label lblSmallName;
        private System.Windows.Forms.TextBox txbSmallID;
    }
}
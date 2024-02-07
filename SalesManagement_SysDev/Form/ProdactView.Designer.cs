namespace SalesManagement_SysDev
{
    partial class ProdactView
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
            this.pnlProdactView = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblProdact = new System.Windows.Forms.Label();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.txbProdactID = new System.Windows.Forms.TextBox();
            this.lblProdactID = new System.Windows.Forms.Label();
            this.cmbSmallID = new System.Windows.Forms.ComboBox();
            this.cmbMajorID = new System.Windows.Forms.ComboBox();
            this.lblSmallID = new System.Windows.Forms.Label();
            this.lblMajorID = new System.Windows.Forms.Label();
            this.cmbMakerName = new System.Windows.Forms.ComboBox();
            this.lblMakerName = new System.Windows.Forms.Label();
            this.dtpProdactReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblProdactReleaseDate = new System.Windows.Forms.Label();
            this.btnPagesize = new System.Windows.Forms.Button();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.dgvProdact = new System.Windows.Forms.DataGridView();
            this.pnlProdactView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdact)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProdactView
            // 
            this.pnlProdactView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.pnlProdactView.Controls.Add(this.pctHint);
            this.pnlProdactView.Controls.Add(this.btnReturn);
            this.pnlProdactView.Controls.Add(this.lblProdact);
            this.pnlProdactView.Location = new System.Drawing.Point(-1, -1);
            this.pnlProdactView.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProdactView.Name = "pnlProdactView";
            this.pnlProdactView.Size = new System.Drawing.Size(1920, 150);
            this.pnlProdactView.TabIndex = 44;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1817, 39);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 74;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(35, 39);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblProdact
            // 
            this.lblProdact.AutoSize = true;
            this.lblProdact.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdact.Location = new System.Drawing.Point(843, 45);
            this.lblProdact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdact.Name = "lblProdact";
            this.lblProdact.Size = new System.Drawing.Size(287, 64);
            this.lblProdact.TabIndex = 1;
            this.lblProdact.Text = "商品一覧";
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(43, 193);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 45;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1716, 176);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 48;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1513, 178);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 46;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.cmbView.Location = new System.Drawing.Point(1192, 190);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(271, 43);
            this.cmbView.TabIndex = 49;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // txbProdactID
            // 
            this.txbProdactID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactID.Location = new System.Drawing.Point(145, 279);
            this.txbProdactID.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactID.Name = "txbProdactID";
            this.txbProdactID.Size = new System.Drawing.Size(220, 31);
            this.txbProdactID.TabIndex = 51;
            this.txbProdactID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblProdactID
            // 
            this.lblProdactID.AutoSize = true;
            this.lblProdactID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactID.Location = new System.Drawing.Point(50, 282);
            this.lblProdactID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactID.Name = "lblProdactID";
            this.lblProdactID.Size = new System.Drawing.Size(80, 24);
            this.lblProdactID.TabIndex = 50;
            this.lblProdactID.Text = "商品ID";
            // 
            // cmbSmallID
            // 
            this.cmbSmallID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmallID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSmallID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSmallID.FormattingEnabled = true;
            this.cmbSmallID.Location = new System.Drawing.Point(1120, 274);
            this.cmbSmallID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSmallID.Name = "cmbSmallID";
            this.cmbSmallID.Size = new System.Drawing.Size(220, 32);
            this.cmbSmallID.TabIndex = 55;
            // 
            // cmbMajorID
            // 
            this.cmbMajorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMajorID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbMajorID.FormattingEnabled = true;
            this.cmbMajorID.Items.AddRange(new object[] {
            "テレビ・レコーダー",
            "エアコン・冷蔵庫・洗濯機",
            "オーディオ・イヤホン・ヘッドホン",
            "携帯電話・スマートフォン"});
            this.cmbMajorID.Location = new System.Drawing.Point(621, 279);
            this.cmbMajorID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMajorID.Name = "cmbMajorID";
            this.cmbMajorID.Size = new System.Drawing.Size(220, 32);
            this.cmbMajorID.TabIndex = 54;
            this.cmbMajorID.SelectedIndexChanged += new System.EventHandler(this.cmbMajorID_SelectedIndexChanged);
            // 
            // lblSmallID
            // 
            this.lblSmallID.AutoSize = true;
            this.lblSmallID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSmallID.Location = new System.Drawing.Point(1012, 277);
            this.lblSmallID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSmallID.Name = "lblSmallID";
            this.lblSmallID.Size = new System.Drawing.Size(104, 24);
            this.lblSmallID.TabIndex = 53;
            this.lblSmallID.Text = "小分類ID";
            // 
            // lblMajorID
            // 
            this.lblMajorID.AutoSize = true;
            this.lblMajorID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMajorID.Location = new System.Drawing.Point(513, 282);
            this.lblMajorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMajorID.Name = "lblMajorID";
            this.lblMajorID.Size = new System.Drawing.Size(104, 24);
            this.lblMajorID.TabIndex = 52;
            this.lblMajorID.Text = "大分類ID";
            // 
            // cmbMakerName
            // 
            this.cmbMakerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMakerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMakerName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbMakerName.FormattingEnabled = true;
            this.cmbMakerName.Location = new System.Drawing.Point(145, 376);
            this.cmbMakerName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMakerName.Name = "cmbMakerName";
            this.cmbMakerName.Size = new System.Drawing.Size(220, 32);
            this.cmbMakerName.TabIndex = 57;
            // 
            // lblMakerName
            // 
            this.lblMakerName.AutoSize = true;
            this.lblMakerName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMakerName.Location = new System.Drawing.Point(27, 379);
            this.lblMakerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMakerName.Name = "lblMakerName";
            this.lblMakerName.Size = new System.Drawing.Size(108, 24);
            this.lblMakerName.TabIndex = 56;
            this.lblMakerName.Text = "メーカー名";
            // 
            // dtpProdactReleaseDate
            // 
            this.dtpProdactReleaseDate.CalendarFont = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpProdactReleaseDate.Checked = false;
            this.dtpProdactReleaseDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpProdactReleaseDate.Location = new System.Drawing.Point(621, 374);
            this.dtpProdactReleaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpProdactReleaseDate.Name = "dtpProdactReleaseDate";
            this.dtpProdactReleaseDate.ShowCheckBox = true;
            this.dtpProdactReleaseDate.Size = new System.Drawing.Size(220, 31);
            this.dtpProdactReleaseDate.TabIndex = 59;
            this.dtpProdactReleaseDate.TabStop = false;
            // 
            // lblProdactReleaseDate
            // 
            this.lblProdactReleaseDate.AutoSize = true;
            this.lblProdactReleaseDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdactReleaseDate.Location = new System.Drawing.Point(535, 379);
            this.lblProdactReleaseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdactReleaseDate.Name = "lblProdactReleaseDate";
            this.lblProdactReleaseDate.Size = new System.Drawing.Size(82, 24);
            this.lblProdactReleaseDate.TabIndex = 58;
            this.lblProdactReleaseDate.Text = "発売日";
            // 
            // btnPagesize
            // 
            this.btnPagesize.BackColor = System.Drawing.Color.White;
            this.btnPagesize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPagesize.Location = new System.Drawing.Point(209, 1029);
            this.btnPagesize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagesize.Name = "btnPagesize";
            this.btnPagesize.Size = new System.Drawing.Size(140, 40);
            this.btnPagesize.TabIndex = 62;
            this.btnPagesize.TabStop = false;
            this.btnPagesize.Text = "行数変更";
            this.btnPagesize.UseVisualStyleBackColor = false;
            this.btnPagesize.Click += new System.EventHandler(this.btnPagesize_Click);
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(145, 1035);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(38, 29);
            this.txbPageSize.TabIndex = 61;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(17, 1041);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(125, 22);
            this.lblPageSize.TabIndex = 60;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(1610, 1039);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(61, 21);
            this.lblNumPage.TabIndex = 118;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Enabled = false;
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(1542, 1036);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.ReadOnly = true;
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 117;
            this.txbNumPage.TabStop = false;
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(1697, 1029);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 116;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1751, 1029);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 115;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1805, 1029);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 114;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1859, 1029);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 113;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // dgvProdact
            // 
            this.dgvProdact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdact.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvProdact.Location = new System.Drawing.Point(11, 447);
            this.dgvProdact.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdact.Name = "dgvProdact";
            this.dgvProdact.RowHeadersWidth = 51;
            this.dgvProdact.RowTemplate.Height = 24;
            this.dgvProdact.Size = new System.Drawing.Size(1900, 569);
            this.dgvProdact.TabIndex = 119;
            this.dgvProdact.TabStop = false;
            this.dgvProdact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdact_CellClick);
            // 
            // ProdactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(250)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.dgvProdact);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnPagesize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.dtpProdactReleaseDate);
            this.Controls.Add(this.lblProdactReleaseDate);
            this.Controls.Add(this.cmbMakerName);
            this.Controls.Add(this.lblMakerName);
            this.Controls.Add(this.cmbSmallID);
            this.Controls.Add(this.cmbMajorID);
            this.Controls.Add(this.lblSmallID);
            this.Controls.Add(this.lblMajorID);
            this.Controls.Add(this.txbProdactID);
            this.Controls.Add(this.lblProdactID);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.pnlProdactView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdactView";
            this.Text = "ProdactView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProdactView_Load);
            this.pnlProdactView.ResumeLayout(false);
            this.pnlProdactView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProdactView;
        private System.Windows.Forms.Label lblProdact;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.TextBox txbProdactID;
        private System.Windows.Forms.Label lblProdactID;
        private System.Windows.Forms.ComboBox cmbSmallID;
        private System.Windows.Forms.ComboBox cmbMajorID;
        private System.Windows.Forms.Label lblSmallID;
        private System.Windows.Forms.Label lblMajorID;
        private System.Windows.Forms.ComboBox cmbMakerName;
        private System.Windows.Forms.Label lblMakerName;
        private System.Windows.Forms.DateTimePicker dtpProdactReleaseDate;
        private System.Windows.Forms.Label lblProdactReleaseDate;
        private System.Windows.Forms.Button btnPagesize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.DataGridView dgvProdact;
        private System.Windows.Forms.PictureBox pctHint;
    }
}
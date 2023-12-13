namespace SalesManagement_SysDev
{
    partial class F_ButuryuHattyu
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
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbRegister = new System.Windows.Forms.RadioButton();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.dgvHattyuDetail = new System.Windows.Forms.DataGridView();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.pnlHonsha = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvHattyu = new System.Windows.Forms.DataGridView();
            this.lblHattyuDate = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblMakerName = new System.Windows.Forms.Label();
            this.txbHattyuID = new System.Windows.Forms.TextBox();
            this.lblHattyuID = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbDetailRegister = new System.Windows.Forms.RadioButton();
            this.txbEmployeeID = new System.Windows.Forms.TextBox();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblButuryuHidden = new System.Windows.Forms.Label();
            this.txbHattyuQuantity = new System.Windows.Forms.TextBox();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.lbltxbHattyuQuentity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.cmbMakerName = new System.Windows.Forms.ComboBox();
            this.btnDetailClear = new System.Windows.Forms.Button();
            this.rdbConfirm = new System.Windows.Forms.RadioButton();
            this.lblHidden = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.cmbConfirm = new System.Windows.Forms.ComboBox();
            this.dtpHattyuDate = new System.Windows.Forms.DateTimePicker();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHattyuDetail)).BeginInit();
            this.pnlHonsha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHattyu)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(695, 179);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 82;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbRegister
            // 
            this.rdbRegister.AutoSize = true;
            this.rdbRegister.Checked = true;
            this.rdbRegister.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbRegister.Location = new System.Drawing.Point(28, 179);
            this.rdbRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbRegister.Name = "rdbRegister";
            this.rdbRegister.Size = new System.Drawing.Size(103, 39);
            this.rdbRegister.TabIndex = 107;
            this.rdbRegister.TabStop = true;
            this.rdbRegister.Text = "登録";
            this.rdbRegister.UseVisualStyleBackColor = true;
            this.rdbRegister.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(186, 433);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 108;
            this.cmbHidden.TabStop = false;
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(880, 1022);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(61, 21);
            this.lblNumPage.TabIndex = 106;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(812, 1019);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 105;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(967, 1012);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 104;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1021, 1012);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 103;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1075, 1012);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 102;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1129, 1012);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 101;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // dgvHattyuDetail
            // 
            this.dgvHattyuDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHattyuDetail.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvHattyuDetail.Location = new System.Drawing.Point(1193, 523);
            this.dgvHattyuDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHattyuDetail.Name = "dgvHattyuDetail";
            this.dgvHattyuDetail.RowHeadersWidth = 51;
            this.dgvHattyuDetail.RowTemplate.Height = 24;
            this.dgvHattyuDetail.Size = new System.Drawing.Size(700, 480);
            this.dgvHattyuDetail.TabIndex = 100;
            this.dgvHattyuDetail.TabStop = false;
            this.dgvHattyuDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHattyuDetail_CellClick_1);
            // 
            // btnPageSize
            // 
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(287, 1015);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 99;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = true;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(24, 1025);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(114, 21);
            this.lblPageSize.TabIndex = 98;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(186, 1019);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 97;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(884, 175);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 96;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // pnlHonsha
            // 
            this.pnlHonsha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(179)))));
            this.pnlHonsha.Controls.Add(this.pctHint);
            this.pnlHonsha.Controls.Add(this.btnClose);
            this.pnlHonsha.Controls.Add(this.lblClient);
            this.pnlHonsha.Controls.Add(this.btnReturn);
            this.pnlHonsha.Location = new System.Drawing.Point(-8, -14);
            this.pnlHonsha.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHonsha.Name = "pnlHonsha";
            this.pnlHonsha.Size = new System.Drawing.Size(1920, 150);
            this.pnlHonsha.TabIndex = 95;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1614, 51);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 130;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1707, 47);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 128;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(780, 47);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(417, 64);
            this.lblClient.TabIndex = 23;
            this.lblClient.Text = "発注管理画面";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(56, 47);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1506, 160);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 94;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvHattyu
            // 
            this.dgvHattyu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHattyu.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvHattyu.Location = new System.Drawing.Point(11, 523);
            this.dgvHattyu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHattyu.Name = "dgvHattyu";
            this.dgvHattyu.RowHeadersWidth = 51;
            this.dgvHattyu.RowTemplate.Height = 24;
            this.dgvHattyu.Size = new System.Drawing.Size(1170, 480);
            this.dgvHattyu.TabIndex = 92;
            this.dgvHattyu.TabStop = false;
            this.dgvHattyu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHattyu_CellClick);
            // 
            // lblHattyuDate
            // 
            this.lblHattyuDate.AutoSize = true;
            this.lblHattyuDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHattyuDate.Location = new System.Drawing.Point(455, 352);
            this.lblHattyuDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHattyuDate.Name = "lblHattyuDate";
            this.lblHattyuDate.Size = new System.Drawing.Size(130, 24);
            this.lblHattyuDate.TabIndex = 91;
            this.lblHattyuDate.Text = "発注年月日";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeID.Location = new System.Drawing.Point(455, 278);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(80, 24);
            this.lblEmployeeID.TabIndex = 87;
            this.lblEmployeeID.Text = "社員ID";
            // 
            // lblMakerName
            // 
            this.lblMakerName.AutoSize = true;
            this.lblMakerName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMakerName.Location = new System.Drawing.Point(53, 352);
            this.lblMakerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMakerName.Name = "lblMakerName";
            this.lblMakerName.Size = new System.Drawing.Size(108, 24);
            this.lblMakerName.TabIndex = 85;
            this.lblMakerName.Text = "メーカー名";
            // 
            // txbHattyuID
            // 
            this.txbHattyuID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbHattyuID.Location = new System.Drawing.Point(186, 275);
            this.txbHattyuID.Margin = new System.Windows.Forms.Padding(2);
            this.txbHattyuID.Name = "txbHattyuID";
            this.txbHattyuID.ShortcutsEnabled = false;
            this.txbHattyuID.Size = new System.Drawing.Size(220, 31);
            this.txbHattyuID.TabIndex = 84;
            // 
            // lblHattyuID
            // 
            this.lblHattyuID.AutoSize = true;
            this.lblHattyuID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHattyuID.Location = new System.Drawing.Point(81, 278);
            this.lblHattyuID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHattyuID.Name = "lblHattyuID";
            this.lblHattyuID.Size = new System.Drawing.Size(80, 24);
            this.lblHattyuID.TabIndex = 83;
            this.lblHattyuID.Text = "発注ID";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1699, 160);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 93;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(352, 179);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(173, 39);
            this.rdbUpdate.TabIndex = 110;
            this.rdbUpdate.Text = "表示更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbDetailRegister
            // 
            this.rdbDetailRegister.AutoSize = true;
            this.rdbDetailRegister.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbDetailRegister.Location = new System.Drawing.Point(154, 179);
            this.rdbDetailRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbDetailRegister.Name = "rdbDetailRegister";
            this.rdbDetailRegister.Size = new System.Drawing.Size(173, 39);
            this.rdbDetailRegister.TabIndex = 111;
            this.rdbDetailRegister.Text = "詳細登録";
            this.rdbDetailRegister.UseVisualStyleBackColor = true;
            this.rdbDetailRegister.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeID.Location = new System.Drawing.Point(639, 275);
            this.txbEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.ShortcutsEnabled = false;
            this.txbEmployeeID.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeID.TabIndex = 85;
            this.txbEmployeeID.TextChanged += new System.EventHandler(this.txbEmployeeID_TextChanged);
            this.txbEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbHidden.Location = new System.Drawing.Point(639, 433);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(662, 31);
            this.txbHidden.TabIndex = 86;
            // 
            // lblButuryuHidden
            // 
            this.lblButuryuHidden.AutoSize = true;
            this.lblButuryuHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblButuryuHidden.Location = new System.Drawing.Point(455, 436);
            this.lblButuryuHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButuryuHidden.Name = "lblButuryuHidden";
            this.lblButuryuHidden.Size = new System.Drawing.Size(130, 24);
            this.lblButuryuHidden.TabIndex = 113;
            this.lblButuryuHidden.Text = "非表示理由";
            // 
            // txbHattyuQuantity
            // 
            this.txbHattyuQuantity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbHattyuQuantity.Location = new System.Drawing.Point(1587, 412);
            this.txbHattyuQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txbHattyuQuantity.Name = "txbHattyuQuantity";
            this.txbHattyuQuantity.ShortcutsEnabled = false;
            this.txbHattyuQuantity.Size = new System.Drawing.Size(220, 31);
            this.txbHattyuQuantity.TabIndex = 89;
            // 
            // txbProductName
            // 
            this.txbProductName.Enabled = false;
            this.txbProductName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductName.Location = new System.Drawing.Point(1587, 359);
            this.txbProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.ReadOnly = true;
            this.txbProductName.ShortcutsEnabled = false;
            this.txbProductName.Size = new System.Drawing.Size(220, 31);
            this.txbProductName.TabIndex = 90;
            // 
            // txbProductID
            // 
            this.txbProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductID.Location = new System.Drawing.Point(1587, 305);
            this.txbProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.ShortcutsEnabled = false;
            this.txbProductID.Size = new System.Drawing.Size(220, 31);
            this.txbProductID.TabIndex = 88;
            this.txbProductID.TextChanged += new System.EventHandler(this.txbProductID_TextChanged);
            this.txbProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lbltxbHattyuQuentity
            // 
            this.lbltxbHattyuQuentity.AutoSize = true;
            this.lbltxbHattyuQuentity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltxbHattyuQuentity.Location = new System.Drawing.Point(1486, 415);
            this.lbltxbHattyuQuentity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltxbHattyuQuentity.Name = "lbltxbHattyuQuentity";
            this.lbltxbHattyuQuentity.Size = new System.Drawing.Size(58, 24);
            this.lbltxbHattyuQuentity.TabIndex = 118;
            this.lbltxbHattyuQuentity.Text = "数量";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProductName.Location = new System.Drawing.Point(1462, 362);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(82, 24);
            this.lblProductName.TabIndex = 119;
            this.lblProductName.Text = "商品名";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProductID.Location = new System.Drawing.Point(1464, 305);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(80, 24);
            this.lblProductID.TabIndex = 120;
            this.lblProductID.Text = "商品ID";
            // 
            // cmbMakerName
            // 
            this.cmbMakerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMakerName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbMakerName.FormattingEnabled = true;
            this.cmbMakerName.Location = new System.Drawing.Point(186, 349);
            this.cmbMakerName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMakerName.Name = "cmbMakerName";
            this.cmbMakerName.Size = new System.Drawing.Size(220, 32);
            this.cmbMakerName.TabIndex = 121;
            this.cmbMakerName.TabStop = false;
            // 
            // btnDetailClear
            // 
            this.btnDetailClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDetailClear.Location = new System.Drawing.Point(1285, 160);
            this.btnDetailClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetailClear.Name = "btnDetailClear";
            this.btnDetailClear.Size = new System.Drawing.Size(187, 70);
            this.btnDetailClear.TabIndex = 122;
            this.btnDetailClear.TabStop = false;
            this.btnDetailClear.Text = "詳細クリア";
            this.btnDetailClear.UseVisualStyleBackColor = true;
            this.btnDetailClear.Click += new System.EventHandler(this.btnDetailClear_Click);
            // 
            // rdbConfirm
            // 
            this.rdbConfirm.AutoSize = true;
            this.rdbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbConfirm.Location = new System.Drawing.Point(563, 179);
            this.rdbConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbConfirm.Name = "rdbConfirm";
            this.rdbConfirm.Size = new System.Drawing.Size(103, 39);
            this.rdbConfirm.TabIndex = 123;
            this.rdbConfirm.Text = "確定";
            this.rdbConfirm.UseVisualStyleBackColor = true;
            this.rdbConfirm.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHidden.Location = new System.Drawing.Point(19, 436);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(142, 24);
            this.lblHidden.TabIndex = 124;
            this.lblHidden.Text = "表示/非表示";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConfirm.Location = new System.Drawing.Point(909, 352);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(142, 24);
            this.lblConfirm.TabIndex = 125;
            this.lblConfirm.Text = "未確定/確定";
            // 
            // cmbConfirm
            // 
            this.cmbConfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbConfirm.FormattingEnabled = true;
            this.cmbConfirm.Items.AddRange(new object[] {
            "未確定",
            "確定"});
            this.cmbConfirm.Location = new System.Drawing.Point(1081, 348);
            this.cmbConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbConfirm.Name = "cmbConfirm";
            this.cmbConfirm.Size = new System.Drawing.Size(220, 32);
            this.cmbConfirm.TabIndex = 126;
            this.cmbConfirm.TabStop = false;
            // 
            // dtpHattyuDate
            // 
            this.dtpHattyuDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpHattyuDate.Location = new System.Drawing.Point(639, 349);
            this.dtpHattyuDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHattyuDate.Name = "dtpHattyuDate";
            this.dtpHattyuDate.ShowCheckBox = true;
            this.dtpHattyuDate.Size = new System.Drawing.Size(220, 31);
            this.dtpHattyuDate.TabIndex = 127;
            this.dtpHattyuDate.TabStop = false;
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Enabled = false;
            this.txbEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeName.Location = new System.Drawing.Point(1081, 275);
            this.txbEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.ReadOnly = true;
            this.txbEmployeeName.ShortcutsEnabled = false;
            this.txbEmployeeName.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeName.TabIndex = 128;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeName.Location = new System.Drawing.Point(969, 278);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(82, 24);
            this.lblEmployeeName.TabIndex = 129;
            this.lblEmployeeName.Text = "社員名";
            // 
            // F_ButuryuHattyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.dtpHattyuDate);
            this.Controls.Add(this.cmbConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.rdbConfirm);
            this.Controls.Add(this.btnDetailClear);
            this.Controls.Add(this.cmbMakerName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lbltxbHattyuQuentity);
            this.Controls.Add(this.txbProductID);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.txbHattyuQuantity);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblButuryuHidden);
            this.Controls.Add(this.txbEmployeeID);
            this.Controls.Add(this.rdbDetailRegister);
            this.Controls.Add(this.rdbUpdate);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.rdbRegister);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.dgvHattyuDetail);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.pnlHonsha);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvHattyu);
            this.Controls.Add(this.lblHattyuDate);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblMakerName);
            this.Controls.Add(this.txbHattyuID);
            this.Controls.Add(this.lblHattyuID);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_ButuryuHattyu";
            this.Text = "F_ButuryuHattyu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_ButuryuHattyu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHattyuDetail)).EndInit();
            this.pnlHonsha.ResumeLayout(false);
            this.pnlHonsha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHattyu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbRegister;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.DataGridView dgvHattyuDetail;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Panel pnlHonsha;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvHattyu;
        private System.Windows.Forms.Label lblHattyuDate;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblMakerName;
        private System.Windows.Forms.TextBox txbHattyuID;
        private System.Windows.Forms.Label lblHattyuID;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbDetailRegister;
        private System.Windows.Forms.TextBox txbEmployeeID;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Label lblButuryuHidden;
        private System.Windows.Forms.TextBox txbHattyuQuantity;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.Label lbltxbHattyuQuentity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ComboBox cmbMakerName;
        private System.Windows.Forms.Button btnDetailClear;
        private System.Windows.Forms.RadioButton rdbConfirm;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.ComboBox cmbConfirm;
        private System.Windows.Forms.DateTimePicker dtpHattyuDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.PictureBox pctHint;
    }
}
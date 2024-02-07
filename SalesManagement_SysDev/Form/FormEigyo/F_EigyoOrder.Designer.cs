namespace SalesManagement_SysDev
{
    partial class F_EigyoOrder
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
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblClientHidden = new System.Windows.Forms.Label();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.lblSalesOfficeID = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txbOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbConfirm = new System.Windows.Forms.RadioButton();
            this.rdbDetailRegister = new System.Windows.Forms.RadioButton();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbRegister = new System.Windows.Forms.RadioButton();
            this.btnDone = new System.Windows.Forms.Button();
            this.pnlHonsha = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.txbOrderManager = new System.Windows.Forms.TextBox();
            this.lblOrderManager = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblHidden = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.txbOrderQuantity = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txbEmployeeID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.cmbConfirm = new System.Windows.Forms.ComboBox();
            this.btnDetailClear = new System.Windows.Forms.Button();
            this.btnProdactView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlHonsha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(895, 1050);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(61, 21);
            this.lblNumPage.TabIndex = 63;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Enabled = false;
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(833, 1045);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.ReadOnly = true;
            this.txbNumPage.Size = new System.Drawing.Size(58, 28);
            this.txbNumPage.TabIndex = 62;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(984, 1035);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 61;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1038, 1035);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 60;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1092, 1036);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 59;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1151, 1036);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 58;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // btnPageSize
            // 
            this.btnPageSize.BackColor = System.Drawing.Color.White;
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(226, 1035);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 57;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = false;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(28, 1045);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(114, 21);
            this.lblPageSize.TabIndex = 56;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(150, 1042);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 55;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // cmbView
            // 
            this.cmbView.BackColor = System.Drawing.Color.White;
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(984, 184);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(290, 43);
            this.cmbView.TabIndex = 54;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1329, 173);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 53;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbHidden
            // 
            this.cmbHidden.BackColor = System.Drawing.Color.White;
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(195, 449);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 52;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvOrder.Location = new System.Drawing.Point(11, 506);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(1190, 525);
            this.dgvOrder.TabIndex = 50;
            this.dgvOrder.TabStop = false;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbHidden.ForeColor = System.Drawing.Color.Black;
            this.txbHidden.Location = new System.Drawing.Point(663, 449);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(691, 31);
            this.txbHidden.TabIndex = 49;
            // 
            // lblClientHidden
            // 
            this.lblClientHidden.AutoSize = true;
            this.lblClientHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientHidden.Location = new System.Drawing.Point(517, 452);
            this.lblClientHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientHidden.Name = "lblClientHidden";
            this.lblClientHidden.Size = new System.Drawing.Size(130, 24);
            this.lblClientHidden.TabIndex = 48;
            this.lblClientHidden.Text = "非表示理由";
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOfficeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(195, 383);
            this.cmbSalesOfficeID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(220, 32);
            this.cmbSalesOfficeID.TabIndex = 40;
            // 
            // lblSalesOfficeID
            // 
            this.lblSalesOfficeID.AutoSize = true;
            this.lblSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSalesOfficeID.Location = new System.Drawing.Point(70, 389);
            this.lblSalesOfficeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesOfficeID.Name = "lblSalesOfficeID";
            this.lblSalesOfficeID.Size = new System.Drawing.Size(106, 24);
            this.lblSalesOfficeID.TabIndex = 38;
            this.lblSalesOfficeID.Text = "営業所名";
            // 
            // txbClientName
            // 
            this.txbClientName.Enabled = false;
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientName.ForeColor = System.Drawing.Color.Black;
            this.txbClientName.Location = new System.Drawing.Point(1134, 330);
            this.txbClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.ReadOnly = true;
            this.txbClientName.Size = new System.Drawing.Size(220, 31);
            this.txbClientName.TabIndex = 37;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientName.Location = new System.Drawing.Point(1034, 337);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(82, 24);
            this.lblClientName.TabIndex = 36;
            this.lblClientName.Text = "顧客名";
            // 
            // txbOrderID
            // 
            this.txbOrderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOrderID.ForeColor = System.Drawing.Color.Black;
            this.txbOrderID.Location = new System.Drawing.Point(195, 271);
            this.txbOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txbOrderID.Name = "txbOrderID";
            this.txbOrderID.Size = new System.Drawing.Size(220, 31);
            this.txbOrderID.TabIndex = 35;
            this.txbOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOrderID.Location = new System.Drawing.Point(90, 274);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(80, 24);
            this.lblOrderID.TabIndex = 34;
            this.lblOrderID.Text = "受注ID";
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(329, 185);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(208, 39);
            this.rdbUpdate.TabIndex = 5;
            this.rdbUpdate.Text = "非表示更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbConfirm
            // 
            this.rdbConfirm.AutoSize = true;
            this.rdbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbConfirm.Location = new System.Drawing.Point(541, 185);
            this.rdbConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.rdbConfirm.Name = "rdbConfirm";
            this.rdbConfirm.Size = new System.Drawing.Size(103, 39);
            this.rdbConfirm.TabIndex = 4;
            this.rdbConfirm.Text = "確定";
            this.rdbConfirm.UseVisualStyleBackColor = true;
            this.rdbConfirm.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbDetailRegister
            // 
            this.rdbDetailRegister.AutoSize = true;
            this.rdbDetailRegister.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbDetailRegister.Location = new System.Drawing.Point(152, 185);
            this.rdbDetailRegister.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDetailRegister.Name = "rdbDetailRegister";
            this.rdbDetailRegister.Size = new System.Drawing.Size(173, 39);
            this.rdbDetailRegister.TabIndex = 3;
            this.rdbDetailRegister.Text = "詳細登録";
            this.rdbDetailRegister.UseVisualStyleBackColor = true;
            this.rdbDetailRegister.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(648, 185);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 2;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbRegister
            // 
            this.rdbRegister.AutoSize = true;
            this.rdbRegister.Checked = true;
            this.rdbRegister.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbRegister.Location = new System.Drawing.Point(45, 185);
            this.rdbRegister.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRegister.Name = "rdbRegister";
            this.rdbRegister.Size = new System.Drawing.Size(103, 39);
            this.rdbRegister.TabIndex = 0;
            this.rdbRegister.TabStop = true;
            this.rdbRegister.Text = "登録";
            this.rdbRegister.UseVisualStyleBackColor = true;
            this.rdbRegister.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1721, 173);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 51;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pnlHonsha
            // 
            this.pnlHonsha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(128)))));
            this.pnlHonsha.Controls.Add(this.pctHint);
            this.pnlHonsha.Controls.Add(this.button1);
            this.pnlHonsha.Controls.Add(this.lblOrder);
            this.pnlHonsha.Controls.Add(this.btnReturn);
            this.pnlHonsha.Location = new System.Drawing.Point(0, 0);
            this.pnlHonsha.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHonsha.Name = "pnlHonsha";
            this.pnlHonsha.Size = new System.Drawing.Size(1920, 150);
            this.pnlHonsha.TabIndex = 64;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1638, 42);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 88;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1721, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 70);
            this.button1.TabIndex = 88;
            this.button1.TabStop = false;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOrder.ForeColor = System.Drawing.Color.Black;
            this.lblOrder.Location = new System.Drawing.Point(854, 42);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(287, 64);
            this.lblOrder.TabIndex = 23;
            this.lblOrder.Text = "受注管理";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(32, 36);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvOrderDetail.Location = new System.Drawing.Point(1209, 506);
            this.dgvOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(700, 525);
            this.dgvOrderDetail.TabIndex = 65;
            this.dgvOrderDetail.TabStop = false;
            this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellClick);
            // 
            // txbOrderManager
            // 
            this.txbOrderManager.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOrderManager.ForeColor = System.Drawing.Color.Black;
            this.txbOrderManager.Location = new System.Drawing.Point(195, 330);
            this.txbOrderManager.Margin = new System.Windows.Forms.Padding(2);
            this.txbOrderManager.Name = "txbOrderManager";
            this.txbOrderManager.Size = new System.Drawing.Size(220, 31);
            this.txbOrderManager.TabIndex = 67;
            // 
            // lblOrderManager
            // 
            this.lblOrderManager.AutoSize = true;
            this.lblOrderManager.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOrderManager.Location = new System.Drawing.Point(22, 334);
            this.lblOrderManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderManager.Name = "lblOrderManager";
            this.lblOrderManager.Size = new System.Drawing.Size(154, 24);
            this.lblOrderManager.TabIndex = 66;
            this.lblOrderManager.Text = "顧客担当者名";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Enabled = false;
            this.txbEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.txbEmployeeName.Location = new System.Drawing.Point(1134, 274);
            this.txbEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.ReadOnly = true;
            this.txbEmployeeName.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeName.TabIndex = 69;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeName.Location = new System.Drawing.Point(1034, 277);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(82, 24);
            this.lblEmployeeName.TabIndex = 68;
            this.lblEmployeeName.Text = "社員名";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOrderDate.Location = new System.Drawing.Point(1000, 389);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(130, 24);
            this.lblOrderDate.TabIndex = 70;
            this.lblOrderDate.Text = "受注年月日";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Checked = false;
            this.dtpOrderDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpOrderDate.Location = new System.Drawing.Point(1134, 384);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.ShowCheckBox = true;
            this.dtpOrderDate.Size = new System.Drawing.Size(220, 31);
            this.dtpOrderDate.TabIndex = 71;
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHidden.Location = new System.Drawing.Point(28, 452);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(142, 24);
            this.lblHidden.TabIndex = 73;
            this.lblHidden.Text = "表示/非表示";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProductID.Location = new System.Drawing.Point(1521, 277);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(80, 24);
            this.lblProductID.TabIndex = 76;
            this.lblProductID.Text = "商品ID";
            // 
            // txbProductID
            // 
            this.txbProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductID.ForeColor = System.Drawing.Color.Black;
            this.txbProductID.Location = new System.Drawing.Point(1638, 274);
            this.txbProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductID.MaxLength = 4;
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(220, 31);
            this.txbProductID.TabIndex = 75;
            this.txbProductID.TextChanged += new System.EventHandler(this.txbProductID_TextChanged);
            this.txbProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOrderQuantity.Location = new System.Drawing.Point(1521, 389);
            this.lblOrderQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(82, 24);
            this.lblOrderQuantity.TabIndex = 78;
            this.lblOrderQuantity.Text = "発注量";
            // 
            // txbOrderQuantity
            // 
            this.txbOrderQuantity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOrderQuantity.ForeColor = System.Drawing.Color.Black;
            this.txbOrderQuantity.Location = new System.Drawing.Point(1638, 386);
            this.txbOrderQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txbOrderQuantity.Name = "txbOrderQuantity";
            this.txbOrderQuantity.Size = new System.Drawing.Size(220, 31);
            this.txbOrderQuantity.TabIndex = 77;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProductName.Location = new System.Drawing.Point(1521, 333);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(82, 24);
            this.lblProductName.TabIndex = 79;
            this.lblProductName.Text = "商品名";
            // 
            // txbProductName
            // 
            this.txbProductName.BackColor = System.Drawing.SystemColors.Control;
            this.txbProductName.Enabled = false;
            this.txbProductName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductName.ForeColor = System.Drawing.Color.Black;
            this.txbProductName.Location = new System.Drawing.Point(1638, 327);
            this.txbProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.ReadOnly = true;
            this.txbProductName.Size = new System.Drawing.Size(220, 31);
            this.txbProductName.TabIndex = 80;
            // 
            // txbClientID
            // 
            this.txbClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientID.ForeColor = System.Drawing.Color.Black;
            this.txbClientID.Location = new System.Drawing.Point(663, 337);
            this.txbClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(220, 31);
            this.txbClientID.TabIndex = 84;
            this.txbClientID.TextChanged += new System.EventHandler(this.txbClientID_TextChanged);
            this.txbClientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeID.Location = new System.Drawing.Point(558, 278);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(80, 24);
            this.lblEmployeeID.TabIndex = 83;
            this.lblEmployeeID.Text = "社員ID";
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.txbEmployeeID.Location = new System.Drawing.Point(663, 274);
            this.txbEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeID.TabIndex = 82;
            this.txbEmployeeID.TextChanged += new System.EventHandler(this.txbEmployeeID_TextChanged);
            this.txbEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientID.Location = new System.Drawing.Point(558, 340);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(80, 24);
            this.lblClientID.TabIndex = 81;
            this.lblClientID.Text = "顧客ID";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConfirm.Location = new System.Drawing.Point(505, 393);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(142, 24);
            this.lblConfirm.TabIndex = 85;
            this.lblConfirm.Text = "未確定/確定";
            // 
            // cmbConfirm
            // 
            this.cmbConfirm.BackColor = System.Drawing.Color.White;
            this.cmbConfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbConfirm.FormattingEnabled = true;
            this.cmbConfirm.Items.AddRange(new object[] {
            "未確定",
            "確定"});
            this.cmbConfirm.Location = new System.Drawing.Point(666, 389);
            this.cmbConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.cmbConfirm.Name = "cmbConfirm";
            this.cmbConfirm.Size = new System.Drawing.Size(220, 32);
            this.cmbConfirm.TabIndex = 86;
            // 
            // btnDetailClear
            // 
            this.btnDetailClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDetailClear.Location = new System.Drawing.Point(1510, 173);
            this.btnDetailClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetailClear.Name = "btnDetailClear";
            this.btnDetailClear.Size = new System.Drawing.Size(187, 70);
            this.btnDetailClear.TabIndex = 87;
            this.btnDetailClear.TabStop = false;
            this.btnDetailClear.Text = "詳細クリア";
            this.btnDetailClear.UseVisualStyleBackColor = true;
            this.btnDetailClear.Click += new System.EventHandler(this.btnDetailClear_Click);
            // 
            // btnProdactView
            // 
            this.btnProdactView.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnProdactView.Location = new System.Drawing.Point(1654, 443);
            this.btnProdactView.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdactView.Name = "btnProdactView";
            this.btnProdactView.Size = new System.Drawing.Size(204, 43);
            this.btnProdactView.TabIndex = 132;
            this.btnProdactView.TabStop = false;
            this.btnProdactView.Text = "商品一覧";
            this.btnProdactView.UseVisualStyleBackColor = true;
            this.btnProdactView.Click += new System.EventHandler(this.btnProdactView_Click);
            // 
            // F_EigyoOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnProdactView);
            this.Controls.Add(this.rdbUpdate);
            this.Controls.Add(this.rdbConfirm);
            this.Controls.Add(this.btnDetailClear);
            this.Controls.Add(this.rdbDetailRegister);
            this.Controls.Add(this.txbOrderManager);
            this.Controls.Add(this.lblSalesOfficeID);
            this.Controls.Add(this.cmbConfirm);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.lblOrderManager);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.rdbRegister);
            this.Controls.Add(this.txbClientID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txbEmployeeID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblOrderQuantity);
            this.Controls.Add(this.txbOrderQuantity);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txbProductID);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.pnlHonsha);
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
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblClientHidden);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txbOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_EigyoOrder";
            this.Text = "F_EigyoOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_EigyoOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlHonsha.ResumeLayout(false);
            this.pnlHonsha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Label lblClientHidden;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.Label lblSalesOfficeID;
        private System.Windows.Forms.TextBox txbClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txbOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbRegister;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel pnlHonsha;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.TextBox txbOrderManager;
        private System.Windows.Forms.Label lblOrderManager;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.TextBox txbOrderQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.RadioButton rdbDetailRegister;
        private System.Windows.Forms.RadioButton rdbConfirm;
        private System.Windows.Forms.TextBox txbClientID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txbEmployeeID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.ComboBox cmbConfirm;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.Button btnDetailClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctHint;
        private System.Windows.Forms.Button btnProdactView;
    }
}
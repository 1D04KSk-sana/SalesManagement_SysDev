﻿namespace SalesManagement_SysDev
{
    partial class F_ButuryuSyukko
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
            this.pnlButuryu = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblButuryuSyukko = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.txbSyukkoID = new System.Windows.Forms.TextBox();
            this.lblSyukkoID = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.lblSalesOfficeID = new System.Windows.Forms.Label();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblChumonID = new System.Windows.Forms.Label();
            this.txbOrderID = new System.Windows.Forms.TextBox();
            this.lblSyukkoDate = new System.Windows.Forms.Label();
            this.dtpSyukkoDate = new System.Windows.Forms.DateTimePicker();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblHidden = new System.Windows.Forms.Label();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.btnPagesize = new System.Windows.Forms.Button();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.rdbConfirm = new System.Windows.Forms.RadioButton();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConfirm = new System.Windows.Forms.ComboBox();
            this.dgvSyukko = new System.Windows.Forms.DataGridView();
            this.dgvSyukkoDetail = new System.Windows.Forms.DataGridView();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.txbEmployeeID = new System.Windows.Forms.TextBox();
            this.rdbHidden = new System.Windows.Forms.RadioButton();
            this.pnlButuryu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyukko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyukkoDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButuryu
            // 
            this.pnlButuryu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(179)))));
            this.pnlButuryu.Controls.Add(this.pctHint);
            this.pnlButuryu.Controls.Add(this.btnClose);
            this.pnlButuryu.Controls.Add(this.lblButuryuSyukko);
            this.pnlButuryu.Controls.Add(this.btnReturn);
            this.pnlButuryu.Location = new System.Drawing.Point(0, 0);
            this.pnlButuryu.Name = "pnlButuryu";
            this.pnlButuryu.Size = new System.Drawing.Size(1920, 150);
            this.pnlButuryu.TabIndex = 0;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1654, 54);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 41;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1742, 44);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 64;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblButuryuSyukko
            // 
            this.lblButuryuSyukko.AutoSize = true;
            this.lblButuryuSyukko.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblButuryuSyukko.ForeColor = System.Drawing.Color.Black;
            this.lblButuryuSyukko.Location = new System.Drawing.Point(818, 44);
            this.lblButuryuSyukko.Name = "lblButuryuSyukko";
            this.lblButuryuSyukko.Size = new System.Drawing.Size(287, 64);
            this.lblButuryuSyukko.TabIndex = 1;
            this.lblButuryuSyukko.Text = "出庫管理";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(50, 44);
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
            this.btnClear.Location = new System.Drawing.Point(1493, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1680, 179);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 2;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1106, 194);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 3;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // txbSyukkoID
            // 
            this.txbSyukkoID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSyukkoID.Location = new System.Drawing.Point(193, 278);
            this.txbSyukkoID.Name = "txbSyukkoID";
            this.txbSyukkoID.Size = new System.Drawing.Size(220, 31);
            this.txbSyukkoID.TabIndex = 4;
            this.txbSyukkoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblSyukkoID
            // 
            this.lblSyukkoID.AutoSize = true;
            this.lblSyukkoID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSyukkoID.Location = new System.Drawing.Point(107, 281);
            this.lblSyukkoID.Name = "lblSyukkoID";
            this.lblSyukkoID.Size = new System.Drawing.Size(80, 24);
            this.lblSyukkoID.TabIndex = 5;
            this.lblSyukkoID.Text = "出庫ID";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientID.Location = new System.Drawing.Point(108, 414);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(80, 24);
            this.lblClientID.TabIndex = 7;
            this.lblClientID.Text = "顧客ID";
            // 
            // txbClientID
            // 
            this.txbClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientID.Location = new System.Drawing.Point(193, 411);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(220, 31);
            this.txbClientID.TabIndex = 6;
            this.txbClientID.TextChanged += new System.EventHandler(this.txbClientID_TextChanged);
            this.txbClientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblSalesOfficeID
            // 
            this.lblSalesOfficeID.AutoSize = true;
            this.lblSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSalesOfficeID.Location = new System.Drawing.Point(749, 278);
            this.lblSalesOfficeID.Name = "lblSalesOfficeID";
            this.lblSalesOfficeID.Size = new System.Drawing.Size(106, 24);
            this.lblSalesOfficeID.TabIndex = 9;
            this.lblSalesOfficeID.Text = "営業所名";
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOfficeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(876, 275);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(220, 32);
            this.cmbSalesOfficeID.TabIndex = 10;
            this.cmbSalesOfficeID.TabStop = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeName.Location = new System.Drawing.Point(428, 350);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(82, 24);
            this.lblEmployeeName.TabIndex = 12;
            this.lblEmployeeName.Text = "社員名";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Enabled = false;
            this.txbEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeName.Location = new System.Drawing.Point(514, 347);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.ReadOnly = true;
            this.txbEmployeeName.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeName.TabIndex = 11;
            // 
            // lblChumonID
            // 
            this.lblChumonID.AutoSize = true;
            this.lblChumonID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblChumonID.Location = new System.Drawing.Point(428, 281);
            this.lblChumonID.Name = "lblChumonID";
            this.lblChumonID.Size = new System.Drawing.Size(80, 24);
            this.lblChumonID.TabIndex = 14;
            this.lblChumonID.Text = "受注ID";
            // 
            // txbOrderID
            // 
            this.txbOrderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOrderID.Location = new System.Drawing.Point(514, 278);
            this.txbOrderID.Name = "txbOrderID";
            this.txbOrderID.Size = new System.Drawing.Size(220, 31);
            this.txbOrderID.TabIndex = 13;
            this.txbOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblSyukkoDate
            // 
            this.lblSyukkoDate.AutoSize = true;
            this.lblSyukkoDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSyukkoDate.Location = new System.Drawing.Point(749, 350);
            this.lblSyukkoDate.Name = "lblSyukkoDate";
            this.lblSyukkoDate.Size = new System.Drawing.Size(130, 24);
            this.lblSyukkoDate.TabIndex = 15;
            this.lblSyukkoDate.Text = "出庫年月日";
            // 
            // dtpSyukkoDate
            // 
            this.dtpSyukkoDate.CalendarFont = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpSyukkoDate.Checked = false;
            this.dtpSyukkoDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpSyukkoDate.Location = new System.Drawing.Point(876, 345);
            this.dtpSyukkoDate.Name = "dtpSyukkoDate";
            this.dtpSyukkoDate.ShowCheckBox = true;
            this.dtpSyukkoDate.Size = new System.Drawing.Size(220, 31);
            this.dtpSyukkoDate.TabIndex = 16;
            this.dtpSyukkoDate.TabStop = false;
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
            this.cmbHidden.Location = new System.Drawing.Point(1620, 278);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 17;
            this.cmbHidden.TabStop = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConfirm.Location = new System.Drawing.Point(1472, 281);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(142, 24);
            this.lblConfirm.TabIndex = 18;
            this.lblConfirm.Text = "表示/非表示";
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHidden.Location = new System.Drawing.Point(1102, 350);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(130, 24);
            this.lblHidden.TabIndex = 19;
            this.lblHidden.Text = "非表示理由";
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbHidden.Location = new System.Drawing.Point(1246, 347);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(594, 31);
            this.txbHidden.TabIndex = 20;
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(46, 1026);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(120, 21);
            this.lblPageSize.TabIndex = 23;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(184, 1023);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 24;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPagesize
            // 
            this.btnPagesize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPagesize.Location = new System.Drawing.Point(255, 1012);
            this.btnPagesize.Name = "btnPagesize";
            this.btnPagesize.Size = new System.Drawing.Size(140, 40);
            this.btnPagesize.TabIndex = 25;
            this.btnPagesize.TabStop = false;
            this.btnPagesize.Text = "行数変更";
            this.btnPagesize.UseVisualStyleBackColor = true;
            this.btnPagesize.Click += new System.EventHandler(this.btnPagesize_Click);
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(849, 1012);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 26;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // txbNumPage
            // 
            this.txbNumPage.Enabled = false;
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(723, 1016);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.ReadOnly = true;
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 27;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(779, 1023);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(64, 21);
            this.lblNumPage.TabIndex = 28;
            this.lblNumPage.Text = "ページ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(905, 1011);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 29;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(982, 1012);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 30;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1038, 1011);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 31;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // rdbConfirm
            // 
            this.rdbConfirm.AutoSize = true;
            this.rdbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbConfirm.Location = new System.Drawing.Point(306, 195);
            this.rdbConfirm.Name = "rdbConfirm";
            this.rdbConfirm.Size = new System.Drawing.Size(103, 39);
            this.rdbConfirm.TabIndex = 1;
            this.rdbConfirm.Text = "確定";
            this.rdbConfirm.UseVisualStyleBackColor = true;
            this.rdbConfirm.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(445, 195);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 0;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1098, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "確定/未確定";
            // 
            // cmbConfirm
            // 
            this.cmbConfirm.AutoCompleteCustomSource.AddRange(new string[] {
            "確定",
            "未確定"});
            this.cmbConfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbConfirm.FormattingEnabled = true;
            this.cmbConfirm.Items.AddRange(new object[] {
            "未確定",
            "確定"});
            this.cmbConfirm.Location = new System.Drawing.Point(1246, 275);
            this.cmbConfirm.Name = "cmbConfirm";
            this.cmbConfirm.Size = new System.Drawing.Size(220, 32);
            this.cmbConfirm.TabIndex = 34;
            this.cmbConfirm.TabStop = false;
            // 
            // dgvSyukko
            // 
            this.dgvSyukko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyukko.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvSyukko.Location = new System.Drawing.Point(11, 498);
            this.dgvSyukko.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvSyukko.Name = "dgvSyukko";
            this.dgvSyukko.RowHeadersWidth = 51;
            this.dgvSyukko.RowTemplate.Height = 24;
            this.dgvSyukko.Size = new System.Drawing.Size(1106, 487);
            this.dgvSyukko.TabIndex = 35;
            this.dgvSyukko.TabStop = false;
            this.dgvSyukko.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSyukko_CellClick);
            // 
            // dgvSyukkoDetail
            // 
            this.dgvSyukkoDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyukkoDetail.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvSyukkoDetail.Location = new System.Drawing.Point(1132, 498);
            this.dgvSyukkoDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvSyukkoDetail.Name = "dgvSyukkoDetail";
            this.dgvSyukkoDetail.RowHeadersWidth = 51;
            this.dgvSyukkoDetail.RowTemplate.Height = 24;
            this.dgvSyukkoDetail.Size = new System.Drawing.Size(770, 487);
            this.dgvSyukkoDetail.TabIndex = 36;
            this.dgvSyukkoDetail.TabStop = false;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeID.Location = new System.Drawing.Point(107, 350);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(80, 24);
            this.lblEmployeeID.TabIndex = 37;
            this.lblEmployeeID.Text = "社員ID";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientName.Location = new System.Drawing.Point(429, 414);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(82, 24);
            this.lblClientName.TabIndex = 39;
            this.lblClientName.Text = "顧客名";
            // 
            // txbClientName
            // 
            this.txbClientName.Enabled = false;
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientName.Location = new System.Drawing.Point(514, 411);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.ReadOnly = true;
            this.txbClientName.Size = new System.Drawing.Size(220, 31);
            this.txbClientName.TabIndex = 38;
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeID.Location = new System.Drawing.Point(193, 347);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeID.TabIndex = 40;
            this.txbEmployeeID.TextChanged += new System.EventHandler(this.txbEmployeeID_TextChanged);
            this.txbEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // rdbHidden
            // 
            this.rdbHidden.AutoSize = true;
            this.rdbHidden.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbHidden.Location = new System.Drawing.Point(72, 195);
            this.rdbHidden.Name = "rdbHidden";
            this.rdbHidden.Size = new System.Drawing.Size(208, 39);
            this.rdbHidden.TabIndex = 2;
            this.rdbHidden.Text = "非表示更新";
            this.rdbHidden.UseVisualStyleBackColor = true;
            this.rdbHidden.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // F_ButuryuSyukko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.rdbHidden);
            this.Controls.Add(this.txbEmployeeID);
            this.Controls.Add(this.rdbConfirm);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.dgvSyukkoDetail);
            this.Controls.Add(this.dgvSyukko);
            this.Controls.Add(this.cmbConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnPagesize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.dtpSyukkoDate);
            this.Controls.Add(this.lblSyukkoDate);
            this.Controls.Add(this.lblChumonID);
            this.Controls.Add(this.txbOrderID);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.lblSalesOfficeID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.txbClientID);
            this.Controls.Add(this.lblSyukkoID);
            this.Controls.Add(this.txbSyukkoID);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlButuryu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_ButuryuSyukko";
            this.Text = "F_ButuryuSyukko";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_ButuryuSyukko_Load);
            this.pnlButuryu.ResumeLayout(false);
            this.pnlButuryu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyukko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyukkoDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButuryu;
        private System.Windows.Forms.Label lblButuryuSyukko;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.TextBox txbSyukkoID;
        private System.Windows.Forms.Label lblSyukkoID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txbClientID;
        private System.Windows.Forms.Label lblSalesOfficeID;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.Label lblChumonID;
        private System.Windows.Forms.TextBox txbOrderID;
        private System.Windows.Forms.Label lblSyukkoDate;
        private System.Windows.Forms.DateTimePicker dtpSyukkoDate;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Button btnPagesize;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.RadioButton rdbConfirm;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConfirm;
        private System.Windows.Forms.DataGridView dgvSyukko;
        private System.Windows.Forms.DataGridView dgvSyukkoDetail;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txbClientName;
        private System.Windows.Forms.TextBox txbEmployeeID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctHint;
        private System.Windows.Forms.RadioButton rdbHidden;
    }
}
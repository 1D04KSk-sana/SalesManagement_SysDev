using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    partial class F_ButuryuChumon
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

        private void InitializeComponent()
        {
            this.pnlButuryu = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbConfirm = new System.Windows.Forms.RadioButton();
            this.rdbHidden = new System.Windows.Forms.RadioButton();
            this.txbChumonID = new System.Windows.Forms.TextBox();
            this.lblChumonID = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblSalesOfficeID = new System.Windows.Forms.Label();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.txbOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.dgvChumon = new System.Windows.Forms.DataGridView();
            this.dgvChumonDetail = new System.Windows.Forms.DataGridView();
            this.lblHidden = new System.Windows.Forms.Label();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblClientHidden = new System.Windows.Forms.Label();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txbEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.dtpChumonDate = new System.Windows.Forms.DateTimePicker();
            this.lblChumonDate = new System.Windows.Forms.Label();
            this.cmbConfirm = new System.Windows.Forms.ComboBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.pnlButuryu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChumon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChumonDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButuryu
            // 
            this.pnlButuryu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(179)))));
            this.pnlButuryu.Controls.Add(this.pctHint);
            this.pnlButuryu.Controls.Add(this.lblClient);
            this.pnlButuryu.Controls.Add(this.btnClose);
            this.pnlButuryu.Controls.Add(this.btnReturn);
            this.pnlButuryu.Location = new System.Drawing.Point(1, 3);
            this.pnlButuryu.Name = "pnlButuryu";
            this.pnlButuryu.Size = new System.Drawing.Size(1920, 150);
            this.pnlButuryu.TabIndex = 0;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1656, 47);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 28;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClient.ForeColor = System.Drawing.Color.Black;
            this.lblClient.Location = new System.Drawing.Point(823, 37);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(287, 64);
            this.lblClient.TabIndex = 27;
            this.lblClient.Text = "注文管理";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1737, 37);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 26;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(27, 31);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1557, 170);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 27;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbSearch.Location = new System.Drawing.Point(419, 186);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 2;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbConfirm
            // 
            this.rdbConfirm.AutoSize = true;
            this.rdbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbConfirm.Location = new System.Drawing.Point(241, 186);
            this.rdbConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbConfirm.Name = "rdbConfirm";
            this.rdbConfirm.Size = new System.Drawing.Size(103, 39);
            this.rdbConfirm.TabIndex = 1;
            this.rdbConfirm.Text = "確定";
            this.rdbConfirm.UseVisualStyleBackColor = true;
            this.rdbConfirm.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbHidden
            // 
            this.rdbHidden.AutoSize = true;
            this.rdbHidden.Checked = true;
            this.rdbHidden.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbHidden.Location = new System.Drawing.Point(55, 186);
            this.rdbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbHidden.Name = "rdbHidden";
            this.rdbHidden.Size = new System.Drawing.Size(138, 39);
            this.rdbHidden.TabIndex = 0;
            this.rdbHidden.TabStop = true;
            this.rdbHidden.Text = "非表示";
            this.rdbHidden.UseVisualStyleBackColor = true;
            this.rdbHidden.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // txbChumonID
            // 
            this.txbChumonID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbChumonID.Location = new System.Drawing.Point(210, 277);
            this.txbChumonID.Margin = new System.Windows.Forms.Padding(2);
            this.txbChumonID.Name = "txbChumonID";
            this.txbChumonID.Size = new System.Drawing.Size(220, 31);
            this.txbChumonID.TabIndex = 36;
            this.txbChumonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblChumonID
            // 
            this.lblChumonID.AutoSize = true;
            this.lblChumonID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblChumonID.Location = new System.Drawing.Point(114, 280);
            this.lblChumonID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChumonID.Name = "lblChumonID";
            this.lblChumonID.Size = new System.Drawing.Size(80, 24);
            this.lblChumonID.TabIndex = 35;
            this.lblChumonID.Text = "注文ID";
            // 
            // txbClientName
            // 
            this.txbClientName.Enabled = false;
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientName.Location = new System.Drawing.Point(640, 347);
            this.txbClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.ReadOnly = true;
            this.txbClientName.Size = new System.Drawing.Size(220, 31);
            this.txbClientName.TabIndex = 38;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientName.Location = new System.Drawing.Point(531, 350);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(82, 24);
            this.lblClientName.TabIndex = 37;
            this.lblClientName.Text = "顧客名";
            // 
            // lblSalesOfficeID
            // 
            this.lblSalesOfficeID.AutoSize = true;
            this.lblSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSalesOfficeID.Location = new System.Drawing.Point(507, 277);
            this.lblSalesOfficeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesOfficeID.Name = "lblSalesOfficeID";
            this.lblSalesOfficeID.Size = new System.Drawing.Size(106, 24);
            this.lblSalesOfficeID.TabIndex = 39;
            this.lblSalesOfficeID.Text = "営業所名";
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.BackColor = System.Drawing.Color.White;
            this.cmbSalesOfficeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOfficeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(640, 274);
            this.cmbSalesOfficeID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(220, 32);
            this.cmbSalesOfficeID.TabIndex = 41;
            this.cmbSalesOfficeID.TabStop = false;
            // 
            // txbOrderID
            // 
            this.txbOrderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOrderID.Location = new System.Drawing.Point(1067, 277);
            this.txbOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txbOrderID.Name = "txbOrderID";
            this.txbOrderID.Size = new System.Drawing.Size(220, 31);
            this.txbOrderID.TabIndex = 43;
            this.txbOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOrderID.Location = new System.Drawing.Point(969, 280);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(80, 24);
            this.lblOrderID.TabIndex = 42;
            this.lblOrderID.Text = "受注ID";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1738, 170);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 50;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbView
            // 
            this.cmbView.BackColor = System.Drawing.Color.White;
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1184, 185);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 51;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // btnPageSize
            // 
            this.btnPageSize.BackColor = System.Drawing.Color.White;
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(210, 1029);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(111, 40);
            this.btnPageSize.TabIndex = 66;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = false;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(24, 1036);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(114, 21);
            this.lblPageSize.TabIndex = 65;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(142, 1034);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 64;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(1410, 1044);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(61, 21);
            this.lblNumPage.TabIndex = 75;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Enabled = false;
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(1356, 1041);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.ReadOnly = true;
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 74;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(1628, 1029);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 73;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1682, 1029);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 72;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1778, 1029);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 71;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1832, 1029);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 70;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // dgvChumon
            // 
            this.dgvChumon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChumon.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvChumon.Location = new System.Drawing.Point(15, 500);
            this.dgvChumon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChumon.Name = "dgvChumon";
            this.dgvChumon.RowHeadersWidth = 51;
            this.dgvChumon.RowTemplate.Height = 24;
            this.dgvChumon.Size = new System.Drawing.Size(1190, 525);
            this.dgvChumon.TabIndex = 76;
            this.dgvChumon.TabStop = false;
            this.dgvChumon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChumon_CellClick);
            // 
            // dgvChumonDetail
            // 
            this.dgvChumonDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChumonDetail.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvChumonDetail.Location = new System.Drawing.Point(1209, 500);
            this.dgvChumonDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChumonDetail.Name = "dgvChumonDetail";
            this.dgvChumonDetail.RowHeadersWidth = 51;
            this.dgvChumonDetail.RowTemplate.Height = 24;
            this.dgvChumonDetail.Size = new System.Drawing.Size(700, 525);
            this.dgvChumonDetail.TabIndex = 77;
            this.dgvChumonDetail.TabStop = false;
            this.dgvChumonDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChumonDetail_CellClick);
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHidden.Location = new System.Drawing.Point(471, 427);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(142, 24);
            this.lblHidden.TabIndex = 78;
            this.lblHidden.Text = "表示/非表示";
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
            this.cmbHidden.Location = new System.Drawing.Point(640, 424);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 79;
            this.cmbHidden.TabStop = false;
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbHidden.Location = new System.Drawing.Point(1067, 424);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(650, 31);
            this.txbHidden.TabIndex = 81;
            // 
            // lblClientHidden
            // 
            this.lblClientHidden.AutoSize = true;
            this.lblClientHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientHidden.Location = new System.Drawing.Point(919, 427);
            this.lblClientHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientHidden.Name = "lblClientHidden";
            this.lblClientHidden.Size = new System.Drawing.Size(130, 24);
            this.lblClientHidden.TabIndex = 80;
            this.lblClientHidden.Text = "非表示理由";
            // 
            // txbClientID
            // 
            this.txbClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientID.Location = new System.Drawing.Point(210, 350);
            this.txbClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(220, 31);
            this.txbClientID.TabIndex = 83;
            this.txbClientID.TextChanged += new System.EventHandler(this.txbClientID_TextChanged);
            this.txbClientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientID.Location = new System.Drawing.Point(114, 353);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(80, 24);
            this.lblClientID.TabIndex = 82;
            this.lblClientID.Text = "顧客ID";
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeID.Location = new System.Drawing.Point(1067, 347);
            this.txbEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeID.TabIndex = 87;
            this.txbEmployeeID.TextChanged += new System.EventHandler(this.txbEmployeeID_TextChanged);
            this.txbEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeID.Location = new System.Drawing.Point(971, 350);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(80, 24);
            this.lblEmployeeID.TabIndex = 86;
            this.lblEmployeeID.Text = "社員ID";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Enabled = false;
            this.txbEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeName.Location = new System.Drawing.Point(1497, 344);
            this.txbEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.ReadOnly = true;
            this.txbEmployeeName.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeName.TabIndex = 85;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeName.Location = new System.Drawing.Point(1388, 347);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(82, 24);
            this.lblEmployeeName.TabIndex = 84;
            this.lblEmployeeName.Text = "社員名";
            // 
            // dtpChumonDate
            // 
            this.dtpChumonDate.Checked = false;
            this.dtpChumonDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpChumonDate.Location = new System.Drawing.Point(1497, 272);
            this.dtpChumonDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpChumonDate.Name = "dtpChumonDate";
            this.dtpChumonDate.ShowCheckBox = true;
            this.dtpChumonDate.Size = new System.Drawing.Size(220, 31);
            this.dtpChumonDate.TabIndex = 129;
            this.dtpChumonDate.TabStop = false;
            // 
            // lblChumonDate
            // 
            this.lblChumonDate.AutoSize = true;
            this.lblChumonDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblChumonDate.Location = new System.Drawing.Point(1340, 277);
            this.lblChumonDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChumonDate.Name = "lblChumonDate";
            this.lblChumonDate.Size = new System.Drawing.Size(130, 24);
            this.lblChumonDate.TabIndex = 128;
            this.lblChumonDate.Text = "注文年月日";
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
            this.cmbConfirm.Location = new System.Drawing.Point(210, 424);
            this.cmbConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.cmbConfirm.Name = "cmbConfirm";
            this.cmbConfirm.Size = new System.Drawing.Size(220, 32);
            this.cmbConfirm.TabIndex = 131;
            this.cmbConfirm.TabStop = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConfirm.Location = new System.Drawing.Point(41, 427);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(142, 24);
            this.lblConfirm.TabIndex = 130;
            this.lblConfirm.Text = "未確定/確定";
            // 
            // F_ButuryuChumon
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.cmbConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.dtpChumonDate);
            this.Controls.Add(this.lblChumonDate);
            this.Controls.Add(this.txbEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.txbClientID);
            this.Controls.Add(this.rdbConfirm);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.rdbHidden);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblClientHidden);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.dgvChumonDetail);
            this.Controls.Add(this.dgvChumon);
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
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txbOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.lblSalesOfficeID);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txbChumonID);
            this.Controls.Add(this.lblChumonID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlButuryu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_ButuryuChumon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_ButuryuChumon_Load);
            this.pnlButuryu.ResumeLayout(false);
            this.pnlButuryu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChumon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChumonDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbConfirm;
        private System.Windows.Forms.RadioButton rdbHidden;
        private System.Windows.Forms.TextBox txbChumonID;
        private System.Windows.Forms.Label lblChumonID;
        private System.Windows.Forms.TextBox txbClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblSalesOfficeID;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.TextBox txbOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.DataGridView dgvChumon;
        private System.Windows.Forms.DataGridView dgvChumonDetail;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel pnlButuryu;
        private Label lblHidden;
        private ComboBox cmbHidden;
        private TextBox txbHidden;
        private Label lblClientHidden;
        private TextBox txbClientID;
        private Label lblClientID;
        private PictureBox pctHint;
        private TextBox txbEmployeeID;
        private Label lblEmployeeID;
        private TextBox txbEmployeeName;
        private Label lblEmployeeName;
        private DateTimePicker dtpChumonDate;
        private Label lblChumonDate;
        private ComboBox cmbConfirm;
        private Label lblConfirm;
    }
}
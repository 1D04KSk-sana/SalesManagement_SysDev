namespace SalesManagement_SysDev
{
    partial class F_HonshaSale
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
            this.lblClient = new System.Windows.Forms.Label();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.pnlHonsha = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.txbClientPostal = new System.Windows.Forms.TextBox();
            this.lblChumonID = new System.Windows.Forms.Label();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.lblSalesOfficeID = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txbSaleID = new System.Windows.Forms.TextBox();
            this.lblSaleID = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.dgvSaleDetail = new System.Windows.Forms.DataGridView();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbHiddenUpdate = new System.Windows.Forms.RadioButton();
            this.dtpSaleDate = new SalesManagement_SysDev.MonthPicker();
            this.pnlHonsha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(784, 41);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(624, 97);
            this.lblClient.TabIndex = 23;
            this.lblClient.Text = "売上管理画面";
            // 
            // btnPageSize
            // 
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(295, 1029);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 64;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = true;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(32, 1039);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(174, 33);
            this.lblPageSize.TabIndex = 63;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(194, 1033);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 39);
            this.txbPageSize.TabIndex = 62;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPageSize_KeyPress);
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1065, 198);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 60);
            this.cmbView.TabIndex = 61;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // pnlHonsha
            // 
            this.pnlHonsha.BackColor = System.Drawing.Color.Lime;
            this.pnlHonsha.Controls.Add(this.lblClient);
            this.pnlHonsha.Controls.Add(this.btnReturn);
            this.pnlHonsha.Location = new System.Drawing.Point(0, 0);
            this.pnlHonsha.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHonsha.Name = "pnlHonsha";
            this.pnlHonsha.Size = new System.Drawing.Size(1920, 150);
            this.pnlHonsha.TabIndex = 60;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(73, 41);
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
            this.btnClear.Location = new System.Drawing.Point(1496, 174);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 59;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Location = new System.Drawing.Point(11, 537);
            this.dgvSale.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowTemplate.Height = 24;
            this.dgvSale.Size = new System.Drawing.Size(1190, 480);
            this.dgvSale.TabIndex = 56;
            this.dgvSale.TabStop = false;
            this.dgvSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellClick);
            this.dgvSale.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSaleDate.Location = new System.Drawing.Point(731, 414);
            this.lblSaleDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(159, 36);
            this.lblSaleDate.TabIndex = 50;
            this.lblSaleDate.Text = "売上日時";
            // 
            // txbClientPostal
            // 
            this.txbClientPostal.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientPostal.Location = new System.Drawing.Point(321, 407);
            this.txbClientPostal.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientPostal.Name = "txbClientPostal";
            this.txbClientPostal.ShortcutsEnabled = false;
            this.txbClientPostal.Size = new System.Drawing.Size(220, 43);
            this.txbClientPostal.TabIndex = 49;
            // 
            // lblChumonID
            // 
            this.lblChumonID.AutoSize = true;
            this.lblChumonID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblChumonID.Location = new System.Drawing.Point(93, 414);
            this.lblChumonID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChumonID.Name = "lblChumonID";
            this.lblChumonID.Size = new System.Drawing.Size(119, 36);
            this.lblChumonID.TabIndex = 48;
            this.lblChumonID.Text = "注文ID";
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(1619, 292);
            this.cmbSalesOfficeID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(220, 44);
            this.cmbSalesOfficeID.TabIndex = 46;
            this.cmbSalesOfficeID.TabStop = false;
            // 
            // lblSalesOfficeID
            // 
            this.lblSalesOfficeID.AutoSize = true;
            this.lblSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSalesOfficeID.Location = new System.Drawing.Point(1364, 299);
            this.lblSalesOfficeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesOfficeID.Name = "lblSalesOfficeID";
            this.lblSalesOfficeID.Size = new System.Drawing.Size(159, 36);
            this.lblSalesOfficeID.TabIndex = 44;
            this.lblSalesOfficeID.Text = "営業所名";
            // 
            // txbClientName
            // 
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientName.Location = new System.Drawing.Point(981, 292);
            this.txbClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.ShortcutsEnabled = false;
            this.txbClientName.Size = new System.Drawing.Size(220, 43);
            this.txbClientName.TabIndex = 43;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClientName.Location = new System.Drawing.Point(755, 298);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(123, 36);
            this.lblClientName.TabIndex = 42;
            this.lblClientName.Text = "顧客名";
            // 
            // txbSaleID
            // 
            this.txbSaleID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSaleID.Location = new System.Drawing.Point(321, 291);
            this.txbSaleID.Margin = new System.Windows.Forms.Padding(2);
            this.txbSaleID.Name = "txbSaleID";
            this.txbSaleID.ShortcutsEnabled = false;
            this.txbSaleID.Size = new System.Drawing.Size(220, 43);
            this.txbSaleID.TabIndex = 41;
            // 
            // lblSaleID
            // 
            this.lblSaleID.AutoSize = true;
            this.lblSaleID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSaleID.Location = new System.Drawing.Point(93, 298);
            this.lblSaleID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaleID.Name = "lblSaleID";
            this.lblSaleID.Size = new System.Drawing.Size(119, 36);
            this.lblSaleID.TabIndex = 40;
            this.lblSaleID.Text = "売上ID";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1707, 174);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 57;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dgvSaleDetail
            // 
            this.dgvSaleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleDetail.Location = new System.Drawing.Point(1209, 537);
            this.dgvSaleDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSaleDetail.Name = "dgvSaleDetail";
            this.dgvSaleDetail.RowHeadersWidth = 51;
            this.dgvSaleDetail.RowTemplate.Height = 24;
            this.dgvSaleDetail.Size = new System.Drawing.Size(700, 480);
            this.dgvSaleDetail.TabIndex = 72;
            this.dgvSaleDetail.TabStop = false;
            this.dgvSaleDetail.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(888, 1036);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(94, 33);
            this.lblNumPage.TabIndex = 78;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(820, 1033);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 39);
            this.txbNumPage.TabIndex = 77;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumPage_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(975, 1026);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 76;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1029, 1026);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 75;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1083, 1026);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 74;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1137, 1026);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 73;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(1619, 407);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 44);
            this.cmbHidden.TabIndex = 80;
            this.cmbHidden.TabStop = false;
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(36, 174);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(154, 57);
            this.rdbSearch.TabIndex = 2;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // rdbHiddenUpdate
            // 
            this.rdbHiddenUpdate.AutoSize = true;
            this.rdbHiddenUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbHiddenUpdate.Location = new System.Drawing.Point(169, 174);
            this.rdbHiddenUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbHiddenUpdate.Name = "rdbHiddenUpdate";
            this.rdbHiddenUpdate.Size = new System.Drawing.Size(260, 57);
            this.rdbHiddenUpdate.TabIndex = 79;
            this.rdbHiddenUpdate.Text = "表示更新";
            this.rdbHiddenUpdate.UseVisualStyleBackColor = true;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.CustomFormat = "MMMM yyyy";
            this.dtpSaleDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpSaleDate.Location = new System.Drawing.Point(981, 407);
            this.dtpSaleDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(220, 43);
            this.dtpSaleDate.TabIndex = 81;
            this.dtpSaleDate.TabStop = false;
            // 
            // F_HonshaSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.rdbHiddenUpdate);
            this.Controls.Add(this.dtpSaleDate);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.dgvSaleDetail);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.pnlHonsha);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.txbClientPostal);
            this.Controls.Add(this.lblChumonID);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.lblSalesOfficeID);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txbSaleID);
            this.Controls.Add(this.lblSaleID);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "F_HonshaSale";
            this.Text = "F_HonshaSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_HonshaSale_Load);
            this.pnlHonsha.ResumeLayout(false);
            this.pnlHonsha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Panel pnlHonsha;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.TextBox txbClientPostal;
        private System.Windows.Forms.Label lblChumonID;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.Label lblSalesOfficeID;
        private System.Windows.Forms.TextBox txbClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txbSaleID;
        private System.Windows.Forms.Label lblSaleID;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView dgvSaleDetail;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.ComboBox cmbHidden;
        private MonthPicker dtpSaleDate;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbHiddenUpdate;
        private System.Windows.Forms.Label lblClient;
    }
}
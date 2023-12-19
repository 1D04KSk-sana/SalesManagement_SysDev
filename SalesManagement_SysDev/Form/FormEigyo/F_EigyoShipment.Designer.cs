namespace SalesManagement_SysDev
{
    partial class F_EigyoShipment
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
            this.pnlEigyo = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblWarehousing = new System.Windows.Forms.Label();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.txbShipmentquantity = new System.Windows.Forms.TextBox();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.txbShipmentDetailID = new System.Windows.Forms.TextBox();
            this.txbShipmentID = new System.Windows.Forms.TextBox();
            this.txbOrderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.txbEmployeeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpShipmentDate = new System.Windows.Forms.DateTimePicker();
            this.dgvShipmentDetail = new System.Windows.Forms.DataGridView();
            this.dgvShipment = new System.Windows.Forms.DataGridView();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbShipmentHidden = new System.Windows.Forms.TextBox();
            this.cmbShipmentHidden = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.pnlEigyo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipment)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEigyo
            // 
            this.pnlEigyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(128)))));
            this.pnlEigyo.Controls.Add(this.pctHint);
            this.pnlEigyo.Controls.Add(this.btnClose);
            this.pnlEigyo.Controls.Add(this.btnReturn);
            this.pnlEigyo.Controls.Add(this.lblWarehousing);
            this.pnlEigyo.Location = new System.Drawing.Point(1, 1);
            this.pnlEigyo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEigyo.Name = "pnlEigyo";
            this.pnlEigyo.Size = new System.Drawing.Size(1920, 150);
            this.pnlEigyo.TabIndex = 134;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1621, 44);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 177;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1706, 38);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 63;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(34, 38);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblWarehousing
            // 
            this.lblWarehousing.AutoSize = true;
            this.lblWarehousing.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWarehousing.ForeColor = System.Drawing.Color.White;
            this.lblWarehousing.Location = new System.Drawing.Point(729, 44);
            this.lblWarehousing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarehousing.Name = "lblWarehousing";
            this.lblWarehousing.Size = new System.Drawing.Size(417, 64);
            this.lblWarehousing.TabIndex = 24;
            this.lblWarehousing.Text = "出荷管理画面";
            // 
            // cmbView
            // 
            this.cmbView.BackColor = System.Drawing.Color.White;
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1050, 187);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 137;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1468, 172);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 136;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1661, 172);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 135;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(255, 188);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 139;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Checked = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(138, 188);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(103, 39);
            this.rdbUpdate.TabIndex = 138;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(1468, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 147;
            this.label8.Text = "商品ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(1475, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 146;
            this.label7.Text = "商品名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1490, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 145;
            this.label1.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1420, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 144;
            this.label3.Text = "出荷詳細ID";
            // 
            // txbProductID
            // 
            this.txbProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductID.ForeColor = System.Drawing.Color.Black;
            this.txbProductID.Location = new System.Drawing.Point(1561, 347);
            this.txbProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(220, 31);
            this.txbProductID.TabIndex = 143;
            // 
            // txbShipmentquantity
            // 
            this.txbShipmentquantity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbShipmentquantity.ForeColor = System.Drawing.Color.Black;
            this.txbShipmentquantity.Location = new System.Drawing.Point(1561, 457);
            this.txbShipmentquantity.Margin = new System.Windows.Forms.Padding(2);
            this.txbShipmentquantity.Name = "txbShipmentquantity";
            this.txbShipmentquantity.Size = new System.Drawing.Size(220, 31);
            this.txbShipmentquantity.TabIndex = 142;
            // 
            // txbProductName
            // 
            this.txbProductName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductName.ForeColor = System.Drawing.Color.Black;
            this.txbProductName.Location = new System.Drawing.Point(1561, 401);
            this.txbProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(220, 31);
            this.txbProductName.TabIndex = 141;
            // 
            // txbShipmentDetailID
            // 
            this.txbShipmentDetailID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbShipmentDetailID.ForeColor = System.Drawing.Color.Black;
            this.txbShipmentDetailID.Location = new System.Drawing.Point(1561, 294);
            this.txbShipmentDetailID.Margin = new System.Windows.Forms.Padding(2);
            this.txbShipmentDetailID.Name = "txbShipmentDetailID";
            this.txbShipmentDetailID.Size = new System.Drawing.Size(220, 31);
            this.txbShipmentDetailID.TabIndex = 140;
            // 
            // txbShipmentID
            // 
            this.txbShipmentID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbShipmentID.ForeColor = System.Drawing.Color.Black;
            this.txbShipmentID.Location = new System.Drawing.Point(197, 277);
            this.txbShipmentID.Margin = new System.Windows.Forms.Padding(2);
            this.txbShipmentID.Name = "txbShipmentID";
            this.txbShipmentID.Size = new System.Drawing.Size(220, 31);
            this.txbShipmentID.TabIndex = 148;
            // 
            // txbOrderID
            // 
            this.txbOrderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOrderID.ForeColor = System.Drawing.Color.Black;
            this.txbOrderID.Location = new System.Drawing.Point(1119, 277);
            this.txbOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txbOrderID.Name = "txbOrderID";
            this.txbOrderID.Size = new System.Drawing.Size(220, 31);
            this.txbOrderID.TabIndex = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(489, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 153;
            this.label4.Text = "営業所名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(513, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 154;
            this.label5.Text = "社員名";
            // 
            // txbClientID
            // 
            this.txbClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientID.ForeColor = System.Drawing.Color.Black;
            this.txbClientID.Location = new System.Drawing.Point(197, 397);
            this.txbClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(220, 31);
            this.txbClientID.TabIndex = 155;
            this.txbClientID.TextChanged += new System.EventHandler(this.txbClientID_TextChanged);
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.txbEmployeeID.Location = new System.Drawing.Point(197, 339);
            this.txbEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeID.TabIndex = 156;
            this.txbEmployeeID.TextChanged += new System.EventHandler(this.txbEmployeeID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(904, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 158;
            this.label6.Text = "出荷完了年月日";
            // 
            // dtpShipmentDate
            // 
            this.dtpShipmentDate.Checked = false;
            this.dtpShipmentDate.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpShipmentDate.Location = new System.Drawing.Point(1119, 341);
            this.dtpShipmentDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpShipmentDate.Name = "dtpShipmentDate";
            this.dtpShipmentDate.ShowCheckBox = true;
            this.dtpShipmentDate.Size = new System.Drawing.Size(220, 29);
            this.dtpShipmentDate.TabIndex = 157;
            // 
            // dgvShipmentDetail
            // 
            this.dgvShipmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipmentDetail.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvShipmentDetail.Location = new System.Drawing.Point(1135, 514);
            this.dgvShipmentDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShipmentDetail.Name = "dgvShipmentDetail";
            this.dgvShipmentDetail.RowHeadersWidth = 51;
            this.dgvShipmentDetail.RowTemplate.Height = 24;
            this.dgvShipmentDetail.Size = new System.Drawing.Size(748, 499);
            this.dgvShipmentDetail.TabIndex = 169;
            this.dgvShipmentDetail.TabStop = false;
            this.dgvShipmentDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipmentDetail_CellClick);
            // 
            // dgvShipment
            // 
            this.dgvShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipment.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvShipment.Location = new System.Drawing.Point(11, 514);
            this.dgvShipment.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShipment.Name = "dgvShipment";
            this.dgvShipment.RowHeadersWidth = 51;
            this.dgvShipment.RowTemplate.Height = 24;
            this.dgvShipment.Size = new System.Drawing.Size(1102, 499);
            this.dgvShipment.TabIndex = 168;
            this.dgvShipment.TabStop = false;
            this.dgvShipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipment_CellClick);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(11, 1043);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(114, 21);
            this.lblPageSize.TabIndex = 167;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(153, 1036);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 166;
            this.txbPageSize.TabStop = false;
            // 
            // btnPageSize
            // 
            this.btnPageSize.BackColor = System.Drawing.Color.White;
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(253, 1032);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 165;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = false;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(779, 1046);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(67, 22);
            this.lblNumPage.TabIndex = 164;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(725, 1039);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 163;
            this.txbNumPage.TabStop = false;
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(883, 1029);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 162;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(937, 1029);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 161;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1045, 1029);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 160;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(991, 1029);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 159;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(988, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 170;
            this.label2.Text = "受注ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(513, 400);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 171;
            this.label9.Text = "顧客名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(90, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 172;
            this.label10.Text = "出荷ID";
            // 
            // txbShipmentHidden
            // 
            this.txbShipmentHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbShipmentHidden.Location = new System.Drawing.Point(626, 452);
            this.txbShipmentHidden.Name = "txbShipmentHidden";
            this.txbShipmentHidden.Size = new System.Drawing.Size(721, 31);
            this.txbShipmentHidden.TabIndex = 176;
            // 
            // cmbShipmentHidden
            // 
            this.cmbShipmentHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipmentHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbShipmentHidden.ForeColor = System.Drawing.Color.Black;
            this.cmbShipmentHidden.FormattingEnabled = true;
            this.cmbShipmentHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbShipmentHidden.Location = new System.Drawing.Point(197, 452);
            this.cmbShipmentHidden.Margin = new System.Windows.Forms.Padding(4);
            this.cmbShipmentHidden.Name = "cmbShipmentHidden";
            this.cmbShipmentHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbShipmentHidden.TabIndex = 175;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(28, 455);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 24);
            this.label11.TabIndex = 174;
            this.label11.Text = "表示/非表示";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(465, 455);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 173;
            this.label12.Text = "非表示理由";
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSalesOfficeID.ForeColor = System.Drawing.Color.Black;
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(626, 276);
            this.cmbSalesOfficeID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(220, 32);
            this.cmbSalesOfficeID.TabIndex = 177;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(90, 342);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 24);
            this.label13.TabIndex = 178;
            this.label13.Text = "社員ID";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Enabled = false;
            this.txbEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.txbEmployeeName.Location = new System.Drawing.Point(626, 339);
            this.txbEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeName.TabIndex = 179;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(90, 401);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 24);
            this.label14.TabIndex = 181;
            this.label14.Text = "顧客ID";
            // 
            // txbClientName
            // 
            this.txbClientName.Enabled = false;
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientName.ForeColor = System.Drawing.Color.Black;
            this.txbClientName.Location = new System.Drawing.Point(626, 397);
            this.txbClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.Size = new System.Drawing.Size(220, 31);
            this.txbClientName.TabIndex = 180;
            // 
            // F_EigyoShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.txbShipmentHidden);
            this.Controls.Add(this.cmbShipmentHidden);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvShipmentDetail);
            this.Controls.Add(this.dgvShipment);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpShipmentDate);
            this.Controls.Add(this.txbEmployeeID);
            this.Controls.Add(this.txbClientID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbOrderID);
            this.Controls.Add(this.txbShipmentID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbProductID);
            this.Controls.Add(this.txbShipmentquantity);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.txbShipmentDetailID);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.rdbUpdate);
            this.Controls.Add(this.pnlEigyo);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_EigyoShipment";
            this.Text = "F_EigyoShipment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_EigyoShipment_Load);
            this.pnlEigyo.ResumeLayout(false);
            this.pnlEigyo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEigyo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblWarehousing;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.TextBox txbShipmentquantity;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.TextBox txbShipmentDetailID;
        private System.Windows.Forms.TextBox txbShipmentID;
        private System.Windows.Forms.TextBox txbOrderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbClientID;
        private System.Windows.Forms.TextBox txbEmployeeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpShipmentDate;
        private System.Windows.Forms.DataGridView dgvShipmentDetail;
        private System.Windows.Forms.DataGridView dgvShipment;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbShipmentHidden;
        private System.Windows.Forms.ComboBox cmbShipmentHidden;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.PictureBox pctHint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbClientName;
    }
}
namespace SalesManagement_SysDev
{
    partial class F_ButuryuWarehousing
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
            this.lblWarehousing = new System.Windows.Forms.Label();
            this.pnlButuryu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txbProdactName = new System.Windows.Forms.TextBox();
            this.txbWarehousingDetailID = new System.Windows.Forms.TextBox();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.txbWarehousingQuantity = new System.Windows.Forms.TextBox();
            this.txbOrderID = new System.Windows.Forms.TextBox();
            this.txbWarehousingID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpWarehousingDate = new System.Windows.Forms.DateTimePicker();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.txbWarehousingHidden = new System.Windows.Forms.TextBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvWarehousing = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvWarehousingDetail = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbDetailRegister = new System.Windows.Forms.RadioButton();
            this.pnlButuryu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehousing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehousingDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarehousing
            // 
            this.lblWarehousing.AutoSize = true;
            this.lblWarehousing.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWarehousing.ForeColor = System.Drawing.Color.White;
            this.lblWarehousing.Location = new System.Drawing.Point(754, 44);
            this.lblWarehousing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarehousing.Name = "lblWarehousing";
            this.lblWarehousing.Size = new System.Drawing.Size(418, 64);
            this.lblWarehousing.TabIndex = 24;
            this.lblWarehousing.Text = "入庫管理画面";
            // 
            // pnlButuryu
            // 
            this.pnlButuryu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(179)))));
            this.pnlButuryu.Controls.Add(this.btnClose);
            this.pnlButuryu.Controls.Add(this.btnReturn);
            this.pnlButuryu.Controls.Add(this.lblWarehousing);
            this.pnlButuryu.Location = new System.Drawing.Point(0, 0);
            this.pnlButuryu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButuryu.Name = "pnlButuryu";
            this.pnlButuryu.Size = new System.Drawing.Size(1920, 150);
            this.pnlButuryu.TabIndex = 55;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1705, 51);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 63;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
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
            // 
            // txbProdactName
            // 
            this.txbProdactName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProdactName.ForeColor = System.Drawing.Color.Black;
            this.txbProdactName.Location = new System.Drawing.Point(1429, 350);
            this.txbProdactName.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactName.Name = "txbProdactName";
            this.txbProdactName.Size = new System.Drawing.Size(220, 31);
            this.txbProdactName.TabIndex = 56;
            this.txbProdactName.TextChanged += new System.EventHandler(this.txbstockID_TextChanged);
            // 
            // txbWarehousingDetailID
            // 
            this.txbWarehousingDetailID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbWarehousingDetailID.ForeColor = System.Drawing.Color.Black;
            this.txbWarehousingDetailID.Location = new System.Drawing.Point(1429, 262);
            this.txbWarehousingDetailID.Margin = new System.Windows.Forms.Padding(2);
            this.txbWarehousingDetailID.Name = "txbWarehousingDetailID";
            this.txbWarehousingDetailID.Size = new System.Drawing.Size(220, 31);
            this.txbWarehousingDetailID.TabIndex = 57;
            // 
            // txbProductID
            // 
            this.txbProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductID.ForeColor = System.Drawing.Color.Black;
            this.txbProductID.Location = new System.Drawing.Point(1429, 306);
            this.txbProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(220, 31);
            this.txbProductID.TabIndex = 58;
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.txbEmployeeName.Location = new System.Drawing.Point(869, 286);
            this.txbEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeName.TabIndex = 59;
            // 
            // txbWarehousingQuantity
            // 
            this.txbWarehousingQuantity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbWarehousingQuantity.ForeColor = System.Drawing.Color.Black;
            this.txbWarehousingQuantity.Location = new System.Drawing.Point(1429, 389);
            this.txbWarehousingQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txbWarehousingQuantity.Name = "txbWarehousingQuantity";
            this.txbWarehousingQuantity.Size = new System.Drawing.Size(220, 31);
            this.txbWarehousingQuantity.TabIndex = 60;
            // 
            // txbOrderID
            // 
            this.txbOrderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOrderID.ForeColor = System.Drawing.Color.Black;
            this.txbOrderID.Location = new System.Drawing.Point(271, 323);
            this.txbOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txbOrderID.Name = "txbOrderID";
            this.txbOrderID.Size = new System.Drawing.Size(220, 31);
            this.txbOrderID.TabIndex = 61;
            // 
            // txbWarehousingID
            // 
            this.txbWarehousingID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbWarehousingID.ForeColor = System.Drawing.Color.Black;
            this.txbWarehousingID.Location = new System.Drawing.Point(271, 262);
            this.txbWarehousingID.Margin = new System.Windows.Forms.Padding(2);
            this.txbWarehousingID.Name = "txbWarehousingID";
            this.txbWarehousingID.Size = new System.Drawing.Size(220, 31);
            this.txbWarehousingID.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1268, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "入庫詳細ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1336, 392);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 94;
            this.label1.Text = "数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(668, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "受注確定年月日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(668, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 96;
            this.label4.Text = "入庫確認社員名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(169, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 97;
            this.label5.Text = "発注ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(169, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 98;
            this.label6.Text = "入庫ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(1314, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 99;
            this.label7.Text = "商品名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(1316, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 100;
            this.label8.Text = "商品ID";
            // 
            // dtpWarehousingDate
            // 
            this.dtpWarehousingDate.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpWarehousingDate.Location = new System.Drawing.Point(869, 369);
            this.dtpWarehousingDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpWarehousingDate.Name = "dtpWarehousingDate";
            this.dtpWarehousingDate.Size = new System.Drawing.Size(220, 29);
            this.dtpWarehousingDate.TabIndex = 101;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1678, 171);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 102;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1485, 171);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 103;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(11, 1007);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(114, 21);
            this.lblPageSize.TabIndex = 112;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(153, 1000);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 111;
            this.txbPageSize.TabStop = false;
            // 
            // btnPageSize
            // 
            this.btnPageSize.BackColor = System.Drawing.Color.White;
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(253, 996);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 110;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = false;
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(779, 1010);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(67, 22);
            this.lblNumPage.TabIndex = 109;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(716, 1005);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 108;
            this.txbNumPage.TabStop = false;
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(883, 993);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 107;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(937, 993);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 106;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1045, 993);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 105;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(991, 993);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 104;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbHidden
            // 
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.ForeColor = System.Drawing.Color.Black;
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Location = new System.Drawing.Point(271, 381);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 113;
            // 
            // txbWarehousingHidden
            // 
            this.txbWarehousingHidden.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbWarehousingHidden.Location = new System.Drawing.Point(271, 437);
            this.txbWarehousingHidden.Name = "txbWarehousingHidden";
            this.txbWarehousingHidden.Size = new System.Drawing.Size(1565, 42);
            this.txbWarehousingHidden.TabIndex = 114;
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
            this.cmbView.Location = new System.Drawing.Point(1067, 186);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 115;
            this.cmbView.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(107, 384);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 116;
            this.label9.Text = "表示/非表示";
            // 
            // dgvWarehousing
            // 
            this.dgvWarehousing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehousing.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvWarehousing.Location = new System.Drawing.Point(11, 509);
            this.dgvWarehousing.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWarehousing.Name = "dgvWarehousing";
            this.dgvWarehousing.RowHeadersWidth = 51;
            this.dgvWarehousing.RowTemplate.Height = 24;
            this.dgvWarehousing.Size = new System.Drawing.Size(1102, 480);
            this.dgvWarehousing.TabIndex = 117;
            this.dgvWarehousing.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(119, 437);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 24);
            this.label10.TabIndex = 118;
            this.label10.Text = "非表示理由";
            // 
            // dgvWarehousingDetail
            // 
            this.dgvWarehousingDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehousingDetail.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvWarehousingDetail.Location = new System.Drawing.Point(1135, 509);
            this.dgvWarehousingDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWarehousingDetail.Name = "dgvWarehousingDetail";
            this.dgvWarehousingDetail.RowHeadersWidth = 51;
            this.dgvWarehousingDetail.RowTemplate.Height = 24;
            this.dgvWarehousingDetail.Size = new System.Drawing.Size(748, 480);
            this.dgvWarehousingDetail.TabIndex = 119;
            this.dgvWarehousingDetail.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 16);
            this.radioButton1.TabIndex = 120;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbDetailRegister
            // 
            this.rdbDetailRegister.AutoSize = true;
            this.rdbDetailRegister.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbDetailRegister.Location = new System.Drawing.Point(153, 186);
            this.rdbDetailRegister.Name = "rdbDetailRegister";
            this.rdbDetailRegister.Size = new System.Drawing.Size(173, 39);
            this.rdbDetailRegister.TabIndex = 121;
            this.rdbDetailRegister.Text = "詳細登録";
            this.rdbDetailRegister.UseVisualStyleBackColor = true;
            // 
            // F_ButuryuWarehousing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.rdbDetailRegister);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dgvWarehousingDetail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvWarehousing);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.txbWarehousingHidden);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dtpWarehousingDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbWarehousingID);
            this.Controls.Add(this.txbOrderID);
            this.Controls.Add(this.txbWarehousingQuantity);
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.txbProductID);
            this.Controls.Add(this.txbWarehousingDetailID);
            this.Controls.Add(this.txbProdactName);
            this.Controls.Add(this.pnlButuryu);
            this.Name = "F_ButuryuWarehousing";
            this.Text = "F_ButuryuWarehousing";
            this.pnlButuryu.ResumeLayout(false);
            this.pnlButuryu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehousing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehousingDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWarehousing;
        private System.Windows.Forms.Panel pnlButuryu;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txbProdactName;
        private System.Windows.Forms.TextBox txbWarehousingDetailID;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.TextBox txbWarehousingQuantity;
        private System.Windows.Forms.TextBox txbOrderID;
        private System.Windows.Forms.TextBox txbWarehousingID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpWarehousingDate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.TextBox txbWarehousingHidden;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvWarehousing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvWarehousingDetail;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton rdbDetailRegister;
    }
}
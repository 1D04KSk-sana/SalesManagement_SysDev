namespace SalesManagement_SysDev
{
    partial class F_EigyoArrival
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlEigyo = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.lblWarehousing = new System.Windows.Forms.Label();
            this.txbArrivalID = new System.Windows.Forms.TextBox();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.txbOrderID = new System.Windows.Forms.TextBox();
            this.txbEmployeeID = new System.Windows.Forms.TextBox();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dgvArrivalDetail = new System.Windows.Forms.DataGridView();
            this.dgvArrival = new System.Windows.Forms.DataGridView();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.cmbConfirm = new System.Windows.Forms.ComboBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbConfirm = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.cmbSalesOfficeID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.cmbHidden = new System.Windows.Forms.ComboBox();
            this.pnlEigyo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivalDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrival)).BeginInit();
            this.SuspendLayout();
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
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlEigyo
            // 
            this.pnlEigyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(128)))));
            this.pnlEigyo.Controls.Add(this.pctHint);
            this.pnlEigyo.Controls.Add(this.btnClose);
            this.pnlEigyo.Controls.Add(this.btnReturn);
            this.pnlEigyo.Controls.Add(this.lblWarehousing);
            this.pnlEigyo.Location = new System.Drawing.Point(0, 0);
            this.pnlEigyo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEigyo.Name = "pnlEigyo";
            this.pnlEigyo.Size = new System.Drawing.Size(1920, 150);
            this.pnlEigyo.TabIndex = 56;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1621, 44);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 154;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // lblWarehousing
            // 
            this.lblWarehousing.AutoSize = true;
            this.lblWarehousing.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWarehousing.ForeColor = System.Drawing.Color.White;
            this.lblWarehousing.Location = new System.Drawing.Point(729, 44);
            this.lblWarehousing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarehousing.Name = "lblWarehousing";
            this.lblWarehousing.Size = new System.Drawing.Size(418, 64);
            this.lblWarehousing.TabIndex = 24;
            this.lblWarehousing.Text = "入荷管理画面";
            // 
            // txbArrivalID
            // 
            this.txbArrivalID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbArrivalID.ForeColor = System.Drawing.Color.Black;
            this.txbArrivalID.Location = new System.Drawing.Point(263, 275);
            this.txbArrivalID.Margin = new System.Windows.Forms.Padding(2);
            this.txbArrivalID.Name = "txbArrivalID";
            this.txbArrivalID.Size = new System.Drawing.Size(220, 31);
            this.txbArrivalID.TabIndex = 1;
            // 
            // txbClientID
            // 
            this.txbClientID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientID.ForeColor = System.Drawing.Color.Black;
            this.txbClientID.Location = new System.Drawing.Point(263, 386);
            this.txbClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(220, 31);
            this.txbClientID.TabIndex = 4;
            this.txbClientID.TextChanged += new System.EventHandler(this.txbClientID_TextChanged);
            this.txbClientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // txbOrderID
            // 
            this.txbOrderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOrderID.ForeColor = System.Drawing.Color.Black;
            this.txbOrderID.Location = new System.Drawing.Point(1532, 274);
            this.txbOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txbOrderID.Name = "txbOrderID";
            this.txbOrderID.Size = new System.Drawing.Size(220, 31);
            this.txbOrderID.TabIndex = 5;
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.txbEmployeeID.Location = new System.Drawing.Point(263, 333);
            this.txbEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeID.TabIndex = 3;
            this.txbEmployeeID.TextChanged += new System.EventHandler(this.txbEmployeeID_TextChanged);
            this.txbEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Checked = false;
            this.dtpArrivalDate.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpArrivalDate.Location = new System.Drawing.Point(1532, 332);
            this.dtpArrivalDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.ShowCheckBox = true;
            this.dtpArrivalDate.Size = new System.Drawing.Size(220, 29);
            this.dtpArrivalDate.TabIndex = 6;
            this.dtpArrivalDate.TabStop = false;
            // 
            // dgvArrivalDetail
            // 
            this.dgvArrivalDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArrivalDetail.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvArrivalDetail.Location = new System.Drawing.Point(1195, 512);
            this.dgvArrivalDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArrivalDetail.Name = "dgvArrivalDetail";
            this.dgvArrivalDetail.RowHeadersWidth = 51;
            this.dgvArrivalDetail.RowTemplate.Height = 24;
            this.dgvArrivalDetail.Size = new System.Drawing.Size(700, 480);
            this.dgvArrivalDetail.TabIndex = 130;
            this.dgvArrivalDetail.TabStop = false;
            // 
            // dgvArrival
            // 
            this.dgvArrival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArrival.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvArrival.Location = new System.Drawing.Point(11, 512);
            this.dgvArrival.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArrival.Name = "dgvArrival";
            this.dgvArrival.RowHeadersWidth = 51;
            this.dgvArrival.RowTemplate.Height = 24;
            this.dgvArrival.Size = new System.Drawing.Size(1170, 480);
            this.dgvArrival.TabIndex = 129;
            this.dgvArrival.TabStop = false;
            this.dgvArrival.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArrival_CellClick);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(21, 1010);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(114, 21);
            this.lblPageSize.TabIndex = 128;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(163, 1003);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 127;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageSize
            // 
            this.btnPageSize.BackColor = System.Drawing.Color.White;
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(263, 999);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 126;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = false;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(792, 1008);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(67, 22);
            this.lblNumPage.TabIndex = 125;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(726, 1003);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 124;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(893, 996);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 123;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(947, 996);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 122;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1055, 996);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 121;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1001, 996);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 120;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.cmbView.Location = new System.Drawing.Point(1001, 184);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 133;
            this.cmbView.TabStop = false;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1443, 169);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 132;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1658, 168);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 131;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(643, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 134;
            this.label6.Text = "営業所名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1308, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 135;
            this.label1.Text = "入荷年月日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(103, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 136;
            this.label2.Text = "社員ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(103, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 137;
            this.label3.Text = "顧客ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(103, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 138;
            this.label4.Text = "入荷ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(1358, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 139;
            this.label5.Text = "受注ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(619, 450);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 140;
            this.label7.Text = "非表示理由";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(52, 450);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 24);
            this.label8.TabIndex = 141;
            this.label8.Text = "表示/非表示";
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbHidden.Location = new System.Drawing.Point(856, 447);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(896, 31);
            this.txbHidden.TabIndex = 143;
            // 
            // cmbConfirm
            // 
            this.cmbConfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbConfirm.FormattingEnabled = true;
            this.cmbConfirm.Items.AddRange(new object[] {
            "未確定",
            "確定"});
            this.cmbConfirm.Location = new System.Drawing.Point(1532, 385);
            this.cmbConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbConfirm.Name = "cmbConfirm";
            this.cmbConfirm.Size = new System.Drawing.Size(220, 32);
            this.cmbConfirm.TabIndex = 145;
            this.cmbConfirm.TabStop = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConfirm.Location = new System.Drawing.Point(1296, 388);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(142, 24);
            this.lblConfirm.TabIndex = 144;
            this.lblConfirm.Text = "未確定/確定";
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(421, 185);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 148;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbConfirm
            // 
            this.rdbConfirm.AutoSize = true;
            this.rdbConfirm.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbConfirm.Location = new System.Drawing.Point(263, 184);
            this.rdbConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbConfirm.Name = "rdbConfirm";
            this.rdbConfirm.Size = new System.Drawing.Size(103, 39);
            this.rdbConfirm.TabIndex = 147;
            this.rdbConfirm.Text = "確定";
            this.rdbConfirm.UseVisualStyleBackColor = true;
            this.rdbConfirm.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Checked = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(51, 185);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(173, 39);
            this.rdbUpdate.TabIndex = 146;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "表示更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // cmbSalesOfficeID
            // 
            this.cmbSalesOfficeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOfficeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSalesOfficeID.FormattingEnabled = true;
            this.cmbSalesOfficeID.Location = new System.Drawing.Point(856, 274);
            this.cmbSalesOfficeID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbSalesOfficeID.Name = "cmbSalesOfficeID";
            this.cmbSalesOfficeID.Size = new System.Drawing.Size(220, 32);
            this.cmbSalesOfficeID.TabIndex = 2;
            this.cmbSalesOfficeID.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(667, 336);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 150;
            this.label9.Text = "社員名";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Enabled = false;
            this.txbEmployeeName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.txbEmployeeName.Location = new System.Drawing.Point(856, 333);
            this.txbEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.ReadOnly = true;
            this.txbEmployeeName.Size = new System.Drawing.Size(220, 31);
            this.txbEmployeeName.TabIndex = 149;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(667, 389);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 152;
            this.label10.Text = "顧客名";
            // 
            // txbClientName
            // 
            this.txbClientName.Enabled = false;
            this.txbClientName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbClientName.ForeColor = System.Drawing.Color.Black;
            this.txbClientName.Location = new System.Drawing.Point(856, 386);
            this.txbClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.ReadOnly = true;
            this.txbClientName.Size = new System.Drawing.Size(220, 31);
            this.txbClientName.TabIndex = 151;
            // 
            // cmbHidden
            // 
            this.cmbHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHidden.ForeColor = System.Drawing.Color.Black;
            this.cmbHidden.FormattingEnabled = true;
            this.cmbHidden.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbHidden.Location = new System.Drawing.Point(263, 447);
            this.cmbHidden.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHidden.Name = "cmbHidden";
            this.cmbHidden.Size = new System.Drawing.Size(220, 32);
            this.cmbHidden.TabIndex = 153;
            this.cmbHidden.TabStop = false;
            // 
            // F_EigyoArrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.cmbHidden);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbEmployeeName);
            this.Controls.Add(this.cmbSalesOfficeID);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.rdbConfirm);
            this.Controls.Add(this.rdbUpdate);
            this.Controls.Add(this.cmbConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dgvArrivalDetail);
            this.Controls.Add(this.dgvArrival);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dtpArrivalDate);
            this.Controls.Add(this.txbEmployeeID);
            this.Controls.Add(this.txbOrderID);
            this.Controls.Add(this.txbClientID);
            this.Controls.Add(this.txbArrivalID);
            this.Controls.Add(this.pnlEigyo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_EigyoArrival";
            this.Text = "F_EigyoArrival";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_EigyoArrival_Load);
            this.pnlEigyo.ResumeLayout(false);
            this.pnlEigyo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivalDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrival)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlEigyo;
        private System.Windows.Forms.Label lblWarehousing;
        private System.Windows.Forms.TextBox txbArrivalID;
        private System.Windows.Forms.TextBox txbClientID;
        private System.Windows.Forms.TextBox txbOrderID;
        private System.Windows.Forms.TextBox txbEmployeeID;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.DataGridView dgvArrivalDetail;
        private System.Windows.Forms.DataGridView dgvArrival;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.ComboBox cmbConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbConfirm;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.ComboBox cmbSalesOfficeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbClientName;
        private System.Windows.Forms.ComboBox cmbHidden;
        private System.Windows.Forms.PictureBox pctHint;
    }
}
namespace SalesManagement_SysDev
{
    partial class F_EigyoStockView
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
            this.txbStockQuantity = new System.Windows.Forms.TextBox();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.dgvStockView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.pnlEigyo = new System.Windows.Forms.Panel();
            this.pctHint = new System.Windows.Forms.PictureBox();
            this.lblStockView = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbHattyuten = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockView)).BeginInit();
            this.pnlEigyo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            this.SuspendLayout();
            // 
            // txbStockQuantity
            // 
            this.txbStockQuantity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbStockQuantity.ForeColor = System.Drawing.Color.Black;
            this.txbStockQuantity.Location = new System.Drawing.Point(1084, 338);
            this.txbStockQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txbStockQuantity.Name = "txbStockQuantity";
            this.txbStockQuantity.Size = new System.Drawing.Size(220, 31);
            this.txbStockQuantity.TabIndex = 2;
            // 
            // txbProductID
            // 
            this.txbProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductID.ForeColor = System.Drawing.Color.Black;
            this.txbProductID.Location = new System.Drawing.Point(198, 338);
            this.txbProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(220, 31);
            this.txbProductID.TabIndex = 3;
            this.txbProductID.TextChanged += new System.EventHandler(this.txbProdactID_TextChanged);
            this.txbProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // dgvStockView
            // 
            this.dgvStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockView.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvStockView.Location = new System.Drawing.Point(11, 451);
            this.dgvStockView.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStockView.Name = "dgvStockView";
            this.dgvStockView.RowHeadersWidth = 51;
            this.dgvStockView.RowTemplate.Height = 24;
            this.dgvStockView.Size = new System.Drawing.Size(1882, 563);
            this.dgvStockView.TabIndex = 5;
            this.dgvStockView.TabStop = false;
            this.dgvStockView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockView_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1720, 44);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1787, 1029);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 60;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1841, 1029);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 61;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1733, 1029);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 62;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(1679, 1029);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 63;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(1486, 1032);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 64;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(1540, 1038);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(67, 22);
            this.lblNumPage.TabIndex = 65;
            this.lblNumPage.Text = "ページ";
            // 
            // btnPageSize
            // 
            this.btnPageSize.BackColor = System.Drawing.Color.White;
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(270, 1029);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 66;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = false;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(170, 1032);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 67;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(41, 1035);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(114, 21);
            this.lblPageSize.TabIndex = 68;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // pnlEigyo
            // 
            this.pnlEigyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(128)))));
            this.pnlEigyo.Controls.Add(this.pctHint);
            this.pnlEigyo.Controls.Add(this.lblStockView);
            this.pnlEigyo.Controls.Add(this.btnReturn);
            this.pnlEigyo.Controls.Add(this.btnClose);
            this.pnlEigyo.Location = new System.Drawing.Point(1, -2);
            this.pnlEigyo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEigyo.Name = "pnlEigyo";
            this.pnlEigyo.Size = new System.Drawing.Size(1920, 150);
            this.pnlEigyo.TabIndex = 69;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1633, 54);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 93;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // lblStockView
            // 
            this.lblStockView.AutoSize = true;
            this.lblStockView.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStockView.ForeColor = System.Drawing.Color.Black;
            this.lblStockView.Location = new System.Drawing.Point(826, 44);
            this.lblStockView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockView.Name = "lblStockView";
            this.lblStockView.Size = new System.Drawing.Size(287, 64);
            this.lblStockView.TabIndex = 23;
            this.lblStockView.Text = "在庫確認";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(34, 44);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(307, 211);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 70;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeID.Location = new System.Drawing.Point(98, 341);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(80, 24);
            this.lblEmployeeID.TabIndex = 84;
            this.lblEmployeeID.Text = "商品ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(976, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 85;
            this.label1.Text = "在庫数";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1459, 194);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 87;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1667, 194);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 88;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txbProductName
            // 
            this.txbProductName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbProductName.ForeColor = System.Drawing.Color.Black;
            this.txbProductName.Location = new System.Drawing.Point(650, 338);
            this.txbProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.ReadOnly = true;
            this.txbProductName.Size = new System.Drawing.Size(220, 31);
            this.txbProductName.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(549, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 92;
            this.label3.Text = "商品名";
            // 
            // rdbHattyuten
            // 
            this.rdbHattyuten.AutoSize = true;
            this.rdbHattyuten.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbHattyuten.Location = new System.Drawing.Point(61, 210);
            this.rdbHattyuten.Margin = new System.Windows.Forms.Padding(2);
            this.rdbHattyuten.Name = "rdbHattyuten";
            this.rdbHattyuten.Size = new System.Drawing.Size(208, 39);
            this.rdbHattyuten.TabIndex = 99;
            this.rdbHattyuten.Text = "発注点検索";
            this.rdbHattyuten.UseVisualStyleBackColor = true;
            // 
            // F_EigyoStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.rdbHattyuten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.pnlEigyo);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvStockView);
            this.Controls.Add(this.txbProductID);
            this.Controls.Add(this.txbStockQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_EigyoStockView";
            this.Text = "F_EigyoStockView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_EigyoStockView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockView)).EndInit();
            this.pnlEigyo.ResumeLayout(false);
            this.pnlEigyo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbStockQuantity;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.DataGridView dgvStockView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.Panel pnlEigyo;
        private System.Windows.Forms.Label lblStockView;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctHint;
        private System.Windows.Forms.RadioButton rdbHattyuten;
    }
}
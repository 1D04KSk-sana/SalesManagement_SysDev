namespace SalesManagement_SysDev
{
    partial class F_ButuryuStock
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
            this.lblClient = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbStockQuentity = new System.Windows.Forms.TextBox();
            this.txbProdactName = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbHattyuten = new System.Windows.Forms.RadioButton();
            this.btnProdactView = new System.Windows.Forms.Button();
            this.pnlButuryu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButuryu
            // 
            this.pnlButuryu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(179)))));
            this.pnlButuryu.Controls.Add(this.pctHint);
            this.pnlButuryu.Controls.Add(this.btnClose);
            this.pnlButuryu.Controls.Add(this.lblClient);
            this.pnlButuryu.Controls.Add(this.btnReturn);
            this.pnlButuryu.Location = new System.Drawing.Point(1, 1);
            this.pnlButuryu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlButuryu.Name = "pnlButuryu";
            this.pnlButuryu.Size = new System.Drawing.Size(1920, 150);
            this.pnlButuryu.TabIndex = 23;
            // 
            // pctHint
            // 
            this.pctHint.Image = global::SalesManagement_SysDev.Properties.Resources.Question;
            this.pctHint.Location = new System.Drawing.Point(1623, 46);
            this.pctHint.Name = "pctHint";
            this.pctHint.Size = new System.Drawing.Size(60, 60);
            this.pctHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHint.TabIndex = 98;
            this.pctHint.TabStop = false;
            this.pctHint.Click += new System.EventHandler(this.pctHint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.btnClose.Location = new System.Drawing.Point(1719, 40);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 24;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClient.ForeColor = System.Drawing.Color.Black;
            this.lblClient.Location = new System.Drawing.Point(806, 40);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(287, 64);
            this.lblClient.TabIndex = 23;
            this.lblClient.Text = "在庫管理";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.btnReturn.Location = new System.Drawing.Point(30, 36);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1524, 192);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 24;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1720, 192);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 25;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txbProductID
            // 
            this.txbProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbProductID.Location = new System.Drawing.Point(236, 330);
            this.txbProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txbProductID.MaxLength = 4;
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(220, 31);
            this.txbProductID.TabIndex = 76;
            this.txbProductID.TextChanged += new System.EventHandler(this.txbProductID_TextChanged);
            this.txbProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblProductID.Location = new System.Drawing.Point(126, 328);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(80, 24);
            this.lblProductID.TabIndex = 77;
            this.lblProductID.Text = "商品ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(1046, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "在庫数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label3.Location = new System.Drawing.Point(566, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 81;
            this.label3.Text = "商品名";
            // 
            // txbStockQuentity
            // 
            this.txbStockQuentity.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbStockQuentity.Location = new System.Drawing.Point(1168, 325);
            this.txbStockQuentity.Margin = new System.Windows.Forms.Padding(2);
            this.txbStockQuentity.MaxLength = 4;
            this.txbStockQuentity.Name = "txbStockQuentity";
            this.txbStockQuentity.Size = new System.Drawing.Size(220, 31);
            this.txbStockQuentity.TabIndex = 83;
            // 
            // txbProdactName
            // 
            this.txbProdactName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbProdactName.Location = new System.Drawing.Point(688, 328);
            this.txbProdactName.Margin = new System.Windows.Forms.Padding(2);
            this.txbProdactName.MaxLength = 4;
            this.txbProdactName.Name = "txbProdactName";
            this.txbProdactName.ReadOnly = true;
            this.txbProdactName.Size = new System.Drawing.Size(220, 31);
            this.txbProdactName.TabIndex = 84;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvStock.Location = new System.Drawing.Point(9, 432);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 27;
            this.dgvStock.Size = new System.Drawing.Size(1900, 582);
            this.dgvStock.TabIndex = 87;
            this.dgvStock.TabStop = false;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // btnPageSize
            // 
            this.btnPageSize.BackColor = System.Drawing.Color.White;
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageSize.Location = new System.Drawing.Point(205, 1037);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 90;
            this.btnPageSize.TabStop = false;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = false;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(141, 1044);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 28);
            this.txbPageSize.TabIndex = 89;
            this.txbPageSize.TabStop = false;
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPageSize.Location = new System.Drawing.Point(15, 1047);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(120, 21);
            this.lblPageSize.TabIndex = 88;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(1756, 1037);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 96;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.BackColor = System.Drawing.Color.White;
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMax.Location = new System.Drawing.Point(1864, 1037);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 95;
            this.btnPageMax.TabStop = false;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = false;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(1810, 1037);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 94;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMin
            // 
            this.btnPageMin.BackColor = System.Drawing.Color.White;
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPageMin.Location = new System.Drawing.Point(1702, 1037);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 93;
            this.btnPageMin.TabStop = false;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = false;
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumPage.Location = new System.Drawing.Point(1620, 1047);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(64, 21);
            this.lblNumPage.TabIndex = 92;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Enabled = false;
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNumPage.Location = new System.Drawing.Point(1566, 1044);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.ReadOnly = true;
            this.txbNumPage.Size = new System.Drawing.Size(50, 28);
            this.txbNumPage.TabIndex = 91;
            this.txbNumPage.TabStop = false;
            this.txbNumPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbSearch.Location = new System.Drawing.Point(468, 197);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 28;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Checked = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbUpdate.Location = new System.Drawing.Point(43, 197);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(103, 39);
            this.rdbUpdate.TabIndex = 97;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rdbHattyuten
            // 
            this.rdbHattyuten.AutoSize = true;
            this.rdbHattyuten.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbHattyuten.Location = new System.Drawing.Point(205, 197);
            this.rdbHattyuten.Margin = new System.Windows.Forms.Padding(2);
            this.rdbHattyuten.Name = "rdbHattyuten";
            this.rdbHattyuten.Size = new System.Drawing.Size(208, 39);
            this.rdbHattyuten.TabIndex = 98;
            this.rdbHattyuten.Text = "発注点検索";
            this.rdbHattyuten.UseVisualStyleBackColor = true;
            this.rdbHattyuten.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // btnProdactView
            // 
            this.btnProdactView.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnProdactView.Location = new System.Drawing.Point(1587, 319);
            this.btnProdactView.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdactView.Name = "btnProdactView";
            this.btnProdactView.Size = new System.Drawing.Size(204, 43);
            this.btnProdactView.TabIndex = 132;
            this.btnProdactView.TabStop = false;
            this.btnProdactView.Text = "商品一覧";
            this.btnProdactView.UseVisualStyleBackColor = true;
            this.btnProdactView.Click += new System.EventHandler(this.btnProdactView_Click);
            // 
            // F_ButuryuStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.btnProdactView);
            this.Controls.Add(this.rdbHattyuten);
            this.Controls.Add(this.rdbUpdate);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.txbProdactName);
            this.Controls.Add(this.txbStockQuentity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txbProductID);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlButuryu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_ButuryuStock";
            this.Text = "在庫管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_ButuryuStock_Load);
            this.pnlButuryu.ResumeLayout(false);
            this.pnlButuryu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButuryu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStockQuentity;
        private System.Windows.Forms.TextBox txbProdactName;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.PictureBox pctHint;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbHattyuten;
        private System.Windows.Forms.Button btnProdactView;
    }
}
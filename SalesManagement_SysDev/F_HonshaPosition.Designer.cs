namespace SalesManagement_SysDev
{
    partial class F_HonshaPosition
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
            this.pnlHonsha = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbRegister = new System.Windows.Forms.RadioButton();
            this.txbPositionID = new System.Windows.Forms.TextBox();
            this.lblPositionID = new System.Windows.Forms.Label();
            this.txbPositionName = new System.Windows.Forms.TextBox();
            this.PositionName = new System.Windows.Forms.Label();
            this.txbPositionListFlug = new System.Windows.Forms.TextBox();
            this.lblPositionListFlug = new System.Windows.Forms.Label();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblClientHidden = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.btnPageSize = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPageMin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageMax = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.pnlHonsha.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHonsha
            // 
            this.pnlHonsha.BackColor = System.Drawing.Color.Lime;
            this.pnlHonsha.Controls.Add(this.btnClose);
            this.pnlHonsha.Controls.Add(this.lblPosition);
            this.pnlHonsha.Controls.Add(this.btnReturn);
            this.pnlHonsha.Location = new System.Drawing.Point(-8, -2);
            this.pnlHonsha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHonsha.Name = "pnlHonsha";
            this.pnlHonsha.Size = new System.Drawing.Size(1920, 150);
            this.pnlHonsha.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnClose.Location = new System.Drawing.Point(1699, 30);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 80);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(720, 46);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(417, 64);
            this.lblPosition.TabIndex = 23;
            this.lblPosition.Text = "役職管理画面";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnReturn.Location = new System.Drawing.Point(20, 30);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 80);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSelect.Controls.Add(this.rdbSearch);
            this.pnlSelect.Controls.Add(this.rdbUpdate);
            this.pnlSelect.Controls.Add(this.rdbRegister);
            this.pnlSelect.Location = new System.Drawing.Point(12, 187);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(577, 74);
            this.pnlSelect.TabIndex = 24;
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbSearch.Location = new System.Drawing.Point(424, 16);
            this.rdbSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(103, 39);
            this.rdbSearch.TabIndex = 2;
            this.rdbSearch.TabStop = true;
            this.rdbSearch.Text = "検索";
            this.rdbSearch.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbUpdate.Location = new System.Drawing.Point(218, 16);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(103, 39);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "更新";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbRegister
            // 
            this.rdbRegister.AutoSize = true;
            this.rdbRegister.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.rdbRegister.Location = new System.Drawing.Point(29, 16);
            this.rdbRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbRegister.Name = "rdbRegister";
            this.rdbRegister.Size = new System.Drawing.Size(103, 39);
            this.rdbRegister.TabIndex = 0;
            this.rdbRegister.TabStop = true;
            this.rdbRegister.Text = "登録";
            this.rdbRegister.UseVisualStyleBackColor = true;
            // 
            // txbPositionID
            // 
            this.txbPositionID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbPositionID.Location = new System.Drawing.Point(280, 311);
            this.txbPositionID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPositionID.Name = "txbPositionID";
            this.txbPositionID.Size = new System.Drawing.Size(220, 31);
            this.txbPositionID.TabIndex = 26;
            // 
            // lblPositionID
            // 
            this.lblPositionID.AutoSize = true;
            this.lblPositionID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblPositionID.Location = new System.Drawing.Point(172, 315);
            this.lblPositionID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPositionID.Name = "lblPositionID";
            this.lblPositionID.Size = new System.Drawing.Size(80, 24);
            this.lblPositionID.TabIndex = 25;
            this.lblPositionID.Text = "役職ID";
            // 
            // txbPositionName
            // 
            this.txbPositionName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbPositionName.Location = new System.Drawing.Point(819, 311);
            this.txbPositionName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPositionName.Name = "txbPositionName";
            this.txbPositionName.Size = new System.Drawing.Size(220, 31);
            this.txbPositionName.TabIndex = 28;
            // 
            // PositionName
            // 
            this.PositionName.AutoSize = true;
            this.PositionName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.PositionName.Location = new System.Drawing.Point(692, 314);
            this.PositionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PositionName.Name = "PositionName";
            this.PositionName.Size = new System.Drawing.Size(82, 24);
            this.PositionName.TabIndex = 27;
            this.PositionName.Text = "役職名";
            // 
            // txbPositionListFlug
            // 
            this.txbPositionListFlug.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbPositionListFlug.Location = new System.Drawing.Point(1357, 311);
            this.txbPositionListFlug.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPositionListFlug.Name = "txbPositionListFlug";
            this.txbPositionListFlug.Size = new System.Drawing.Size(220, 31);
            this.txbPositionListFlug.TabIndex = 30;
            // 
            // lblPositionListFlug
            // 
            this.lblPositionListFlug.AutoSize = true;
            this.lblPositionListFlug.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblPositionListFlug.Location = new System.Drawing.Point(1192, 314);
            this.lblPositionListFlug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPositionListFlug.Name = "lblPositionListFlug";
            this.lblPositionListFlug.Size = new System.Drawing.Size(157, 24);
            this.lblPositionListFlug.TabIndex = 29;
            this.lblPositionListFlug.Text = "役職管理フラグ";
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txbHidden.Location = new System.Drawing.Point(501, 388);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(1076, 31);
            this.txbHidden.TabIndex = 32;
            // 
            // lblClientHidden
            // 
            this.lblClientHidden.AutoSize = true;
            this.lblClientHidden.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblClientHidden.Location = new System.Drawing.Point(350, 391);
            this.lblClientHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientHidden.Name = "lblClientHidden";
            this.lblClientHidden.Size = new System.Drawing.Size(130, 24);
            this.lblClientHidden.TabIndex = 31;
            this.lblClientHidden.Text = "非表示理由";
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dgvClient.Location = new System.Drawing.Point(11, 459);
            this.dgvClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(1880, 495);
            this.dgvClient.TabIndex = 33;
            this.dgvClient.TabStop = false;
            // 
            // btnPageSize
            // 
            this.btnPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageSize.Location = new System.Drawing.Point(230, 981);
            this.btnPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageSize.Name = "btnPageSize";
            this.btnPageSize.Size = new System.Drawing.Size(140, 40);
            this.btnPageSize.TabIndex = 36;
            this.btnPageSize.Text = "行数変更";
            this.btnPageSize.UseVisualStyleBackColor = true;
            this.btnPageSize.Click += new System.EventHandler(this.btnPageSize_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lblPageSize.Location = new System.Drawing.Point(28, 991);
            this.lblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(119, 22);
            this.lblPageSize.TabIndex = 35;
            this.lblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbPageSize.Location = new System.Drawing.Point(159, 988);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 29);
            this.txbPageSize.TabIndex = 34;
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lblNumPage.Location = new System.Drawing.Point(1496, 989);
            this.lblNumPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(64, 22);
            this.lblNumPage.TabIndex = 42;
            this.lblNumPage.Text = "ページ";
            // 
            // txbNumPage
            // 
            this.txbNumPage.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbNumPage.Location = new System.Drawing.Point(1431, 988);
            this.txbNumPage.Margin = new System.Windows.Forms.Padding(1);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.Size = new System.Drawing.Size(50, 29);
            this.txbNumPage.TabIndex = 41;
            // 
            // btnPageMin
            // 
            this.btnPageMin.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageMin.Location = new System.Drawing.Point(1584, 981);
            this.btnPageMin.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageMin.Name = "btnPageMin";
            this.btnPageMin.Size = new System.Drawing.Size(50, 40);
            this.btnPageMin.TabIndex = 40;
            this.btnPageMin.Text = "|◀";
            this.btnPageMin.UseVisualStyleBackColor = true;
            this.btnPageMin.Click += new System.EventHandler(this.btnPageMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnBack.Location = new System.Drawing.Point(1656, 981);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnNext.Location = new System.Drawing.Point(1723, 981);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 40);
            this.btnNext.TabIndex = 38;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageMax
            // 
            this.btnPageMax.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPageMax.Location = new System.Drawing.Point(1789, 981);
            this.btnPageMax.Margin = new System.Windows.Forms.Padding(1);
            this.btnPageMax.Name = "btnPageMax";
            this.btnPageMax.Size = new System.Drawing.Size(50, 40);
            this.btnPageMax.TabIndex = 37;
            this.btnPageMax.Text = "▶|";
            this.btnPageMax.UseVisualStyleBackColor = true;
            this.btnPageMax.Click += new System.EventHandler(this.btnPageMax_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1530, 187);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 70);
            this.btnClear.TabIndex = 96;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(1723, 187);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(160, 70);
            this.btnDone.TabIndex = 95;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "実行";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Font = new System.Drawing.Font("MS UI Gothic", 26F);
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "表示",
            "非表示"});
            this.cmbView.Location = new System.Drawing.Point(1139, 202);
            this.cmbView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(360, 43);
            this.cmbView.TabIndex = 97;
            // 
            // F_HonshaPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblNumPage);
            this.Controls.Add(this.txbNumPage);
            this.Controls.Add(this.btnPageMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageMax);
            this.Controls.Add(this.btnPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.lblClientHidden);
            this.Controls.Add(this.txbPositionListFlug);
            this.Controls.Add(this.lblPositionListFlug);
            this.Controls.Add(this.txbPositionName);
            this.Controls.Add(this.PositionName);
            this.Controls.Add(this.txbPositionID);
            this.Controls.Add(this.lblPositionID);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlHonsha);
            this.Name = "F_HonshaPosition";
            this.Text = "F_HonshaPosition";
            this.pnlHonsha.ResumeLayout(false);
            this.pnlHonsha.PerformLayout();
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHonsha;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbRegister;
        private System.Windows.Forms.TextBox txbPositionID;
        private System.Windows.Forms.Label lblPositionID;
        private System.Windows.Forms.TextBox txbPositionName;
        private System.Windows.Forms.Label PositionName;
        private System.Windows.Forms.TextBox txbPositionListFlug;
        private System.Windows.Forms.Label lblPositionListFlug;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Label lblClientHidden;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btnPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.Button btnPageMin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageMax;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbView;
    }
}
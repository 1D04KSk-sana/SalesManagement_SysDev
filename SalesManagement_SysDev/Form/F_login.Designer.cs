namespace SalesManagement_SysDev
{
    partial class F_Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CleateDabase = new System.Windows.Forms.Button();
            this.btn_InsertSampleData = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbEmployeeID = new System.Windows.Forms.TextBox();
            this.txbSinghUpPass = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblSinghUpPass = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblProdact = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CleateDabase
            // 
            this.btn_CleateDabase.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_CleateDabase.Location = new System.Drawing.Point(1607, 802);
            this.btn_CleateDabase.Name = "btn_CleateDabase";
            this.btn_CleateDabase.Size = new System.Drawing.Size(212, 84);
            this.btn_CleateDabase.TabIndex = 0;
            this.btn_CleateDabase.TabStop = false;
            this.btn_CleateDabase.Text = "データベース生成";
            this.btn_CleateDabase.UseVisualStyleBackColor = true;
            this.btn_CleateDabase.Click += new System.EventHandler(this.btn_CleateDabase_Click);
            // 
            // btn_InsertSampleData
            // 
            this.btn_InsertSampleData.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_InsertSampleData.Location = new System.Drawing.Point(1607, 915);
            this.btn_InsertSampleData.Name = "btn_InsertSampleData";
            this.btn_InsertSampleData.Size = new System.Drawing.Size(212, 84);
            this.btn_InsertSampleData.TabIndex = 0;
            this.btn_InsertSampleData.TabStop = false;
            this.btn_InsertSampleData.Text = "サンプルデータ登録";
            this.btn_InsertSampleData.UseVisualStyleBackColor = true;
            this.btn_InsertSampleData.Click += new System.EventHandler(this.btn_InsertSampleData_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogin.Location = new System.Drawing.Point(771, 693);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(406, 108);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "ログイン";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmployeeID.Location = new System.Drawing.Point(878, 317);
            this.txbEmployeeID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.Size = new System.Drawing.Size(309, 42);
            this.txbEmployeeID.TabIndex = 6;
            // 
            // txbSinghUpPass
            // 
            this.txbSinghUpPass.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSinghUpPass.Location = new System.Drawing.Point(878, 468);
            this.txbSinghUpPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSinghUpPass.Name = "txbSinghUpPass";
            this.txbSinghUpPass.Size = new System.Drawing.Size(299, 42);
            this.txbSinghUpPass.TabIndex = 7;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmployeeID.Location = new System.Drawing.Point(754, 325);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(101, 29);
            this.lblEmployeeID.TabIndex = 8;
            this.lblEmployeeID.Text = "社員ID";
            // 
            // lblSinghUpPass
            // 
            this.lblSinghUpPass.AutoSize = true;
            this.lblSinghUpPass.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSinghUpPass.Location = new System.Drawing.Point(724, 476);
            this.lblSinghUpPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinghUpPass.Name = "lblSinghUpPass";
            this.lblSinghUpPass.Size = new System.Drawing.Size(131, 29);
            this.lblSinghUpPass.TabIndex = 9;
            this.lblSinghUpPass.Text = "パスワード";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.pnlLogin.Controls.Add(this.btnclose);
            this.pnlLogin.Controls.Add(this.lblProdact);
            this.pnlLogin.Location = new System.Drawing.Point(1, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1920, 150);
            this.pnlLogin.TabIndex = 43;
            // 
            // lblProdact
            // 
            this.lblProdact.AutoSize = true;
            this.lblProdact.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdact.Location = new System.Drawing.Point(801, 42);
            this.lblProdact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdact.Name = "lblProdact";
            this.lblProdact.Size = new System.Drawing.Size(350, 64);
            this.lblProdact.TabIndex = 1;
            this.lblProdact.Text = "ログイン画面";
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnclose.Location = new System.Drawing.Point(1722, 39);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(160, 70);
            this.btnclose.TabIndex = 2;
            this.btnclose.TabStop = false;
            this.btnclose.Text = "閉じる";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(250)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblSinghUpPass);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txbSinghUpPass);
            this.Controls.Add(this.txbEmployeeID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btn_InsertSampleData);
            this.Controls.Add(this.btn_CleateDabase);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "F_Login";
            this.Text = "販売管理システムログイン画面";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CleateDabase;
        private System.Windows.Forms.Button btn_InsertSampleData;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbEmployeeID;
        private System.Windows.Forms.TextBox txbSinghUpPass;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblSinghUpPass;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblProdact;
        private System.Windows.Forms.Button btnclose;
    }
}


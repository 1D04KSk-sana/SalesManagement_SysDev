namespace SalesManagement_SysDev
{
    partial class F_PassChange
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
            this.pnlPassChange = new System.Windows.Forms.Panel();
            this.lblProdact = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pctPassEye = new System.Windows.Forms.PictureBox();
            this.lblSinghUpPass = new System.Windows.Forms.Label();
            this.txbSinghUpPass = new System.Windows.Forms.TextBox();
            this.lblPassKaku = new System.Windows.Forms.Label();
            this.txbPassKaku = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlPassChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassEye)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPassChange
            // 
            this.pnlPassChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.pnlPassChange.Controls.Add(this.btnReturn);
            this.pnlPassChange.Controls.Add(this.lblProdact);
            this.pnlPassChange.Location = new System.Drawing.Point(-1, -1);
            this.pnlPassChange.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPassChange.Name = "pnlPassChange";
            this.pnlPassChange.Size = new System.Drawing.Size(1920, 150);
            this.pnlPassChange.TabIndex = 44;
            // 
            // lblProdact
            // 
            this.lblProdact.AutoSize = true;
            this.lblProdact.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProdact.Location = new System.Drawing.Point(777, 45);
            this.lblProdact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdact.Name = "lblProdact";
            this.lblProdact.Size = new System.Drawing.Size(410, 64);
            this.lblProdact.TabIndex = 1;
            this.lblProdact.Text = "パスワード変更";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnReturn.Location = new System.Drawing.Point(36, 39);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 70);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseCompatibleTextRendering = true;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pctPassEye
            // 
            this.pctPassEye.Image = global::SalesManagement_SysDev.Properties.Resources.PassEyeNot;
            this.pctPassEye.Location = new System.Drawing.Point(1188, 572);
            this.pctPassEye.Name = "pctPassEye";
            this.pctPassEye.Size = new System.Drawing.Size(73, 50);
            this.pctPassEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPassEye.TabIndex = 47;
            this.pctPassEye.TabStop = false;
            this.pctPassEye.Click += new System.EventHandler(this.pctPassEye_Click);
            // 
            // lblSinghUpPass
            // 
            this.lblSinghUpPass.AutoSize = true;
            this.lblSinghUpPass.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSinghUpPass.Location = new System.Drawing.Point(693, 416);
            this.lblSinghUpPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinghUpPass.Name = "lblSinghUpPass";
            this.lblSinghUpPass.Size = new System.Drawing.Size(131, 29);
            this.lblSinghUpPass.TabIndex = 46;
            this.lblSinghUpPass.Text = "パスワード";
            // 
            // txbSinghUpPass
            // 
            this.txbSinghUpPass.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSinghUpPass.Location = new System.Drawing.Point(847, 408);
            this.txbSinghUpPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSinghUpPass.Name = "txbSinghUpPass";
            this.txbSinghUpPass.PasswordChar = '*';
            this.txbSinghUpPass.Size = new System.Drawing.Size(299, 42);
            this.txbSinghUpPass.TabIndex = 45;
            // 
            // lblPassKaku
            // 
            this.lblPassKaku.AutoSize = true;
            this.lblPassKaku.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPassKaku.Location = new System.Drawing.Point(571, 584);
            this.lblPassKaku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassKaku.Name = "lblPassKaku";
            this.lblPassKaku.Size = new System.Drawing.Size(253, 29);
            this.lblPassKaku.TabIndex = 49;
            this.lblPassKaku.Text = "パスワード（確認用）";
            // 
            // txbPassKaku
            // 
            this.txbPassKaku.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPassKaku.Location = new System.Drawing.Point(847, 576);
            this.txbPassKaku.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPassKaku.Name = "txbPassKaku";
            this.txbPassKaku.PasswordChar = '*';
            this.txbPassKaku.Size = new System.Drawing.Size(299, 42);
            this.txbPassKaku.TabIndex = 48;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogin.Location = new System.Drawing.Point(780, 777);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(406, 108);
            this.btnLogin.TabIndex = 50;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "変更更新";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // F_PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(250)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1920, 1020);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassKaku);
            this.Controls.Add(this.txbPassKaku);
            this.Controls.Add(this.pctPassEye);
            this.Controls.Add(this.lblSinghUpPass);
            this.Controls.Add(this.txbSinghUpPass);
            this.Controls.Add(this.pnlPassChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_PassChange";
            this.Text = "F_PassChange";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_PassChange_Load);
            this.pnlPassChange.ResumeLayout(false);
            this.pnlPassChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPassChange;
        private System.Windows.Forms.Label lblProdact;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pctPassEye;
        private System.Windows.Forms.Label lblSinghUpPass;
        private System.Windows.Forms.TextBox txbSinghUpPass;
        private System.Windows.Forms.Label lblPassKaku;
        private System.Windows.Forms.TextBox txbPassKaku;
        private System.Windows.Forms.Button btnLogin;
    }
}
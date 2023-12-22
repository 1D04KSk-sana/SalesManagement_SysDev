namespace SalesManagement_SysDev
{
    partial class F_Buturyu
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
            this.btnFormStock = new System.Windows.Forms.Button();
            this.btnFormSyukko = new System.Windows.Forms.Button();
            this.btnFormChumon = new System.Windows.Forms.Button();
            this.btnFormWarehousing = new System.Windows.Forms.Button();
            this.btnFormHattyu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblButuryu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormStock
            // 
            this.btnFormStock.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormStock.Location = new System.Drawing.Point(686, 214);
            this.btnFormStock.Name = "btnFormStock";
            this.btnFormStock.Size = new System.Drawing.Size(510, 100);
            this.btnFormStock.TabIndex = 0;
            this.btnFormStock.Text = "在庫管理画面";
            this.btnFormStock.UseVisualStyleBackColor = true;
            this.btnFormStock.Click += new System.EventHandler(this.btnFormStock_Click);
            // 
            // btnFormSyukko
            // 
            this.btnFormSyukko.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormSyukko.Location = new System.Drawing.Point(686, 844);
            this.btnFormSyukko.Name = "btnFormSyukko";
            this.btnFormSyukko.Size = new System.Drawing.Size(510, 100);
            this.btnFormSyukko.TabIndex = 1;
            this.btnFormSyukko.Text = "出庫管理画面";
            this.btnFormSyukko.UseVisualStyleBackColor = true;
            this.btnFormSyukko.Click += new System.EventHandler(this.btnFormSyukko_Click);
            // 
            // btnFormChumon
            // 
            this.btnFormChumon.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormChumon.Location = new System.Drawing.Point(686, 686);
            this.btnFormChumon.Name = "btnFormChumon";
            this.btnFormChumon.Size = new System.Drawing.Size(510, 100);
            this.btnFormChumon.TabIndex = 2;
            this.btnFormChumon.Text = "注文管理画面";
            this.btnFormChumon.UseVisualStyleBackColor = true;
            this.btnFormChumon.Click += new System.EventHandler(this.btnFormChumon_Click);
            // 
            // btnFormWarehousing
            // 
            this.btnFormWarehousing.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormWarehousing.Location = new System.Drawing.Point(686, 372);
            this.btnFormWarehousing.Name = "btnFormWarehousing";
            this.btnFormWarehousing.Size = new System.Drawing.Size(510, 100);
            this.btnFormWarehousing.TabIndex = 3;
            this.btnFormWarehousing.Text = "入庫管理画面";
            this.btnFormWarehousing.UseVisualStyleBackColor = true;
            this.btnFormWarehousing.Click += new System.EventHandler(this.btnFormWarehousing_Click);
            // 
            // btnFormHattyu
            // 
            this.btnFormHattyu.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormHattyu.Location = new System.Drawing.Point(686, 529);
            this.btnFormHattyu.Name = "btnFormHattyu";
            this.btnFormHattyu.Size = new System.Drawing.Size(510, 100);
            this.btnFormHattyu.TabIndex = 4;
            this.btnFormHattyu.Text = "発注管理画面";
            this.btnFormHattyu.UseVisualStyleBackColor = true;
            this.btnFormHattyu.Click += new System.EventHandler(this.btnFormHattyu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1704, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogOut.Location = new System.Drawing.Point(32, 38);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(160, 70);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "ログアウト";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.lblButuryu);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 7;
            // 
            // lblButuryu
            // 
            this.lblButuryu.AutoSize = true;
            this.lblButuryu.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblButuryu.Location = new System.Drawing.Point(797, 44);
            this.lblButuryu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButuryu.Name = "lblButuryu";
            this.lblButuryu.Size = new System.Drawing.Size(287, 64);
            this.lblButuryu.TabIndex = 7;
            this.lblButuryu.Text = "物流管理";
            // 
            // F_Buturyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFormHattyu);
            this.Controls.Add(this.btnFormWarehousing);
            this.Controls.Add(this.btnFormChumon);
            this.Controls.Add(this.btnFormSyukko);
            this.Controls.Add(this.btnFormStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Buturyu";
            this.Text = "F_Buturyu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormStock;
        private System.Windows.Forms.Button btnFormSyukko;
        private System.Windows.Forms.Button btnFormChumon;
        private System.Windows.Forms.Button btnFormWarehousing;
        private System.Windows.Forms.Button btnFormHattyu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblButuryu;
    }
}
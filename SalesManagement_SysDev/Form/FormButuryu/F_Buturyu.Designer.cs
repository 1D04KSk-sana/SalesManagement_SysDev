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
            this.SuspendLayout();
            // 
            // btnFormStock
            // 
            this.btnFormStock.Location = new System.Drawing.Point(459, 145);
            this.btnFormStock.Name = "btnFormStock";
            this.btnFormStock.Size = new System.Drawing.Size(75, 23);
            this.btnFormStock.TabIndex = 0;
            this.btnFormStock.Text = "在庫管理画面";
            this.btnFormStock.UseVisualStyleBackColor = true;
            this.btnFormStock.Click += new System.EventHandler(this.btnFormStock_Click);
            // 
            // btnFormSyukko
            // 
            this.btnFormSyukko.Location = new System.Drawing.Point(459, 479);
            this.btnFormSyukko.Name = "btnFormSyukko";
            this.btnFormSyukko.Size = new System.Drawing.Size(75, 23);
            this.btnFormSyukko.TabIndex = 1;
            this.btnFormSyukko.Text = "出庫管理画面";
            this.btnFormSyukko.UseVisualStyleBackColor = true;
            this.btnFormSyukko.Click += new System.EventHandler(this.btnFormSyukko_Click);
            // 
            // btnFormChumon
            // 
            this.btnFormChumon.Location = new System.Drawing.Point(459, 385);
            this.btnFormChumon.Name = "btnFormChumon";
            this.btnFormChumon.Size = new System.Drawing.Size(75, 23);
            this.btnFormChumon.TabIndex = 2;
            this.btnFormChumon.Text = "注文管理画面";
            this.btnFormChumon.UseVisualStyleBackColor = true;
            this.btnFormChumon.Click += new System.EventHandler(this.btnFormChumon_Click);
            // 
            // btnFormWarehousing
            // 
            this.btnFormWarehousing.Location = new System.Drawing.Point(459, 223);
            this.btnFormWarehousing.Name = "btnFormWarehousing";
            this.btnFormWarehousing.Size = new System.Drawing.Size(75, 23);
            this.btnFormWarehousing.TabIndex = 3;
            this.btnFormWarehousing.Text = "入庫管理画面";
            this.btnFormWarehousing.UseVisualStyleBackColor = true;
            this.btnFormWarehousing.Click += new System.EventHandler(this.btnFormWarehousing_Click);
            // 
            // btnFormHattyu
            // 
            this.btnFormHattyu.Location = new System.Drawing.Point(459, 311);
            this.btnFormHattyu.Name = "btnFormHattyu";
            this.btnFormHattyu.Size = new System.Drawing.Size(75, 23);
            this.btnFormHattyu.TabIndex = 4;
            this.btnFormHattyu.Text = "発注管理画面";
            this.btnFormHattyu.UseVisualStyleBackColor = true;
            this.btnFormHattyu.Click += new System.EventHandler(this.btnFormHattyu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(889, 48);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(61, 48);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "ログアウト";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // F_Buturyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 571);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFormHattyu);
            this.Controls.Add(this.btnFormWarehousing);
            this.Controls.Add(this.btnFormChumon);
            this.Controls.Add(this.btnFormSyukko);
            this.Controls.Add(this.btnFormStock);
            this.Name = "F_Buturyu";
            this.Text = "F_Buturyu";
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
    }
}
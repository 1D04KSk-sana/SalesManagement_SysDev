namespace SalesManagement_SysDev
{
    partial class F_Eigyo
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnFormStockView = new System.Windows.Forms.Button();
            this.btnFormOrder = new System.Windows.Forms.Button();
            this.btnFormSyukko = new System.Windows.Forms.Button();
            this.btnFormArrival = new System.Windows.Forms.Button();
            this.pnlEigyo = new System.Windows.Forms.Panel();
            this.pnlEigyo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 8);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(183, 75);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "ログアウト";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnclose.Location = new System.Drawing.Point(868, 8);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(183, 75);
            this.btnclose.TabIndex = 1;
            this.btnclose.TabStop = false;
            this.btnclose.Text = "閉じる";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnFormStockView
            // 
            this.btnFormStockView.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFormStockView.Location = new System.Drawing.Point(247, 113);
            this.btnFormStockView.Name = "btnFormStockView";
            this.btnFormStockView.Size = new System.Drawing.Size(510, 100);
            this.btnFormStockView.TabIndex = 2;
            this.btnFormStockView.TabStop = false;
            this.btnFormStockView.Text = "在庫確認画面";
            this.btnFormStockView.UseVisualStyleBackColor = true;
            this.btnFormStockView.Click += new System.EventHandler(this.btnFormStockView_Click);
            // 
            // btnFormOrder
            // 
            this.btnFormOrder.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFormOrder.Location = new System.Drawing.Point(247, 219);
            this.btnFormOrder.Name = "btnFormOrder";
            this.btnFormOrder.Size = new System.Drawing.Size(510, 100);
            this.btnFormOrder.TabIndex = 3;
            this.btnFormOrder.TabStop = false;
            this.btnFormOrder.Text = "受注管理画面";
            this.btnFormOrder.UseVisualStyleBackColor = true;
            this.btnFormOrder.Click += new System.EventHandler(this.btnFormOrder_Click);
            // 
            // btnFormSyukko
            // 
            this.btnFormSyukko.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFormSyukko.Location = new System.Drawing.Point(247, 325);
            this.btnFormSyukko.Name = "btnFormSyukko";
            this.btnFormSyukko.Size = new System.Drawing.Size(510, 100);
            this.btnFormSyukko.TabIndex = 4;
            this.btnFormSyukko.TabStop = false;
            this.btnFormSyukko.Text = "出荷管理画面";
            this.btnFormSyukko.UseVisualStyleBackColor = true;
            this.btnFormSyukko.Click += new System.EventHandler(this.btnFormSyukko_Click);
            // 
            // btnFormArrival
            // 
            this.btnFormArrival.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFormArrival.Location = new System.Drawing.Point(247, 431);
            this.btnFormArrival.Name = "btnFormArrival";
            this.btnFormArrival.Size = new System.Drawing.Size(510, 100);
            this.btnFormArrival.TabIndex = 5;
            this.btnFormArrival.TabStop = false;
            this.btnFormArrival.Text = "入荷管理画面";
            this.btnFormArrival.UseVisualStyleBackColor = true;
            this.btnFormArrival.Click += new System.EventHandler(this.btnFormArrival_Click);
            // 
            // pnlEigyo
            // 
            this.pnlEigyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(128)))));
            this.pnlEigyo.Controls.Add(this.btnLogOut);
            this.pnlEigyo.Controls.Add(this.btnclose);
            this.pnlEigyo.Location = new System.Drawing.Point(0, 0);
            this.pnlEigyo.Name = "pnlEigyo";
            this.pnlEigyo.Size = new System.Drawing.Size(1085, 90);
            this.pnlEigyo.TabIndex = 6;
            // 
            // F_Eigyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1063, 554);
            this.Controls.Add(this.pnlEigyo);
            this.Controls.Add(this.btnFormArrival);
            this.Controls.Add(this.btnFormSyukko);
            this.Controls.Add(this.btnFormOrder);
            this.Controls.Add(this.btnFormStockView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "F_Eigyo";
            this.Text = "営業画面";
            this.pnlEigyo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnFormStockView;
        private System.Windows.Forms.Button btnFormOrder;
        private System.Windows.Forms.Button btnFormSyukko;
        private System.Windows.Forms.Button btnFormArrival;
        private System.Windows.Forms.Panel pnlEigyo;
    }
}
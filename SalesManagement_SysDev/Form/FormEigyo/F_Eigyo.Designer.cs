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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnlEigyo = new System.Windows.Forms.Panel();
            this.pnlEigyo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogOut.Location = new System.Drawing.Point(30, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(110, 50);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "ログアウト";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnclose.Location = new System.Drawing.Point(921, 20);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(110, 50);
            this.btnclose.TabIndex = 1;
            this.btnclose.TabStop = false;
            this.btnclose.Text = "閉じる";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(427, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(427, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "F_Eigyo";
            this.Text = "営業画面";
            this.pnlEigyo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel pnlEigyo;
    }
}
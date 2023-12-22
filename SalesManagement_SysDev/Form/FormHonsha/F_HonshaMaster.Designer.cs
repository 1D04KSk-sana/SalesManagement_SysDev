namespace SalesManagement_SysDev
{
    partial class F_HonshaMaster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHonshaMaster = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFormSalesOffice = new System.Windows.Forms.Button();
            this.btnFormMaker = new System.Windows.Forms.Button();
            this.btnFormPoition = new System.Windows.Forms.Button();
            this.btnFormClassification = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.lblHonshaMaster);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 9;
            // 
            // lblHonshaMaster
            // 
            this.lblHonshaMaster.AutoSize = true;
            this.lblHonshaMaster.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHonshaMaster.Location = new System.Drawing.Point(813, 41);
            this.lblHonshaMaster.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHonshaMaster.Name = "lblHonshaMaster";
            this.lblHonshaMaster.Size = new System.Drawing.Size(354, 64);
            this.lblHonshaMaster.TabIndex = 3;
            this.lblHonshaMaster.Text = "マスター管理";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogOut.Location = new System.Drawing.Point(25, 35);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(160, 70);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "戻る";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1719, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 70);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFormSalesOffice
            // 
            this.btnFormSalesOffice.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormSalesOffice.Location = new System.Drawing.Point(745, 238);
            this.btnFormSalesOffice.Name = "btnFormSalesOffice";
            this.btnFormSalesOffice.Size = new System.Drawing.Size(510, 100);
            this.btnFormSalesOffice.TabIndex = 10;
            this.btnFormSalesOffice.TabStop = false;
            this.btnFormSalesOffice.Text = "営業所管理画面";
            this.btnFormSalesOffice.UseVisualStyleBackColor = true;
            this.btnFormSalesOffice.Click += new System.EventHandler(this.btnFormSalesOffice_Click);
            // 
            // btnFormMaker
            // 
            this.btnFormMaker.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormMaker.Location = new System.Drawing.Point(745, 442);
            this.btnFormMaker.Name = "btnFormMaker";
            this.btnFormMaker.Size = new System.Drawing.Size(510, 100);
            this.btnFormMaker.TabIndex = 11;
            this.btnFormMaker.TabStop = false;
            this.btnFormMaker.Text = "メーカー管理画面";
            this.btnFormMaker.UseVisualStyleBackColor = true;
            this.btnFormMaker.Click += new System.EventHandler(this.btnFormMaker_Click);
            // 
            // btnFormPoition
            // 
            this.btnFormPoition.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormPoition.Location = new System.Drawing.Point(745, 644);
            this.btnFormPoition.Name = "btnFormPoition";
            this.btnFormPoition.Size = new System.Drawing.Size(510, 100);
            this.btnFormPoition.TabIndex = 12;
            this.btnFormPoition.TabStop = false;
            this.btnFormPoition.Text = "役職管理画面";
            this.btnFormPoition.UseVisualStyleBackColor = true;
            this.btnFormPoition.Click += new System.EventHandler(this.btnFormPoition_Click);
            // 
            // btnFormClassification
            // 
            this.btnFormClassification.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormClassification.Location = new System.Drawing.Point(745, 861);
            this.btnFormClassification.Name = "btnFormClassification";
            this.btnFormClassification.Size = new System.Drawing.Size(510, 100);
            this.btnFormClassification.TabIndex = 13;
            this.btnFormClassification.TabStop = false;
            this.btnFormClassification.Text = "分類管理画面";
            this.btnFormClassification.UseVisualStyleBackColor = true;
            this.btnFormClassification.Click += new System.EventHandler(this.btnFormClassification_Click);
            // 
            // F_HonshaMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnFormClassification);
            this.Controls.Add(this.btnFormPoition);
            this.Controls.Add(this.btnFormMaker);
            this.Controls.Add(this.btnFormSalesOffice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_HonshaMaster";
            this.Text = "F_HonshaMaster";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHonshaMaster;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFormSalesOffice;
        private System.Windows.Forms.Button btnFormMaker;
        private System.Windows.Forms.Button btnFormPoition;
        private System.Windows.Forms.Button btnFormClassification;
    }
}
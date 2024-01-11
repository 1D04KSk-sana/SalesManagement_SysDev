namespace SalesManagement_SysDev
{
    partial class F_Honsha
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
            this.btnFormClient = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFormEmployee = new System.Windows.Forms.Button();
            this.btnFormSale = new System.Windows.Forms.Button();
            this.btnFormProdact = new System.Windows.Forms.Button();
            this.btnFormOperationLog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPsition = new System.Windows.Forms.Button();
            this.btnFormSalesOffice = new System.Windows.Forms.Button();
            this.btnFormMaker = new System.Windows.Forms.Button();
            this.btnFormClassification = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormClient
            // 
            this.btnFormClient.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormClient.Location = new System.Drawing.Point(707, 210);
            this.btnFormClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormClient.Name = "btnFormClient";
            this.btnFormClient.Size = new System.Drawing.Size(510, 100);
            this.btnFormClient.TabIndex = 0;
            this.btnFormClient.TabStop = false;
            this.btnFormClient.Text = "顧客管理画面";
            this.btnFormClient.UseVisualStyleBackColor = true;
            this.btnFormClient.Click += new System.EventHandler(this.btnFormClient_Click);
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
            this.btnLogOut.Text = "ログアウト";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnReturn_Click);
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
            // btnFormEmployee
            // 
            this.btnFormEmployee.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormEmployee.Location = new System.Drawing.Point(707, 567);
            this.btnFormEmployee.Name = "btnFormEmployee";
            this.btnFormEmployee.Size = new System.Drawing.Size(510, 100);
            this.btnFormEmployee.TabIndex = 3;
            this.btnFormEmployee.TabStop = false;
            this.btnFormEmployee.Text = "社員管理画面";
            this.btnFormEmployee.UseVisualStyleBackColor = true;
            this.btnFormEmployee.Click += new System.EventHandler(this.btnFormEmployee_Click);
            // 
            // btnFormSale
            // 
            this.btnFormSale.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormSale.Location = new System.Drawing.Point(707, 390);
            this.btnFormSale.Name = "btnFormSale";
            this.btnFormSale.Size = new System.Drawing.Size(510, 100);
            this.btnFormSale.TabIndex = 4;
            this.btnFormSale.TabStop = false;
            this.btnFormSale.Text = "売上管理画面";
            this.btnFormSale.UseVisualStyleBackColor = true;
            this.btnFormSale.Click += new System.EventHandler(this.btnFormSale_Click);
            // 
            // btnFormProdact
            // 
            this.btnFormProdact.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormProdact.Location = new System.Drawing.Point(707, 746);
            this.btnFormProdact.Name = "btnFormProdact";
            this.btnFormProdact.Size = new System.Drawing.Size(510, 100);
            this.btnFormProdact.TabIndex = 5;
            this.btnFormProdact.TabStop = false;
            this.btnFormProdact.Text = "商品管理画面";
            this.btnFormProdact.UseVisualStyleBackColor = true;
            this.btnFormProdact.Click += new System.EventHandler(this.btnFormProdact_Click);
            // 
            // btnFormOperationLog
            // 
            this.btnFormOperationLog.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormOperationLog.Location = new System.Drawing.Point(707, 917);
            this.btnFormOperationLog.Name = "btnFormOperationLog";
            this.btnFormOperationLog.Size = new System.Drawing.Size(510, 100);
            this.btnFormOperationLog.TabIndex = 7;
            this.btnFormOperationLog.TabStop = false;
            this.btnFormOperationLog.Text = "ログ管理画面";
            this.btnFormOperationLog.UseVisualStyleBackColor = true;
            this.btnFormOperationLog.Click += new System.EventHandler(this.btnFormOperationLog_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFormSalesOffice
            // 
            this.btnFormSalesOffice.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormSalesOffice.Location = new System.Drawing.Point(1288, 940);
            this.btnFormSalesOffice.Name = "btnFormSalesOffice";
            this.btnFormSalesOffice.Size = new System.Drawing.Size(510, 100);
            this.btnFormSalesOffice.TabIndex = 9;
            this.btnFormSalesOffice.TabStop = false;
            this.btnFormSalesOffice.Text = "営業所管理画面";
            this.btnFormSalesOffice.UseVisualStyleBackColor = true;
            this.btnFormSalesOffice.Click += new System.EventHandler(this.btnFormSalesOffice_Click);
            // 
            // btnFormMaker
            // 
            this.btnFormMaker.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormMaker.Location = new System.Drawing.Point(1288, 788);
            this.btnFormMaker.Name = "btnFormMaker";
            this.btnFormMaker.Size = new System.Drawing.Size(510, 100);
            this.btnFormMaker.TabIndex = 10;
            this.btnFormMaker.TabStop = false;
            this.btnFormMaker.Text = "メーカー管理画面";
            this.btnFormMaker.UseVisualStyleBackColor = true;
            this.btnFormMaker.Click += new System.EventHandler(this.btnFormMaker_Click);
            // 
            // btnPsition
            // 
            this.btnPsition.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPsition.Location = new System.Drawing.Point(1369, 647);
            this.btnPsition.Name = "btnPsition";
            this.btnPsition.Size = new System.Drawing.Size(510, 100);
            this.btnPsition.TabIndex = 9;
            this.btnPsition.TabStop = false;
            this.btnPsition.Text = "役職管理画面";
            this.btnPsition.UseVisualStyleBackColor = true;
            this.btnPsition.Click += new System.EventHandler(this.btnPsition_Click);
            //
            // btnFormClassification
            // 
            this.btnFormClassification.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFormClassification.Location = new System.Drawing.Point(1288, 646);
            this.btnFormClassification.Name = "btnFormClassification";
            this.btnFormClassification.Size = new System.Drawing.Size(510, 100);
            this.btnFormClassification.TabIndex = 11;
            this.btnFormClassification.TabStop = false;
            this.btnFormClassification.Text = "分類管理画面";
            this.btnFormClassification.UseVisualStyleBackColor = true;
            this.btnFormClassification.Click += new System.EventHandler(this.btnFormClassification_Click);
            // 
            // F_Honsha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnPsition);
            this.Controls.Add(this.btnFormClassification);
            this.Controls.Add(this.btnFormMaker);
            this.Controls.Add(this.btnFormSalesOffice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFormOperationLog);
            this.Controls.Add(this.btnFormProdact);
            this.Controls.Add(this.btnFormSale);
            this.Controls.Add(this.btnFormEmployee);
            this.Controls.Add(this.btnFormClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "F_Honsha";
            this.Text = "本社画面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormClient;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFormEmployee;
        private System.Windows.Forms.Button btnFormSale;
        private System.Windows.Forms.Button btnFormProdact;
        private System.Windows.Forms.Button btnFormOperationLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPsition;
        private System.Windows.Forms.Button btnFormSalesOffice;
        private System.Windows.Forms.Button btnFormMaker;
        private System.Windows.Forms.Button btnFormClassification;
    }
}
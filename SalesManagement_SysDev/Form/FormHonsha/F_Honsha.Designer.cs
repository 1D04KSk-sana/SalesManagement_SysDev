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
            this.lblHonsha = new System.Windows.Forms.Label();
            this.btnFormMaster = new System.Windows.Forms.Button();
            this.btnFormButuryu = new System.Windows.Forms.Button();
            this.btnFormEigyo = new System.Windows.Forms.Button();
            this.btnPassChange = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.lblHonsha);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 8;
            // 
            // lblHonsha
            // 
            this.lblHonsha.AutoSize = true;
            this.lblHonsha.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHonsha.Location = new System.Drawing.Point(813, 41);
            this.lblHonsha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHonsha.Name = "lblHonsha";
            this.lblHonsha.Size = new System.Drawing.Size(287, 64);
            this.lblHonsha.TabIndex = 3;
            this.lblHonsha.Text = "本社管理";
            // 
            // btnFormMaster
            // 
            this.btnFormMaster.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormMaster.Location = new System.Drawing.Point(1336, 917);
            this.btnFormMaster.Name = "btnFormMaster";
            this.btnFormMaster.Size = new System.Drawing.Size(510, 100);
            this.btnFormMaster.TabIndex = 11;
            this.btnFormMaster.TabStop = false;
            this.btnFormMaster.Text = "マスター管理画面";
            this.btnFormMaster.UseVisualStyleBackColor = true;
            this.btnFormMaster.Click += new System.EventHandler(this.btnFormMaster_Click);
            // 
            // btnFormButuryu
            // 
            this.btnFormButuryu.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormButuryu.Location = new System.Drawing.Point(1336, 210);
            this.btnFormButuryu.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormButuryu.Name = "btnFormButuryu";
            this.btnFormButuryu.Size = new System.Drawing.Size(510, 100);
            this.btnFormButuryu.TabIndex = 12;
            this.btnFormButuryu.TabStop = false;
            this.btnFormButuryu.Text = "物流管理画面";
            this.btnFormButuryu.UseVisualStyleBackColor = true;
            this.btnFormButuryu.Click += new System.EventHandler(this.btnButuryu_Click);
            // 
            // btnFormEigyo
            // 
            this.btnFormEigyo.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btnFormEigyo.Location = new System.Drawing.Point(1336, 390);
            this.btnFormEigyo.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormEigyo.Name = "btnFormEigyo";
            this.btnFormEigyo.Size = new System.Drawing.Size(510, 100);
            this.btnFormEigyo.TabIndex = 13;
            this.btnFormEigyo.TabStop = false;
            this.btnFormEigyo.Text = "営業管理画面";
            this.btnFormEigyo.UseVisualStyleBackColor = true;
            this.btnFormEigyo.Click += new System.EventHandler(this.btnFormEigyo_Click);
            // 
            // btnPassChange
            // 
            this.btnPassChange.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPassChange.Location = new System.Drawing.Point(25, 1004);
            this.btnPassChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(227, 50);
            this.btnPassChange.TabIndex = 47;
            this.btnPassChange.TabStop = false;
            this.btnPassChange.Text = "パスワード変更";
            this.btnPassChange.UseVisualStyleBackColor = true;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // F_Honsha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnPassChange);
            this.Controls.Add(this.btnFormEigyo);
            this.Controls.Add(this.btnFormButuryu);
            this.Controls.Add(this.btnFormMaster);
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
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lblHonsha;
        private System.Windows.Forms.Button btnFormMaster;
        private System.Windows.Forms.Button btnFormButuryu;
        private System.Windows.Forms.Button btnFormEigyo;
        private System.Windows.Forms.Button btnPassChange;
    }
}
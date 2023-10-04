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
            this.SuspendLayout();
            // 
            // btnFormClient
            // 
            this.btnFormClient.Location = new System.Drawing.Point(287, 12);
            this.btnFormClient.Name = "btnFormClient";
            this.btnFormClient.Size = new System.Drawing.Size(236, 67);
            this.btnFormClient.TabIndex = 0;
            this.btnFormClient.Text = "顧客管理画面";
            this.btnFormClient.UseVisualStyleBackColor = true;
            // 
            // F_Honsha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormClient);
            this.Name = "F_Honsha";
            this.Text = "F_Honsha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormClient;
    }
}
namespace SalesManagement_SysDev
{
    partial class F_SearchDialog
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
            this.btnAndSearch = new System.Windows.Forms.Button();
            this.btnOrSearch = new System.Windows.Forms.Button();
            this.lblAndSearch = new System.Windows.Forms.Label();
            this.lblOrSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAndSearch
            // 
            this.btnAndSearch.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnAndSearch.Location = new System.Drawing.Point(288, 276);
            this.btnAndSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndSearch.Name = "btnAndSearch";
            this.btnAndSearch.Size = new System.Drawing.Size(265, 117);
            this.btnAndSearch.TabIndex = 0;
            this.btnAndSearch.Text = "AND検索";
            this.btnAndSearch.UseVisualStyleBackColor = true;
            // 
            // btnOrSearch
            // 
            this.btnOrSearch.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.btnOrSearch.Location = new System.Drawing.Point(288, 651);
            this.btnOrSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrSearch.Name = "btnOrSearch";
            this.btnOrSearch.Size = new System.Drawing.Size(265, 117);
            this.btnOrSearch.TabIndex = 1;
            this.btnOrSearch.Text = "OR検索";
            this.btnOrSearch.UseVisualStyleBackColor = true;
            // 
            // lblAndSearch
            // 
            this.lblAndSearch.AutoSize = true;
            this.lblAndSearch.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.lblAndSearch.Location = new System.Drawing.Point(638, 314);
            this.lblAndSearch.Name = "lblAndSearch";
            this.lblAndSearch.Size = new System.Drawing.Size(502, 40);
            this.lblAndSearch.TabIndex = 2;
            this.lblAndSearch.Text = "「全てのキーワードを含む」検索";
            // 
            // lblOrSearch
            // 
            this.lblOrSearch.AutoSize = true;
            this.lblOrSearch.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.lblOrSearch.Location = new System.Drawing.Point(638, 689);
            this.lblOrSearch.Name = "lblOrSearch";
            this.lblOrSearch.Size = new System.Drawing.Size(566, 40);
            this.lblOrSearch.TabIndex = 3;
            this.lblOrSearch.Text = "「いずれかのキーワードを含む」検索";
            // 
            // F_SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.lblOrSearch);
            this.Controls.Add(this.lblAndSearch);
            this.Controls.Add(this.btnOrSearch);
            this.Controls.Add(this.btnAndSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_SearchDialog";
            this.Text = "F_SearchDialog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAndSearch;
        private System.Windows.Forms.Button btnOrSearch;
        private System.Windows.Forms.Label lblAndSearch;
        private System.Windows.Forms.Label lblOrSearch;
    }
}
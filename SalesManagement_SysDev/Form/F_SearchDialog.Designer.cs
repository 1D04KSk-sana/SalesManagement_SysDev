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
            this.SuspendLayout();
            // 
            // btnAndSearch
            // 
            this.btnAndSearch.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAndSearch.Location = new System.Drawing.Point(46, 92);
            this.btnAndSearch.Name = "btnAndSearch";
            this.btnAndSearch.Size = new System.Drawing.Size(154, 68);
            this.btnAndSearch.TabIndex = 0;
            this.btnAndSearch.Text = "AND検索";
            this.btnAndSearch.UseVisualStyleBackColor = true;
            // 
            // btnOrSearch
            // 
            this.btnOrSearch.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOrSearch.Location = new System.Drawing.Point(281, 92);
            this.btnOrSearch.Name = "btnOrSearch";
            this.btnOrSearch.Size = new System.Drawing.Size(154, 68);
            this.btnOrSearch.TabIndex = 1;
            this.btnOrSearch.Text = "OR検索";
            this.btnOrSearch.UseVisualStyleBackColor = true;
            // 
            // F_SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 215);
            this.ControlBox = false;
            this.Controls.Add(this.btnOrSearch);
            this.Controls.Add(this.btnAndSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_SearchDialog";
            this.Text = "F_SearchDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAndSearch;
        private System.Windows.Forms.Button btnOrSearch;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_HonshaMaster : Form
    {
        public F_HonshaMaster()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("本当に閉じますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            Application.Exit();
        }

        private void btnFormClassification_Click(object sender, EventArgs e)
        {
            F_HonshaClassification f_HonshaClassification = new F_HonshaClassification();

            f_HonshaClassification.Owner = this;
            f_HonshaClassification.FormClosed += ChildForm_FormClosed;
            f_HonshaClassification.Show();

            this.Opacity = 0;
        }

        private void btnFormPoition_Click(object sender, EventArgs e)
        {
            F_HonshaPosition f_HonshaPosition = new F_HonshaPosition();

            f_HonshaPosition.Owner = this;
            f_HonshaPosition.FormClosed += ChildForm_FormClosed;
            f_HonshaPosition.Show();

            this.Opacity = 0;
        }

        private void btnFormMaker_Click(object sender, EventArgs e)
        {
            F_HonshaMaker f_HonshaMaker = new F_HonshaMaker();

            f_HonshaMaker.Owner = this;
            f_HonshaMaker.FormClosed += ChildForm_FormClosed;
            f_HonshaMaker.Show();

            this.Opacity = 0;
        }

        private void btnFormSalesOffice_Click(object sender, EventArgs e)
        {
            F_HonshaSalesOffice f_HonshaSalesOffice = new F_HonshaSalesOffice();

            f_HonshaSalesOffice.Owner = this;
            f_HonshaSalesOffice.FormClosed += ChildForm_FormClosed;
            f_HonshaSalesOffice.Show();

            this.Opacity = 0;
        }
    }
}

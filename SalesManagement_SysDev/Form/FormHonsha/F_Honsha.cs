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
    public partial class F_Honsha : Form
    {
        public F_Honsha()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFormClient_Click(object sender, EventArgs e)
        {
            F_HonshaClient f_HonshaClient = new F_HonshaClient();

            f_HonshaClient.Owner = this;
            f_HonshaClient.FormClosed += ChildForm_FormClosed;
            f_HonshaClient.Show();

            this.Opacity = 0;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnFormSale_Click(object sender, EventArgs e)
        {
            F_HonshaSale f_HonshaSale = new F_HonshaSale();

            f_HonshaSale.Owner = this;
            f_HonshaSale.FormClosed += ChildForm_FormClosed;
            f_HonshaSale.Show();

            this.Opacity = 0;
        }

        private void btnFormEmployee_Click(object sender, EventArgs e)
        {
            F_HonshaEmployee F_HonshaEmployee = new F_HonshaEmployee();

            F_HonshaEmployee.Owner = this;
            F_HonshaEmployee.FormClosed += ChildForm_FormClosed;
            F_HonshaEmployee.Show();

            this.Opacity = 0;
        }

        private void btnFormProdact_Click(object sender, EventArgs e)
        {
            F_HonshaProdact F_HonshaProdact = new F_HonshaProdact();

            F_HonshaProdact.Owner = this;
            F_HonshaProdact.FormClosed += ChildForm_FormClosed;
            F_HonshaProdact.Show();

            this.Opacity = 0;
        }

        private void btnFormSinghUp_Click(object sender, EventArgs e)
        {
            F_HonshaSinghUp F_HonshaSinghUp = new F_HonshaSinghUp();

            F_HonshaSinghUp.Owner = this;
            F_HonshaSinghUp.FormClosed += ChildForm_FormClosed;
            F_HonshaSinghUp.Show();

            this.Opacity = 0;
        }

        private void btnFormOperationLog_Click(object sender, EventArgs e)
        {
            F_HonshaOperationLog F_HonshaOperationLog = new F_HonshaOperationLog();

            F_HonshaOperationLog.Owner = this;
            F_HonshaOperationLog.FormClosed += ChildForm_FormClosed;
            F_HonshaOperationLog.Show();

            this.Opacity = 0;
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

        private void btnFormMaster_Click(object sender, EventArgs e)
        {
            F_HonshaMaster F_HonshaMaster = new F_HonshaMaster();

            F_HonshaMaster.Owner = this;
            F_HonshaMaster.FormClosed += ChildForm_FormClosed;
            F_HonshaMaster.Show();

            this.Opacity = 0;
        }

        private void btnButuryu_Click(object sender, EventArgs e)
        {
            F_Buturyu f_Buturyu = new F_Buturyu();

            f_Buturyu.Owner = this;
            f_Buturyu.FormClosed += ChildForm_FormClosed;
            f_Buturyu.Show();

            this.Opacity = 0;
        }

        private void btnFormEigyo_Click(object sender, EventArgs e)
        {
            F_Eigyo f_Eigyo = new F_Eigyo();

            f_Eigyo.Owner = this;
            f_Eigyo.FormClosed += ChildForm_FormClosed;
            f_Eigyo.Show();

            this.Opacity = 0;
        }
    }
}

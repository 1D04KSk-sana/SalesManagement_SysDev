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
        private void btnFormSalesOffice_Click(object sender, EventArgs e)
        {
            F_HonshaSalesOffice F_HonshaSalesOffice = new F_HonshaSalesOffice();

            F_HonshaSalesOffice.Owner = this;
            F_HonshaSalesOffice.FormClosed += ChildForm_FormClosed;
            F_HonshaSalesOffice.Show();

            this.Opacity = 0;
        }

        private void btnFormMaker_Click(object sender, EventArgs e)
        {
            F_HonshaMaker F_HonshaMaker = new F_HonshaMaker();

            F_HonshaMaker.Owner = this;
            F_HonshaMaker.FormClosed += ChildForm_FormClosed;
            F_HonshaMaker.Show();

            this.Opacity = 0;
        }
        private void btnFormClassification_Click(object sender, EventArgs e)
        {
            F_HonshaClassification F_HonshaClassification = new F_HonshaClassification();

            F_HonshaClassification.Owner = this;
            F_HonshaClassification.FormClosed += ChildForm_FormClosed;
            F_HonshaClassification.Show();

            this.Opacity = 0;
        }
    private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

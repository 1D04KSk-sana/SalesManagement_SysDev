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
    }
}

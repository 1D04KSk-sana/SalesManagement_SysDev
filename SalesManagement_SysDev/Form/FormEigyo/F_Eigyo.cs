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
    public partial class F_Eigyo : Form
    {
        public F_Eigyo()
        {
            InitializeComponent();
        }

        private void btnFormStockView_Click(object sender, EventArgs e)
        {
            F_EigyoStockView f_EigyoStockView = new F_EigyoStockView();

            f_EigyoStockView.Owner = this;
            f_EigyoStockView.FormClosed += ChildForm_FormClosed;
            f_EigyoStockView.Show();

            this.Opacity = 0;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnFormOrder_Click(object sender, EventArgs e)
        {
            F_EigyoOrder f_EigyoOrder = new F_EigyoOrder();

            f_EigyoOrder.Owner = this;
            f_EigyoOrder.FormClosed += ChildForm_FormClosed;
            f_EigyoOrder.Show();

            this.Opacity = 0;
        }

        private void btnFormSyukko_Click(object sender, EventArgs e)
        {
            F_EigyoShipment f_EigyoSyukko = new F_EigyoShipment();

            f_EigyoSyukko.Owner = this;
            f_EigyoSyukko.FormClosed += ChildForm_FormClosed;
            f_EigyoSyukko.Show();

            this.Opacity = 0;
        }

        private void btnFormArrival_Click(object sender, EventArgs e)
        {
            F_EigyoArrival f_EigyoArrival = new F_EigyoArrival();

            f_EigyoArrival.Owner = this;
            f_EigyoArrival.FormClosed += ChildForm_FormClosed;
            f_EigyoArrival.Show();

            this.Opacity = 0;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

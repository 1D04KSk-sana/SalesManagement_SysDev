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
    public partial class F_Buturyu : Form
    {
        public F_Buturyu()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnFormStock_Click(object sender, EventArgs e)
        {
            F_ButuryuStock f_ButuryuStock = new F_ButuryuStock();

            f_ButuryuStock.Owner = this;
            f_ButuryuStock.FormClosed += ChildForm_FormClosed;
            f_ButuryuStock.Show();

            this.Opacity = 0;

        }

        private void btnFormWarehousing_Click(object sender, EventArgs e)
        {
            F_ButuryuWarehousing f_ButuryuWarehousing = new F_ButuryuWarehousing();

            f_ButuryuWarehousing.Owner = this;
            f_ButuryuWarehousing.FormClosed += ChildForm_FormClosed;
            f_ButuryuWarehousing.Show();

            this.Opacity = 0;

        }

        private void btnFormHattyu_Click(object sender, EventArgs e)
        {
            F_ButuryuHattyu f_ButuryuHattyu = new F_ButuryuHattyu();

            f_ButuryuHattyu.Owner = this;
            f_ButuryuHattyu.FormClosed += ChildForm_FormClosed;
            f_ButuryuHattyu.Show();

            this.Opacity = 0;

        }

        private void btnFormChumon_Click(object sender, EventArgs e)
        {
            F_ButuryuChumon f_ButuryuChumon = new F_ButuryuChumon();

            f_ButuryuChumon.Owner = this;
            f_ButuryuChumon.FormClosed += ChildForm_FormClosed;
            f_ButuryuChumon.Show();

            this.Opacity = 0;

        }

        private void btnFormSyukko_Click(object sender, EventArgs e)
        {
            F_ButuryuSyukko f_ButuryuSyukko = new F_ButuryuSyukko();

            f_ButuryuSyukko.Owner = this;
            f_ButuryuSyukko.FormClosed += ChildForm_FormClosed;
            f_ButuryuSyukko.Show();

            this.Opacity = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Buturyu_Load(object sender, EventArgs e)
        {
            if (F_Login.intPositionID == 1)
            {
                btnLogOut.Text = "閉じる";
            }
            else
            {
                btnLogOut.Text = "ログアウト";
            }
        }
    }
}

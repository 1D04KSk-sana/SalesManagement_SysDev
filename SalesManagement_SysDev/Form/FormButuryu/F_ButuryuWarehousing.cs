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
    public partial class F_ButuryuWarehousing : Form
    {
        public F_ButuryuWarehousing()
        {
            InitializeComponent();
        }

        private void txbstockID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<T_Warehousing> viewWarehousing = SetListWarehousing();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewWarehousing.Count / (double)pageSize);

            if (lastPage == 0)
            {
                lastPage++;
            }

            txbNumPage.Text = lastPage.ToString();

            dgvWarehousing();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = (int.Parse(txbNumPage.Text.Trim()) + 1).ToString();

            GetDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = (int.Parse(txbNumPage.Text.Trim()) - 1).ToString();

            GetDataGridView();
        }

        private void btnPageMin_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            GetDataGridView();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SaleDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetSaleDetailData()
        //引　数：なし
        //戻り値：売上詳細データ
        //機　能：売上詳細データの全取得
        ///////////////////////////////
        public List<T_SaleDetail> GetSaleDetailData()
        {
            List<T_SaleDetail> listSaleDetail = new List<T_SaleDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSaleDetail = context.T_SaleDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSaleDetail;
        }

        ///////////////////////////////
        //メソッド名：GetSaleDetailIDData()
        //引　数：なし
        //戻り値：受注詳細データ
        //機　能：受注詳細データの全取得
        ///////////////////////////////
        public List<T_SaleDetail> GetSaleDetailIDData(int saleID)
        {
            List<T_SaleDetail> listSaleDetail = new List<T_SaleDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSaleDetail = context.T_SaleDetails.Where(x => x.SaID == saleID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSaleDetail;
        }
    }

}

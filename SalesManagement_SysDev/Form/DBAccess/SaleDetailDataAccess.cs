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

        ///////////////////////////////
        //メソッド名：AddSaleDetailData()
        //引　数：売上詳細データ
        //戻り値：True or False
        //機　能：売上詳細データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddSaleDetailData(T_SaleDetail regSaleDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_SaleDetails.Add(regSaleDetail);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }

}

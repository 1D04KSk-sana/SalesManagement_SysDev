using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OrderDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetOrderDetailData()
        //引　数：なし
        //戻り値：受注詳細データ
        //機　能：受注詳細データの全取得
        ///////////////////////////////
        public List<T_OrderDetail> GetOrderDetailIDData(int orderID)
        {
            List<T_OrderDetail> listOrderDetail = new List<T_OrderDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listOrderDetail = context.T_OrderDetails.Where(x => x.OrID == orderID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrderDetail;
        }

        ///////////////////////////////
        //メソッド名：AddOrderDetailData()
        //引　数：regOrder = 受注詳細データ
        //戻り値：True or False
        //機　能：受注詳細データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddOrderDetailData(T_OrderDetail regOrder)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_OrderDetails.Add(regOrder);
                context.SaveChanges();
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

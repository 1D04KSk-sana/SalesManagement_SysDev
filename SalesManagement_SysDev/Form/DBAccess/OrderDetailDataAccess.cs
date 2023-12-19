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
        //メソッド名：CheckOrderDetailProdactIDExistence()
        //引　数   ：商品ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckOrderDetailProdactIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                //部署CDで一致するデータが存在するか
                flg = context.T_OrderDetails.Any(x => x.PrID == ProdactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetOrderDetailData()
        //引　数：受注ID
        //戻り値：受注詳細データ
        //機　能：受注IDの一致する受注詳細データの取得
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

                context.Dispose ();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OrderDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckOrderIDExistence()
        //引　数   ：受注コード
        //戻り値   ：True or False
        //機　能   ：一致する受注IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckOrderIDExistence(int orderID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDで一致するデータが存在するか
                flg = context.T_Orders.Any(x => x.OrID == orderID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetOrderData()
        //引　数：なし
        //戻り値：受注データ
        //機　能：受注データの全取得
        ///////////////////////////////
        public List<T_Order> GetOrderData()
        {
            List<T_Order> listOrder = new List<T_Order>();

            try
            {
                var context = new SalesManagement_DevContext();
                listOrder = context.T_Orders.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }

        ///////////////////////////////
        //メソッド名：AddOrderData()
        //引　数：regOrder = 受注データ
        //戻り値：True or False
        //機　能：受注データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddOrderData(T_Order regOrder)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Orders.Add(regOrder);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        ///////////////////////////////
        //メソッド名：UpdateOrderData()
        //引　数：updOrder = 受注データ
        //戻り値：True or False
        //機　能：受注データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateOrderData(T_Order updOrder)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Order = context.T_Orders.Single(x => x.OrID == updOrder.OrID);

                Order.OrFlag = updOrder.OrFlag;
                Order.OrHidden = updOrder.OrHidden;

                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        ///////////////////////////////
        //メソッド名：ConfirmOrderData()
        //引　数：cfmOrder = 受注データ
        //戻り値：True or False
        //機　能：受注データの確定
        //      ：確定成功の場合True
        //      ：確定失敗の場合False
        ///////////////////////////////
        public bool ConfirmOrderData(T_Order cfmOrder)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Order = context.T_Orders.Single(x => x.OrID == cfmOrder.OrID);

                Order.OrStateFlag = cfmOrder.OrStateFlag;

                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        ///////////////////////////////
        //メソッド名：GetIDOrderData()
        //引　数：受注ID
        //戻り値：受注IDの一致する受注データ
        //機　能：受注IDの一致する受注データの取得
        ///////////////////////////////
        public T_Order GetIDOrderData(int OrderID)
        {
            T_Order Order = new T_Order{ };

            try
            {
                var context = new SalesManagement_DevContext();
                Order = context.T_Orders.Single(x => x.OrID == OrderID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Order;
        }

        ///////////////////////////////
        //メソッド名：GetOrderDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の受注データ
        //機　能：管理Flgが表示の受注データの全取得
        ///////////////////////////////
        public List<T_Order> GetOrderDspData(List<T_Order> dspOrder)
        {
            List<T_Order> listOrder = new List<T_Order>();

            try
            {
                listOrder = dspOrder.Where(x => x.OrFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }

        ///////////////////////////////
        //メソッド名：GetOrderNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の受注データ
        //機　能：管理Flgが非表示の受注データの全取得
        ///////////////////////////////
        public List<T_Order> GetOrderNotDspData(List<T_Order> dspOrder)
        {
            List<T_Order> listOrder = new List<T_Order>();

            try
            {
                listOrder = dspOrder.Where(x => x.OrFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }
        
        ///////////////////////////////
        //メソッド名：GetAndOrderData()
        //引　数：検索条件
        //戻り値：条件完全一致受注データ
        //機　能：条件完全一致受注データの取得
        ///////////////////////////////
        public List<T_Order> GetAndOrderData(T_Order selectOrder)
        {
            List<T_Order> listOrder = new List<T_Order>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_Orders.AsQueryable();

                if (selectOrder.OrID != 0)
                {
                    query = query.Where(x => x.OrID == selectOrder.OrID);
                }

                if (selectOrder.SoID != 0)
                {
                    query = query.Where(x => x.SoID == selectOrder.SoID);
                }

                if (selectOrder.EmID != 0)
                {
                    query = query.Where(x => x.EmID == selectOrder.EmID);
                }

                if (selectOrder.ClID != 0)
                {
                    query = query.Where(x => x.ClID == selectOrder.ClID);
                }
                if (selectOrder.OrDate != null)
                {
                    query = query.Where(x => x.OrDate.Value == selectOrder.OrDate.Value);
                }

                listOrder = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }

        ///////////////////////////////
        //メソッド名：GetOrOrderData()
        //引　数：検索条件
        //戻り値：条件一部一致受注データ
        //機　能：条件一部一致受注データの取得
        ///////////////////////////////
        public List<T_Order> GetOrOrderData(T_Order selectOrder)
        {
            List<T_Order> listOrder = new List<T_Order>();
            try
            {
                var context = new SalesManagement_DevContext();
                listOrder = context.T_Orders.Where(x => x.OrID == selectOrder.OrID || x.SoID == selectOrder.SoID || x.EmID == selectOrder.EmID || x.ClID == selectOrder.ClID || x.OrDate.Value == selectOrder.OrDate.Value).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }
    }
}

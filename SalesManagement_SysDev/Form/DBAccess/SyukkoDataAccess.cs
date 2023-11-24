using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetOrderData()
        //引　数：なし
        //戻り値：受注詳細データ
        //機　能：受注詳細データの全取得
        ///////////////////////////////
        public List<T_Syukko> GetOrderData(int orderID)
        {
            List<T_Syukko> listOrderDetail = new List<T_Syukko>();

            try
            {
                var context = new SalesManagement_DevContext();
                listOrderDetail = context.T_Syukkos.Where(x => x.OrID == orderID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrderDetail;
        }

        ///////////////////////////////
        //メソッド名：CheckProdactIDExistence()
        //引　数   ：商品コード
        //戻り値   ：True or False
        //機　能   ：一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSyukkoIDExistence(int SyukkoID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //商品IDで一致するデータが存在するか
                flg = context.T_Syukkos.Any(x => x.SyID == SyukkoID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetIDOrderData()
        //引　数：受注ID
        //戻り値：受注IDの一致する受注データ
        //機　能：受注IDの一致する受注データの取得
        ///////////////////////////////
        public T_Syukko GetSyukkoIDOrderData(int OrderID)
        {
            T_Syukko Order = new T_Syukko { };

            try
            {
                var context = new SalesManagement_DevContext();
                Order = context.T_Syukkos.Single(x => x.OrID == OrderID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Order;
        }

        ///////////////////////////////
        //メソッド名：ConfirmSyukkoData()
        //引　数：cfmOrder = 受注データ
        //戻り値：True or False
        //機　能：受注データの確定
        //      ：確定成功の場合True
        //      ：確定失敗の場合False
        ///////////////////////////////
        public bool ConfirmSyukkoData(T_Syukko cfmOrder)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Syukko = context.T_Syukkos.Single(x => x.SyID == cfmOrder.SyID);

                Syukko.SyStateFlag = cfmOrder.SyStateFlag;

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
        public T_Syukko GetIDSyukkoData(int OrderID)
        {
            T_Syukko Order = new T_Syukko { };

            try
            {
                var context = new SalesManagement_DevContext();
                Order = context.T_Syukkos.Single(x => x.OrID == OrderID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Order;
        }

        ///////////////////////////////
        //メソッド名：GetAndProdactData()
        //引　数：検索条件
        //戻り値：条件完全一致商品データ
        //機　能：条件完全一致商品データの取得
        ///////////////////////////////
        public List<T_Syukko> GetAndSyukkoData(T_Syukko selectSyukko)
        {
            List<T_Syukko> listSyukko = new List<T_Syukko>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_Syukkos.AsQueryable();

                if (selectSyukko.SyID != null && selectSyukko.SyID != 0)
                {
                    query = query.Where(x => x.SyID == selectSyukko.SyID);
                }

                if (selectSyukko.SoID != null && selectSyukko.SoID != 0)
                {
                    query = query.Where(x => x.SoID == selectSyukko.SoID);
                }

                if (selectSyukko.OrID != null && selectSyukko.OrID != 0)
                {
                    query = query.Where(x => x.OrID == selectSyukko.OrID);
                }

                listSyukko = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSyukko;
        }

        ///////////////////////////////
        //メソッド名：GetOrProdactData()
        //引　数：検索条件
        //戻り値：条件一部一致商品データ
        //機　能：条件一部一致商品データの取得
        ///////////////////////////////
        public List<T_Syukko> GetOrSyukkoData(T_Syukko selectProdact)
        {
            List<T_Syukko> listProdact = new List<T_Syukko>();
            try
            {
                var context = new SalesManagement_DevContext();
                listProdact = context.T_Syukkos.Where(x => x.SyID == selectProdact.SyID || x.SoID == selectProdact.SoID || x.OrID == selectProdact.OrID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：GetSyukkoDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の商品データ
        //機　能：管理Flgが表示の商品データの全取得
        ///////////////////////////////
        public List<T_Syukko> GetSyukkoDspData()
        {
            List<T_Syukko> listSyukko = new List<T_Syukko>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSyukko = context.T_Syukkos.Where(x => x.SyFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSyukko;
        }

        ///////////////////////////////
        //メソッド名：GetProdactDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の商品データ
        //機　能：管理Flgが表示の商品データの全取得
        ///////////////////////////////
        public List<T_Syukko> GetSyukkotDspData(List<T_Syukko> dspProdact)
        {
            List<T_Syukko> listProdact = new List<T_Syukko>();

            try
            {
                listProdact = dspProdact.Where(x => x.SyFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：GetSyukkotNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の商品データ
        //機　能：管理Flgが非表示の商品データの全取得
        ///////////////////////////////
        public List<T_Syukko> GetSyukkoNotDspData(List<T_Syukko> dspClient)
        {
            List<T_Syukko> listProdact = new List<T_Syukko>();

            try
            {
                listProdact = dspClient.Where(x => x.SyFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }
    }
}

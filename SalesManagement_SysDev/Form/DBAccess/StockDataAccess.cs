using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class StockDataAccess
    {
        ///////////////////////////////
        //メソッド名：AddStockData()
        //引　数：regClient = 商品データ
        //戻り値：True or False
        //機　能：商品データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddStockData(T_Stock regStock)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Stocks.Add(regStock);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        //メソッド名：CheckstockIDExistence()
        //引　数   ：在庫コード
        //戻り値   ：True or False
        //機　能   ：一致する在庫IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckstockIDExistence(int stockID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDで一致するデータが存在するか
                flg = context.T_Stocks.Any(x => x.StID == stockID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    return flg;
        }

        ///////////////////////////////
        //メソッド名：GetOrderDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の受注データ
        //機　能：管理Flgが表示の受注データの全取得
        ///////////////////////////////
        public List<T_Stock> GetStockDspData(List<T_Stock> dspStock)
        {
            List<T_Stock> listStock = new List<T_Stock>();

            try
            {
                listStock = dspStock.Where(x => x.StFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listStock;
        }
        ///////////////////////////////
        //メソッド名：GetStockNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の受注データ
        //機　能：管理Flgが非表示の受注データの全取得
        ///////////////////////////////
        public List<T_Stock> GetStockNotDspData(List<T_Stock> dspStock)
        {
            List<T_Stock> listStock = new List<T_Stock>();

            try
            {
                listStock = dspStock.Where(x => x.StFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listStock;
        }
        ///////////////////////////////
        //メソッド名：GetOrderData()
        //引　数：なし
        //戻り値：受注データ
        //機　能：受注データの全取得
        ///////////////////////////////
        public List<T_Stock> GetStockData()
        {
            List<T_Stock> listStock = new List<T_Stock>();

            try
            {
                var context = new SalesManagement_DevContext();
                listStock = context.T_Stocks.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listStock;
        }
        ///////////////////////////////
        //メソッド名：CheckOrderIDExistence()
        //引　数   ：受注コード
        //戻り値   ：True or False
        //機　能   ：一致する受注IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckStockIDExistence(int StockID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDで一致するデータが存在するか
                flg = context.T_Stocks.Any(x => x.StID == StockID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        ///////////////////////////////
        //メソッド名：GetAndOrderData()
        //引　数：検索条件
        //戻り値：条件完全一致受注データ
        //機　能：条件完全一致受注データの取得
        ///////////////////////////////
        public List<T_Stock> GetAndStockData(T_Stock selectStock)
        {
            List<T_Stock> listStock = new List<T_Stock>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_Stocks.AsQueryable();

                if (selectStock.StID != null && selectStock.StID != 0)
                {
                    query = query.Where(x => x.StID == selectStock.StID);
                }

                if (selectStock.PrID != null && selectStock.PrID != 0)
                {
                    query = query.Where(x => x.PrID == selectStock.PrID);
                }

                if (selectStock.StID != null && selectStock.StID != 0)
                {
                    query = query.Where(x => x.StID == selectStock.StID);
                }
                if (selectStock.StQuantity != null && selectStock.StQuantity != 0)
                {
                    query = query.Where(x => x.StQuantity == selectStock.StQuantity);
                }

                listStock = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listStock;
        }
        ///////////////////////////////
        //メソッド名：GetOrOrderData()
        //引　数：検索条件
        //戻り値：条件一部一致受注データ
        //機　能：条件一部一致受注データの取得
        ///////////////////////////////
        public List<T_Stock> GetOrStockData(T_Stock selectStock)
        {
            List<T_Stock> listStock = new List<T_Stock>();
            try
            {
                var context = new SalesManagement_DevContext();
                listStock = context.T_Stocks.Where(x => x.StID == selectStock.StID || x.PrID == selectStock.PrID || x.StQuantity == selectStock.StQuantity).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listStock;
        }
    }
}

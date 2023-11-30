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
        //メソッド名：GetStockData()
        //引　数：なし
        //戻り値：在庫データ
        //機　能：在庫データの全取得
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
        //メソッド名：GetStockDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の在庫データ
        //機　能：管理Flgが表示の在庫データの全取得
        ///////////////////////////////
        //public List<T_Stock> GetStockDspData()
        //{
        //    //List<T_Stock> listStock = new List<T_Stock>();

        //    try
        //    {
        //        var context = new SalesManagement_DevContext();
        //        listStock = context.T_Stocks.Where(x => x.StFlag == 0).ToList();
        //        context.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return listStock;
        //}

        ///////////////////////////////
        //メソッド名：GetStockDspData()　　※オーバーロード
        //引　数：なし
        //戻り値：管理Flgが表示の在庫データ
        //機　能：管理Flgが表示の在庫データの全取得
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
        //戻り値：管理Flgが非表示の在庫データ
        //機　能：管理Flgが非表示の在庫データの全取得
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
        //メソッド名：GetAndClientData()
        //引　数：検索条件
        //戻り値：条件完全一致在庫データ
        //機　能：条件完全一致在庫データの取得
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
        //メソッド名：GetOrClientData()
        //引　数：検索条件
        //戻り値：条件一部一致顧客データ
        //機　能：条件一部一致顧客データの取得
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
        ///////////////////////////////
        //メソッド名：UpdateStockData()
        //引　数：updStock = 在庫データ
        //戻り値：True or False
        //機　能：在庫データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateStockData(T_Stock updStock)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Stock = context.T_Stocks.Single(x => x.StID == updStock.StID);



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

    }
}

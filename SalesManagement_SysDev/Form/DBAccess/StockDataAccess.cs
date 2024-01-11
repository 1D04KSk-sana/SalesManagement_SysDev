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

        ///////////////////////////////
        //メソッド名：UpdateStockData()
        //引　数：regStock = 在庫データ
        //戻り値：True or False
        //機　能：在庫データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateStockData(T_Stock regStock)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Stock = context.T_Stocks.Single(x => x.PrID == regStock.PrID);

                Stock.StQuantity = regStock.StQuantity;

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
        //メソッド名：CheckStockIDExistence()
        //引　数   ：在庫コード
        //戻り値   ：True or False
        //機　能   ：一致する在庫IDの有無を確認
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
        //メソッド名：CheckStockProdactIDExistence()
        //引　数   ：商品ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckStockProdactIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                //部署CDで一致するデータが存在するか
                flg = context.T_Stocks.Any(x => x.PrID == ProdactID);
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

                if (selectStock.StID != 0)
                {
                    query = query.Where(x => x.StID == selectStock.StID);
                }

                if (selectStock.PrID != 0)
                {
                    query = query.Where(x => x.PrID == selectStock.PrID);
                }

                if (selectStock.StQuantity != 0)
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
                listStock = context.T_Stocks.Where(x => x.PrID == selectStock.PrID || x.StQuantity >= selectStock.StQuantity).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listStock;
        }

        ///////////////////////////////
        //メソッド名：UpdateStockQuantityData()
        //引　数：updWarehousingDEtail = 入庫詳細データ
        //戻り値：True or False
        //機　能：在庫データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateStockQuantityData(T_WarehousingDetail updWarehousingDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Stock = context.T_Stocks.Single(x => x.PrID == updWarehousingDetail.PrID);

                Stock.StQuantity = Stock.StQuantity + updWarehousingDetail.WaQuantity;

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
        //メソッド名：UpdateChumonStockQuantityData()
        //引　数：注文詳細データ
        //戻り値：True or False
        //機　能：在庫データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateChumonStockQuantityData(T_ChumonDetail updChumonDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Stock = context.T_Stocks.Single(x => x.PrID == updChumonDetail.PrID);

                Stock.StQuantity = Stock.StQuantity - updChumonDetail.ChQuantity;

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
        //メソッド名：GetStockProdactIDData()
        //引　数：商品ID
        //戻り値：在庫データ
        //機　能：商品IDにつながった在庫データの取得
        ///////////////////////////////
        public T_Stock GetStockProdactIDData(int prodactID)
        {
            T_Stock Stock = new T_Stock();

            try
            {
                var context = new SalesManagement_DevContext();
                Stock = context.T_Stocks.Single(x => x.PrID == prodactID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Stock;
        }
    }
}

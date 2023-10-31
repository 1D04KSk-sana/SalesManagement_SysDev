using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SaleDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckSaleIDExistence()
        //引　数   ：売上コード
        //戻り値   ：True or False
        //機　能   ：一致する売上IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSaleIDExistence(int saleID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //部署CDで一致するデータが存在するか
                flg = context.T_Sales.Any(x => x.SaID == saleID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetSaleData()
        //引　数：なし
        //戻り値：売上データ
        //機　能：売上データの全取得
        ///////////////////////////////
        public List<T_Sale> GetSaleData()
        {
            List<T_Sale> listSale = new List<T_Sale>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSale = context.T_Sales.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSale;
        }

        ///////////////////////////////
        //メソッド名：GetSaleDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の売上データ
        //機　能：管理Flgが表示の売上データの全取得
        ///////////////////////////////
        public List<T_Sale> GetSaleDspData(List<T_Sale> dspSale)
        {
            List<T_Sale> listSale = new List<T_Sale>();

            try
            {
                listSale = dspSale.Where(x => x.SaFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSale;
        }

        ///////////////////////////////
        //メソッド名：GetSaleNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の売上データ
        //機　能：管理Flgが非表示の売上データの全取得
        ///////////////////////////////
        public List<T_Sale> GetSaleNotDspData(List<T_Sale> dspSale)
        {
            List<T_Sale> listSale = new List<T_Sale>();

            try
            {
                listSale = dspSale.Where(x => x.SaFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSale;
        }

        ///////////////////////////////
        //メソッド名：GetAndSaleData()
        //引　数：検索条件
        //戻り値：条件完全一致売上データ
        //機　能：条件完全一致売上データの取得
        ///////////////////////////////
        public List<T_Sale> GetAndSaleData(T_Sale selectSale)
        {
            List<T_Sale> listSale = new List<T_Sale>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_Sales.AsQueryable();

                if (selectSale.SaID != null && selectSale.SaID != 0)
                {
                    query = query.Where(x => x.SaID == selectSale.SaID);
                }

                if (selectSale.SoID != null && selectSale.SoID != 0)
                {
                    query = query.Where(x => x.SoID == selectSale.SoID);
                }

                if (selectSale.ChID != null && selectSale.ChID != 0)
                {
                    query = query.Where(x => x.ChID == selectSale.ChID);
                }

                listSale = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSale;
        }

        ///////////////////////////////
        //メソッド名：GetOrSaleData()
        //引　数：検索条件
        //戻り値：条件一部一致売上データ
        //機　能：条件一部一致うデータの取得
        ///////////////////////////////
        public List<T_Sale> GetOrSaleData(T_Sale selectSale)
        {
            List<T_Sale> listSale = new List<T_Sale>();
            try
            {
                var context = new SalesManagement_DevContext();
                listSale = context.T_Sales.Where(x => x.SaID == selectSale.SaID || x.SoID == selectSale.SoID || x.ChID == selectSale.ChID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSale;
        }
    }
}

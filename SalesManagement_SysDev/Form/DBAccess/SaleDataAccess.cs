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
        //メソッド名：CheckSaleSalesOfficeIDExistence()
        //引　数   ：営業所ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する営業所IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSaleSalesOfficeIDExistence(int SalesOfficeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Sale> listSale = context.T_Sales.Where(x => x.SaFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listSale.Any(x => x.SoID == SalesOfficeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckSaleEmployeeIDExistence()
        //引　数   ：社員ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する社員IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSaleEmployeeIDExistence(int EmployeeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Sale> listSale = context.T_Sales.Where(x => x.SaFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listSale.Any(x => x.EmID == EmployeeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckSaleClientIDExistence()
        //引　数   ：顧客ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する顧客IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSaleClientIDExistence(int ClientID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Sale> listSale = context.T_Sales.Where(x => x.SaFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listSale.Any(x => x.ClID == ClientID);
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
        //メソッド名：GetIDChumonData()
        //引　数：注文ID
        //戻り値：注文IDの一致する売上データ
        //機　能：注文IDの一致する売上データの取得
        ///////////////////////////////
        public T_Sale GetIDChumonData(int ChumonID)
        {
            T_Sale Sale = new T_Sale { };

            try
            {
                var context = new SalesManagement_DevContext();
                Sale = context.T_Sales.Single(x => x.ChID == ChumonID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Sale;
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

                if ( selectSale.SaID != 0)
                {
                    query = query.Where(x => x.SaID == selectSale.SaID);
                }

                if ( selectSale.SoID != 0)
                {
                    query = query.Where(x => x.SoID == selectSale.SoID);
                }

                if ( selectSale.ChID != 0)
                {
                    query = query.Where(x => x.ChID == selectSale.ChID);
                }
                if (selectSale.ClID != 0)
                {
                    query = query.Where(x => x.ClID == selectSale.ClID);
                }

                if (selectSale.SaDate != null)
                {
                    query = query.Where(x => x.SaDate.Value.Month == selectSale.SaDate.Value.Month);
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
                listSale = context.T_Sales.Where(x => x.SaID == selectSale.SaID || x.SoID == selectSale.SoID || x.ChID == selectSale.ChID || x.ClID == selectSale.ClID || x.SaDate.Value.Month == selectSale.SaDate.Value.Month).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSale;
        }
        ///////////////////////////////
        //メソッド名：UpdateSaleData()
        //引　数：updSale = 売上データ
        //戻り値：True or False
        //機　能：売上データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateSaleData(T_Sale updSale)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Sale = context.T_Sales.Single(x => x.SaID == updSale.SaID);

                Sale.SaFlag = updSale.SaFlag;
                Sale.SaHidden = updSale.SaHidden;
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
        //メソッド名：AddSaleData()
        //引　数：売上データ
        //戻り値：True or False
        //機　能：売上データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddSaleData(T_Sale regSale)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Sales.Add(regSale);
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

        ///////////////////////////////
        //メソッド名：SaleNum()
        //引　数：なし
        //戻り値：受注件数
        //機　能：受注データの件数
        ///////////////////////////////
        public int SaleNum()
        {
            var context = new SalesManagement_DevContext();

            //登録されている操作ログの件数取得
            int SaleCount = context.T_Sales.Count();

            return SaleCount;
        }
    }
}

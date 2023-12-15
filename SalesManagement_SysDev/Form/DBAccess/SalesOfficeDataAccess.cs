using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SalesOfficeDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetSalesOfficeDspData()
        //引　数   ：なし
        //戻り値   ：表示用営業所データ
        //機　能   ：表示用営業所データの取得
        ///////////////////////////////
        public List<M_SalesOffice> GetSalesOfficeDspData()
        {
            List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                listSalesOffice = context.M_SalesOffices.Where(x => x.SoFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSalesOffice;
        }
        ///////////////////////////////
        //メソッド名：CheckClientIDExistence()
        //引　数   ：営業所コード
        //戻り値   ：True or False
        //機　能   ：一致する営業所IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSalesOfficeIDExistence(int SalesOfficeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //営業所IDで一致するデータが存在するか
                flg = context.M_SalesOffices.Any(x => x.SoID == SalesOfficeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        ///////////////////////////////
        //メソッド名：AddSaleOfficeData()
        //引　数：regSalesOffice = 営業所データ
        //戻り値：True or False
        //機　能：営業所データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddSalesOfficeData(M_SalesOffice regSalesOffice)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_SalesOffices.Add(regSalesOffice);
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
        //メソッド名：GetSalesOfficeData()
        //引　数：なし
        //戻り値：顧客データ
        //機　能：顧客データの全取得
        ///////////////////////////////
        public List<M_SalesOffice> GetSalesOfficeData()
        {
            List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSalesOffice = context.M_SalesOffices.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSalesOffice;
        }
        ///////////////////////////////
        //メソッド名：GetClientDspData()　　※オーバーロード
        //引　数：なし
        //戻り値：管理Flgが表示の営業所データ
        //機　能：管理Flgが表示の営業所データの全取得
        ///////////////////////////////
        public List<M_SalesOffice> GetSalesOfficeDspData(List<M_SalesOffice> dspSalesOffice)
        {
            List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();

            try
            {
                listSalesOffice = dspSalesOffice.Where(x => x.SoFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSalesOffice;
        }
        ///////////////////////////////
        //メソッド名：GetSalesOfficeNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の営業所データ
        //機　能：管理Flgが非表示の営業所データの全取得
        ///////////////////////////////
        public List<M_SalesOffice> GetSalesOfficeNotDspData(List<M_SalesOffice> dspSalesOffice)
        {
            List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();

            try
            {
                listSalesOffice = dspSalesOffice.Where(x => x.SoFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSalesOffice;
        }
        ///////////////////////////////
        //メソッド名：GetAndSalesOfficeData()
        //引　数：検索条件
        //戻り値：条件完全一致営業所データ
        //機　能：条件完全一致営業所データの取得
        ///////////////////////////////
        public List<M_SalesOffice> GetAndSalesOfficeData(M_SalesOffice selectClient)
        {
            List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.M_SalesOffices.AsQueryable();

                if (selectClient.SoID != null && selectClient.SoID != 0)
                {
                    query = query.Where(x => x.SoID == selectClient.SoID);
                }

                if (selectClient.SoPhone != null && selectClient.SoPhone != "")
                {
                    query = query.Where(x => x.SoPhone == selectClient.SoPhone);
                }

                listSalesOffice = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSalesOffice;
        }
        ///////////////////////////////
        //メソッド名：GetOrSalesOfficeData()
        //引　数：検索条件
        //戻り値：条件一部一営業所データ
        //機　能：条件一部一致営業所データの取得
        ///////////////////////////////
        public List<M_SalesOffice> GetOrSalesOfficetData(M_SalesOffice selectSalesOffice)
        {
            List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                listSalesOffice = context.M_SalesOffices.Where(x =>  x.SoID == selectSalesOffice.SoID || x.SoPhone == selectSalesOffice.SoPhone).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSalesOffice;
        }
        ///////////////////////////////
        //メソッド名：UpdateSalesOfficeData()
        //引　数：updClient = 営業所データ
        //戻り値：True or False
        //機　能：営業所データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateSalesOfficeData(M_SalesOffice updSalesOffice)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var SalesOffice = context.M_SalesOffices.Single(x => x.SoID == updSalesOffice.SoID);

                SalesOffice.SoName = updSalesOffice.SoName;
                SalesOffice.SoFlag = updSalesOffice.SoFlag;
                SalesOffice.SoHidden = updSalesOffice.SoHidden;
                SalesOffice.SoFAX = updSalesOffice.SoFAX;
                SalesOffice.SoPhone = updSalesOffice.SoPhone;
                SalesOffice.SoAddress = updSalesOffice.SoAddress;
                SalesOffice.SoID = updSalesOffice.SoID;
                SalesOffice.SoPostal = updSalesOffice.SoPostal;

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
        //メソッド名：CheckClientNameExistence()
        //引　数   ：営業所コード
        //戻り値   ：True or False
        //機　能   ：一致する営業所名の有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSalesOfficeNameExistence(string SalesOfficeName)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //営業所IDで一致するデータが存在するか
                flg = context.M_SalesOffices.Any(x => x.SoName == SalesOfficeName);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
    }
}

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
        public bool CheckClientIDExistence(int SalesOfficeID)
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
        //メソッド名：GetClientNotDspData()
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
    }
}

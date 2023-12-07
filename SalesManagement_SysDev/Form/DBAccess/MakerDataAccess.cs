using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class MakerDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetMakerDspData()　　※オーバーロード
        //引　数：なし
        //戻り値：管理Flgが表示のメーカーデータ
        //機　能：管理Flgが表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_Maker> GetMakerDspData(List<M_Maker> dspMaker)
        {
            List<M_Maker> listMaker = new List<M_Maker>();

            try
            {
                listMaker = dspMaker.Where(x => x.MaFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
        ///////////////////////////////
        //メソッド名：GetMakerNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示のメーカーデータ
        //機　能：管理Flgが非表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_Maker> GetMakerNotDspData(List<M_Maker> dspMaker)
        {
            List<M_Maker> listMaker = new List<M_Maker>();

            try
            {
                listMaker = dspMaker.Where(x => x.MaFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
        ///////////////////////////////
        //メソッド名：GetMakerData()
        //引　数：なし
        //戻り値：メーカーデータ
        //機　能：メーカーデータの全取得
        ///////////////////////////////
        public List<M_Maker> GetMakerData()
        {
            List<M_Maker> listMaker = new List<M_Maker>();

            try
            {
                var context = new SalesManagement_DevContext();
                listMaker = context.M_Makers.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
        ///////////////////////////////
        //メソッド名：CheckClientIDExistence()
        //引　数   ：営業所コード
        //戻り値   ：True or False
        //機　能   ：一致するmメーカーIDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckClientIDExistence(int MakerID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //メーカーIDで一致するデータが存在するか
                flg = context.M_Makers.Any(x => x.MaID == MakerID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        ///////////////////////////////
        //メソッド名：CheckClientNameExistence()
        //引　数   ：営業所コード
        //戻り値   ：True or False
        //機　能   ：一致する営業所名の有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckClientNameExistence(string MakerName)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //営業所IDで一致するデータが存在するか
                flg = context.M_Makers.Any(x => x.MaName == MakerName);
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
        //機　能：メーカーデータの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddSalesOfficeData(M_Maker regMaker)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Makers.Add(regMaker);
                context.SaveChanges();
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

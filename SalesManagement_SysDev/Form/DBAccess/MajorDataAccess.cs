using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class MajorDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetMajorDspData()
        //引　数   ：なし
        //戻り値   ：表示用大分類名データ
        //機　能   ：表示用大分類名データの取得
        ///////////////////////////////
        public List<M_MajorClassification> GetMajorDspData()
        {
            List<M_MajorClassification> listMajor = new List<M_MajorClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                listMajor = context.M_MajorClassifications.Where(x => x.McFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMajor;
        }
        ///////////////////////////////
        //メソッド名：GetMakerData()
        //引　数：なし
        //戻り値：大分類データ
        //機　能：大分類データの全取得
        ///////////////////////////////
        public List<M_MajorClassification> GetMajorData()
        {
            List<M_MajorClassification> listMajor = new List<M_MajorClassification>();

            try
            {
                var context = new SalesManagement_DevContext();
                listMajor = context.M_MajorClassifications.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMajor;
        }
        ///////////////////////////////
        //メソッド名：GetMakerDspData()　　※オーバーロード
        //引　数：なし
        //戻り値：管理Flgが表示のメーカーデータ
        //機　能：管理Flgが表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_MajorClassification> GetMajorDspData(List<M_MajorClassification> dspMajor)
        {
            List<M_MajorClassification> listMajor = new List<M_MajorClassification>();

            try
            {
                listMajor = dspMajor.Where(x => x.McFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMajor;
        }
        ///////////////////////////////
        //メソッド名：GetMajorNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示のメーカーデータ
        //機　能：管理Flgが非表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_MajorClassification> GetMajorNotDspData(List<M_MajorClassification> dspMajor)
        {
            List<M_MajorClassification> listMajor = new List<M_MajorClassification>();

            try
            {
                listMajor = dspMajor.Where(x => x.McFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMajor;
        }
        ///////////////////////////////
        //メソッド名：CheckMakerIDExistence()
        //引　数   ：メーカーコード
        //戻り値   ：True or False
        //機　能   ：一致するメーカーIDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckMajorIDExistence(int MajorID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //大分類IDで一致するデータが存在するか
                flg = context.M_MajorClassifications.Any(x => x.McID == MajorID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        ///////////////////////////////
        //メソッド名：CheckMakerNameExistence()
        //引　数   ：メーカーコード
        //戻り値   ：True or False
        //機　能   ：一致するメーカー名の有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckMajorNameExistence(string MajorName)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //営業所IDで一致するデータが存在するか
                flg = context.M_MajorClassifications.Any(x => x.McName == MajorName);
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

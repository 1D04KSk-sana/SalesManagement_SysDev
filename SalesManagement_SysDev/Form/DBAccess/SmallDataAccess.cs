using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SmallDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetSmallClassificationDspData()
        //引　数   ：なし
        //戻り値   ：表示用小分類名データ
        //機　能   ：表示用小分類名データの取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallDspData()
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                listSmall = context.M_SmallClassifications.Where(x => x.ScFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：GetSmallData()
        //引　数：なし
        //戻り値：大分類データ
        //機　能：大分類データの全取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallData()
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSmall = context.M_SmallClassifications.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：GetSmallDspData()　　※オーバーロード
        //引　数：なし
        //戻り値：管理Flgが表示のメーカーデータ
        //機　能：管理Flgが表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallDspData(List<M_SmallClassification> dspSmall)
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();

            try
            {
                listSmall = dspSmall.Where(x => x.ScFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：GetSmallNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示のメーカーデータ
        //機　能：管理Flgが非表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallNotDspData(List<M_SmallClassification> dspSmall)
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();

            try
            {
                listSmall = dspSmall.Where(x => x.ScFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
    }
}

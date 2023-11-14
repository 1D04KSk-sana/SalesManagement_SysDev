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
        public List<M_SmallClassification> GetSmallClassificationDspData()
        {
            List<M_SmallClassification> listSmallClassification = new List<M_SmallClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                listSmallClassification = context.M_SmallClassifications.Where(x => x.ScFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmallClassification;
        }
    }
}

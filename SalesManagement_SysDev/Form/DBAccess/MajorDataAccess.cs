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
        //メソッド名：GetMajorClassificationDspData()
        //引　数   ：なし
        //戻り値   ：表示用大分類名データ
        //機　能   ：表示用大分類名データの取得
        ///////////////////////////////
        public List<M_MajorClassification> GetMajorClassificationDspData()
        {
            List<M_MajorClassification> listMajorClassification = new List<M_MajorClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                listMajorClassification = context.M_MajorCassifications.Where(x => x.McFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMajorClassification;
        }
    }
}

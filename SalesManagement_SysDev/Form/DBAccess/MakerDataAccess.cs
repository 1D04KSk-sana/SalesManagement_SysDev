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
        //メソッド名：GetSalesOfficeDspData()
        //引　数   ：なし
        //戻り値   ：表示用メーカ名データ
        //機　能   ：表示用メーカデータの取得
        ///////////////////////////////
        public List<M_Maker> GetMakerDspData()
        {
            List<M_Maker> listMaker = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                listMaker = context.M_Makers.Where(x => x.MaFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
    }
}

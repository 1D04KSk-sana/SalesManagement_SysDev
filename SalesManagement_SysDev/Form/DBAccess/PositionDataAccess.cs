using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class PositionDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetPositionDspData()
        //引　数   ：なし
        //戻り値   ：表示用役員データ
        //機　能   ：表示用役員データの取得
        ///////////////////////////////
        public List<M_Position> GetPositionDspData()
        {
            List<M_Position> listPosition = new List<M_Position>();
            try
            {
                var context = new SalesManagement_DevContext();
                listPosition = context.M_Positions.Where(x => x.PoFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listPosition;
        }
    }
}

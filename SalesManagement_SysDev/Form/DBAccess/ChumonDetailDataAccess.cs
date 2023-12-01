using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ChumonDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetOrderDetailData()
        //引　数：なし
        //戻り値：受注詳細データ
        //機　能：受注詳細データの全取得
        ///////////////////////////////
        public List<T_ChumonDetail> GetChumonDetailIDData(int chumonID)
        {
            List<T_ChumonDetail> listChumonDetail = new List<T_ChumonDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listChumonDetail = context.T_ChumonDetails.Where(x => x.ChID == chumonID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listChumonDetail;
        }
    }
}

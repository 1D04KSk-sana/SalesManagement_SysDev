using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetOrderDetailData()
        //引　数：なし
        //戻り値：受注詳細データ
        //機　能：受注詳細データの全取得
        ///////////////////////////////
        public List<T_SyukkoDetail> GetSyukkoDetailIDData(int syukkoID)
        {
            List<T_SyukkoDetail> listOrderDetail = new List<T_SyukkoDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listOrderDetail = context.T_SyukkoDetails.Where(x => x.SyID == syukkoID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrderDetail;
        }
    }
}

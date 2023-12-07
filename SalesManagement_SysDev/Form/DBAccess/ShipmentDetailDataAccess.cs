using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ShipmentDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：AddShipmentDetailData()
        //引　数：regShipment = 入荷詳細データ
        //戻り値：True or False
        //機　能：入荷詳細データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddShipmentDetailData(T_ShipmentDetail regShipment)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ShipmentDetails.Add(regShipment);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ShipmentDataAccess
    {
        ///////////////////////////////
        //メソッド名：AddShipmentData()
        //引　数：regShipment = 入荷データ
        //戻り値：True or False
        //機　能：入荷データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddShipmentData(T_Shipment regShipment)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Shipments.Add(regShipment);
                context.SaveChanges();
                context.Dispose();
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

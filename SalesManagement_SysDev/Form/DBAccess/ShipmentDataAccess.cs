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
        //メソッド名：GetShipmentData()
        //引　数：なし
        //戻り値：受注データ
        //機　能：受注データの全取得
        ///////////////////////////////
        public List<T_Shipment> GetShipmentData()
        {
            List<T_Shipment> listShipment = new List<T_Shipment>();

            try
            {
                var context = new SalesManagement_DevContext();
                listShipment = context.T_Shipments.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listShipment;
        }

        ///////////////////////////////
        //メソッド名：GetShipmentDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の受注データ
        //機　能：管理Flgが表示の受注データの全取得
        ///////////////////////////////
        public List<T_Shipment> GetShipmentDspData(List<T_Shipment> dspOrder)
        {
            List<T_Shipment> listOrder = new List<T_Shipment>();

            try
            {
                listOrder = dspOrder.Where(x => x.ShFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }

        ///////////////////////////////
        //メソッド名：GetShipmentNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の受注データ
        //機　能：管理Flgが非表示の受注データの全取得
        ///////////////////////////////
        public List<T_Shipment> GetShipmentNotDspData(List<T_Shipment> dspOrder)
        {
            List<T_Shipment> listOrder = new List<T_Shipment>();

            try
            {
                listOrder = dspOrder.Where(x => x.ShFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }
    }
}

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
        //メソッド名：CheckShipmentDetailProdactIDExistence()
        //引　数   ：商品ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckShipmentDetailProdactIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                //部署CDで一致するデータが存在するか
                flg = context.T_ShipmentDetails.Any(x => x.PrID == ProdactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        //////////////////////////////
        //メソッド名：AddShipmentDetailData()
        //引　数：regShipment = 出荷詳細データ
        //戻り値：True or False
        //機　能：出荷詳細データの登録
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

        ///////////////////////////////
        //メソッド名：GetIDShipmentDetailData()
        //引　数：出荷ID
        //戻り値：出荷IDの一致する出荷詳細データ
        //機　能：出荷IDの一致する出荷詳細データの取得
        ///////////////////////////////
        public List<T_ShipmentDetail> GetIDShipmentDetailData(int shipmentID)
        {
            List<T_ShipmentDetail> listShipmentDetail = new List<T_ShipmentDetail> { };

            try
            {
                var context = new SalesManagement_DevContext();
                listShipmentDetail = context.T_ShipmentDetails.Where(x => x.ShID == shipmentID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listShipmentDetail;
        }
    }
}

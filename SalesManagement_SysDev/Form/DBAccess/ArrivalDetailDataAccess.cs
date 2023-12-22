using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ArrivalDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckArrivalDetailProdactIDExistence()
        //引　数   ：商品ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckArrivalDetailProdactIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                //部署CDで一致するデータが存在するか
                flg = context.T_ArrivalDetails.Any(x => x.PrID == ProdactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetArrivalDetailData()
        //引　数：なし
        //戻り値：入荷詳細データ
        //機　能：入荷詳細データの全取得
        ///////////////////////////////
        public List<T_ArrivalDetail> GetArrivalDetailIDData(int arrivalID)
        {
            List<T_ArrivalDetail> listArrivalDetail = new List<T_ArrivalDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listArrivalDetail = context.T_ArrivalDetails.Where(x => x.ArID == arrivalID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listArrivalDetail;
        }
        ///////////////////////////////
        //メソッド名：CheckArrivalDetailIDExistence()
        //引　数   　:入荷詳細コード
        //戻り値   ：True or False
        //機　能   ：一致する入荷詳細IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckArrivalDetailIDExistence(int ArrivalDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //部署CDで一致するデータが存在するか
                flg = context.T_ArrivalDetails.Any(x => x.ArDetailID == ArrivalDetailID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddArrivalDetailData()
        //引　数：regArrivalDetail = 入荷詳細データ
        //戻り値：True or False
        //機　能：入荷詳細データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddArrivalDetailData(T_ArrivalDetail regArrivalDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ArrivalDetails.Add(regArrivalDetail);
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

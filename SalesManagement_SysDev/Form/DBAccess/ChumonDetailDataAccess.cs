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
        //メソッド名：CheckChumonDetailProdactIDExistence()
        //引　数   ：商品ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckChumonDetailProdactIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                //部署CDで一致するデータが存在するか
                flg = context.T_ChumonDetails.Any(x => x.PrID == ProdactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

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

        ///////////////////////////////
        //メソッド名：AddChumonDetailData()
        //引　数：regChumon = 注文詳細データ
        //戻り値：True or False
        //機　能：注文詳細データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddChumonDetailData(T_ChumonDetail regChumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ChumonDetails.Add(regChumon);
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

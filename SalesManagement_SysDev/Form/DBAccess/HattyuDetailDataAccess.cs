using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class HattyuDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckHattyuDetailProdactIDExistence()
        //引　数   ：商品ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckHattyuDetailProdactIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                //部署CDで一致するデータが存在するか
                flg = context.T_HattyuDetails.Any(x => x.PrID == ProdactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddHattyuDetailData()
        //引　数：regHattyu = 発注詳細データ
        //戻り値：True or False
        //機　能：発注詳細データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddHattyuDetailData(T_HattyuDetail regHattyu)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_HattyuDetails.Add(regHattyu);
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
        //メソッド名：CheckHattyuDetailIDExistence()
        //引　数   ：発注詳細コード
        //戻り値   ：True or False
        //機　能   ：一致する発注詳細IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckHattyuDetailIDExistence(int HattyuDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //部署CDで一致するデータが存在するか
                flg = context.T_HattyuDetails.Any(x => x.HaDetailID == HattyuDetailID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetIDHattyuDetailData()
        //引　数：発注ID
        //戻り値：発注IDの一致する発注詳細データ
        //機　能：発注IDの一致する発注詳細データの取得
        ///////////////////////////////
        public List<T_HattyuDetail> GetIDHattyuDetailData(int HattyuID)
        {
            List<T_HattyuDetail> listHattyuDetail = new List<T_HattyuDetail> { };

            try
            {
                var context = new SalesManagement_DevContext();
                listHattyuDetail = context.T_HattyuDetails.Where(x => x.HaID == HattyuID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listHattyuDetail;
        }

        ///////////////////////////////
        //メソッド名：HattyuDetailNum()
        //引　数：なし
        //戻り値：発注詳細件数
        //機　能：発注詳細データの件数
        ///////////////////////////////
        public int HattyuDetailNum()
        {
            var context = new SalesManagement_DevContext();

            //登録されている発注件数取得
            int HattyuDetailCount = context.T_Hattyus.Count();

            return HattyuDetailCount;
        }
    }
}

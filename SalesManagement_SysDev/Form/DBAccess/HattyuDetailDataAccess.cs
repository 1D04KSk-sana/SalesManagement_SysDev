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
        //メソッド名：GetHattyuDetailData()
        //引　数：なし
        //戻り値：発注詳細データ
        //機　能：発注詳細データの全取得
        ///////////////////////////////
        public List<T_HattyuDetail> GetHattyuDetailData()
        {
            List<T_HattyuDetail> listHattyuDetail = new List<T_HattyuDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listHattyuDetail = context.T_HattyuDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listHattyuDetail;
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
        //メソッド名：GetHattyuDetailData()
        //引　数：なし
        //戻り値：発注詳細データ
        //機　能：発注詳細データの全取得
        ///////////////////////////////
        public List<T_HattyuDetail> GetHattyuDetailIDData(int hattyuID)
        {
            List<T_HattyuDetail> listHattyuDetail = new List<T_HattyuDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listHattyuDetail = context.T_HattyuDetails.Where(x => x.HaID == hattyuID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listHattyuDetail;
        }
        ///////////////////////////////
        //メソッド名：CheckHattyuDetailIDExistence()
        //引　数   ：発注コード
        //戻り値   ：True or False
        //機　能   ：一致する発注IDの有無を確認
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

    }
}

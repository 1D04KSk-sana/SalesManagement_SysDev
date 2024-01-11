using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class WarehousingDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckWarehousingDetailProdactIDExistence()
        //引　数   ：商品ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckWarehousingDetailProdactIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                //部署CDで一致するデータが存在するか
                flg = context.T_WarehousingDetails.Any(x => x.PrID == ProdactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddWarehousingDetailData()
        //引　数：regWarehousing = 入庫詳細データ
        //戻り値：True or False
        //機　能：入庫詳細データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddWarehousingDetailData(T_WarehousingDetail regWarehousing)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_WarehousingDetails.Add(regWarehousing);
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
        //メソッド名：GetWarehousingDetailData()
        //引　数：なし
        //戻り値：入庫詳細データ
        //機　能：入庫詳細データの全取得
        ///////////////////////////////
        public List<T_WarehousingDetail> GetWarehousingDetailIDData(int warehousingID)
        {
            List<T_WarehousingDetail> listWarehousingDetail = new List<T_WarehousingDetail>();

            try
            {
                var context = new SalesManagement_DevContext();
                listWarehousingDetail = context.T_WarehousingDetails.Where(x => x.WaID == warehousingID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listWarehousingDetail;
        }
        ///////////////////////////////
        //メソッド名：CheckWarehousingDetailIDExistence()
        //引　数   ：入庫詳細コード
        //戻り値   ：True or False
        //機　能   ：一致する入庫詳細IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckWarehousingDetailIDExistence(int WarehousingDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //部署CDで一致するデータが存在するか
                flg = context.T_WarehousingDetails.Any(x => x.WaDetailID == WarehousingDetailID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetIDWarehousingDetailData()
        //引　数：入庫ID
        //戻り値：入庫IDの一致する入庫詳細データ
        //機　能：入庫IDの一致する入庫詳細データの取得
        ///////////////////////////////
        public List<T_WarehousingDetail> GetIDWarehousingDetailData(int WarehousingID)
        {
            List<T_WarehousingDetail> listWarehousingDetail = new List<T_WarehousingDetail> { };

            try
            {
                var context = new SalesManagement_DevContext();
                listWarehousingDetail = context.T_WarehousingDetails.Where(x => x.WaID == WarehousingID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listWarehousingDetail;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class HattyuDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckHattyuIDExistence()
        //引　数   ：発注コード
        //戻り値   ：True or False
        //機　能   ：一致する発注IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckHattyuIDExistence(int HattyuID)
        {
            bool flg = false;
            try
            {
                var context = new HattyusManagement_DevContext();
                //部署CDで一致するデータが存在するか
                flg = context.T_Hattyus.Any(x => x.haID == HattyuID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetHattyuData()
        //引　数：なし
        //戻り値：発注データ
        //機　能：発注データの全取得
        ///////////////////////////////
        public List<T_Hattyu> GetHattyuData()
        {
            List<T_Hattyu> listHattyu = new List<T_Hattyu>();

            try
            {
                var context = new HattyusManagement_DevContext();
                listHattyu = context.T_Hattyus.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listHattyu;
        }

        ///////////////////////////////
        //メソッド名：GetHattyuDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の発注データ
        //機　能：管理Flgが表示の発注データの全取得
        ///////////////////////////////
        public List<T_Hattyu> GetHattyuDspData(List<T_Hattyu> dspHattyu)
        {
            List<T_Hattyu> listHattyu = new List<T_Hattyu>();

            try
            {
                listHattyu = dspHattyu.Where(x => x.HaFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listHattyu;
        }

        ///////////////////////////////
        //メソッド名：GetHattyuNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の発注データ
        //機　能：管理Flgが非表示の発注データの全取得
        ///////////////////////////////
        public List<T_Hattyu> GetHattyuNotDspData(List<T_Hattyu> dspHattyu)
        {
            List<T_Hattyu> listHattyu = new List<T_Hattyu>();

            try
            {
                listHattyu = dspHattyu.Where(x => x.HaFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listHattyu;
        }

        ///////////////////////////////
        //メソッド名：GetAndHattyuData()
        //引　数：検索条件
        //戻り値：条件完全一致発注データ
        //機　能：条件完全一致発注データの取得
        ///////////////////////////////
        public List<T_Hattyu> GetAndHattyuData(T_Sale selectHattyu)
        {
            List<T_Hattyu> listHattyu = new List<T_Hattyu>();
            try
            {
                var context = new HattyusManagement_DevContext();
                var query = context.T_Hattyus.AsQueryable();

                if (selectSale.SaID != null && selectSale.SaID != 0)
                {
                    query = query.Where(x => x.SaID == selectSale.SaID);
                }

                if (selectSale.SoID != null && selectSale.SoID != 0)
                {
                    query = query.Where(x => x.SoID == selectSale.SoID);
                }

                if (selectSale.ChID != null && selectSale.ChID != 0)
                {
                    query = query.Where(x => x.ChID == selectSale.ChID);
                }
                if (selectSale.ClID != null && selectSale.ClID != 0)
                {
                    query = query.Where(x => x.ClID == selectSale.ClID);
                }
                if (selectSale.SaDate != null)
                {
                    query = query.Where(x => x.SaDate.Month == selectSale.SaDate.Month);
                }




                listHattyu = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listHattyu;
        }

        ///////////////////////////////
        //メソッド名：GetOrHattyuData()
        //引　数：検索条件
        //戻り値：条件一部一致発注データ
        //機　能：条件一部一致うデータの取得
        ///////////////////////////////
        public List<T_Hattyu> GetOrHattyuData(T_Hattyu selectHattyu)
        {
            List<T_Hattyu> listHattyu = new List<T_Hattyu>();
            try
            {
                var context = new HattyusManagement_DevContext();
                listHattyu = context.T_Hattyus.Where(x => x.SaID == selectSale.SaID || x.SoID == selectSale.SoID || x.ChID == selectSale.ChID || x.ClID == selectSale.ClID || x.SaDate.Month == selectSale.SaDate.Month).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listHattyu;
        }
        ///////////////////////////////
        //メソッド名：UpdateHattyuData()
        //引　数：updHattyu = 発注データ
        //戻り値：True or False
        //機　能：発注データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateHattyuData(T_Hattyu updHattyu)
        {
            try
            {
                var context = new HattyusManagement_DevContext();
                var Hattyu = context.T_Hattyus.Single(x => x.HaID == updHattyu.HaID);

                Hattyu.HaFlag = updHattyu.HaFlag;
                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        ///////////////////////////////
        //メソッド名：AddHattyuData()
        //引　数：regHattyu = 発注データ
        //戻り値：True or False
        //機　能：発注データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddHattyuData(T_Hattyu regHattyu)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Hattyus.Add(regHattyu);
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

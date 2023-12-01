using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ChumonDataAccess
    {
        ///////////////////////////////
        //メソッド名：AddChumonData()
        //引　数：regChumon = 注文データ
        //戻り値：True or False
        //機　能：注文データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddChumonData(T_Chumon regChumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Chumons.Add(regChumon);
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

        ///////////////////////////////
        //メソッド名：CheckChumonIDExistence()
        //引　数   ：受注コード
        //戻り値   ：True or False
        //機　能   ：一致する受注IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckChumonIDExistence(int chumonID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDで一致するデータが存在するか
                flg = context.T_Chumons.Any(x => x.ChID == chumonID);
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

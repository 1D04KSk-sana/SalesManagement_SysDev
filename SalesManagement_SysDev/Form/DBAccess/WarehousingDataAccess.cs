using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class WarehousingDataAccess
    {
        ///////////////////////////////
        //メソッド名：AddWarehousingData()
        //引　数：regWarehousing = 注文データ
        //戻り値：True or False
        //機　能：入庫データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddWarehousingData(T_Warehousing regWarehousing)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Warehousings.Add(regWarehousing);
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

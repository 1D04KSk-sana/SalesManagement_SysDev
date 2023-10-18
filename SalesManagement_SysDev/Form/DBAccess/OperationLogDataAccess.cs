using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OperationLogDataAccess
    {
        ///////////////////////////////
        //メソッド名：AddOperationLogData()
        //引　数：操作ログデータ
        //戻り値：True or False
        //機　能：操作ログデータの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddOperationLogData(T_OperationLog regOperationLog)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_OperationLogs.Add(regOperationLog);
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

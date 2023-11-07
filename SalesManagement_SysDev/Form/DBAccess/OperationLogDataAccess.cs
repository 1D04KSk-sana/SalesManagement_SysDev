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

        ///////////////////////////////
        //メソッド名：OperationLogNum()
        //引　数：なし
        //戻り値：操作ログ件数
        //機　能：操作ログデータの件数
        ///////////////////////////////
        public int OperationLogNum()
        {
            var context = new SalesManagement_DevContext();

            //登録されている操作ログの件数取得
            int logCount = context.T_OperationLogs.Count();

            return logCount;
        }
        ///////////////////////////////
        //メソッド名：GetLogData()
        //引　数：なし
        //戻り値：操作ログデータ
        //機　能：操作ログデータの全取得
        ///////////////////////////////
        public List<T_OperationLog> GetLogData()
        {
            List<T_OperationLog> listLog = new List<T_OperationLog>();

            try
            {
                var context = new SalesManagement_DevContext();
                listLog = context.T_OperationLogs.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listLog;
        }
        ///////////////////////////////
        //メソッド名：GetAndLogData()
        //引　数：検索条件
        //戻り値：条件完全一致操作ログデータ
        //機　能：条件完全一致操作ログデータの取得
        ///////////////////////////////
        public List<T_OperationLog> GetAndLogData(T_OperationLog selectLog)
        {
            List<T_OperationLog> listLog = new List<T_OperationLog>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_OperationLogs.AsQueryable();

                if (selectLog.OpHistoryID != null && selectLog.OpHistoryID != 0)
                {
                    query = query.Where(x => x.OpHistoryID == selectLog.OpHistoryID);
                }

                listLog = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listLog;
        }

        ///////////////////////////////
        //メソッド名：GetOrLogData()
        //引　数：検索条件
        //戻り値：条件一部一致操作ログデータ
        //機　能：条件一部一致操作ログデータの取得
        ///////////////////////////////
        public List<T_OperationLog> GetOrLogData(T_OperationLog selectLog)
        {
            List<T_OperationLog> listLog = new List<T_OperationLog>();
            try
            {
                var context = new SalesManagement_DevContext();
                listLog = context.T_OperationLogs.Where(x => x.OpHistoryID == selectLog.OpHistoryID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listLog;
        }
    }
}

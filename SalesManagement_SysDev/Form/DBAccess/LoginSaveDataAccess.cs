using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class LoginSaveDataAccess
    {
        ///////////////////////////////
        //メソッド名：AddSaveLogData()
        //引　数：ログイン記憶データ
        //戻り値：True or False
        //機　能：ログイン記憶データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddOperationLogData(T_LoginSave regLoginSave)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_LoginSaves.Add(regLoginSave);
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
        //メソッド名：UpdateOperationLogData()
        //引　数：ログイン記憶データ
        //戻り値：True or False
        //機　能：ログイン記憶データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateOperationLogData(T_LoginSave updLoginSave)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var LoginSave = context.T_LoginSaves.Single(x => x.SaveId == 1);

                LoginSave.SaveEmployeeID = updLoginSave.SaveEmployeeID;
                LoginSave.SaveSinghUpPass = updLoginSave.SaveSinghUpPass;

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
        //メソッド名：DeleteSaveLogData()
        //引　数：ログイン記憶データ
        //戻り値：True or False
        //機　能：ログイン記憶データの削除
        //      ：削除成功の場合True
        //      ：削除失敗の場合False
        ///////////////////////////////
        public bool DeleteSaveLogData(T_LoginSave delLoginSave)
        {
            try
            {
                var context = new SalesManagement_DevContext();
            context.Entry(delLoginSave).State = EntityState.Deleted;
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
        //メソッド名：GetSaveLogData()
        //引　数：なし
        //戻り値：ログイン記憶データ
        //機　能：ログイン記憶データの取得
        ///////////////////////////////
        public T_LoginSave GetSaveLogData()
        {
            T_LoginSave LoginSave = new T_LoginSave();

            try
            {
                var context = new SalesManagement_DevContext();
                LoginSave = context.T_LoginSaves.Single(x => x.SaveId == 1);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return LoginSave;
        }
    }
}

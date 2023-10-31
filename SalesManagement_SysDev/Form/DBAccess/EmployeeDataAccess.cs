using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class EmployeeDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckEmployeeIDExistence()
        //引　数   ：社員ID
        //戻り値   ：True or False
        //機　能   ：一致する社員IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckEmployeeIDExistence(int employeeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //社員IDで一致するデータが存在するか
                flg = context.M_Employees.Any(x => x.EmID == employeeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddEmployeeData()
        //引　数：regEmployee = 顧客データ
        //戻り値：True or False
        //機　能：顧客データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddEmployeeData(M_Employee regEmployee)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Employees.Add(regEmployee);
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
        //メソッド名：CheckSinghUpPassExistence()
        //引　数   ：パスワード
        //戻り値   ：True or False
        //機　能   ：一致するパスワードの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSinghUpPassExistence(string singhUpPass)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //社員IDで一致するデータが存在するか
                flg = context.M_Employees.Any(x => x.EmPassword == singhUpPass);
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

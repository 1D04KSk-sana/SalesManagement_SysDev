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
        //メソッド名：GetEmployeeData()
        //引　数：なし
        //戻り値：顧客データ
        //機　能：顧客データの全取得
        ///////////////////////////////
        public List<M_Employee> GetEmployeeData()
        {
            List<M_Employee> listEmployee = new List<M_Employee>();

            try
            {
                var context = new SalesManagement_DevContext();
                listEmployee = context.M_Employees.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listEmployee;
        }
        ///////////////////////////////
        //メソッド名：GetEmployeeDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の社員データ
        //機　能：管理Flgが表示の社員データの全取得
        ///////////////////////////////
        public List<M_Employee> GetEmployeeDspData(List<M_Employee> dspEmployee)
        {
            List<M_Employee> listEmployee = new List<M_Employee>();

            try
            {
                listEmployee = dspEmployee.Where(x => x.EmFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listEmployee;
        }
        ///////////////////////////////
        //メソッド名：GetEmployeeNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の顧客データ
        //機　能：管理Flgが非表示の顧客データの全取得
        ///////////////////////////////
        public List<M_Employee> GetEmployeeNotDspData(List<M_Employee> dspEmployee)
        {
            List<M_Employee> listEmployee = new List<M_Employee>();

            try
            {
                listEmployee = dspEmployee.Where(x => x.EmFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listEmployee;
        }
        ///////////////////////////////
        //メソッド名：UpdateEmployeeData()
        //引　数：updEmployee = 社員データ
        //戻り値：True or False
        //機　能：社員データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateEmployeeData(M_Employee updEmployee)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Employee = context.M_Employees.Single(x => x.EmID == updEmployee.EmID);

                Employee.EmName = updEmployee.EmName;
                Employee.EmName = updEmployee.EmName;
                Employee.EmName = updEmployee.EmName;
                Employee.EmName = updEmployee.EmName;
                Employee.SoID = updEmployee.SoID;


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

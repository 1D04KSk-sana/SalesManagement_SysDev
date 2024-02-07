using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_PassChange : Form
    {
        public F_PassChange()
        {
            InitializeComponent();
        }

        //入力チェッククラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //パスワードハッシュ化クラスのインスタンス化
        PasswordHash passwordHash = new PasswordHash();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogDataAccess = new OperationLogDataAccess();
        //データベースログイン記憶テーブルアクセス用クラスのインスタンス化
        LoginSaveDataAccess loginSaveDataAccess = new LoginSaveDataAccess();

        private int intPassEye = 1;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_PassChange_Load(object sender, EventArgs e)
        {
            if (F_Login.intPositionID == 1)
            {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
                pnlPassChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(122)))));
            }
            if (F_Login.intPositionID == 2)
            {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
                pnlPassChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(128)))));
            }
            if (F_Login.intPositionID == 3)
            {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
                pnlPassChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(179)))));
            }
        }

        private void pctPassEye_Click(object sender, EventArgs e)
        {
            if (intPassEye == 0)
            {
                txbSinghUpPass.PasswordChar = '*';
                txbPassKaku.PasswordChar = '*';
                pctPassEye.Image = Properties.Resources.PassEyeNot;

                intPassEye = 1;
            }
            else if (intPassEye == 1)
            {
                txbSinghUpPass.PasswordChar = '\0';
                txbPassKaku.PasswordChar = '\0';
                pctPassEye.Image = Properties.Resources.PassEye;

                intPassEye = 0;
            }
        }

        ///////////////////////////////
        //メソッド名：GetValidDataAtLogin()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：ログイン入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtLogin()
        {
            //パスワードの適否
            if (!String.IsNullOrEmpty(txbSinghUpPass.Text.Trim()))
            {
                //パスワードの数字チェック
                if (!dataInputCheck.CheckHalfAlphabetNumeric(txbSinghUpPass.Text.Trim()))
                {
                    MessageBox.Show("パスワードは全て英数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSinghUpPass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("パスワードを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSinghUpPass.Focus();
                return false;
            }

            //パスワードの適否
            if (!String.IsNullOrEmpty(txbPassKaku.Text.Trim()))
            {
                //パスワードの数字チェック
                if (!dataInputCheck.CheckHalfAlphabetNumeric(txbPassKaku.Text.Trim()))
                {
                    MessageBox.Show("パスワードは全て英数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPassKaku.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("パスワードを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPassKaku.Focus();
                return false;
            }

            if (txbSinghUpPass.Text.Trim() != txbPassKaku.Text.Trim())
            {
                MessageBox.Show("確認用のパスワードと異なります", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSinghUpPass.Focus();
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtLogin())
            {
                return;
            }

            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("パスワードを更新しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //操作ログデータ取得
            var regOperationLog = GenerateLogAtRegistration("パスワード更新");

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogDataAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 顧客情報作成
            var updEmployee = GenerateDataAtUpdate();

            // 顧客情報更新
            UpdatePasswaord(updEmployee);
        }

        ///////////////////////////////
        //メソッド名：GenerateLogAtRegistration()
        //引　数   ：操作名
        //戻り値   ：操作ログ登録情報
        //機　能   ：操作ログ情報登録データのセット
        ///////////////////////////////
        private T_OperationLog GenerateLogAtRegistration(string OperationDone)
        {
            return new T_OperationLog
            {
                OpHistoryID = operationLogDataAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "パスワード更新画面",
                OpDone = OperationDone,
                OpDBID = null,
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：パスワード更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_Employee GenerateDataAtUpdate()
        {
            return new M_Employee
            {
                EmID = F_Login.intEmployeeID,
                EmPassword = PasswordHash.CreatePasswordHash(txbSinghUpPass.Text.Trim())
            };
        }

        ///////////////////////////////
        //メソッド名：UpdatePasswaord()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客情報の更新
        ///////////////////////////////
        private void UpdatePasswaord(M_Employee updEmployee)
        {
            // 顧客情報の更新
            bool flg = employeeDataAccess.UpdatePassData(updEmployee);
            if (flg == true)
            {
                MessageBox.Show("更新しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("更新に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var context = new SalesManagement_DevContext();

            if (context.T_LoginSaves.Count() != 0)
            {
                var delLoginSave = loginSaveDataAccess.GetSaveLogData();

                loginSaveDataAccess.DeleteSaveLogData(delLoginSave);
            }

            context.Dispose();
        }
    }
}

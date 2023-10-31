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
    public partial class F_HonshaSinghUp : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess EmployeeDataAccess = new EmployeeDataAccess();
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogDataAccess = new OperationLogDataAccess();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //データベース役職名テーブルアクセス用クラスのインスタンス化
       PositionDataAccess PositionDataAccess = new PositionDataAccess();
        //コンボボックス用の役職名データリスト
        private static List<M_Position> listPosition = new List<M_Position>();

        public F_HonshaSinghUp()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtRegistration())
            {
                return;
            }

            //操作ログデータ取得
            var regOperationLog = GenerateLogAtRegistration("登録");

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogDataAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }
            // 顧客情報作成
            var regEmployee = GenerateDataAtRegistration();

            // 顧客情報登録
            RegistrationEmployee(regEmployee);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
        }

            ///////////////////////////////
            //メソッド名：RegEmployee()
            //引　数   ：顧客情報
            //戻り値   ：なし
            //機　能   ：顧客データの登録
            ///////////////////////////////
            private void RegistrationEmployee(M_Employee regEmployee)
        {
            // 顧客情報の登録
            bool flg = EmployeeDataAccess.AddEmployeeData(regEmployee);

            //登録成功・失敗メッセージ
            if (flg == true)
            {
                MessageBox.Show("データを登録しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 入力エリアのクリア
            ClearImput();

        }
        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbEmployeeName.Text = string.Empty;
            txbSinghUpPass.Text = string.Empty;
            txbSinghUpPhone.Text = string.Empty;
            dtpHireDate.Value = DateTime.Now;
            cmbSalesOfficeID.SelectedIndex = -1;
            cmbPositionID.SelectedIndex = -1;
            txbEmployeeID.Text = string.Empty;
        }

        ///////////////////////////////
        //メソッド名：GenerateLogAtRegistration()
        //引　数   ：操作名
        //戻り値   ：操作ログ登録情報
        //機　能   ：操作ログ情報登録データのセット
        ///////////////////////////////
        private T_OperationLog GenerateLogAtRegistration(string OperationDone)
        {
            //登録・更新使用としている顧客データの取得
            var logOperatin = GenerateDataAtRegistration();

            return new T_OperationLog
            {
                OpHistoryID = operationLogDataAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "社員新規登録画面",
                OpDone = OperationDone,
                OpDBID = logOperatin.EmID,
                OpSetTime = DateTime.Now
            };
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：顧客登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Employee GenerateDataAtRegistration()
        {
            return new M_Employee
            {
                EmID = int.Parse(txbEmployeeID.Text.Trim()),
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                EmPassword = txbSinghUpPass.Text.Trim(),
                EmHiredate = dtpHireDate.Value,
                EmPhone = txbSinghUpPhone.Text.Trim(),
                PoID = cmbPositionID.SelectedIndex +1,
                EmName = txbEmployeeName.Text.Trim(),
            };
        }
        
        ///////////////////////////////
        //メソッド名：GetValidDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：登録入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtRegistration()
        {
            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                // 顧客IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbEmployeeID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (EmployeeDataAccess.CheckEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("顧客IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeID.Focus();
                return false;
            }

            // 社員名の適否
            if (!String.IsNullOrEmpty(txbEmployeeName.Text.Trim()))
            {
                // 社員名の文字数チェック
                if (txbEmployeeName.TextLength > 50)
                {
                    MessageBox.Show("社員名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("社員名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeName.Focus();
                return false;
            }

            //役職名の適否
            if (cmbPositionID.SelectedIndex == -1)
            {
                MessageBox.Show("営業名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPositionID.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbSinghUpPhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbSinghUpPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSinghUpPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSinghUpPhone.Focus();
                return false;
            }


            // パスワードの適否
            if (!String.IsNullOrEmpty(txbSinghUpPass.Text.Trim()))
            {
                // パスワードの数字チェック
                if (!dataInputCheck.CheckHalfAlphabetNumeric(txbSinghUpPass.Text.Trim()))
                {
                    MessageBox.Show("パスワードは全て半角英数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSinghUpPass.Focus();
                    return false;
                }
                // パスワードの文字数チェック
                if (txbSinghUpPass.TextLength > 10)
                {
                    MessageBox.Show("パスワードは10文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSinghUpPass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("パスワードが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSinghUpPass.Focus();
                return false;
            }

            // 営業所名の適否
            if (cmbSalesOfficeID.SelectedIndex == -1)
            {
                MessageBox.Show("営業所名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPositionID.Focus();
                return false;
            }
            return true;
        }

        private void F_HonshaSinghUp_Load(object sender, EventArgs e)
        {
            //営業所のデータを取得
            listSalesOffice = salesOfficeDataAccess.GetSalesOfficeDspData();
            //取得したデータをコンボボックスに挿入
            cmbSalesOfficeID.DataSource = listSalesOffice;
            //表示する名前をSoNameに指定
            cmbSalesOfficeID.DisplayMember = "SoName";
            //項目の順番をSoIDに指定
            cmbSalesOfficeID.ValueMember = "SoID";

            //cmbSalesOfficeIDを未選択に
            cmbSalesOfficeID.SelectedIndex = -1;

            //役職名のデータを取得
            listPosition = PositionDataAccess.GetPositionDspData();
            //取得したデータをコンボボックスに挿入
            cmbPositionID.DataSource = listPosition;
            //表示する名前をSoNameに指定
            cmbPositionID.DisplayMember = "PoName";
            //項目の順番をSoIDに指定
            cmbPositionID.ValueMember = "PoID";

            //cmbPositionIDを未選択に
            cmbPositionID.SelectedIndex = -1;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_HonshaOperationLog : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess LogDataAccess = new OperationLogDataAccess();
        //データグリッドビュー用の全操作ログデータ
        private static List<T_OperationLog> listAllLog = new List<T_OperationLog>();
        //データグリッドビュー用の操作ログデータ
        private static List<T_OperationLog> listLog = new List<T_OperationLog>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //DataGridView用に使用する社員のDictionary
        private Dictionary<int, string> dictionaryEmployee;
        //コンボボックス用の社員データリスト
        private static List<M_Employee> listEmployee = new List<M_Employee>();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();


        public F_HonshaOperationLog()
        {
            InitializeComponent();
        }

        private void F_HonshaOperationLog_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            DictionarySet();
            SetFormDataGridView();
            GetDataGridView();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
            dtpStartDate.Checked = false;
            dtpEndoDate.Checked = false;

            rdbSearch.Checked = false;

            GetDataGridView();
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }
        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            LogSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            LogSearchButtonClick(false);
        }
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar > '0' && '9' > e.KeyChar)
            {
                // テキストボックスに入力されている値を取得
                string inputText = textBox.Text + e.KeyChar;

                // 入力されている値をTryParseして、結果がTrueの場合のみ処理を行う
                int parsedValue;
                if (!int.TryParse(inputText, out parsedValue))
                {
                    MessageBox.Show("入力された数字が大きすぎます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                }
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ClientDataSelect();
            }
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {

            }
            else
            {

            }
        }
        ///////////////////////////////
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの初期設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //列を自由に設定できるように
            dgvOperationLog.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvOperationLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvOperationLog.AllowUserToResizeColumns = false;
            dgvOperationLog.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvOperationLog.MultiSelect = false;
            //セルの編集ができないように
            dgvOperationLog.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvOperationLog.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvOperationLog.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvOperationLog.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvOperationLog.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOperationLog.Columns.Add("OpHistoryID", "ログイン操作ID");
            dgvOperationLog.Columns.Add("EmID", "社員ID");
            dgvOperationLog.Columns.Add("FormName", "フォーム名");
            dgvOperationLog.Columns.Add("OpDone", "操作内容");
            dgvOperationLog.Columns.Add("OpDBID", "操作ID");
            dgvOperationLog.Columns.Add("OpSetTime", "操作日時");

            dgvOperationLog.Columns["OpHistoryID"].Width = 316;
            dgvOperationLog.Columns["EmID"].Width = 316;
            dgvOperationLog.Columns["FormName"].Width = 316;
            dgvOperationLog.Columns["OpDone"].Width = 316;
            dgvOperationLog.Columns["OpDBID"].Width = 316;
            dgvOperationLog.Columns["OpSetTime"].Width = 320;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvOperationLog.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_OperationLog> viewLog)
        {
            //中身を消去
            dgvOperationLog.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewLog.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewLog.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvOperationLogに挿入
            foreach (var item in depData)
            {
                dgvOperationLog.Rows.Add(item.OpHistoryID, item.EmID, item.FormName, item.OpDone, item.OpDBID, item.OpSetTime);
            }

            //dgvoperationLogをリフレッシュ
            dgvOperationLog.Refresh();

            if (lastPage == -1 || (lastPage == pageNum && pageNum == 0))
            {
                btnPageMax.Visible = false;
                btnNext.Visible = false;
                btnPageMin.Visible = false;
                btnBack.Visible = false;
            }
            else if (pageNum == 0)
            {
                btnPageMax.Visible = true;
                btnNext.Visible = true;
                btnPageMin.Visible = false;
                btnBack.Visible = false;
            }
            else if (lastPage == pageNum)
            {
                btnPageMax.Visible = false;
                btnNext.Visible = false;
                btnPageMin.Visible = true;
                btnBack.Visible = true;
            }
            else
            {
                btnPageMax.Visible = true;
                btnNext.Visible = true;
                btnPageMin.Visible = true;
                btnBack.Visible = true;
            }
        }
        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の顧客リスト作成
            List<T_OperationLog> listViewLog = SetListLog();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewLog);
        }
        ///////////////////////////////
        //メソッド名：SetListLog()
        //引　数   ：なし
        //戻り値   ：表示用操作ログデータ
        //機　能   ：表示用操作ログデータの準備
        ///////////////////////////////
        private List<T_OperationLog> SetListLog()
        {
            //操作ログのデータを全取得
            listAllLog = LogDataAccess.GetLogData();

            //表示用の操作ログ作成
            List<T_OperationLog> listViewLog = new List<T_OperationLog>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewLog = listLog;
            }
            else
            {
                //全データをとってくる
                listViewLog = listAllLog;
            }

            return listViewLog;
        }
        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbEmployeeID.Text = string.Empty;
        }
        ///////////////////////////////
        //メソッド名：ClientDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void ClientDataSelect()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtSearch())
            {
                return;
            }

            //検索ダイアログのフォームを作成
            f_SearchDialog = new F_SearchDialog();
            //検索ダイアログのフォームのオーナー設定
            f_SearchDialog.Owner = this;

            //検索ダイアログのフォームのボタンクリックイベントにハンドラを追加
            f_SearchDialog.btnAndSearchClick += SearchDialog_btnAndSearchClick;
            f_SearchDialog.btnOrSearchClick += SearchDialog_btnOrSearchClick;

            //検索ダイアログのフォームが閉じたときのイベントを設定
            f_SearchDialog.FormClosed += ChildForm_FormClosed;
            //検索ダイアログのフォームの表示
            f_SearchDialog.Show();

            //顧客登録フォームの透明化
            this.Opacity = 0;
        }
        ///////////////////////////////
        //メソッド名：GetValidDataAtSearch()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：検索入力データの形式チェック
        //         ：エラーがない場合True
        //         ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtSearch()
        {
            //検索条件の存在確認
            if (String.IsNullOrEmpty(txbEmployeeID.Text.Trim()) && dtpStartDate.Checked == false && dtpEndoDate.Checked == false)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeID.Focus();
                return false;
            }

            // 社員IDの適否
            if (!String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                // 社員IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbEmployeeID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //社員IDの重複チェック
                if (!employeeDataAccess.CheckEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("社員IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }

            return true;
        }
        ///////////////////////////////
        //メソッド名：LogSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：操作ログ情報検索の実行
        ///////////////////////////////
        private void LogSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listLog.Count;

            txbNumPage.Text = "1";

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：操作ログ情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strEmployeeID = txbEmployeeID.Text.Trim();
            int intEmployeeID = 0;

            if (!String.IsNullOrEmpty(strEmployeeID))
            {
                intEmployeeID = int.Parse(strEmployeeID);
            }

            DateTime? dateStart = null;

            if (dtpStartDate.Checked)
            {
                dateStart = dtpStartDate.Value.Date;
            }

            DateTime? dateEnd = null;

            if (dtpEndoDate.Checked)
            {
                dateEnd = dtpEndoDate.Value.Date;
            }

            // 検索条件のセット
            T_OperationLog selectCondition = new T_OperationLog()
            {
                EmID = intEmployeeID,
            };

            if (searchFlg)
            {
                // 操作ログデータのAnd抽出
                listLog = LogDataAccess.GetAndLogData(selectCondition);
            }
            else
            {
                // 操作ログデータのOr抽出
                listLog = LogDataAccess.GetOrLogData(selectCondition);
            }

            if (dtpStartDate.Checked == false && dtpEndoDate.Checked == false)
            {
                return;
            }

            listLog = LogDataAccess.GetDateLogData(listLog, dateStart, dateEnd);
        }

        private void btnPageMin_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            GetDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = (int.Parse(txbNumPage.Text.Trim()) - 1).ToString();

            GetDataGridView();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = (int.Parse(txbNumPage.Text.Trim()) + 1).ToString();

            GetDataGridView();
        }

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<T_OperationLog> viewLog = SetListLog();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewLog.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            GetDataGridView();
        }

        private void dgvOperationLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvOperationLog.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();
        }
        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            //データグリッドビューに乗っている情報をGUIに反映
            //txbEmployeeID.Text = dgvOperationLog[0, dgvOperationLog.CurrentCellAddress.Y].Value.ToString();
            txbEmployeeID.Text = dgvOperationLog[1, dgvOperationLog.CurrentCellAddress.Y].Value.ToString();
        }
        ///////////////////////////////
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {

            listEmployee = employeeDataAccess.GetEmployeeDspData();

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listEmployee)
            {
                dictionaryEmployee.Add(item.EmID, item.EmName);
            }
        }

        private void txbEmployeeID_TextChanged(object sender, EventArgs e)
        {
            //nullの確認
            string stringEmployeeID = txbEmployeeID.Text.Trim();
            int intEmployeeID = 0;

            if (!String.IsNullOrEmpty(stringEmployeeID))
            {
                intEmployeeID = int.Parse(stringEmployeeID);
            }

            //存在確認
            if (!employeeDataAccess.CheckEmployeeIDExistence(intEmployeeID))
            {
                txbEmployeeName.Text = "社員IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Employee = listEmployee.Single(x => x.EmID == intEmployeeID);

            txbEmployeeName.Text = Employee.EmName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctHint_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/document/d/1EZOZ5lLJvSLiC0PDFAzTtEPuf1iQJLLU/edit=true",
                UseShellExecute = true
            });
        }
    }
}

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
    public partial class F_HonshaOperationLog : Form
    {
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess LogDataAccess = new OperationLogDataAccess();
        //データグリッドビュー用の全操作ログデータ
        private static List<T_OperationLog> listAllLog = new List<T_OperationLog>();
        //データグリッドビュー用の操作ログデータ
        private static List<T_OperationLog> listLog = new List<T_OperationLog>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        public F_HonshaOperationLog()
        {
            InitializeComponent();
        }

        private void F_HonshaOperationLog_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

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
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
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
            dgvOperatinLog.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvOperatinLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvOperatinLog.AllowUserToResizeColumns = false;
            dgvOperatinLog.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvOperatinLog.MultiSelect = false;
            //セルの編集ができないように
            dgvOperatinLog.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvOperatinLog.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvOperatinLog.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvOperatinLog.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvOperatinLog.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOperatinLog.Columns.Add("OpHistoryID", "ログイン操作ID");
            dgvOperatinLog.Columns.Add("EmID", "社員ID");
            dgvOperatinLog.Columns.Add("FormName", "フォーム名");
            dgvOperatinLog.Columns.Add("OpDone", "操作内容");
            dgvOperatinLog.Columns.Add("OpDBID", "操作ID");
            dgvOperatinLog.Columns.Add("OpSetTime", "操作日時");

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvOperatinLog.Columns)
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
            dgvOperatinLog.Rows.Clear();

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
                dgvOperatinLog.Rows.Add(item.OpHistoryID, item.EmID, item.FormName, item.OpDone, item.OpDBID, item.OpSetTime);
            }

            //dgvClientをリフレッシュ
            dgvOperatinLog.Refresh();

            if (lastPage == pageNum)
            {
                btnPageMax.Visible = false;
                btnNext.Visible = false;
                btnPageMin.Visible = true;
                btnBack.Visible = true;
            }
            else if (pageNum == 0)
            {
                btnPageMax.Visible = true;
                btnNext.Visible = true;
                btnPageMin.Visible = false;
                btnBack.Visible = false;
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
            if (String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeID.Focus();
                return false;
            }

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
                if (!LogDataAccess.CheckClientIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }

            return true;
        }
    }
}

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
        //データグリッドビュー用の全顧客データ
        private static List<T_OperationLog> listAllLog = new List<T_OperationLog>();
        public F_HonshaOperationLog()
        {
            InitializeComponent();
        }

        private void F_HonshaOperationLog_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
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

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //顧客のデータを全取得
            listAllLog = LogDataAccess.GetLogData();

            //表示用の顧客リスト作成
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

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewLog = LogDataAccess.GetLogDspData(listViewLog);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewLog = LogDataAccess.GetLogNotDspData(listViewLog);
            }

            return listViewLog;
        }
    }
}

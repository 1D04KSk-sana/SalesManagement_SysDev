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
    public partial class F_HonshaClient : Form
    {
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の顧客データ
        private static List<M_Client> listClient = new List<M_Client>();

        public F_HonshaClient()
        {
            InitializeComponent();
        }

        private void F_HonshaClient_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///////////////////////////////
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの初期設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //読み取り専用に指定
            dgvClient.ReadOnly = true;
            //行内をクリックすることで行を選択
            dgvClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //ヘッダー位置の指定
            dgvClient.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            // 部署データの取得
            listClient = clientDataAccess.GetClientData();

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView()
        {
            //行単位で選択するようにする
            dgvClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvClient.AllowUserToResizeColumns = false;
            dgvClient.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvClient.MultiSelect = false;
            //セルの編集ができないように
            dgvClient.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvClient.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvClient.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvClient.AllowUserToAddRows = false;

            dgvClient.DataSource = listClient.ToList();

            //各列幅の指定
            dgvClient.Columns[0].Width = 40;
            dgvClient.Columns[1].Width = 70;
            dgvClient.Columns[2].Width = 70;
            dgvClient.Columns[3].Width = 60;
            dgvClient.Columns[4].Width = 60;
            dgvClient.Columns[5].Width = 70;
            dgvClient.Columns[6].Width = 60;
            dgvClient.Columns[7].Width = 60;
            dgvClient.Columns[8].Width = 100;

            dgvClient.Refresh();
        }
    }
}

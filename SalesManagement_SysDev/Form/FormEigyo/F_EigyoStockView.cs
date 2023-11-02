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
    public partial class F_EigyoStockView : Form
    {
        public F_EigyoStockView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlHonsha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblOrder_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_EigyoStockView_Load(object sender, EventArgs e)
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
            dgvStockView.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvStockView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvStockView.AllowUserToResizeColumns = false;
            dgvStockView.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvStockView.MultiSelect = false;
            //セルの編集ができないように
            dgvStockView.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvStockView.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvStockView.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvStockView.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvStockView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvStockView.Columns.Add("StID", "在庫ID");
            dgvStockView.Columns.Add("PrID", "商品ID");
            dgvStockView.Columns.Add("StQuantity", "在庫数");
            dgvStockView.Columns.Add("StFlags", "在庫管理フラグ");
         

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvStockView.Columns)
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
        private void SetDataGridView(List<T_Stock> viewStock)
        {
            //中身を消去
            dgvStockView.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewStock.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewStock.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvStockに挿入
            foreach (var item in depData)
            {
                dgvStockView.Rows.Add(item.StID,item.PrID,item.StQuantity,item.StFlag);
            }

            //dgvClientをリフレッシュ
            dgvStockView.Refresh();

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
            List<T_Stock> listViewStock = SetListStock();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewStock);
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
            List<M_Client> listViewClient = SetListClient();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewClient);
        }

        ///////////////////////////////
        //メソッド名：SetListClient()
        //引　数   ：なし
        //戻り値   ：表示用顧客データ
        //機　能   ：表示用顧客データの準備
        ///////////////////////////////
        private List<M_Client> SetListClient()
        {
            //顧客のデータを全取得
            listAllStock = stockDataAccess.GetClientData();

            //表示用の顧客リスト作成
            List<T_Stock> listViewStock = new List<T_Stock>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewStock = listStock;
            }
            else
            {
                //全データをとってくる
                listViewStock = listAllStock;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewStock = stockDataAccess.GetStockDspData(listViewStock);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewStock = stockDataAccess.GetStockNotDspData(listViewStock);
            }

            return listViewStock;
        }
    }

}

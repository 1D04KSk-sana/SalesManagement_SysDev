﻿using System;
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
        //データベース在庫テーブルアクセス用クラスのインスタンス化
        StockDataAccess stockDataAccess = new StockDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の全在庫データ
        private static List<T_Stock> listAllStock = new List<T_Stock>();
        //データグリッドビュー用の在庫データ
        private static List<T_Stock> listStock = new List<T_Stock>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        public F_EigyoStockView()
        {
            InitializeComponent();
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
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
        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            StockSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            StockSearchButtonClick(false);
        }

        private void F_EigyoStockView_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();




            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                StockDataSelect();
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
            GetDataGridView();
        }
        ///////////////////////////////
        //メソッド名：StockDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：在庫情報検索の実行
        ///////////////////////////////
        private void StockDataSelect()
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
            if (String.IsNullOrEmpty(txbstockID.Text.Trim()) && String.IsNullOrEmpty(txbstockID.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbstockID.Focus();
                return false;
            }

            // 在庫IDの適否
            if (!String.IsNullOrEmpty(txbstockID.Text.Trim()))
            {
                // 在庫IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbstockID.Text.Trim()))
                {
                    MessageBox.Show("在庫IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbstockID.Focus();
                    return false;
                }
                //在庫IDの重複チェック
                if (!stockDataAccess.CheckstockIDExistence(int.Parse(txbstockID.Text.Trim())))
                {
                    MessageBox.Show("在庫IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbstockID.Focus();
                    return false;
                }
            }
            // 商品IDの適否
            if (!String.IsNullOrEmpty(txbProdactID.Text.Trim()))
            {
                // 商品IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbProdactID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactID.Focus();
                    return false;
                }
                //商品IDの重複チェック
                if (!prodactDataAccess.CheckProdactIDExistence(int.Parse(txbProdactID.Text.Trim())))
                {
                    MessageBox.Show("商品IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactID.Focus();
                    return false;
                }
            }
            // 在庫数の適否
            if (!String.IsNullOrEmpty(txbstocknum.Text.Trim()))
            {
                // 在庫数の数字チェック
                if (!dataInputCheck.CheckNumeric(txbstocknum.Text.Trim()))
                {
                    MessageBox.Show("在庫数は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbstocknum.Focus();
                    return false;
                }
            }

            return true;
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
                dgvStockView.Rows.Add(item.StID, item.PrID, item.StQuantity, item.StFlag);
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
            //表示用の在庫リスト作成
            List<T_Stock> listViewStock = SetListStock();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewStock);
        }

        ///////////////////////////////
        //メソッド名：SetListStock()
        //引　数   ：なし
        //戻り値   ：表示用在庫ｓデータ
        //機　能   ：表示用在庫データの準備
        ///////////////////////////////
        private List<T_Stock> SetListStock()
        {
            //在庫のデータを全取得
            listAllStock = stockDataAccess.GetStockData();

            //表示用の在庫リスト作成
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
                // 管理Flgが表示の在庫データの取得
                listViewStock = stockDataAccess.GetStockDspData(listViewStock);
            }
            else
            {
                // 管理Flgが非表示の在庫データの取得
                listViewStock = stockDataAccess.GetStockNotDspData(listViewStock);
            }

            return listViewStock;
        }
        ///////////////////////////////
        //メソッド名：StockSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：在庫情報検索の実行
        ///////////////////////////////
        private void StockSearchButtonClick(bool searchFlg)
        {
            // 在庫情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listStock.Count;

            // 在庫抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：在庫情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strStockID = txbstockID.Text.Trim();
            int intStockID = 0;

            if (!String.IsNullOrEmpty(strStockID))
            {
                intStockID = int.Parse(strStockID);
            }
            string strProdactID = txbProdactID.Text.Trim();
            int intProdactID = 0;

            if (!String.IsNullOrEmpty(strProdactID))
            {
                intProdactID = int.Parse(strProdactID);
            }
            string strtocknum = txbstocknum.Text.Trim();
            int intstocknum = 0;

            if (!String.IsNullOrEmpty(strtocknum))
            {
                intstocknum = int.Parse(strtocknum);
            }

            // 検索条件のセット
            T_Stock selectCondition = new T_Stock()
            {
                StID = intStockID,
                //ClName = txbClientName.Text.Trim()
                //SoID = cmbSalesOfficeID.SelectedIndex + 1,
                PrID = intProdactID,
                StQuantity = intstocknum,
                //ClAddress= txbClientAddress.Text.Trim(),
                //ClFAX=txbClientFax.Text.Trim(),
                //ClHidden=txbHidden.Text.Trim()
            };

            if (searchFlg)
            {
                // 在庫データのAnd抽出
                listStock = stockDataAccess.GetAndStockData(selectCondition);
            }
            else
            {
                // 在庫データのOr抽出
                listStock = stockDataAccess.GetOrStockData(selectCondition);
            }
        }

        private void rdbSearch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}

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
        //コンボボックス用の社員データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //DataGridView用に使用する商品のDictionary
        private Dictionary<int, string> dictionaryProdact;
        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };


        public F_EigyoStockView()
        {
            InitializeComponent();
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("本当に閉じますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            Application.Exit();
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
            DictionarySet();

            SetFormDataGridView();
            GetDataGridView();
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                StockDataSelect();
            }

            //発注点検索ラヂオボタンがチェックされているとき
            if (rdbHattyuten.Checked)
            {
                StockDataHattyuten();
            }
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

            // テキストボックスに入力されている値を取得
            string inputText = textBox.Text + e.KeyChar;

            // 8文字を超える場合は入力を許可しない
            if (inputText.Length > 8 && e.KeyChar != '\b')
            {
                MessageBox.Show("入力された数字が大きすぎます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
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

            dgvStockView.Columns.Add("PrID", "商品ID");
            dgvStockView.Columns.Add("PrName", "商品名");
            dgvStockView.Columns.Add("StQuantity", "在庫数");
            dgvStockView.Columns.Add("PrSafetyStock", "安全在庫数");

            dgvStockView.Columns["PrID"].Width = 475;
            dgvStockView.Columns["PrName"].Width = 475;
            dgvStockView.Columns["StQuantity"].Width = 475;
            dgvStockView.Columns["PrSafetyStock"].Width = 475;

            dgvStockView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(96)))), ((int)(((byte)(54)))));
            dgvStockView.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvStockView.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        ///////////////////////////////
        //メソッド名：StockDataHattyuten()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：在庫情報更新の実行
        ///////////////////////////////
        private void StockDataHattyuten()
        {
            listAllStock = stockDataAccess.GetStockData();

            listStock = new List<T_Stock> { };

            foreach (var item in listAllStock)
            {
                M_Product Prodact = prodactDataAccess.GetIDProdactData(item.PrID);

                if (item.StQuantity <= Prodact.PrSafetyStock)
                {
                    listStock.Add(item);
                }
            }

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
            if (String.IsNullOrEmpty(txbProductID.Text.Trim()) && String.IsNullOrEmpty(txbStockQuantity.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProductID.Focus();
                return false;
            }

            //商品IDの適否
            if (!String.IsNullOrEmpty(txbProductID.Text.Trim()))
            {
                //商品IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbProductID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProductID.Focus();
                    return false;
                }
                //商品IDの重複チェック
                if (!prodactDataAccess.CheckProdactIDExistence(int.Parse(txbProductID.Text.Trim())))
                {
                    MessageBox.Show("商品IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProductID.Focus();
                    return false;
                }
            }

            //在庫数の適否
            if (!String.IsNullOrEmpty(txbStockQuantity.Text.Trim()))
            {
                // 在庫数の数字チェック
                if (!dataInputCheck.CheckNumeric(txbStockQuantity.Text.Trim()))
                {
                    MessageBox.Show("在庫数は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbStockQuantity.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("在庫数が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbStockQuantity.Focus();
                return false;
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

            depData.Reverse();

            //1行ずつdgvStockに挿入
            foreach (var item in depData)
            {
                M_Product Prodact = prodactDataAccess.GetIDProdactData(item.PrID);

                dgvStockView.Rows.Add(item.PrID, dictionaryProdact[item.PrID], item.StQuantity, Prodact.PrSafetyStock);
            }

            //dgvClientをリフレッシュ
            dgvStockView.Refresh();

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
            if (txbPageSize.Text.Trim() == string.Empty)
            {
                txbPageSize.Text = "1";
            }

            //表示用の在庫リスト作成
            List<T_Stock> listViewStock = SetListStock();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewStock);
        }

        ///////////////////////////////
        //メソッド名：SetListStock()
        //引　数   ：なし
        //戻り値   ：表示用在庫データ
        //機　能   ：表示用在庫データの準備
        ///////////////////////////////
        private List<T_Stock> SetListStock()
        {
            //在庫のデータを全取得
            listAllStock = stockDataAccess.GetStockData();

            //表示用の在庫リスト作成
            List<T_Stock> listViewStock = new List<T_Stock>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked || rdbHattyuten.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewStock = listStock;
            }
            else
            {
                //全データをとってくる
                listViewStock = listAllStock;
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

            txbNumPage.Text = "1";

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
            string strProductID = txbProductID.Text.Trim();
            int intProdactID = 0;

            if (!String.IsNullOrEmpty(strProductID))
            {
                intProdactID = int.Parse(strProductID);
            }

            string strStockQuentity = txbStockQuantity.Text.Trim();
            int intStockQuentity = 0;

            if (!String.IsNullOrEmpty(strStockQuentity))
            {
                intStockQuentity = int.Parse(strStockQuentity);
            }

            // 検索条件のセット
            T_Stock selectStock = new T_Stock()
            {
                PrID = intProdactID,
                StQuantity = intStockQuentity,
            };

            if (searchFlg)
            {
                // 顧客データのAnd抽出
                listStock = stockDataAccess.GetAndStockData(selectStock);
            }
            else
            {
                // 顧客データのOr抽出
                listStock = stockDataAccess.GetOrStockData(selectStock);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            {
                List<T_Stock> viewStock = SetListStock();

                //ページ行数を取得
                int pageSize = int.Parse(txbPageSize.Text.Trim());
                //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
                int lastPage = (int)Math.Ceiling(viewStock.Count / (double)pageSize);

                txbNumPage.Text = lastPage.ToString();

                GetDataGridView();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = (int.Parse(txbNumPage.Text.Trim()) + 1).ToString();

            GetDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = (int.Parse(txbNumPage.Text.Trim()) - 1).ToString();

            GetDataGridView();
        }

        private void btnPageMin_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            GetDataGridView();
        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            GetDataGridView();
        }

        private void txbProdactID_TextChanged(object sender, EventArgs e)
        {
            //nullの確認
            string stringProdactID = txbProductID.Text.Trim();
            int intProdactID = 0;

            if (!String.IsNullOrEmpty(stringProdactID))
            {
                intProdactID = int.Parse(stringProdactID);
            }

            //存在確認
            if (!prodactDataAccess.CheckProdactIDExistence(intProdactID))
            {
                txbProductName.Text = "商品IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Prodact = listProdact.Single(x => x.PrID == intProdactID);

            txbProductName.Text = Prodact.PrName;
        }
        ///////////////////////////////
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {

            //商品のデータを取得
            listProdact = prodactDataAccess.GetProdactDspData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listProdact)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
            }
        }

        private void dgvStockView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvStockView.SelectedCells.Count == 0)
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
            txbProductID.Text = dgvStockView[0, dgvStockView.CurrentCellAddress.Y].Value.ToString();
            txbStockQuantity.Text = dgvStockView[2, dgvStockView.CurrentCellAddress.Y].Value.ToString();
        }

        private void pctHint_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/document/d/1x5e-cyn25BCmNneXa8iYbhvX_WtcsflB",
                UseShellExecute = true
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbSearch.Checked = false;
            rdbHattyuten.Checked = false;

            txbNumPage.Text = "1";

            GetDataGridView();
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                txbProductID.Enabled = true;
                txbStockQuantity.Enabled = true;

            }

            if (rdbHattyuten.Checked)
            {
                txbProductID.Enabled = false;
                txbStockQuantity.Enabled = false;
            }
        }

        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbProductID.Text = string.Empty;
            txbStockQuantity.Text = string.Empty;
        }

    }
}

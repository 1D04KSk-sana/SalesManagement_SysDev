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
    public partial class F_ButuryuStock : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //データベース在庫テーブルアクセス用クラスのインスタンス化
        StockDataAccess stockDataAccess = new StockDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //コンボボックス用の商品データリスト
        private static List<T_Stock> listStock = new List<T_Stock>();
        //コンボボックス用の商品データリスト
        private static List<M_Product> listProduct = new List<M_Product>();
        //データグリッドビュー用の全商品データ
        private static List<T_Stock> listAllStock = new List<T_Stock>();
        //DataGridView用に使用する商品のDictionary
        private Dictionary<int, string> dictionaryProdact;

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };

        public F_ButuryuStock()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbUpdate.Checked = true;

            txbNumPage.Text = "1";

            GetDataGridView();
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
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
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
            List<T_Stock> viewStock = SetListStock();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewStock.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
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
        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvStock.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();
        }
        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbStockQuentity.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbProdactName.Text = string.Empty;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                StockDataUpdate();
            }

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

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {

            }

            if (rdbUpdate.Checked)
            {

            }

            if (rdbHattyuten.Checked)
            {

            }
        }

        private void F_ButuryuStock_Load(object sender, EventArgs e)
        {
            rdbUpdate.Checked = true;
            
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            DictionarySet();
            SetFormDataGridView();
            GetDataGridView();
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
            listProduct = prodactDataAccess.GetProdactDspData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listProduct)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
            }
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
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "在庫管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbProductID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }
        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の商品リスト作成
            List<T_Stock> listViewStock = SetListStock();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewStock);
        }
        ///////////////////////////////
        //メソッド名：SetListStock()
        //引　数   ：なし
        //戻り値   ：表示用商品データ
        //機　能   ：表示用商品データの準備
        ///////////////////////////////
        private List<T_Stock> SetListStock()
        {
            //商品のデータを全取得
            listAllStock = stockDataAccess.GetStockData();

            //表示用の商品リスト作成
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
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Stock> viewStock)
        {
            //中身を消去
            dgvStock.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewStock.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewStock.Skip(pageSize * pageNum).Take(pageSize).ToList();

            depData.Reverse();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                M_Product Prodact = prodactDataAccess.GetIDProdactData(item.PrID);

                dgvStock.Rows.Add(item.PrID, dictionaryProdact[item.PrID], item.StQuantity, Prodact.PrSafetyStock);
            }

            //dgvStockをリフレッシュ
            dgvStock.Refresh();

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
        //メソッド名：StockDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：在庫情報更新の実行
        ///////////////////////////////
        private void StockDataUpdate()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtUpdate())
            {
                return;
            }

            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("更新しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //操作ログデータ取得
            var regOperationLog = GenerateLogAtRegistration(rdbUpdate.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 発注情報作成
            var updStock = GenerateDataAtUpdate();

            // 発注情報更新
            UpdateStock(updStock);
        }

        ///////////////////////////////
        //メソッド名：GetValidDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：更新入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtUpdate()
        {
            //商品IDの適否
            if (!String.IsNullOrEmpty(txbProductID.Text.Trim()))
            {
                // 商品IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbProductID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProductID.Focus();
                    return false;
                }
                //商品IDの存在チェック
                if (!prodactDataAccess.CheckProdactIDExistence(int.Parse(txbProductID.Text.Trim())))
                {
                    MessageBox.Show("商品IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProductID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("商品IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProductID.Focus();
                return false;
            }

            //在庫数の適否
            if (!String.IsNullOrEmpty(txbStockQuentity.Text.Trim()))
            {
                // 在庫数の数字チェック
                if (!dataInputCheck.CheckNumeric(txbStockQuentity.Text.Trim()))
                {
                    MessageBox.Show("在庫数は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbStockQuentity.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("在庫数が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbStockQuentity.Focus();
                return false;
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：在庫更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private T_Stock GenerateDataAtUpdate()
        {
            return new T_Stock
            {
                PrID = int.Parse(txbProductID.Text.Trim()),
                StQuantity = int.Parse(txbStockQuentity.Text.Trim()),
            };
        }

        ///////////////////////////////
        //メソッド名：UpdateStock()
        //引　数   ：在庫情報
        //戻り値   ：なし
        //機　能   ：在庫情報の更新
        ///////////////////////////////
        private void UpdateStock(T_Stock updHattyu)
        {
            // 在庫情報の更新
            bool flg = stockDataAccess.UpdateStockData(updHattyu);

            if (flg == true)
            {
                MessageBox.Show("更新しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("更新に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //テキストボックス等のクリア
            ClearImput();

            // データグリッドビューの表示
            GetDataGridView();
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
            if (String.IsNullOrEmpty(txbProductID.Text.Trim()) && String.IsNullOrEmpty(txbStockQuentity.Text.Trim()))
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
            if (!String.IsNullOrEmpty(txbStockQuentity.Text.Trim()))
            {
                // 在庫数の数字チェック
                if (!dataInputCheck.CheckNumeric(txbStockQuentity.Text.Trim()))
                {
                    MessageBox.Show("在庫数は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbStockQuentity.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("在庫数が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbStockQuentity.Focus();
                return false;
            }

            return true;
        }
        ///////////////////////////////
        //メソッド名：StockSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：受注情報検索の実行
        ///////////////////////////////
        private void StockSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listStock.Count;

            txbNumPage.Text = "1";

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：受注情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strProductID = txbProductID.Text.Trim();
            int intProdactID = 0;

            if (!String.IsNullOrEmpty(strProductID))
            {
                intProdactID = int.Parse(strProductID);
            }

            string strStockQuentity = txbStockQuentity.Text.Trim();
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
        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            //データグリッドビューに乗っている情報をGUIに反映
            txbProductID.Text = dgvStock[0, dgvStock.CurrentCellAddress.Y].Value.ToString();
            txbStockQuentity.Text = dgvStock[2, dgvStock.CurrentCellAddress.Y].Value.ToString();
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
            dgvStock.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvStock.MultiSelect = false;
            //セルの編集ができないように
            dgvStock.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvStock.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvStock.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvStock.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvStock.Columns.Add("PrID", "商品ID");
            dgvStock.Columns.Add("PrName", "商品名");
            dgvStock.Columns.Add("StQuantity", "在庫数");
            dgvStock.Columns.Add("PrSafetyStock", "安全在庫数");

            dgvStock.Columns["PrID"].Width = 475;
            dgvStock.Columns["PrName"].Width = 475;
            dgvStock.Columns["StQuantity"].Width = 475;
            dgvStock.Columns["PrSafetyStock"].Width = 475;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvStock.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void txbProductID_TextChanged(object sender, EventArgs e)
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
                txbProdactName.Text = "商品IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Prodact = listProduct.Single(x => x.PrID == intProdactID);

            txbProdactName.Text = Prodact.PrName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("本当に閉じますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            Application.Exit();
        }

        private void pctHint_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/document/d/1uhR5cLzstFzykefN7f-r67N1qg6Ox-Vs",
                UseShellExecute = true
            });
         }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            GetDataGridView();
        }

        private void btnProdactView_Click(object sender, EventArgs e)
        {
            ProdactView prodactView = new ProdactView();

            prodactView.Owner = this;
            prodactView.FormClosed += ChildForm_FormClosed;
            prodactView.Show();

            this.Opacity = 0;
        }
    }
}

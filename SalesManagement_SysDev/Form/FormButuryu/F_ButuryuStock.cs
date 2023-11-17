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
    public partial class F_ButuryuStock : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //コンボボックス用の商品データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //データグリッドビュー用の全商品データ
        private static List<M_Product> listAllProdact = new List<M_Product>();
        //DataGridView用に使用する商品のDictionary
        private Dictionary<int, string> dictionaryProdact;

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
        }
        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ProductSearchButtonClick(true);
        }
        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ProductSearchButtonClick(false);
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }
        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbStockID.Text = string.Empty;
            txbStockQuentity.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbProdactName.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
            cmbView.SelectedIndex = -1;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                StockDataRegister();
            }
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                StockDataSelect();
            }
        }
        ///////////////////////////////
        //メソッド名：StockDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：在庫情報登録の実行
        ///////////////////////////////
        private void StockDataRegister()
        {
            //入力情報適否
            if (!GetValidDataAtRegistration())
            {
                return;
            }

            //操作ログデータ取得
            var regOperationLog = GenerateLogAtRegistration(rdbRegister.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 受注情報作成
            var regProduct = GenerateDataAtRegistration();

            // 受注情報登録
            RegistrationProduct(regProduct);
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
            //在庫IDの適否
            if (!String.IsNullOrEmpty(txbStockID.Text.Trim()))
            {
                //受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbStockID.Text.Trim()))
                {
                    MessageBox.Show("在庫IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbStockID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (orderDataAccess.CheckOrderIDExistence(int.Parse(txbStockID.Text.Trim())))
                {
                    MessageBox.Show("在庫IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbStockID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("在庫IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbStockID.Focus();
                return false;
            }
            //表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示/非表示が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
                return false;
            }

            return true;
        }

        private void F_ButuryuStock_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            //cmbViewを表示に
            //cmbView.SelectedIndex = 0;
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
                OpDBID = int.Parse(txbStockID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }
        ///////////////////////////////
        //メソッド名：RegistrationOrder()
        //引　数   ：受注情報
        //戻り値   ：なし
        //機　能   ：受注データの登録
        ///////////////////////////////
        private void RegistrationProduct(M_Product regProduct)
        {
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            // 受注情報の登録
            bool flg = prodactDataAccess.AddProductData(regProduct);

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
            ClearImputDetail();

            // データグリッドビューの表示
            GetDataGridView();
        }
        ///////////////////////////////
        //メソッド名：ClearImputDetail()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールのクリア(Detail)
        ///////////////////////////////
        private void ClearImputDetail()
        {
            txbStockID.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbProdactName.Text = string.Empty;
            txbStockQuentity.Text = string.Empty;
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
            List<M_Product> listViewProduct = SetListProduct();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewProduct);
        }
        ///////////////////////////////
        //メソッド名：SetListProduct()
        //引　数   ：なし
        //戻り値   ：表示用商品データ
        //機　能   ：表示用商品データの準備
        ///////////////////////////////
        private List<M_Product> SetListProduct()
        {
            //商品のデータを全取得
            listAllProdact = prodactDataAccess.GetProdactData();

            //表示用の商品リスト作成
            List<M_Product> listViewProduct = new List<M_Product>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewProduct = listProdact;
            }
            else
            {
                //全データをとってくる
                listViewProduct = listAllProdact;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewProduct = prodactDataAccess.GetProdactDspData(listViewProduct);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewProduct = prodactDataAccess.GetProdactNotDspData(listViewProduct);
            }

            return listViewProduct;
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_Product> viewProduct)
        {
            //中身を消去
            dgvStock.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewProduct.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewProduct.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvStock.Rows.Add(item.PrID, item.PrName);
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
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：受注登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Product GenerateDataAtRegistration()
        {
            return new M_Product
            {
                //PrID = int.Parse(txbProductID.Text.Trim()),
                //SoID = cmbSalesOfficeID.SelectedIndex + 1,
                //EmID = F_Login.intEmployeeID,
                //PrName = ProdactDataAccess.GetProdactID(txbProdactName.Text.Trim()),
                //ClCharge = txbOrderManager.Text.Trim(),
                //OrDate = dtpOrderDate.Value,
                //OrStateFlag = 0,
                //OrFlag = cmbHidden.SelectedIndex,
                //OrHidden = txbHidden.Text.Trim().
            };
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
            if (String.IsNullOrEmpty(txbStockID.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbStockID.Focus();
                return false;
            }

            //在庫IDの適否
            if (!String.IsNullOrEmpty(txbStockID.Text.Trim()))
            {
                //在庫IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbStockID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbStockID.Focus();
                    return false;
                }
                //在庫IDの重複チェック
                if (!prodactDataAccess.CheckProductIDExistence(int.Parse(txbStockID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbStockID.Focus();
                    return false;
                }
            }

            //商品IDの適否
            if (!String.IsNullOrEmpty(txbProductID.Text.Trim()))
            {
                //商品IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbProductID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProductID.Focus();
                    return false;
                }
                //商品IDの重複チェック
                if (!prodactDataAccess.CheckProductIDExistence(int.Parse(txbProductID.Text.Trim())))
                {
                    MessageBox.Show("社員IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProductID.Focus();
                    return false;
                }
            }
            return true;
        }
        ///////////////////////////////
        //メソッド名：ProductSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：受注情報検索の実行
        ///////////////////////////////
        private void ProductSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listProdact.Count;

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
            string strStockID = txbStockID.Text.Trim();
            int intStockID = 0;

            if (!String.IsNullOrEmpty(strStockID))
            {
                intStockID = int.Parse(strStockID);
            }

            string strProductID = txbProductID.Text.Trim();
            int intProdactID = 0;

            if (!String.IsNullOrEmpty(strProductID))
            {
                intProdactID = int.Parse(strProductID);
            }

            // 検索条件のセット
            M_Product selectProdact = new M_Product()
            {
                //PrID = intProdactID,
                //SoID = cmbSalesOfficeID.SelectedIndex + 1,
                //StID = intStockID,
                //ClID = intClientID,
            };

            if (searchFlg)
            {
                // 顧客データのAnd抽出
                listProdact = prodactDataAccess.GetAndProdactData(selectProdact);
            }
            else
            {
                // 顧客データのOr抽出
                listProdact = prodactDataAccess.GetOrProdactData(selectProdact);
            }
        }
        ///////////////////////////////
        //メソッド名：OrderSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：受注情報検索の実行
        ///////////////////////////////
        private void ProductSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listProdact.Count;

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

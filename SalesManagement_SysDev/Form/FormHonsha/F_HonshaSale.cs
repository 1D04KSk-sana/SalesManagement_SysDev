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
    public partial class F_HonshaSale : Form
    {
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース売上テーブルアクセス用クラスのインスタンス化
        SaleDataAccess saleDataAccess = new SaleDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //データベース売上詳細テーブルアクセス用クラスのインスタンス化
        SaleDetailDataAccess saleDetailDataAccess = new SaleDetailDataAccess();
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //データグリッドビュー用の売上データ
        private static List<T_Sale> listSale = new List<T_Sale>();
        //データグリッドビュー用の全売上データ
        private static List<T_Sale> listAllSale = new List<T_Sale>();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //データグリッドビュー用の売上詳細データ
        private static List<T_SaleDetail> listSaleDetail = new List<T_SaleDetail>();
        //コンボボックス用の顧客データリスト
        private static List<M_Client> listClient = new List<M_Client>();
        //コンボボックス用の商品データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //DataGridView用に使用する顧客のDictionary
        private Dictionary<int, string> dictionaryClient;
        //DataGridView用に使用す営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;
        //DataGridView用に使用す商品のDictionary
        private Dictionary<int, string> dictionaryProdact;

        //データグリッドビュー用の営業所データリスト
        private static List<M_SalesOffice> listDGVSalesOfficeID = new List<M_SalesOffice>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Client> listDGVClientID = new List<M_Client>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Employee> listDGVEmployeeID = new List<M_Employee>();

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        public F_HonshaSale()
        {
            InitializeComponent();
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

        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            SaleSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            SaleSearchButtonClick(false);
        }
        ///////////////////////////////
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {
            //営業所のデータを取得
            listSalesOffice = salesOfficeDataAccess.GetSalesOfficeDspData();

            //データグリッドビュー用の営業所のデータを取得
            listDGVSalesOfficeID = salesOfficeDataAccess.GetSalesOfficeData();

            dictionarySalesOffice = new Dictionary<int, string> { };

            foreach (var item in listDGVSalesOfficeID)
            {
                dictionarySalesOffice.Add(item.SoID, item.SoName);
            }

            listClient = clientDataAccess.GetClientDspData();

            listDGVClientID = clientDataAccess.GetClientData();

            dictionaryClient = new Dictionary<int, string> { };

            foreach (var item in listDGVClientID)
            {
                dictionaryClient.Add(item.ClID.Value, item.ClName);
            }

            listProdact = prodactDataAccess.GetProdactData();

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
                FormName = "売上管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbSaleID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }


        ///////////////////////////////
        //メソッド名：SaleSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：売上情報検索の実行
        ///////////////////////////////
        private void SaleSearchButtonClick(bool searchFlg)
        {
            //  売上情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listSale.Count;

            txbNumPage.Text = "1";

            // 売上抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：売上情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strSaleID = txbSaleID.Text.Trim();
            int intSaleID = 0;

            if (!String.IsNullOrEmpty(strSaleID))
            {
                intSaleID = int.Parse(strSaleID);
            }
            string strtxbClientPostal = txbChumonID.Text.Trim();
            int inttxbClientPostal = 0;

            if (!String.IsNullOrEmpty(strtxbClientPostal))
            {
                inttxbClientPostal = int.Parse(strtxbClientPostal);
            }
            string strtxbClientID = txbClientID.Text.Trim();
            int inttxbClientID = 0;

            if (!String.IsNullOrEmpty(strtxbClientID))
            {
                inttxbClientID = int.Parse(strtxbClientID);
            }

            DateTime? dateSale = null;

            if (dtpSaleDate.Checked)
            {
                dateSale = dtpSaleDate.Value;
            }

            // 検索条件のセット
            T_Sale selectCondition = new T_Sale()
            {
                SaID = intSaleID,
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                ChID = inttxbClientPostal,
                ClID= inttxbClientID,
                SaDate = dateSale,
            };

            if (searchFlg)
            {
                // 売上データのAnd抽出
                listSale = saleDataAccess.GetAndSaleData(selectCondition);
            }
            else
            {
                // 売上データのOr抽出
                listSale = saleDataAccess.GetOrSaleData(selectCondition);
            }
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void F_HonshaSale_Load(object sender, EventArgs e)
        {
            rdbHiddenUpdate.Checked = true;
            
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";
            DictionarySet();
            SetFormDataGridView();

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
            dgvSale.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvSale.AllowUserToResizeColumns = false;
            dgvSale.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvSale.MultiSelect = false;
            //セルの編集ができないように
            dgvSale.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvSale.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvSale.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvSale.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvSale.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSale.Columns.Add("SaID", "売上ID");
            dgvSale.Columns.Add("ClID", "顧客名");
            dgvSale.Columns.Add("SoID", "営業所名");
            dgvSale.Columns.Add("EmID", "受注社員ID");
            dgvSale.Columns.Add("ChID", "受注ID");
            dgvSale.Columns.Add("SaDate", "売上日時");
            dgvSale.Columns.Add("SaFlag", "管理フラグ");
            dgvSale.Columns.Add("SaHidden", "非表示理由");

            dgvSale.Columns["SaID"].Width = 92;
            dgvSale.Columns["ClID"].Width = 130;
            dgvSale.Columns["SoID"].Width = 145;
            dgvSale.Columns["EmID"].Width = 150;
            dgvSale.Columns["ChID"].Width = 110;
            dgvSale.Columns["SaDate"].Width = 160;
            dgvSale.Columns["SaFlag"].Width = 120;
            dgvSale.Columns["SaHidden"].Width = 280;

            dgvSale.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(69)))));
            dgvSale.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvSale.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvSaleDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvSaleDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvSaleDetail.AllowUserToResizeColumns = false;
            dgvSaleDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvSaleDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvSaleDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvSaleDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvSaleDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvSaleDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvSaleDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSaleDetail.Columns.Add("SaID", "売上ID");
            dgvSaleDetail.Columns.Add("SaDetailID", "売上明細ID");
            dgvSaleDetail.Columns.Add("PrID", "商品ID");
            dgvSaleDetail.Columns.Add("SaQuantity", "個数");
            dgvSaleDetail.Columns.Add("SaTotalPrice", "合計金額");

            dgvSaleDetail.Columns["SaID"].Width = 120;
            dgvSaleDetail.Columns["SaDetailID"].Width = 150;
            dgvSaleDetail.Columns["PrID"].Width = 120;
            dgvSaleDetail.Columns["SaQuantity"].Width = 120;
            dgvSaleDetail.Columns["SaTotalPrice"].Width = 187;

            dgvSaleDetail.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(69)))));
            dgvSaleDetail.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvSaleDetail.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                SaleDataSelect();
            }
            //表示更新ラヂオボタンがチェックされているとき
            if (rdbHiddenUpdate.Checked)
            {
                SaleDataHiddenUpdate();
            }
        }

        ///////////////////////////////
        //メソッド名：SaleDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   売上情報検索の実行
        ///////////////////////////////
        private void SaleDataSelect()
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

            //売上登録フォームの透明化
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
            if (String.IsNullOrEmpty(txbSaleID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbChumonID.Text.Trim()) && String.IsNullOrEmpty(txbClientName.Text.Trim()) && dtpSaleDate.Checked == false)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSaleID.Focus();
                return false;
            }

            // 売上IDの適否
            if (!String.IsNullOrEmpty(txbSaleID.Text.Trim()))
            {
                // 売上IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSaleID.Text.Trim()))
                {
                    MessageBox.Show("売上IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSaleID.Focus();
                    return false;
                }
                //売上IDの重複チェック
                if (!saleDataAccess.CheckSaleIDExistence(int.Parse(txbSaleID.Text.Trim())))
                {
                    MessageBox.Show("売上IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSaleID.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
            dtpSaleDate.Checked = false;

            rdbHiddenUpdate.Checked = true;

            txbNumPage.Text = "1";

            GetDataGridView();
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                txbChumonID.Enabled = true;
                txbClientID.Enabled = true;
                txbSaleID.Enabled = true;
                cmbSalesOfficeID.Enabled = true;
                dtpSaleDate.Enabled = true;
                cmbHidden.Enabled = false;
                txbHidden.Enabled = false;
            }
            if (rdbHiddenUpdate.Checked)
            {
                txbChumonID.Enabled = false;
                txbClientID.Enabled = false;
                txbSaleID.Enabled = true;
                cmbSalesOfficeID.Enabled = false;
                dtpSaleDate.Enabled = false;
                cmbHidden.Enabled = true;
                txbHidden.Enabled = true;
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
            txbSaleID.Text = string.Empty;
            txbClientID.Text = string.Empty;
            txbClientName.Text = string.Empty;
            txbChumonID.Text = string.Empty;
            txbChumonID.Text = string.Empty;
            dtpSaleDate.Value= DateTime.Now;
            cmbSalesOfficeID.SelectedIndex = -1;
            cmbHidden.SelectedIndex = -1;
            txbHidden.Text = string.Empty;
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

            //表示用の売上リスト作成
            List<T_Sale> listViewSale = SetListSale();

            List<T_SaleDetail> listSaleDetail = saleDetailDataAccess.GetSaleDetailData();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewSale,listSaleDetail);
        }

        ///////////////////////////////
        //メソッド名：SetListSale()
        //引　数   ：なし
        //戻り値   ：表示用売上データ
        //機　能   ：表示用売上データの準備
        ///////////////////////////////
        private List<T_Sale> SetListSale()
        {
            //売上のデータを全取得
            listAllSale = saleDataAccess.GetSaleData();

            //表示用の売上リスト作成
            List<T_Sale> listViewSale = new List<T_Sale>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewSale = listSale;
            }
            else
            {
                //全データをとってくる
                listViewSale = listAllSale;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の売上データの取得
                listViewSale = saleDataAccess.GetSaleDspData(listViewSale);
            }
            else
            {
                // 管理Flgが非表示の売上データの取得
                listViewSale = saleDataAccess.GetSaleNotDspData(listViewSale);
            }

            return listViewSale;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Sale> viewSale,List<T_SaleDetail> viewSaleDetail)
        {
            viewSale.Reverse();

            //中身を消去
            dgvSale.Rows.Clear();
            //中身を消去
            dgvSaleDetail.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewSale.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewSale.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvSale.Rows.Add(item.SaID, dictionaryClient[item.ClID], dictionarySalesOffice[item.SoID], item.EmID, item.ChID, item.SaDate, dictionaryHidden[item.SaFlag], item.SaHidden);
            }

            //dgvClientをリフレッシュ
            dgvSale.Refresh();


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
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            bool cmbflg = false;
            int intSalesOfficeID = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvSale[2, dgvSale.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listSalesOffice)
            {
                if (intSalesOfficeID == item.SoID)
                {
                    cmbflg = true;
                }
            }

            if (cmbflg)
            {
                cmbSalesOfficeID.SelectedValue = intSalesOfficeID;
            }
            else
            {
                cmbSalesOfficeID.SelectedIndex = -1;
            }

            bool cmbClientflg = false;
            string strClientID = (dictionaryClient.FirstOrDefault(x => x.Value == dgvSale[1, dgvSale.CurrentCellAddress.Y].Value.ToString()).Key).ToString(); ;
            foreach (var item in listDGVClientID)
            {
                if (strClientID == item.SoID.ToString())
                {
                    cmbClientflg = true;
                }
            }

            if (cmbClientflg)
            {
                txbClientID.Text = strClientID;
            }
            else
            {
                txbClientID.Text = string.Empty;
            }

            //データグリッドビューに乗っている情報をGUIに反映
            txbSaleID.Text = dgvSale[0, dgvSale.CurrentCellAddress.Y].Value.ToString();
            txbChumonID.Text = dgvSale[4, dgvSale.CurrentCellAddress.Y].Value.ToString();
            dtpSaleDate.Text = dgvSale[5, dgvSale.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvSale[6, dgvSale.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvSale[7, dgvSale.CurrentCellAddress.Y]?.Value?.ToString();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvSale.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();

            dgvSaleDetail.Rows.Clear();

            listSaleDetail = saleDetailDataAccess.GetSaleDetailIDData(int.Parse(dgvSale[0, dgvSale.CurrentCellAddress.Y].Value.ToString()));

            //1行ずつdgvSaleに挿入
            foreach (var item in listSaleDetail)
            {
                dgvSaleDetail.Rows.Add(item.SaDetailID, item.SaID, dictionaryProdact[item.PrID], item.SaQuantity, item.SaTotalPrice);
            }

            //dgvSaleDetailをリフレッシュ
            dgvSaleDetail.Refresh();

        }
        ///////////////////////////////
        //メソッド名：SaleDataHiddenUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：売上情報表示更新の実行
        ///////////////////////////////
        private void SaleDataHiddenUpdate()
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
            var regOperationLog = GenerateLogAtRegistration(rdbHiddenUpdate.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 売上情報作成
            var updSale = GenerateDataAtUpdate();

            // 売上情報更新
            UpdateSale(updSale);
        }
        ///////////////////////////////
        //メソッド名：GetValidDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：更新入力データの形式チェック
        //         ：エラーがない場合True
        //         ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtUpdate()
        {
            // 売上IDの適否
            if (!String.IsNullOrEmpty(txbSaleID.Text.Trim()))
            {
                // 売上IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSaleID.Text.Trim()))
                {
                    MessageBox.Show("売上IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSaleID.Focus();
                    return false;
                }
                //売上IDの存在チェック
                if (!saleDataAccess.CheckSaleIDExistence(int.Parse(txbSaleID.Text.Trim())))
                {
                    MessageBox.Show("売上IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSaleID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("売上IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSaleID.Focus();
                return false;
            }
            //表示非表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示選択が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
                return false;
            }


            return true;
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：顧客更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private T_Sale GenerateDataAtUpdate()
        {
            return new T_Sale
            {
                SaID = int.Parse(txbSaleID.Text.Trim()),
                SaFlag= cmbHidden.SelectedIndex,
                SaHidden=txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：UpdateSale()
        //引　数   ：売上情報
        //戻り値   ：なし
        //機　能   ：売上情報の更新
        ///////////////////////////////
        private void UpdateSale(T_Sale updSale)
        {
            //  売上情報の更新
            bool flg = saleDataAccess.UpdateSaleData(updSale);
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

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            GetDataGridView();
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
            List<T_Sale> viewSale = SetListSale();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewSale.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();

        }

        private void txbClientID_TextChanged(object sender, EventArgs e)
        {
            //nullの確認
            string stringClientID = txbClientID.Text.Trim();
            int intClientID = 0;

            if (!String.IsNullOrEmpty(stringClientID))
            {
                intClientID = int.Parse(stringClientID);
            }

            //存在確認
            if (!clientDataAccess.CheckClientIDExistence(intClientID))
            {
                txbClientName.Text = "顧客IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Client = listClient.Single(x => x.ClID == intClientID);

            txbClientName.Text = Client.ClName;
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

        private void pctHint_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/document/d/1-nFWLxjJ3gj2gqEa9VjvKW3R5T7nG_0J",
                UseShellExecute = true
            });
        }
    }
}

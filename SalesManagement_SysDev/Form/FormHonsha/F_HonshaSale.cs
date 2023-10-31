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
    public partial class F_HonshaSale : Form
    {
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース売上テーブルアクセス用クラスのインスタンス化
        SaleDataAccess saleDataAccess = new SaleDataAccess();
        //データベース売上詳細テーブルアクセス用クラスのインスタンス化
        SaleDetailDataAccess saleDetailDataAccess = new SaleDetailDataAccess();
        //データグリッドビュー用の売上データ
        private static List<T_Sale> listSale = new List<T_Sale>();
        //データグリッドビュー用の全売上データ
        private static List<T_Sale> listAllSale = new List<T_Sale>();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

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

        //DataGridView用に使用す営業所のDictionary
        private Dictionary<int?, string> dictionarySalesOffice = new Dictionary<int?, string>
        {
            { 1, "北大阪営業所" },
            { 2, "兵庫営業所" },
            { 3, "鹿営業所"},
            { 4, "京都営業所"},
            { 5, "和歌山営業所"}
        };

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
        //メソッド名：SaleSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void SaleSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listSale.Count;

            // 顧客抽出結果表示
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
            string strtxbClientPostal = txbClientPostal.Text.Trim();
            int inttxbClientPostal = 0;

            if (!String.IsNullOrEmpty(strtxbClientPostal))
            {
                inttxbClientPostal = int.Parse(strtxbClientPostal);
            }

            // 検索条件のセット
            T_Sale selectCondition = new T_Sale()
            {
                SaID = intSaleID,
                //ClName = txbClientName.Text.Trim()
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                ChID = inttxbClientPostal,

                //ClPostal= txbClientPostal.Text.Trim(),
                //ClAddress= txbClientAddress.Text.Trim(),
                //ClFAX=txbClientFax.Text.Trim(),
                //ClHidden=txbHidden.Text.Trim()
            };

            if (searchFlg)
            {
                // 顧客データのAnd抽出
                listSale = saleDataAccess.GetAndSaleData(selectCondition);
            }
            else
            {
                // 顧客データのOr抽出
                listSale = saleDataAccess.GetOrSaleData(selectCondition);
            }
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void F_HonshaSale_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

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

            dgvSale.Columns["SaID"].Width = 50;
            dgvSale.Columns["ClID"].Width = 65;
            dgvSale.Columns["SoID"].Width = 65;
            dgvSale.Columns["EmID"].Width = 80;
            dgvSale.Columns["ChID"].Width = 50;
            dgvSale.Columns["SaDate"].Width = 80;
            dgvSale.Columns["SaFlag"].Width = 65;


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

            dgvSaleDetail.Columns.Add("SaDetailID", "売上明細ID");
            dgvSaleDetail.Columns.Add("SaID", "売上ID");
            dgvSaleDetail.Columns.Add("PrID", "商品ID");
            dgvSaleDetail.Columns.Add("SaQuantity", "個数");
            dgvSaleDetail.Columns.Add("SaTotalPrice", "合計金額");

            dgvSaleDetail.Columns["SaDetailID"].Width = 70;
            dgvSaleDetail.Columns["SaID"].Width = 60;
            dgvSaleDetail.Columns["PrID"].Width = 60;
            dgvSaleDetail.Columns["SaQuantity"].Width = 57;
            dgvSaleDetail.Columns["SaTotalPrice"].Width = 80;
                        
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
                ClientDataSelect();
            }
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
            if (String.IsNullOrEmpty(txbSaleID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbClientPostal.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSaleID.Focus();
                return false;
            }

            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbSaleID.Text.Trim()))
            {
                // 顧客IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSaleID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSaleID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (!saleDataAccess.CheckSaleIDExistence(int.Parse(txbSaleID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSaleID.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            GetDataGridView();            
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
            txbClientName.Text = string.Empty;
            txbClientPostal.Text = string.Empty;
            txbEmployeeName.Text = string.Empty;
            txbClientPostal.Text = string.Empty;
            txbHidden.Text = string.Empty;
            dtpSaleDate.Value= DateTime.Now;
            cmbSalesOfficeID.SelectedIndex = -1;
            cmbHidden.SelectedIndex = -1;
        }

        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
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
                dgvSale.Rows.Add(item.SaID, item.ClID, dictionarySalesOffice[item.SoID], item.EmID, item.ChID, item.SaDate, dictionaryHidden[item.SaFlag], item.SaHidden);
            }

            //dgvClientをリフレッシュ
            dgvSale.Refresh();

            //1行ずつdgvClientに挿入
            foreach (var item in viewSaleDetail)
            {
                dgvSaleDetail.Rows.Add(item.SaDetailID, item.SaID,item.PrID, item.SaQuantity, item.SaTotalPrice);
            }

            //dgvClientをリフレッシュ
            dgvSaleDetail.Refresh();

            if (pageNum == 0 && lastPage == pageNum)
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
            //データグリッドビューに乗っている情報をGUIに反映
            txbSaleID.Text = dgvSale[0, dgvSale.CurrentCellAddress.Y].Value.ToString();
            txbClientName.Text = dgvSale[1, dgvSale.CurrentCellAddress.Y].Value.ToString();
            cmbSalesOfficeID.SelectedIndex = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvSale[2, dgvSale.CurrentCellAddress.Y].Value.ToString()).Key.Value - 1;
            txbEmployeeName.Text = dgvSale [3, dgvSale.CurrentCellAddress.Y].Value.ToString();
            txbClientPostal.Text = dgvSale[4, dgvSale.CurrentCellAddress.Y].Value.ToString();
            dtpSaleDate.Text = dgvSale[5, dgvSale.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvSale[6, dgvSale.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvSale[7, dgvSale.CurrentCellAddress.Y]?.Value?.ToString();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
    }
}

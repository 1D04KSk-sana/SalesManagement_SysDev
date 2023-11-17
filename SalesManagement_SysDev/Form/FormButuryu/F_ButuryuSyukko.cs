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
    public partial class F_ButuryuSyukko : Form
    {
        //データベース商品テーブルアクセス用クラスのインスタンス化
        SyukkoDataAccess SyukkoDataAccess = new SyukkoDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess SalesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        MakerDataAccess MakerDataAccess = new MakerDataAccess();
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        SaleDataAccess SaleDataAccess = new SaleDataAccess();
        //データグリッドビュー用の全出庫データ
        private static List<T_Syukko> listAllSyukko = new List<T_Syukko>();
        //データグリッドビュー用の出庫データ
        private static List<T_Syukko> listsyukko = new List<T_Syukko>();
        //データグリッドビュー用の出庫データ
        private static List<T_Syukko> listsalesoffice = new List<T_Syukko>();
        //データグリッドビュー用の営業所データ
        private static List<M_SalesOffice> listSalesOfficeID = new List<M_SalesOffice>();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //DataGridView用に使用する大分類名のDictionary
        private Dictionary<int, string> dictionarySoID;
        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };

        public F_ButuryuSyukko()
        {
            InitializeComponent();
        }

        private void F_ButuryuSyukko_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();
            DictionarySet();

            //cmbSalesOfficeIDを未選択に
            cmbSalesOfficeID.SelectedIndex = -1;

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;

            ////営業所名のデータを取得
            //listSalesOfficeID = SaleDataAccess.GetSalesOfficeDspData();
            ////取得したデータをコンボボックスに挿入
            //cmbSalesOfficeID.DataSource = listSalesOfficeID;
            ////表示する名前をMaNameに指定
            //cmbSalesOfficeID.DisplayMember = "MaName";
            ////項目の順番をMaIDに指定
            //cmbSalesOfficeID.ValueMember = "SoID";
            ////cmbMakerNameを未選択に
            //cmbSalesOfficeID.SelectedIndex = -1;
        }
        
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbSearch.Checked = true;

            GetDataGridView();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ProdactDataSelect();
            }

            //確定ラヂオボタンがチェックされているとき
            if (rdbConfirm.Checked)
            {

            }

            //非表示ラヂオボタンがチェックされているとき
            if (rdbHidden.Checked)
            {

            }
        }

        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ProdactSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ProdactSearchButtonClick(false);
        }

        ///////////////////////////////
        //メソッド名：ProdactDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：商品情報検索の実行
        ///////////////////////////////
        private void ProdactDataSelect()
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

            //商品登録フォームの透明化
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
            if (String.IsNullOrEmpty(txbSyukkoID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbChumonID.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSyukkoID.Focus();
                return false;
            }

            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbChumonID.Text.Trim()))
            {
                // 顧客IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbChumonID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (!SyukkoDataAccess.CheckSyukkoIDExistence(int.Parse(txbChumonID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbSyukkoID.Text = string.Empty;
            txbClientID.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            txbEmployeeName.Text = string.Empty;
            txbChumonID.Text = string.Empty;
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
            //表示用の商品リスト作成
            List<T_Syukko> listViewSyukko = SetListSyukko();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewSyukko);
        }

        ///////////////////////////////
        //メソッド名：SetListClient()
        //引　数   ：なし
        //戻り値   ：表示用出庫データ
        //機　能   ：表示用出庫データの準備
        ///////////////////////////////
        private List<T_Syukko> SetListSyukko()
        {
            //商品のデータを全取得
            listAllSyukko = SyukkoDataAccess.GetSyukkoDspData();

            //表示用の顧客リスト作成
            List<T_Syukko> listViewSyukko = new List<T_Syukko>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewSyukko = listsyukko;
            }
            else
            {
                //全データをとってくる
                listViewSyukko = listAllSyukko;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の商品データの取得
                listViewSyukko = SyukkoDataAccess.GetSyukkotDspData(listViewSyukko);
            }
            else
            {
                // 管理Flgが非表示の商品データの取得
                listViewSyukko = SyukkoDataAccess.GetSyukkoNotDspData(listViewSyukko);
            }

            return listViewSyukko;
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：商品情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strSyukkoID = txbSyukkoID.Text.Trim();
            int intSyukkoID = 0;

            if (!String.IsNullOrEmpty(strSyukkoID))
            {
                intSyukkoID = int.Parse(strSyukkoID);
            }

            // 検索条件のセット
            T_Syukko selectCondition = new T_Syukko()
            {
                SyID = intSyukkoID,
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                OrID = intSyukkoID
                //テキストボックス = txbxxxxxx.Text.Trim()
            };

            if (searchFlg)
            {
                // 商品データのAnd抽出
                listsyukko = SyukkoDataAccess.GetAndSyukkoData(selectCondition);
            }
            else
            {
                // 商品データのOr抽出
                listsyukko = SyukkoDataAccess.GetOrSyukkoData(selectCondition);
            }
        }

        ///////////////////////////////
        //メソッド名：ProdactSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：商品情報検索の実行
        ///////////////////////////////
        private void ProdactSearchButtonClick(bool searchFlg)
        {
            // 出庫情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listsyukko.Count;

            // 顧客抽出結果表示
            txbNumPage.Text = "1";
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {
            //営業所名のデータを取得
            listSalesOfficeID = SalesOfficeDataAccess.GetSalesOfficeDspData();

            dictionarySoID = new Dictionary<int, string> { };

            foreach (var item in listSalesOfficeID)
            {
                dictionarySoID.Add(item.SoID, item.SoName);
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
            dgvSyukko.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvSyukko.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvSyukko.AllowUserToResizeColumns = false;
            dgvSyukko.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvSyukko.MultiSelect = false;
            //セルの編集ができないように
            dgvSyukko.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvSyukko.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvSyukko.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvSyukko.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvSyukko.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSyukko.Columns.Add("SyID", "出庫ID");
            dgvSyukko.Columns.Add("EmID", "社員ID");
            dgvSyukko.Columns.Add("ClID", "顧客ID");
            dgvSyukko.Columns.Add("SoID", "営業所ID");
            dgvSyukko.Columns.Add("OrID", "受注ID");
            dgvSyukko.Columns.Add("SyDate", "出庫年月日");
            dgvSyukko.Columns.Add("SyStateFlag", "出庫状態フラグ");
            dgvSyukko.Columns.Add("SyFlag", "出庫管理フラグ");
            dgvSyukko.Columns.Add("SyHidden", "非表示理由");

            dgvSyukko.Columns["SyID"].Width = 80;
            dgvSyukko.Columns["EmID"].Width = 80;
            dgvSyukko.Columns["ClID"].Width = 80;
            dgvSyukko.Columns["SoID"].Width = 80;
            dgvSyukko.Columns["OrID"].Width = 80;
            dgvSyukko.Columns["SyDate"].Width = 80;
            dgvSyukko.Columns["SyStateFlag"].Width = 80;
            dgvSyukko.Columns["SyFlag"].Width = 80;
            dgvSyukko.Columns["SyHidden"].Width = 80;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvSyukko.Columns)
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
        private void SetDataGridView(List<T_Syukko> viewSyukko)
        {
            //中身を消去
            dgvSyukko.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewSyukko.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewSyukko.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvSyukko.Rows.Add(item.SyID, item.EmID, item.ClID, item.SoID, item.OrID,item.SyDate,
                    item.SyDate, dictionaryHidden[item.SyStateFlag],item.SyHidden);
            }
            //SyFlagだけまだ

            //dgvClientをリフレッシュ
            dgvSyukko.Refresh();

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


    }
}

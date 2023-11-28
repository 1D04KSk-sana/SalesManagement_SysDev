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
    public partial class F_ButuryuWarehousing : Form
    {
        //データベース入庫テーブルアクセス用クラスのインスタンス化
        WarehousingDataAccess warehousingDataAccess = new WarehousingDataAccess();
        //データベース入庫テーブルアクセス用クラスのインスタンス化
        WarehousingDetailDataAccess warehousingDetailDataAccess = new WarehousingDetailDataAccess();
        //データグリッドビュー用の全入庫データ
        private static List<T_Warehousing> listAllWarehousing = new List<T_Warehousing>();
        //データグリッドビュー用の入庫データ
        private static List<T_Warehousing> listWarehousing = new List<T_Warehousing>();
        //データグリッドビュー用の入庫データ
        private static List<T_WarehousingDetail> listWarehousingDetail = new List<T_WarehousingDetail>();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //コンボボックス用の社員データリスト
        private static List<M_Employee> listEmployee = new List<M_Employee>();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //DataGridView用に使用す社員のDictionary
        private Dictionary<int, string> dictionaryEmployee;
        //コンボボックス用の商品データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //DataGridView用に使用す商品のDictionary
        private Dictionary<int, string> dictionaryProdact;



        public F_ButuryuWarehousing()
        {
            InitializeComponent();
        }
        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        //DataGridView用に使用する確定形式のDictionary
        private Dictionary<int, string> dictionaryConfirm = new Dictionary<int, string>
        {
            { 0, "未確定" },
            { 1, "確定" },
        };

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ///////////////////////////////
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {
            //社員のデータ取得
            listEmployee = employeeDataAccess.GetEmployeeDspData();

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listEmployee)
            {
                dictionaryEmployee.Add(item.EmID, item.EmName);
            }

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
                FormName = "入庫管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbWarehousingID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }
        ///////////////////////////////
        //メソッド名：GenerateDetailDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：入庫詳細登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private T_WarehousingDetail GenerateDetailDataAtRegistration()
        {
            M_Product Prodact = prodactDataAccess.GetIDProdactData(int.Parse(txbProductID.Text.Trim()));

            return new T_WarehousingDetail
            {
                WaDetailID = int.Parse(txbWarehousingDetailID.Text.Trim()),
                WaID = int.Parse(txbWarehousingID.Text.Trim()),
                PrID = int.Parse(txbProductID.Text.Trim()),
                WaQuantity = int.Parse(txbWarehousingQuantity.Text.Trim()),

            };
        }
        private void btnDetailClear_Click(object sender, EventArgs e)
        {
            ClearImputDetail();
        }
        ///////////////////////////////
        //メソッド名：ClearImputDetail()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールのクリア(Detail)
        ///////////////////////////////
        private void ClearImputDetail()
        {
            txbWarehousingDetailID.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbProductName.Text = string.Empty;
            txbWarehousingQuantity.Text = string.Empty;
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
            txbWarehousingID.Text = string.Empty;
            txbHattyuID.Text = string.Empty;
            txbEmployeeName.Text = string.Empty;
            dtpWarehousingDate.Value = DateTime.Now;
            cmbHidden.SelectedIndex = -1;
            cmbConfirm.SelectedIndex = -1;
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
            //表示用の発注リスト作成
            List<T_Warehousing> listViewWarehousing = SetListWarehousing();


            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewWarehousing);
        }
        ///////////////////////////////
        //メソッド名：SetListWarehousing()
        //引　数   ：なし
        //戻り値   ：表示用入庫データ
        //機　能   ：表示用入庫データの準備
        ///////////////////////////////
        private List<T_Warehousing> SetListWarehousing()
        {
            //入庫のデータを全取得
            listAllWarehousing = warehousingDataAccess.GetWarehousingData();

            //表示用の入庫リスト作成
            List<T_Warehousing> listViewWarehousing = new List<T_Warehousing>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewWarehousing = listWarehousing;
            }
            else
            {
                //全データをとってくる
                listViewWarehousing = listAllWarehousing;
            }


            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の入庫データの取得
                listViewWarehousing = warehousingDataAccess.GetWarehousingDspData(listViewWarehousing);
            }
            else
            {
                // 管理Flgが非表示の入庫データの取得
                listViewWarehousing = warehousingDataAccess.GetWarehousingNotDspData(listViewWarehousing);
            }

            return listViewWarehousing;
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Warehousing> viewWarehousing)
        {
            //中身を消去
            dgvWarehousing.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewWarehousing.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewWarehousing.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvWarehousingに挿入
            foreach (var item in depData)
            {
                dgvWarehousing.Rows.Add(item.WaID, dictionaryEmployee[item.EmID], item.HaID, item.WaDate, dictionaryHidden[item.WaFlag], dictionaryConfirm[item.WaShelfFlag], item.WaHidden);
            }

            //dgvWarehousingをリフレッシュ
            dgvWarehousing.Refresh();


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

        private void btnDone_Click(object sender, EventArgs e)
        {
            //詳細登録ラヂオボタンがチェックされているとき
            if (rdbDetailRegister.Checked)
            {
                WarehousingDetailDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                //WarehousingDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //WarehousingDataSelect();
            }

            //確定ラヂオボタンがチェックされているとき
            if (rdbConfirm.Checked)
            {
                //WarehousingDataConfirm();
            }
        }
        ///////////////////////////////
        //メソッド名：WarehousingDetailDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：発注詳細情報登録の実行
        ///////////////////////////////
        private void WarehousingDetailDataRegister()
        {
            //入力情報適否
            if (!GetValidDetailDataAtRegistration())
            {
                return;
            }

            //操作ログデータ取得
            var regOperationLog = GenerateLogAtRegistration(rdbDetailRegister.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 発注詳細情報作成
            var regWarehousing = GenerateDetailDataAtRegistration();

            // 発注詳細情報登録
            RegistrationWarehousingDetail(regWarehousing);
        }
        ///////////////////////////////
        //メソッド名：GetValidDetailDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：詳細登録入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDetailDataAtRegistration()
        {
            //入庫詳細IDの適否
            if (!String.IsNullOrEmpty(txbWarehousingDetailID.Text.Trim()))
            {
                //入庫詳細IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbWarehousingDetailID.Text.Trim()))
                {
                    MessageBox.Show("入庫詳細IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbWarehousingDetailID.Focus();
                    return false;
                }
                //入庫詳細IDの存在チェック
                if (warehousingDetailDataAccess.CheckWarehousingDetailIDExistence(int.Parse(txbWarehousingDetailID.Text.Trim())))
                {
                    MessageBox.Show("入庫詳細IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbWarehousingDetailID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("入庫詳細IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbWarehousingDetailID.Focus();
                return false;
            }

            //入庫IDの適否
            if (!String.IsNullOrEmpty(txbWarehousingID.Text.Trim()))
            {
                //入庫IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbWarehousingID.Text.Trim()))
                {
                    MessageBox.Show("入庫IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbWarehousingID.Focus();
                    return false;
                }
                //入庫IDの存在チェック
                if (!warehousingDataAccess.CheckWarehousingIDExistence(int.Parse(txbWarehousingID.Text.Trim())))
                {
                    MessageBox.Show("入庫IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbWarehousingID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("入庫IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbWarehousingID.Focus();
                return false;
            }

            return true;
        }
        ///////////////////////////////
        //メソッド名：RegistrationWarehousingDetail()
        //引　数   ：入庫詳細情報
        //戻り値   ：なし
        //機　能   ：入庫詳細データの登録
        ///////////////////////////////
        private void RegistrationWarehousingDetail(T_WarehousingDetail regWarehousing)
        {
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            // 発注情報の登録
            bool flg = warehousingDetailDataAccess.AddWarehousingDetailData(regWarehousing);

            //登録成功・失敗メッセージ
            if (flg == true)
            {
                MessageBox.Show("データを登録しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // データグリッドビューの表示
            SetDataDetailGridView(int.Parse(txbWarehousingID.Text.Trim()));

            // 入力エリアのクリア
            ClearImput();
            ClearImputDetail();
        }
        ///////////////////////////////
        //メソッド名：SetDataDetailGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：詳細データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataDetailGridView(int intWarehousingID)
        {
            dgvWarehousingDetail.Rows.Clear();

            listWarehousingDetail = warehousingDetailDataAccess.GetWarehousingDetailIDData(intWarehousingID);

            //1行ずつdgvClientに挿入
            foreach (var item in listWarehousingDetail)
            {
                dgvWarehousingDetail.Rows.Add(item.WaID, item.WaDetailID, dictionaryProdact[item.PrID], item.WaQuantity);
            }

            //dgvClientをリフレッシュ
            dgvWarehousingDetail.Refresh();
        }

        private void F_ButuryuWarehousing_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            DictionarySet();

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
            dgvWarehousing.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvWarehousing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvWarehousing.AllowUserToResizeColumns = false;
            dgvWarehousing.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvWarehousing.MultiSelect = false;
            //セルの編集ができないように
            dgvWarehousing.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvWarehousing.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvWarehousing.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvWarehousing.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvWarehousing.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvWarehousing.Columns.Add("WaID", "入庫ID");
            dgvWarehousing.Columns.Add("EmID", "入庫社員名");
            dgvWarehousing.Columns.Add("HaID", "発注ID");
            dgvWarehousing.Columns.Add("WaDate", "入庫年月日");
            dgvWarehousing.Columns.Add("WaFlag", "入庫管理フラグ");
            dgvWarehousing.Columns.Add("WaShelfFlag", "入庫済フラグ");
            dgvWarehousing.Columns.Add("WaHidden", "非表示理由");

            dgvWarehousing.Columns["WaID"].Width = 132;
            dgvWarehousing.Columns["EmID"].Width = 150;
            dgvWarehousing.Columns["HaID"].Width = 130;
            dgvWarehousing.Columns["WaDate"].Width = 160;
            dgvWarehousing.Columns["WaFlag"].Width = 170;
            dgvWarehousing.Columns["WaShelfFlag"].Width = 160;
            dgvWarehousing.Columns["WaHidden"].Width = 265;



            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvWarehousing.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvWarehousingDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvWarehousingDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvWarehousingDetail.AllowUserToResizeColumns = false;
            dgvWarehousingDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvWarehousingDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvWarehousingDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvWarehousingDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvWarehousingDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvWarehousingDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvWarehousingDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvWarehousingDetail.Columns.Add("WaID", "入庫ID");
            dgvWarehousingDetail.Columns.Add("WaDetailID", "入庫詳細ID");
            dgvWarehousingDetail.Columns.Add("PrID", "商品ID");
            dgvWarehousingDetail.Columns.Add("WaQuantity", "数量");

            dgvWarehousingDetail.Columns["WaID"].Width = 174;
            dgvWarehousingDetail.Columns["WaDetailID"].Width = 174;
            dgvWarehousingDetail.Columns["PrID"].Width = 174;
            dgvWarehousingDetail.Columns["WaQuantity"].Width = 175;


            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvWarehousingDetail.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

    }
}

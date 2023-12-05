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
    public partial class F_EigyoShipment : Form
    {
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        ShipmentDataAccess ShipmentDataAccess = new ShipmentDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();

        //データグリッドビュー用の全顧客データ
        private static List<T_Shipment> listAllShipment = new List<T_Shipment>();
        //データグリッドビュー用の顧客データ
        private static List<T_Shipment> listShipment = new List<T_Shipment>();

        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();

        //DataGridView用に使用する営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;
        //DataGridView用に使用する顧客のDictionary
        private Dictionary<int, string> dictionaryClient;
        //DataGridView用に使用する社員のDictionary
        private Dictionary<int, string> dictionaryEmployee;

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

        public F_EigyoShipment()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                ShipmentDataUpdate();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbUpdate.Checked = true;

            GetDataGridView();
        }
        
        private void F_EigyoShipment_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            DictionarySet();

            //取得したデータをコンボボックスに挿入
            cmbSalesOfficeID.DataSource = listSalesOffice;
            //表示する名前をSoNameに指定
            cmbSalesOfficeID.DisplayMember = "SoName";
            //項目の順番をSoIDに指定
            cmbSalesOfficeID.ValueMember = "SoID";

            //cmbSalesOfficeIDを未選択に
            cmbSalesOfficeID.SelectedIndex = -1;
            SetFormDataGridView();

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
        }
        
        private void btnPageSize_Click(object sender, EventArgs e)
        {
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
            List<T_Shipment> viewOrder = SetListShipment();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewOrder.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：ShipmentDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：受注情報更新の実行
        ///////////////////////////////
        private void ShipmentDataUpdate()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtUpdate())
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

            // 受注情報作成
            var updOrder = GenerateDataAtUpdate();

            // 受注情報更新
            UpdateOrder(updOrder);
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
            //受注IDの適否
            if (!String.IsNullOrEmpty(txbOrderID.Text.Trim()))
            {
                // 出荷IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbShipmentID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (!ShipmentDataAccess.CheckShipmentIDExistence(int.Parse(txbShipmentID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("受注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbOrderID.Focus();
                return false;
            }

            //表示選択の適否
            if (cmbShipmentHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示/非表示が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbShipmentHidden.Focus();
                return false;
            }

            return true;
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
                FormName = "受注管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbOrderID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：受注登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private T_Shipment GenerateDataAtRegistration()
        {
            return new T_Shipment
            {
                ShID = int.Parse(txbOrderID.Text.Trim()),
                ClID = clientDataAccess.GetClientID(txbClientName.Text.Trim()),
                EmID = F_Login.intEmployeeID,
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                OrID = int.Parse(txbOrderID.Text.Trim()),
                ShStateFlag = 0,
                ShFinishDate = dtpShipmentDate.Value,
                ShFlag = cmbShipmentHidden.SelectedIndex,
                ShHidden = txbShipmentHidden.Text.Trim(),
            };
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

            dictionarySalesOffice = new Dictionary<int, string> { };

            foreach (var item in listSalesOffice)
            {
                dictionarySalesOffice.Add(item.SoID, item.SoName);
            }

            //listClient = clientDataAccess.GetClientDspData();

            //dictionaryClient = new Dictionary<int, string> { };

            //foreach (var item in listClient)
            //{
            //    dictionaryClient.Add(item.ClID.Value, item.ClName);
            //}

            //listEmployee = employeeDataAccess.GetEmployeeDspData();

            //dictionaryEmployee = new Dictionary<int, string> { };

            //foreach (var item in listEmployee)
            //{
            //    dictionaryEmployee.Add(item.EmID, item.EmName);
            //}

            ////商品のデータを取得
            //listProdact = prodactDataAccess.GetProdactDspData();

            //dictionaryProdact = new Dictionary<int, string> { };

            //foreach (var item in listProdact)
            //{
            //    dictionaryProdact.Add(item.PrID, item.PrName);
            //}
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
            dgvShipment.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvShipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvShipment.AllowUserToResizeColumns = false;
            dgvShipment.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvShipment.MultiSelect = false;
            //セルの編集ができないように
            dgvShipment.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvShipment.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvShipment.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvShipment.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvShipment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvShipment.Columns.Add("ShID", "出荷ID");
            dgvShipment.Columns.Add("ClID", "顧客ID");
            dgvShipment.Columns.Add("EmID", "社員ID");
            dgvShipment.Columns.Add("SoID", "営業所ID");
            dgvShipment.Columns.Add("OrID", "受注ID");
            dgvShipment.Columns.Add("ShStateFlag", "受注年月日");
            dgvShipment.Columns.Add("ShFinishDate", "出荷完了年月日");
            dgvShipment.Columns.Add("ShFlag", "出荷管理フラグ");
            dgvShipment.Columns.Add("ShHidden", "非表示理由");

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvShipment.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvShipmentDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvShipmentDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvShipmentDetail.AllowUserToResizeColumns = false;
            dgvShipmentDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvShipmentDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvShipmentDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvShipmentDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvShipmentDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvShipmentDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvShipmentDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvShipmentDetail.Columns.Add("ShDetailID", "受注ID");
            dgvShipmentDetail.Columns.Add("ShID", "受注詳細ID");
            dgvShipmentDetail.Columns.Add("PrID", "商品ID");
            dgvShipmentDetail.Columns.Add("ShQuantity", "数量");

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvShipmentDetail.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールのクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbShipmentID.Text = string.Empty;
            txbEmployeeName.Text = string.Empty;
            txbOrderID.Text = string.Empty;
            txbShipmentDetailID.Text = string.Empty;
            txbProductName.Text = string.Empty;
            txbClientName.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbShipmentquantity.Text = string.Empty;
            txbShipmentHidden.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            cmbShipmentHidden.SelectedIndex = -1;
            dtpShipmentDate.Value = DateTime.Now;
        }

        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の受注リスト作成
            List<T_Shipment> listViewShipment = SetListShipment();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewShipment);
        }

        ///////////////////////////////
        //メソッド名：SetListShipment()
        //引　数   ：なし
        //戻り値   ：表示用受注データ
        //機　能   ：表示用受注データの準備
        ///////////////////////////////
        private List<T_Shipment> SetListShipment()
        {
            //受注のデータを全取得
            listAllShipment = ShipmentDataAccess.GetShipmentData();

            //表示用の受注リスト作成
            List<T_Shipment> listViewShipment = new List<T_Shipment>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewShipment = listShipment;
            }
            else
            {
                //全データをとってくる
                listViewShipment = listAllShipment;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewShipment = ShipmentDataAccess.GetShipmentDspData(listViewShipment);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewShipment = ShipmentDataAccess.GetShipmentNotDspData(listViewShipment);
            }

            return listViewShipment;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Shipment> viewShipment)
        {
            //中身を消去
            dgvShipment.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewShipment.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewShipment.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvShipment.Rows.Add(item.ShID,item.OrID, dictionaryClient[item.ClID], dictionaryEmployee[item.EmID], 
                    dictionarySalesOffice[item.SoID],item.OrID, dictionaryConfirm[item.ShStateFlag], item.ShFinishDate, dictionaryHidden[item.ShFlag], item.ShHidden);
            }

            //dgvClientをリフレッシュ
            dgvShipment.Refresh();

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


    }
}

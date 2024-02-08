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
    public partial class F_EigyoArrival : Form
    {
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //データベース入荷テーブルアクセス用クラスのインスタンス化
        ArrivalDataAccess arrivalDataAccess = new ArrivalDataAccess();
        //データベース入荷詳細テーブルアクセス用クラスのインスタンス化
        ArrivalDetailDataAccess arrivalDetailDataAccess = new ArrivalDetailDataAccess();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        //データベース出荷テーブルアクセス用クラスのインスタンス化
        ShipmentDataAccess shipmentDataAccess = new ShipmentDataAccess();
        //データベース出荷テーブルアクセス用クラスのインスタンス化
        ShipmentDetailDataAccess shipmentDetailDataAccess = new ShipmentDetailDataAccess();
        //コンボボックス用の社員データリスト
        private static List<M_Employee> listEmployee = new List<M_Employee>();
        //コンボボックス用の商品データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //コンボボックス用の顧客データリスト
        private static List<M_Client> listClient = new List<M_Client>();
        //コンボボックス用の入荷データリスト
        private static List<T_Arrival> listArrival = new List<T_Arrival>();
        //データグリッドビュー用の全入荷データ
        private static List<T_Arrival> listAllArrival = new List<T_Arrival>();
        //コンボボックス用の入荷詳細データリスト
        private static List<T_ArrivalDetail> listArrivalDetail = new List<T_ArrivalDetail>();
        //データグリッドビュー用の全入荷詳細データ
        private static List<T_ArrivalDetail> listAllArrivalDetail = new List<T_ArrivalDetail>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //DataGridView用に使用する営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;
        //DataGridView用に使用する顧客のDictionary
        private Dictionary<int, string> dictionaryClient;
        //DataGridView用に使用す社員のDictionary
        private Dictionary<int, string> dictionaryEmployee;
        //DataGridView用に使用す商品のDictionary
        private Dictionary<int, string> dictionaryProdact;

        //データグリッドビュー用の営業所データリスト
        private static List<M_SalesOffice> listDGVSalesOfficeID = new List<M_SalesOffice>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Client> listDGVClientID = new List<M_Client>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Employee> listDGVEmployeeID = new List<M_Employee>();

        public F_EigyoArrival()
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

            listDGVEmployeeID = employeeDataAccess.GetEmployeeData();

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listDGVEmployeeID)
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
            //営業所のデータを取得
            listSalesOffice = salesOfficeDataAccess.GetSalesOfficeDspData();

            //データグリッドビュー用の営業所のデータを取得
            listDGVSalesOfficeID = salesOfficeDataAccess.GetSalesOfficeData();

            dictionarySalesOffice = new Dictionary<int, string> { };

            foreach (var item in listDGVSalesOfficeID)
            {
                dictionarySalesOffice.Add(item.SoID, item.SoName);
            }
            //顧客のデータを取得
            listClient = clientDataAccess.GetClientDspData();

            listDGVClientID = clientDataAccess.GetClientData();

            dictionaryClient = new Dictionary<int, string> { };

            foreach (var item in listDGVClientID)
            {
                dictionaryClient.Add(item.ClID.Value, item.ClName);
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
                FormName = "入荷管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbArrivalID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
            dtpArrivalDate.Checked= false;

            rdbUpdate.Checked = true;

            txbNumPage.Text = "1";

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
            txbArrivalID.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            txbOrderID.Text = string.Empty;
            txbEmployeeID.Text = string.Empty;
            txbClientID.Text = string.Empty;
            dtpArrivalDate.Value = DateTime.Now;
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
            if (txbPageSize.Text.Trim() == string.Empty)
            {
                txbPageSize.Text = "1";
            }

            //表示用の入荷リスト作成
            List<T_Arrival> listViewArrival = SetListArrival();


            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewArrival);
        }
        ///////////////////////////////
        //メソッド名：SetListArrival()
        //引　数   ：なし
        //戻り値   ：表示用入荷データ
        //機　能   ：表示用入荷データの準備
        ///////////////////////////////
        private List<T_Arrival> SetListArrival()
        {
            //入荷のデータを全取得
            listAllArrival = arrivalDataAccess.GetArrivalData();

            //表示用の入荷リスト作成
            List<T_Arrival> listViewArrival = new List<T_Arrival>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewArrival = listArrival;
            }
            else
            {
                //全データをとってくる
                listViewArrival = listAllArrival;
            }


            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の入荷データの取得
                listViewArrival = arrivalDataAccess.GetArrivalDspData(listViewArrival);
            }
            else
            {
                // 管理Flgが非表示の入荷データの取得
                listViewArrival = arrivalDataAccess.GetArrivalNotDspData(listViewArrival);
            }

            return listViewArrival;
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Arrival> viewArrival)
        {
            //中身を消去
            dgvArrival.Rows.Clear();
            dgvArrivalDetail.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewArrival.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewArrival.Skip(pageSize * pageNum).Take(pageSize).ToList();

            depData.Reverse();

            //1行ずつdgvArrivalに挿入
            foreach (var item in depData)
            {
                string strEmployeeName = "";

                if (item.EmID != null)
                {
                    strEmployeeName = dictionaryEmployee[item.EmID.Value];
                }

                dgvArrival.Rows.Add(item.ArID, dictionarySalesOffice[item.SoID], strEmployeeName, dictionaryClient[item.ClID],item.OrID, item.ArDate, dictionaryHidden[item.ArFlag], dictionaryConfirm[item.ArStateFlag], item.ArHidden);
            }

            //dgvArrivalをリフレッシュ
            dgvArrival.Refresh();


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

        private void F_EigyoArrival_Load(object sender, EventArgs e)
        {
            rdbUpdate.Checked = true;
            
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
        ///////////////////////////////
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの初期設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //列を自由に設定できるように
            dgvArrival.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvArrival.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvArrival.AllowUserToResizeColumns = false;
            dgvArrival.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvArrival.MultiSelect = false;
            //セルの編集ができないように
            dgvArrival.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvArrival.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvArrival.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvArrival.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvArrival.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvArrival.Columns.Add("ArID", "入荷ID");
            dgvArrival.Columns.Add("SoID", "営業所名");
            dgvArrival.Columns.Add("EmID", "社員名");
            dgvArrival.Columns.Add("ClID", "顧客名");
            dgvArrival.Columns.Add("OrID", "受注ID");
            dgvArrival.Columns.Add("ArDate", "入荷年月日");
            dgvArrival.Columns.Add("ArFlag", "入荷管理フラグ");
            dgvArrival.Columns.Add("ArStateFlag", "入荷済フラグ");
            dgvArrival.Columns.Add("ArHidden", "非表示理由");

            dgvArrival.Columns["ArID"].Width = 112;
            dgvArrival.Columns["SoID"].Width = 172;
            dgvArrival.Columns["EmID"].Width = 140;
            dgvArrival.Columns["ClID"].Width = 152;
            dgvArrival.Columns["OrID"].Width = 100;
            dgvArrival.Columns["ArDate"].Width = 160;
            dgvArrival.Columns["ArFlag"].Width = 170;
            dgvArrival.Columns["ArStateFlag"].Width = 161;
            dgvArrival.Columns["ArHidden"].Width = 265;

            dgvArrival.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(96)))), ((int)(((byte)(54)))));
            dgvArrival.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvArrival.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvArrivalDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvArrivalDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvArrivalDetail.AllowUserToResizeColumns = false;
            dgvArrivalDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvArrivalDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvArrivalDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvArrivalDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvArrivalDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvArrivalDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvArrivalDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvArrivalDetail.Columns.Add("ArID", "入荷ID");
            dgvArrivalDetail.Columns.Add("ArDetailID", "入荷詳細ID");
            dgvArrivalDetail.Columns.Add("PrID", "商品ID");
            dgvArrivalDetail.Columns.Add("ArQuantity", "数量");

            dgvArrivalDetail.Columns["ArID"].Width = 174;
            dgvArrivalDetail.Columns["ArDetailID"].Width = 174;
            dgvArrivalDetail.Columns["PrID"].Width = 174;
            dgvArrivalDetail.Columns["ArQuantity"].Width = 175;

            dgvArrivalDetail.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(96)))), ((int)(((byte)(54)))));
            dgvArrivalDetail.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvArrivalDetail.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void dgvArrival_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvArrival.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();

            SetDataDetailGridView(int.Parse(dgvArrival[0, dgvArrival.CurrentCellAddress.Y].Value.ToString()));

        }
        ///////////////////////////////
        //メソッド名：SetDataDetailGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：詳細データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataDetailGridView(int intArrivalID)
        {
            dgvArrivalDetail.Rows.Clear();

            listArrivalDetail = arrivalDetailDataAccess.GetArrivalDetailIDData(intArrivalID);

            //1行ずつdgvClientに挿入
            foreach (var item in listArrivalDetail)
            {
                dgvArrivalDetail.Rows.Add(item.ArID, item.ArDetailID, dictionaryProdact[item.PrID], item.ArQuantity);
            }

            //dgvClientをリフレッシュ
            dgvArrivalDetail.Refresh();
        }

        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            var arrivalDate = dgvArrival[5, dgvArrival.CurrentCellAddress.Y].Value;

            if (arrivalDate != null)
            {
                dtpArrivalDate.Text = arrivalDate.ToString();
            }

            bool cmbflg = false;
            int intSalesOfficeID = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvArrival[1, dgvArrival.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listDGVSalesOfficeID)
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
            string strClientID = dictionaryClient.FirstOrDefault(x => x.Value == dgvArrival[3, dgvArrival.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            foreach (var item in listDGVClientID)
            {
                if (strClientID == item.ClID.ToString())
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

            bool cmbEmployeeflg = false;
            string strEmployeeID = dictionaryEmployee.FirstOrDefault(x => x.Value == dgvArrival[2, dgvArrival.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            foreach (var item in listDGVEmployeeID)
            {
                if (strEmployeeID == item.EmID.ToString())
                {
                    cmbEmployeeflg = true;
                }
            }

            if (cmbEmployeeflg)
            {
                txbEmployeeID.Text = strEmployeeID;
            }
            else
            {
                txbEmployeeID.Text = string.Empty;
            }

            //データグリッドビューに乗っている情報をGUIに反映
            txbArrivalID.Text = dgvArrival[0, dgvArrival.CurrentCellAddress.Y].Value.ToString();
            txbOrderID.Text = dgvArrival[4, dgvArrival.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvArrival[6, dgvArrival.CurrentCellAddress.Y].Value.ToString()).Key;
            cmbConfirm.SelectedIndex = dictionaryConfirm.FirstOrDefault(x => x.Value == dgvArrival[7, dgvArrival.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvArrival[8, dgvArrival.CurrentCellAddress.Y]?.Value?.ToString();
        }
        private void txbEmployeeID_TextChanged(object sender, EventArgs e)
        {
            //nullの確認
            string stringEmployeeID = txbEmployeeID.Text.Trim();
            int intEmployeeID = 0;

            if (!String.IsNullOrEmpty(stringEmployeeID))
            {
                intEmployeeID = int.Parse(stringEmployeeID);
            }

            //存在確認
            if (!employeeDataAccess.CheckEmployeeIDExistence(intEmployeeID))
            {
                txbEmployeeName.Text = "社員IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Employee = listEmployee.Single(x => x.EmID == intEmployeeID);

            txbEmployeeName.Text = Employee.EmName;

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

        private void btnDone_Click(object sender, EventArgs e)
        {
            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                ArrivalDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ArrivalDataSelect();
            }

            //確定ラヂオボタンがチェックされているとき
            if (rdbConfirm.Checked)
            {
                ArrivalDataConfirm();
            }
        }

        ///////////////////////////////
        //メソッド名：ArrivalDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：入荷情報更新の実行
        ///////////////////////////////
        private void ArrivalDataUpdate()
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

            // 入荷情報作成
            var updArrival = GenerateDataAtUpdate();

            // 入荷情報更新
            UpdateArrival(updArrival);
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
            //入荷IDの適否
            if (!String.IsNullOrEmpty(txbArrivalID.Text.Trim()))
            {
                // 入荷IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbArrivalID.Text.Trim()))
                {
                    MessageBox.Show("入荷IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbArrivalID.Focus();
                    return false;
                }
                //入荷IDの存在チェック
                if (!arrivalDataAccess.CheckArrivalIDExistence(int.Parse(txbArrivalID.Text.Trim())))
                {
                    MessageBox.Show("入荷IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbArrivalID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("入荷IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbArrivalID.Focus();
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

        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：入荷更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private T_Arrival GenerateDataAtUpdate()
        {
            return new T_Arrival
            {
                ArID = int.Parse(txbArrivalID.Text.Trim()),
                ArFlag = cmbHidden.SelectedIndex,
                ArHidden = txbHidden.Text.Trim(),
            };
        }

        ///////////////////////////////
        //メソッド名：UpdateArrival()
        //引　数   ：入荷情報
        //戻り値   ：なし
        //機　能   ：入荷情報の更新
        ///////////////////////////////
        private void UpdateArrival(T_Arrival updArrival)
        {
            // 発注情報の更新
            bool flg = arrivalDataAccess.UpdateArrivalData(updArrival);

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
        //メソッド名：ArrivalDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：入荷情報検索の実行
        ///////////////////////////////
        private void ArrivalDataSelect()
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

            //入荷登録フォームの透明化
            this.Opacity = 0;
        }
        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ArrivalSearchButtonClick(true);
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }
        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ArrivalSearchButtonClick(false);
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
            if (String.IsNullOrEmpty(txbArrivalID.Text.Trim()) && String.IsNullOrEmpty(txbEmployeeID.Text.Trim()) && String.IsNullOrEmpty(txbClientID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbOrderID.Text.Trim()) && dtpArrivalDate.Checked == false && cmbConfirm.SelectedIndex == -1)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbArrivalID.Focus();
                return false;
            }

            //入荷IDの適否
            if (!String.IsNullOrEmpty(txbArrivalID.Text.Trim()))
            {
                //入荷IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbArrivalID.Text.Trim()))
                {
                    MessageBox.Show("入荷IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbArrivalID.Focus();
                    return false;
                }
                //入荷IDの重複チェック
                if (!arrivalDataAccess.CheckArrivalIDExistence(int.Parse(txbArrivalID.Text.Trim())))
                {
                    MessageBox.Show("入荷IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbArrivalID.Focus();
                    return false;
                }
            }

            //社員IDの適否
            if (!String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                //社員IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbEmployeeID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //社員IDの重複チェック
                if (!employeeDataAccess.CheckEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("社員IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }
            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbClientID.Text.Trim()))
            {
                // 顧客IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbClientID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (!clientDataAccess.CheckClientIDExistence(int.Parse(txbClientID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientID.Focus();
                    return false;
                }
            }
            //受注IDの適否
            if (!String.IsNullOrEmpty(txbOrderID.Text.Trim()))
            {
                //受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbOrderID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
                //受注IDの重複チェック
                if (!orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
            }


            return true;
        }

        ///////////////////////////////
        //メソッド名：ArrivalSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：入荷情報検索の実行
        ///////////////////////////////
        private void ArrivalSearchButtonClick(bool searchFlg)
        {
            // 入荷情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listArrival.Count;

            txbNumPage.Text = "1";

            // 入荷抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：入荷情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strArrivalID = txbArrivalID.Text.Trim();
            int intArrivalID = 0;

            if (!String.IsNullOrEmpty(strArrivalID))
            {
                intArrivalID = int.Parse(strArrivalID);
            }

            string strEmployeeID = txbEmployeeID.Text.Trim();
            int intEmployeeID = 0;

            if (!String.IsNullOrEmpty(strEmployeeID))
            {
                intEmployeeID = int.Parse(strEmployeeID);
            }

            string strOrderID = txbOrderID.Text.Trim();
            int intOrderID = 0;

            if (!String.IsNullOrEmpty(strOrderID))
            {
                intOrderID = int.Parse(strOrderID);
            }
            string strClientID = txbClientID.Text.Trim();
            int intClientID = 0;

            if (!String.IsNullOrEmpty(strClientID))
            {
                intClientID = int.Parse(strClientID);
            }

            DateTime? dateArrival = null;

            if (dtpArrivalDate.Checked)
            {
                dateArrival = dtpArrivalDate.Value.Date;
            }

            // 検索条件のセット
            T_Arrival selectCondition = new T_Arrival()
            {
                ArID = intArrivalID,
                ClID = intClientID,
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                OrID = intOrderID,
                EmID = intEmployeeID,
                ArDate = dateArrival,
                ArStateFlag = cmbConfirm.SelectedIndex
            };

            if (searchFlg)
            {
                // 入荷データのAnd抽出
                listArrival = arrivalDataAccess.GetAndArrivalData(selectCondition);
            }
            else
            {
                // 入荷データのOr抽出
                listArrival = arrivalDataAccess.GetOrArrivalData(selectCondition);
            }
        }
        ///////////////////////////////
        //メソッド名：ArrivalDataConfirm()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：入荷情報確定の実行
        ///////////////////////////////
        private void ArrivalDataConfirm()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtConfirm())
            {
                return;
            }

            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("確定しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //操作ログデータ取得
            var regOperationLog = GenerateLogAtRegistration(rdbConfirm.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 入荷情報作成
            var cmfArrival = GenerateDataAtConfirm();

            // 入荷情報更新
            ConfirmArrival(cmfArrival);
        }

        ///////////////////////////////
        //メソッド名：GetValidDataAtConfirm()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：確定入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtConfirm()
        {
            //入荷IDの適否
            if (!String.IsNullOrEmpty(txbArrivalID.Text.Trim()))
            {
                // 入荷IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbArrivalID.Text.Trim()))
                {
                    MessageBox.Show("入荷IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbArrivalID.Focus();
                    return false;
                }
                //入荷IDの存在チェック
                if (!arrivalDataAccess.CheckArrivalIDExistence(int.Parse(txbArrivalID.Text.Trim())))
                {
                    MessageBox.Show("入荷IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbArrivalID.Focus();
                    return false;
                }

                T_Arrival arrival = arrivalDataAccess.GetIDArrivalData(int.Parse(txbArrivalID.Text.Trim()));

                //入荷IDの確定チェック
                if (arrival.ArStateFlag == 1)
                {
                    MessageBox.Show("入荷IDはすでに確定しています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbArrivalID.Focus();
                    return false;
                }
                //入荷IDの非表示チェック
                if (arrival.ArFlag == 1)
                {
                    MessageBox.Show("入荷IDは非表示にされています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbArrivalID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("入荷IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbArrivalID.Focus();
                return false;
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtConfirm()
        //引　数   ：なし
        //戻り値   ：入荷確定情報
        //機　能   ：確定データのセット
        ///////////////////////////////
        private T_Arrival GenerateDataAtConfirm()
        {
            return new T_Arrival
            {
                ArID = int.Parse(txbArrivalID.Text.Trim()),
                ArStateFlag = 1,
                EmID = F_Login.intEmployeeID,
                ArDate = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：ConfirmArrival()
        //引　数   ：入荷情報
        //戻り値   ：なし
        //機　能   ：入荷情報の確定
        ///////////////////////////////
        private void ConfirmArrival(T_Arrival cfmArrival)
        {
            // 発注情報の更新
            bool flg = arrivalDataAccess.ConfirmArrivalData(cfmArrival);

            if (flg == true)
            {
                MessageBox.Show("確定しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("確定に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //出荷登録
            T_Arrival Arrival = arrivalDataAccess.GetIDArrivalData(cfmArrival.ArID);

            T_Shipment Shipment = GenerateShipmentAtRegistration(Arrival);

            bool flgShipment = shipmentDataAccess.AddShipmentData(Shipment);

            if (flgShipment == true)
            {
                MessageBox.Show("出荷管理にデータを送信ました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("出荷管理へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //出荷詳細登録
            List<T_ArrivalDetail> listArrivalDetail = arrivalDetailDataAccess.GetArrivalDetailIDData(cfmArrival.ArID);

            List<bool> flgArrivallist = new List<bool>();
            bool flgArrival = true;

            foreach (var item in listArrivalDetail)
            {
                T_ShipmentDetail ShipmentDetail = GenerateShipmentDetailAtRegistration(item, Arrival);

                flgArrivallist.Add(shipmentDetailDataAccess.AddShipmentDetailData(ShipmentDetail));
            }

            foreach (var item in flgArrivallist)
            {
                if (!item)
                {
                    flgArrival = false;
                }
            }

            if (flgArrival)
            {
                MessageBox.Show("出荷詳細へデータを送信しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("出荷詳細へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //テキストボックス等のクリア
            ClearImput();

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GenerateShipmentAtRegistration()
        //引　数   ：出荷情報
        //戻り値   ：出荷登録情報
        //機　能   ：出荷登録データのセット
        ///////////////////////////////
        private T_Shipment GenerateShipmentAtRegistration(T_Arrival Arrival)
        {
            return new T_Shipment
            {
                ShID = shipmentDataAccess.ShipmentNum() + 1,
                ClID = Arrival.ClID,
                SoID = Arrival.SoID,
                OrID = Arrival.OrID,
                ShStateFlag = 0,
                ShFlag = 0,
            };
        }
        ///////////////////////////////
        //メソッド名：GenerateShipmentDetailAtRegistration()
        //引　数   ：入荷詳細情報
        //戻り値   ：入荷詳細登録情報
        //機　能   ：入荷詳細登録データのセット
        ///////////////////////////////
        private T_ShipmentDetail GenerateShipmentDetailAtRegistration(T_ArrivalDetail ArrivalDetail, T_Arrival Arrival)
        {
            return new T_ShipmentDetail
            {
                ShDetailID = ArrivalDetail.ArDetailID,
                ShID = shipmentDataAccess.GetIDOrderData(Arrival.OrID).ShID,
                PrID = ArrivalDetail.PrID,
                ShQuantity = ArrivalDetail.ArQuantity
            };
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                cmbSalesOfficeID.Enabled = true;
                txbArrivalID.Enabled = true;
                dtpArrivalDate.Enabled = true;
                txbClientID.Enabled = true;
                txbEmployeeID.Enabled = true;
                txbOrderID.Enabled = true;

                txbHidden.Enabled = false;
                cmbHidden.Enabled = false;
                cmbConfirm.Enabled = true;
            }
            if (rdbUpdate.Checked)
            {
                txbArrivalID.Enabled = true;
                txbHidden.Enabled = true;
                cmbHidden.Enabled = true;

                txbClientID.Enabled = false;
                txbEmployeeID.Enabled = false;
                txbOrderID.Enabled = false;
                cmbConfirm.Enabled = false;
                cmbSalesOfficeID.Enabled = false;
                dtpArrivalDate.Enabled = false;
            }

            if (rdbConfirm.Checked)
            {
                txbArrivalID.Enabled = true;
                cmbConfirm.Enabled = false;

                txbClientID.Enabled = false;
                txbEmployeeID.Enabled = false;
                txbOrderID.Enabled = false;
                cmbSalesOfficeID.Enabled = false;
                dtpArrivalDate.Enabled = false;
                txbHidden.Enabled = false;
                cmbHidden.Enabled = false;
            }
        }

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<T_Arrival> viewArrival= SetListArrival();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewArrival.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
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
                FileName = "https://docs.google.com/document/d/1Z_kheY9JMioOO_-RxazHPBPAvpAiAioE",
                UseShellExecute = true
            });
        }
    }
}

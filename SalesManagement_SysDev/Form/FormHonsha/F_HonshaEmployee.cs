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
    public partial class F_HonshaEmployee : Form
    {
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess EmployeeDataAccess = new EmployeeDataAccess();
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //データベース役所テーブルアクセス用クラスのインスタンス化
        PositionDataAccess positionDataAccess = new PositionDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        //データベース注文テーブルアクセス用クラスのインスタンス化
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();
        //データベース出庫テーブルアクセス用クラスのインスタンス化
        SyukkoDataAccess syukkoDataAccess = new SyukkoDataAccess();
        //データベース入荷テーブルアクセス用クラスのインスタンス化
        ArrivalDataAccess arrivalDataAccess = new ArrivalDataAccess();
        //データベース出荷テーブルアクセス用クラスのインスタンス化
        ShipmentDataAccess shipmentDataAccess = new ShipmentDataAccess();
        //データベース発注テーブルアクセス用クラスのインスタンス化
        HattyuDataAccess hattyuDataAccess = new HattyuDataAccess();
        //データベース入庫テーブルアクセス用クラスのインスタンス化
        WarehousingDataAccess warehousingDataAccess = new WarehousingDataAccess();
        //データベース売上テーブルアクセス用クラスのインスタンス化
        SaleDataAccess saleDataAccess = new SaleDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の社員データ
        private static List<M_Employee> listEmployee = new List<M_Employee>();
        //データグリッドビュー用の全社員データ
        private static List<M_Employee> listAllEmployee = new List<M_Employee>();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //コンボボックス用の役員データリスト
        private static List<M_Position> listPosition = new List<M_Position>();
        //コンボボックス用の顧客データリスト
        private static List<M_Client> listClient = new List<M_Client>();

        //データグリッドビュー用の役員データリスト
        private static List<M_Position> listDGVPosition = new List<M_Position>();
        //データグリッドビュー用の営業所データリスト
        private static List<M_SalesOffice> listDGVSalesOfficeID = new List<M_SalesOffice>();

        //DataGridView用に使用する営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;
        //DataGridView用に使用する顧客のDictionary
        private Dictionary<int, string> dictionaryClient;
        //DataGridView用に使用する社員のDictionary
        private Dictionary<int, string> dictionaryEmployee;
        //DataGridView用に使用する社員のDictionary
        private Dictionary<int, string> dictionaryPositionname;

        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();



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

       

        public F_HonshaEmployee()
        {
            InitializeComponent();
        }

        private void F_HonshaEmployee_Load(object sender, EventArgs e)
        {
            rdbUpdate.Checked = true;
            
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();
            DictionarySet();

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

            //役職のデータを取得
            listPosition = positionDataAccess.GetPositionDspData();
            //取得したデータをコンボボックスに挿入
            cmbPositionName.DataSource = listPosition;
            //表示する名前をPoNameに指定
            cmbPositionName.DisplayMember = "PoName";
            //項目の順番をPoIDに指定
            cmbPositionName.ValueMember = "PoID";
            //cmbPositionIDを未選択に
            cmbPositionName.SelectedIndex = -1;

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            EmployeeSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            EmployeeSearchButtonClick(false);
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
            dtpEmployeeHireDate.Checked = false;

            rdbUpdate.Checked = true;

            txbNumPage.Text = "1";

            GetDataGridView();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                EmployeeDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                EmployeeDataSelect();
            }
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
            List<M_Employee> viewEmployee = SetListEmployee();

            ////ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            ////最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewEmployee.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvEmployee.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();
        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の社員リスト作成
            List<M_Employee> listViewEmployee = SetListEmployee();

            // DataGridViewに表示するデータを指定
           SetDataGridView(listViewEmployee);
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

            dictionaryClient = new Dictionary<int, string> { };

            foreach (var item in listClient)
            {
                dictionaryClient.Add(item.ClID.Value, item.ClName);
            }

            listEmployee = employeeDataAccess.GetEmployeeDspData();

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listEmployee)
            {
                dictionaryEmployee.Add(item.EmID, item.EmName);
            }

            //コンボボックス用の役職のデータを取得
            listPosition = positionDataAccess.GetPositionDspData();

            //データグリッドビュー用の役職のデータを取得
            listDGVPosition = positionDataAccess.GetPositionData();

            dictionaryPositionname = new Dictionary<int, string> { };

            foreach (var item in listDGVPosition)
            {
                dictionaryPositionname.Add(item.PoID, item.PoName);
            }

            
        }

        ///////////////////////////////
        //メソッド名：SetListEmployee()
        //引　数   ：なし
        //戻り値   ：表示用社員データ
        //機　能   ：表示用社員データの準備
        ///////////////////////////////
        private List<M_Employee> SetListEmployee()
        {
            //社員のデータを全取得
            listAllEmployee = EmployeeDataAccess.GetEmployeeData();

            //表示用の社員リスト作成
            List<M_Employee> listViewEmployee = new List<M_Employee>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewEmployee = listEmployee;
            }
            else
            {
                //全データをとってくる
                listViewEmployee = listAllEmployee;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewEmployee = EmployeeDataAccess.GetEmployeeDspData(listViewEmployee);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewEmployee = EmployeeDataAccess.GetEmployeeNotDspData(listViewEmployee);
            }

            return listViewEmployee;
        }

        ///////////////////////////////
        //メソッド名：UpdateEmployee()
        //引　数   ：社員情報
        //戻り値   ：なし
        //機　能   ：社員情報の更新
        ///////////////////////////////
        private void UpdateEmployee(M_Employee updEmployee)
        {
            // 社員情報の更新
            bool flg = EmployeeDataAccess.UpdateEmployeeData(updEmployee);
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
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_Employee> viewEmployee)
        {
            //中身を消去
            dgvEmployee.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewEmployee.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewEmployee.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvEmployeeに挿入
            foreach (var item in depData)
            {
                dgvEmployee.Rows.Add(item.EmID, dictionarySalesOffice[item.SoID], item.EmName, item.EmPhone,  dictionaryHidden[item.EmFlag], dictionaryPositionname[item.PoID], item.EmHiredate, item.EmHidden);
            }

            //dgvClientをリフレッシュ
            dgvEmployee.Refresh();

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
        //メソッド名：EmployeeDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報更新の実行
        ///////////////////////////////
        private void EmployeeDataUpdate()
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

            // 社員情報作成
            var updEmployee = GenerateDataAtUpdate();

            // 社員情報更新
            UpdateEmployee(updEmployee);
        }
        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbEmployeeID.Text = string.Empty;
            txbEmployeeName.Text = string.Empty;
            txbEmployeePhone.Text = string.Empty;
            txbHidden.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            cmbPositionName.SelectedIndex = -1;
            cmbHidden.SelectedIndex = -1;
            dtpEmployeeHireDate.Text = string.Empty;


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
            // 社員IDの適否
            if (!String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                // 社員IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbEmployeeID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //社員IDの存在チェック
                if (!employeeDataAccess.CheckEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("社員IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("社員IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeID.Focus();
                return false;
            }

            // 社員名の適否
            if (!String.IsNullOrEmpty(txbEmployeeName.Text.Trim()))
            {
                // 社員名の文字数チェック
                if (txbEmployeeName.TextLength >= 50)
                {
                    MessageBox.Show("社員名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("社員名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeName.Focus();
                return false;
            }

            //営業所選択の適否
            if (cmbSalesOfficeID.SelectedIndex == -1)
            {
                MessageBox.Show("営業所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSalesOfficeID.Focus();
                return false;
            }

            //役職選択の適否
            if (cmbPositionName.SelectedIndex == -1)
            {
                MessageBox.Show("役職名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPositionName.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbEmployeePhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbEmployeePhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeePhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeName.Focus();
                return false;
            }

            //表示非表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示選択が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
                return false;
            }
            else if (cmbHidden.SelectedIndex == 1)
            {
                //受注テーブルにおける社員IDの存在チェック
                if (orderDataAccess.CheckOrderEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが受注テーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //注文テーブルにおける社員IDの存在チェック
                if (chumonDataAccess.CheckChumonEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが注文テーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //出庫テーブルにおける社員IDの存在チェック
                if (syukkoDataAccess.CheckSyukkoEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが出庫テーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //入荷テーブルにおける社員IDの存在チェック
                if (arrivalDataAccess.CheckArrivalEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが入荷テーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //出荷テーブルにおける社員IDの存在チェック
                if (shipmentDataAccess.CheckShipmentEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが出荷テーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //発注テーブルにおける社員IDの存在チェック
                if (hattyuDataAccess.CheckHattyuEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが発注テーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //入庫テーブルにおける社員IDの存在チェック
                if (warehousingDataAccess.CheckWarehousingEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが入庫テーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //売上テーブルにおける社員IDの存在チェック
                if (saleDataAccess.CheckSaleEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが売上テーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //操作ログテーブルにおける社員IDの存在チェック
                if (operationLogAccess.CheckOperationLogEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("指定された社員IDが操作ログテーブルで使用されています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }

            return true;
        }
       

        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：社員更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_Employee GenerateDataAtUpdate()
        {
            return new M_Employee
            {
                EmID = int.Parse(txbEmployeeID.Text.Trim()),
                EmName = txbEmployeeName.Text.Trim(),
                EmHidden = txbHidden.Text.Trim(),
                EmPhone = txbEmployeePhone.Text.Trim(),
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                PoID = cmbPositionName.SelectedIndex+ 1,
                EmHiredate = dtpEmployeeHireDate.Value,
                EmFlag = cmbHidden.SelectedIndex ,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：社員情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strEmployeeID = txbEmployeeID.Text.Trim();
            int intEmployeeID = 0;

            if (!String.IsNullOrEmpty(strEmployeeID))
            {
                intEmployeeID = int.Parse(strEmployeeID);
            }
            DateTime? dateEmployee = null;

            if (dtpEmployeeHireDate.Checked)
            {
                dateEmployee = dtpEmployeeHireDate.Value.Date;
            }

            // 検索条件のセット
            M_Employee selectCondition = new M_Employee()
            {
                EmID = intEmployeeID,
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                EmPhone = txbEmployeePhone.Text.Trim(),
                PoID = cmbPositionName.SelectedIndex + 1,
                EmHiredate= dateEmployee,
            };

            if (searchFlg)
            {
                // 社員データのAnd抽出
                listEmployee = EmployeeDataAccess.GetAndEmployeeData(selectCondition);
            }
            else
            {
                // 社員データのOr抽出
                listEmployee = EmployeeDataAccess.GetOrEmployeeData(selectCondition);
            }
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：顧客登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Employee GenerateDataAtRegistration()
        {
            return new M_Employee
            {
                EmID = int.Parse(txbEmployeeID.Text.Trim()),
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                EmName = txbEmployeeName.Text.Trim(),
                EmPhone = txbEmployeePhone.Text.Trim(),
                EmFlag = cmbHidden.SelectedIndex,
                EmHiredate = dtpEmployeeHireDate.Value,
                EmHidden = txbHidden.Text.Trim(),
            };
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
            if (String.IsNullOrEmpty(txbEmployeeID.Text.Trim()) && cmbPositionName.SelectedIndex == -1 && cmbSalesOfficeID.SelectedIndex == -1 &&  String.IsNullOrEmpty(txbEmployeePhone.Text.Trim())&&dtpEmployeeHireDate.Checked==false)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeID.Focus();
                return false;
            }

            // 社員IDの適否
            if (!String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                // 社員IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbEmployeeID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //社員IDの重複チェック
                if (!EmployeeDataAccess.CheckEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("社員IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }

            return true;
        }
        
        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        //////////////////////////////
        private void SelectRowControl()
        {
            bool cmbflg = false;
            int intPositionID = dictionaryPositionname.FirstOrDefault(x => x.Value == dgvEmployee[5, dgvEmployee.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listPosition)
            {
                if (intPositionID == item.PoID)
                {
                    cmbflg = true;
                }
            }

            if (cmbflg)
            {
                cmbPositionName.SelectedValue = intPositionID;
            }
            else
            {
                cmbPositionName.SelectedIndex = -1;
            }

            bool cmbEmployeeflg = false;
            int intEmployeeID = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvEmployee[1, dgvEmployee.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listDGVSalesOfficeID)
            {
                if (intEmployeeID == item.SoID)
                {
                    cmbEmployeeflg = true;
                }
            }

            if (cmbEmployeeflg)
            {
                cmbSalesOfficeID.SelectedValue = intEmployeeID;
            }
            else
            {
                cmbSalesOfficeID.SelectedIndex = -1;
            }

            //データグリッドビューに乗っている情報をGUIに反映
            txbEmployeeID.Text = dgvEmployee[0, dgvEmployee.CurrentCellAddress.Y].Value.ToString();
            txbEmployeeName.Text = dgvEmployee[2, dgvEmployee.CurrentCellAddress.Y].Value.ToString();
            txbEmployeePhone.Text = dgvEmployee[3, dgvEmployee.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvEmployee[4, dgvEmployee.CurrentCellAddress.Y].Value.ToString()).Key;
            dtpEmployeeHireDate.Text = dgvEmployee[6, dgvEmployee.CurrentCellAddress.Y]?.Value.ToString();
            txbHidden.Text = dgvEmployee[7, dgvEmployee.CurrentCellAddress.Y]?.Value?.ToString();
        }

        ///////////////////////////////
        //メソッド名：EmployeeDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：社員情報検索の実行
        ///////////////////////////////
        private void EmployeeDataSelect()
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
        //メソッド名：GenerateLogAtRegistration()
        //引　数   ：操作名
        //戻り値   ：操作ログ登録情報
        //機　能   ：操作ログ情報登録データのセット
        ///////////////////////////////
        private T_OperationLog GenerateLogAtRegistration(string OperationDone)
        {
            //登録・更新使用としている顧客データの取得
            //var logOperatin = GenerateDataAtRegistration();

            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "社員管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbEmployeeID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：EmployeeSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：社員情報検索の実行
        ///////////////////////////////
        private void EmployeeSearchButtonClick(bool searchFlg)
        {
            // 社員情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listEmployee.Count;

            txbNumPage.Text = "1";

            // 社員抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dgvEmployee.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvEmployee.AllowUserToResizeColumns = false;
            dgvEmployee.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvEmployee.MultiSelect = false;
            //セルの編集ができないように
            dgvEmployee.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvEmployee.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvEmployee.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvEmployee.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvEmployee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployee.Columns.Add("EmID", "社員ID");
            dgvEmployee.Columns.Add("SoID", "営業所ID");
            dgvEmployee.Columns.Add("EmName", "社員名");
            dgvEmployee.Columns.Add("EmPhone", "電話番号");
            dgvEmployee.Columns.Add("EmFlag", "顧客管理フラグ");
            dgvEmployee.Columns.Add("PoID", "役職ID");
            dgvEmployee.Columns.Add("EmHiredate", "入社年月日");
            dgvEmployee.Columns.Add("EmHidden", "非表示理由");

            dgvEmployee.Columns["EmID"].Width = 150;
            dgvEmployee.Columns["SoID"].Width = 200;
            dgvEmployee.Columns["EmName"].Width = 250;
            dgvEmployee.Columns["EmPhone"].Width = 200;
            dgvEmployee.Columns["EmFlag"].Width = 200;
            dgvEmployee.Columns["PoID"].Width = 200;
            dgvEmployee.Columns["EmHiredate"].Width = 200;
            dgvEmployee.Columns["EmHidden"].Width = 500;

            dgvEmployee.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(69)))));
            dgvEmployee.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvEmployee.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnSinghUp_Click(object sender, EventArgs e)
        {
            F_HonshaSinghUp F_HonshaSinghUp = new F_HonshaSinghUp();

            F_HonshaSinghUp.Owner = this;
            F_HonshaSinghUp.FormClosed += ChildForm_FormClosed;
            F_HonshaSinghUp.Show();

            this.Opacity = 0;
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
                FileName = "https://docs.google.com/document/d/1RWxzdr9jwJ9XMEOzMnPCcXIOtXWPXqC9",
                UseShellExecute = true
            });
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                txbEmployeeID.Enabled = true;
                txbEmployeePhone.Enabled = true;
                txbEmployeePhone.Enabled=true;
                cmbSalesOfficeID.Enabled = true;
                cmbPositionName.Enabled = true;

                txbHidden.Enabled = false;
                cmbHidden.Enabled = false;
                txbEmployeeName.Enabled = false;
            }

            if (rdbUpdate.Checked)
            {
                txbEmployeeID.Enabled = true;
                txbEmployeePhone.Enabled = true;
                txbEmployeePhone.Enabled = true;
                cmbSalesOfficeID.Enabled = true;
                cmbPositionName.Enabled = true;
                txbHidden.Enabled = true;
                cmbHidden.Enabled = true;
                txbEmployeeName.Enabled = true;
            }

        }
    }
}

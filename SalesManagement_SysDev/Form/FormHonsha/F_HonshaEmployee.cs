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
    public partial class F_HonshaEmployee : Form
    {
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess EmployeeDataAccess = new EmployeeDataAccess();
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース役所テーブルアクセス用クラスのインスタンス化
        PositionDataAccess PositionDataAccess = new PositionDataAccess();
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

        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };

        //DataGridView用に使用す営業所のDictionary
        private Dictionary<int?, string> dictionarySalesOffice = new Dictionary<int?, string>
        {
            { 1, "北大阪営業所" },
            { 2, "兵庫営業所" },
            { 3, "鹿営業所"},
            { 4, "京都営業所"},
            { 5, "和歌山営業所"}
        };

        //DataGridView用に使用す役職のDictionary
        private Dictionary<int?, string> dictionaryPositionname = new Dictionary<int?, string>
        {
            { 1, "管理者" },
            { 2, "営業" },
            { 3, "物流"},
        };

        public F_HonshaEmployee()
        {
            InitializeComponent();
        }
        private void F_HonshaEmployee_Load(object sender, EventArgs e)
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

            //役職のデータを取得
            listPosition = PositionDataAccess.GetPositionDspData();
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

        private void lblClient_Click(object sender, EventArgs e)
        {

        }

        private void F_HonshaEmploye_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbUpdate.Checked = true;

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
                dgvEmployee.Rows.Add(item.EmID, dictionarySalesOffice[item.SoID], item.EmName, item.EmPhone,  dictionaryHidden[item.EmFlag], dictionaryPositionname[item.PoID], item.EmHidden);
            }

            //dgvClientをリフレッシュ
            dgvEmployee.Refresh();

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

            // 検索条件のセット
            M_Employee selectCondition = new M_Employee()
            {
                EmID = intEmployeeID,
               EmName = txbEmployeeName.Text.Trim(),
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                EmPhone = txbEmployeePhone.Text.Trim(),
                //ClPostal= txbClientPostal.Text.Trim(),
                //ClAddress= txbClientAddress.Text.Trim(),
                //ClFAX=txbClientFax.Text.Trim(),
                EmHidden=txbHidden.Text.Trim()
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
            if (String.IsNullOrEmpty(txbEmployeeID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbEmployeePhone.Text.Trim()))
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
            //データグリッドビューに乗っている情報をGUIに反映
            txbEmployeeID.Text = dgvEmployee[0, dgvEmployee.CurrentCellAddress.Y].Value.ToString();
            cmbSalesOfficeID.SelectedIndex = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvEmployee[1, dgvEmployee.CurrentCellAddress.Y].Value.ToString()).Key.Value - 1;
            cmbPositionName.SelectedIndex = dictionaryPositionname.FirstOrDefault(x => x.Value == dgvEmployee[5, dgvEmployee.CurrentCellAddress.Y].Value.ToString()).Key.Value - 1;
            txbEmployeeName.Text = dgvEmployee[2, dgvEmployee.CurrentCellAddress.Y].Value.ToString();
            txbEmployeePhone.Text = dgvEmployee[3, dgvEmployee.CurrentCellAddress.Y].Value.ToString();
          //  txbCEmployeePostal.Text = dgvEmployee[5, dgvEmployee.CurrentCellAddress.Y].Value.ToString();
          //  txbEmployeeFAX.Text = dgvEmployee[6, dgvEmployee.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvEmployee[4, dgvEmployee.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvEmployee[6, dgvEmployee.CurrentCellAddress.Y]?.Value?.ToString();
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
            var logOperatin = GenerateDataAtRegistration();

            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "社員管理画面",
                OpDone = OperationDone,
                OpDBID = logOperatin.EmID,
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
            dgvEmployee.Columns.Add("EmHidden", "非表示理由");
  
            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvEmployee.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            GetDataGridView();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_EigyoOrder : Form
    {
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDetailDataAccess orderDetailDataAccess = new OrderDetailDataAccess();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //データベース注文テーブルアクセス用クラスのインスタンス化
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //コンボボックス用の顧客データリスト
        private static List<M_Client> listClient = new List<M_Client>();
        //コンボボックス用の社員データリスト
        private static List<M_Employee> listEmployee = new List<M_Employee>();
        //コンボボックス用の社員データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //データグリッドビュー用の顧客データ
        private static List<T_Order> listOrder = new List<T_Order>();
        //データグリッドビュー用の顧客データ
        private static List<T_OrderDetail> listOrderDetail = new List<T_OrderDetail>();
        //データグリッドビュー用の全顧客データ
        private static List<T_Order> listAllOrder = new List<T_Order>();

        //DataGridView用に使用する営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;
        //DataGridView用に使用する顧客のDictionary
        private Dictionary<int, string> dictionaryClient;
        //DataGridView用に使用する社員のDictionary
        private Dictionary<int, string> dictionaryEmployee;
        //DataGridView用に使用する商品のDictionary
        private Dictionary<int, string> dictionaryProdact;

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

        public F_EigyoOrder()
        {
            InitializeComponent();
        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
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

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<T_Order> viewOrder = SetListOrder();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewOrder.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvOrder.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();

            SetDataDetailGridView(int.Parse(dgvOrder[0, dgvOrder.CurrentCellAddress.Y].Value.ToString()));

            ClearImputDetail();
        }

        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvOrderDetail.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowDetailControl();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
        }

        private void btnDetailClear_Click(object sender, EventArgs e)
        {
            ClearImputDetail();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void F_EigyoOrder_Load(object sender, EventArgs e)
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

        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                OrderDataRegister();
            }

            //詳細登録ラヂオボタンがチェックされているとき
            if (rdbDetailRegister.Checked)
            {
                OrderDetailDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                OrderDataUpdate();
            }

            //確定ラヂオボタンがチェックされているとき
            if (rdbConfirm.Checked)
            {
                OrderDataConfirm();
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
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
                txbProductName.Text = "商品IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Prodact = listProdact.Single(x => x.PrID == intProdactID);

            txbProductName.Text = Prodact.PrName;
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
                txbClientName.Text = "社員IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Client = listClient.Single(x => x.ClID == intClientID);

            txbClientName.Text = Client.ClName;
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

            //商品のデータを取得
            listProdact = prodactDataAccess.GetProdactDspData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listProdact)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
            }
        }

        ///////////////////////////////
        //メソッド名：OrderDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：受注情報登録の実行
        ///////////////////////////////
        private void OrderDataRegister()
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
            var regOrder = GenerateDataAtRegistration();

            // 受注情報登録
            RegistrationOrder(regOrder);
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
                //受注IDの存在チェック
                if (orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("受注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbOrderID.Focus();
                return false;
            }

            //営業所選択の適否
            if (cmbSalesOfficeID.SelectedIndex == -1)
            {
                MessageBox.Show("営業所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSalesOfficeID.Focus();
                return false;
            }

            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbClientID.Text.Trim()))
            {
                // 顧客IDの存在チェック
                if (!clientDataAccess.CheckClientIDExistence(int.Parse(txbClientID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("顧客IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientID.Focus();
                return false;
            }

            // 顧客担当者名の適否
            if (!String.IsNullOrEmpty(txbOrderManager.Text.Trim()))
            {
                // 顧客担当者名の文字数チェック
                if (txbOrderManager.TextLength >= 50)
                {
                    MessageBox.Show("顧客担当者名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderManager.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("顧客担当者名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbOrderManager.Focus();
                return false;
            }

            // 社員IDの適否
            if (!String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                //社員IDの存在チェック
                if (!employeeDataAccess.CheckEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("社員IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //社員IDが現在ログインしているIDと等しいかチェック
                if (F_Login.intEmployeeID == int.Parse(txbEmployeeID.Text.Trim()))
                {
                    MessageBox.Show("自身の社員IDを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：受注登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private T_Order GenerateDataAtRegistration()
        {
            return new T_Order
            {
                OrID = int.Parse(txbOrderID.Text.Trim()),
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                EmID = F_Login.intEmployeeID,
                ClID = clientDataAccess.GetClientID(txbClientName.Text.Trim()),
                ClCharge = txbOrderManager.Text.Trim(),
                OrDate = dtpOrderDate.Value,
                OrStateFlag = 0,
                OrFlag = cmbHidden.SelectedIndex,
                OrHidden = txbHidden.Text.Trim(),
            };
        }

        ///////////////////////////////
        //メソッド名：RegistrationOrder()
        //引　数   ：受注情報
        //戻り値   ：なし
        //機　能   ：受注データの登録
        ///////////////////////////////
        private void RegistrationOrder(T_Order regOrder)
        {
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            // 受注情報の登録
            bool flg = orderDataAccess.AddOrderData(regOrder);

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
        //メソッド名：OrderDetailDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：受注詳細情報登録の実行
        ///////////////////////////////
        private void OrderDetailDataRegister()
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

            // 受注情報作成
            var regOrder = GenerateDetailDataAtRegistration();

            // 受注情報登録
            RegistrationOrderDetail(regOrder);
        }

        ///////////////////////////////
        //メソッド名：GetValidDetailDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：登録入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDetailDataAtRegistration()
        {
            //受注詳細IDの適否
            if (!String.IsNullOrEmpty(txbOrderDetailID.Text.Trim()))
            {
                //受注詳細IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbOrderDetailID.Text.Trim()))
                {
                    MessageBox.Show("受注詳細IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderDetailID.Focus();
                    return false;
                }
                //受注詳細IDの存在チェック
                if (orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderDetailID.Text.Trim())))
                {
                    MessageBox.Show("受注詳細IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderDetailID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("受注詳細IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbOrderDetailID.Focus();
                return false;
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
                //受注IDの存在チェック
                if (!orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("受注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbOrderID.Focus();
                return false;
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDetailDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：受注詳細登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private T_OrderDetail GenerateDetailDataAtRegistration()
        {
            M_Product Prodact = prodactDataAccess.GetIDProdactData(int.Parse(txbProductID.Text.Trim()));

            return new T_OrderDetail
            {
                OrDetailID = int.Parse(txbOrderDetailID.Text.Trim()),
                OrID = int.Parse(txbOrderID.Text.Trim()),
                PrID = int.Parse(txbProductID.Text.Trim()),
                OrQuantity = int.Parse(txbOrderQuantity.Text.Trim()),
                OrTotalPrice = int.Parse(txbOrderQuantity.Text.Trim()) * Prodact.Price
            };
        }

        ///////////////////////////////
        //メソッド名：RegistrationOrderDetail()
        //引　数   ：受注詳細情報
        //戻り値   ：なし
        //機　能   ：受注詳細データの登録
        ///////////////////////////////
        private void RegistrationOrderDetail(T_OrderDetail regOrder)
        {
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            // 受注情報の登録
            bool flg = orderDetailDataAccess.AddOrderDetailData(regOrder);

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
            SetDataDetailGridView(int.Parse(txbOrderID.Text.Trim()));

            // 入力エリアのクリア
            ClearImput();
            ClearImputDetail();
        }

        ///////////////////////////////
        //メソッド名：OrderDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：受注情報更新の実行
        ///////////////////////////////
        private void OrderDataUpdate()
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
                // 受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbOrderID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (!orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
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
        //戻り値   ：受注更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private T_Order GenerateDataAtUpdate()
        {
            return new T_Order
            {
                OrID = int.Parse(txbOrderID.Text.Trim()),
                OrFlag = cmbHidden.SelectedIndex,
                OrHidden = txbHidden.Text.Trim(),
            };
        }

        ///////////////////////////////
        //メソッド名：UpdateOrder()
        //引　数   ：受注情報
        //戻り値   ：なし
        //機　能   ：受注情報の更新
        ///////////////////////////////
        private void UpdateOrder(T_Order updOrder)
        {
            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("更新しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            // 受注情報の更新
            bool flg = orderDataAccess.UpdateOrderData(updOrder);

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
            ClearImputDetail();

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：OrderDataConfirm()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：受注情報確定の実行
        ///////////////////////////////
        private void OrderDataConfirm()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtConfirm())
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

            // 受注情報作成
            var cmfOrder = GenerateDataAtConfirm();

            // 受注情報更新
            ConfirmOrder(cmfOrder);
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
            //受注IDの適否
            if (!String.IsNullOrEmpty(txbOrderID.Text.Trim()))
            {
                // 受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbOrderID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (!orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }

                T_Order order = orderDataAccess.GetIDOrderData(int.Parse(txbOrderID.Text.Trim()));

                //受注IDの確定チェック
                if (order.OrStateFlag == 1) 
                {
                    MessageBox.Show("受注IDはすでに確定しています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("受注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbOrderID.Focus();
                return false;
            }

            //確定選択の適否
            if (cmbConfirm.SelectedIndex == -1)
            {
                MessageBox.Show("未確定/確定が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbConfirm.Focus();
                return false;
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtConfirm()
        //引　数   ：なし
        //戻り値   ：受注確定情報
        //機　能   ：確定データのセット
        ///////////////////////////////
        private T_Order GenerateDataAtConfirm()
        {
            return new T_Order
            {
                OrID = int.Parse(txbOrderID.Text.Trim()),
                OrStateFlag = cmbConfirm.SelectedIndex,
            };
        }

        ///////////////////////////////
        //メソッド名：ConfirmOrder()
        //引　数   ：受注情報
        //戻り値   ：なし
        //機　能   ：受注情報の確定
        ///////////////////////////////
        private void ConfirmOrder(T_Order cfmOrder)
        {
            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("確定しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            // 受注情報の更新
            bool flg = orderDataAccess.ConfirmOrderData(cfmOrder);

            if (flg == true)
            {
                MessageBox.Show("確定しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("確定に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            T_Order Order = orderDataAccess.GetIDOrderData(int.Parse(txbOrderID.Text.Trim()));

            T_Chumon Chumon = GenerateChumonAtRegistration(Order);

            bool flgChumon = chumonDataAccess.AddChumonData(Chumon);

            if (flg == true)
            {
                MessageBox.Show("注文管理にデータを送信ました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("注文管理へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //テキストボックス等のクリア
            ClearImput();
            ClearImputDetail();

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GenerateChumonAtRegistration()
        //引　数   ：注文情報
        //戻り値   ：注文登録情報
        //機　能   ：注文登録データのセット
        ///////////////////////////////
        private T_Chumon GenerateChumonAtRegistration(T_Order Order)
        {
            return new T_Chumon
            {
                ChID = Order.OrID,
                SoID = Order.SoID,
                ClID = Order.ClID,
                OrID = Order.OrID,
                ChDate = DateTime.Now,
            };
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
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの初期設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //列を自由に設定できるように
            dgvOrder.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvOrder.AllowUserToResizeColumns = false;
            dgvOrder.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvOrder.MultiSelect = false;
            //セルの編集ができないように
            dgvOrder.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvOrder.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvOrder.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvOrder.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrder.Columns.Add("OrID", "受注ID");
            dgvOrder.Columns.Add("SoID", "営業所名");
            dgvOrder.Columns.Add("ClName", "顧客名");
            dgvOrder.Columns.Add("ClCharge", "顧客担当者名");
            dgvOrder.Columns.Add("EmName", "社員名");
            dgvOrder.Columns.Add("OrDate", "受注年月日");
            dgvOrder.Columns.Add("OrFlag", "受注管理フラグ");
            dgvOrder.Columns.Add("OrStateFlag", "受注情報フラグ");
            dgvOrder.Columns.Add("OrHidden", "非表示理由");

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvOrder.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvOrderDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvOrderDetail.AllowUserToResizeColumns = false;
            dgvOrderDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvOrderDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvOrderDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvOrderDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvOrderDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvOrderDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvOrderDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrderDetail.Columns.Add("OrID", "受注ID");
            dgvOrderDetail.Columns.Add("OrDetailID", "受注詳細ID");
            dgvOrderDetail.Columns.Add("PrID", "商品ID");
            dgvOrderDetail.Columns.Add("OrQuantity", "数量");
            dgvOrderDetail.Columns.Add("OrTotalPrice", "合計金額");

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvOrderDetail.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
            List<T_Order> listViewOrder = SetListOrder();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewOrder);
        }
        
        ///////////////////////////////
        //メソッド名：SetListOrder()
        //引　数   ：なし
        //戻り値   ：表示用受注データ
        //機　能   ：表示用受注データの準備
        ///////////////////////////////
        private List<T_Order> SetListOrder()
        {
            //受注のデータを全取得
            listAllOrder = orderDataAccess.GetOrderData();

            //表示用の受注リスト作成
            List<T_Order> listViewOrder = new List<T_Order>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewOrder = listOrder;
            }
            else
            {
                //全データをとってくる
                listViewOrder = listAllOrder;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewOrder = orderDataAccess.GetOrderDspData(listViewOrder);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewOrder = orderDataAccess.GetOrderNotDspData(listViewOrder);
            }

            return listViewOrder;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Order> viewOrder)
        {
            //中身を消去
            dgvOrder.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewOrder.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewOrder.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvOrder.Rows.Add(item.OrID, dictionarySalesOffice[item.SoID], dictionaryClient[item.ClID], item.ClCharge, dictionaryEmployee[item.EmID], item.OrDate, dictionaryHidden[item.OrFlag], dictionaryConfirm[item.OrStateFlag], item.OrHidden);
            }

            //dgvClientをリフレッシュ
            dgvOrder.Refresh();

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
        //メソッド名：SetDataDetailGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：詳細データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataDetailGridView(int intOrderID)
        {
            dgvOrderDetail.Rows.Clear();

            listOrderDetail = orderDetailDataAccess.GetOrderDetailIDData(intOrderID);

            //1行ずつdgvClientに挿入
            foreach (var item in listOrderDetail)
            {
                dgvOrderDetail.Rows.Add(item.OrID, item.OrDetailID, dictionaryProdact[item.PrID], item.OrQuantity, item.OrTotalPrice);
            }

            //dgvClientをリフレッシュ
            dgvOrderDetail.Refresh();
        }

        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールのクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbOrderID.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            txbClientID.Text = string.Empty;
            txbClientName.Text = string.Empty;
            txbOrderManager.Text = string.Empty;
            txbEmployeeID.Text = string.Empty;
            txbEmployeeName.Text = string.Empty;
            dtpOrderDate.Value = DateTime.Now;
            cmbHidden.SelectedIndex = -1;
            cmbConfirm.SelectedIndex = -1;
            txbHidden.Text = string.Empty;
        }

        ///////////////////////////////
        //メソッド名：ClearImputDetail()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールのクリア(Detail)
        ///////////////////////////////
        private void ClearImputDetail()
        {
            txbOrderDetailID.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbProductName.Text = string.Empty;
            txbOrderQuantity.Text = string.Empty;
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
            txbOrderID.Text = dgvOrder[0, dgvOrder.CurrentCellAddress.Y].Value.ToString();
            cmbSalesOfficeID.SelectedIndex = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvOrder[1, dgvOrder.CurrentCellAddress.Y].Value.ToString()).Key - 1;
            txbClientID.Text = dictionaryClient.FirstOrDefault(x => x.Value == dgvOrder[2, dgvOrder.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            txbOrderManager.Text = dgvOrder[3, dgvOrder.CurrentCellAddress.Y].Value.ToString();
            txbEmployeeID.Text = dictionaryEmployee.FirstOrDefault(x => x.Value == dgvOrder[4, dgvOrder.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            dtpOrderDate.Text = dgvOrder[5, dgvOrder.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvOrder[6, dgvOrder.CurrentCellAddress.Y].Value.ToString()).Key;
            cmbConfirm.SelectedIndex = dictionaryConfirm.FirstOrDefault(x => x.Value == dgvOrder[7, dgvOrder.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvOrder[8, dgvOrder.CurrentCellAddress.Y]?.Value?.ToString();
        }

        ///////////////////////////////
        //メソッド名：SelectRowDetailControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更(Detail)
        ///////////////////////////////
        private void SelectRowDetailControl()
        {
            //データグリッドビューに乗っている情報をGUIに反映
            txbOrderDetailID.Text = dgvOrderDetail[1, dgvOrderDetail.CurrentCellAddress.Y].Value.ToString();
            txbProductID.Text = dictionaryProdact.FirstOrDefault(x => x.Value == dgvOrderDetail[2, dgvOrderDetail.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            txbOrderQuantity.Text = dgvOrderDetail[3, dgvOrderDetail.CurrentCellAddress.Y].Value.ToString();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

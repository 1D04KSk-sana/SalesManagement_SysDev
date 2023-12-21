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
    public partial class F_HonshaClient : Form
    {
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の顧客データ
        private static List<M_Client> listClient = new List<M_Client>();
        //データグリッドビュー用の全顧客データ
        private static List<M_Client> listAllClient = new List<M_Client>();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //DataGridView用に使用す営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        { 
            { 0, "表示" },
            { 1, "非表示" },
        };

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

        }

        public F_HonshaClient()
        {
            InitializeComponent();
        }

        private void F_HonshaClient_Load(object sender, EventArgs e)
        {
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

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
        }

        private void rdoSElect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRegister.Checked)
            {
                var context = new SalesManagement_DevContext();

                txbClientID.Text = (context.M_Clients.Count() + 1).ToString();
            }
            else
            {
                txbClientID.Text = string.Empty;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbRegister.Checked = true;

            GetDataGridView();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                ClientDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                ClientDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ClientDataSelect();
            }
        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
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
            List<M_Client> viewClient = SetListClient();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewClient.Count / (double)pageSize);

            if (lastPage == 0)
            {
                lastPage++;
            }

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }

        private void txbPageSizeID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbNumPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void dgvRecordEditing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvClient.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ClientSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ClientSearchButtonClick(false);
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {

            }
            else
            {

            }

            if (rdbUpdate.Checked)
            {

            }
            else
            {

            }

            if (rdbRegister.Checked)
            {

            }
            else
            {

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
                FormName = "顧客管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbClientID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：ClientDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報登録の実行
        ///////////////////////////////
        private void ClientDataRegister()
        {
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //テキストボックス等の入力チェック
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

            // 顧客情報作成
            var regClient = GenerateDataAtRegistration();

            // 顧客情報登録
            RegistrationClient(regClient);
        }

        ///////////////////////////////
        //メソッド名：RegistrationClient()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客データの登録
        ///////////////////////////////
        private void RegistrationClient(M_Client regClient)
        {
            // 顧客情報の登録
            bool flg = clientDataAccess.AddClientData(regClient);

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

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：顧客登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Client GenerateDataAtRegistration()

        {
            return new M_Client
            {
                ClID = int.Parse(txbClientID.Text.Trim()),
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                ClName = txbClientName.Text.Trim(),
                ClAddress = txbClientAddress.Text.Trim(),
                ClPhone = txbClientPhone.Text.Trim(),
                ClPostal = txbClientPostal.Text.Trim(),
                ClFAX = txbClientFAX.Text.Trim(),
                ClFlag = cmbHidden.SelectedIndex,
                ClHidden = txbHidden.Text.Trim(),
            };
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
                if (clientDataAccess.CheckClientIDExistence(int.Parse(txbClientID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // 顧客名の適否
            if (!String.IsNullOrEmpty(txbClientName.Text.Trim()))
            {
                // 顧客名の文字数チェック
                if (txbClientName.TextLength >= 50)
                {
                    MessageBox.Show("顧客名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("顧客名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientName.Focus();
                return false;
            }

            //営業所選択の適否
            if (cmbSalesOfficeID.SelectedIndex == -1)
            {
                MessageBox.Show("営業所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSalesOfficeID.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbClientPhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbClientPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientName.Focus();
                return false;
            }


            // 郵便番号の適否
            if (!String.IsNullOrEmpty(txbClientPostal.Text.Trim()))
            {
                // 郵便番号の数字チェック
                if (!dataInputCheck.CheckNumeric(txbClientPostal.Text.Trim()))
                {
                    MessageBox.Show("郵便番号は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientPostal.Focus();
                    return false;
                }
                // 郵便番号の文字数チェック
                if (txbClientPostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientPostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientPostal.Focus();
                return false;
            }

            // 住所の適否
            if (!String.IsNullOrEmpty(txbClientAddress.Text.Trim()))
            {
                // 住所の文字数チェック
                if (txbClientAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientAddress.Focus();
                return false;
            }

            // FAXの適否
            if (!String.IsNullOrEmpty(txbClientFAX.Text.Trim()))
            {
                // FAXの文字数チェック
                if (txbClientFAX.TextLength > 13)
                {
                    MessageBox.Show("FAXは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientFAX.Focus();
                return false;
            }

            //表示非表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示家選択が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
                return false;
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：ClientDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報更新の実行
        ///////////////////////////////
        private void ClientDataUpdate()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtUpdate())
            {
                return;
            }

            // 顧客情報作成
            var updClient = GenerateDataAtUpdate();

            // 顧客情報更新
            UpdateClient(updClient);
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：顧客更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_Client GenerateDataAtUpdate()
        {
            return new M_Client
            {
                ClID = int.Parse(txbClientID.Text.Trim()),
                ClName = txbClientName.Text.Trim(),
                ClHidden = txbHidden.Text.Trim(),
                ClPhone = txbClientPhone.Text.Trim(),
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                ClPostal = txbClientPostal.Text.Trim(),
                ClAddress = txbClientAddress.Text.Trim(),
                ClFAX = txbClientFAX.Text.Trim(),
                ClFlag = cmbHidden.SelectedIndex,
            };
        }

        ///////////////////////////////
        //メソッド名：UpdateClient()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客情報の更新
        ///////////////////////////////
        private void UpdateClient(M_Client updClient)
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

            // 顧客情報の更新
            bool flg = clientDataAccess.UpdateClientData(updClient);
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
        //メソッド名：GetValidDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：更新入力データの形式チェック
        //         ：エラーがない場合True
        //         ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtUpdate()
        {
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
                //顧客IDの存在チェック
                if (!clientDataAccess.CheckClientIDExistence(int.Parse(txbClientID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // 顧客名の適否
            if (!String.IsNullOrEmpty(txbClientName.Text.Trim()))
            {
                // 顧客名の文字数チェック
                if (txbClientName.TextLength >= 50)
                {
                    MessageBox.Show("顧客名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("顧客名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientName.Focus();
                return false;
            }

            //営業所選択の適否
            if (cmbSalesOfficeID.SelectedIndex == -1)
            {
                MessageBox.Show("営業所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSalesOfficeID.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbClientPhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbClientPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientName.Focus();
                return false;
            }


            // 郵便番号の適否
            if (!String.IsNullOrEmpty(txbClientPostal.Text.Trim()))
            {
                // 郵便番号の数字チェック
                if (!dataInputCheck.CheckNumeric(txbClientPostal.Text.Trim()))
                {
                    MessageBox.Show("郵便番号は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientPostal.Focus();
                    return false;
                }
                // 郵便番号の文字数チェック
                if (txbClientPostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientPostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientPostal.Focus();
                return false;
            }

            // 住所の適否
            if (!String.IsNullOrEmpty(txbClientAddress.Text.Trim()))
            {
                // 住所の文字数チェック
                if (txbClientAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientAddress.Focus();
                return false;
            }

            // FAXの適否
            if (!String.IsNullOrEmpty(txbClientFAX.Text.Trim()))
            {
                // FAXの文字数チェック
                if (txbClientFAX.TextLength > 13)
                {
                    MessageBox.Show("FAXは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientFAX.Focus();
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
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：顧客情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strClientID = txbClientID.Text.Trim();
            int intClientID = 0;

            if (!String.IsNullOrEmpty(strClientID))
            {
                intClientID = int.Parse(strClientID);
            }

            // 検索条件のセット
            M_Client selectCondition = new M_Client()
            {
                ClID =intClientID,
                SoID= cmbSalesOfficeID.SelectedIndex + 1,
                ClPhone = txbClientPhone.Text.Trim(),
            };

            if (searchFlg)
            {
                // 顧客データのAnd抽出
                listClient = clientDataAccess.GetAndClientData(selectCondition);
            }
            else
            {
                // 顧客データのOr抽出
                listClient = clientDataAccess.GetOrClientData(selectCondition);
            }
        }

        ///////////////////////////////
        //メソッド名：ClientSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void ClientSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listClient.Count;

            txbNumPage.Text = "1";

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (String.IsNullOrEmpty(txbClientID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbClientPhone.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClientID.Focus();
                return false;
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

            return true;
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
            txbClientID.Text = dgvClient[0, dgvClient.CurrentCellAddress.Y].Value.ToString();
            cmbSalesOfficeID.SelectedIndex = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvClient[1, dgvClient.CurrentCellAddress.Y].Value.ToString()).Key - 1;
            txbClientName.Text = dgvClient[2, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientAddress.Text = dgvClient[3, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientPhone.Text = dgvClient[4, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientPostal.Text = dgvClient[5, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientFAX.Text = dgvClient[6, dgvClient.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvClient[7, dgvClient.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvClient[8, dgvClient.CurrentCellAddress.Y]?.Value?.ToString();
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
            dgvClient.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvClient.AllowUserToResizeColumns = false;
            dgvClient.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvClient.MultiSelect = false;
            //セルの編集ができないように
            dgvClient.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvClient.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvClient.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvClient.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvClient.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvClient.Columns.Add("ClID", "顧客ID");
            dgvClient.Columns.Add("SoID", "営業所ID");
            dgvClient.Columns.Add("ClName", "顧客名");
            dgvClient.Columns.Add("ClAddress", "住所");
            dgvClient.Columns.Add("ClPhone", "電話番号");
            dgvClient.Columns.Add("ClPostal", "郵便番号");
            dgvClient.Columns.Add("ClFAX", "FAX");
            dgvClient.Columns.Add("ClFlag", "顧客管理フラグ");
            dgvClient.Columns.Add("ClHidden", "非表示理由");

            dgvClient.Columns["ClID"].Width = 120;
            dgvClient.Columns["SoID"].Width = 200;
            dgvClient.Columns["ClName"].Width = 160;
            dgvClient.Columns["ClAddress"].Width = 400;
            dgvClient.Columns["ClPhone"].Width = 180;
            dgvClient.Columns["ClPostal"].Width = 150;
            dgvClient.Columns["ClFAX"].Width = 180;
            dgvClient.Columns["ClFlag"].Width = 170;
            dgvClient.Columns["ClHidden"].Width = 337;


            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvClient.Columns)
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
            //表示用の顧客リスト作成
            List<M_Client> listViewClient = SetListClient();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewClient);
        }

        ///////////////////////////////
        //メソッド名：SetListClient()
        //引　数   ：なし
        //戻り値   ：表示用顧客データ
        //機　能   ：表示用顧客データの準備
        ///////////////////////////////
        private List<M_Client> SetListClient()
        {
            //顧客のデータを全取得
            listAllClient = clientDataAccess.GetClientData();

            //表示用の顧客リスト作成
            List<M_Client> listViewClient = new List<M_Client>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewClient = listClient;
            }
            else
            {
                //全データをとってくる
                listViewClient = listAllClient;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewClient = clientDataAccess.GetClientDspData(listViewClient);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewClient = clientDataAccess.GetClientNotDspData(listViewClient);
            }

            return listViewClient;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_Client> viewClient)
        {
            //中身を消去
            dgvClient.Rows.Clear();
            
            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewClient.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewClient.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvClient.Rows.Add(item.ClID, dictionarySalesOffice[item.SoID], item.ClName, item.ClAddress, item.ClPhone, item.ClPostal, item.ClFAX, dictionaryHidden[item.ClFlag], item.ClHidden);
            }

            //dgvClientをリフレッシュ
            dgvClient.Refresh();

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
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbClientID.Text = string.Empty;
            txbClientName.Text = string.Empty;
            txbClientPhone.Text = string.Empty;
            txbClientPostal.Text = string.Empty;
            txbClientAddress.Text = string.Empty;
            txbClientAddress.Text = string.Empty;
            txbHidden.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            cmbHidden.SelectedIndex = -1;
            txbClientFAX.Text = string.Empty;
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
                FileName = "https://docs.google.com/document/d/1tSBtymj0B82Q-tjiNp3mP2HDdMxDpypI",
                UseShellExecute = true
            });
        }

    }
}

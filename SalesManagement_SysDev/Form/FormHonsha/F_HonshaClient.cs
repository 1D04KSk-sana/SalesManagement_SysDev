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
    public partial class F_HonshaClient : Form
    {
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の顧客データ
        private static List<M_Client> listClient = new List<M_Client>();

        public F_HonshaClient()
        {
            InitializeComponent();
        }

        private void F_HonshaClient_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
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

        private void dgvRecordEditing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvClient.SelectedCells.Count == 0)
            {
                return;
            }

            SelectRowControl();
        }

        ///////////////////////////////
        //メソッド名：ClientDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報登録の実行
        ///////////////////////////////
        private void ClientDataRegister()
        {

            // 部署情報作成
            var regClient = GenerateDataAtRegistration();

            // 部署情報登録
            RegistrationClient(regClient);
        }

        ///////////////////////////////
        //メソッド名：RegistrationDivision()
        //引　数   ：部署情報
        //戻り値   ：なし
        //機　能   ：部署データの登録
        ///////////////////////////////
        private void RegistrationClient(M_Client regClient)
        {
            // 部署情報の登録
            bool flg = clientDataAccess.AddClientData(regClient);

            //登録成功・失敗メッセージ
            if (flg == true)
            {
                MessageBox.Show("データを登録しました。");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました。");
            }

            // 入力エリアのクリア
            ClearImput();

            // データグリッドビューの表示
            GetDataGridView();

        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：部署登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Client GenerateDataAtRegistration()
        {
            return new M_Client
            {
                ClID = int.Parse(txbClientID.Text.Trim()),
                SoID = cmbSalesOfficeID.SelectedIndex,
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
        //　8.1.1.1 妥当な部署データ取得
        //メソッド名：GetValidDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtRegistration()
        {

            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbClientID.Text.Trim()))
            {
                // 顧客IDの半角英数字チェック
                if (dataInputCheck.CheckHalfAlphabetNumeric(txbClientID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは全て半角英数字入力です");
                    txbClientID.Focus();
                    return false;
                }
                // 顧客IDの文字数チェック
                if (txbClientID.TextLength != 5)
                {
                    MessageBox.Show("顧客IDは5文字です");
                    txbClientID.Focus();
                    return false;
                }
                //// 顧客IDの重複チェック
                //if (divisionDataAccess.CheckDivisionCDExistence(textBoxDivisionCD.Text.Trim()))
                //{
                //    //MessageBox.Show("入力された顧客IDは既に存在します");
                //    messageDsp.DspMsg("M1003");
                //    txbClientID.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("顧客IDが入力されていません");
                txbClientID.Focus();
                return false;
            }

            // 顧客名の適否
            if (!String.IsNullOrEmpty(txbClientName.Text.Trim()))
            {
                // 顧客名の文字数チェック
                if (txbClientName.TextLength >= 50)
                {
                    MessageBox.Show("顧客名は50文字です");
                    txbClientName.Focus();
                    return false;
                }
                //// 顧客名の重複チェック
                //if (divisionDataAccess.CheckDivisionCDExistence(textBoxDivisionCD.Text.Trim()))
                //{
                //    //MessageBox.Show("入力された顧客名は既に存在します");
                //    messageDsp.DspMsg("M1003");
                //    txbClientName.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("顧客名が入力されていません");
                txbClientName.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbClientPhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbClientPhone.TextLength >= 13)
                {
                    MessageBox.Show("電話番号は13文字以内です");
                    txbClientPhone.Focus();
                    return false;
                }
                //// 電話番号の重複チェック
                //if (divisionDataAccess.CheckDivisionCDExistence(textBoxDivisionCD.Text.Trim()))
                //{
                //    //MessageBox.Show("入力された電話番号は既に存在します");
                //    messageDsp.DspMsg("M1003");
                //    txbClientPhone.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません");
                txbClientName.Focus();
                return false;
            }


            // 郵便番号の適否
            if (!String.IsNullOrEmpty(txbClientPostal.Text.Trim()))
            {
                // 郵便番号の文字数チェック
                if (txbClientPostal.TextLength >= 7)
                {
                    MessageBox.Show("郵便番号は7文字以内です");
                    txbClientPostal.Focus();
                    return false;
                }
                //// 郵便番号の重複チェック
                //if (divisionDataAccess.CheckDivisionCDExistence(textBoxDivisionCD.Text.Trim()))
                //{
                //    //MessageBox.Show("入力された郵便番号は既に存在します");
                //    messageDsp.DspMsg("M1003");
                //    txbClientPostal.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません");
                txbClientPostal.Focus();
                return false;
            }

            // 住所の適否
            if (!String.IsNullOrEmpty(txbClientAddress.Text.Trim()))
            {
                // 住所の文字数チェック
                if (txbClientAddress.TextLength >= 50)
                {
                    MessageBox.Show("住所は50文字以内です");
                    txbClientAddress.Focus();
                    return false;
                }
                //// 住所の重複チェック
                //if (divisionDataAccess.CheckDivisionCDExistence(textBoxDivisionCD.Text.Trim()))
                //{
                //    //MessageBox.Show("入力された住所は既に存在します");
                //    messageDsp.DspMsg("M1003");
                //    txbClientAddress.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("住所が入力されていません");
                txbClientAddress.Focus();
                return false;
            }

            // FAXの適否
            if (!String.IsNullOrEmpty(txbClientFAX.Text.Trim()))
            {
                // FAXの文字数チェック
                if (txbClientFAX.TextLength >= 13)
                {
                    MessageBox.Show("FAXは13文字以内です");
                    txbClientFAX.Focus();
                    return false;
                }
                //// FAXの重複チェック
                //if (divisionDataAccess.CheckDivisionCDExistence(textBoxDivisionCD.Text.Trim()))
                //{
                //    //MessageBox.Show("入力されたFAXは既に存在します");
                //    messageDsp.DspMsg("M1003");
                //    txbClientFAX.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("FAXが入力されていません");
                txbClientFAX.Focus();
                return false;
            }

            // 非表示理由の適否
            if (!String.IsNullOrEmpty(txbHidden.Text.Trim()))
            {
  
                
                //// 非表示理由の重複チェック
                //if (divisionDataAccess.CheckDivisionCDExistence(textBoxDivisionCD.Text.Trim()))
                //{
                //    //MessageBox.Show("入力された非表示理由は既に存在します");
                //    messageDsp.DspMsg("M1003");
                //    txbHidden.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("非表示理由が入力されていません");
                txbHidden.Focus();
                return false;
            }


            return true;
        }


        ///////////////////////////////
        //メソッド名：ClientDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void ClientDataUpdate()
        {

            // 8.1.2.2 部署情報作成
            var updDivision = GenerateDataAtUpdate();

            // 8.1.2.3 部署情報更新
            UpdateDivision(updDivision);
        }

        ///////////////////////////////
        //　8.1.2.2 部署情報作成
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：部署更新情報
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
                SoID = cmbSalesOfficeID.SelectedIndex,
                ClPostal = txbClientPostal.Text.Trim(),
                ClAddress = txbClientAddress.Text.Trim(),
                ClFAX = txbClientFAX.Text.Trim(),
                ClFlag = cmbHidden.SelectedIndex,
            };
        }

        ///////////////////////////////
        //　8.1.2.3 部署情報更新
        //メソッド名：UpdateDivision()
        //引　数   ：部署情報
        //戻り値   ：なし
        //機　能   ：部署情報の更新
        ///////////////////////////////
        private void UpdateDivision(M_Client updDivision)
        {
            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("更新しますか？","確認"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
                return;

            // 部署情報の更新
            bool flg = clientDataAccess.UpdateClientData(updDivision);
            if (flg == true)
                //MessageBox.Show("データを更新しました。");
                MessageBox.Show("更新しました。", "確認"
                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //MessageBox.Show("データの更新に失敗しました。");
                MessageBox.Show("更新に失敗しました。", "エラー"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);

           

            

            // データグリッドビューの表示
            GetDataGridView();


        }

        ///////////////////////////////
        //メソッド名：ClientDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void ClientDataSelect()
        {

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
            cmbSalesOfficeID.SelectedIndex = int.Parse(dgvClient[1, dgvClient.CurrentCellAddress.Y].Value.ToString()) - 1;
            txbClientName.Text = dgvClient[2, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientAddress.Text = dgvClient[3, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientPhone.Text = dgvClient[4, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientPostal.Text = dgvClient[5, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientFAX.Text = dgvClient[6, dgvClient.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = int.Parse(dgvClient[7, dgvClient.CurrentCellAddress.Y].Value.ToString());
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

            //データグリッドビューのデータ取得
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
            // 部署データの取得
            listClient = clientDataAccess.GetClientData();

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView()
        {
            dgvClient.DataSource = listClient.ToList();

            //各列幅の指定
            dgvClient.Columns[0].Width = 40;
            dgvClient.Columns[1].Width = 70;
            dgvClient.Columns[2].Width = 70;
            dgvClient.Columns[3].Width = 60;
            dgvClient.Columns[4].Width = 60;
            dgvClient.Columns[5].Width = 70;
            dgvClient.Columns[6].Width = 60;
            dgvClient.Columns[7].Width = 60;
            dgvClient.Columns[8].Width = 100;

            dgvClient.Refresh();
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
    }
}

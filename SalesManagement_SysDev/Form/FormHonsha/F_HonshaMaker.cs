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

    public partial class F_HonshaMaker : Form
    {
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の全メーカーデータ
        private static List<M_Maker> listAllMaker = new List<M_Maker>();
        //コンボボックス用のメーカーデータリスト
        private static List<M_Maker> listMaker = new List<M_Maker>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        public F_HonshaMaker()
        {
            InitializeComponent();
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
        private void F_HonshaMaker_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
        }
        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            MakerSearchButtonClick(true);
        }
        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            MakerSearchButtonClick(false);
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }
        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<M_Maker> viewMaker = SetListMaker();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewMaker.Count / (double)pageSize);

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
        private void dgvMaker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvMaker.SelectedCells.Count == 0)
            {
                return;
            }
            //選択された行に対してのコントロールの変更
            SelectRowControl();
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
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
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
        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                MakerDataRegister();
            }
            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                MakerDataUpdate();
            }
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                MakerDataSelect();
            }
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
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

            if (rdbUpdate.Checked)
            {

            }
            else
            {

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
            dgvMaker.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvMaker.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvMaker.AllowUserToResizeColumns = false;
            dgvMaker.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvMaker.MultiSelect = false;
            //セルの編集ができないように
            dgvMaker.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvMaker.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvMaker.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvMaker.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvMaker.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMaker.Columns.Add("MaID", "メーカーID");
            dgvMaker.Columns.Add("MaName", "メーカー名");
            dgvMaker.Columns.Add("MaAddress", "住所");
            dgvMaker.Columns.Add("MaPhone", "電話番号");
            dgvMaker.Columns.Add("MaPostal", "郵便番号");
            dgvMaker.Columns.Add("MaFAX", "FAX");
            dgvMaker.Columns.Add("MaFlag", "メーカー管理フラグ");
            dgvMaker.Columns.Add("MaHidden", "非表示理由");

            dgvMaker.Columns["MaID"].Width = 241;
            dgvMaker.Columns["MaName"].Width = 237;
            dgvMaker.Columns["MaAddress"].Width = 237;
            dgvMaker.Columns["MaPhone"].Width = 237;
            dgvMaker.Columns["MaPostal"].Width = 237;
            dgvMaker.Columns["MaFAX"].Width = 237;
            dgvMaker.Columns["MaFlag"].Width = 237;
            dgvMaker.Columns["MaHidden"].Width = 237;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvMaker.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            txbMakerID.Text = string.Empty;
            txbMakerPhone.Text = string.Empty;
            txbMakerPostal.Text = string.Empty;
            txbMakerAddress.Text = string.Empty;
            txbHidden.Text = string.Empty;
            txbMakerName.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
            txbMakerFAX.Text = string.Empty;
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
            List<M_Maker> listViewMaker = SetListMaker();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewMaker);
        }
        ///////////////////////////////
        //メソッド名：SetListMaker()
        //引　数   ：なし
        //戻り値   ：表示用メーカーデータ
        //機　能   ：表示用メーカーデータの準備
        ///////////////////////////////
        private List<M_Maker> SetListMaker()
        {
            //顧客のデータを全取得
            listAllMaker = makerDataAccess.GetMakerData();

            //表示用の顧客リスト作成
            List<M_Maker> listViewMaker = new List<M_Maker>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewMaker = listMaker;
            }
            else
            {
                //全データをとってくる
                listViewMaker = listAllMaker;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewMaker = makerDataAccess.GetMakerDspData(listViewMaker);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewMaker = makerDataAccess.GetMakerNotDspData(listViewMaker);
            }

            return listViewMaker;
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_Maker> viewMaker)
        {
            //中身を消去
            dgvMaker.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewMaker.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewMaker.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvMakerに挿入
            foreach (var item in depData)
            {
                dgvMaker.Rows.Add(item.MaID, item.MaName, item.MaAddress, item.MaPhone, item.MaPostal, item.MaFAX, dictionaryHidden[item.MaFlag], item.MaHidden);
            }

            //dgvMakerをリフレッシュ
            dgvMaker.Refresh();

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
        //メソッド名：MakerDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：メーカー情報登録の実行
        ///////////////////////////////
        private void MakerDataRegister()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtRegistration())
            {
                return;
            }

            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
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
            var regMaker = GenerateDataAtRegistration();

            // 顧客情報登録
            RegistrationMaker(regMaker);
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
            // メーカー名の適否
            if (!String.IsNullOrEmpty(txbMakerName.Text.Trim()))
            {
                // メーカー名の文字数チェック
                if (txbMakerName.TextLength > 50)
                {
                    MessageBox.Show("メーカー名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerName.Focus();
                    return false;
                }
                //メーカー名の重複チェック
                if (makerDataAccess.CheckMakerNameExistence(string.Format(txbMakerName.Text.Trim())))
                {
                    MessageBox.Show("メーカー名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("メーカー名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerName.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbMakerPhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbMakerPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerPhone.Focus();
                return false;
            }


            // 郵便番号の適否
            if (!String.IsNullOrEmpty(txbMakerPostal.Text.Trim()))
            {
                // 郵便番号の数字チェック
                if (!dataInputCheck.CheckNumeric(txbMakerPostal.Text.Trim()))
                {
                    MessageBox.Show("郵便番号は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerPostal.Focus();
                    return false;
                }
                // 郵便番号の文字数チェック
                if (txbMakerPostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerPostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerPostal.Focus();
                return false;
            }

            // 住所の適否
            if (!String.IsNullOrEmpty(txbMakerAddress.Text.Trim()))
            {
                // 住所の文字数チェック
                if (txbMakerAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerAddress.Focus();
                return false;
            }

            // FAXの適否
            if (!String.IsNullOrEmpty(txbMakerFAX.Text.Trim()))
            {
                // FAXの文字数チェック
                if (txbMakerFAX.TextLength > 13)
                {
                    MessageBox.Show("FAXは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerFAX.Focus();
                return false;
            }

            //表示非表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示非表示が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
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
                FormName = "メーカー管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbMakerID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：メーカー登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Maker GenerateDataAtRegistration()
        {
            return new M_Maker
            {
                MaName = string.Format(txbMakerName.Text.Trim()),
                MaAddress = txbMakerAddress.Text.Trim(),
                MaPhone = txbMakerPhone.Text.Trim(),
                MaPostal = txbMakerPostal.Text.Trim(),
                MaFAX = txbMakerFAX.Text.Trim(),
                MaFlag = cmbHidden.SelectedIndex,
                MaHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：RegistrationMaker()
        //引　数   ：メーカー情報
        //戻り値   ：なし
        //機　能   ：メーカーデータの登録
        ///////////////////////////////
        private void RegistrationMaker(M_Maker regMaker)
        {
            // 営業所情報の登録
            bool flg = makerDataAccess.AddMakerData(regMaker);

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
        //メソッド名：MakerDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：メーカー情報更新の実行
        ///////////////////////////////
        private void MakerDataUpdate()
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

            // 顧客情報作成
            var updMaker = GenerateDataAtUpdate();

            // 顧客情報更新
            UpdateMaker(updMaker);
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
            // メーカーIDの適否
            if (!String.IsNullOrEmpty(txbMakerID.Text.Trim()))
            {
                // メーカーIDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbMakerID.Text.Trim()))
                {
                    MessageBox.Show("メーカーIDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
                //メーカーIDの存在チェック
                if (!makerDataAccess.CheckMakerIDExistence(int.Parse(txbMakerID.Text.Trim())))
                {
                    MessageBox.Show("メーカーIDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("メーカーIDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerID.Focus();
                return false;
            }

            // メーカー名の適否
            if (!String.IsNullOrEmpty(txbMakerName.Text.Trim()))
            {
                // メーカー名の文字数チェック
                if (txbMakerName.TextLength > 50)
                {
                    MessageBox.Show("メーカー名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerName.Focus();
                    return false;
                }
                //メーカー名存在チェック
                if (!makerDataAccess.CheckMakerNameExistence(txbMakerName.Text.Trim()))
                {
                    MessageBox.Show("メーカー名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("メーカー名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerName.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbMakerPhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbMakerPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerPhone.Focus();
                return false;
            }


            // 郵便番号の適否
            if (!String.IsNullOrEmpty(txbMakerPostal.Text.Trim()))
            {
                // 郵便番号の数字チェック
                if (!dataInputCheck.CheckNumeric(txbMakerPostal.Text.Trim()))
                {
                    MessageBox.Show("郵便番号は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerPostal.Focus();
                    return false;
                }
                // 郵便番号の文字数チェック
                if (txbMakerPostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerPostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerPostal.Focus();
                return false;
            }

            // 住所の適否
            if (!String.IsNullOrEmpty(txbMakerAddress.Text.Trim()))
            {
                // 住所の文字数チェック
                if (txbMakerAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerAddress.Focus();
                return false;
            }

            // FAXの適否
            if (!String.IsNullOrEmpty(txbMakerFAX.Text.Trim()))
            {
                // FAXの文字数チェック
                if (txbMakerFAX.TextLength > 13)
                {
                    MessageBox.Show("FAXは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerFAX.Focus();
                return false;
            }

            //表示非表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示非表示が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
                return false;
            }

            return true;
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：メーカー更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_Maker GenerateDataAtUpdate()
        {
            return new M_Maker
            {
                MaID = int.Parse(txbMakerID.Text.Trim()),
                MaName = string.Format(txbMakerName.Text.Trim()),
                MaAddress = txbMakerAddress.Text.Trim(),
                MaPhone = txbMakerPhone.Text.Trim(),
                MaPostal = txbMakerPostal.Text.Trim(),
                MaFAX = txbMakerFAX.Text.Trim(),
                MaFlag = cmbHidden.SelectedIndex,
                MaHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：UpdateMaker()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客情報の更新
        ///////////////////////////////
        private void UpdateMaker(M_Maker updMaker)
        {
            // 顧客情報の更新
            bool flg = makerDataAccess.UpdateMakerData(updMaker);
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
        //メソッド名：MakerDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：メーカー情報検索の実行
        ///////////////////////////////
        private void MakerDataSelect()
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
            if (String.IsNullOrEmpty(txbMakerID.Text.Trim()) && String.IsNullOrEmpty(txbMakerName.Text.Trim()) && String.IsNullOrEmpty(txbMakerPhone.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerID.Focus();
                return false;
            }

            // メーカーIDの適否
            if (!String.IsNullOrEmpty(txbMakerID.Text.Trim()))
            {
                // メーカーIDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbMakerID.Text.Trim()))
                {
                    MessageBox.Show("メーカーIDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
                //メーカーIDの重複チェック
                if (!makerDataAccess.CheckMakerIDExistence(int.Parse(txbMakerID.Text.Trim())))
                {
                    MessageBox.Show("メーカーIDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
            }

            return true;
        }
        ///////////////////////////////
        //メソッド名：MakerSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：メーカー情報検索の実行
        ///////////////////////////////
        private void MakerSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listMaker.Count;

            txbNumPage.Text = "1";

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：メーカー情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strMakerID = txbMakerID.Text.Trim();
            int intMakerID = 0;

            if (!String.IsNullOrEmpty(strMakerID))
            {
                intMakerID = int.Parse(strMakerID);
            }

            // 検索条件のセット
            M_Maker selectCondition = new M_Maker()
            {
                MaID = intMakerID,
                //SoName = txbSalesOfficeName.Text.Trim()
                MaPhone = txbMakerPhone.Text.Trim(),
                //SoPostal= txbSalesOfficePostal.Text.Trim(),
                //SoAddress= txbSalesOfficeAddress.Text.Trim(),
                //SoFAX=txbSalesOfficeFax.Text.Trim(),
                //SoHidden=txbHidden.Text.Trim()
            };

            if (searchFlg)
            {
                // 顧客データのAnd抽出
                listMaker = makerDataAccess.GetAndMakerData(selectCondition);
            }
            else
            {
                // 顧客データのOr抽出
                listMaker = makerDataAccess.GetOrMakerData(selectCondition);
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
            txbMakerID.Text = dgvMaker[0, dgvMaker.CurrentCellAddress.Y].Value.ToString();
            txbMakerName.Text = dgvMaker[1, dgvMaker.CurrentCellAddress.Y].Value.ToString();
            txbMakerAddress.Text = dgvMaker[2, dgvMaker.CurrentCellAddress.Y].Value.ToString();
            txbMakerPhone.Text = dgvMaker[3, dgvMaker.CurrentCellAddress.Y].Value.ToString();
            txbMakerPostal.Text = dgvMaker[4, dgvMaker.CurrentCellAddress.Y].Value.ToString();
            txbMakerFAX.Text = dgvMaker[5, dgvMaker.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvMaker[6, dgvMaker.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvMaker[7, dgvMaker.CurrentCellAddress.Y]?.Value?.ToString();
        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            GetDataGridView();
        }
    }
}

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
        MakerDataAccess MakerDataAccess = new MakerDataAccess();
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

            dgvMaker.Columns["SoID"].Width = 241;
            dgvMaker.Columns["SoName"].Width = 237;
            dgvMaker.Columns["SoAddress"].Width = 237;
            dgvMaker.Columns["SoPhone"].Width = 237;
            dgvMaker.Columns["SoPostal"].Width = 237;
            dgvMaker.Columns["SoFAX"].Width = 237;
            dgvMaker.Columns["SoFlag"].Width = 237;
            dgvMaker.Columns["SoHidden"].Width = 237;

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
        //戻り値   ：表示用営業所データ
        //機　能   ：表示用営業所データの準備
        ///////////////////////////////
        private List<M_Maker> SetListMaker()
        {
            //顧客のデータを全取得
            listAllMaker = MakerDataAccess.GetMakerData();

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
                listViewMaker = MakerDataAccess.GetMakerDspData(listViewMaker);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewMaker = MakerDataAccess.GetMakerNotDspData(listViewMaker);
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
            // 営業所IDの適否
            if (!String.IsNullOrEmpty(txbMakerID.Text.Trim()))
            {
                // 営業所IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbMakerID.Text.Trim()))
                {
                    MessageBox.Show("営業所IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
                //営業所IDの重複チェック
                if (MakerDataAccess.CheckClientIDExistence(int.Parse(txbMakerID.Text.Trim())))
                {
                    MessageBox.Show("営業所IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("営業所IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerID.Focus();
                return false;
            }

            // 営業所名の適否
            if (!String.IsNullOrEmpty(txbMakerName.Text.Trim()))
            {
                // 営業所名の文字数チェック
                if (txbMakerName.TextLength > 50)
                {
                    MessageBox.Show("営業所名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerName.Focus();
                    return false;
                }
                //営業所名の重複チェック
                if (MakerDataAccess.CheckClientNameExistence(string.Format(txbMakerName.Text.Trim())))
                {
                    MessageBox.Show("営業所名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("営業所名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("表示家選択が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //メソッド名：RegistrationSalesOffice()
        //引　数   ：メーカー情報
        //戻り値   ：なし
        //機　能   ：メーカーデータの登録
        ///////////////////////////////
        private void RegistrationMaker(M_Maker regMaker)
        {
            // 営業所情報の登録
            bool flg = MakerDataAccess.AddMakerData(regMaker);

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
            // 営業所IDの適否
            if (!String.IsNullOrEmpty(txbMakerID.Text.Trim()))
            {
                // 営業所IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbMakerID.Text.Trim()))
                {
                    MessageBox.Show("営業所IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
                //営業所IDの重複チェック
                if (MakerDataAccess.CheckClientIDExistence(int.Parse(txbMakerID.Text.Trim())))
                {
                    MessageBox.Show("営業所IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("営業所IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerID.Focus();
                return false;
            }

            // 営業所名の適否
            if (!String.IsNullOrEmpty(txbMakerName.Text.Trim()))
            {
                // 営業所名の文字数チェック
                if (txbMakerName.TextLength > 50)
                {
                    MessageBox.Show("営業所名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerName.Focus();
                    return false;
                }
                //営業所名の重複チェック
                if (MakerDataAccess.CheckClientNameExistence(string.Format(txbMakerName.Text.Trim())))
                {
                    MessageBox.Show("営業所名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("営業所名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("表示家選択が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //メソッド名：UpdateSalesOffice()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客情報の更新
        ///////////////////////////////
        private void UpdateMaker(M_Maker updMaker)
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
            bool flg = MakerDataAccess.UpdateMakerData(updMaker);
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

            // 営業所IDの適否
            if (!String.IsNullOrEmpty(txbMakerID.Text.Trim()))
            {
                // 営業所IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbMakerID.Text.Trim()))
                {
                    MessageBox.Show("営業所IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
                //営業所IDの重複チェック
                if (!MakerDataAccess.CheckClientIDExistence(int.Parse(txbMakerID.Text.Trim())))
                {
                    MessageBox.Show("営業所IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerID.Focus();
                    return false;
                }
            }

            return true;
        }
        ///////////////////////////////
        //メソッド名：ClientSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void MakerSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listMaker.Count;

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：営業所情報の取得
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
                listMaker = MakerDataAccess.GetAndMakerData(selectCondition);
            }
            else
            {
                // 顧客データのOr抽出
                listMaker = MakerDataAccess.GetOrMakerData(selectCondition);
            }
        }
    }
}

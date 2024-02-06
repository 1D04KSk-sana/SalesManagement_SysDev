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
    public partial class F_HonshaClassification : Form
    {
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        MajorDataAccess majorDataAccess = new MajorDataAccess();
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        SmallDataAccess smallDataAccess = new SmallDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の全大分類データ
        private static List<M_MajorClassification> listAllMajor = new List<M_MajorClassification>();
        //コンボボックス用の大分類データリスト
        private static List<M_MajorClassification> listMajor = new List<M_MajorClassification>();
        //データグリッドビュー用の全小分類データ
        private static List<M_SmallClassification> listAllSmall = new List<M_SmallClassification>();
        //コンボボックス用の小分類データリスト
        private static List<M_SmallClassification> listSmall = new List<M_SmallClassification>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        public F_HonshaClassification()
        {
            InitializeComponent();
        }
        private void dgvMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvMajor.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            M_SelectRowControl();

            dgvSmall.Rows.Clear();

            listSmall = smallDataAccess.GetMajorIDData(int.Parse(dgvMajor[0, dgvMajor.CurrentCellAddress.Y].Value.ToString()));

            //1行ずつdgvSmallに挿入
            foreach (var item in listSmall)
            {
                dgvSmall.Rows.Add(item.ScID, item.ScName, dictionaryHidden[item.ScFlag], item.ScHidden);
            }

            //dgvSmallをリフレッシュ
            dgvSmall.Refresh();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();


            rdbRegister.Checked = true;

            GetDataGridView();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cmbClassfication.SelectedIndex == 0)
            {
                //大分類登録ラヂオボタンがチェックされているとき
                if (rdbRegister.Checked)
                {
                    MajorDataRegister();
                }
                //大分類更新ラヂオボタンがチェックされているとき
                if (rdbUpdate.Checked)
                {
                    MajorDataUpdate();
                }
                //大分類検索ラヂオボタンがチェックされているとき
                if (rdbSearch.Checked)
                {
                    MajorDataSelect();
                }
            }
            if (cmbClassfication.SelectedIndex == 1)
            {
                //小分類登録ラヂオボタンがチェックされているとき
                if (rdbRegister.Checked)
                {
                    SmallDataRegister();
                }
                //小分類更新ラヂオボタンがチェックされているとき
                if (rdbUpdate.Checked)
                {
                    SmallDataUpdate();
                }
                //小分類検索ラヂオボタンがチェックされているとき
                if (rdbSearch.Checked)
                {
                    SmallDataSelect();
                }
            }            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvSmall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvSmall.SelectedCells.Count == 0)
            {
                return;
            }
            //選択された行に対してのコントロールの変更
            S_SelectRowControl();
        }
        private void F_HonshaClassification_Load(object sender, EventArgs e)
        {
            rdbRegister.Checked = true;
            
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
            //cmbClassficationViewを非表示に
            cmbClassfication.SelectedIndex = 0;
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
            List<M_MajorClassification> viewMajor = SetListMajor();
            List<M_SmallClassification> viewSmall = SetListSmall();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int MlastPage = (int)Math.Ceiling(viewMajor.Count / (double)pageSize);
            int SlastPage = (int)Math.Ceiling(viewSmall.Count / (double)pageSize);

            txbNumPage.Text = MlastPage.ToString();
            txbNumPage.Text = SlastPage.ToString();

            GetDataGridView();
        }
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
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
        private void M_SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            MajorSearchButtonClick(true);
        }
        private void M_SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            MajorSearchButtonClick(false);
        }
        private void S_ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }
        private void S_SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            SmallSearchButtonClick(true);
        }
        private void S_SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            SmallSearchButtonClick(false);
        }
        private void M_ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }
        ///////////////////////////////
        //メソッド名：MajorDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：大分類情報登録の実行
        ///////////////////////////////
        private void MajorDataRegister()
        {
            //テキストボックス等の入力チェック
            if (!GetValidMDataAtRegistration())
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
            var regOperationLog = GenerateMLogAtRegistration(rdbRegister.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 顧客情報作成
            var regMaker = GenerateMDataAtRegistration();

            // 顧客情報登録
            RegistrationMajor(regMaker);
        }
        ///////////////////////////////
        //メソッド名：SmallDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：小分類情報登録の実行
        ///////////////////////////////
        private void SmallDataRegister()
        {
            //テキストボックス等の入力チェック
            if (!GetValidSDataAtRegistration())
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
            var regOperationLog = GenerateSLogAtRegistration(rdbRegister.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 顧客情報作成
            var regSmall = GenerateSDataAtRegistration();

            // 顧客情報登録
            RegistrationSmall(regSmall);
        }
        ///////////////////////////////
        //メソッド名：RegistrationMajor()
        //引　数   ：メーカー情報
        //戻り値   ：なし
        //機　能   ：大分類データの登録
        ///////////////////////////////
        private void RegistrationMajor(M_MajorClassification regMajor)
        {
            // 営業所情報の登録
            bool flg = majorDataAccess.AddMajorData(regMajor);

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
        //メソッド名：RegistrationSmall()
        //引　数   ：メーカー情報
        //戻り値   ：なし
        //機　能   ：小分類データの登録
        ///////////////////////////////
        private void RegistrationSmall(M_SmallClassification regSmall)
        {
            // 営業所情報の登録
            bool flg = smallDataAccess.AddSmallData(regSmall);

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
        //戻り値   ：大分類登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_MajorClassification GenerateMDataAtRegistration()
        {
            return new M_MajorClassification
            {
                McName = txbMajorName.Text.Trim(),
                McFlag = cmbHidden.SelectedIndex,
                McHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：GenerateSDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：小分類登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_SmallClassification GenerateSDataAtRegistration()
        {
            List<M_SmallClassification> listSmallClassfication = smallDataAccess.GetMajorIDData(int.Parse(txbMajorID.Text.Trim()));

            int intSmallIDCount = listSmallClassfication.Count();

            return new M_SmallClassification
            {
                ScID = intSmallIDCount + 1,
                McID = int.Parse(txbMajorID.Text.Trim()),
                ScName = txbSmallName.Text.Trim(),
                ScFlag = cmbHidden.SelectedIndex,
                ScHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：GetValidMDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：登録入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidMDataAtRegistration()
        {
            // 大分類名の適否
            if (!String.IsNullOrEmpty(txbMajorName.Text.Trim()))
            {
                // 大分類名の文字数チェック
                if (txbMajorName.TextLength > 50)
                {
                    MessageBox.Show("大分類名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorName.Focus();
                    return false;
                }
                //大分類名の重複チェック
                if (majorDataAccess.CheckMajorNameExistence(string.Format(txbMajorName.Text.Trim())))
                {
                    MessageBox.Show("大分類名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("大分類名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMajorName.Focus();
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
        //メソッド名：GetValidSDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：登録入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidSDataAtRegistration()
        {
            // 小分類名の適否
            if (!String.IsNullOrEmpty(txbSmallName.Text.Trim()))
            {
                // 小分類名の文字数チェック
                if (txbSmallName.TextLength > 50)
                {
                    MessageBox.Show("小分類名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallName.Focus();
                    return false;
                }
                //小分類名の重複チェック
                if (smallDataAccess.CheckSmallNameExistence(string.Format(txbSmallName.Text.Trim())))
                {
                    MessageBox.Show("小分類名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("小分類名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSmallName.Focus();
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
        //メソッド名：GenerateMLogAtRegistration()
        //引　数   ：操作名
        //戻り値   ：操作ログ大分類登録情報
        //機　能   ：操作ログ大分類情報登録データのセット
        ///////////////////////////////
        private T_OperationLog GenerateMLogAtRegistration(string OperationDone)
        {
            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "分類管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbMajorID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }
        ///////////////////////////////
        //メソッド名：GenerateLogAtRegistration()
        //引　数   ：操作名
        //戻り値   ：操作ログ小分類登録情報
        //機　能   ：操作ログ小分類情報登録データのセット
        ///////////////////////////////
        private T_OperationLog GenerateSLogAtRegistration(string OperationDone)
        {
            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "分類管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbMajorID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }
        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbMajorID.Text = string.Empty;
            txbSmallID.Text = string.Empty;
            txbMajorName.Text = string.Empty;
            txbSmallName.Text = string.Empty;
            txbHidden.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
        }
        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の大分類リスト作成
            List<M_MajorClassification> listViewMajor = SetListMajor();

            List<M_SmallClassification> listViewSmall = SetListSmall();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewMajor, listViewSmall);
        }
        ///////////////////////////////
        //メソッド名：SetListMajor()
        //引　数   ：なし
        //戻り値   ：表示用大分類データ
        //機　能   ：表示用大分類データの準備
        ///////////////////////////////
        private List<M_MajorClassification> SetListMajor()
        {
            //大分類のデータを全取得
            listAllMajor = majorDataAccess.GetMajorData();

            //表示用の大分類リスト作成
            List<M_MajorClassification> listViewMajor = new List<M_MajorClassification>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewMajor = listMajor;
            }
            else
            {
                //全データをとってくる
                listViewMajor = listAllMajor;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の大分類データの取得
                listViewMajor = majorDataAccess.GetMajorDspData(listViewMajor);
            }
            else
            {
                // 管理Flgが非表示の大分類データの取得
                listViewMajor = majorDataAccess.GetMajorNotDspData(listViewMajor);
            }

            return listViewMajor;
        }
        ///////////////////////////////
        //メソッド名：SetListSmall()
        //引　数   ：なし
        //戻り値   ：表示用小分類データ
        //機　能   ：表示用小分類データの準備
        ///////////////////////////////
        private List<M_SmallClassification> SetListSmall()
        {
            //小分類のデータを全取得
            listAllSmall = smallDataAccess.GetSmallData();

            //表示用の小分類リスト作成
            List<M_SmallClassification> listViewSmall = new List<M_SmallClassification>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewSmall = listSmall;
            }
            else
            {
                //全データをとってくる
                listViewSmall = listAllSmall;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の小分類データの取得
                listViewSmall = smallDataAccess.GetSmallDspData(listViewSmall);
            }
            else
            {
                // 管理Flgが非表示の小分類データの取得
                listViewSmall = smallDataAccess.GetSmallNotDspData(listViewSmall);
            }

            return listViewSmall;
        }
        ///////////////////////////////
        //メソッド名：MajorDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：大分類情報更新の実行
        ///////////////////////////////
        private void MajorDataUpdate()
        {
            //テキストボックス等の入力チェック
            if (!GetValidMDataAtUpdate())
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
            var regOperationLog = GenerateSLogAtRegistration(rdbUpdate.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 大分類情報作成
            var updMajor = GenerateMDataAtUpdate();

            // 大分類情報更新
            UpdateMajor(updMajor);
        }
        ///////////////////////////////
        //メソッド名：SmallDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：小分類情報更新の実行
        ///////////////////////////////
        private void SmallDataUpdate()
        {
            //テキストボックス等の入力チェック
            if (!GetValidSDataAtUpdate())
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
            var regOperationLog = GenerateSLogAtRegistration(rdbUpdate.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 小分類情報作成
            var updSmall = GenerateSDataAtUpdate();

            // 小分類情報更新
            UpdateSmall(updSmall);
        }
        ///////////////////////////////
        //メソッド名：GetValidMDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：更新入力データの形式チェック
        //         ：エラーがない場合True
        //         ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidMDataAtUpdate()
        {
            // 大分類IDの適否
            if (!String.IsNullOrEmpty(txbMajorID.Text.Trim()))
            {
                // 大分類IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbMajorID.Text.Trim()))
                {
                    MessageBox.Show("大分類IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorID.Focus();
                    return false;
                }
                //大分類IDの存在チェック
                if (!majorDataAccess.CheckMajorIDExistence(int.Parse(txbMajorID.Text.Trim())))
                {
                    MessageBox.Show("大分類IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("大分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMajorID.Focus();
                return false;
            }

            // 大分類名の適否
            if (!String.IsNullOrEmpty(txbMajorName.Text.Trim()))
            {
                // 大分類名の文字数チェック
                if (txbMajorName.TextLength > 50)
                {
                    MessageBox.Show("大分類名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorName.Focus();
                    return false;
                }

                M_MajorClassification Major = majorDataAccess.GetMajorIDData(int.Parse(txbMajorID.Text.Trim()));

                //大分類名がDBとは異なる場合
                if (Major.McName != txbMajorName.Text.Trim())
                {
                    if (majorDataAccess.CheckMajorNameExistence(txbMajorName.Text.Trim()))
                    {
                        MessageBox.Show("大分類名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbMajorID.Focus();
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("大分類名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMajorName.Focus();
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
        //メソッド名：GetValidSDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：更新入力データの形式チェック
        //         ：エラーがない場合True
        //         ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidSDataAtUpdate()
        {
            // 小分類IDの適否
            if (!String.IsNullOrEmpty(txbSmallID.Text.Trim()))
            {
                // 小分類IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSmallID.Text.Trim()))
                {
                    MessageBox.Show("小分類IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallID.Focus();
                    return false;
                }
                //小分類IDの存在チェック
                if (!smallDataAccess.CheckSmallIDExistence(int.Parse(txbSmallID.Text.Trim())))
                {
                    MessageBox.Show("小分類IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("小分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSmallID.Focus();
                return false;
            }

            // 小分類名の適否
            if (!String.IsNullOrEmpty(txbSmallName.Text.Trim()))
            {
                // 小分類名の文字数チェック
                if (txbSmallName.TextLength > 50)
                {
                    MessageBox.Show("小分類名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallName.Focus();
                    return false;
                }

                M_SmallClassification Small = smallDataAccess.GetSmallIDData(int.Parse(txbSmallID.Text.Trim()));

                //小分類名がDBとは異なる場合
                if (Small.ScName != txbSmallName.Text.Trim())
                {
                    if (smallDataAccess.CheckSmallNameExistence(txbSmallName.Text.Trim()))
                    {
                        MessageBox.Show("小分類名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbSmallName.Focus();
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("小分類名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSmallName.Focus();
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
        //メソッド名：GenerateMDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：大分類更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_MajorClassification GenerateMDataAtUpdate()
        {
            return new M_MajorClassification
            {
                McID = int.Parse(txbMajorID.Text.Trim()),
                McName = txbMajorName.Text.Trim(),
                McFlag = cmbHidden.SelectedIndex,
                McHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：GeneratSDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：小分類更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_SmallClassification GenerateSDataAtUpdate()
        {
            return new M_SmallClassification
            {
                ScID = int.Parse(txbSmallID.Text.Trim()),
                ScName = string.Format(txbSmallName.Text.Trim()),
                ScFlag = cmbHidden.SelectedIndex,
                ScHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：UpdateSmall()
        //引　数   ：小分類情報
        //戻り値   ：なし
        //機　能   ：小分類情報の更新
        ///////////////////////////////
        private void UpdateSmall(M_SmallClassification updSmall)
        {
            // 顧客情報の更新
            bool flg = smallDataAccess.UpdateSmallData(updSmall);
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
        //メソッド名：UpdateMajor()
        //引　数   ：大分類情報
        //戻り値   ：なし
        //機　能   ：大分類情報の更新
        ///////////////////////////////
        private void UpdateMajor(M_MajorClassification updMajor)
        {
            // 大分類情報の更新
            bool flg = majorDataAccess.UpdateMajorData(updMajor);

            List<bool> listflg = new List<bool>();

            if (updMajor.McFlag == 1)
            {
                List<M_SmallClassification> listSmall = smallDataAccess.GetMajorIDData(updMajor.McID);

                foreach (var item in  listSmall)
                {
                    listflg.Add(smallDataAccess.UpdateHiddenMakerData(item.ScID));
                }

                foreach (var item in listflg)
                {
                    if (!item)
                    {
                        flg = false;
                    }
                }
            }

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
        //メソッド名：MajorDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：大分類情報検索の実行
        ///////////////////////////////
        private void MajorDataSelect()
        {
            //テキストボックス等の入力チェック
            if (!GetValidMDataAtSearch())
            {
                return;
            }

            //検索ダイアログのフォームを作成
            f_SearchDialog = new F_SearchDialog();
            //検索ダイアログのフォームのオーナー設定
            f_SearchDialog.Owner = this;

            //検索ダイアログのフォームのボタンクリックイベントにハンドラを追加
            f_SearchDialog.btnAndSearchClick += M_SearchDialog_btnAndSearchClick;
            f_SearchDialog.btnOrSearchClick += M_SearchDialog_btnOrSearchClick;

            //検索ダイアログのフォームが閉じたときのイベントを設定
            f_SearchDialog.FormClosed += M_ChildForm_FormClosed;
            //検索ダイアログのフォームの表示
            f_SearchDialog.Show();

            //顧客登録フォームの透明化
            this.Opacity = 0;
        }
        ///////////////////////////////
        //メソッド名：SmallDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：小分類情報検索の実行
        ///////////////////////////////
        private void SmallDataSelect()
        {
            //テキストボックス等の入力チェック
            if (!GetValidSDataAtSearch())
            {
                return;
            }

            //検索ダイアログのフォームを作成
            f_SearchDialog = new F_SearchDialog();
            //検索ダイアログのフォームのオーナー設定
            f_SearchDialog.Owner = this;

            //検索ダイアログのフォームのボタンクリックイベントにハンドラを追加
            f_SearchDialog.btnAndSearchClick += S_SearchDialog_btnAndSearchClick;
            f_SearchDialog.btnOrSearchClick += S_SearchDialog_btnOrSearchClick;

            //検索ダイアログのフォームが閉じたときのイベントを設定
            f_SearchDialog.FormClosed += S_ChildForm_FormClosed;
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
        private bool GetValidMDataAtSearch()
        {
            //検索条件の存在確認
            if (String.IsNullOrEmpty(txbMajorID.Text.Trim()) && String.IsNullOrEmpty(txbMajorName.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMajorID.Focus();
                return false;
            }

            // 大分類IDの適否
            if (!String.IsNullOrEmpty(txbMajorID.Text.Trim()))
            {
                // 大分類IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbMajorID.Text.Trim()))
                {
                    MessageBox.Show("大分類IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorID.Focus();
                    return false;
                }
                //大分類IDの重複チェック
                if (!majorDataAccess.CheckMajorIDExistence(int.Parse(txbMajorID.Text.Trim())))
                {
                    MessageBox.Show("大分類IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorID.Focus();
                    return false;
                }
            }

            return true;
        }
        ///////////////////////////////
        //メソッド名：GetValidSDataAtSearch()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：検索入力データの形式チェック
        //         ：エラーがない場合True
        //         ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidSDataAtSearch()
        {
            //検索条件の存在確認
            if (String.IsNullOrEmpty(txbSmallID.Text.Trim()) && String.IsNullOrEmpty(txbSmallName.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSmallID.Focus();
                return false;
            }

            // 小分類IDの適否
            if (!String.IsNullOrEmpty(txbSmallID.Text.Trim()))
            {
                // 小分類IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSmallID.Text.Trim()))
                {
                    MessageBox.Show("小分類IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallID.Focus();
                    return false;
                }
                //小分類IDの重複チェック
                if (!smallDataAccess.CheckSmallIDExistence(int.Parse(txbSmallID.Text.Trim())))
                {
                    MessageBox.Show("小分類IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallID.Focus();
                    return false;
                }
            }

            return true;
        }
        ///////////////////////////////
        //メソッド名：MajorSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：大分類情報検索の実行
        ///////////////////////////////
        private void MajorSearchButtonClick(bool searchFlg)
        {
            // 大分類情報抽出
            GenerateMDataAtSelect(searchFlg);

            int intSearchCount = listMajor.Count;

            txbNumPage.Text = "1";

            // 大分類抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ///////////////////////////////
        //メソッド名：SmallSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：小分類情報検索の実行
        ///////////////////////////////
        private void SmallSearchButtonClick(bool searchFlg)
        {
            // 小分類情報抽出
            GenerateSDataAtSelect(searchFlg);

            int intSearchCount = listSmall.Count;

            txbNumPage.Text = "1";

            // 小分類抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ///////////////////////////////
        //メソッド名：GenerateMDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：大分類情報の取得
        ///////////////////////////////
        private void GenerateMDataAtSelect(bool searchFlg)
        {
            string strMajorID = txbMajorID.Text.Trim();
            int intMajorID = 0;

            if (!String.IsNullOrEmpty(strMajorID))
            {
                intMajorID = int.Parse(strMajorID);
            }

            // 検索条件のセット
            M_MajorClassification selectCondition = new M_MajorClassification()
            {
                McID = intMajorID,
                McName = txbMajorName.Text.Trim()
            };

            if (searchFlg)
            {
                // 大分類データのAnd抽出
                listMajor = majorDataAccess.GetAndMajorData(selectCondition);
            }
            else
            {
                // 大分類データのOr抽出
                listMajor = majorDataAccess.GetOrMajorData(selectCondition);
            }
        }
        ///////////////////////////////
        //メソッド名：GenerateSDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：小分類情報の取得
        ///////////////////////////////
        private void GenerateSDataAtSelect(bool searchFlg)
        {
            string strSmallID = txbSmallID.Text.Trim();
            int intSmallID = 0;

            if (!String.IsNullOrEmpty(strSmallID))
            {
                intSmallID = int.Parse(strSmallID);
            }

            // 検索条件のセット
            M_SmallClassification selectCondition = new M_SmallClassification()
            {
                ScID = intSmallID,
                ScName = txbSmallName.Text.Trim()
            };

            if (searchFlg)
            {
                // 小分類データのAnd抽出
                listSmall = smallDataAccess.GetAndSmallData(selectCondition);
            }
            else
            {
                // 小分類データのOr抽出
                listSmall = smallDataAccess.GetOrSmallData(selectCondition);
            }
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_MajorClassification> viewMajor, List<M_SmallClassification> viewSmall)
        {
            //中身を消去
            dgvMajor.Rows.Clear();

            dgvSmall.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int MlastPage = (int)Math.Ceiling(viewMajor.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var MdepData = viewMajor.Skip(pageSize * pageNum).Take(pageSize).ToList();
            //1行ずつdgvMajorに挿入
            foreach (var item in MdepData)
            {
                dgvMajor.Rows.Add(item.McID, item.McName, dictionaryHidden[item.McFlag], item.McHidden);
            }
            //dgvMajorをリフレッシュ
            dgvMajor.Refresh();

            if (MlastPage == -1 || (MlastPage == pageNum && pageNum == 0))
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
            else if (MlastPage == pageNum)
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
        //メソッド名：M_SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void M_SelectRowControl()
        {
            //データグリッドビューに乗っている情報をGUIに反映
            txbMajorID.Text = dgvMajor[0, dgvMajor.CurrentCellAddress.Y].Value.ToString();
            txbMajorName.Text = dgvMajor[1, dgvMajor.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvMajor[2, dgvMajor.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvMajor[3, dgvMajor.CurrentCellAddress.Y]?.Value?.ToString();
        }
        ///////////////////////////////
        //メソッド名：S_SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void S_SelectRowControl()
        {
            //データグリッドビューに乗っている情報をGUIに反映
            txbMajorID.Text = dgvSmall[0, dgvSmall.CurrentCellAddress.Y].Value.ToString();
            txbMajorName.Text = dgvSmall[1, dgvSmall.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvSmall[2, dgvSmall.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvSmall[3, dgvSmall.CurrentCellAddress.Y]?.Value?.ToString();
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
            dgvMajor.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvMajor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvMajor.AllowUserToResizeColumns = false;
            dgvMajor.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvMajor.MultiSelect = false;
            //セルの編集ができないように
            dgvMajor.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvMajor.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvMajor.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvMajor.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvMajor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMajor.Columns.Add("McID", "大分類ID");
            dgvMajor.Columns.Add("McName", "大分類名");
            dgvMajor.Columns.Add("McFlag", "管理フラグ");
            dgvMajor.Columns.Add("McHidden", "非表示理由");

            dgvMajor.Columns["McID"].Width = 225;
            dgvMajor.Columns["McName"].Width = 225;
            dgvMajor.Columns["McFlag"].Width = 225;
            dgvMajor.Columns["McHidden"].Width = 225;


            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvMajor.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvSmall.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvSmall.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvSmall.AllowUserToResizeColumns = false;
            dgvSmall.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvSmall.MultiSelect = false;
            //セルの編集ができないように
            dgvSmall.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvSmall.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvSmall.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvSmall.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvSmall.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSmall.Columns.Add("ScID", "小分類ID");
            dgvSmall.Columns.Add("ScName", "小分類名");
            dgvSmall.Columns.Add("ScFlag", "管理フラグ");
            dgvSmall.Columns.Add("ScHidden", "非表示理由");

            dgvSmall.Columns["ScID"].Width = 225;
            dgvSmall.Columns["ScName"].Width = 225;
            dgvSmall.Columns["ScFlag"].Width = 225;
            dgvSmall.Columns["ScHidden"].Width = 225;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvSmall.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void pctHint_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/document/d/1Z3YrjQt_mtU7ZRFNzO-mtclnj1IlsH01",
                UseShellExecute = true
            });
        }
    }
}

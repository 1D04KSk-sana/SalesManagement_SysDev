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
        //DataGridView用に使用する確定形式のDictionary
        private Dictionary<int, string> dictionaryConfirm = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        public F_HonshaClassification()
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


            rdbMajorRegister.Checked = true;

            GetDataGridView();
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            //大分類登録ラヂオボタンがチェックされているとき
            if (rdbMajorRegister.Checked)
            {
                MajorDataRegister();
            }
            //大分類更新ラヂオボタンがチェックされているとき
            if (rdbMajorUpdate.Checked)
            {
                MajorDataUpdate();
            }
            //大分類検索ラヂオボタンがチェックされているとき
            if (rdbMajorSearch.Checked)
            {
                MajorDataSelect();
            }
            //大分類登録ラヂオボタンがチェックされているとき
            if (rdbSmallRegister.Checked)
            {
                SmallDataRegister();
            }
            //大分類更新ラヂオボタンがチェックされているとき
            if (rdbSmallUpdate.Checked)
            {
                SmallDataUpdate();
            }
            //大分類検索ラヂオボタンがチェックされているとき
            if (rdbSmallSearch.Checked)
            {
                SmallDataSelect();
            }
        }
        ///////////////////////////////
        //メソッド名：MajorDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：大分類情報登録の実行
        ///////////////////////////////
        private void MajorDataRegister()
        {
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //テキストボックス等の入力チェック
            if (!GetValidMDataAtRegistration())
            {
                return;
            }

            //操作ログデータ取得
            var regOperationLog = GenerateMLogAtRegistration(rdbMajorRegister.Text);

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
        //メソッド名：MajorDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：大分類情報登録の実行
        ///////////////////////////////
        private void SmallDataRegister()
        {
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //テキストボックス等の入力チェック
            if (!GetValidSDataAtRegistration())
            {
                return;
            }

            //操作ログデータ取得
            var regOperationLog = GenerateSLogAtRegistration(rdbMajorRegister.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 顧客情報作成
            var regMaker = GenerateSDataAtRegistration();

            // 顧客情報登録
            RegistrationSmall(regSmall);
        }
        ///////////////////////////////
        //メソッド名：RegistrationMaker()
        //引　数   ：メーカー情報
        //戻り値   ：なし
        //機　能   ：メーカーデータの登録
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
        //メソッド名：RegistrationMaker()
        //引　数   ：メーカー情報
        //戻り値   ：なし
        //機　能   ：メーカーデータの登録
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
                McID = int.Parse(txbMajorID.Text.Trim()),
                McName = string.Format(txbMajorName.Text.Trim()),
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
            return new M_SmallClassification
            {
                ScID = int.Parse(txbSmallID.Text.Trim()),
                ScName = string.Format(txbSmallName.Text.Trim()),
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
                if (majorDataAccess.CheckMajorIDExistence(int.Parse(txbMajorID.Text.Trim())))
                {
                    MessageBox.Show("大分類IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("メーカー名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorName.Focus();
                    return false;
                }
                //大分類名の重複チェック
                if (majorDataAccess.CheckMajorNameExistence(string.Format(txbMajorName.Text.Trim())))
                {
                    MessageBox.Show("メーカー名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //メソッド名：GetValidMDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：登録入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidSDataAtRegistration()
        {
            // 小分類IDの適否
            if (!String.IsNullOrEmpty(txbSmallID.Text.Trim()))
            {
                // 小分類IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSmallID.Text.Trim()))
                {
                    MessageBox.Show("小分類IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorID.Focus();
                    return false;
                }
                //小分類IDの重複チェック
                if (smallDataAccess.CheckSmallIDExistence(int.Parse(txbSmallID.Text.Trim())))
                {
                    MessageBox.Show("小分類IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorID.Focus();
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
                //小分類名の重複チェック
                if (smallDataAccess.CheckSmallNameExistence(string.Format(txbSmallName.Text.Trim())))
                {
                    MessageBox.Show("小分類名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMajorName.Focus();
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
                OpDBID = int.Parse(txbSmallID.Text.Trim()),
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

            List<M_SmallClassification> listViewSmall = smallDataAccess.GetSmallData();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewMajor,listViewSmall);
        }
        ///////////////////////////////
        //メソッド名：SetListMajor()
        //引　数   ：なし
        //戻り値   ：表示用大分類データ
        //機　能   ：表示用大分類データの準備
        ///////////////////////////////
        private List<M_MajorClassification> SetListMajor()
        {
            //顧客のデータを全取得
            listAllMajor = majorDataAccess.GetMajorData();

            //表示用の顧客リスト作成
            List<M_MajorClassification> listViewMajor = new List<M_MajorClassification>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbMajorSearch.Checked)
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
                // 管理Flgが表示の部署データの取得
                listViewMajor = majorDataAccess.GetMajorDspData(listViewMajor);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewMajor = majorDataAccess.GetMajorNotDspData(listViewMajor);
            }

            return listViewMajor;
        }
        ///////////////////////////////
        //メソッド名：SetListMajor()
        //引　数   ：なし
        //戻り値   ：表示用大分類データ
        //機　能   ：表示用大分類データの準備
        ///////////////////////////////
        private List<M_SmallClassification> SetListSmall()
        {
            //顧客のデータを全取得
            listAllSmall = smallDataAccess.GetSmallData();

            //表示用の顧客リスト作成
            List<M_SmallClassification> listViewSmall = new List<M_SmallClassification>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbMajorSearch.Checked)
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
                // 管理Flgが表示の部署データの取得
                listViewSmall = smallDataAccess.GetSmallDspData(listViewSmall);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewSmall = smallDataAccess.GetSmallNotDspData(listViewSmall);
            }

            return listViewSmall;
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
            int lastPage = (int)Math.Ceiling(viewMajor.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewMajor.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvMakerに挿入
            foreach (var item in depData)
            {
                dgvMajor.Rows.Add(item.McID, item.McName, dictionaryHidden[item.McFlag], item.McHidden);
            }

            //dgvMajorをリフレッシュ
            dgvMajor.Refresh();

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
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            //データグリッドビューに乗っている情報をGUIに反映
            txbMajorID.Text = dgvMajor[0, dgvMajor.CurrentCellAddress.Y].Value.ToString();
            txbMajorName.Text = dgvMajor[1, dgvMajor.CurrentCellAddress.Y].Value.ToString();
            txbSmallID.Text = dgvSmall[0, dgvSmall.CurrentCellAddress.Y].Value.ToString();
            txbSmallName.Text = dgvSmall[1, dgvSmall.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvMajor[2, dgvMajor.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvMajor[3, dgvMajor.CurrentCellAddress.Y]?.Value?.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvSmall[2, dgvMajor.CurrentCellAddress.Y].Value.ToString()).Key;
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

            dgvMajor.Columns["McID"].Width = 120;
            dgvMajor.Columns["McName"].Width = 120;
            dgvMajor.Columns["McFlag"].Width = 120;
            dgvMajor.Columns["McHidden"].Width = 120;


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

            dgvSmall.Columns["ScID"].Width = 120;
            dgvSmall.Columns["ScName"].Width = 120;
            dgvSmall.Columns["ScFlag"].Width = 120;
            dgvSmall.Columns["ScHidden"].Width = 120;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvSmall.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}

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
    public partial class F_HonshaPosition : Form
    {
        //データグリッドビュー用の顧客データ
        private static List<M_Position> listPosition = new List<M_Position>();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の全役職データ
        private static List<M_Position> listAllPosition = new List<M_Position>();
        //データベース役職テーブルアクセス用クラスのインスタンス化
        PositionDataAccess positionDataAccess = new PositionDataAccess();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();


        //DataGridView用に使用す社員のDictionary
        private Dictionary<int, string> dictionaryPosition;
        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        public F_HonshaPosition()
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

            txbNumPage.Text = "1";

            GetDataGridView();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                PositionDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                PositionDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                PositionDataSelect();
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
            txbPositionID.Text = string.Empty;
            txbPositionName.Text = string.Empty;
            txbHidden.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
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

        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            PositionSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            PositionSearchButtonClick(false);
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = (int.Parse(txbNumPage.Text.Trim()) + 1).ToString();

            GetDataGridView();
        }

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<M_Position> viewPosition = SetListPosition();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewPosition.Count / (double)pageSize);

            if (lastPage == 0)
            {
                lastPage++;
            }

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
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
            //表示用の顧客リスト作成
            List<M_Position> listViewPosition = SetListPosition();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewPosition);
        }

        ///////////////////////////////
        //メソッド名：PositionSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void PositionSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listPosition.Count;

            txbNumPage.Text = "1";

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////
        //メソッド名：SetListPosition()
        //引　数   ：なし
        //戻り値   ：表示用顧客データ
        //機　能   ：表示用顧客データの準備
        ///////////////////////////////
        private List<M_Position> SetListPosition()
        {
            //役職のデータを全取得
            listAllPosition = positionDataAccess.GetPositionData();

            //表示用の役職リスト作成
            List<M_Position> listViewPosition = new List<M_Position>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewPosition = listPosition;
            }
            else
            {
                //全データをとってくる
                listViewPosition = listAllPosition;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewPosition = positionDataAccess.GetPositionDspData(listViewPosition);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewPosition = positionDataAccess.GetPositionNotDspData(listViewPosition);
            }

            return listViewPosition;
        }


        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_Position> viewPosition)
        {
            //中身を消去
            dgvPosition.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewPosition.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewPosition.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvPosition.Rows.Add(item.PoID, item.PoName, dictionaryHidden[item.PoFlag], item.PoHidden);
            }

            //dgvClientをリフレッシュ
            dgvPosition.Refresh();

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
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの初期設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //列を自由に設定できるように
            dgvPosition.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvPosition.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvPosition.AllowUserToResizeColumns = false;
            dgvPosition.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvPosition.MultiSelect = false;
            //セルの編集ができないように
            dgvPosition.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvPosition.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvPosition.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvPosition.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvPosition.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPosition.Columns.Add("PoID", "役職ID");
            dgvPosition.Columns.Add("PoName", "役職名");
            dgvPosition.Columns.Add("PoFlag", "役職管理フラグ");
            dgvPosition.Columns.Add("PoHidden", "非表示理由");

            dgvPosition.Columns["PoID"].Width = 250;
            dgvPosition.Columns["PoName"].Width = 250;
            dgvPosition.Columns["PoFlag"].Width = 500;
            dgvPosition.Columns["PoHidden"].Width = 900;

            dgvPosition.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(69)))));
            dgvPosition.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvPosition.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void F_HonshaPosition_Load(object sender, EventArgs e)
        {
            rdbRegister.Checked = true;
            
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            DictionarySet();

            SetFormDataGridView();

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
        }

        ///////////////////////////////
        //メソッド名：GenerateLogAtRegistration()
        //引　数   ：操作名
        //戻り値   ：操作ログ登録情報
        //機　能   ：操作ログ情報登録データのセット
        ///////////////////////////////
        private T_OperationLog GenerateLogAtRegistration(string OperationDone)
        {
            int? intDBID = 0;

            if (OperationDone == "登録")
            {
                var context = new SalesManagement_DevContext();

                intDBID = context.M_Positions.Count() + 1;
            }
            else
            {
                intDBID = int.Parse(txbPositionID.Text.Trim());
            }

            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "役職管理",
                OpDone = OperationDone,
                OpDBID = intDBID,
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：PositionDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報登録の実行
        ///////////////////////////////
        private void PositionDataRegister()
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

            // 役職情報作成
            var regPosition = GenerateDataAtRegistration();

            // 役職情報登録
            RegistrationPosition(regPosition);
        }

        ///////////////////////////////
        //メソッド名：RegistrationPosition()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客データの登録
        ///////////////////////////////
        private void RegistrationPosition(M_Position regPosition)
        {
            // 顧客情報の登録
            bool flg = positionDataAccess.AddPositionData(regPosition);

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
        private M_Position GenerateDataAtRegistration()
        {
            return new M_Position
            {
                PoName = txbPositionName.Text.Trim(),
                PoFlag = cmbHidden.SelectedIndex,
                PoHidden = txbHidden.Text.Trim(),
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
            // 顧客名の適否
            if (!String.IsNullOrEmpty(txbPositionName.Text.Trim()))
            {
                // 顧客名の文字数チェック
                if (txbPositionName.TextLength >= 50)
                {
                    MessageBox.Show("役職名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPositionName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("役職名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPositionName.Focus();
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
        //メソッド名：PositionDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報更新の実行
        ///////////////////////////////
        private void PositionDataUpdate()
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

            // 役職情報作成
            var updPosition = GenerateDataAtUpdate();

            // 役職情報更新
            UpdatePosition(updPosition);
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
            // 役職IDの適否
            if (!String.IsNullOrEmpty(txbPositionID.Text.Trim()))
            {
                // 役職IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbPositionID.Text.Trim()))
                {
                    MessageBox.Show("役職IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPositionID.Focus();
                    return false;
                }
                //役職IDの存在チェック
                if (!positionDataAccess.CheckPositionIDExistence(int.Parse(txbPositionID.Text.Trim())))
                {
                    MessageBox.Show("役職IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPositionID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("役職IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPositionID.Focus();
                return false;
            }

            // 役職名の適否
            if (!String.IsNullOrEmpty(txbPositionName.Text.Trim()))
            {
                // 役職名の文字数チェック
                if (txbPositionName.TextLength >= 50)
                {
                    MessageBox.Show("役職名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPositionName.Focus();
                    return false;
                }

                M_Position Position = positionDataAccess.GetPositionIDData(int.Parse(txbPositionID.Text.Trim()));

                if (Position.PoName != txbPositionName.Text.Trim())
                {
                    MessageBox.Show("役職名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPositionID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("役職名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPositionName.Focus();
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
        //戻り値   ：顧客更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_Position GenerateDataAtUpdate()
        {
            return new M_Position
            {
                PoID = int.Parse(txbPositionID.Text.Trim()),
                PoName = txbPositionName.Text.Trim(),
                PoHidden = txbHidden.Text.Trim(),
                PoFlag = cmbHidden.SelectedIndex,
            };
        }

        ///////////////////////////////
        //メソッド名：UpdatePosition()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客情報の更新
        ///////////////////////////////
        private void UpdatePosition(M_Position updPosition)
        {
            // 顧客情報の更新
            bool flg = positionDataAccess.UpdatePositionData(updPosition);
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
        //メソッド名：PositionDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void PositionDataSelect()
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
            if (String.IsNullOrEmpty(txbPositionID.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPositionID.Focus();
                return false;
            }

            // 役職IDの適否
            if (!String.IsNullOrEmpty(txbPositionID.Text.Trim()))
            {
                // 役職IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbPositionID.Text.Trim()))
                {
                    MessageBox.Show("役職IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPositionID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (!positionDataAccess.CheckPositionIDExistence(int.Parse(txbPositionID.Text.Trim())))
                {
                    MessageBox.Show("役職IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPositionID.Focus();
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
            txbPositionID.Text = dgvPosition[0, dgvPosition.CurrentCellAddress.Y].Value.ToString();
            txbPositionName.Text = dgvPosition[1, dgvPosition.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvPosition[2, dgvPosition.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvPosition[3, dgvPosition.CurrentCellAddress.Y]?.Value?.ToString();
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：顧客情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strPositionID = txbPositionID.Text.Trim();
            int intPositionID = 0;

            if (!String.IsNullOrEmpty(strPositionID))
            {
                intPositionID = int.Parse(strPositionID);
            }

            // 検索条件のセット
            M_Position selectCondition = new M_Position()
            {
                PoID = intPositionID,
                PoName = txbPositionName.Text.Trim(),
                PoHidden = txbHidden.Text.Trim()

            };

            if (searchFlg)
            {
                // 役職データのAnd抽出
                listPosition = positionDataAccess.GetAndPositionData(selectCondition);
            }
            else
            {
                // 役職データのOr抽出
                listPosition = positionDataAccess.GetOrPositionData(selectCondition);
            }
        }

        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvPosition.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();
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
            listPosition = positionDataAccess.GetPositionDspData();

            dictionaryPosition = new Dictionary<int, string> { };

            foreach (var item in listPosition)
            {
                dictionaryPosition.Add(item.PoID, item.PoName);
            }
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

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                txbPositionID.Enabled = true;
                txbPositionName.Enabled = true;
                txbHidden.Enabled = false;
                cmbHidden.Enabled = false;
            }

            if (rdbRegister.Checked)
            {
                txbPositionID.Enabled = true;
                txbPositionName.Enabled = true;
                txbHidden.Enabled = true;
                cmbHidden.Enabled = true;
            }


            if (rdbUpdate.Checked)
            {
                txbPositionID.Enabled = true;
                txbPositionName.Enabled = true;
                txbHidden.Enabled = true;
                cmbHidden.Enabled = true;
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
                FileName = "https://docs.google.com/document/d/1gg14VPnUVGjmiVEmFMjEHm2udjTegejpo6AO7PUOW0s",
                UseShellExecute = true
            });
        }
    }
}

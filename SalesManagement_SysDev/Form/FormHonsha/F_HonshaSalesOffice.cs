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
    public partial class F_HonshaSalesOffice : Form
    {
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の全顧客データ
        private static List<M_SalesOffice> listAllSalesOffice = new List<M_SalesOffice>();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        public F_HonshaSalesOffice()
        {
            InitializeComponent();
        }

        private void F_HonshaSalesOffice_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
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
        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            SalesOfficeSearchButtonClick(true);
        }
        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            SalesOfficeSearchButtonClick(false);
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //データグリッドビューのデータ取得
            GetDataGridView();
        }
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
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
            List<M_SalesOffice> viewSalesOffice = SetListSalesOffice();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewSalesOffice.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }
        private void dgvSalesOffice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvSalesOffice.SelectedCells.Count == 0)
            {
                return;
            }
            //選択された行に対してのコントロールの変更
            SelectRowControl();
        }
            private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                SalesOfficeDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                SalesOfficeDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                SalesOfficeDataSelect();
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
            txbSalesOfficeID.Text = string.Empty;
            txbSalesOfficePhone.Text = string.Empty;
            txbSalesOfficePostal.Text = string.Empty;
            txbSalesOfficeAddress.Text = string.Empty;
            txbHidden.Text = string.Empty;
            txbSalesOfficeName.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
            txbSalesOfficeFAX.Text = string.Empty;
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
            List<M_SalesOffice> listViewSalesOffice = SetListSalesOffice();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewSalesOffice);
        }
        ///////////////////////////////
        //メソッド名：SetListSalesOffice()
        //引　数   ：なし
        //戻り値   ：表示用営業所データ
        //機　能   ：表示用営業所データの準備
        ///////////////////////////////
        private List<M_SalesOffice> SetListSalesOffice()
        {
            //顧客のデータを全取得
            listAllSalesOffice = salesOfficeDataAccess.GetSalesOfficeData();

            //表示用の顧客リスト作成
            List<M_SalesOffice> listViewSalesOffice = new List<M_SalesOffice>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewSalesOffice = listSalesOffice;
            }
            else
            {
                //全データをとってくる
                listViewSalesOffice = listAllSalesOffice;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewSalesOffice = salesOfficeDataAccess.GetSalesOfficeDspData(listViewSalesOffice);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewSalesOffice = salesOfficeDataAccess.GetSalesOfficeNotDspData(listViewSalesOffice);
            }

            return listViewSalesOffice;
        }
        ///////////////////////////////
        //メソッド名：SalesOfficeDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報登録の実行
        ///////////////////////////////
        private void SalesOfficeDataRegister()
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
            var regSalesOffice = GenerateDataAtRegistration();

            // 顧客情報登録
            RegistrationSalesOffice(regSalesOffice);
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
            if (!String.IsNullOrEmpty(txbSalesOfficeID.Text.Trim()))
            {
                // 営業所IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSalesOfficeID.Text.Trim()))
                {
                    MessageBox.Show("営業所IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeID.Focus();
                    return false;
                }
                //営業所IDの重複チェック
                if (salesOfficeDataAccess.CheckSalesOfficeIDExistence(int.Parse(txbSalesOfficeID.Text.Trim())))
                {
                    MessageBox.Show("営業所IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("営業所IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeID.Focus();
                return false;
            }

            // 営業所名の適否
            if (!String.IsNullOrEmpty(txbSalesOfficeName.Text.Trim()))
            {
                // 営業所名の文字数チェック
                if (txbSalesOfficeName.TextLength > 50)
                {
                    MessageBox.Show("営業所名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeName.Focus();
                    return false;
                }
                //営業所名の重複チェック
                if (salesOfficeDataAccess.CheckSalesOfficeNameExistence(string.Format(txbSalesOfficeName.Text.Trim())))
                {
                    MessageBox.Show("営業所名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("営業所名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeName.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbSalesOfficePhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbSalesOfficePhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficePhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficePhone.Focus();
                return false;
            }


            // 郵便番号の適否
            if (!String.IsNullOrEmpty(txbSalesOfficePostal.Text.Trim()))
            {
                // 郵便番号の数字チェック
                if (!dataInputCheck.CheckNumeric(txbSalesOfficePostal.Text.Trim()))
                {
                    MessageBox.Show("郵便番号は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficePostal.Focus();
                    return false;
                }
                // 郵便番号の文字数チェック
                if (txbSalesOfficePostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficePostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficePostal.Focus();
                return false;
            }

            // 住所の適否
            if (!String.IsNullOrEmpty(txbSalesOfficeAddress.Text.Trim()))
            {
                // 住所の文字数チェック
                if (txbSalesOfficeAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeAddress.Focus();
                return false;
            }

            // FAXの適否
            if (!String.IsNullOrEmpty(txbSalesOfficeFAX.Text.Trim()))
            {
                // FAXの文字数チェック
                if (txbSalesOfficeFAX.TextLength > 13)
                {
                    MessageBox.Show("FAXは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeFAX.Focus();
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
                FormName = "営業所管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbSalesOfficeID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }
                ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：営業所登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_SalesOffice GenerateDataAtRegistration()

        {
            return new M_SalesOffice
            {
                SoID = int.Parse(txbSalesOfficeID.Text.Trim()),
                SoName = string.Format(txbSalesOfficeName.Text.Trim()),
                SoAddress = txbSalesOfficeAddress.Text.Trim(),
                SoPhone = txbSalesOfficePhone.Text.Trim(),
                SoPostal = txbSalesOfficePostal.Text.Trim(),
                SoFAX = txbSalesOfficeFAX.Text.Trim(),
                SoFlag = cmbHidden.SelectedIndex,
                SoHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：RegistrationSalesOffice()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客データの登録
        ///////////////////////////////
        private void RegistrationSalesOffice(M_SalesOffice regSalesOffice)
        {
            // 営業所情報の登録
            bool flg = salesOfficeDataAccess.AddSalesOfficeData(regSalesOffice);

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
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_SalesOffice> viewSalesOffice)
        {
            //中身を消去
            dgvSalesOffice.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewSalesOffice.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewSalesOffice.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvSalesOfficeに挿入
            foreach (var item in depData)
            {
                dgvSalesOffice.Rows.Add(item.SoID,  item.SoName, item.SoAddress, item.SoPhone, item.SoPostal, item.SoFAX, dictionaryHidden[item.SoFlag], item.SoHidden);
            }

            //dgvClientをリフレッシュ
            dgvSalesOffice.Refresh();

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
        //メソッド名：SalesOfficeDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void SalesOfficeDataSelect()
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
            if (String.IsNullOrEmpty(txbSalesOfficeID.Text.Trim()) && String.IsNullOrEmpty(txbSalesOfficeName.Text.Trim()) && String.IsNullOrEmpty(txbSalesOfficePhone.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeID.Focus();
                return false;
            }

            // 営業所IDの適否
            if (!String.IsNullOrEmpty(txbSalesOfficeID.Text.Trim()))
            {
                // 営業所IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSalesOfficeID.Text.Trim()))
                {
                    MessageBox.Show("営業所IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeID.Focus();
                    return false;
                }
                //営業所IDの重複チェック
                if (!salesOfficeDataAccess.CheckSalesOfficeIDExistence(int.Parse(txbSalesOfficeID.Text.Trim())))
                {
                    MessageBox.Show("営業所IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeID.Focus();
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
        private void SalesOfficeSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listSalesOffice.Count;

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
            string strSalesOfficeID = txbSalesOfficeID.Text.Trim();
            int intSalesOfficeID = 0;

            if (!String.IsNullOrEmpty(strSalesOfficeID))
            {
                intSalesOfficeID = int.Parse(strSalesOfficeID);
            }

            // 検索条件のセット
            M_SalesOffice selectCondition = new M_SalesOffice()
            {
                SoID = intSalesOfficeID,
                //SoName = txbSalesOfficeName.Text.Trim()
                SoPhone = txbSalesOfficePhone.Text.Trim(),
                //SoPostal= txbSalesOfficePostal.Text.Trim(),
                //SoAddress= txbSalesOfficeAddress.Text.Trim(),
                //SoFAX=txbSalesOfficeFax.Text.Trim(),
                //SoHidden=txbHidden.Text.Trim()
            };

            if (searchFlg)
            {
                // 顧客データのAnd抽出
                listSalesOffice = salesOfficeDataAccess.GetAndSalesOfficeData(selectCondition);
            }
            else
            {
                // 顧客データのOr抽出
                listSalesOffice = salesOfficeDataAccess.GetOrSalesOfficetData(selectCondition);
            }
        }
        ///////////////////////////////
        //メソッド名：SalesOfficeDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：営業所情報更新の実行
        ///////////////////////////////
        private void SalesOfficeDataUpdate()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtUpdate())
            {
                return;
            }

            // 顧客情報作成
            var updSalesOffice = GenerateDataAtUpdate();

            // 顧客情報更新
            UpdateSalesOffice(updSalesOffice);
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
            if (!String.IsNullOrEmpty(txbSalesOfficeID.Text.Trim()))
            {
                // 営業所IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSalesOfficeID.Text.Trim()))
                {
                    MessageBox.Show("営業所IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeID.Focus();
                    return false;
                }
                //営業所IDの存在チェック
                if (!salesOfficeDataAccess.CheckSalesOfficeIDExistence(int.Parse(txbSalesOfficeID.Text.Trim())))
                {
                    MessageBox.Show("営業所IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("営業所IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeID.Focus();
                return false;
            }

            // 営業所名の適否
            if (!String.IsNullOrEmpty(txbSalesOfficeName.Text.Trim()))
            {
                // 営業所名の文字数チェック
                if (txbSalesOfficeName.TextLength > 50)
                {
                    MessageBox.Show("営業所名は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeName.Focus();
                    return false;
                }
                //営業所名存在チェック
                if (!salesOfficeDataAccess.CheckSalesOfficeNameExistence(txbSalesOfficeName.Text.Trim()))
                {
                    MessageBox.Show("メーカー名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("営業所名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeName.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbSalesOfficePhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbSalesOfficePhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficePhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeName.Focus();
                return false;
            }


            // 郵便番号の適否
            if (!String.IsNullOrEmpty(txbSalesOfficePostal.Text.Trim()))
            {
                // 郵便番号の数字チェック
                if (!dataInputCheck.CheckNumeric(txbSalesOfficePostal.Text.Trim()))
                {
                    MessageBox.Show("郵便番号は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficePostal.Focus();
                    return false;
                }
                // 郵便番号の文字数チェック
                if (txbSalesOfficePostal.TextLength > 7)
                {
                    MessageBox.Show("郵便番号は7文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficePostal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("郵便番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficePostal.Focus();
                return false;
            }

            // 住所の適否
            if (!String.IsNullOrEmpty(txbSalesOfficeAddress.Text.Trim()))
            {
                // 住所の文字数チェック
                if (txbSalesOfficeAddress.TextLength > 50)
                {
                    MessageBox.Show("住所は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeAddress.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("住所が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeAddress.Focus();
                return false;
            }

            // FAXの適否
            if (!String.IsNullOrEmpty(txbSalesOfficeFAX.Text.Trim()))
            {
                // FAXの文字数チェック
                if (txbSalesOfficeFAX.TextLength > 13)
                {
                    MessageBox.Show("FAXは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSalesOfficeFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSalesOfficeFAX.Focus();
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
        private M_SalesOffice GenerateDataAtUpdate()
        {
            return new M_SalesOffice
            {
                SoID = int.Parse(txbSalesOfficeID.Text.Trim()),
                SoName = string.Format(txbSalesOfficeName.Text.Trim()),
                SoAddress = txbSalesOfficeAddress.Text.Trim(),
                SoPhone = txbSalesOfficePhone.Text.Trim(),
                SoPostal = txbSalesOfficePostal.Text.Trim(),
                SoFAX = txbSalesOfficeFAX.Text.Trim(),
                SoFlag = cmbHidden.SelectedIndex,
                SoHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：UpdateSalesOffice()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客情報の更新
        ///////////////////////////////
        private void UpdateSalesOffice(M_SalesOffice updSalesOffice)
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
            bool flg = salesOfficeDataAccess.UpdateSalesOfficeData(updSalesOffice);
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
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの初期設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //列を自由に設定できるように
            dgvSalesOffice.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvSalesOffice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvSalesOffice.AllowUserToResizeColumns = false;
            dgvSalesOffice.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvSalesOffice.MultiSelect = false;
            //セルの編集ができないように
            dgvSalesOffice.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvSalesOffice.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvSalesOffice.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvSalesOffice.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvSalesOffice.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSalesOffice.Columns.Add("SoID", "営業所ID");
            dgvSalesOffice.Columns.Add("SoName", "営業所名");
            dgvSalesOffice.Columns.Add("SoAddress", "住所");
            dgvSalesOffice.Columns.Add("SoPhone", "電話番号");
            dgvSalesOffice.Columns.Add("SoPostal", "郵便番号");
            dgvSalesOffice.Columns.Add("SoFAX", "FAX");
            dgvSalesOffice.Columns.Add("SoFlag", "営業所管理フラグ");
            dgvSalesOffice.Columns.Add("SoHidden", "非表示理由");

            dgvSalesOffice.Columns["SoID"].Width = 241;
            dgvSalesOffice.Columns["SoName"].Width = 237;
            dgvSalesOffice.Columns["SoAddress"].Width = 237;
            dgvSalesOffice.Columns["SoPhone"].Width = 237;
            dgvSalesOffice.Columns["SoPostal"].Width = 237;
            dgvSalesOffice.Columns["SoFAX"].Width = 237;
            dgvSalesOffice.Columns["SoFlag"].Width = 237;
            dgvSalesOffice.Columns["SoHidden"].Width = 237;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvSalesOffice.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            txbSalesOfficeID.Text = dgvSalesOffice[0, dgvSalesOffice.CurrentCellAddress.Y].Value.ToString();
            txbSalesOfficeName.Text = dgvSalesOffice[1, dgvSalesOffice.CurrentCellAddress.Y].Value.ToString();
            txbSalesOfficeAddress.Text = dgvSalesOffice[2, dgvSalesOffice.CurrentCellAddress.Y].Value.ToString();
            txbSalesOfficePhone.Text = dgvSalesOffice[3, dgvSalesOffice.CurrentCellAddress.Y].Value.ToString();
            txbSalesOfficePostal.Text = dgvSalesOffice[4, dgvSalesOffice.CurrentCellAddress.Y].Value.ToString();
            txbSalesOfficeFAX.Text = dgvSalesOffice[5, dgvSalesOffice.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvSalesOffice[6, dgvSalesOffice.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvSalesOffice[7, dgvSalesOffice.CurrentCellAddress.Y]?.Value?.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctHint_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/document/d/1EwgtxiqAgD8eJP7D9e6v9xkQuUIdCJ1H/edit=true",
                UseShellExecute = true
            });
        }
    }
}

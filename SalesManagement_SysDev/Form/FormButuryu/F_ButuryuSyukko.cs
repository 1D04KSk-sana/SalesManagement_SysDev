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
    public partial class F_ButuryuSyukko : Form
    {
        //データベース出庫テーブルアクセス用クラスのインスタンス化
        SyukkoDataAccess SyukkoDataAccess = new SyukkoDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        //データベース入荷テーブルアクセス用クラスのインスタンス化
        ArrivalDataAccess arrivalDataAccess = new ArrivalDataAccess();
        //データベース入荷詳細テーブルアクセス用クラスのインスタンス化
        ArrivalDetailDataAccess arrivalDetailDataAccess = new ArrivalDetailDataAccess();
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess SalesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース出庫詳細テーブルアクセス用クラスのインスタンス化
        SyukkoDetailDataAccess SyukkoDetailDataAccess = new SyukkoDetailDataAccess();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //データベース注文テーブルアクセス用クラスのインスタンス化
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //データグリッドビュー用の全出庫データ
        private static List<T_Syukko> listAllSyukko = new List<T_Syukko>();
        //データグリッドビュー用の出庫データ
        private static List<T_Syukko> listsyukko = new List<T_Syukko>();
        //データグリッドビュー用の全出庫データ
        private static List<T_SyukkoDetail> listAllSyukkoDetail = new List<T_SyukkoDetail>();
        //データグリッドビュー用の営業所データ
        private static List<M_SalesOffice> listSalesOfficeID = new List<M_SalesOffice>();
        //データグリッドビュー用の商品データ
        private static List<M_Product> listProdact = new List<M_Product>();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //コンボボックス用の社員データリスト
        private static List<M_Employee> listEmployee = new List<M_Employee>();
        //コンボボックス用の顧客データリスト
        private static List<M_Client> listClient = new List<M_Client>();

        //DataGridView用に使用する営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;
        //DataGridView用に使用する大分類名のDictionary
        //private Dictionary<int, string> dictionarySoID;
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
        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryFlag = new Dictionary<int, string>
        {
            { 0, "未確定" },
            { 1, "確定" },
        };

        public F_ButuryuSyukko()
        {
            InitializeComponent();
        }

        private void F_ButuryuSyukko_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            DictionarySet();

            // 取得したデータをコンボボックスに挿入
            cmbSalesOfficeID.DataSource = listSalesOfficeID;
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
        
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
            dtpSyukkoDate.Checked = false;

            rdbHidden.Checked = true;

            txbNumPage.Text = "1";

            GetDataGridView();
        }

       
        private void btnDone_Click(object sender, EventArgs e)
        {
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ProdactDataSelect();
            }

            //確定ラヂオボタンがチェックされているとき
            if (rdbConfirm.Checked)
            {
                SyukkoDataConfirm();
            }

            //非表示ラヂオボタンがチェックされているとき
            if (rdbHidden.Checked)
            {
                SyukkoDataUpdate();
            }
        }
        
        private void dgvSyukko_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvSyukko.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();

            SetDataDetailGridView(int.Parse(dgvSyukko[0, dgvSyukko.CurrentCellAddress.Y].Value.ToString()));
        }

        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ProdactSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ProdactSearchButtonClick(false);
        }

        ///////////////////////////////
        //メソッド名：SyukkoDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：出庫情報更新の実行
        ///////////////////////////////
        private void SyukkoDataUpdate()
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
            var regOperationLog = GenerateLogAtRegistration(rdbHidden.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 出庫情報作成
            var updSyukko = GenerateDataAtUpdate();

            // 出庫情報更新
            UpdateSyukko(updSyukko);
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：受注更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private T_Syukko GenerateDataAtUpdate()
        {
            return new T_Syukko
            {
                SyID = int.Parse(txbSyukkoID.Text.Trim()),
                SyFlag = 1,
                SyHidden = txbHidden.Text.Trim(),
            };
        }

        ///////////////////////////////
        //メソッド名：UpdateSyukko()
        //引　数   ：受注情報
        //戻り値   ：なし
        //機　能   ：受注情報の更新
        ///////////////////////////////
        private void UpdateSyukko(T_Syukko updSyukko)
        {
            // 受注情報の更新
            bool flg = SyukkoDataAccess.UpdateSyukkoData(updSyukko);

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
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtUpdate()
        {
            //出庫IDの適否
            if (!String.IsNullOrEmpty(txbSyukkoID.Text.Trim()))
            {
                // 受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSyukkoID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSyukkoID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (!SyukkoDataAccess.CheckSyukkoIDExistence(int.Parse(txbSyukkoID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSyukkoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("出庫IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSyukkoID.Focus();
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
        //メソッド名：SyukkoDataConfirm()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：出庫情報確定の実行
        ///////////////////////////////
        private void SyukkoDataConfirm()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtConfirm())
            {
                return;
            }

            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("確定しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
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
            var cmfSyukko = GenerateDataAtConfirm();

            // 受注情報更新
            ConfirmSyukko(cmfSyukko);
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：受注登録情報
        //機　能   ：確定データのセット
        ///////////////////////////////
        private T_Syukko GenerateDataAtConfirm()
        {
            return new T_Syukko
            {
                SyID = int.Parse(txbSyukkoID.Text.Trim()),
                SyDate = DateTime.Now,
                EmID = F_Login.intEmployeeID,
                SyStateFlag = 1,
            };
        }

        ///////////////////////////////
        //メソッド名：ConfirmSyukko()
        //引　数   ：受注情報
        //戻り値   ：なし
        //機　能   ：受注情報の確定
        ///////////////////////////////
        private void ConfirmSyukko(T_Syukko cfmSyukko)
        {
            // 出庫情報の更新
            bool flg = SyukkoDataAccess.ConfirmSyukkoData(cfmSyukko);

            if (flg == true)
            {
                MessageBox.Show("確定しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("確定に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //入荷登録
            T_Syukko Syukko = SyukkoDataAccess.GetIDSyukkoData(cfmSyukko.SyID);

            T_Arrival Arrival = GenerateArrivalAtRegistration(Syukko);

            bool flgArrival = arrivalDataAccess.AddArrivalData(Arrival);

            if (flgArrival == true)
            {
                MessageBox.Show("入荷管理にデータを送信ました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("入荷管理へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //入荷詳細登録
            List<T_SyukkoDetail> listSyukkoDetail = SyukkoDetailDataAccess.GetSyukkoDetailIDData(cfmSyukko.SyID);

            List<bool> flgSyukkolist = new List<bool>();
            bool flgSyukko = true;

            foreach (var item in listSyukkoDetail)
            {
                T_ArrivalDetail ArrivalDetail = GenerateArrivalDetailAtRegistration(item, Syukko);

                flgSyukkolist.Add(arrivalDetailDataAccess.AddArrivalDetailData(ArrivalDetail));
            }

            foreach (var item in flgSyukkolist)
            {
                if (!item)
                {
                    flgSyukko = false;
                }
            }

            if (flgSyukko)
            {
                MessageBox.Show("入荷詳細へデータを送信しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("入荷詳細へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //テキストボックス等のクリア
            ClearImput();

            // データグリッドビューの表示
            GetDataGridView();
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
            //出庫IDの適否
            if (!String.IsNullOrEmpty(txbSyukkoID.Text.Trim()))
            {
                // 出庫IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSyukkoID.Text.Trim()))
                {
                    MessageBox.Show("出庫IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSyukkoID.Focus();
                    return false;
                }
                //出庫IDの存在チェック
                if (!SyukkoDataAccess.CheckSyukkoIDExistence(int.Parse(txbSyukkoID.Text.Trim())))
                {
                    MessageBox.Show("出庫IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSyukkoID.Focus();
                    return false;
                }

                T_Syukko syukko = SyukkoDataAccess.GetIDSyukkoData(int.Parse(txbSyukkoID.Text.Trim()));

                //注文IDの非表示チェック
                if (syukko.SyFlag == 1)
                {
                    MessageBox.Show("出庫IDは非表示にされています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSyukkoID.Focus();
                    return false;
                }
                //受注IDの確定チェック
                if (syukko.SyStateFlag == 1)
                {
                    MessageBox.Show("出庫IDはすでに確定しています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSyukkoID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("出庫IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSyukkoID.Focus();
                return false;
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateArrivalAtRegistration()
        //引　数   ：出庫情報
        //戻り値   ：入荷登録情報
        //機　能   ：入荷登録データのセット
        ///////////////////////////////
        private T_Arrival GenerateArrivalAtRegistration(T_Syukko Syukko)
        {
            return new T_Arrival
            {
                ArID = arrivalDataAccess.ArrivalNum() + 1,
                SoID = Syukko.SoID,
                ClID = Syukko.ClID,
                OrID = Syukko.OrID,
                ArStateFlag = 0,
                ArFlag = 0
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateArrivalDetailAtRegistration()
        //引　数   ：入荷詳細情報
        //戻り値   ：入荷詳細登録情報
        //機　能   ：入荷詳細登録データのセット
        ///////////////////////////////
        private T_ArrivalDetail GenerateArrivalDetailAtRegistration(T_SyukkoDetail SyukkoDetail, T_Syukko Syukko)
        {
            return new T_ArrivalDetail
            {
                ArDetailID = SyukkoDetail.SyDetailID,
                ArID = arrivalDataAccess.GetIDOrderData(Syukko.OrID).ArID,
                PrID = SyukkoDetail.PrID,
                ArQuantity = SyukkoDetail.SyQuantity
            };
        }

        ///////////////////////////////
        //メソッド名：ProdactDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：商品情報検索の実行
        ///////////////////////////////
        private void ProdactDataSelect()
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

            //商品登録フォームの透明化
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
            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "受注管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbSyukkoID.Text.Trim()),
                OpSetTime = DateTime.Now,
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
            //検索の部分で受注IDに出庫IDを入れているので修正してほしい 
            //検索条件の存在確認
            if (String.IsNullOrEmpty(txbSyukkoID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbOrderID.Text.Trim()) && String.IsNullOrEmpty(txbClientID.Text.Trim()) && String.IsNullOrEmpty(txbEmployeeID.Text.Trim()) && dtpSyukkoDate.Checked == false && cmbConfirm.SelectedIndex == -1)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSyukkoID.Focus();
                return false;
            }

            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbOrderID.Text.Trim()))
            {
                // 顧客IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbOrderID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (!orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
            }

            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbSyukkoID.Text.Trim()))
            {
                // 顧客IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSyukkoID.Text.Trim()))
                {
                    MessageBox.Show("出庫IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSyukkoID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (!SyukkoDataAccess.CheckSyukkoIDExistence(int.Parse(txbSyukkoID.Text.Trim())))
                {
                    MessageBox.Show("出庫IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSyukkoID.Focus();
                    return false;
                }
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
                //注文IDの重複チェック
                if (!clientDataAccess.CheckClientIDExistence(int.Parse(txbClientID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientID.Focus();
                    return false;
                }
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
                if (!employeeDataAccess.CheckEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("社員IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbSyukkoID.Text = string.Empty;
            txbClientID.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            txbEmployeeName.Text = string.Empty;
            txbOrderID.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
            txbHidden.Text = string.Empty;
            txbEmployeeID.Text = string.Empty;
        }

        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の商品リスト作成
            List<T_Syukko> listViewSyukko = SetListSyukko();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewSyukko);

        }

        ///////////////////////////////
        //メソッド名：SetListSyukko()
        //引　数   ：なし
        //戻り値   ：表示用出庫データ
        //機　能   ：表示用出庫データの準備
        ///////////////////////////////
        private List<T_Syukko> SetListSyukko()
        {
            //商品のデータを全取得
            listAllSyukko = SyukkoDataAccess.GetSyukkoData();

            //表示用の顧客リスト作成
            List<T_Syukko> listViewSyukko = new List<T_Syukko>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewSyukko = listsyukko;
            }
            else
            {
                //全データをとってくる
                listViewSyukko = listAllSyukko;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の商品データの取得
                listViewSyukko = SyukkoDataAccess.GetSyukkotDspData(listViewSyukko);
            }
            else
            {
                // 管理Flgが非表示の商品データの取得
                listViewSyukko = SyukkoDataAccess.GetSyukkoNotDspData(listViewSyukko);
            }

            return listViewSyukko;
        }


        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：商品情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strSyukkoID = txbSyukkoID.Text.Trim();
            int intSyukkoID = 0;

            if (!String.IsNullOrEmpty(strSyukkoID))
            {
                intSyukkoID = int.Parse(strSyukkoID);
            }

            string strOrderID = txbOrderID.Text.Trim();
            int intOrderID = 0;

            if (!String.IsNullOrEmpty(strOrderID))
            {
                intOrderID = int.Parse(strOrderID);
            }

            string strClientID = txbClientID.Text.Trim();
            int intClientID = 0;

            if (!String.IsNullOrEmpty(strClientID))
            {
                intClientID = int.Parse(strClientID);
            }

            string strEmployeeID = txbEmployeeID.Text.Trim();
            int intEmployeeID = 0;

            if (!String.IsNullOrEmpty(strEmployeeID))
            {
                intEmployeeID = int.Parse(strEmployeeID);
            }
            DateTime? dateSyukko = null;

            if (dtpSyukkoDate.Checked)
            {
                dateSyukko = dtpSyukkoDate.Value.Date;
            }
            // 検索条件のセット
            T_Syukko selectCondition = new T_Syukko()
            {
                SyID = intSyukkoID,
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                OrID = intOrderID,
                ClID = intClientID,
                EmID = intEmployeeID,
                SyDate = dateSyukko,
                SyStateFlag = cmbConfirm.SelectedIndex

                //テキストボックス = txbxxxxxx.Text.Trim()
            };

            if (searchFlg)
            {
                // 商品データのAnd抽出
                listsyukko = SyukkoDataAccess.GetAndSyukkoData(selectCondition);
            }
            else
            {
                // 商品データのOr抽出
                listsyukko = SyukkoDataAccess.GetOrSyukkoData(selectCondition);
            }
        }

        ///////////////////////////////
        //メソッド名：ProdactSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：商品情報検索の実行
        ///////////////////////////////
        private void ProdactSearchButtonClick(bool searchFlg)
        {
            // 出庫情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listsyukko.Count;

            txbNumPage.Text = "1";

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {
            //営業所名のデータを取得
            listSalesOfficeID = SalesOfficeDataAccess.GetSalesOfficeDspData();

            dictionarySalesOffice = new Dictionary<int, string> { };

            foreach (var item in listSalesOfficeID)
            {
                dictionarySalesOffice.Add(item.SoID, item.SoName);
            }

            //社員名のデータを取得
            listEmployee = employeeDataAccess.GetEmployeeDspData();

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listEmployee)
            {
                dictionaryEmployee.Add(item.EmID, item.EmName);
            }

            //顧客名のデータを取得
            listClient = clientDataAccess.GetClientDspData();

            dictionaryClient = new Dictionary<int, string> { };

            foreach (var item in listClient)
            {
                dictionaryClient.Add(item.ClID.Value, item.ClName);
            }

            listProdact = prodactDataAccess.GetProdactDspData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listProdact)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
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
            dgvSyukko.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvSyukko.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvSyukko.AllowUserToResizeColumns = false;
            dgvSyukko.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvSyukko.MultiSelect = false;
            //セルの編集ができないように
            dgvSyukko.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvSyukko.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvSyukko.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvSyukko.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvSyukko.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSyukko.Columns.Add("SyID", "出庫ID");
            dgvSyukko.Columns.Add("EmID", "社員名");
            dgvSyukko.Columns.Add("ClID", "顧客名");
            dgvSyukko.Columns.Add("SoID", "営業所名");
            dgvSyukko.Columns.Add("OrID", "受注ID");
            dgvSyukko.Columns.Add("SyDate", "出庫年月日");
            dgvSyukko.Columns.Add("SyStateFlag", "出庫状態フラグ");
            dgvSyukko.Columns.Add("SyFlag", "出庫管理フラグ");
            dgvSyukko.Columns.Add("SyHidden", "非表示理由");

            dgvSyukko.Columns["SyID"].Width = 100;
            dgvSyukko.Columns["EmID"].Width = 110;
            dgvSyukko.Columns["ClID"].Width = 110;
            dgvSyukko.Columns["SoID"].Width = 160;
            dgvSyukko.Columns["OrID"].Width = 110;
            dgvSyukko.Columns["SyDate"].Width = 150;
            dgvSyukko.Columns["SyStateFlag"].Width = 100;
            dgvSyukko.Columns["SyFlag"].Width = 100;
            dgvSyukko.Columns["SyHidden"].Width = 163;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvSyukko.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvSyukkoDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvSyukkoDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvSyukkoDetail.AllowUserToResizeColumns = false;
            dgvSyukkoDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvSyukkoDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvSyukkoDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvSyukkoDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvSyukkoDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvSyukkoDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvSyukkoDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSyukkoDetail.Columns.Add("SyDetailID", "出庫詳細ID");
            dgvSyukkoDetail.Columns.Add("SyID", "出庫ID");
            dgvSyukkoDetail.Columns.Add("PrID", "商品ID");
            dgvSyukkoDetail.Columns.Add("SyQuantity", "数量");


            dgvSyukkoDetail.Columns["SyDetailID"].Width = 192;
            dgvSyukkoDetail.Columns["SyID"].Width = 192;
            dgvSyukkoDetail.Columns["PrID"].Width = 192;
            dgvSyukkoDetail.Columns["SyQuantity"].Width = 191;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvSyukkoDetail.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Syukko> viewSyukko)
        {
            //中身を消去
            dgvSyukko.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewSyukko.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewSyukko.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvSyukkoに挿入
            foreach (var item in depData)
            {
                string strEmployeeName = "";

                if (item.EmID != null)
                {
                    strEmployeeName = dictionaryEmployee[item.EmID.Value];
                }

                dgvSyukko.Rows.Add(item.SyID, strEmployeeName, dictionaryClient[item.ClID], dictionarySalesOffice[item.SoID], item.OrID, item.SyDate,
                   dictionaryFlag[item.SyStateFlag], dictionaryHidden[item.SyFlag], item.SyHidden);
            }

            //dgvSyukkotをリフレッシュ
            dgvSyukko.Refresh();

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

        private void btnNext_Click(object sender, EventArgs e)
         {
            txbNumPage.Text = (int.Parse(txbNumPage.Text.Trim()) + 1).ToString();

            GetDataGridView();
        }
        
        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<T_Syukko> viewSyukko = SetListSyukko();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewSyukko.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

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

        ///////////////////////////////
        //メソッド名：SetDataDetailGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：詳細データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataDetailGridView(int intSyukkoID)
        {
            dgvSyukkoDetail.Rows.Clear();

            listAllSyukkoDetail = SyukkoDetailDataAccess.GetSyukkoDetailIDData(intSyukkoID);

            //1行ずつdgvClientに挿入
            foreach (var item in listAllSyukkoDetail)
            {
                dgvSyukkoDetail.Rows.Add(item.SyDetailID, item.SyID, dictionaryProdact[item.PrID], item.SyQuantity);
            }

            //dgvClientをリフレッシュ
            dgvSyukkoDetail.Refresh();
        }

        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            var syukkoDate = dgvSyukko[5, dgvSyukko.CurrentCellAddress.Y].Value;

            if (syukkoDate != null)
            {
                dtpSyukkoDate.Text = syukkoDate.ToString();
            }

            //データグリッドビューに乗っている情報をGUIに反映
            txbSyukkoID.Text = dgvSyukko[0, dgvSyukko.CurrentCellAddress.Y].Value.ToString();
            txbEmployeeID.Text = dictionaryEmployee.FirstOrDefault(x => x.Value == dgvSyukko[1, dgvSyukko.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            cmbSalesOfficeID.SelectedIndex = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvSyukko[3, dgvSyukko.CurrentCellAddress.Y].Value.ToString()).Key - 1;
            txbClientID.Text = dictionaryClient.FirstOrDefault(x => x.Value == dgvSyukko[2, dgvSyukko.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            txbOrderID.Text = dgvSyukko[4, dgvSyukko.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvSyukko[7, dgvSyukko.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvSyukko[8, dgvSyukko.CurrentCellAddress.Y]?.Value?.ToString();
            cmbConfirm.SelectedIndex = dictionaryFlag.FirstOrDefault(x => x.Value == dgvSyukko[6, dgvSyukko.CurrentCellAddress.Y].Value.ToString()).Key;
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
                txbClientName.Text = "顧客IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Client = listClient.Single(x => x.ClID == intClientID);

            txbClientName.Text = Client.ClName;
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
                FileName = "https://docs.google.com/document/d/1MfMtaYTJYmbGbq3IKHSwdryVny-aQX0B",
                UseShellExecute = true
            });
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                txbEmployeeID.Enabled = true;
                txbClientID.Enabled = true;
                txbOrderID.Enabled = true;
                cmbSalesOfficeID.Enabled = true;
                dtpSyukkoDate.Enabled = true;
                cmbConfirm.Enabled = true;
                txbHidden.Enabled = false;
                cmbHidden.Enabled = false;
            }

            if (rdbConfirm.Checked)
            {
                txbEmployeeID.Enabled = false;
                txbClientID.Enabled = false;
                txbOrderID.Enabled = false;
                cmbSalesOfficeID.Enabled = false;
                dtpSyukkoDate.Enabled = false;
                cmbConfirm.Enabled = false;
                txbHidden.Enabled = false;
                cmbHidden.Enabled = false;
            }

            if (rdbHidden.Checked)
            {
                txbEmployeeID.Enabled = false;
                txbClientID.Enabled = false;
                txbOrderID.Enabled = false;
                cmbSalesOfficeID.Enabled = false;
                dtpSyukkoDate.Enabled = false;
                cmbConfirm.Enabled = false;
                txbHidden.Enabled = true;
                cmbHidden.Enabled = true;
            }
        }

        private void btnPagesize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            GetDataGridView();
        }
    }
}
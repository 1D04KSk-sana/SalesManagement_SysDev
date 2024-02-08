using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_ButuryuChumon : Form
    {
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース在庫テーブルアクセス用クラスのインスタンス化
        StockDataAccess stockDataAccess = new StockDataAccess();
        //データベース出庫テーブルアクセス用クラスのインスタンス化
        SyukkoDataAccess syukkoDataAccess = new SyukkoDataAccess();
        //データベース出庫詳細テーブルアクセス用クラスのインスタンス化
        SyukkoDetailDataAccess syukkoDetailDataAccess = new SyukkoDetailDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        //データベース発注詳細テーブルアクセス用クラスのインスタンス化
        ChumonDetailDataAccess ChumonDetailDataAccess = new ChumonDetailDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDetailDataAccess orderDetailDataAccess = new OrderDetailDataAccess();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //データグリッドビュー用の顧客データ
        private static List<T_ChumonDetail> listChumonDetail = new List<T_ChumonDetail>();
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
        //データグリッドビュー用の顧客データ
        private static List<T_Chumon> listChumon = new List<T_Chumon>();
        //データグリッドビュー用の顧客データ
        private static List<T_Chumon> listAllChumon = new List<T_Chumon>();
        //データグリッドビュー用の全顧客データ
        private static List<T_Order> listAllOrder = new List<T_Order>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        //DataGridView用に使用する営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;
        //DataGridView用に使用する顧客のDictionary
        private Dictionary<int, string> dictionaryClient;
        //DataGridView用に使用する社員のDictionary
        private Dictionary<int, string> dictionaryEmployee;
        //DataGridView用に使用する商品のDictionary
        private Dictionary<int, string> dictionaryProdact;

        //データグリッドビュー用の営業所データリスト
        private static List<M_SalesOffice> listDGVSalesOfficeID = new List<M_SalesOffice>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Client> listDGVClientID = new List<M_Client>();

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

        public F_ButuryuChumon()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ChumonDataSelect();
            }

            //確定ラヂオボタンがチェックされているとき
            if (rdbConfirm.Checked)
            {
                ChumonDataConfirm();
            }

            //非表示ラヂオボタンがチェックされているとき
            if (rdbHidden.Checked)
            {
                ChumonDataHidden();
            }
        }

        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ChumonSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ChumonSearchButtonClick(false);
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }


        ///////////////////////////////
        //メソッド名：ChumonDataConfirm()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：受注情報確定の実行
        ///////////////////////////////
        private void ChumonDataConfirm()
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
            var cmfChumon = GenerateDataAtConfirm();

            // 受注情報更新
            ConfirmChumon(cmfChumon);
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
            if (!String.IsNullOrEmpty(txbChumonID.Text.Trim()))
            {
                // 受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbChumonID.Text.Trim()))
                {
                    MessageBox.Show("注文IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (!orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("注文IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }

                T_Chumon chumon = chumonDataAccess.GetIDChumonData(int.Parse(txbChumonID.Text.Trim()));

                //注文IDの非表示チェック
                if (chumon.ChFlag == 1)
                {
                    MessageBox.Show("注文IDは非表示にされています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }
                //受注IDの確定チェック
                if (chumon.ChStateFlag == 1)
                {
                    MessageBox.Show("注文IDはすでに確定しています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }

                //在庫確認
                List<T_ChumonDetail> listChumonDetail = ChumonDetailDataAccess.GetChumonDetailIDData(chumon.ChID);

                foreach (var item in listChumonDetail)
                {
                    T_Stock Stock = stockDataAccess.GetStockProdactIDData(item.PrID);

                    if (item.ChQuantity > Stock.StQuantity)
                    {
                        MessageBox.Show(dictionaryProdact[item.PrID] + "の在庫数が足りません\n発注してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbChumonID.Focus();
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("注文IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbChumonID.Focus();
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
        private T_Chumon GenerateDataAtConfirm()
        {
            return new T_Chumon
            {
                ChID = int.Parse(txbChumonID.Text.Trim()),
                EmID = F_Login.intEmployeeID,
                ChStateFlag = 1,
            };
        }
        ///////////////////////////////
        //メソッド名：ChumonDataHidden()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：受注情報更新の実行
        ///////////////////////////////
        private void ChumonDataHidden()
        {
            //テキストボックス等の入力チェック
            if (!GetValidDataAtHidden())
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

            // 受注情報作成
            var hidChumon = GenerateDataAtHidden();

            // 受注情報更新
            HiddenChumon(hidChumon);
        }
        ///////////////////////////////
        //メソッド名：HiddenChumon()
        //引　数   ：受注情報
        //戻り値   ：なし
        //機　能   ：受注情報の更新
        ///////////////////////////////
        private void HiddenChumon(T_Chumon hidChumon)
        {
            // 受注情報の更新
            bool flg = chumonDataAccess.UpdateChumonData(hidChumon);

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
        //メソッド名：GetValidDataAtHidden()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：更新入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataAtHidden()
        {
            //注文IDの適否
            if (!String.IsNullOrEmpty(txbChumonID.Text.Trim()))
            {
                // 受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbChumonID.Text.Trim()))
                {
                    MessageBox.Show("注文IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (!chumonDataAccess.CheckChumonIDExistence(int.Parse(txbChumonID.Text.Trim())))
                {
                    MessageBox.Show("注文IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("注文IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbChumonID.Focus();
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
        //メソッド名：GenerateDataAtHidden()
        //引　数   ：なし
        //戻り値   ：受注更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private T_Chumon GenerateDataAtHidden()
        {
            return new T_Chumon
            {
                ChID = int.Parse(txbChumonID.Text.Trim()),
                ChFlag = cmbHidden.SelectedIndex,
                ChHidden = txbHidden.Text.Trim(),
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
                FormName = "注文管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbChumonID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：ConfirmChumon()
        //引　数   ：受注情報
        //戻り値   ：なし
        //機　能   ：受注情報の確定
        ///////////////////////////////
        private void ConfirmChumon(T_Chumon cfmChumon)
        {
            // 受注情報の更新
            bool flg = chumonDataAccess.ConfirmChumonData(cfmChumon);

            if (flg == true)
            {
                MessageBox.Show("確定しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("確定に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //在庫更新
            List<T_ChumonDetail> listChumonDetail = ChumonDetailDataAccess.GetChumonDetailIDData(cfmChumon.ChID);

            List<bool> flgStocklist = new List<bool>();
            bool flgStock = true;

            foreach (var item in listChumonDetail)
            {
                flgStocklist.Add(stockDataAccess.UpdateChumonStockQuantityData(item));
            }

            foreach (var item in flgStocklist)
            {
                if (!item)
                {
                    flgStock = false;
                }
            }

            if (flgStock)
            {
                MessageBox.Show("在庫数を更新しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("在庫数の更新に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //出庫登録
            T_Chumon Chumon = chumonDataAccess.GetIDChumonData(cfmChumon.ChID);

            T_Syukko Syukko = GenerateSyukkoAtRegistration(Chumon);

            bool flgSyukko = syukkoDataAccess.AddSyukkoData(Syukko);

            if (flgSyukko == true)
            {
                MessageBox.Show("出庫管理にデータを送信ました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("出庫管理へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //出庫詳細登録
            List<bool> flgChumonlist = new List<bool>();
            bool flgChumon = true;

            foreach (var item in listChumonDetail)
            {
                T_SyukkoDetail SyukkoDetail = GenerateSyukkoDetailAtRegistration(item, Chumon);

                flgChumonlist.Add(syukkoDetailDataAccess.AddSyukkoDetailData(SyukkoDetail));
            }

            foreach (var item in flgChumonlist)
            {
                if (!item)
                {
                    flgChumon = false;
                }
            }

            if (flgChumon)
            {
                MessageBox.Show("出庫詳細へデータを送信しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("出庫詳細へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //テキストボックス等のクリア
            ClearImput();

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GenerateSyukkoAtRegistration()
        //引　数   ：注文情報
        //戻り値   ：出庫登録情報
        //機　能   ：出庫登録データのセット
        ///////////////////////////////
        private T_Syukko GenerateSyukkoAtRegistration(T_Chumon Chumon)
        {
            return new T_Syukko
            {
                SyID = syukkoDataAccess.SyukkoNum() + 1,
                SoID = Chumon.SoID,
                ClID = Chumon.ClID,
                OrID = Chumon.OrID,
                SyStateFlag = 0,
                SyFlag = 0
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateSyukkoDetailAtRegistration()
        //引　数   ：出庫詳細情報
        //戻り値   ：出庫詳細登録情報
        //機　能   ：出庫詳細登録データのセット
        ///////////////////////////////
        private T_SyukkoDetail GenerateSyukkoDetailAtRegistration(T_ChumonDetail ChumonDetail, T_Chumon Chumon)
        {
            return new T_SyukkoDetail
            {
                SyDetailID = ChumonDetail.ChDetailID,
                SyID = syukkoDataAccess.GetIDOrderData(Chumon.OrID).SyID,
                PrID = ChumonDetail.PrID,
                SyQuantity = ChumonDetail.ChQuantity
            };
        }

        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールのクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbChumonID.Text = string.Empty;
            txbOrderID.Text = string.Empty;
            txbClientID.Text = string.Empty;
            txbClientName.Text = string.Empty;
            txbEmployeeID.Text = string.Empty;
            txbEmployeeName.Text = string.Empty;
            cmbConfirm.SelectedIndex = -1;
            cmbSalesOfficeID.SelectedIndex = -1;
            cmbHidden.SelectedIndex = -1;
            txbHidden.Text = string.Empty;
        }

        ///////////////////////////////
        //メソッド名：ChumonDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void ChumonDataSelect()
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
        //メソッド名：ChumonSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：受注情報検索の実行
        ///////////////////////////////
        private void ChumonSearchButtonClick(bool searchFlg)
        {
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listChumon.Count;

            txbNumPage.Text = "1";

            // 受注抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：受注情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strOrderID = txbOrderID.Text.Trim();
            int intOrderID = 0;

            if (!String.IsNullOrEmpty(strOrderID))
            {
                intOrderID = int.Parse(strOrderID);
            }

            string strChumonID = txbChumonID.Text.Trim();
            int intChumonID = 0;

            if (!String.IsNullOrEmpty(strChumonID))
            {
                intChumonID = int.Parse(strChumonID);
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

            DateTime? dateChumon = null;

            if (dtpChumonDate.Checked)
            {
                dateChumon = dtpChumonDate.Value.Date;
            }

            // 検索条件のセット
            T_Chumon selectCondition = new T_Chumon()
            {
                ChID = intChumonID,
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                ClID = intClientID,
                OrID = intOrderID, 
                EmID = intEmployeeID,
                ChDate = dateChumon,
                ChStateFlag = cmbConfirm.SelectedIndex
            };

            if (searchFlg)
            {
                // 顧客データのAnd抽出
                listChumon = chumonDataAccess.GetAndChumonData(selectCondition);
            }
            else
            {
                // 顧客データのOr抽出
                listChumon = chumonDataAccess.GetOrChumonData(selectCondition);
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
            if (txbPageSize.Text.Trim() == string.Empty)
            {
                txbPageSize.Text = "1";
            }

            //表示用の受注リスト作成
            List<T_Chumon> listViewChumon = SetListChumon();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewChumon);

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
            dgvChumon.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvChumon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvChumon.AllowUserToResizeColumns = false;
            dgvChumon.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvChumon.MultiSelect = false;
            //セルの編集ができないように
            dgvChumon.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvChumon.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvChumon.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvChumon.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvChumon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvChumon.Columns.Add("ChID", "注文ID");
            dgvChumon.Columns.Add("SoID", "営業所名");
            dgvChumon.Columns.Add("OrID", "受注ID");
            dgvChumon.Columns.Add("ChDate", "注文年月日");
            dgvChumon.Columns.Add("ClName", "顧客名");
            dgvChumon.Columns.Add("EmName", "社員名");
            dgvChumon.Columns.Add("ChStateFlag", "未確定/確定");
            dgvChumon.Columns.Add("ChFlag", "表示/非表示");
            dgvChumon.Columns.Add("ChHidden", "非表示理由");

            dgvChumon.Columns["ChID"].Width = 100;
            dgvChumon.Columns["SoID"].Width = 150;
            dgvChumon.Columns["OrID"].Width = 100;
            dgvChumon.Columns["ChDate"].Width = 150;
            dgvChumon.Columns["ClName"].Width = 150;
            dgvChumon.Columns["EmName"].Width = 150;
            dgvChumon.Columns["ChStateFlag"].Width = 200;
            dgvChumon.Columns["ChFlag"].Width = 200;
            dgvChumon.Columns["ChHidden"].Width = 200;

            dgvChumon.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dgvChumon.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvChumon.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvChumonDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvChumonDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvChumonDetail.AllowUserToResizeColumns = false;
            dgvChumonDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvChumonDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvChumonDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvChumonDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvChumonDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvChumonDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvChumonDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvChumonDetail.Columns.Add("ChID", "注文ID");
            dgvChumonDetail.Columns.Add("ChDetailID", "注文詳細ID");
            dgvChumonDetail.Columns.Add("PrID", "商品ID");
            dgvChumonDetail.Columns.Add("OrQuantity", "数量");

            dgvChumonDetail.Columns["ChID"].Width = 150;
            dgvChumonDetail.Columns["ChDetailID"].Width = 150;
            dgvChumonDetail.Columns["PrID"].Width = 150;
            dgvChumonDetail.Columns["OrQuantity"].Width = 300;

            dgvChumonDetail.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dgvChumonDetail.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvChumonDetail.Columns)
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
        private void SetDataGridView(List<T_Chumon> viewChumon)
        {
            //中身を消去
            dgvChumon.Rows.Clear();
            dgvChumonDetail.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewChumon.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewChumon.Skip(pageSize * pageNum).Take(pageSize).ToList();

            depData.Reverse();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                string strEmployeeName = "";

                if (item.EmID != null)
                {
                    strEmployeeName = dictionaryEmployee[item.EmID.Value];
                }

                dgvChumon.Rows.Add(item.ChID, dictionarySalesOffice[item.SoID], item.OrID,item.ChDate, dictionaryClient[item.ClID], strEmployeeName, dictionaryConfirm[item.ChStateFlag], dictionaryHidden[item.ChFlag], item.ChHidden);
            }

            //dgvClientをリフレッシュ
            dgvChumon.Refresh();

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
        //メソッド名：SetListChumon()
        //引　数   ：なし
        //戻り値   ：表示用受注データ
        //機　能   ：表示用受注データの準備
        ///////////////////////////////
        private List<T_Chumon> SetListChumon()
        {
            //受注のデータを全取得
            listAllChumon = chumonDataAccess.GetChumonData();

            //表示用の受注リスト作成
            List<T_Chumon> listViewChumon = new List<T_Chumon>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewChumon = listChumon;
            }
            else
            {
                //全データをとってくる
                listViewChumon = listAllChumon;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewChumon = chumonDataAccess.GetChumonDspData(listViewChumon);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewChumon = chumonDataAccess.GetChumonNotDspData(listViewChumon);
            }

            return listViewChumon;
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

            //データグリッドビュー用の営業所のデータを取得
            listDGVSalesOfficeID = salesOfficeDataAccess.GetSalesOfficeData();

            dictionarySalesOffice = new Dictionary<int, string> { };

            foreach (var item in listDGVSalesOfficeID)
            {
                dictionarySalesOffice.Add(item.SoID, item.SoName);
            }

            listClient = clientDataAccess.GetClientDspData();

            listDGVClientID = clientDataAccess.GetClientData();

            dictionaryClient = new Dictionary<int, string> { };

            foreach (var item in listDGVClientID)
            {
                dictionaryClient.Add(item.ClID.Value, item.ClName);
            }

            listEmployee = employeeDataAccess.GetEmployeeDspData();

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listEmployee)
            {
                dictionaryEmployee.Add(item.EmID, item.EmName);
            }

            listProdact = prodactDataAccess.GetProdactDspData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listProdact)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
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
            bool cmbflg = false;
            int intSalesOfficeID = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvChumon[1, dgvChumon.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listSalesOffice)
            {
                if (intSalesOfficeID == item.SoID)
                {
                    cmbflg = true;
                }
            }

            if (cmbflg)
            {
                cmbSalesOfficeID.SelectedValue = intSalesOfficeID;
            }
            else
            {
                cmbSalesOfficeID.SelectedIndex = -1;
            }

            bool cmbClientflg = false;
            string strClientID = dictionaryClient.FirstOrDefault(x => x.Value == dgvChumon[4, dgvChumon.CurrentCellAddress.Y].Value.ToString()).Key.ToString();

            foreach (var item in listDGVClientID)
            {
                if (strClientID == item.SoID.ToString())
                {
                    cmbClientflg = true;
                }
            }

            if (cmbClientflg)
            {
                txbClientID.Text = strClientID;
            }
            else
            {
                txbClientID.Text = string.Empty;
            }

            //データグリッドビューに乗っている情報をGUIに反映
            txbChumonID.Text = dgvChumon[0, dgvChumon.CurrentCellAddress.Y].Value.ToString();
            txbOrderID.Text = dgvChumon[2, dgvChumon.CurrentCellAddress.Y].Value.ToString();
            dtpChumonDate.Text = dgvChumon[3, dgvChumon.CurrentCellAddress.Y].Value.ToString();
            txbEmployeeID.Text = dictionaryEmployee.FirstOrDefault(x => x.Value == dgvChumon[5, dgvChumon.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            cmbConfirm.SelectedIndex = dictionaryConfirm.FirstOrDefault(x => x.Value == dgvChumon[6, dgvChumon.CurrentCellAddress.Y].Value.ToString()).Key;
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvChumon[7, dgvChumon.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvChumon[8, dgvChumon.CurrentCellAddress.Y]?.Value?.ToString();
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
             //txbChumonDetailID.Text = dgvChumonDetail[1, dgvChumonDetail.CurrentCellAddress.Y].Value.ToString();
             //txbProductID.Text = dictionaryProdact.FirstOrDefault(x => x.Value == dgvChumonDetail[2, dgvChumonDetail.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            // txbChumonQuantity.Text = dgvChumonDetail[3, dgvChumonDetail.CurrentCellAddress.Y].Value.ToString();
        }

        ///////////////////////////////
        //メソッド名：SetDataDetailGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：詳細データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataDetailGridView(int intChumonID)
        {
            dgvChumonDetail.Rows.Clear();

            listChumonDetail = ChumonDetailDataAccess.GetChumonDetailIDData(intChumonID);

            //1行ずつdgvClientに挿入
            foreach (var item in listChumonDetail)
            {
                dgvChumonDetail.Rows.Add(item.ChID, item.ChDetailID, dictionaryProdact[item.PrID], item.ChQuantity);
            }

            //dgvClientをリフレッシュ
            dgvChumonDetail.Refresh();
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
            if (String.IsNullOrEmpty(txbChumonID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1  && String.IsNullOrEmpty(txbClientID.Text.Trim()) && String.IsNullOrEmpty(txbEmployeeID.Text.Trim()) && String.IsNullOrEmpty(txbOrderID.Text.Trim())&& dtpChumonDate.Checked==false && cmbConfirm.SelectedIndex == -1)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbChumonID.Focus();
                return false;
            }

            // 注文IDの適否
            if (!String.IsNullOrEmpty(txbChumonID.Text.Trim()))
            {
                // 注文IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbChumonID.Text.Trim()))
                {
                    MessageBox.Show("注文IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }
                //注文IDの重複チェック
                if (!chumonDataAccess.CheckChumonIDExistence(int.Parse(txbChumonID.Text.Trim())))
                {
                    MessageBox.Show("注文IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbChumonID.Focus();
                    return false;
                }
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
                //受注IDの重複チェック
                if (!orderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
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

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void F_ButuryuChumon_Load(object sender, EventArgs e)
        {
            rdbHidden.Checked = true;

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

        private void dgvChumon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvChumon.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();

            SetDataDetailGridView(int.Parse(dgvChumon[0, dgvChumon.CurrentCellAddress.Y].Value.ToString()));
        }

        private void dgvChumonDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                //クリックされたDataGridViewがヘッダーのとき⇒何もしない
                if (dgvChumonDetail.SelectedCells.Count == 0)
                {
                    return;
                }

                //選択された行に対してのコントロールの変更
                SelectRowDetailControl();
            }


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbHidden.Checked = true;

            txbNumPage.Text = "1";

            GetDataGridView();
        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            GetDataGridView();
        }

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<T_Chumon> viewOrder = SetListChumon();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewOrder.Count / (double)pageSize);

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

        private void pctHint_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/document/d/1yYyPRRkTIaRLV_tuXHSAWTVoa1-09lZ6",
                UseShellExecute = true
            });
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

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                txbClientID.Enabled = true;
                cmbConfirm.Enabled = true;
                cmbSalesOfficeID.Enabled = true;
                cmbHidden.Enabled = false;
                txbOrderID.Enabled = true;
                txbEmployeeID.Enabled = true;
                txbHidden.Enabled = false;
                dtpChumonDate.Enabled = true;
            }

            if (rdbConfirm.Checked)
            {
                txbClientID.Enabled = false;
                cmbConfirm.Enabled = false;
                cmbSalesOfficeID.Enabled = false;
                cmbHidden.Enabled = false;
                txbOrderID.Enabled = false;
                txbEmployeeID.Enabled = false;
                txbHidden.Enabled = false;
                dtpChumonDate.Enabled = false;
            }

            if (rdbHidden.Checked)
            {
                txbClientID.Enabled = false;
                cmbConfirm.Enabled = false;
                cmbSalesOfficeID.Enabled = false;
                cmbHidden.Enabled = true;
                txbOrderID.Enabled = false;
                txbEmployeeID.Enabled = false;
                txbHidden.Enabled = true;
                dtpChumonDate.Enabled = false;
            }
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
    }
}


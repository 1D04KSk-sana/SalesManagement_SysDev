using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_EigyoShipment : Form
    {
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        ShipmentDataAccess ShipmentDataAccess = new ShipmentDataAccess();
        //データベース注文テーブルアクセス用クラスのインスタンス化
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess OrderDataAccess = new OrderDataAccess();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        ShipmentDetailDataAccess shipmentDetailDataAccess = new ShipmentDetailDataAccess();
        //データベース売上テーブルアクセス用クラスのインスタンス化
        SaleDataAccess saleDataAccess = new SaleDataAccess();
        //データベース売上詳細テーブルアクセス用クラスのインスタンス化
        SaleDetailDataAccess saleDetailDataAccess = new SaleDetailDataAccess();

        //コンボボックス用の顧客データリスト
        private static List<M_Client> listClient = new List<M_Client>();
        //コンボボックス用の社員データリスト
        private static List<M_Employee> listEmployee = new List<M_Employee>();
        //コンボボックス用の社員データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //コンボボックス用の受注データリスト
        private static List<T_Order> listOrder = new List<T_Order>();
        //データグリッドビュー用の全顧客データ
        private static List<T_Shipment> listAllShipment = new List<T_Shipment>();
        //データグリッドビュー用の顧客データ
        private static List<T_Shipment> listShipment = new List<T_Shipment>();
        //データグリッドビュー用の顧客データ
        private static List<T_ShipmentDetail> listShipmentDetail = new List<T_ShipmentDetail>();

        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();

        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        //データグリッドビュー用の営業所データリスト
        private static List<M_SalesOffice> listDGVSalesOfficeID = new List<M_SalesOffice>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Client> listDGVClientID = new List<M_Client>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Employee> listDGVEmployeeID = new List<M_Employee>();

        //DataGridView用に使用する営業所のDictionary
        private Dictionary<int, string> dictionarySalesOffice;
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

        //DataGridView用に使用する確定形式のDictionary
        private Dictionary<int, string> dictionaryConfirm = new Dictionary<int, string>
        {
            { 0, "未確定" },
            { 1, "確定" },
        };

        public F_EigyoShipment()
        {
            InitializeComponent();
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
                FileName = "https://docs.google.com/document/d/14XlxBQncTgkILHJYzptnZhHkBNSxxrWe",
                UseShellExecute = true
            });
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                ShipmentDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ShipmentDataSelect();
            }

            //確定ラヂオボタンがチェックされているとき
            if (rdbConfirm.Checked)
            {
                ShipmentDataConfirm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
            dtpShipmentDate.Checked = false;

            rdbUpdate.Checked = true;

            txbNumPage.Text = "1";

            GetDataGridView();
        }
           
        private void F_EigyoShipment_Load(object sender, EventArgs e)
        {
            rdbUpdate.Checked = true;
            
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

        private void dgvShipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvShipment.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();

            SetDataDetailGridView(int.Parse(dgvShipment[0, dgvShipment.CurrentCellAddress.Y].Value.ToString()));
        }
        
        private void btnPageSize_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            GetDataGridView();
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

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<T_Shipment> viewShipment = SetListShipment();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewShipment.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }

        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ShipmentSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            ShipmentSearchButtonClick(false);
        }

        ///////////////////////////////
        //メソッド名：ShipmentSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：出荷情報検索の実行
        ///////////////////////////////
        private void ShipmentSearchButtonClick(bool searchFlg)
        {
            // 出荷情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listShipment.Count;

            txbNumPage.Text = "1";

            // 出荷抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：出荷情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strShipmentID = txbShipmentID.Text.Trim();
            int intShipmentID = 0;

            if (!String.IsNullOrEmpty(strShipmentID))
            {
                intShipmentID = int.Parse(strShipmentID);
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

            string strOrderID = txbOrderID.Text.Trim();
            int intOrderID = 0;

            if (!String.IsNullOrEmpty(strOrderID))
            {
                intOrderID = int.Parse(strOrderID);
            }
            DateTime? dateShipment = null;

            if (dtpShipmentDate.Checked)
            {
                dateShipment = dtpShipmentDate.Value.Date;
            }

            // 検索条件のセット
            T_Shipment selectCondition = new T_Shipment()
            {
                ShID = intShipmentID,
                EmID = intEmployeeID,
                ClID = intClientID,
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                OrID = intOrderID,
                ShFinishDate = dateShipment,
                ShStateFlag = cmbConfirm.SelectedIndex
            };

            if (searchFlg)
            {
                // 出荷データのAnd抽出
                listShipment = ShipmentDataAccess.GetAndShipmentData(selectCondition);
            }
            else
            {
                // 出荷データのOr抽出
                listShipment = ShipmentDataAccess.GetOrShipmentData(selectCondition);
            }
        }

        ///////////////////////////////
        //メソッド名：ShipmentDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：出荷情報検索の実行
        ///////////////////////////////
        private void ShipmentDataSelect()
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

            //出荷登録フォームの透明化
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
            if (String.IsNullOrEmpty(txbShipmentID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbEmployeeID.Text.Trim()) && String.IsNullOrEmpty(txbClientID.Text.Trim()) && String.IsNullOrEmpty(txbOrderID.Text.Trim())&&dtpShipmentDate.Checked==false)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbShipmentID.Focus();
                return false;
            }

            //出荷IDの適否
            if (!String.IsNullOrEmpty(txbShipmentID.Text.Trim()))
            {
                //出荷IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbShipmentID.Text.Trim()))
                {
                    MessageBox.Show("出荷IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }
                //出荷IDの重複チェック
                if (!ShipmentDataAccess.CheckShipmentIDExistence(int.Parse(txbShipmentID.Text.Trim())))
                {
                    MessageBox.Show("出荷IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
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
                //顧客IDの重複チェック
                if (!clientDataAccess.CheckClientIDExistence(int.Parse(txbClientID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbClientID.Focus();
                    return false;
                }
            }
            //社員IDの適否
            if (!String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                //社員IDの数字チェック
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
                if (!OrderDataAccess.CheckOrderIDExistence(int.Parse(txbOrderID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbOrderID.Focus();
                    return false;
                }
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：ShipmentDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：出荷情報更新の実行
        ///////////////////////////////
        private void ShipmentDataUpdate()
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

            // 出荷情報作成
            var updShipment = GenerateDataAtUpdate();

            // 出荷情報更新
            UpdateShipment(updShipment);
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
            //出荷IDの適否
            if (!String.IsNullOrEmpty(txbShipmentID.Text.Trim()))
            {
                // 出荷IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbShipmentID.Text.Trim()))
                {
                    MessageBox.Show("出荷IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }
                //出荷IDの存在チェック
                if (!ShipmentDataAccess.CheckShipmentIDExistence(int.Parse(txbShipmentID.Text.Trim())))
                {
                    MessageBox.Show("出荷IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("出荷IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbShipmentID.Focus();
                return false;
            }

            //表示選択の適否
            if (cmbShipmentHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示/非表示が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbShipmentHidden.Focus();
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
                FormName = "出荷管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbShipmentID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：受注更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private T_Shipment GenerateDataAtUpdate()
        {
            return new T_Shipment
            {
                ShID = int.Parse(txbShipmentID.Text.Trim()),
                ShFlag = cmbShipmentHidden.SelectedIndex,
                ShHidden = txbShipmentHidden.Text.Trim(),
            };
        }

        ///////////////////////////////
        //メソッド名：UpdateShipment()
        //引　数   ：出荷情報
        //戻り値   ：なし
        //機　能   ：出荷情報の更新
        ///////////////////////////////
        private void UpdateShipment(T_Shipment updShipment)
        {
            // 受注情報の更新
            bool flg = ShipmentDataAccess.UpdateShipmentData(updShipment);

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
        //メソッド名：ShipmentDataConfirm()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：出荷情報確定の実行
        ///////////////////////////////
        private void ShipmentDataConfirm()
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
            var cmfShipment = GenerateDataAtConfirm();

            // 受注情報更新
            ConfirmShipment(cmfShipment);
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
            if (!String.IsNullOrEmpty(txbShipmentID.Text.Trim()))
            {
                // 受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbShipmentID.Text.Trim()))
                {
                    MessageBox.Show("出荷IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (!ShipmentDataAccess.CheckShipmentIDExistence(int.Parse(txbShipmentID.Text.Trim())))
                {
                    MessageBox.Show("出荷IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }

                T_Shipment shipment = ShipmentDataAccess.GetIDShipmentData(int.Parse(txbShipmentID.Text.Trim()));

                //受注IDの確定チェック
                if (shipment.ShStateFlag == 1)
                {
                    MessageBox.Show("出荷IDはすでに確定しています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }
                //受注IDの非表示チェック
                if (shipment.ShFlag == 1)
                {
                    MessageBox.Show("出荷IDは非表示にされています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbShipmentID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("出荷IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbShipmentID.Focus();
                return false;
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtConfirm()
        //引　数   ：なし
        //戻り値   ：出荷確定情報
        //機　能   ：確定データのセット
        ///////////////////////////////
        private T_Shipment GenerateDataAtConfirm()
        {
            return new T_Shipment
            {
                ShID = int.Parse(txbShipmentID.Text.Trim()),
                ShStateFlag = 1,
                EmID = F_Login.intEmployeeID,
                ShFinishDate = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：ConfirmShipment()
        //引　数   ：出荷情報
        //戻り値   ：なし
        //機　能   ：出荷情報の確定
        ///////////////////////////////
        private void ConfirmShipment(T_Shipment cfmShipment)
        {
            // 受注情報の更新
            bool flg = ShipmentDataAccess.ConfirmShipmentData(cfmShipment);

            if (flg == true)
            {
                MessageBox.Show("確定しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("確定に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //注文登録
            T_Shipment Shipment = ShipmentDataAccess.GetIDShipmentData(cfmShipment.ShID);

            T_Chumon Chumon = chumonDataAccess.GetIDOrderData(Shipment.OrID);

            T_Sale Sale = GenerateSaleAtRegistration(Shipment, Chumon);

            bool flgSale = saleDataAccess.AddSaleData(Sale);

            if (flgSale == true)
            {
                MessageBox.Show("売上管理にデータを送信ました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("売上管理へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //注文詳細登録
            List<T_ShipmentDetail> listShipmentDetail = shipmentDetailDataAccess.GetIDShipmentDetailData(cfmShipment.ShID);

            List<bool> flgShipmentlist = new List<bool>();
            bool flgShipment = true;

            foreach (var item in listShipmentDetail)
            {
                T_SaleDetail SaleDetail = GenerateSaleDetailAtRegistration(item, Chumon);

                flgShipmentlist.Add(saleDetailDataAccess.AddSaleDetailData(SaleDetail));
            }

            foreach (var item in flgShipmentlist)
            {
                if (!item)
                {
                    flgShipment = false;
                }
            }

            if (flgShipment)
            {
                MessageBox.Show("売上詳細へデータを送信しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("売上詳細へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //テキストボックス等のクリア
            ClearImput();

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GenerateSaleAtRegistration()
        //引　数   ：売上情報
        //戻り値   ：売上登録情報
        //機　能   ：売上登録データのセット
        ///////////////////////////////
        private T_Sale GenerateSaleAtRegistration(T_Shipment Shipment, T_Chumon Chumon)
        {
            return new T_Sale
            {
                SaID = saleDataAccess.SaleNum() + 1,
                ChID = Chumon.ChID,
                SoID = Shipment.SoID,
                ClID = Shipment.ClID,
                EmID = F_Login.intEmployeeID,
                SaDate = DateTime.Now,
                SaFlag = 0,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateSaleDetailAtRegistration()
        //引　数   ：売上詳細情報
        //戻り値   ：売上詳細登録情報
        //機　能   ：売上詳細登録データのセット
        ///////////////////////////////
        private T_SaleDetail GenerateSaleDetailAtRegistration(T_ShipmentDetail ShipmentDetail, T_Chumon Chumon)
        {
            M_Product Prodact = prodactDataAccess.GetIDProdactData(ShipmentDetail.PrID);

            int intProdactPrice = Prodact.Price;

            return new T_SaleDetail
            {
                Id = 1,
                SaDetailID = ShipmentDetail.ShDetailID,
                SaID = saleDataAccess.GetIDChumonData(Chumon.ChID).SaID,
                PrID = ShipmentDetail.PrID,
                SaQuantity = ShipmentDetail.ShQuantity,
                SaTotalPrice = ShipmentDetail.ShQuantity * intProdactPrice
            };
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
            //顧客のデータを取得
            listClient = clientDataAccess.GetClientDspData();

            listDGVClientID = clientDataAccess.GetClientData();

            dictionaryClient = new Dictionary<int, string> { };

            foreach (var item in listDGVClientID)
            {
                dictionaryClient.Add(item.ClID.Value, item.ClName);
            }
            //社員のデータを取得
            listEmployee = employeeDataAccess.GetEmployeeDspData();

            listDGVEmployeeID = employeeDataAccess.GetEmployeeData();

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listDGVEmployeeID)
            {
                dictionaryEmployee.Add(item.EmID, item.EmName);
            }

            //商品のデータを取得
            listProdact = prodactDataAccess.GetProdactData();

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
            dgvShipment.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvShipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvShipment.AllowUserToResizeColumns = false;
            dgvShipment.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvShipment.MultiSelect = false;
            //セルの編集ができないように
            dgvShipment.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvShipment.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvShipment.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvShipment.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvShipment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvShipment.Columns.Add("ShID", "出荷ID");
            dgvShipment.Columns.Add("SoID", "営業所名");
            dgvShipment.Columns.Add("ClID", "顧客ID");
            dgvShipment.Columns.Add("EmID", "社員名");
            dgvShipment.Columns.Add("OrID", "受注ID");
            dgvShipment.Columns.Add("ShFinishDate", "出荷完了年月日");
            dgvShipment.Columns.Add("ShStateFlag", "出荷状態フラグ");
            dgvShipment.Columns.Add("ShFlag", "出荷管理フラグ");
            dgvShipment.Columns.Add("ShHidden", "非表示理由");

            dgvShipment.Columns["ShID"].Width = 102;
            dgvShipment.Columns["SoID"].Width = 172;
            dgvShipment.Columns["EmID"].Width = 140;
            dgvShipment.Columns["ClID"].Width = 152;
            dgvShipment.Columns["OrID"].Width = 100;
            dgvShipment.Columns["ShFinishDate"].Width = 160;
            dgvShipment.Columns["ShStateFlag"].Width = 170;
            dgvShipment.Columns["ShFlag"].Width = 171;
            dgvShipment.Columns["ShHidden"].Width = 265;

            dgvShipment.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(96)))), ((int)(((byte)(54)))));
            dgvShipment.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvShipment.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvShipmentDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvShipmentDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvShipmentDetail.AllowUserToResizeColumns = false;
            dgvShipmentDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvShipmentDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvShipmentDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvShipmentDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvShipmentDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvShipmentDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvShipmentDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvShipmentDetail.Columns.Add("ShDetailID", "出荷詳細ID");
            dgvShipmentDetail.Columns.Add("ShID", "受注詳細ID");
            dgvShipmentDetail.Columns.Add("PrID", "商品名");
            dgvShipmentDetail.Columns.Add("ShQuantity", "数量");

            dgvShipmentDetail.Columns["ShDetailID"].Width = 174;
            dgvShipmentDetail.Columns["ShID"].Width = 174;
            dgvShipmentDetail.Columns["PrID"].Width = 174;
            dgvShipmentDetail.Columns["ShQuantity"].Width = 175;

            dgvShipmentDetail.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(96)))), ((int)(((byte)(54)))));
            dgvShipmentDetail.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvShipmentDetail.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールのクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbShipmentID.Text = string.Empty;
            txbEmployeeID.Text = string.Empty;
            txbEmployeeName.Text = string.Empty;
            txbOrderID.Text = string.Empty;
            txbClientID.Text = string.Empty;
            txbClientName.Text = string.Empty;
            txbShipmentHidden.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            cmbShipmentHidden.SelectedIndex = -1;
            cmbConfirm.SelectedIndex = -1;
            dtpShipmentDate.Value = DateTime.Now;
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
            List<T_Shipment> listViewShipment = SetListShipment();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewShipment);
        }

        ///////////////////////////////
        //メソッド名：SetListShipment()
        //引　数   ：なし
        //戻り値   ：表示用受注データ
        //機　能   ：表示用受注データの準備
        ///////////////////////////////
        private List<T_Shipment> SetListShipment()
        {
            //受注のデータを全取得
            listAllShipment = ShipmentDataAccess.GetShipmentData();

            //表示用の受注リスト作成
            List<T_Shipment> listViewShipment = new List<T_Shipment>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewShipment = listShipment;
            }
            else
            {
                //全データをとってくる
                listViewShipment = listAllShipment;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewShipment = ShipmentDataAccess.GetShipmentDspData(listViewShipment);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewShipment = ShipmentDataAccess.GetShipmentNotDspData(listViewShipment);
            }

            return listViewShipment;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Shipment> viewShipment)
        {
            viewShipment.Reverse();

            //中身を消去
            dgvShipment.Rows.Clear();
            dgvShipmentDetail.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewShipment.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewShipment.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvShipmentに挿入
            foreach (var item in depData)
            {
                string strEmployeeName = "";

                if (item.EmID != null)
                {
                    strEmployeeName = dictionaryEmployee[item.EmID.Value];
                }

                dgvShipment.Rows.Add(item.ShID, dictionarySalesOffice[item.SoID], dictionaryClient[item.ClID], strEmployeeName, item.OrID, item.ShFinishDate, dictionaryConfirm[item.ShStateFlag], dictionaryHidden[item.ShFlag], item.ShHidden);
            }

            //dgvShipmentをリフレッシュ
            dgvShipment.Refresh();

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
        //メソッド名：SetDataDetailGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：詳細データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataDetailGridView(int intShipmentID)
        {
            dgvShipmentDetail.Rows.Clear();

            listShipmentDetail = shipmentDetailDataAccess.GetIDShipmentDetailData(intShipmentID);

            //1行ずつdgvClientに挿入
            foreach (var item in listShipmentDetail)
            {
                dgvShipmentDetail.Rows.Add(item.ShID, item.ShDetailID, dictionaryProdact[item.PrID], item.ShQuantity);
            }

            //dgvClientをリフレッシュ
            dgvShipmentDetail.Refresh();
        }

        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            var shipmentDate = dgvShipment[5, dgvShipment.CurrentCellAddress.Y].Value;

            if (shipmentDate != null)
            {
                dtpShipmentDate.Text = shipmentDate.ToString();
            }

            bool cmbflg = false;
            int intSalesOfficeID = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvShipment[1, dgvShipment.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listDGVSalesOfficeID)
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
            string strClientID = dictionaryClient.FirstOrDefault(x => x.Value == dgvShipment[2, dgvShipment.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            foreach (var item in listDGVClientID)
            {
                if (strClientID == item.ClID.ToString())
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

            bool cmbEmployeeflg = false;
            string strEmployeeID = dictionaryEmployee.FirstOrDefault(x => x.Value == dgvShipment[3, dgvShipment.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            foreach (var item in listDGVEmployeeID)
            {
                if (strEmployeeID == item.EmID.ToString())
                {
                    cmbEmployeeflg = true;
                }
            }

            if (cmbEmployeeflg)
            {
                txbEmployeeID.Text = strEmployeeID;
            }
            else
            {
                txbEmployeeID.Text = string.Empty;
            }

            //データグリッドビューに乗っている情報をguiに反映
            txbShipmentID.Text = dgvShipment[0, dgvShipment.CurrentCellAddress.Y].Value.ToString();
            txbOrderID.Text = dgvShipment[4, dgvShipment.CurrentCellAddress.Y].Value.ToString();
            cmbConfirm.SelectedIndex = dictionaryConfirm.FirstOrDefault(x => x.Value == dgvShipment[7, dgvShipment.CurrentCellAddress.Y].Value.ToString()).Key;
            cmbShipmentHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvShipment[6, dgvShipment.CurrentCellAddress.Y].Value.ToString()).Key;
            txbShipmentHidden.Text = dgvShipment[8, dgvShipment.CurrentCellAddress.Y]?.Value?.ToString();
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

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                txbShipmentID.Enabled = true;
                txbClientID.Enabled = true;
                txbEmployeeID.Enabled = true;
                cmbSalesOfficeID.Enabled = true;
                txbOrderID.Enabled = true;
                dtpShipmentDate.Enabled = true;
                cmbConfirm.Enabled = true;

                txbShipmentHidden.Enabled = false;
                cmbShipmentHidden.Enabled = false;
            }

            if (rdbUpdate.Checked)
            {
                txbOrderID.Enabled = true;
                txbShipmentHidden.Enabled = true;
                cmbShipmentHidden.Enabled = true;

                txbClientID.Enabled = false;
                txbEmployeeID.Enabled = false;
                txbOrderID.Enabled = false;
                cmbConfirm.Enabled = false;
                cmbSalesOfficeID.Enabled = false;
                dtpShipmentDate.Enabled = false;
            }

            if (rdbConfirm.Checked)
            {
                txbOrderID.Enabled = true;

                cmbConfirm.Enabled = false;
                txbClientID.Enabled = false;
                txbEmployeeID.Enabled = false;
                txbOrderID.Enabled = false;
                cmbSalesOfficeID.Enabled = false;
                dtpShipmentDate.Enabled = false;
                txbShipmentHidden.Enabled = false;
                cmbShipmentHidden.Enabled = false;
            }

        }

        private void txbEmployeeID_TextChanged_1(object sender, EventArgs e)
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

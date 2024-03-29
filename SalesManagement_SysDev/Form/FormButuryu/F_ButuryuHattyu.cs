﻿using System;
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
    public partial class F_ButuryuHattyu : Form
    {
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //データベース在庫テーブルアクセス用クラスのインスタンス化
        StockDataAccess stockDataAccess = new StockDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース売上テーブルアクセス用クラスのインスタンス化
        HattyuDataAccess hattyuDataAccess = new HattyuDataAccess();
        //データグリッドビュー用の全売上データ
        private static List<T_Hattyu> listAllHattyu = new List<T_Hattyu>();
        //データグリッドビュー用の売上データ
        private static List<T_Hattyu> listHattyu = new List<T_Hattyu>();
        //データベース売上詳細テーブルアクセス用クラスのインスタンス化
        HattyuDetailDataAccess hattyuDetailDataAccess = new HattyuDetailDataAccess();
        //コンボボックス用の社員データリスト
        private static List<M_Employee> listEmployee = new List<M_Employee>();
        //データベース社員テーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        //DataGridView用に使用す社員のDictionary
        private Dictionary<int, string> dictionaryEmployee;
        //コンボボックス用の商品データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //DataGridView用に使用す商品のDictionary
        private Dictionary<int, string> dictionaryProdact;
        //コンボボックス用のメーカーデータリスト
        private static List<M_Maker> listMaker = new List<M_Maker>();
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        //DataGridView用に使用すメーカーのDictionary
        private Dictionary<int, string> dictionaryMaker;
        //データグリッドビュー用の発注詳細データ
        private static List<T_HattyuDetail> listHattyuDetail = new List<T_HattyuDetail>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();
        //データベース注文テーブルアクセス用クラスのインスタンス化
        WarehousingDataAccess warehousingDataAccess = new WarehousingDataAccess();
        //データベース入庫詳細テーブルアクセス用クラスのインスタンス化
        WarehousingDetailDataAccess warehousingDetailDataAccess = new WarehousingDetailDataAccess();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        MakerDataAccess MakerDataAccess = new MakerDataAccess();

        //データグリッドビュー用のメーカーデータリスト
        private static List<M_Maker> listDGVMakerID = new List<M_Maker>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Employee> listDGVEmployeeID = new List<M_Employee>();

        //データグリッドビュー用の営業所データリスト
        private static List<M_Product> listDGVProdactID = new List<M_Product>();

        public F_ButuryuHattyu()
        {
            InitializeComponent();
        }
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
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
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

        ///////////////////////////////
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {
            //社員のデータ取得
            listEmployee = employeeDataAccess.GetEmployeeDspData();

            listDGVEmployeeID = employeeDataAccess.GetEmployeeData();

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listDGVEmployeeID)
            {
                dictionaryEmployee.Add(item.EmID, item.EmName);
            }

            //商品のデータを取得
            listProdact = prodactDataAccess.GetProdactDspData();

            listDGVProdactID = prodactDataAccess.GetProdactData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listDGVProdactID)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
            }
            //メーカー名のデータを取得
            listMaker = makerDataAccess.GetMakerDspData();

            //データグリッドビュー用のメーカーのデータを取得
            listDGVMakerID = MakerDataAccess.GetMakerData();

            dictionaryMaker = new Dictionary<int, string> { };

            foreach (var item in listDGVMakerID)
            {
                dictionaryMaker.Add(item.MaID, item.MaName);
            }

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

                intDBID = context.T_Hattyus.Count() + 1;
            }
            else
            {
                intDBID = int.Parse(txbHattyuID.Text.Trim());
            }

            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "発注管理画面",
                OpDone = OperationDone,
                OpDBID = intDBID,
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateWarehousingAtRegistration()
        //引　数   ：入庫情報
        //戻り値   ：入庫登録情報
        //機　能   ：入庫登録データのセット
        ///////////////////////////////
        private T_Warehousing GenerateWarehousingAtRegistration(T_Hattyu Hattyu)
        {
            return new T_Warehousing
            {
                WaID = warehousingDataAccess.WarehousingNum() + 1,
                HaID = Hattyu.HaID,
                EmID = null,
                WaShelfFlag = 0,
                WaFlag = 0,
            };
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();
            dtpHattyuDate.Checked= false;

            rdbRegister.Checked = true;

            txbNumPage.Text = "1";

            GetDataGridView();
        }
        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbHattyuID.Text = string.Empty;
            cmbMakerName.SelectedIndex = -1;
            txbEmployeeID.Text = string.Empty;
            dtpHattyuDate.Value = DateTime.Now;
            cmbHidden.SelectedIndex = -1;
            cmbConfirm.SelectedIndex = -1;
            txbHidden.Text = string.Empty;
        }
        private void btnDetailClear_Click(object sender, EventArgs e)
        {
            ClearImputDetail();
        }

        ///////////////////////////////
        //メソッド名：ClearImputDetail()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールのクリア(Detail)
        ///////////////////////////////
        private void ClearImputDetail()
        {
            txbProductID.Text = string.Empty;
            txbProductName.Text = string.Empty;
            txbHattyuQuantity.Text = string.Empty;
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

            //表示用の発注リスト作成
            List<T_Hattyu> listViewHattyu = SetListHattyu();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewHattyu);
        }

        ///////////////////////////////
        //メソッド名：SetListHattyu()
        //引　数   ：なし
        //戻り値   ：表示用発注データ
        //機　能   ：表示用発注データの準備
        ///////////////////////////////
        private List<T_Hattyu> SetListHattyu()
        {
            //発注のデータを全取得
            listAllHattyu = hattyuDataAccess.GetHattyuData();

            //表示用の発注リスト作成
            List<T_Hattyu> listViewHattyu = new List<T_Hattyu>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewHattyu = listHattyu;
            }
            else
            {
                //全データをとってくる
                listViewHattyu = listAllHattyu;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の発注データの取得
                listViewHattyu = hattyuDataAccess.GetHattyuDspData(listViewHattyu);
            }
            else
            {
                // 管理Flgが非表示の発注データの取得
                listViewHattyu = hattyuDataAccess.GetHattyuNotDspData(listViewHattyu);
            }

            return listViewHattyu;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<T_Hattyu> viewHattyu)
        {
            viewHattyu.Reverse();

            //中身を消去
            dgvHattyu.Rows.Clear();
            dgvHattyuDetail.Rows.Clear();  

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewHattyu.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewHattyu.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvHattyuに挿入
            foreach (var item in depData)
            {
                dgvHattyu.Rows.Add(item.HaID, dictionaryMaker[item.MaID], dictionaryEmployee[item.EmID], item.HaDate, dictionaryHidden[item.HaFlag], dictionaryConfirm[item.WaWarehouseFlag], item.HaHidden);
            }

            //dgvHattyuをリフレッシュ
            dgvHattyu.Refresh();


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

        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                HattyuDataRegister();
            }

            //詳細登録ラヂオボタンがチェックされているとき
            if (rdbDetailRegister.Checked)
            {
                HattyuDetailDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                HattyuDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                HattyuDataSelect();
            }

            //確定ラヂオボタンがチェックされているとき
            if (rdbConfirm.Checked)
            {
                HattyuDataConfirm();
            }

        }
        ///////////////////////////////
        //メソッド名：HattyuDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：発注情報登録の実行
        ///////////////////////////////
        private void HattyuDataRegister()
        {
            //入力情報適否
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

            // 発注情報作成
            var regHattyu = GenerateDataAtRegistration();

            // 発注情報登録
            RegistrationHattyu(regHattyu);
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
            if (cmbMakerName.SelectedIndex == -1)
            {
                MessageBox.Show("メーカー名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMakerName.Focus();
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
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：発注登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private T_Hattyu GenerateDataAtRegistration()
        {
            return new T_Hattyu
            {
                HaID = hattyuDataAccess.HattyuNum() + 1,
                EmID = F_Login.intEmployeeID,
                MaID = cmbMakerName.SelectedIndex + 1,
                HaDate = dtpHattyuDate.Value,
                HaFlag = cmbHidden.SelectedIndex,
                HaHidden = txbHidden.Text.Trim(),
            };
        }
        ///////////////////////////////
        //メソッド名：RegistrationHattyu()
        //引　数   ：発注情報
        //戻り値   ：なし
        //機　能   ：発注データの登録
        ///////////////////////////////
        private void RegistrationHattyu(T_Hattyu regHattyu)
        {
            // 発注情報の登録
            bool flg = hattyuDataAccess.AddHattyuData(regHattyu);

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
            ClearImputDetail();

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：HattyuDetailDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：発注詳細情報登録の実行
        ///////////////////////////////
        private void HattyuDetailDataRegister()
        {
            //入力情報適否
            if (!GetValidDetailDataAtRegistration())
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
            var regOperationLog = GenerateLogAtRegistration(rdbDetailRegister.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 発注詳細情報作成
            var regHattyu = GenerateDetailDataAtRegistration();

            // 発注詳細情報登録
            RegistrationHattyuDetail(regHattyu);
        }
        ///////////////////////////////
        //メソッド名：GetValidDetailDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：詳細登録入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDetailDataAtRegistration()
        {
            //発注IDの適否
            if (!String.IsNullOrEmpty(txbHattyuID.Text.Trim()))
            {
                //発注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbHattyuID.Text.Trim()))
                {
                    MessageBox.Show("発注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }
                //発注IDの存在チェック
                if (!hattyuDataAccess.CheckHattyuIDExistence(int.Parse(txbHattyuID.Text.Trim())))
                {
                    MessageBox.Show("発注IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }

                T_Hattyu Hattyu = hattyuDataAccess.GetIDHattyuData(int.Parse(txbHattyuID.Text.Trim()));

                if (Hattyu.WaWarehouseFlag == 1)
                {
                    MessageBox.Show("発注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("発注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbHattyuID.Focus();
                return false;
            }

            //商品IDの適否
            if (!String.IsNullOrEmpty(txbProductID.Text.Trim()))
            {
                //商品IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbProductID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProductID.Focus();
                    return false;
                }
                //商品IDの存在チェック
                if (!prodactDataAccess.CheckProdactIDExistence(int.Parse(txbProductID.Text.Trim())))
                {
                    MessageBox.Show("商品IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProductID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("商品IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProductID.Focus();
                return false;
            }

            //発注量の適否
            if (!String.IsNullOrEmpty(txbHattyuQuantity.Text.Trim()))
            {
                //発注量の数字チェック
                if (!dataInputCheck.CheckNumeric(txbHattyuQuantity.Text.Trim()))
                {
                    MessageBox.Show("発注量は全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuQuantity.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("発注量が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbHattyuQuantity.Focus();
                return false;
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDetailDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：発注詳細登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private T_HattyuDetail GenerateDetailDataAtRegistration()
        {
            M_Product Prodact = prodactDataAccess.GetIDProdactData(int.Parse(txbProductID.Text.Trim()));

            List<T_HattyuDetail> listIDHattyuDetail = hattyuDetailDataAccess.GetIDHattyuDetailData(int.Parse(txbHattyuID.Text.Trim()));

            int intHattyuIDCount = listIDHattyuDetail.Count();

            return new T_HattyuDetail
            {
                HaDetailID = intHattyuIDCount + 1,
                HaID = int.Parse(txbHattyuID.Text.Trim()),
                PrID = int.Parse(txbProductID.Text.Trim()),
                HaQuantity = int.Parse(txbHattyuQuantity.Text.Trim()),
            };
        }

        ///////////////////////////////
        //メソッド名：RegistrationHattyuDetail()
        //引　数   ：発注詳細情報
        //戻り値   ：なし
        //機　能   ：発注詳細データの登録
        ///////////////////////////////
        private void RegistrationHattyuDetail(T_HattyuDetail regHattyu)
        {
            // 発注情報の登録
            bool flg = hattyuDetailDataAccess.AddHattyuDetailData(regHattyu);

            //登録成功・失敗メッセージ
            if (flg == true)
            {
                MessageBox.Show("データを登録しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // データグリッドビューの表示
            SetDataDetailGridView(int.Parse(txbHattyuID.Text.Trim()));

            // 入力エリアのクリア
            ClearImput();
            ClearImputDetail();
        }
        ///////////////////////////////
        //メソッド名：HattyuDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：発注情報更新の実行
        ///////////////////////////////
        private void HattyuDataUpdate()
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

            // 発注情報作成
            var updHattyu = GenerateDataAtUpdate();

            // 発注情報更新
            UpdateHattyu(updHattyu);
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
            //発注IDの適否
            if (!String.IsNullOrEmpty(txbHattyuID.Text.Trim()))
            {
                // 発注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbHattyuID.Text.Trim()))
                {
                    MessageBox.Show("発注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }
                //発注IDの存在チェック
                if (!hattyuDataAccess.CheckHattyuIDExistence(int.Parse(txbHattyuID.Text.Trim())))
                {
                    MessageBox.Show("発注IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("発注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbHattyuID.Focus();
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
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：発注更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private T_Hattyu GenerateDataAtUpdate()
        {
            return new T_Hattyu
            {
                HaID = int.Parse(txbHattyuID.Text.Trim()),
                HaFlag = cmbHidden.SelectedIndex,
                HaHidden = txbHidden.Text.Trim(),
            };
        }

        ///////////////////////////////
        //メソッド名：UpdateHattyu()
        //引　数   ：発注情報
        //戻り値   ：なし
        //機　能   ：発注情報の更新
        ///////////////////////////////
        private void UpdateHattyu(T_Hattyu updHattyu)
        {
            // 発注情報の更新
            bool flg = hattyuDataAccess.UpdateHattyuData(updHattyu);

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
            ClearImputDetail();

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：HattyuDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：発注情報検索の実行
        ///////////////////////////////
        private void HattyuDataSelect()
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
        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            HattyuSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            HattyuSearchButtonClick(false);
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
            if (String.IsNullOrEmpty(txbHattyuID.Text.Trim()) && cmbMakerName.SelectedIndex == -1 && String.IsNullOrEmpty(txbEmployeeID.Text.Trim())&&dtpHattyuDate.Checked==false && cmbConfirm.SelectedIndex == -1)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbHattyuID.Focus();
                return false;
            }

            //発注IDの適否
            if (!String.IsNullOrEmpty(txbHattyuID.Text.Trim()))
            {
                //発注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbHattyuID.Text.Trim()))
                {
                    MessageBox.Show("発注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }
                //発注IDの重複チェック
                if (!hattyuDataAccess.CheckHattyuIDExistence(int.Parse(txbHattyuID.Text.Trim())))
                {
                    MessageBox.Show("発注IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
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


            return true;
        }

        ///////////////////////////////
        //メソッド名：HattyuSearchButtonClick()
        //引　数   ：searchFlg = AND検索かOR検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：発注情報検索の実行
        ///////////////////////////////
        private void HattyuSearchButtonClick(bool searchFlg)
        {
            // 発注情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listHattyu.Count;

            txbNumPage.Text = "1";

            // 発注抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：発注情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strHattyuID = txbHattyuID.Text.Trim();
            int intHattyuID = 0;

            if (!String.IsNullOrEmpty(strHattyuID))
            {
                intHattyuID = int.Parse(strHattyuID);
            }

            string strEmployeeID = txbEmployeeID.Text.Trim();
            int intEmployeeID = 0;

            if (!String.IsNullOrEmpty(strEmployeeID))
            {
                intEmployeeID = int.Parse(strEmployeeID);
            }

            DateTime? dateSale = null;

            if (dtpHattyuDate.Checked)
            {
                dateSale = dtpHattyuDate.Value.Date;
            }
                // 検索条件のセット
            T_Hattyu selectCondition = new T_Hattyu()
            {
                HaID = intHattyuID,
                MaID = cmbMakerName.SelectedIndex + 1,
                EmID = intEmployeeID,
                HaDate = dateSale,
                WaWarehouseFlag = cmbConfirm.SelectedIndex
            };

            if (searchFlg)
            {
                // 発注データのAnd抽出
                listHattyu = hattyuDataAccess.GetAndHattyuData(selectCondition);
            }
            else
            {
                // 発注データのOr抽出
                listHattyu = hattyuDataAccess.GetOrHattyuData(selectCondition);
            }
        }

        ///////////////////////////////
        //メソッド名：HattyuDataConfirm()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：発注情報確定の実行
        ///////////////////////////////
        private void HattyuDataConfirm()
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

            // 発注情報作成
            var cmfHattyu = GenerateDataAtConfirm();

            // 発注情報更新
            ConfirmHattyu(cmfHattyu);
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
            //発注IDの適否
            if (!String.IsNullOrEmpty(txbHattyuID.Text.Trim()))
            {
                // 発注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbHattyuID.Text.Trim()))
                {
                    MessageBox.Show("発注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }
                //発注IDの存在チェック
                if (!hattyuDataAccess.CheckHattyuIDExistence(int.Parse(txbHattyuID.Text.Trim())))
                {
                    MessageBox.Show("発注IDが存在していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }

                T_Hattyu hattyu = hattyuDataAccess.GetIDHattyuData(int.Parse(txbHattyuID.Text.Trim()));

                //発注IDの非表示チェック
                if (hattyu.HaFlag == 1)
                {
                    MessageBox.Show("発注IDは非表示にされています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }
                //発注IDの確定チェック
                if (hattyu.WaWarehouseFlag == 1)
                {
                    MessageBox.Show("発注IDはすでに確定しています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }

                List<T_HattyuDetail> listHattyuDetail = hattyuDetailDataAccess.GetIDHattyuDetailData(int.Parse(txbHattyuID.Text.Trim()));

                //発注IDの詳細登録チェック
                if (listHattyuDetail.Count() == 0)
                {
                    MessageBox.Show("詳細が登録されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("発注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbHattyuID.Focus();
                return false;
            }



            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtConfirm()
        //引　数   ：なし
        //戻り値   ：発注確定情報
        //機　能   ：確定データのセット
        ///////////////////////////////
        private T_Hattyu GenerateDataAtConfirm()
        {
            return new T_Hattyu
            {
                HaID = int.Parse(txbHattyuID.Text.Trim()),
                WaWarehouseFlag = 1,
            };
        }

        ///////////////////////////////
        //メソッド名：ConfirmHattyu()
        //引　数   ：発注情報
        //戻り値   ：なし
        //機　能   ：発注情報の確定
        ///////////////////////////////
        private void ConfirmHattyu(T_Hattyu cfmHattyu)
        {
            // 発注情報の更新
            bool flg = hattyuDataAccess.ConfirmHattyuData(cfmHattyu);

            if (flg == true)
            {
                MessageBox.Show("確定しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("確定に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //入庫登録
            T_Hattyu Hattyu = hattyuDataAccess.GetIDHattyuData(int.Parse(txbHattyuID.Text.Trim()));

            T_Warehousing Warehousing = GenerateWarehousingAtRegistration(Hattyu);

            bool flgWarehousing = warehousingDataAccess.AddWarehousingData(Warehousing);

            if (flgWarehousing == true)
            {
                MessageBox.Show("入庫管理にデータを送信ました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("入庫管理へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //入庫詳細
            List<T_HattyuDetail> listHattyuDetail = hattyuDetailDataAccess.GetIDHattyuDetailData(int.Parse(txbHattyuID.Text.Trim()));

            List<bool> flgHattyulist = new List<bool>();
            bool flgHattyu = true;

            foreach (var item in listHattyuDetail)
            {
                T_WarehousingDetail WarehousingDetail = GenerateWarehousingDetailAtRegistration(item);

                flgHattyulist.Add(warehousingDetailDataAccess.AddWarehousingDetailData(WarehousingDetail));
            }

            foreach (var item in flgHattyulist)
            {
                if (!item)
                {
                    flgHattyu = false;
                }
            }

            if (flgHattyu)
            {
                MessageBox.Show("入庫詳細へデータを送信しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("入庫詳細へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //テキストボックス等のクリア
            ClearImput();
            ClearImputDetail();

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GenerateWarehousingDetailAtRegistration()
        //引　数   ：入庫詳細情報
        //戻り値   ：入庫詳細登録情報
        //機　能   ：入庫詳細登録データのセット
        ///////////////////////////////
        private T_WarehousingDetail GenerateWarehousingDetailAtRegistration(T_HattyuDetail HattyuDetail)
        {
            return new T_WarehousingDetail
            {
                WaID = HattyuDetail.HaID,
                PrID = HattyuDetail.PrID,
                WaQuantity = HattyuDetail.HaQuantity
            };
        }

        ///////////////////////////////
        //メソッド名：SetDataDetailGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：詳細データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataDetailGridView(int intHattyuID)
        {
            dgvHattyuDetail.Rows.Clear();

            listHattyuDetail = hattyuDetailDataAccess.GetIDHattyuDetailData(intHattyuID);

            //1行ずつdgvClientに挿入
            foreach (var item in listHattyuDetail)
            {
                dgvHattyuDetail.Rows.Add(item.HaID, item.HaDetailID, dictionaryProdact[item.PrID], item.HaQuantity);
            }

            //dgvClientをリフレッシュ
            dgvHattyuDetail.Refresh();
        }


        private void dgvHattyu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvHattyu.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();

            SetDataDetailGridView(int.Parse(dgvHattyu[0, dgvHattyu.CurrentCellAddress.Y].Value.ToString()));

            ClearImputDetail();

        }
        private void dgvHattyuDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvHattyuDetail.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowDetailControl();
        }
        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            bool cmbMakerflg = false;
            int intMakerID = dictionaryMaker.FirstOrDefault(x => x.Value == dgvHattyu[1, dgvHattyu.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listDGVMakerID)
            {
                if (intMakerID == item.MaID)
                {
                    cmbMakerflg = true;
                }
            }

            if (cmbMakerflg)
            {
                cmbMakerName.SelectedValue = intMakerID;
            }
            else
            {
                cmbMakerName.SelectedIndex = -1;
            }

            bool cmbEmployeeflg = false;
            string strEmployeeID = dictionaryEmployee.FirstOrDefault(x => x.Value == dgvHattyu[2, dgvHattyu.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
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

            //データグリッドビューに乗っている情報をGUIに反映
            txbHattyuID.Text = dgvHattyu[0, dgvHattyu.CurrentCellAddress.Y].Value.ToString();
            dtpHattyuDate.Text = dgvHattyu[3, dgvHattyu.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvHattyu[4, dgvHattyu.CurrentCellAddress.Y].Value.ToString()).Key;
            cmbConfirm.SelectedIndex = dictionaryConfirm.FirstOrDefault(x => x.Value == dgvHattyu[5, dgvHattyu.CurrentCellAddress.Y].Value.ToString()).Key;
            txbHidden.Text = dgvHattyu[6, dgvHattyu.CurrentCellAddress.Y]?.Value?.ToString();
        }

        ///////////////////////////////
        //メソッド名：SelectRowDetailControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更(Detail)
        ///////////////////////////////
        private void SelectRowDetailControl()
        {
            bool cmbProdactflg = false;
            string strProdactID = dictionaryProdact.FirstOrDefault(x => x.Value == dgvHattyuDetail[2, dgvHattyuDetail.CurrentCellAddress.Y].Value.ToString()).Key.ToString();
            foreach (var item in listDGVProdactID)
            {
                if (strProdactID == item.PrID.ToString())
                {
                    cmbProdactflg = true;
                }
            }


            if (cmbProdactflg)
            {
                txbProductID.Text = strProdactID;
            }
            else
            {
                txbProductID.Text = string.Empty;
            }

            //データグリッドビューに乗っている情報をGUIに反映
            txbHattyuID.Text = dgvHattyuDetail[0, dgvHattyuDetail.CurrentCellAddress.Y].Value.ToString();
            txbHattyuQuantity.Text = dgvHattyuDetail[3, dgvHattyuDetail.CurrentCellAddress.Y].Value.ToString();
        }

        private void F_ButuryuHattyu_Load(object sender, EventArgs e)
        {
            rdbRegister.Checked = true;

            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            DictionarySet();
            //メーカ名のデータを取得
            listMaker = MakerDataAccess.GetMakerDspData();
            //取得したデータをコンボボックスに挿入
            cmbMakerName.DataSource = listMaker;
            //表示する名前をMaNameに指定
            cmbMakerName.DisplayMember = "MaName";
            //項目の順番をMaIDに指定
            cmbMakerName.ValueMember = "MaID";
            //cmbMakerNameを未選択に
            cmbMakerName.SelectedIndex = -1;

            SetFormDataGridView();

            List<T_Stock> listStock = stockDataAccess.GetStockData();

            List<T_Stock> listStockHattyuten = new List<T_Stock> { };

            foreach (var item in listStock)
            {
                M_Product Prodact = prodactDataAccess.GetIDProdactData(item.PrID);

                if (item.StQuantity <= Prodact.PrSafetyStock)
                {
                    listStockHattyuten.Add(item);
                }
            }

            //1行ずつdgvStockに挿入
            foreach (var item in listStockHattyuten)
            {
                M_Product Prodact = prodactDataAccess.GetIDProdactData(item.PrID);

                dgvStock.Rows.Add(item.PrID, dictionaryProdact[item.PrID], item.StQuantity, Prodact.PrSafetyStock);
            }

            //dgvStockをリフレッシュ
            dgvStock.Refresh();

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
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
            dgvHattyu.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvHattyu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvHattyu.AllowUserToResizeColumns = false;
            dgvHattyu.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvHattyu.MultiSelect = false;
            //セルの編集ができないように
            dgvHattyu.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvHattyu.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvHattyu.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvHattyu.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvHattyu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHattyu.Columns.Add("HaID", "発注ID");
            dgvHattyu.Columns.Add("MaID", "メーカー名");
            dgvHattyu.Columns.Add("EmID", "発注社員名");
            dgvHattyu.Columns.Add("HaDate", "発注年月日");
            dgvHattyu.Columns.Add("HaFlag", "発注管理フラグ");
            dgvHattyu.Columns.Add("WaWarehouseFlag", "入庫済フラグ");
            dgvHattyu.Columns.Add("HaHidden", "非表示理由");

            dgvHattyu.Columns["HaID"].Width = 110;
            dgvHattyu.Columns["MaID"].Width = 150;
            dgvHattyu.Columns["EmID"].Width = 150;
            dgvHattyu.Columns["HaDate"].Width = 160;
            dgvHattyu.Columns["HaFlag"].Width = 170;
            dgvHattyu.Columns["WaWarehouseFlag"].Width = 160;
            dgvHattyu.Columns["HaHidden"].Width = 267;

            dgvHattyu.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dgvHattyu.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvHattyu.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvHattyuDetail.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvHattyuDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvHattyuDetail.AllowUserToResizeColumns = false;
            dgvHattyuDetail.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvHattyuDetail.MultiSelect = false;
            //セルの編集ができないように
            dgvHattyuDetail.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvHattyuDetail.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvHattyuDetail.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvHattyuDetail.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvHattyuDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHattyuDetail.Columns.Add("HaID", "発注ID");
            dgvHattyuDetail.Columns.Add("HaDetailID", "発注詳細ID");
            dgvHattyuDetail.Columns.Add("PrID", "商品ID");
            dgvHattyuDetail.Columns.Add("HaQuantity", "数量");

            dgvHattyuDetail.Columns["HaID"].Width = 174;
            dgvHattyuDetail.Columns["HaDetailID"].Width = 174;
            dgvHattyuDetail.Columns["PrID"].Width = 174;
            dgvHattyuDetail.Columns["HaQuantity"].Width = 175;

            dgvHattyuDetail.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dgvHattyuDetail.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvHattyuDetail.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //列を自由に設定できるように
            dgvStock.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvStock.MultiSelect = false;
            //セルの編集ができないように
            dgvStock.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvStock.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvStock.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvStock.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvStock.Columns.Add("PrID", "商品ID");
            dgvStock.Columns.Add("PrName", "商品名");
            dgvStock.Columns.Add("StQuantity", "在庫数");
            dgvStock.Columns.Add("PrSafetyStock", "安全在庫数");

            dgvStock.Columns["PrID"].Width = 157;
            dgvStock.Columns["PrName"].Width = 174;
            dgvStock.Columns["StQuantity"].Width = 174;
            dgvStock.Columns["PrSafetyStock"].Width = 175;

            dgvStock.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dgvStock.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvStock.Columns)
            {
                dataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void txbProductID_TextChanged(object sender, EventArgs e)
        {
            //nullの確認
            string stringProdactID = txbProductID.Text.Trim();
            int intProdactID = 0;

            if (!String.IsNullOrEmpty(stringProdactID))
            {
                intProdactID = int.Parse(stringProdactID);
            }

            //存在確認
            if (!prodactDataAccess.CheckProdactIDExistence(intProdactID))
            {
                txbProductName.Text = "商品IDが存在しません";
                return;
            }

            //IDから名前を取り出す
            var Prodact = listProdact.Single(x => x.PrID == intProdactID);

            txbProductName.Text = Prodact.PrName;
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

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
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

        private void btnPageMax_Click(object sender, EventArgs e)
        {
            List<T_Hattyu> viewHattyu = SetListHattyu();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewHattyu.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }

        private void dgvHattyuDetail_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvHattyuDetail.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowDetailControl();

        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                cmbMakerName.Enabled = true;
                txbEmployeeID.Enabled = true;
                dtpHattyuDate.Enabled = true;
                txbHidden.Enabled = false;
                cmbConfirm.Enabled = true;
                cmbHidden.Enabled = false;
                txbHattyuQuantity.Enabled = false;
                txbProductID.Enabled = false;
            }

            if (rdbConfirm.Checked)
            {
                cmbMakerName.Enabled = false;
                cmbHidden.Enabled = false;
                txbEmployeeID.Enabled = false;
                dtpHattyuDate.Enabled = false;
                cmbConfirm.Enabled = true;
                txbHidden.Enabled = false;
                txbHattyuQuantity.Enabled = false;
                txbProductID.Enabled = false;
            }

            if (rdbDetailRegister.Checked)
            {
                cmbMakerName.Enabled = false;
                txbEmployeeID.Enabled = false;
                dtpHattyuDate.Enabled = false;
                cmbHidden.Enabled = false;
                cmbConfirm.Enabled = false;
                txbHidden.Enabled = false;
                txbProductID.Enabled = true;
                txbHattyuQuantity.Enabled = true;
            }

            if (rdbRegister.Checked)
            {
                cmbMakerName.Enabled = true;
                cmbHidden.Enabled = true;
                txbEmployeeID.Enabled = false;
                dtpHattyuDate.Enabled = true;
                cmbConfirm.Enabled = true;
                txbHidden.Enabled = false;
                txbHattyuQuantity.Enabled = false;
                txbProductID.Enabled = false;
            }

            if (rdbUpdate.Checked)
            {
                cmbMakerName.Enabled = false;
                cmbHidden.Enabled = true;
                txbEmployeeID.Enabled = false;
                dtpHattyuDate.Enabled = false;
                cmbConfirm.Enabled = false;
                txbHidden.Enabled = true;
                txbHattyuQuantity.Enabled = false;
                txbProductID.Enabled = false;
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
                FileName = "https://docs.google.com/document/d/1ek0yP4S7QgqV0NlQk6M91KyCYdRDb5GE",
                UseShellExecute = true
            });
        }

        private void btnProdactView_Click(object sender, EventArgs e)
        {
            ProdactView prodactView = new ProdactView();

            prodactView.Owner = this;
            prodactView.FormClosed += ChildForm_FormClosed;
            prodactView.Show();

            this.Opacity = 0;
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvHattyuDetail.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowDetailControl();
        }
    }
}

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
    public partial class F_HonshaProdact : Form
    {
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess ProdactDataAccess = new ProdactDataAccess();
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        MakerDataAccess MakerDataAccess = new MakerDataAccess();
        //データベース大分類テーブルアクセス用クラスのインスタンス化
        MajorDataAccess MajorDataAccess = new MajorDataAccess();
        //データベース小分類テーブルアクセス用クラスのインスタンス化
        SmallDataAccess SmallDataAccess = new SmallDataAccess();
        //データベース在庫テーブルアクセス用クラスのインスタンス化
        StockDataAccess stockDataAccess = new StockDataAccess();
        //データベース受注詳細テーブルアクセス用クラスのインスタンス化
        OrderDetailDataAccess orderDetailDataAccess = new OrderDetailDataAccess();
        //データベース注文詳細テーブルアクセス用クラスのインスタンス化
        ChumonDetailDataAccess chumonDetailDataAccess = new ChumonDetailDataAccess();
        //データベース出庫詳細テーブルアクセス用クラスのインスタンス化
        SyukkoDetailDataAccess syukkoDetailDataAccess = new SyukkoDetailDataAccess();
        //データベース入荷詳細テーブルアクセス用クラスのインスタンス化
        ArrivalDetailDataAccess arrivalDetailDataAccess = new ArrivalDetailDataAccess();
        //データベース出荷詳細テーブルアクセス用クラスのインスタンス化
        ShipmentDetailDataAccess shipmentDetailDataAccess = new ShipmentDetailDataAccess();
        //データベース発注詳細テーブルアクセス用クラスのインスタンス化
        HattyuDetailDataAccess hattyuDetailDataAccess = new HattyuDetailDataAccess();
        //データベース入庫詳細テーブルアクセス用クラスのインスタンス化
        WarehousingDetailDataAccess warehousingDetailDataAccess = new WarehousingDetailDataAccess();
        //データベース売上詳細テーブルアクセス用クラスのインスタンス化
        SaleDetailDataAccess saleDetailDataAccess = new SaleDetailDataAccess();
        //データグリッドビュー用の全商品データ
        private static List<M_Product> listAllProdact = new List<M_Product>();
        //データグリッドビュー用の大分類データ
        private static List<M_MajorClassification> listMajorID = new List<M_MajorClassification>();
        //データグリッドビュー用の小分類データ
        private static List<M_SmallClassification> listDGVSmallID = new List<M_SmallClassification>();
        //コンボボックス用の小分類データ
        private static List<M_SmallClassification> listSmallMajorID = new List<M_SmallClassification>();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //データグリッドビュー用の商品データ
        private static List<M_Product> listProdact = new List<M_Product>();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //コンボボックス用の営業所データリスト
        private static List<M_Maker> listMaker = new List<M_Maker>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        //データグリッドビュー用の大分類データリスト
        private static List<M_MajorClassification> listDGVMajorID = new List<M_MajorClassification>();
        //データグリッドビュー用のメーカーデータリスト
        private static List<M_Maker> listDGVMakerID = new List<M_Maker>();

        //DataGridView用に使用する大分類名のDictionary
        private Dictionary<int, string> dictionaryMajorID;
        //DataGridView用に使用する小分類名のDictionary
        private Dictionary<int, string> dictionarydgvSmallID;
        //DataGridView用に使用するメーカー名のDictionary
        private Dictionary<int, string> dictionaryMakerName;
        //DataGridView用に使用する商品のDictionary
        private Dictionary<int, string> dictionaryProdact;

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };

        private void F_HonshaProdact_Load(object sender, EventArgs e)
        {
            rdbRegister.Checked = true;
            
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();
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

            //大分類のデータを取得
            listMajorID = MajorDataAccess.GetMajorClassificationDspData();
            //表示する名前をMaNameに指定
            cmbMajorID.DisplayMember = "McName";
            //項目の順番をMaIDに指定
            cmbMajorID.ValueMember = "McID";
            //取得したデータをコンボボックスに挿入
            cmbMajorID.DataSource = listMajorID;
            //cmbMakerNameを未選択に
            cmbMajorID.SelectedIndex = -1;

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
        }

        public F_HonshaProdact()
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
            dtpProdactReleaseDate.Checked = false;

            rdbRegister.Checked = true;

            txbNumPage.Text = "1";

            GetDataGridView();
        }
        
        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                ProdactDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                ProdactDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ProdactDataSelect();
            }
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
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

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rdbSearch.Checked)
            {
                txbProdactID.Enabled = true;
                cmbMajorID.Enabled = true;
                cmbSmallID.Enabled = true;
                cmbMakerName.Enabled = true;

                txbProdactColor.Enabled = false;
                txbProdactHidden.Enabled = false;
                cmbHidden.Enabled = false;
                txbModelNumber.Enabled = false;
                txbProdactJanCode.Enabled = false;
                txbProdactPrice.Enabled = false;
                txbProdactSafetyStock.Enabled = false;
                txbProdactName.Enabled = false;
                
            }

            if (rdbRegister.Checked)
            {
                txbProdactID.Enabled = true;
                cmbMajorID.Enabled = true;
                cmbSmallID.Enabled = true;
                cmbMakerName.Enabled = true;
                txbProdactColor.Enabled = true;
                txbProdactHidden.Enabled = true;
                cmbHidden.Enabled = true;
                txbModelNumber.Enabled = true;
                txbProdactJanCode.Enabled = true;
                txbProdactPrice.Enabled = true;
                txbProdactSafetyStock.Enabled = true;
                txbProdactName.Enabled = true;
            }
            if (rdbUpdate.Checked)
            {
                txbProdactID.Enabled = true;
                cmbMajorID.Enabled = true;
                cmbSmallID.Enabled = true;
                cmbMakerName.Enabled = true;
                txbProdactColor.Enabled = true;
                txbProdactHidden.Enabled = true;
                cmbHidden.Enabled = true;
                txbModelNumber.Enabled = true;
                txbProdactJanCode.Enabled = true;
                txbProdactPrice.Enabled = true;
                txbProdactSafetyStock.Enabled = true;
                txbProdactName.Enabled = true;
            }
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
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {
            //大分類名のデータを取得
            listMajorID = MajorDataAccess.GetMajorClassificationDspData();

            //データグリッドビュー用の大分類のデータを取得
            listDGVMajorID = MajorDataAccess.GetMajorData();

            dictionaryMajorID = new Dictionary<int, string> { };

            foreach (var item in listDGVMajorID)
            {
                dictionaryMajorID.Add(item.McID, item.McName);
            }

            //データグリッドビュー用の小分類のデータを取得
            listDGVSmallID = SmallDataAccess.GetSmallData();

            //メーカ名
            listMaker = MakerDataAccess.GetMakerDspData();

            //データグリッドビュー用のメーカーのデータを取得
            listDGVMakerID = MakerDataAccess.GetMakerData();

            dictionaryMakerName = new Dictionary<int, string> { };

            foreach (var item in listDGVMakerID)
            {
                dictionaryMakerName.Add(item.MaID, item.MaName);
            }

            //商品のデータを取得
            listProdact = ProdactDataAccess.GetProdactDspData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listProdact)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
            }
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
            if (String.IsNullOrEmpty(txbProdactID.Text.Trim()) && cmbMajorID.SelectedIndex == -1 && cmbMakerName.SelectedIndex == -1 && cmbSmallID.SelectedIndex == -1 && dtpProdactReleaseDate.Checked == false)
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactID.Focus();
                return false;
            }

            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbProdactID.Text.Trim()))
            {
                // 顧客IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbProdactID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (!ProdactDataAccess.CheckProdactIDExistence(int.Parse(txbProdactID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactID.Focus();
                    return false;
                }
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：ProdactDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：商品情報更新の実行
        ///////////////////////////////
        private void ProdactDataUpdate()
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

            // 商品情報作成
            var updProdact = GenerateDataAtUpdate();

            // 情報更新
            UpdateProdact(updProdact);
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
            // 商品IDの適否
            if (!String.IsNullOrEmpty(txbProdactID.Text.Trim()))
            {
                // 商品IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbProdactID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactID.Focus();
                    return false;
                }
                //商品IDの重複チェック
                if (!ProdactDataAccess.CheckProdactIDExistence(int.Parse(txbProdactID.Text.Trim())))
                {
                    MessageBox.Show("商品IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("商品IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactID.Focus();
                return false;
            }

            // メーカー名の適否
            if (cmbMakerName.SelectedIndex == -1)
            {
                MessageBox.Show("メーカー名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMakerName.Focus();
                return false;
            }

            // 商品名の適否
            if (!String.IsNullOrEmpty(txbProdactName.Text.Trim()))
            {
                // 商品名の文字数チェック
                if (txbProdactName.TextLength >= 50)
                {
                    MessageBox.Show("商品名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactName.Focus();
                    return false;
                }

                M_Product Prodact = ProdactDataAccess.GetIDProdactData(int.Parse(txbProdactID.Text.Trim()));

                if (Prodact.PrName != txbProdactName.Text.Trim())
                {
                    MessageBox.Show("商品名が既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("商品名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactName.Focus();
                return false;
            }

            // 価格の適否
            if (!String.IsNullOrEmpty(txbProdactPrice.Text.Trim()))
            {
                // 価格の文字数チェック
                if (txbProdactPrice.TextLength >= 50)
                {
                    MessageBox.Show("価格は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactPrice.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("価格が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactPrice.Focus();
                return false;
            }

            // 安全在庫数の適否
            if (!String.IsNullOrEmpty(txbProdactSafetyStock.Text.Trim()))
            {
                // 安全在庫数の文字数チェック
                if (txbProdactSafetyStock.TextLength >= 50)
                {
                    MessageBox.Show("安全在庫数は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactSafetyStock.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("安全在庫数が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactSafetyStock.Focus();
                return false;
            }

            // 型番の適否
            if (!String.IsNullOrEmpty(txbModelNumber.Text.Trim()))
            {
                // 型番の文字数チェック
                if (txbModelNumber.TextLength > 50)
                {
                    MessageBox.Show("型番は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbModelNumber.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("型番が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbModelNumber.Focus();
                return false;
            }

            // 色の適否
            if (!String.IsNullOrEmpty(txbProdactColor.Text.Trim()))
            {
                // 色の文字数チェック
                if (txbProdactColor.TextLength > 10)
                {
                    MessageBox.Show("色は10文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactColor.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("色が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactColor.Focus();
                return false;
            }

            // 大分類IDの適否
            if (cmbMajorID.SelectedIndex == -1)
            {
                MessageBox.Show("大分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactName.Focus();
                return false;
            }

            // 小分類IDの適否
            if (cmbMajorID.SelectedIndex == -1)
            {
                MessageBox.Show("小分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMajorID.Focus();
                return false;
            }

            //表示非表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示の選択が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
                return false;
            }

            return true;
        }


        ///////////////////////////////
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：商品更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_Product GenerateDataAtUpdate()
        {
            return new M_Product
            {
                PrID = int.Parse(txbProdactID.Text.Trim()),
                MaID = cmbMakerName.SelectedIndex + 1,
                PrName = txbProdactName.Text.Trim(),
                Price = int.Parse(txbProdactPrice.Text.Trim()),
                PrJCode = txbProdactJanCode.Text.Trim(),
                PrSafetyStock = int.Parse(txbProdactSafetyStock.Text.Trim()),
                ScID = cmbSmallID.SelectedIndex + 1,
                McID = cmbMajorID.SelectedIndex + 1,
                PrModelNumber = txbModelNumber.Text.Trim(),
                PrColor = txbProdactColor.Text.Trim(),
                PrFlag = cmbHidden.SelectedIndex,
                PrHidden = txbProdactHidden.Text.Trim(),
                PrReleaseDate = dtpProdactReleaseDate.Value,
            };
        }

        ///////////////////////////////
        //メソッド名：ProdactDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：商品情報登録の実行
        ///////////////////////////////
        private void ProdactDataRegister()
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

            // 商品情報作成
            var regProdact = GenerateDataAtRegistration();

            // 商品情報登録
            RegistrationProdact(regProdact);
        }

        ///////////////////////////////
        //メソッド名：UpdateProdact()
        //引　数   ：商品情報
        //戻り値   ：なし
        //機　能   ：商品情報の更新
        ///////////////////////////////
        private void UpdateProdact(M_Product updProdact)
        {
            // 商品情報の更新
            bool flg = ProdactDataAccess.UpdateProdactData(updProdact);
            if (flg == true)
            {
                MessageBox.Show("更新しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("更新に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // データグリッドビューの表示
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：RegistrationClient()
        //引　数   ：商品情報
        //戻り値   ：なし
        //機　能   ：商品データの登録
        ///////////////////////////////
        private void RegistrationProdact(M_Product regProdact)
        {
            // 商品情報の登録
            bool flg = ProdactDataAccess.AddProdactData(regProdact);

            //登録成功・失敗メッセージ
            if (flg == true)
            {
                MessageBox.Show("データを登録しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //在庫登録
            M_Product Prodact = ProdactDataAccess.GetProdactIDName(regProdact.PrName);

            T_Stock Stock = GenerateProdactAtRegistration(Prodact);

            bool flgStock = stockDataAccess.AddStockData(Stock);

            if (flgStock == true)
            {
                MessageBox.Show("在庫管理にデータを送信ました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("在庫管理へのデータ送信に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 入力エリアのクリア
            ClearImput();

            // データグリッドビューの表示
            GetDataGridView();
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

                intDBID = context.M_Products.Count() + 1;
            }
            else
            {
                intDBID = int.Parse(txbProdactID.Text.Trim());
            }

            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "商品管理画面",
                OpDone = OperationDone,
                OpDBID = intDBID,
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateChumonAtRegistration()
        //引　数   ：商品情報
        //戻り値   ：在庫登録情報
        //機　能   ：在庫登録データのセット
        ///////////////////////////////
        private T_Stock GenerateProdactAtRegistration(M_Product Prodact)
        {
            return new T_Stock
            {
                PrID = Prodact.PrID,
                StQuantity = 0,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：商品登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Product GenerateDataAtRegistration()
        {
            return new M_Product
            {
                MaID = cmbMakerName.SelectedIndex + 1,
                PrName = txbProdactName.Text.Trim(),
                Price = int.Parse(txbProdactPrice.Text.Trim()),
                PrJCode = txbProdactJanCode.Text.Trim(),
                PrSafetyStock = int.Parse(txbProdactSafetyStock.Text.Trim()),
                ScID = cmbSmallID.SelectedIndex + 1,
                McID = cmbMajorID.SelectedIndex + 1,
                PrModelNumber = txbModelNumber.Text.Trim(),
                PrColor = txbProdactColor.Text.Trim(),
                PrFlag = cmbHidden.SelectedIndex,
                PrHidden = txbProdactHidden.Text.Trim(),
                PrReleaseDate = DateTime.Now,
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
            // メーカー名の適否
            if (cmbMakerName.SelectedIndex == -1)
            {
                MessageBox.Show("メーカー名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMakerName.Focus();
                return false;
            }

            // 商品名の適否
            if (!String.IsNullOrEmpty(txbProdactName.Text.Trim()))
            {
                // 商品名の文字数チェック
                if (txbProdactName.TextLength >= 50)
                {
                    MessageBox.Show("商品名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("商品名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactName.Focus();
                return false;
            }

            // 価格の適否
            if (!String.IsNullOrEmpty(txbProdactPrice.Text.Trim()))
            {
                // 価格の文字数チェック
                if (txbProdactPrice.TextLength >= 50)
                {
                    MessageBox.Show("価格は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactPrice.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("価格が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactPrice.Focus();
                return false;
            }

            // 安全在庫数の適否
            if (!String.IsNullOrEmpty(txbProdactSafetyStock.Text.Trim()))
            {
                // 安全在庫数の文字数チェック
                if (txbProdactSafetyStock.TextLength >= 50)
                {
                    MessageBox.Show("安全在庫数は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactSafetyStock.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("安全在庫数が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactSafetyStock.Focus();
                return false;
            }

            // 型番の適否
            if (!String.IsNullOrEmpty(txbModelNumber.Text.Trim()))
            {
                // 型番の文字数チェック
                if (txbModelNumber.TextLength > 50)
                {
                    MessageBox.Show("型番は50文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbModelNumber.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("型番が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbModelNumber.Focus();
                return false;
            }

            // 色の適否
            if (!String.IsNullOrEmpty(txbProdactColor.Text.Trim()))
            {
                // 色の文字数チェック
                if (txbProdactColor.TextLength > 10)
                {
                    MessageBox.Show("色は10文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactColor.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("色が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactColor.Focus();
                return false;
            }

            //表示非表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示の選択が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
                return false;
            }

            // 大分類IDの適否
            if (cmbMajorID.SelectedIndex == -1)
            {
                MessageBox.Show("大分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactName.Focus();
                return false;
            }

            // 小分類IDの適否
            if (cmbMajorID.SelectedIndex == -1)
            {
                MessageBox.Show("小分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMajorID.Focus();
                return false;
            }

            return true;
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
            List<M_Product> listViewClient = SetListClient();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewClient);
        }

        ///////////////////////////////
        //メソッド名：SetListClient()
        //引　数   ：なし
        //戻り値   ：表示用商品データ
        //機　能   ：表示用商品データの準備
        ///////////////////////////////
        private List<M_Product> SetListClient()
        {
            //商品のデータを全取得
            listAllProdact = ProdactDataAccess.GetProdactDspData();

            //表示用の顧客リスト作成
            List<M_Product> listViewProdact = new List<M_Product>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewProdact = listProdact;
            }
            else
            {
                //全データをとってくる
                listViewProdact = listAllProdact;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の商品データの取得
                listViewProdact = ProdactDataAccess.GetProdactDspData(listViewProdact);
            }
            else
            {
                // 管理Flgが非表示の商品データの取得
                listViewProdact = ProdactDataAccess.GetProdactNotDspData(listViewProdact);
            }

            return listViewProdact;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_Product> viewProdact)
        {
            //中身を消去
            dgvProdact.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewProdact.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewProdact.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                //小分類名のデータを取得
                listSmallMajorID = SmallDataAccess.GetMajorIDData(item.McID);

                dictionarydgvSmallID = new Dictionary<int, string> { };

                foreach (var items in listSmallMajorID)
                {
                    dictionarydgvSmallID.Add(items.ScID, items.ScName);
                }

                dgvProdact.Rows.Add(item.PrID, dictionaryMakerName[item.MaID],item.PrName, item.Price,item.PrJCode, item.PrSafetyStock, dictionaryMajorID[item.McID], dictionarydgvSmallID[item.ScID], item.PrModelNumber, item.PrColor, dictionaryHidden[item.PrFlag], item.PrReleaseDate, item.PrHidden);
            }

            //dgvClientをリフレッシュ
            dgvProdact.Refresh();

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
            dgvProdact.AutoGenerateColumns = false;
            //行単位で選択するようにする
            dgvProdact.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvProdact.AllowUserToResizeColumns = false;
            dgvProdact.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvProdact.MultiSelect = false;
            //セルの編集ができないように
            dgvProdact.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvProdact.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvProdact.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvProdact.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvProdact.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProdact.Columns.Add("PrID", "商品ID");
            dgvProdact.Columns.Add("MaID", "メーカID");
            dgvProdact.Columns.Add("PrName", "商品名");
            dgvProdact.Columns.Add("Price", "価格");
            dgvProdact.Columns.Add("PrJCode", "JANコード");
            dgvProdact.Columns.Add("PrSafetyStock", "安全在庫数");
            dgvProdact.Columns.Add("McID", "大分類ID");
            dgvProdact.Columns.Add("ScID", "小分類ID");
            dgvProdact.Columns.Add("PrModelNumber", "型番");
            dgvProdact.Columns.Add("PrColor", "色");
            dgvProdact.Columns.Add("PrFlag", "商品管理フラグ");
            dgvProdact.Columns.Add("PrReleaseDate", "発売日");
            dgvProdact.Columns.Add("PrHidden", "非表示理由");

            dgvProdact.Columns["PrID"].Width = 102;
            dgvProdact.Columns["MaID"].Width = 85;
            dgvProdact.Columns["PrName"].Width = 150;
            dgvProdact.Columns["Price"].Width = 120;
            dgvProdact.Columns["PrJCode"].Width = 70;
            dgvProdact.Columns["PrSafetyStock"].Width = 140;
            dgvProdact.Columns["McID"].Width = 290;
            dgvProdact.Columns["ScID"].Width = 142;
            dgvProdact.Columns["PrModelNumber"].Width = 80;
            dgvProdact.Columns["PrColor"].Width = 95;
            dgvProdact.Columns["PrFlag"].Width = 115;
            dgvProdact.Columns["PrReleaseDate"].Width = 210;
            dgvProdact.Columns["PrHidden"].Width = 298;

            dgvProdact.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(69)))));
            dgvProdact.DefaultCellStyle.SelectionForeColor = Color.White;

            //並び替えができないようにする
            foreach (DataGridViewColumn dataColumn in dgvProdact.Columns)
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
            txbProdactID.Text = string.Empty;
            txbProdactName.Text = string.Empty;
            cmbMajorID.SelectedIndex = -1;
            //txbMajorName.Text = string.Empty;
            txbModelNumber.Text = string.Empty;
            txbProdactColor.Text = string.Empty;
            cmbSmallID.SelectedIndex = -1;
            //txbSmallName.Text = string.Empty;
            cmbMakerName.SelectedIndex = -1;
            txbProdactPrice.Text = string.Empty;
            dtpProdactReleaseDate.Value = DateTime.Now;
            txbProdactSafetyStock.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";

            //データグリッドビューのデータ取得
            GetDataGridView();
        }

        private void dgvProdact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvProdact.SelectedCells.Count == 0)
            {
                return;
            }

            //選択された行に対してのコントロールの変更
            SelectRowControl();
        }

        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            //小分類名のデータを取得
            listSmallMajorID = SmallDataAccess.GetMajorIDData(dictionaryMajorID.FirstOrDefault(x => x.Value == dgvProdact[6, dgvProdact.CurrentCellAddress.Y].Value.ToString()).Key);

            dictionarydgvSmallID = new Dictionary<int, string> { };

            foreach (var items in listSmallMajorID)
            {
                dictionarydgvSmallID.Add(items.ScID, items.ScName);
            }

            bool cmbMflg = false;
            int intMajorID = dictionaryMajorID.FirstOrDefault(x => x.Value == dgvProdact[6, dgvProdact.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listMajorID)
            {
                if (intMajorID == item.McID)
                {
                    cmbMflg = true;
                }
            }

            if (cmbMflg)
            {
                cmbMajorID.SelectedValue = intMajorID;
            }
            else
            {
                cmbMajorID.SelectedIndex = -1;
            }

            bool cmbSflg = false;
            int intSmallID = dictionarydgvSmallID.FirstOrDefault(x => x.Value == dgvProdact[7, dgvProdact.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach (var item in listSmallMajorID)
            {
                if (intSmallID == item.ScID)
                {
                    cmbSflg = true;
                }
            }

            if (cmbSflg)
            {
                cmbSmallID.SelectedValue = intSmallID;
            }
            else
            {
                cmbSmallID.SelectedIndex = -1;
            }

            bool cmbMakerflg = false;
            int intMakerID = dictionaryMakerName.FirstOrDefault(x => x.Value == dgvProdact[1, dgvProdact.CurrentCellAddress.Y].Value.ToString()).Key;

            foreach(var item in listDGVMakerID)
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

            //データグリッドビューに乗っている情報をGUIに反映
            txbProdactID.Text = dgvProdact[0, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            //cmbSalesOfficeID.SelectedIndex = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvProdact[1, dgvProdact.CurrentCellAddress.Y].Value.ToString()).Key.Value - 1;
            txbProdactName.Text = dgvProdact[2, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbProdactPrice.Text = dgvProdact[3, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbProdactSafetyStock.Text = dgvProdact[5, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbModelNumber.Text = dgvProdact[8, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbProdactColor.Text = dgvProdact[9, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            dtpProdactReleaseDate.Text = dgvProdact[11, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbProdactJanCode.Text = dgvProdact[4, dgvProdact.CurrentCellAddress.Y]?.Value?.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvProdact[10, dgvProdact.CurrentCellAddress.Y].Value.ToString()).Key;
            txbProdactHidden.Text = dgvProdact[12, dgvProdact.CurrentCellAddress.Y]?.Value?.ToString();
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：searchFlg = And検索かOr検索か判別するためのBool値
        //戻り値   ：なし
        //機　能   ：商品情報の取得
        ///////////////////////////////
        private void GenerateDataAtSelect(bool searchFlg)
        {
            string strProdactID = txbProdactID.Text.Trim();
            int intProdactID = 0;

            if (!String.IsNullOrEmpty(strProdactID))
            {
                intProdactID = int.Parse(strProdactID);
            }

            DateTime? dateProdact = null;

            if (dtpProdactReleaseDate.Checked)
            {
                dateProdact = dtpProdactReleaseDate.Value.Date;
            }

            // 検索条件のセット
            M_Product selectCondition = new M_Product()
            {
                PrID = intProdactID,
                McID = cmbMajorID.SelectedIndex + 1,
                ScID = cmbSmallID.SelectedIndex + 1,
                MaID = cmbMakerName.SelectedIndex + 1,
                PrReleaseDate = dateProdact.Value,
                //テキストボックス = txbxxxxxx.Text.Trim()
            };

            if (searchFlg)
            {
                // 商品データのAnd抽出
                listProdact = ProdactDataAccess.GetAndProdactData(selectCondition);
            }
            else
            {
                // 商品データのOr抽出
                listProdact = ProdactDataAccess.GetOrProdactData(selectCondition);
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
            // 顧客情報抽出
            GenerateDataAtSelect(searchFlg);

            int intSearchCount = listProdact.Count;

            txbNumPage.Text = "1";

            // 顧客抽出結果表示
            GetDataGridView();

            MessageBox.Show("検索結果：" + intSearchCount + "件", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPagesize_Click(object sender, EventArgs e)
        {
            if (txbPageSize.Text.Trim() == string.Empty)
            {
                txbPageSize.Text = "1";
            }

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
            List<M_Product> viewClient = SetListClient();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewClient.Count / (double)pageSize);

            txbNumPage.Text = lastPage.ToString();

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

        private void button1_Click(object sender, EventArgs e)
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
                FileName = "https://docs.google.com/document/d/1ZgVVTTy5Qd2OHCWsk43F0fwvHmdQC4br",
                UseShellExecute = true
            });
        }

        private void cmbMajorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMajorID.SelectedIndex == -1)
            {
                if (cmbSmallID.Items.Count != 0)
                {
                    cmbSmallID.DataSource = null;
                }

                return;
            }

            int intSmallID = MajorDataAccess.GetMajorNameData(cmbMajorID.Text);

            //小分類名のデータを取得
            listSmallMajorID = SmallDataAccess.GetMajorIDData(intSmallID);

            //表示する名前をScNameに指定
            cmbSmallID.DisplayMember = "ScName";
            //項目の順番をScIDに指定
            cmbSmallID.ValueMember = "ScID";
            //取得したデータをコンボボックスに挿入
            cmbSmallID.DataSource = listSmallMajorID;
            //cmbMakerNameを未選択に
            cmbSmallID.SelectedIndex = -1;
        }
    }
}

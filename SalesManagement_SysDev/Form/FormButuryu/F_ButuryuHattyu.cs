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
    public partial class F_ButuryuHattyu : Form
    {
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
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
        private void SearchDialog_btnAndSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            SaleSearchButtonClick(true);
        }

        private void SearchDialog_btnOrSearchClick(object sender, EventArgs e)
        {
            f_SearchDialog.Close();

            SaleSearchButtonClick(false);
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

            dictionaryEmployee = new Dictionary<int, string> { };

            foreach (var item in listEmployee)
            {
                dictionaryEmployee.Add(item.EmID, item.EmName);
            }

            //商品のデータを取得
            listProdact = prodactDataAccess.GetProdactDspData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listProdact)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
            }
            //メーカーのデータを取得
            listMaker = makerDataAccess.GetMakerDspData();

            dictionaryMaker = new Dictionary<int, string> { };

            foreach (var item in listMaker)
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
            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "発注管理画面",
                OpDone = OperationDone,
                OpDBID = int.Parse(txbHattyuID.Text.Trim()),
                OpSetTime = DateTime.Now,
            };
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

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
            cmbMakerName.Text = string.Empty;
            txbEmployeeID.Text = string.Empty;
            txbHattyuDetailID.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbProductName.Text = string.Empty;
            txbHattyuQuantity.Text = string.Empty;
            dtpHattyuDate.Value = DateTime.Now;
        }

        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の売上リスト作成
            List<T_Hattyu> listViewHattyu = SetListHattyu();

            List<T_HattyuDetail> listHattyuDetail = hattyuDetailDataAccess.GetHattyuDetailData();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewHattyu, listHattyuDetail);
        }

        ///////////////////////////////
        //メソッド名：SetListHattyu()
        //引　数   ：なし
        //戻り値   ：表示用発注データ
        //機　能   ：表示用発注データの準備
        ///////////////////////////////
        private List<T_Hattyu> SetListHattyu()
        {
            //売上のデータを全取得
            listAllHattyu = hattyuDataAccess.GetHattyuData();

            //表示用の売上リスト作成
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
                // 管理Flgが表示の売上データの取得
                listViewHattyu = hattyuDataAccess.GetHattyuDspData(listViewHattyu);
            }
            else
            {
                // 管理Flgが非表示の売上データの取得
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
        private void SetDataGridView(List<T_Hattyu> viewHattyu, List<T_HattyuDetail> viewHattyuDetail)
        {
            //中身を消去
            dgvHattyu.Rows.Clear();
            //中身を消去
            dgvHattyuDetail.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewHattyu.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewHattyu.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvHattyu.Rows.Add(item.HaID, dictionaryMaker[item.MaID], dictionaryEmployee[item.EmID],item.HaDate, dictionaryHidden[item.HaFlag], item.HaHidden);
            }

            //dgvClientをリフレッシュ
            dgvHattyu.Refresh();


            if (pageNum == 0 && lastPage == pageNum)
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
                if (hattyuDataAccess.CheckHattyuIDExistence(int.Parse(txbHattyuID.Text.Trim())))
                {
                    MessageBox.Show("発注IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // メーカー名の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("メーカー名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMakerName.Focus();
                return false;
            }


            // 社員IDの適否
            if (!String.IsNullOrEmpty(txbEmployeeID.Text.Trim()))
            {
                //社員IDの存在チェック
                if (!employeeDataAccess.CheckEmployeeIDExistence(int.Parse(txbEmployeeID.Text.Trim())))
                {
                    MessageBox.Show("社員IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
                //社員IDが現在ログインしているIDと等しいかチェック
                if (F_Login.intEmployeeID == int.Parse(txbEmployeeID.Text.Trim()))
                {
                    MessageBox.Show("自身の社員IDを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("社員IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeID.Focus();
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
                HaID = int.Parse(txbHattyuID.Text.Trim()),
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
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

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

            //操作ログデータ取得
            var regOperationLog = GenerateLogAtRegistration(rdbDetailRegister.Text);

            //操作ログデータの登録（成功 = true,失敗 = false）
            if (!operationLogAccess.AddOperationLogData(regOperationLog))
            {
                return;
            }

            // 発注情報作成
            var regHattyu = GenerateDetailDataAtRegistration();

            // 発注情報登録
            RegistrationHattyuDetail(regHattyu);
        }
        ///////////////////////////////
        //メソッド名：GetValidDetailDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：登録入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDetailDataAtRegistration()
        {
            //発注詳細IDの適否
            if (!String.IsNullOrEmpty(txbHattyuDetailID.Text.Trim()))
            {
                //発注詳細IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbHattyuDetailID.Text.Trim()))
                {
                    MessageBox.Show("発注詳細IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuDetailID.Focus();
                    return false;
                }
                //発注詳細IDの存在チェック
                if (hattyuDataAccess.CheckHattyuIDExistence(int.Parse(txbHattyuID.Text.Trim())))
                {
                    MessageBox.Show("発注詳細IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHattyuDetailID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("発注詳細IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbHattyuDetailID.Focus();
                return false;
            }

            //発注IDの適否
            if (!String.IsNullOrEmpty(txbHattyuID.Text.Trim()))
            {
                //発注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbHattyuID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //メソッド名：GenerateDetailDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：発注詳細登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private T_HattyuDetail GenerateDetailDataAtRegistration()
        {
            M_Product Prodact = prodactDataAccess.GetIDProdactData(int.Parse(txbProductID.Text.Trim()));

            return new T_HattyuDetail
            {
                HaDetailID = int.Parse(txbHattyuDetailID.Text.Trim()),
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
            // 登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            // 受注情報の登録
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


        private void button1_Click(object sender, EventArgs e)
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
            txbHattyuDetailID.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbProductName.Text = string.Empty;
            txbHattyuQuantity.Text = string.Empty;
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

            listHattyuDetail = hattyuDetailDataAccess.GetHattyuDetailIDData(intHattyuID);

            //1行ずつdgvClientに挿入
            foreach (var item in listHattyuDetail)
            {
                dgvHattyuDetail.Rows.Add(item.HaID, item.HaDetailID, dictionaryProdact[item.PrID], item.OrQuantity);
            }

            //dgvClientをリフレッシュ
            dgvHattyuDetail.Refresh();
        }

    }
}

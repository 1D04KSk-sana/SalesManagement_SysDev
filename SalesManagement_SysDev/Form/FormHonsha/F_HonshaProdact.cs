using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SalesManagement_SysDev
{
    public partial class F_HonshaProdact : Form
    {
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess ProdactDataAccess = new ProdactDataAccess();
        //データグリッドビュー用の全商品データ
        private static List<M_Product> listAllProdact = new List<M_Product>();
        //データグリッドビュー用の商品データ
        private static List<M_Product> listProdact = new List<M_Product>();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };



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

            rdbRegister.Checked = true;

            GetDataGridView();
        }
        
        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                ProdactDataRegister();
            }
        }

        ///////////////////////////////
        //メソッド名：ClientDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報登録の実行
        ///////////////////////////////
        private void ProdactDataRegister()
        {
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
            var regClient = GenerateDataAtRegistration();

            // 顧客情報登録
            RegistrationClient(regClient);
        }

        ///////////////////////////////
        //メソッド名：GenerateLogAtRegistration()
        //引　数   ：操作名
        //戻り値   ：操作ログ登録情報
        //機　能   ：操作ログ情報登録データのセット
        ///////////////////////////////
        private T_OperationLog GenerateLogAtRegistration(string OperationDone)
        {
            //登録・更新使用としている顧客データの取得
            var logOperatin = GenerateDataAtRegistration();

            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "顧客管理画面",
                OpDone = OperationDone,
                OpDBID = logOperatin.ClID.Value,
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：顧客登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Client GenerateDataAtRegistration()
        {
            return new M_Client
            {
                ClID = int.Parse(txbClientID.Text.Trim()),
                SoID = cmbSalesOfficeID.SelectedIndex + 1,
                ClName = txbClientName.Text.Trim(),
                ClAddress = txbClientAddress.Text.Trim(),
                ClPhone = txbClientPhone.Text.Trim(),
                ClPostal = txbClientPostal.Text.Trim(),
                ClFAX = txbClientFAX.Text.Trim(),
                ClFlag = cmbHidden.SelectedIndex,
                ClHidden = txbHidden.Text.Trim(),
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
                if (ProdactDataAccess.CheckProdactIDExistence(int.Parse(txbProdactID.Text.Trim())))
                {
                    MessageBox.Show("商品IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // 大分類IDの適否
            if (!String.IsNullOrEmpty(txbMajorID.Text.Trim()))
            {
                // 大分類IDの文字数チェック
                //if (txbMajorID.TextLength > 13)
                //{
                //    MessageBox.Show("大分類IDは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txbMajorID.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("大分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactName.Focus();
                return false;
            }


            // 大分類名の適否
            if (!String.IsNullOrEmpty(txbMajorName.Text.Trim()))
            {
                // 大分類名の文字数チェック
                if (txbMajorName.TextLength >= 50)
                {
                    MessageBox.Show("大分類名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("大分類名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactName.Focus();
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

            // 小分類IDの適否
            if (!String.IsNullOrEmpty(txbSmallID.Text.Trim()))
            {
                // 小分類IDの文字数チェック
                //if (txbSmallID.TextLength > 13)
                //{
                //    MessageBox.Show("大分類IDは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txbSmallID.Focus();
                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("小分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSmallID.Focus();
                return false;
            }


            // 大分類名の適否
            if (!String.IsNullOrEmpty(txbSmallName.Text.Trim()))
            {
                // 大分類名の文字数チェック
                if (txbSmallName.TextLength >= 50)
                {
                    MessageBox.Show("小分類名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("小分類名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerName.Focus();
                return false;
            }

            // メーカー名の適否
            if (!String.IsNullOrEmpty(txbMakerName.Text.Trim()))
            {
                // メーカー名の文字数チェック
                if (txbMakerName.TextLength >= 50)
                {
                    MessageBox.Show("メーカー名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMakerName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("メーカー名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMakerName.Focus();
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

            // 発売日の適否
            if (!String.IsNullOrEmpty(txbProdactReleaseDate.Text.Trim()))
            {
                // 発売日の文字数チェック
                if (txbProdactReleaseDate.TextLength >= 50)
                {
                    MessageBox.Show("発売日は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactReleaseDate.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("発売日が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactReleaseDate.Focus();
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
                dgvProdact.Rows.Add(item.PrID,item.MaID,item.PrName, dictionaryHidden[item.PrFlag], 
                    item.PrHidden, item.Price, item.PrJCode, item.PrSafetyStock, item.ScID, item.PrModelNumber, 
                    item.PrColor, item.PrReleaseDate, item.PrHidden);
            }

            //dgvClientをリフレッシュ
            dgvProdact.Refresh();

            if (lastPage == pageNum)
            {
                btnPageMax.Visible = false;
                btnNext.Visible = false;
                btnPageMin.Visible = true;
                btnBack.Visible = true;
            }
            else if (pageNum == 0)
            {
                btnPageMax.Visible = true;
                btnNext.Visible = true;
                btnPageMin.Visible = false;
                btnBack.Visible = false;
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
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbProdactID.Text = string.Empty;
            txbProdactName.Text = string.Empty;
            txbMajorID.Text = string.Empty;
            txbMajorName.Text = string.Empty;
            txbModelNumber.Text = string.Empty;
            txbProdactColor.Text = string.Empty;
            txbSmallID.Text = string.Empty;
            txbSmallName.Text = string.Empty;
            txbMakerName.Text = string.Empty;
            txbProdactPrice.Text = string.Empty;
            txbProdactReleaseDate.Text = string.Empty;
            txbProdactSafetyStock.Text = string.Empty;
            cmbView.SelectedIndex = -1;
            cmbHidden.SelectedIndex = -1;
        }


    }
}

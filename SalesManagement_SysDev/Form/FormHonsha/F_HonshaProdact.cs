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
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //データグリッドビュー用の商品データ
        private static List<M_Product> listProdact = new List<M_Product>();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();


        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };

        private void F_HonshaProdact_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            SetFormDataGridView();



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
        //機　能   ：商品情報登録の実行
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

            // 商品情報作成
            var regProdact = GenerateDataAtRegistration();

            // 商品情報登録
            RegistrationProdact(regProdact);
        }

        ///////////////////////////////
        //メソッド名：RegistrationClient()
        //引　数   ：顧客情報
        //戻り値   ：なし
        //機　能   ：顧客データの登録
        ///////////////////////////////
        private void RegistrationProdact(M_Product regProdact)
        {
            // 顧客情報の登録
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
            //登録・更新使用としている商品データの取得
            var logOperatin = GenerateDataAtRegistration();

            return new T_OperationLog
            {
                OpHistoryID = operationLogAccess.OperationLogNum() + 1,
                EmID = F_Login.intEmployeeID,
                FormName = "商品管理画面",
                OpDone = OperationDone,
                OpDBID = logOperatin.PrID,
                OpSetTime = DateTime.Now,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：顧客登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Product GenerateDataAtRegistration()
        {
            return new M_Product
            {
                PrID = int.Parse(txbProdactID.Text.Trim()),
                MaID = int.Parse(txbMakerName.Text.Trim()),
                PrName = txbProdactName.Text.Trim(),
                Price = int.Parse(txbSmallID.Text.Trim()),
                PrJCode = txbProdactJanCode.Text.Trim(),
                PrSafetyStock = int.Parse(txbProdactSafetyStock.Text.Trim()),
                ScID = int.Parse(txbSmallID.Text.Trim()),
                PrModelNumber = txbModelNumber.Text.Trim(),
                PrColor = txbProdactColor.Text.Trim(),
                PrFlag = cmbHidden.SelectedIndex,
                PrHidden = tbxProdactHidden.Text.Trim(),
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

            // JANコードの適否
            if (!String.IsNullOrEmpty(txbProdactJanCode.Text.Trim()))
            {
                // JANコードの文字数チェック
                if (txbProdactJanCode.TextLength >= 50)
                {
                    MessageBox.Show("JANコードは50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProdactJanCode.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("JANコードが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProdactJanCode.Focus();
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

            // 小分類IDの適否
            if (!String.IsNullOrEmpty(txbSmallID.Text.Trim()))
            {
                //小分類IDの文字数チェック
                if (txbSmallID.TextLength > 13)
                {
                    MessageBox.Show("小分類IDは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSmallID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("小分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSmallID.Focus();
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

            //表示非表示選択の適否
            if (cmbHidden.SelectedIndex == -1)
            {
                MessageBox.Show("表示家選択が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHidden.Focus();
                return false;
            }

            //// 大分類IDの適否
            //if (!String.IsNullOrEmpty(txbMajorID.Text.Trim()))
            //{
            //    // 大分類IDの文字数チェック
            //    //if (txbMajorID.TextLength > 13)
            //    //{
            //    //    MessageBox.Show("大分類IDは13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    txbMajorID.Focus();
            //    //    return false;
            //    //}
            //}
            //else
            //{
            //    MessageBox.Show("大分類IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txbProdactName.Focus();
            //    return false;
            //}


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
                dgvProdact.Rows.Add(item.PrID,item.MaID,item.PrName, 
                     item.Price,item.PrJCode, item.PrSafetyStock, item.ScID,
                     item.PrModelNumber, item.PrColor, dictionaryHidden[item.PrFlag],
                     item.PrReleaseDate, item.PrHidden);
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
            dgvProdact.Columns.Add("ScID", "小分類ID");
            dgvProdact.Columns.Add("PrModelNumber", "型番");
            dgvProdact.Columns.Add("PrColor", "色");
            dgvProdact.Columns.Add("PrFlag", "商品管理フラグ");
            dgvProdact.Columns.Add("PrReleaseDate", "発売日");
            dgvProdact.Columns.Add("PrHidden", "非表示理由");

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
            txbMajorID.Text = string.Empty;
            //txbMajorName.Text = string.Empty;
            txbModelNumber.Text = string.Empty;
            txbProdactColor.Text = string.Empty;
            txbSmallID.Text = string.Empty;
            //txbSmallName.Text = string.Empty;
            txbMakerName.Text = string.Empty;
            txbProdactPrice.Text = string.Empty;
            txbProdactReleaseDate.Text = string.Empty;
            txbProdactSafetyStock.Text = string.Empty;
            cmbView.SelectedIndex = -1;
            cmbHidden.SelectedIndex = -1;
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            

            //データグリッドビューに乗っている情報をGUIに反映
            txbProdactID.Text = dgvProdact[0, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            //cmbSalesOfficeID.SelectedIndex = dictionarySalesOffice.FirstOrDefault(x => x.Value == dgvProdact[1, dgvProdact.CurrentCellAddress.Y].Value.ToString()).Key.Value - 1;
            txbProdactName.Text = dgvProdact[2, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            //txbMajorID.Text = dgvProdact[2, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbSmallID.Text = dgvProdact[6, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbModelNumber.Text = dgvProdact[7, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbProdactColor.Text = dgvProdact[8, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbProdactReleaseDate.Text = dgvProdact[9, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbProdactJanCode.Text = dgvProdact[10, dgvProdact.CurrentCellAddress.Y]?.Value?.ToString();
            txbMakerName.Text = dgvProdact[1, dgvProdact.CurrentCellAddress.Y]?.Value?.ToString();
            txbProdactPrice.Text = dgvProdact[3, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            txbProdactSafetyStock.Text = dgvProdact[5, dgvProdact.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = dictionaryHidden.FirstOrDefault(x => x.Value == dgvProdact[10, dgvProdact.CurrentCellAddress.Y].Value.ToString()).Key;
            tbxProdactHidden.Text = dgvProdact[11, dgvProdact.CurrentCellAddress.Y]?.Value?.ToString();
        }

        private void btnPagesize_Click(object sender, EventArgs e)
        {
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
    }
}

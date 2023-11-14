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
    public partial class F_ButuryuStock : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース受注テーブルアクセス用クラスのインスタンス化
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        //データベース商品テーブルアクセス用クラスのインスタンス化
        ProdactDataAccess prodactDataAccess = new ProdactDataAccess();
        //コンボボックス用の社員データリスト
        private static List<M_Product> listProdact = new List<M_Product>();
        //DataGridView用に使用する商品のDictionary
        private Dictionary<int, string> dictionaryProdact;

        public F_ButuryuStock()
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
        }
        ///////////////////////////////
        //メソッド名：ClearImput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：テキストボックスやコンボボックスの中身のクリア
        ///////////////////////////////
        private void ClearImput()
        {
            txbstockID.Text = string.Empty;
            txbStockQuentity.Text = string.Empty;
            txbProductID.Text = string.Empty;
            txbProdactName.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
            cmbView.SelectedIndex = -1;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                StockDataRegister();
            }
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //StockDataSelect();
            }
        }
        ///////////////////////////////
        //メソッド名：StockDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：在庫情報登録の実行
        ///////////////////////////////
        private void StockDataRegister()
        {
            ////入力情報適否
            //if (!GetValidDataAtRegistration())
            //{
            //    return;
            //}

            ////操作ログデータ取得
            //var regOperationLog = GenerateLogAtRegistration(rdbRegister.Text);

            ////操作ログデータの登録（成功 = true,失敗 = false）
            //if (!operationLogAccess.AddOperationLogData(regOperationLog))
            //{
            //    return;
            //}

            //// 受注情報作成
            //var regOrder = GenerateDataAtRegistration();

            //// 受注情報登録
            //RegistrationOrder(regOrder);
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
            //受注IDの適否
            if (!String.IsNullOrEmpty(txbstockID.Text.Trim()))
            {
                //受注IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbstockID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbstockID.Focus();
                    return false;
                }
                //受注IDの存在チェック
                if (orderDataAccess.CheckOrderIDExistence(int.Parse(txbstockID.Text.Trim())))
                {
                    MessageBox.Show("受注IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbstockID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("受注IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbstockID.Focus();
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

        private void F_ButuryuStock_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";

            //cmbViewを表示に
            cmbView.SelectedIndex = 0;
        }
        ///////////////////////////////
        //メソッド名：DictionarySet()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：Dictionaryのセット
        ///////////////////////////////
        private void DictionarySet()
        {
            //商品のデータを取得
            listProdact = prodactDataAccess.GetProdactDspData();

            dictionaryProdact = new Dictionary<int, string> { };

            foreach (var item in listProdact)
            {
                dictionaryProdact.Add(item.PrID, item.PrName);
            }
        }
    }
}

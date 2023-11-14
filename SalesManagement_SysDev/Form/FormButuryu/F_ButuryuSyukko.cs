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
    public partial class F_ButuryuSyukko : Form
    {
        //データベース商品テーブルアクセス用クラスのインスタンス化
        SyukkoDataAccess SyukkoDataAccess = new SyukkoDataAccess();
        //データグリッドビュー用の全出庫データ
        private static List<T_Syukko> listAllSyukko = new List<T_Syukko>();
        //データグリッドビュー用の出庫データ
        private static List<T_Syukko> listsyukko = new List<T_Syukko>();

        public F_ButuryuSyukko()
        {
            InitializeComponent();
        }

        private void F_ButuryuSyukko_Load(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
            txbPageSize.Text = "3";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbSearch.Checked = true;

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
            txbSyukkoID.Text = string.Empty;
            txbClientID.Text = string.Empty;
            cmbSalesOfficeID.SelectedIndex = -1;
            txbEmployeeName.Text = string.Empty;
            txbChumonID.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
            txbHidden.Text = string.Empty;
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
            //SetDataGridView(listViewSyukko);
        }

        ///////////////////////////////
        //メソッド名：SetListClient()
        //引　数   ：なし
        //戻り値   ：表示用商品データ
        //機　能   ：表示用商品データの準備
        ///////////////////////////////
        private List<T_Syukko> SetListSyukko()
        {
            //商品のデータを全取得
            listAllSyukko = SyukkoDataAccess.GetSyukkoDspData();

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
                //listViewSyukko = SyukkoDataAccess.GetSyukkoDspData(listViewSyukko);
            }
            else
            {
                // 管理Flgが非表示の商品データの取得
                listViewSyukko = SyukkoDataAccess.GetSyukkoNotDspData(listViewSyukko);
            }

            return listViewSyukko;
        }
    }
}

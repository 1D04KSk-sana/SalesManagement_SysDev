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
    public partial class F_HonshaPosition : Form
    {
        //データグリッドビュー用の顧客データ
        private static List<M_Position> listPosition = new List<M_Position>();
        //データグリッドビュー用の全役職データ
        private static List<M_Position> listAllPosition = new List<M_Position>();
        //データベース役職テーブルアクセス用クラスのインスタンス化
        PositionDataAccess positionDataAccess = new PositionDataAccess();

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        public F_HonshaPosition()
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
                PositionDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                PositionDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                PositionDataSelect();
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
            txbPositionID.Text = string.Empty;
            txbPositionName.Text = string.Empty;
            txbHidden.Text = string.Empty;
            txbPositionListFlug.Text = string.Empty;
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
            List<M_Position> viewPosition = SetListPosition();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //最終ページ数を取得（テキストボックスに代入する数字なので-1はしない）
            int lastPage = (int)Math.Ceiling(viewPosition.Count / (double)pageSize);

            if (lastPage == 0)
            {
                lastPage++;
            }

            txbNumPage.Text = lastPage.ToString();

            GetDataGridView();
        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の顧客リスト作成
            List<M_Position> listViewPosition = SetListPosition();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewPosition);
        }

        ///////////////////////////////
        //メソッド名：SetListPosition()
        //引　数   ：なし
        //戻り値   ：表示用顧客データ
        //機　能   ：表示用顧客データの準備
        ///////////////////////////////
        private List<M_Position> SetListPosition()
        {
            //役職のデータを全取得
            listAllPosition = positionDataAccess.GetPositionData();

            //表示用の役職リスト作成
            List<M_Position> listViewPosition = new List<M_Position>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewPosition = listPosition;
            }
            else
            {
                //全データをとってくる
                listViewPosition = listAllPosition;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewPosition = positionDataAccess.GetPositionDspData(listViewPosition);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewPosition = positionDataAccess.GetPositionNotDspData(listViewPosition);
            }

            return listViewPosition;
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_Position> viewPosition)
        {
            //中身を消去
            dgvClient.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewPosition.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewPosition.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvClient.Rows.Add(item.PoID,  item.PoName,  dictionaryHidden[item.PoFlag], item.PoHidden);
            }

            //dgvClientをリフレッシュ
            dgvClient.Refresh();

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
    }
}

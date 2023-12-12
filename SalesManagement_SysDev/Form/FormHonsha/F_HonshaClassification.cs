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
    public partial class F_HonshaClassification : Form
    {
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        MajorDataAccess majorDataAccess = new MajorDataAccess();
        //データベースメーカーテーブルアクセス用クラスのインスタンス化
        SmallDataAccess smallDataAccess = new SmallDataAccess();
        //データベース操作ログテーブルアクセス用クラスのインスタンス化
        OperationLogDataAccess operationLogAccess = new OperationLogDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の全大分類データ
        private static List<M_MajorClassification> listAllMajor = new List<M_MajorClassification>();
        //コンボボックス用の大分類データリスト
        private static List<M_MajorClassification> listMajor = new List<M_MajorClassification>();
        //データグリッドビュー用の全小分類データ
        private static List<M_SmallClassification> listAllSmall = new List<M_SmallClassification>();
        //コンボボックス用の小分類データリスト
        private static List<M_SmallClassification> listSmall = new List<M_SmallClassification>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();

        //DataGridView用に使用する表示形式のDictionary
        private Dictionary<int, string> dictionaryHidden = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        //DataGridView用に使用する確定形式のDictionary
        private Dictionary<int, string> dictionaryConfirm = new Dictionary<int, string>
        {
            { 0, "表示" },
            { 1, "非表示" },
        };
        public F_HonshaClassification()
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


            rdbMajorRegister.Checked = true;

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
            txbMajorID.Text = string.Empty;
            txbSmallID.Text = string.Empty;
            txbMajorName.Text = string.Empty;
            txbSmallName.Text = string.Empty;
            txbHidden.Text = string.Empty;
            cmbHidden.SelectedIndex = -1;
        }
        ///////////////////////////////
        //メソッド名：GetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューに表示するデータの全取得
        ///////////////////////////////
        private void GetDataGridView()
        {
            //表示用の大分類リスト作成
            List<M_MajorClassification> listViewMajor = SetListMajor();
            //表示用の小分類リスト作成
            List<M_SmallClassification> listViewSmall = SetListSmall();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewMajor);
        }
        ///////////////////////////////
        //メソッド名：SetListMajor()
        //引　数   ：なし
        //戻り値   ：表示用大分類データ
        //機　能   ：表示用大分類データの準備
        ///////////////////////////////
        private List<M_MajorClassification> SetListMajor()
        {
            //顧客のデータを全取得
            listAllMajor = majorDataAccess.GetMajorData();

            //表示用の顧客リスト作成
            List<M_MajorClassification> listViewMajor = new List<M_MajorClassification>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbMajorSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewMajor = listMajor;
            }
            else
            {
                //全データをとってくる
                listViewMajor = listAllMajor;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewMajor = majorDataAccess.GetMajorDspData(listViewMajor);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewMajor = majorDataAccess.GetMajorNotDspData(listViewMajor);
            }

            return listViewMajor;
        }
        ///////////////////////////////
        //メソッド名：SetListMajor()
        //引　数   ：なし
        //戻り値   ：表示用大分類データ
        //機　能   ：表示用大分類データの準備
        ///////////////////////////////
        private List<M_SmallClassification> SetListSmall()
        {
            //顧客のデータを全取得
            listAllSmall = smallDataAccess.GetSmallData();

            //表示用の顧客リスト作成
            List<M_SmallClassification> listViewSmall = new List<M_SmallClassification>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbMajorSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewSmall = listSmall;
            }
            else
            {
                //全データをとってくる
                listViewSmall = listAllSmall;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewSmall = smallDataAccess.GetSmallDspData(listViewSmall);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewSmall = smallDataAccess.GetSmallNotDspData(listViewSmall);
            }

            return listViewSmall;
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_MajorClassification> viewMajor)
        {
            //中身を消去
            dgvMajor.Rows.Clear();

            dgvSmall.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewMajor.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewMajor.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvMakerに挿入
            foreach (var item in depData)
            {
                dgvMajor.Rows.Add(item.McID, item.McName, dictionaryHidden[item.McFlag], item.McHidden);
            }

            //dgvMajorをリフレッシュ
            dgvMajor.Refresh();

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

                //dgvSmallをリフレッシュ
                dgvSmall.Refresh();

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
}

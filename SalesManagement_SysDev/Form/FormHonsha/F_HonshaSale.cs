﻿using System;
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
    public partial class F_HonshaSale : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //データグリッドビュー用の売上データ
        private static List<T_Sale> listClient = new List<T_Sale>();
        //データグリッドビュー用の全売上データ
        private static List<T_Sale> listAllClient = new List<T_Sale>();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //フォームを呼び出しする際のインスタンス化
        private F_SearchDialog f_SearchDialog = new F_SearchDialog();



        public F_HonshaSale()
        {
            InitializeComponent();
        }
        //DataGridView用に使用す営業所のDictionary
        private Dictionary<int?, string> dictionarySalesOffice = new Dictionary<int?, string>
        {
            { 1, "北大阪営業所" },
            { 2, "兵庫営業所" },
            { 3, "鹿営業所"},
            { 4, "京都営業所"},
            { 5, "和歌山営業所"}
        };


        private void F_HonshaSale_Load(object sender, EventArgs e)
        {

        }

        private void rdbSearch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpSaleDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSaleDate_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void txbEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbClientPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ClientDataSelect();
            }
        }
        ///////////////////////////////
        //メソッド名：ClientDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報検索の実行
        ///////////////////////////////
        private void ClientDataSelect()
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
            if (String.IsNullOrEmpty(txbSaleID.Text.Trim()) && cmbSalesOfficeID.SelectedIndex == -1 && String.IsNullOrEmpty(txbClientPhone.Text.Trim()))
            {
                MessageBox.Show("検索条件が未入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSaleID.Focus();
                return false;
            }

            // 顧客IDの適否
            if (!String.IsNullOrEmpty(txbSaleID.Text.Trim()))
            {
                // 顧客IDの数字チェック
                if (!dataInputCheck.CheckNumeric(txbSaleID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSaleID.Focus();
                    return false;
                }
                //顧客IDの重複チェック
                if (!clientDataAccess.CheckClientIDExistence(int.Parse(txbSaleID.Text.Trim())))
                {
                    MessageBox.Show("顧客IDが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSaleID.Focus();
                    return false;
                }
            }

            return true;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearImput();

            rdbRegister.Checked = true;

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
            txbSaleID.Text = string.Empty;
            txbClientName.Text = string.Empty;
            txbClientPostal.Text = string.Empty;
            txbEmployeeName.Text = string.Empty;
            txbClientPostal.Text = string.Empty;
            txbHidden.Text = string.Empty;
            dtpSaleDate.Value= DateTime.Now;
            cmbSalesOfficeID.SelectedIndex = -1;
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
            //表示用の売上リスト作成
            List<T_Sale> listViewSale = SetListSale();

            // DataGridViewに表示するデータを指定
            SetDataGridView(listViewSale);
        }
        ///////////////////////////////
        //メソッド名：SetListSale()
        //引　数   ：なし
        //戻り値   ：表示用売上データ
        //機　能   ：表示用売上データの準備
        ///////////////////////////////
        private List<T_Sale> SetListSale()
        {
            //売上のデータを全取得
            listAllSale = saleDataAccess.GetSaleData();

            //表示用の売上リスト作成
            List<T_Sale> listViewSale = new List<T_Sale>();

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                //表示している（検索結果）のデータをとってくる
                listViewSale = listSale;
            }
            else
            {
                //全データをとってくる
                listViewSale = listAllSale;
            }

            //一覧表示cmbViewが表示を選択されているとき
            if (cmbView.SelectedIndex == 0)
            {
                // 管理Flgが表示の部署データの取得
                listViewSale = saleDataAccess.GetSaleDspData(listViewSale);
            }
            else
            {
                // 管理Flgが非表示の部署データの取得
                listViewSale = saleDataAccess.GetSaleNotDspData(listViewSale);
            }

            return listViewSale;
        }
        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView(List<M_Client> viewClient)
        {
            //中身を消去
            dgvSale.Rows.Clear();

            //ページ行数を取得
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            //ページ数を取得
            int pageNum = int.Parse(txbNumPage.Text.Trim()) - 1;
            //最終ページ数を取得
            int lastPage = (int)Math.Ceiling(viewClient.Count / (double)pageSize) - 1;

            //データからページに必要な部分だけを取り出す
            var depData = viewClient.Skip(pageSize * pageNum).Take(pageSize).ToList();

            //1行ずつdgvClientに挿入
            foreach (var item in depData)
            {
                dgvSale.Rows.Add(item.ClID, dictionarySalesOffice[item.SoID], item.ClName, item.ClAddress, item.ClPhone, item.ClPostal, item.ClFAX, dictionaryHidden[item.ClFlag], item.ClHidden);
            }

            //dgvClientをリフレッシュ
            dgvSale.Refresh();

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





        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

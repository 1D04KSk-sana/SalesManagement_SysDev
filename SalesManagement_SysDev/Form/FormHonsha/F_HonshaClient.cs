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
    public partial class F_HonshaClient : Form
    {
        //データベース顧客テーブルアクセス用クラスのインスタンス化
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データグリッドビュー用の顧客データ
        private static List<M_Client> listClient = new List<M_Client>();

        public F_HonshaClient()
        {
            InitializeComponent();
        }

        private void F_HonshaClient_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //登録ラヂオボタンがチェックされているとき
            if (rdbRegister.Checked)
            {
                ClientDataRegister();
            }

            //更新ラヂオボタンがチェックされているとき
            if (rdbUpdate.Checked)
            {
                ClientDataUpdate();
            }

            //検索ラヂオボタンがチェックされているとき
            if (rdbSearch.Checked)
            {
                ClientDataSelect();
            }
        }

        private void dgvRecordEditing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvClient.SelectedCells.Count == 0)
            {
                return;
            }

            SelectRowControl();
        }

        ///////////////////////////////
        //メソッド名：ClientDataRegister()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：顧客情報登録の実行
        ///////////////////////////////
        private void ClientDataRegister()
        {

            // 部署情報作成
            var regClient = GenerateDataAtRegistration();

            // 部署情報登録
            RegistrationClient(regClient);
        }

        ///////////////////////////////
        //メソッド名：RegistrationDivision()
        //引　数   ：部署情報
        //戻り値   ：なし
        //機　能   ：部署データの登録
        ///////////////////////////////
        private void RegistrationClient(M_Client regClient)
        {
            // 部署情報の登録
            bool flg = clientDataAccess.AddClientData(regClient);

            //登録成功・失敗メッセージ
            if (flg == true)
            {
                MessageBox.Show("データを登録しました。");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました。");
            }

            // 入力エリアのクリア
            ClearInput();

            // データグリッドビューの表示
            GetDataGridView();

        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtRegistration()
        //引　数   ：なし
        //戻り値   ：部署登録情報
        //機　能   ：登録データのセット
        ///////////////////////////////
        private M_Client GenerateDataAtRegistration()
        {
            return new M_Client
            {
                ClID = int.Parse(txbClientID.Text.Trim()),
                SoID = cmbSalesOfficeID.SelectedIndex,
                ClName = txbClientName.Text.Trim(),
                ClAddress = txbClientAddress.Text.Trim(),
                ClPhone = txbCilentPhone.Text.Trim(),
                ClPostal = txbClientPostal.Text.Trim(),
                ClFAX = txbClientFax.Text.Trim(),
                ClFlag = cmbHidden.SelectedIndex,
                ClHidden = txbHidden.Text.Trim(),
            };
        }

        ///////////////////////////////
        //メソッド名：ClientDataUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void ClientDataUpdate()
        {

            // 8.1.2.2 部署情報作成
            var updDivision = GenerateDataAtUpdate();

            // 8.1.2.3 部署情報更新
            UpdateDivision(updDivision);
        }

        ///////////////////////////////
        //　8.1.2.2 部署情報作成
        //メソッド名：GenerateDataAtUpdate()
        //引　数   ：なし
        //戻り値   ：部署更新情報
        //機　能   ：更新データのセット
        ///////////////////////////////
        private M_Client GenerateDataAtUpdate()
        {
            return new M_Client
            {
                ClID = int.Parse(txbClientID.Text.Trim()),
                ClName = txbClientName.Text.Trim(),
                ClHidden = txbHidden.Text.Trim(),
                ClPhone = txbCilentPhone.Text.Trim(),
                SoID = cmbSalesOfficeID.SelectedIndex,
                ClPostal = txbClientPostal.Text.Trim(),
                ClAddress = txbClientAddress.Text.Trim(),
                ClFAX = txbClientFax.Text.Trim(),
                ClFlag = cmbHidden.SelectedIndex,
            };
        }

        ///////////////////////////////
        //　8.1.2.3 部署情報更新
        //メソッド名：UpdateDivision()
        //引　数   ：部署情報
        //戻り値   ：なし
        //機　能   ：部署情報の更新
        ///////////////////////////////
        private void UpdateDivision(M_Client updDivision)
        {
            // 更新確認メッセージ
            DialogResult result = MessageBox.Show("更新しますか？","確認"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
                return;

            // 部署情報の更新
            bool flg = clientDataAccess.UpdateClientData(updDivision);
            if (flg == true)
                //MessageBox.Show("データを更新しました。");
                MessageBox.Show("更新しました。", "確認"
                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //MessageBox.Show("データの更新に失敗しました。");
                MessageBox.Show("更新に失敗しました。", "エラー"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);

           

            

            // データグリッドビューの表示
            GetDataGridView();


        }

        ///////////////////////////////
        //メソッド名：ClientDataSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void ClientDataSelect()
        {

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
            txbClientID.Text = dgvClient[0, dgvClient.CurrentCellAddress.Y].Value.ToString();
            cmbSalesOfficeID.SelectedIndex = int.Parse(dgvClient[1, dgvClient.CurrentCellAddress.Y].Value.ToString()) - 1;
            txbClientName.Text = dgvClient[2, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientAddress.Text = dgvClient[3, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbCilentPhone.Text = dgvClient[4, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientPostal.Text = dgvClient[5, dgvClient.CurrentCellAddress.Y].Value.ToString();
            txbClientFax.Text = dgvClient[6, dgvClient.CurrentCellAddress.Y].Value.ToString();
            cmbHidden.SelectedIndex = int.Parse(dgvClient[7, dgvClient.CurrentCellAddress.Y].Value.ToString());
            txbHidden.Text = dgvClient[8, dgvClient.CurrentCellAddress.Y]?.Value?.ToString();
        }

        ///////////////////////////////
        //メソッド名：SetFormDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューの初期設定
        ///////////////////////////////
        private void SetFormDataGridView()
        {
            //行単位で選択するようにする
            dgvClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvClient.AllowUserToResizeColumns = false;
            dgvClient.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvClient.MultiSelect = false;
            //セルの編集ができないように
            dgvClient.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvClient.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvClient.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvClient.AllowUserToAddRows = false;

            //ヘッダー位置の指定
            dgvClient.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //データグリッドビューのデータ取得
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
            // 部署データの取得
            listClient = clientDataAccess.GetClientData();

            // DataGridViewに表示するデータを指定
            SetDataGridView();
        }

        ///////////////////////////////
        //メソッド名：SetDataGridView()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：データグリッドビューへの表示
        ///////////////////////////////
        private void SetDataGridView()
        {
            dgvClient.DataSource = listClient.ToList();

            //各列幅の指定
            dgvClient.Columns[0].Width = 40;
            dgvClient.Columns[1].Width = 70;
            dgvClient.Columns[2].Width = 70;
            dgvClient.Columns[3].Width = 60;
            dgvClient.Columns[4].Width = 60;
            dgvClient.Columns[5].Width = 70;
            dgvClient.Columns[6].Width = 60;
            dgvClient.Columns[7].Width = 60;
            dgvClient.Columns[8].Width = 100;

            dgvClient.Refresh();
        }

        ///////////////////////////////
        //メソッド名：ClearInput()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：入力エリアをクリア
        ///////////////////////////////
        private void ClearInput()
        {
            txbClientID.Text = "";
            txbClientName.Text = "";
            txbCilentPhone.Text = "";
            txbClientPostal.Text = "";
            txbClientAddress.Text = "";
            txbClientFax.Text = "";
            txbHidden.Text = "";
            cmbSalesOfficeID.SelectedIndex = 0;
            cmbHidden.SelectedIndex = 0;
        }
    }
}

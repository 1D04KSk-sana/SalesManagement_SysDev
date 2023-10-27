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
    public partial class F_HonshaSinghUp : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputCheck dataInputCheck = new DataInputCheck();
        //データベース営業所テーブルアクセス用クラスのインスタンス化
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        //コンボボックス用の営業所データリスト
        private static List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
        //データベース役職名テーブルアクセス用クラスのインスタンス化
       PositionDataAccess PositionDataAccess = new PositionDataAccess();
        //コンボボックス用の役職名データリスト
        private static List<M_Position> listPosition = new List<M_Position>();
        public F_HonshaSinghUp()
        {
            InitializeComponent();
        }

        private void pnlHonsha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbNumPage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPageMin_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPageMax_Click(object sender, EventArgs e)
        {

        }

        private void btnPageSize_Click(object sender, EventArgs e)
        {

        }

        private void lblPageSize_Click(object sender, EventArgs e)
        {

        }

        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNumPage_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void cmbHidden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbHidden_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClientHidden_Click(object sender, EventArgs e)
        {

        }

        private void txbClientFAX_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClientFax_Click(object sender, EventArgs e)
        {

        }

        private void txbClientAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClientAddress_Click(object sender, EventArgs e)
        {

        }

        private void txbClientPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClientPostal_Click(object sender, EventArgs e)
        {

        }

        private void lblCilentPhone_Click(object sender, EventArgs e)
        {

        }

        private void cmbSalesOfficeID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbClientPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSalesOfficeID_Click(object sender, EventArgs e)
        {

        }

        private void txbClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClientName_Click(object sender, EventArgs e)
        {

        }

        private void txbClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClientID_Click(object sender, EventArgs e)
        {

        }

        private void pnlSelect_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }

        private void lblClient_Click(object sender, EventArgs e)
        {

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
            //// 顧客IDの適否
            //if (!String.IsNullOrEmpty(txbEmployeeName.Text.Trim()))
            //{
            //    // 顧客IDの数字チェック
            //    if (!dataInputCheck.CheckNumeric(txbClientID.Text.Trim()))
            //    {
            //        MessageBox.Show("顧客IDは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txbClientID.Focus();
            //        return false;
            //    }
            //    //顧客IDの重複チェック
            //    if (clientDataAccess.CheckClientIDExistence(int.Parse(txbClientID.Text.Trim())))
            //    {
            //        MessageBox.Show("顧客IDが既に存在します", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txbClientID.Focus();
            //        return false;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("顧客IDが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txbClientID.Focus();
            //    return false;
            //}

            // 社員名の適否
            if (!String.IsNullOrEmpty(txbEmployeeName.Text.Trim()))
            {
                // 社員名の文字数チェック
                if (txbEmployeeName.TextLength >= 50)
                {
                    MessageBox.Show("社員名は50文字です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmployeeName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("社員名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmployeeName.Focus();
                return false;
            }

            //役職名の適否
            if (cmbPositionID.SelectedIndex == -1)
            {
                MessageBox.Show("営業名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPositionID.Focus();
                return false;
            }

            // 電話番号の適否
            if (!String.IsNullOrEmpty(txbSinghUpPhone.Text.Trim()))
            {
                // 電話番号の文字数チェック
                if (txbSinghUpPhone.TextLength > 13)
                {
                    MessageBox.Show("電話番号は13文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSinghUpPhone.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSinghUpPhone.Focus();
                return false;
            }


            // パスワードの適否
            if (!String.IsNullOrEmpty(txbSinghUpPass.Text.Trim()))
            {
                // パスワードの数字チェック
                if (!dataInputCheck.CheckHalfAlphabetNumeric(txbSinghUpPass.Text.Trim()))
                {
                    MessageBox.Show("パスワードは全て数字入力です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSinghUpPass.Focus();
                    return false;
                }
                // パスワードの文字数チェック
                if (txbSinghUpPass.TextLength > 7)
                {
                    MessageBox.Show("パスワードは10文字以内です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSinghUpPass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("パスワードが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSinghUpPass.Focus();
                return false;
            }

            // 営業所名の適否
            if (cmbSalesOfficeID.SelectedIndex == -1)
            {
                MessageBox.Show("営業名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPositionID.Focus();
                return false;
            }
            return true;
        }

        private void F_HonshaSinghUp_Load(object sender, EventArgs e)
        {
            //営業所のデータを取得
            listSalesOffice = salesOfficeDataAccess.GetSalesOfficeDspData();
            //取得したデータをコンボボックスに挿入
            cmbSalesOfficeID.DataSource = listSalesOffice;
            //表示する名前をSoNameに指定
            cmbSalesOfficeID.DisplayMember = "SoName";
            //項目の順番をSoIDに指定
            cmbSalesOfficeID.ValueMember = "SoID";

            //cmbSalesOfficeIDを未選択に
            cmbSalesOfficeID.SelectedIndex = -1;

            //役職名のデータを取得
            listPosition = PositionDataAccess.GetPositionDspData();
            //取得したデータをコンボボックスに挿入
            cmbPositionID.DataSource = listPosition;
            //表示する名前をSoNameに指定
            cmbPositionID.DisplayMember = "PoName";
            //項目の順番をSoIDに指定
            cmbPositionID.ValueMember = "PoID";

            //cmbPositionIDを未選択に
            cmbPositionID.SelectedIndex = -1;
        }
    }
}

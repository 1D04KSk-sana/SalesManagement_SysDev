using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ProdactDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckProdactIDExistence()
        //引　数   ：商品コード
        //戻り値   ：True or False
        //機　能   ：一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckProdactIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //商品IDで一致するデータが存在するか
                flg = context.M_Products.Any(x => x.PrID == ProdactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetProdactDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の商品データ
        //機　能：管理Flgが表示の商品データの全取得
        ///////////////////////////////
        public List<M_Product> GetProdactDspData()
        {
            List<M_Product> listProdact = new List<M_Product>();

            try
            {
                var context = new SalesManagement_DevContext();
                listProdact = context.M_Products.Where(x => x.PrFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：GetProdactID()
        //引　数   ：商品名
        //戻り値   ：商品ID
        //機　能   ：一致する商品名を取り出して、IDを取得
        ///////////////////////////////
        public int GetProdactID(string prodactName)
        {
            int prodactID = 0;

            try
            {
                var context = new SalesManagement_DevContext();
                var Prodact = context.M_Products.Single(x => x.PrName == prodactName);

                prodactID = Prodact.PrID;

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return prodactID;
        }

        ///////////////////////////////
        //メソッド名：GetIDProdactData()
        //引　数：商品ID
        //戻り値：商品IDの一致する受注データ
        //機　能：商品IDの一致する受注データの取得
        ///////////////////////////////
        public M_Product GetIDProdactData(int ProdactID)
        {
            M_Product Prodact = new M_Product { };

            try
            {
                var context = new SalesManagement_DevContext();
                Prodact = context.M_Products.Single(x => x.PrID == ProdactID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Prodact;
        }
    }
}

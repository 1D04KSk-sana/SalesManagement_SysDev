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
        public bool CheckProdactIDExistence(int prodactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //商品CDで一致するデータが存在するか
                flg = context.M_Products.Any(x => x.PrID == prodactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetClientData()
        //引　数：なし
        //戻り値：商品データ
        //機　能：商品データの全取得
        ///////////////////////////////
        public List<M_Product> GetProdactDspData()
        {
            List<M_Product> listProdact = new List<M_Product>();

            try
            {
                var context = new SalesManagement_DevContext();
                listProdact = context.M_Products.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：GetClientNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の商品データ
        //機　能：管理Flgが非表示の商品データの全取得
        ///////////////////////////////
        public List<M_Product> GetProdactNotDspData(List<M_Product> dspClient)
        {
            List<M_Product> listProdact = new List<M_Product>();

            try
            {
                listProdact = dspClient.Where(x => x.PrFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：GetAndProdactData()
        //引　数：検索条件
        //戻り値：条件完全一致商品データ
        //機　能：条件完全一致商品データの取得
        ///////////////////////////////
        public List<M_Product> GetAndProdactData(M_Product selectProdact)
        {
            List<M_Product> listProdact = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.M_Products.AsQueryable();

                if (selectProdact.PrID != null && selectProdact.PrID != 0)
                {
                    query = query.Where(x => x.PrID == selectProdact.PrID);
                }

                if (selectProdact.McID != null && selectProdact.McID != 0)
                {
                    query = query.Where(x => x.McID == selectProdact.McID);
                }

                if (selectProdact.MaID != null && selectProdact.MaID != 0)
                {
                    query = query.Where(x => x.MaID == selectProdact.MaID);
                }

                listProdact = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：GetOrProdactData()
        //引　数：検索条件
        //戻り値：条件一部一致商品データ
        //機　能：条件一部一致商品データの取得
        ///////////////////////////////
        public List<M_Product> GetOrProdactData(M_Product selectProdact)
        {
            List<M_Product> listProdact = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                listProdact = context.M_Products.Where(x => x.PrID == selectProdact.PrID || x.McID == selectProdact.McID || x.MaID == selectProdact.MaID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：GetProdactDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の商品データ
        //機　能：管理Flgが表示の商品データの全取得
        ///////////////////////////////
        public List<M_Product> GetProdactDspData(List<M_Product> dspProdact)
        {
            List<M_Product> listProdact = new List<M_Product>();

            try
            {
                listProdact = dspProdact.Where(x => x.PrFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：AddProdactData()
        //引　数：regClient = 商品データ
        //戻り値：True or False
        //機　能：商品データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddProdactData(M_Product regProdact)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Products.Add(regProdact);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        ///////////////////////////////
        //メソッド名：UpdateClientData()
        //引　数：updClient = 商品データ
        //戻り値：True or False
        //機　能：商品データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateProdactData(M_Product updProdact)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Prodact = context.M_Products.Single(x => x.PrID == updProdact.PrID);

                Prodact.PrID = updProdact.PrID;
                Prodact.MaID = updProdact.MaID;
                Prodact.PrName = updProdact.PrName;
                Prodact.Price = updProdact.Price;
                Prodact.PrJCode = updProdact.PrJCode;
                Prodact.PrSafetyStock = updProdact.PrSafetyStock;
                Prodact.ScID = updProdact.ScID;
                Prodact.PrModelNumber = updProdact.PrModelNumber;
                Prodact.PrColor = updProdact.PrColor;
                Prodact.PrReleaseDate = updProdact.PrReleaseDate;
                Prodact.PrFlag = updProdact.PrFlag;
                Prodact.PrHidden = updProdact.PrHidden;

                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

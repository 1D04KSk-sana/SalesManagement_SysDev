﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class StockDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckProdactIDExistence()
        //引　数   ：商品コード
        //戻り値   ：True or False
        //機　能   ：一致する商品IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckStockIDExistence(int tock
            ID)
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
        //メソッド名：GetClientNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の商品データ
        //機　能：管理Flgが非表示の商品データの全取得
        ///////////////////////////////
        public List<M_Product> GetProdactNotDspData(List<M_Product> dspProduct)
        {
            List<M_Product> listProdact = new List<M_Product>();

            try
            {
                listProdact = dspProduct.Where(x => x.PrFlag == 1).ToList();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return prodactID;
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
        ///////////////////////////////
        //メソッド名：AddProductData()
        //引　数：regProduct = 受注データ
        //戻り値：True or False
        //機　能：受注データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddProductData(M_Product regProduct)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Products.Add(regProduct);
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
        //メソッド名：GetProdactData()
        //引　数：なし
        //戻り値：受注データ
        //機　能：受注データの全取得
        ///////////////////////////////
        public List<M_Product> GetProdactData()
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
        //メソッド名：CheckEmployeeIDExistence()
        //引　数   ：社員ID
        //戻り値   ：True or False
        //機　能   ：一致する社員IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckProductIDExistence(int ProdactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //社員IDで一致するデータが存在するか
                flg = context.M_Products.Any(x => x.PrID == ProdactID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
    }
}
    }
}

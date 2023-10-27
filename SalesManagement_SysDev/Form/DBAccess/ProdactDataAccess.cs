﻿using System;
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
        //引　数   ：顧客コード
        //戻り値   ：True or False
        //機　能   ：一致する顧客IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckProdactIDExistence(int prodactID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //部署CDで一致するデータが存在するか
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
        //引　数：regClient = 顧客データ
        //戻り値：True or False
        //機　能：顧客データの登録
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
    }
}

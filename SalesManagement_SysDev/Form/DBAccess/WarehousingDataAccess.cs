﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class WarehousingDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetWarehousingData()
        //引　数：なし
        //戻り値：入庫データ
        //機　能：入庫データの全取得
        ///////////////////////////////
        public List<T_Warehousing> GetWarehousingData()
        {
            List<T_Warehousing> listWarehousing = new List<T_Warehousing>();

            try
            {
                var context = new SalesManagement_DevContext();
                listWarehousing = context.T_Warehousings.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listWarehousing;
        }

        ///////////////////////////////
        //メソッド名：AddWarehousingData()
        //引　数：regWarehousing = 入庫データ
        //戻り値：True or False
        //機　能：入庫データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddWarehousingData(T_Warehousing regWarehousing)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Warehousings.Add(regWarehousing);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        ///////////////////////////////
        //メソッド名：GetWarehousingDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の入庫データ
        //機　能：管理Flgが表示の入庫データの全取得
        ///////////////////////////////
        public List<T_Warehousing> GetWarehousingDspData(List<T_Warehousing> dspWarehousing)
        {
            List<T_Warehousing> listWarehousing = new List<T_Warehousing>();

            try
            {
                listWarehousing = dspWarehousing.Where(x => x.WaFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listWarehousing;
        }

        ///////////////////////////////
        //メソッド名：GetWarehousingNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の入庫データ
        //機　能：管理Flgが非表示の入庫データの全取得
        ///////////////////////////////
        public List<T_Warehousing> GetWarehousingNotDspData(List<T_Warehousing> dspWarehousing)
        {
            List<T_Warehousing> listWarehousing = new List<T_Warehousing>();

            try
            {
                listWarehousing = dspWarehousing.Where(x => x.WaFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listWarehousing;
        }
        ///////////////////////////////
        //メソッド名：CheckWarehousingIDExistence()
        //引　数   ：入庫コード
        //戻り値   ：True or False
        //機　能   ：一致する入庫IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckWarehousingIDExistence(int WarehousingID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //部署CDで一致するデータが存在するか
                flg = context.T_Warehousings.Any(x => x.WaID == WarehousingID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckWarehousingEmployeeIDExistence()
        //引　数   ：社員ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する社員IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckWarehousingEmployeeIDExistence(int EmployeeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Warehousing> listWarehousing = context.T_Warehousings.Where(x => x.WaFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listWarehousing.Any(x => x.EmID == EmployeeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetAndWarehousingData()
        //引　数：検索条件
        //戻り値：条件完全一致発注データ
        //機　能：条件完全一致発注データの取得
        ///////////////////////////////
        public List<T_Warehousing> GetAndWarehousingData(T_Warehousing selectWarehousing)
        {
            List<T_Warehousing> listWarehousing= new List<T_Warehousing>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_Warehousings.AsQueryable();

                if (selectWarehousing.WaID != 0)
                {
                    query = query.Where(x => x.WaID == selectWarehousing.WaID);
                }

                if (selectWarehousing.HaID != 0)
                {
                    query = query.Where(x => x.HaID == selectWarehousing.HaID);
                }

                if (selectWarehousing.EmID != 0)
                {
                    query = query.Where(x => x.EmID == selectWarehousing.EmID);
                }

                if (selectWarehousing.WaDate != null)
                {
                    query = query.Where(x => x.WaDate.Value == selectWarehousing.WaDate.Value);
                }

                if (selectWarehousing.WaShelfFlag != -1)
                {
                    query = query.Where(x => x.WaShelfFlag == selectWarehousing.WaShelfFlag);
                }


                listWarehousing = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listWarehousing;
        }

        ///////////////////////////////
        //メソッド名：GetOrWarehousingData()
        //引　数：検索条件
        //戻り値：条件一部一致発注データ
        //機　能：条件一部一致うデータの取得
        ///////////////////////////////
        public List<T_Warehousing> GetOrWarehousingData(T_Warehousing selectWarehousing)
        {
            List<T_Warehousing> listWarehousing = new List<T_Warehousing>();
            try
            {
                var context = new SalesManagement_DevContext();

                listWarehousing = context.T_Warehousings.Where(x => x.WaID == selectWarehousing.WaID || x.EmID == selectWarehousing.EmID || x.HaID == selectWarehousing.HaID || x.WaDate.Value == selectWarehousing.WaDate.Value || x.WaShelfFlag == selectWarehousing.WaShelfFlag).ToList();

                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listWarehousing;
        }
        ///////////////////////////////
        //メソッド名：UpdateWarehousingData()
        //引　数：updWarehousing = 発注データ
        //戻り値：True or False
        //機　能：入庫データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateWarehousingData(T_Warehousing updWarehousing)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Warehousing = context.T_Warehousings.Single(x => x.WaID == updWarehousing.WaID);

                Warehousing.WaFlag = updWarehousing.WaFlag;
                Warehousing.WaHidden = updWarehousing.WaHidden;
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
        //メソッド名：GetIDWarehousingData()
        //引　数：入庫ID
        //戻り値：入庫IDの一致する入庫データ
        //機　能：入庫IDの一致する入庫データの取得
        ///////////////////////////////
        public T_Warehousing GetIDWarehousingData(int WarehousingID)
        {
            T_Warehousing Warehousing = new T_Warehousing { };

            try
            {
                var context = new SalesManagement_DevContext();
                Warehousing = context.T_Warehousings.Single(x => x.WaID == WarehousingID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Warehousing;
        }
        ///////////////////////////////
        //メソッド名：ConfirmWarehousingData()
        //引　数：cfmWarehousing = 入庫データ
        //戻り値：True or False
        //機　能：入庫データの確定
        //      ：確定成功の場合True
        //      ：確定失敗の場合False
        ///////////////////////////////
        public bool ConfirmWarehousingData(T_Warehousing cfmWarehousing)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Warehousing = context.T_Warehousings.Single(x => x.WaID == cfmWarehousing.WaID);

                Warehousing.WaShelfFlag = cfmWarehousing.WaShelfFlag;
                Warehousing.EmID = cfmWarehousing.EmID;
                Warehousing.WaDate = cfmWarehousing.WaDate;

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
        //メソッド名：WarehousingNum()
        //引　数：なし
        //戻り値：入庫件数
        //機　能：入庫データの件数
        ///////////////////////////////
        public int WarehousingNum()
        {
            var context = new SalesManagement_DevContext();

            //登録されている操作ログの件数取得
            int WarehousingCount = context.T_Warehousings.Count();

            return WarehousingCount;
        }
    }
}

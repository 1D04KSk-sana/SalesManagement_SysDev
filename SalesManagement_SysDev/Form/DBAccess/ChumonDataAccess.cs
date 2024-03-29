﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ChumonDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckChumonIDExistence()
        //引　数   ：社員ID
        //戻り値   ：True or False
        //機　能   ：一致する社員IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckChumonIDExistence(int ChumonID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //注文IDで一致するデータが存在するか
                flg = context.T_Chumons.Any(x => x.ChID == ChumonID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckChumonSalesOfficeIDExistence()
        //引　数   ：営業所ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する営業所IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckChumonSalesOfficeIDExistence(int SalesOfficeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Chumon> listChumon = context.T_Chumons.Where(x => x.ChFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listChumon.Any(x => x.SoID == SalesOfficeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckChumonEmployeeIDExistence()
        //引　数   ：社員ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する社員IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckChumonEmployeeIDExistence(int EmployeeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Chumon> listChumon = context.T_Chumons.Where(x => x.ChFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listChumon.Any(x => x.EmID == EmployeeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckChumonClientIDExistence()
        //引　数   ：顧客ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する顧客IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckChumonClientIDExistence(int ClientID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Chumon> listChumon = context.T_Chumons.Where(x => x.ChFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listChumon.Any(x => x.ClID == ClientID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetChumonData()
        //引　数：なし
        //戻り値：受注データ
        //機　能：受注データの全取得
        ///////////////////////////////
        public List<T_Chumon> GetChumonData()
        {
            List<T_Chumon> listChumon = new List<T_Chumon>();

            try
            {
                var context = new SalesManagement_DevContext();
                listChumon = context.T_Chumons.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listChumon;
        }

        ///////////////////////////////
        //メソッド名：GetIDOrderData()
        //引　数：受注ID
        //戻り値：受注IDの一致する注文データ
        //機　能：受注IDの一致する注文データの取得
        ///////////////////////////////
        public T_Chumon GetIDOrderData(int OrderID)
        {
            T_Chumon Chumon = new T_Chumon { };

            try
            {
                var context = new SalesManagement_DevContext();
                Chumon = context.T_Chumons.Single(x => x.OrID == OrderID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Chumon;
        }

        ///////////////////////////////
        //メソッド名：GetChumonDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の受注データ
        //機　能：管理Flgが表示の受注データの全取得
        ///////////////////////////////
        public List<T_Chumon> GetChumonDspData(List<T_Chumon> dspChumon)
        {
            List<T_Chumon> listChumon = new List<T_Chumon>();

            try
            {
                listChumon = dspChumon.Where(x => x.ChFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listChumon;
        }
        ///////////////////////////////
        //メソッド名：GetChumonNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の顧客データ
        //機　能：管理Flgが非表示の顧客データの全取得
        ///////////////////////////////
        public List<T_Chumon> GetChumonNotDspData(List<T_Chumon> dspChumon)
        {
            List<T_Chumon> listChumon = new List<T_Chumon>();

            try
            {
                listChumon = dspChumon.Where(x => x.ChFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listChumon;
        }

        ///////////////////////////////
        //メソッド名：GetAndChumonData()
        //引　数：検索条件
        //戻り値：条件完全一致受注データ
        //機　能：条件完全一致受注データの取得
        ///////////////////////////////
        public List<T_Chumon> GetAndChumonData(T_Chumon selectChumon)
        {
            List<T_Chumon> listChumon = new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_Chumons.AsQueryable();

                if (selectChumon.OrID != 0)
                {
                    query = query.Where(x => x.OrID == selectChumon.OrID);
                }

                if (selectChumon.SoID != 0)
                {
                    query = query.Where(x => x.SoID == selectChumon.SoID);
                }

                if ( selectChumon.ChID != 0)
                {
                    query = query.Where(x => x.ChID == selectChumon.ChID);
                }

                if ( selectChumon.ClID != 0)
                {
                    query = query.Where(x => x.ClID == selectChumon.ClID);
                }

                if (selectChumon.ChDate != null)
                {
                    query = query.Where(x => x.ChDate.Value == selectChumon.ChDate.Value);
                }

                if (selectChumon.ChStateFlag != -1)
                {
                    query = query.Where(x => x.ChStateFlag == selectChumon.ChStateFlag);
                }

                listChumon = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listChumon;
        }
        ///////////////////////////////
        //メソッド名：GetIDChumonData()
        //引　数：受注ID
        //戻り値：受注IDの一致する受注データ
        //機　能：受注IDの一致する受注データの取得
        ///////////////////////////////
        public T_Chumon GetIDChumonData(int ChumonID)
        {
            T_Chumon Chumon = new T_Chumon { };

            try
            {
                var context = new SalesManagement_DevContext();
                Chumon = context.T_Chumons.Single(x => x.ChID == ChumonID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Chumon;
        }
        ///////////////////////////////
        //メソッド名：ConfirmChumonData()
        //引　数：cfmOrder = 受注データ
        //戻り値：True or False
        //機　能：受注データの確定
        //      ：確定成功の場合True
        //      ：確定失敗の場合False
        ///////////////////////////////
        public bool ConfirmChumonData(T_Chumon cfmChumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Chumon = context.T_Chumons.Single(x => x.ChID == cfmChumon.ChID);

                Chumon.ChStateFlag = 1;
                Chumon.EmID = cfmChumon.EmID;

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
        //メソッド名：AddChumonData()
        //引　数：regChumon = 注文データ
        //戻り値：True or False
        //機　能：注文データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddChumonData(T_Chumon regChumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Chumons.Add(regChumon);
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
        //メソッド名：UpdateOrderData()
        //引　数：hidChumon = 受注データ
        //戻り値：True or False
        //機　能：受注データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateChumonData(T_Chumon hidChumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Chumon = context.T_Chumons.Single(x => x.ChID == hidChumon.ChID);

                Chumon.ChFlag = hidChumon.ChFlag;
                Chumon.ChHidden = hidChumon.ChHidden;

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
        //メソッド名：GetOrChumonData()
        //引　数：検索条件
        //戻り値：条件一部一致受注データ
        //機　能：条件一部一致受注データの取得
        ///////////////////////////////
        public List<T_Chumon> GetOrChumonData(T_Chumon selectChumon)
        {
            List<T_Chumon> listChumon = new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                listChumon = context.T_Chumons.Where(x => x.OrID == selectChumon.OrID || x.SoID == selectChumon.SoID || x.ChID == selectChumon.ChID || x.ClID == selectChumon.ClID|| x.ChDate.Value == selectChumon.ChDate.Value || x.ChStateFlag == selectChumon.ChStateFlag).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listChumon;
        }

        ///////////////////////////////
        //メソッド名：ChumonNum()
        //引　数：なし
        //戻り値：注文件数
        //機　能：注文データの件数
        ///////////////////////////////
        public int ChumonNum()
        {
            var context = new SalesManagement_DevContext();

            //登録されている操作ログの件数取得
            int ChumonCount = context.T_Chumons.Count();

            return ChumonCount;
        }
    }
}



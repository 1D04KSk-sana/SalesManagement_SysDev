﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ArrivalDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckArrivalIDExistence()
        //引　数   ：入荷コード
        //戻り値   ：True or False
        //機　能   ：一致する入荷IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckArrivalIDExistence(int ArrivalID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //部署CDで一致するデータが存在するか
                flg = context.T_Arrivals.Any(x => x.ArID == ArrivalID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckArrivalSalesOfficeIDExistence()
        //引　数   ：営業所ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する営業所IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckArrivalSalesOfficeIDExistence(int SalesOfficeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Arrival> listArrival = context.T_Arrivals.Where(x => x.ArFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listArrival.Any(x => x.SoID == SalesOfficeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckArrivalEmployeeIDExistence()
        //引　数   ：社員ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する社員IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckArrivalEmployeeIDExistence(int EmployeeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Arrival> listArrival = context.T_Arrivals.Where(x => x.ArFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listArrival.Any(x => x.EmID == EmployeeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckArrivalClientIDExistence()
        //引　数   ：顧客ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する顧客IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckArrivalClientIDExistence(int ClientID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Arrival> listArrival = context.T_Arrivals.Where(x => x.ArFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listArrival.Any(x => x.ClID == ClientID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetArrivalData()
        //引　数：なし
        //戻り値：入荷データ
        //機　能：入荷データの全取得
        ///////////////////////////////
        public List<T_Arrival> GetArrivalData()
        {
            List<T_Arrival> listArrival = new List<T_Arrival>();

            try
            {
                var context = new SalesManagement_DevContext();
                listArrival = context.T_Arrivals.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listArrival;
        }

        ///////////////////////////////
        //メソッド名：GetArrivalDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の入荷データ
        //機　能：管理Flgが表示の入荷データの全取得
        ///////////////////////////////
        public List<T_Arrival> GetArrivalDspData(List<T_Arrival> dspArrival)
        {
            List<T_Arrival> listArrival = new List<T_Arrival>();

            try
            {
                listArrival = dspArrival.Where(x => x.ArFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listArrival;
        }

        ///////////////////////////////
        //メソッド名：GetArrivalNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の入荷データ
        //機　能：管理Flgが非表示の入荷データの全取得
        ///////////////////////////////
        public List<T_Arrival> GetArrivalNotDspData(List<T_Arrival> dspArrival)
        {
            List<T_Arrival> listArrival = new List<T_Arrival>();

            try
            {
                listArrival = dspArrival.Where(x => x.ArFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listArrival;
        }

        ///////////////////////////////
        //メソッド名：GetAndArrivalData()
        //引　数：検索条件
        //戻り値：条件完全一致入荷データ
        //機　能：条件完全一致入荷データの取得
        ///////////////////////////////
        public List<T_Arrival> GetAndArrivalData(T_Arrival selectArrival)
        {
            List<T_Arrival> listArrival = new List<T_Arrival>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_Arrivals.AsQueryable();

                if (selectArrival.ArID != 0)
                {
                    query = query.Where(x => x.ArID == selectArrival.ArID);
                }

                if (selectArrival.OrID != 0)
                {
                    query = query.Where(x => x.OrID == selectArrival.OrID);
                }

                if (selectArrival.EmID != 0)
                {
                    query = query.Where(x => x.EmID == selectArrival.EmID);
                }
                if (selectArrival.SoID != 0)
                {
                    query = query.Where(x => x.SoID == selectArrival.SoID);
                }
                if (selectArrival.ClID != 0)
                {
                    query = query.Where(x => x.ClID == selectArrival.ClID);
                }

                if (selectArrival.ArDate != null)
                {
                    query = query.Where(x => x.ArDate.Value == selectArrival.ArDate.Value);
                }

                if (selectArrival.ArStateFlag != -1)
                {
                    query = query.Where(x => x.ArStateFlag == selectArrival.ArStateFlag);
                }

                listArrival = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listArrival;
        }

        ///////////////////////////////
        //メソッド名：GetOrArrivalData()
        //引　数：検索条件
        //戻り値：条件一部一致入荷データ
        //機　能：条件一部一致うデータの取得
        ///////////////////////////////
        public List<T_Arrival> GetOrArrivalData(T_Arrival selectArrival)
        {
            List<T_Arrival> listArrival = new List<T_Arrival>();
            try
            {
                var context = new SalesManagement_DevContext();

                listArrival = context.T_Arrivals.Where(x => x.ArID == selectArrival.ArID || x.EmID == selectArrival.EmID || x.OrID == selectArrival.OrID || x.SoID == selectArrival.SoID || x.ClID == selectArrival.ClID || x.ArDate.Value == selectArrival.ArDate.Value || x.ArStateFlag == selectArrival.ArStateFlag).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listArrival;
        }
        ///////////////////////////////
        //メソッド名：UpdateArrivalData()
        //引　数：updArrival = 入荷データ
        //戻り値：True or False
        //機　能：入荷データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateArrivalData(T_Arrival updArrival)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Warehousing = context.T_Arrivals.Single(x => x.ArID == updArrival.ArID);

                Warehousing.ArFlag = updArrival.ArFlag;
                Warehousing.ArHidden = updArrival.ArHidden;
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
        //メソッド名：GetIDArrivalData()
        //引　数：入荷ID
        //戻り値：入荷IDの一致する入荷データ
        //機　能：入荷IDの一致する入荷データの取得
        ///////////////////////////////
        public T_Arrival GetIDArrivalData(int ArrivalID)
        {
            T_Arrival Arrival = new T_Arrival { };

            try
            {
                var context = new SalesManagement_DevContext();
                Arrival = context.T_Arrivals.Single(x => x.ArID == ArrivalID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Arrival;
        }

        ///////////////////////////////
        //メソッド名：GetIDOrderData()
        //引　数：受注ID
        //戻り値：受注IDの一致する入荷データ
        //機　能：受注IDの一致する入荷データの取得
        ///////////////////////////////
        public T_Arrival GetIDOrderData(int OrderID)
        {
            T_Arrival Arrival = new T_Arrival { };

            try
            {
                var context = new SalesManagement_DevContext();
                Arrival = context.T_Arrivals.Single(x => x.OrID == OrderID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Arrival;
        }
        ///////////////////////////////
        //メソッド名：ConfirmArrivalData()
        //引　数：cfmArrival = 入荷データ
        //戻り値：True or False
        //機　能：入荷データの確定
        //      ：確定成功の場合True
        //      ：確定失敗の場合False
        ///////////////////////////////
        public bool ConfirmArrivalData(T_Arrival cfmArrival)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Arrival = context.T_Arrivals.Single(x => x.ArID == cfmArrival.ArID);

                Arrival.ArStateFlag = cfmArrival.ArStateFlag;
                Arrival.EmID = cfmArrival.EmID;
                Arrival.ArDate = cfmArrival.ArDate;
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
        //メソッド名：AddArrivalData()
        //引　数：regArrival = 入荷データ
        //戻り値：True or False
        //機　能：入荷データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddArrivalData(T_Arrival regArrival)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Arrivals.Add(regArrival);
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
        //メソッド名：ArrivalNum()
        //引　数：なし
        //戻り値：受注件数
        //機　能：受注データの件数
        ///////////////////////////////
        public int ArrivalNum()
        {
            var context = new SalesManagement_DevContext();

            //登録されている操作ログの件数取得
            int ArrivalCount = context.T_Arrivals.Count();

            return ArrivalCount;
        }
    }
}

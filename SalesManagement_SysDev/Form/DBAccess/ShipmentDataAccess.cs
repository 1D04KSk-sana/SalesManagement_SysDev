﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ShipmentDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckShipmentIDExistence()
        //引　数   ：受注コード
        //戻り値   ：True or False
        //機　能   ：一致する受注IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckShipmentIDExistence(int shipmentID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDで一致するデータが存在するか
                flg = context.T_Shipments.Any(x => x.ShID == shipmentID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckShipmenttSalesOfficeIDExistence()
        //引　数   ：営業所ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する営業所IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckShipmenttSalesOfficeIDExistence(int SalesOfficeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Shipment> listShipment = context.T_Shipments.Where(x => x.ShFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listShipment.Any(x => x.SoID == SalesOfficeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckShipmentEmployeeIDExistence()
        //引　数   ：社員ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する社員IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckShipmentEmployeeIDExistence(int EmployeeID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Shipment> listShipment = context.T_Shipments.Where(x => x.ShFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listShipment.Any(x => x.EmID == EmployeeID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckShipmentClientIDExistence()
        //引　数   ：顧客ID
        //戻り値   ：True or False
        //機　能   ：表示flg=0の中で一致する顧客IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckShipmentClientIDExistence(int ClientID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                List<T_Shipment> listShipment = context.T_Shipments.Where(x => x.ShFlag == 0).ToList();

                //部署CDで一致するデータが存在するか
                flg = listShipment.Any(x => x.ClID == ClientID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：GetShipmentData()
        //引　数：なし
        //戻り値：受注データ
        //機　能：受注データの全取得
        ///////////////////////////////
        public List<T_Shipment> GetShipmentData()
        {
            List<T_Shipment> listShipment = new List<T_Shipment>();

            try
            {
                var context = new SalesManagement_DevContext();
                listShipment = context.T_Shipments.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listShipment;
        }

        ///////////////////////////////
        //メソッド名：GetShipmentDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の受注データ
        //機　能：管理Flgが表示の受注データの全取得
        ///////////////////////////////
        public List<T_Shipment> GetShipmentDspData(List<T_Shipment> dspShipment)
        {
            List<T_Shipment> listShipment = new List<T_Shipment>();

            try
            {
                listShipment = dspShipment.Where(x => x.ShFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listShipment;
        }

        ///////////////////////////////
        //メソッド名：GetShipmentNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の受注データ
        //機　能：管理Flgが非表示の受注データの全取得
        ///////////////////////////////
        public List<T_Shipment> GetShipmentNotDspData(List<T_Shipment> dspShipment)
        {
            List<T_Shipment> listShipment = new List<T_Shipment>();

            try
            {
                listShipment = dspShipment.Where(x => x.ShFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listShipment;
        }

        ///////////////////////////////
        //メソッド名：UpdateShipmentData()
        //引　数：updShipment = 受注データ
        //戻り値：True or False
        //機　能：受注データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateShipmentData(T_Shipment updShipment)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Shipment = context.T_Shipments.Single(x => x.ShID == updShipment.ShID);

                Shipment.ShFlag = updShipment.ShFlag;
                Shipment.ShHidden = updShipment.ShHidden;

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
        //メソッド名：GetAndShipmentData()
        //引　数：検索条件
        //戻り値：条件完全一致受注データ
        //機　能：条件完全一致受注データの取得
        ///////////////////////////////
        public List<T_Shipment> GetAndShipmentData(T_Shipment selectShipment)
        {
            List<T_Shipment> listShipment = new List<T_Shipment>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.T_Shipments.AsQueryable();

                if (selectShipment.ShID != 0)
                {
                    query = query.Where(x => x.ShID == selectShipment.ShID);
                }

                if ( selectShipment.OrID != 0)
                {
                    query = query.Where(x => x.OrID == selectShipment.OrID);
                }

                if (selectShipment.EmID != 0)
                {
                    query = query.Where(x => x.EmID == selectShipment.EmID);
                }

                if (selectShipment.ClID != 0)
                {
                    query = query.Where(x => x.ClID == selectShipment.ClID);
                }

                if (selectShipment.ShFinishDate != null)
                {
                    query = query.Where(x => x.ShFinishDate.Value == selectShipment.ShFinishDate.Value);
                }

                if (selectShipment.ShStateFlag != -1)
                {
                    query = query.Where(x => x.ShStateFlag == selectShipment.ShStateFlag);
                }

                listShipment = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listShipment;
        }

        ///////////////////////////////
        //メソッド名：GetOrShipmentData()
        //引　数：検索条件
        //戻り値：条件一部一致受注データ
        //機　能：条件一部一致受注データの取得
        ///////////////////////////////
        public List<T_Shipment> GetOrShipmentData(T_Shipment selectShipment)
        {
            List<T_Shipment> listShipment = new List<T_Shipment>();
            try
            {
                var context = new SalesManagement_DevContext();
                listShipment = context.T_Shipments.Where(x => x.ShID == selectShipment.ShID || x.OrID == selectShipment.OrID || x.EmID == selectShipment.EmID || x.ClID == selectShipment.ClID || x.ShFinishDate.Value == selectShipment.ShFinishDate.Value || x.ShStateFlag == selectShipment.ShStateFlag).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listShipment;
        }

        ///////////////////////////////
        //メソッド名：AddShipmentData()
        //引　数：regShipment = 入荷データ
        //戻り値：True or False
        //機　能：入荷データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddShipmentData(T_Shipment regShipment)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Shipments.Add(regShipment);
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
        //メソッド名：GetIDShipmentData()
        //引　数：出荷ID
        //戻り値：出荷IDの一致する出荷データ
        //機　能：出荷IDの一致する出荷データの取得
        ///////////////////////////////
        public T_Shipment GetIDShipmentData(int shipmentID)
        {
            T_Shipment Shipment = new T_Shipment { };

            try
            {
                var context = new SalesManagement_DevContext();
                Shipment = context.T_Shipments.Single(x => x.ShID == shipmentID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Shipment;
        }

        ///////////////////////////////
        //メソッド名：GetIDOrderData()
        //引　数：受注ID
        //戻り値：受注IDの一致する入荷データ
        //機　能：受注IDの一致する入荷データの取得
        ///////////////////////////////
        public T_Shipment GetIDOrderData(int OrderID)
        {
            T_Shipment Shipment = new T_Shipment { };

            try
            {
                var context = new SalesManagement_DevContext();
                Shipment = context.T_Shipments.Single(x => x.OrID == OrderID);

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Shipment;
        }

        ///////////////////////////////
        //メソッド名：ConfirmShipmentData()
        //引　数：出荷データ
        //戻り値：True or False
        //機　能：出荷データの確定
        //      ：確定成功の場合True
        //      ：確定失敗の場合False
        ///////////////////////////////
        public bool ConfirmShipmentData(T_Shipment cfmShipment)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Shipment = context.T_Shipments.Single(x => x.ShID == cfmShipment.ShID);

                Shipment.ShStateFlag = cfmShipment.ShStateFlag;
                Shipment.ShFinishDate = cfmShipment.ShFinishDate;
                Shipment.EmID = cfmShipment.EmID;

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
        //メソッド名：ShipmentNum()
        //引　数：なし
        //戻り値：受注件数
        //機　能：受注データの件数
        ///////////////////////////////
        public int ShipmentNum()
        {
            var context = new SalesManagement_DevContext();

            //登録されている操作ログの件数取得
            int ShipmentCount = context.T_Shipments.Count();

            return ShipmentCount;
        }
    }
}

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
        public List<T_Shipment> GetShipmentDspData(List<T_Shipment> dspOrder)
        {
            List<T_Shipment> listOrder = new List<T_Shipment>();

            try
            {
                listOrder = dspOrder.Where(x => x.ShFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }

        ///////////////////////////////
        //メソッド名：GetShipmentNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の受注データ
        //機　能：管理Flgが非表示の受注データの全取得
        ///////////////////////////////
        public List<T_Shipment> GetShipmentNotDspData(List<T_Shipment> dspOrder)
        {
            List<T_Shipment> listOrder = new List<T_Shipment>();

            try
            {
                listOrder = dspOrder.Where(x => x.ShFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }

        ///////////////////////////////
        //メソッド名：UpdateOrderData()
        //引　数：updOrder = 受注データ
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

                updShipment.ShFlag = updShipment.ShFlag;
                updShipment.ShHidden = updShipment.ShHidden;

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
        //メソッド名：GetAndOrderData()
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

                if (selectShipment.ShID != null && selectShipment.ShID != 0)
                {
                    query = query.Where(x => x.ShID == selectShipment.ShID);
                }

                if (selectShipment.OrID != null && selectShipment.OrID != 0)
                {
                    query = query.Where(x => x.OrID == selectShipment.OrID);
                }

                if (selectShipment.EmID != null && selectShipment.EmID != 0)
                {
                    query = query.Where(x => x.EmID == selectShipment.EmID);
                }

                if (selectShipment.ClID != null && selectShipment.ClID != 0)
                {
                    query = query.Where(x => x.ClID == selectShipment.ClID);
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
        //メソッド名：GetOrOrderData()
        //引　数：検索条件
        //戻り値：条件一部一致受注データ
        //機　能：条件一部一致受注データの取得
        ///////////////////////////////
        public List<T_Shipment> GetOrShipmentData(T_Shipment selectOrder)
        {
            List<T_Shipment> listOrder = new List<T_Shipment>();
            try
            {
                var context = new SalesManagement_DevContext();
                listOrder = context.T_Shipments.Where(x => x.ShID == selectOrder.ShID || x.OrID == selectOrder.OrID || x.EmID == selectOrder.EmID || x.ClID == selectOrder.ClID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listOrder;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ClientDataAccess
    {
        ///////////////////////////////
        //メソッド名：CheckClientIDExistence()
        //引　数   ：顧客コード
        //戻り値   ：True or False
        //機　能   ：一致する顧客IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckClientIDExistence(int clientID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //部署CDで一致するデータが存在するか
                flg = context.M_Clients.Any(x => x.ClID == clientID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddClientData()
        //引　数：regClient = 顧客データ
        //戻り値：True or False
        //機　能：顧客データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddClientData(M_Client regClient)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Clients.Add(regClient);
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
        //引　数：updClient = 顧客データ
        //戻り値：True or False
        //機　能：顧客データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateClientData(M_Client updClient)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Client = context.M_Clients.Single(x => x.ClID == updClient.ClID);

                Client.ClName = updClient.ClName;
                Client.ClFlag = updClient.ClFlag;
                Client.ClHidden = updClient.ClHidden;
                Client.ClFAX = updClient.ClFAX;
                Client.ClPhone = updClient.ClPhone;
                Client.ClAddress = updClient.ClAddress;
                Client.SoID = updClient.SoID;
                Client.ClPostal = updClient.ClPostal;

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
        //メソッド名：DeleteClientData()
        //引　数：delClient = 顧客データ
        //戻り値：True or False
        //機　能：顧客データの削除
        //      ：削除成功の場合True
        //      ：削除失敗の場合False
        ///////////////////////////////
        public bool DeleteClientData(M_Client delClient)
        {
            return true;
        }

        ///////////////////////////////
        //メソッド名：GetClientData()
        //引　数：なし
        //戻り値：顧客データ
        //機　能：顧客データの全取得
        ///////////////////////////////
        public List<M_Client> GetClientData()
        {
            List<M_Client> listClient = new List<M_Client>();

            try
            {
                var context = new SalesManagement_DevContext();
                listClient = context.M_Clients.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listClient;
        }

        ///////////////////////////////
        //メソッド名：GetClientData()　オーバーロード
        //引　数：検索条件
        //戻り値：条件一致顧客データ
        //機　能：条件一致顧客データの取得
        ///////////////////////////////
        public List<M_Client> GetClientData(M_Client selectClient)
        {
            List<M_Client> listClient = new List<M_Client>();

            return listClient;
        }
    }
}

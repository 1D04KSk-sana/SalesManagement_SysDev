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
        //メソッド名：AddClientData()
        //引　数：regClient = 顧客データ
        //戻り値：True or False
        //機　能：顧客データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddClientData(M_Client regClient)
        {
            return true;
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
            return true;
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

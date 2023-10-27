using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SalesOfficeDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetSalesOfficeDspData()
        //引　数   ：なし
        //戻り値   ：表示用営業所データ
        //機　能   ：表示用営業所データの取得
        ///////////////////////////////
        public List<M_SalesOffice> GetSalesOfficeDspData()
        {
            List<M_SalesOffice> listSalesOffice = new List<M_SalesOffice>();
            //try
            //{
                var context = new SalesManagement_DevContext();
                listSalesOffice = context.M_SalesOffices.Where(x => x.SoFlag == 0).ToList();
                context.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            return listSalesOffice;
        }
    }
}

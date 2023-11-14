using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetSyukkoDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の商品データ
        //機　能：管理Flgが表示の商品データの全取得
        ///////////////////////////////
        public List<T_Syukko> GetSyukkoDspData()
        {
            List<T_Syukko> listSyukko = new List<T_Syukko>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSyukko = context.T_Syukkos.Where(x => x.SyFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSyukko;
        }

        ///////////////////////////////
        //メソッド名：GetSyukkotNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の商品データ
        //機　能：管理Flgが非表示の商品データの全取得
        ///////////////////////////////
        public List<T_Syukko> GetSyukkoNotDspData(List<T_Syukko> dspClient)
        {
            List<T_Syukko> listProdact = new List<T_Syukko>();

            try
            {
                listProdact = dspClient.Where(x => x.SyFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }
    }
}

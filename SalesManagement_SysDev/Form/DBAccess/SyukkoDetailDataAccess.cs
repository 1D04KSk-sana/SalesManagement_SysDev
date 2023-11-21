using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDetailDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetSyukkoDetailtDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の商品データ
        //機　能：管理Flgが表示の商品データの全取得
        ///////////////////////////////
        public List<T_SyukkoDetail> GetSyukkoDetailtDspData(List<T_SyukkoDetail> dspProdact)
        {
            List<T_SyukkoDetail> listProdact = new List<T_SyukkoDetail>();

            try
            {
                listProdact = dspProdact.Where(x => x.SyDetailID == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }

        ///////////////////////////////
        //メソッド名：GetSyukkotNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の商品データ
        //機　能：管理Flgが非表示の商品データの全取得
        ///////////////////////////////
        public List<T_SyukkoDetail> GetSyukkoDetailNotDspData(List<T_SyukkoDetail> dspClient)
        {
            List<T_SyukkoDetail> listProdact = new List<T_SyukkoDetail>();

            try
            {
                listProdact = dspClient.Where(x => x.SyDetailID == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listProdact;
        }
    }
}

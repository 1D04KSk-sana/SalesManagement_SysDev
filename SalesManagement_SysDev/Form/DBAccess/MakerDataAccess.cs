using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class MakerDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetMakerDspData()　　※オーバーロード
        //引　数：なし
        //戻り値：管理Flgが表示のメーカーデータ
        //機　能：管理Flgが表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_Maker> GetMakerDspData(List<M_Maker> dspMaker)
        {
            List<M_Maker> listMaker = new List<M_Maker>();

            try
            {
                listMaker = dspMaker.Where(x => x.MaFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
        ///////////////////////////////
        //メソッド名：GetSalesOfficeDspData()
        //引　数   ：なし
        //戻り値   ：表示用メーカーデータ
        //機　能   ：表示用メーカーデータの取得
        ///////////////////////////////
        public List<M_Maker> GetMakerDspData()
        {
            List<M_Maker> listMaker = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                listMaker = context.M_Makers.Where(x => x.MaFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
        ///////////////////////////////
        //メソッド名：GetMakerNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示のメーカーデータ
        //機　能：管理Flgが非表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_Maker> GetMakerNotDspData(List<M_Maker> dspMaker)
        {
            List<M_Maker> listMaker = new List<M_Maker>();

            try
            {
                listMaker = dspMaker.Where(x => x.MaFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
        ///////////////////////////////
        //メソッド名：GetMakerData()
        //引　数：なし
        //戻り値：メーカーデータ
        //機　能：メーカーデータの全取得
        ///////////////////////////////
        public List<M_Maker> GetMakerData()
        {
            List<M_Maker> listMaker = new List<M_Maker>();

            try
            {
                var context = new SalesManagement_DevContext();
                listMaker = context.M_Makers.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
        ///////////////////////////////
        //メソッド名：GetMakerIDData()
        //引　数：メーカーID
        //戻り値：メーカーデータ
        //機　能：メーカーデータの全取得
        ///////////////////////////////
        public M_Maker GetMakerIDData(int makerID)
        {
            M_Maker Maker = null;

            try
            {
                var context = new SalesManagement_DevContext();
                Maker = context.M_Makers.Single(x => x.MaID == makerID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Maker;
        }
        ///////////////////////////////
        //メソッド名：CheckMakerIDExistence()
        //引　数   ：メーカーコード
        //戻り値   ：True or False
        //機　能   ：一致するメーカーIDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckMakerIDExistence(int MakerID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //メーカーIDで一致するデータが存在するか
                flg = context.M_Makers.Any(x => x.MaID == MakerID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        ///////////////////////////////
        //メソッド名：CheckMakerNameExistence()
        //引　数   ：メーカーコード
        //戻り値   ：True or False
        //機　能   ：一致するメーカー名の有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckMakerNameExistence(string MakerName)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //営業所IDで一致するデータが存在するか
                flg = context.M_Makers.Any(x => x.MaName == MakerName);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        ///////////////////////////////
        //メソッド名：AddMakerData()
        //引　数：regMaker = メーカーデータ
        //戻り値：True or False
        //機　能：メーカーデータの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddMakerData(M_Maker regMaker)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Makers.Add(regMaker);
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
        //メソッド名：UpdateMakerData()
        //引　数：updMaker = メーカーデータ
        //戻り値：True or False
        //機　能：メーカーデータの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateMakerData(M_Maker updMaker)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Maker = context.M_Makers.Single(x => x.MaID == updMaker.MaID);

                Maker.MaName = updMaker.MaName;
                Maker.MaFlag = updMaker.MaFlag;
                Maker.MaHidden = updMaker.MaHidden;
                Maker.MaFAX = updMaker.MaFAX;
                Maker.MaPhone = updMaker.MaPhone;
                Maker.MaAddress = updMaker.MaAddress;
                Maker.MaPostal = updMaker.MaPostal;

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
        //メソッド名：GetAndMakerData()
        //引　数：検索条件
        //戻り値：条件完全一致メーカーデータ
        //機　能：条件完全一致メーカーデータの取得
        ///////////////////////////////
        public List<M_Maker> GetAndMakerData(M_Maker selectMaker)
        {
            List<M_Maker> listMaker = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.M_Makers.AsQueryable();

                if (selectMaker.MaID != 0)
                {
                    query = query.Where(x => x.MaID == selectMaker.MaID);
                }
                if (selectMaker.MaPhone != null && selectMaker.MaPhone != "")
                {
                    query = query.Where(x => x.MaPhone == selectMaker.MaPhone);
                }

                listMaker = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
        ///////////////////////////////
        //メソッド名：GetOrMakerData()
        //引　数：検索条件
        //戻り値：条件一部一メーカーデータ
        //機　能：条件一部一致メーカーデータの取得
        ///////////////////////////////
        public List<M_Maker> GetOrMakerData(M_Maker selectMaker)
        {
            List<M_Maker> listMaker = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                listMaker = context.M_Makers.Where(x => x.MaID == selectMaker.MaID || x.MaPhone == selectMaker.MaPhone).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listMaker;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SmallDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetSmallDspData()
        //引　数   ：なし
        //戻り値   ：表示用小分類名データ
        //機　能   ：表示用小分類名データの取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallClassificationDspData()
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                listSmall = context.M_SmallClassifications.Where(x => x.ScFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：GetSmallData()
        //引　数：なし
        //戻り値：大分類データ
        //機　能：大分類データの全取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallData()
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSmall = context.M_SmallClassifications.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：GetSmallDspData()　　※オーバーロード
        //引　数：なし
        //戻り値：管理Flgが表示のメーカーデータ
        //機　能：管理Flgが表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallDspData(List<M_SmallClassification> dspSmall)
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();

            try
            {
                listSmall = dspSmall.Where(x => x.ScFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：GetSmallNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示のメーカーデータ
        //機　能：管理Flgが非表示のメーカーデータの全取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallNotDspData(List<M_SmallClassification> dspSmall)
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();

            try
            {
                listSmall = dspSmall.Where(x => x.ScFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：CheckMakerIDExistence()
        //引　数   ：メーカーコード
        //戻り値   ：True or False
        //機　能   ：一致するメーカーIDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckSmallIDExistence(int SmallID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //大分類IDで一致するデータが存在するか
                flg = context.M_SmallClassifications.Any(x => x.ScID == SmallID);
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
        public bool CheckSmallNameExistence(string SmallName)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //営業所IDで一致するデータが存在するか
                flg = context.M_SmallClassifications.Any(x => x.ScName == SmallName);
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
        public bool AddSmallData(M_SmallClassification regSmall)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_SmallClassifications.Add(regSmall);
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
        public bool UpdateSmallData(M_SmallClassification updSmall)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Small = context.M_SmallClassifications.Single(x => x.ScID == updSmall.ScID);

                Small.ScName = updSmall.ScName;
                Small.ScFlag = updSmall.ScFlag;
                Small.ScHidden = updSmall.ScHidden;
                Small.ScID = updSmall.ScID;

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
        //メソッド名：UpdateHiddenMakerData()
        //引　数：大分類ID
        //戻り値：True or False
        //機　能：メーカーデータの非表示更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateHiddenMakerData(int MajorID)
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();

            try
            {
                var context = new SalesManagement_DevContext();
                
                listSmall = context.M_SmallClassifications.Where(x => x.McID == MajorID).ToList();

                int smallcount = listSmall.Count();

                for (int i = 1; i <= smallcount; i++)
                {
                    var Small = context.M_SmallClassifications.Single(x => x.McID == MajorID && x.ScID == i);

                    Small.ScFlag = 1;

                    context.SaveChanges();
                }

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
        public List<M_SmallClassification> GetAndSmallData(M_SmallClassification selectSmall)
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.M_SmallClassifications.AsQueryable();

                if (selectSmall.ScID != 0)
                {
                    query = query.Where(x => x.ScID == selectSmall.ScID);
                }
                if (selectSmall.ScName == null)
                {
                    query = query.Where(x => x.ScName == selectSmall.ScName);
                }

                listSmall = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：GetOrMakerData()
        //引　数：検索条件
        //戻り値：条件一部一メーカーデータ
        //機　能：条件一部一致メーカーデータの取得
        ///////////////////////////////
        public List<M_SmallClassification> GetOrSmallData(M_SmallClassification selectSmall)
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                listSmall = context.M_SmallClassifications.Where(x => x.ScID == selectSmall.ScID && x.ScName == selectSmall.ScName).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
        ///////////////////////////////
        //メソッド名：GetSaleDetailIDData()
        //引　数：なし
        //戻り値：受注詳細データ
        //機　能：受注詳細データの全取得
        ///////////////////////////////
        public List<M_SmallClassification> GetSmallIDData(int MajorID)
        {
            List<M_SmallClassification> listSmall = new List<M_SmallClassification>();

            try
            {
                var context = new SalesManagement_DevContext();
                listSmall = context.M_SmallClassifications.Where(x => x.McID == MajorID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listSmall;
        }
    }
}

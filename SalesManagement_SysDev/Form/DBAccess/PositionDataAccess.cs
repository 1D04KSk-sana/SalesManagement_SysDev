using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SalesManagement_SysDev
{
    class PositionDataAccess
    {
        ///////////////////////////////
        //メソッド名：GetPositionIDData()
        //引　数：役職ID
        //戻り値：役職データ
        //機　能：役職データの全取得
        ///////////////////////////////
        public M_Position GetPositionIDData(int positionID)
        {
            M_Position Position = null;

            try
            {
                var context = new SalesManagement_DevContext();
                Position = context.M_Positions.Single(x => x.PoID == positionID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Position;
        }
        ///////////////////////////////
        //メソッド名：GetPositionDspData()
        //引　数：なし
        //戻り値：管理Flgが表示の顧客データ
        //機　能：管理Flgが表示の顧客データの全取得
        ///////////////////////////////
        public List<M_Position> GetPositionDspData()
        {
            List<M_Position> listPosition = new List<M_Position>();

            try
            {
                var context = new SalesManagement_DevContext();
                listPosition = context.M_Positions.Where(x => x.PoFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listPosition;
        }

        ///////////////////////////////
        //メソッド名：GetPositionDspData()　　※オーバーロード
        //引　数：なし
        //戻り値：管理Flgが表示の顧客データ
        //機　能：管理Flgが表示の顧客データの全取得
        ///////////////////////////////
        public List<M_Position> GetPositionDspData(List<M_Position> dspPosition)
        {
            List<M_Position> listPosition = new List<M_Position>();

            try
            {
                listPosition = dspPosition.Where(x => x.PoFlag == 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listPosition;
        }
        ///////////////////////////////
        //メソッド名：GetPositionNotDspData()
        //引　数：なし
        //戻り値：管理Flgが非表示の顧客データ
        //機　能：管理Flgが非表示の顧客データの全取得
        ///////////////////////////////
        public List<M_Position> GetPositionNotDspData(List<M_Position> dspPosition)
        {
            List<M_Position> listPosition = new List<M_Position>();

            try
            {
                listPosition = dspPosition.Where(x => x.PoFlag == 1).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listPosition;
        }
        ///////////////////////////////
        //メソッド名：GetPositionData()
        //引　数：なし
        //戻り値：役職データ
        //機　能：役職データの全取得
        ///////////////////////////////
        public List<M_Position> GetPositionData()
        {
            List<M_Position> listPosition = new List<M_Position>();

            try
            {
                var context = new SalesManagement_DevContext();
                listPosition = context.M_Positions.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listPosition;
        }

        ///////////////////////////////
        //メソッド名：CheckPositionIDExistence()
        //引　数   ：顧客コード
        //戻り値   ：True or False
        //機　能   ：一致する顧客IDの有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckPositionIDExistence(int positionID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDで一致するデータが存在するか
                flg = context.M_Positions.Any(x => x.PoID == positionID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：UpdatePositionData()
        //引　数：updPosition = 役職データ
        //戻り値：True or False
        //機　能：役職データの更新
        //      ：更新成功の場合True
        //      ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdatePositionData(M_Position updPosition)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Position = context.M_Positions.Single(x => x.PoID == updPosition.PoID);

                Position.PoName = updPosition.PoName;
                Position.PoFlag = updPosition.PoFlag;
                Position.PoHidden = updPosition.PoHidden;

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
        //メソッド名：AddPositionData()
        //引　数：regPosition = 顧客データ
        //戻り値：True or False
        //機　能：役職データの登録
        //      ：登録成功の場合True
        //      ：登録失敗の場合False
        ///////////////////////////////
        public bool AddPositionData(M_Position regPosition)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Positions.Add(regPosition);
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
        //メソッド名：GetAndPositionData()
        //引　数：検索条件
        //戻り値：条件完全一致顧客データ
        //機　能：条件完全一致顧客データの取得
        ///////////////////////////////
        public List<M_Position> GetAndPositionData(M_Position selectPosition)
        {
            List<M_Position> listPoition = new List<M_Position>();
            try
            {
                var context = new SalesManagement_DevContext();
                var query = context.M_Positions.AsQueryable();

                if (selectPosition.PoID != null && selectPosition.PoID != 0)
                {
                    query = query.Where(x => x.PoID == selectPosition.PoID);
                }



                listPoition = query.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listPoition;
        }

        ///////////////////////////////
        //メソッド名：GetOrPositionData()
        //引　数：検索条件
        //戻り値：条件一部一致顧客データ
        //機　能：条件一部一致顧客データの取得
        ///////////////////////////////
        public List<M_Position> GetOrPositionData(M_Position selectPosition)
        {
            List<M_Position> listPosition = new List<M_Position>();
            try
            {
                var context = new SalesManagement_DevContext();
                listPosition = context.M_Positions.Where(x => x.PoID == selectPosition.PoID).ToList();

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listPosition;
        }
        ///////////////////////////////
        //メソッド名：CheckPositionNameExistence()
        //引　数   ：役職コード
        //戻り値   ：True or False
        //機　能   ：一致する役職名の有無を確認
        //          ：一致データありの場合True
        //          ：一致データなしの場合False
        ///////////////////////////////
        public bool CheckPositionNameExistence(string PositionName)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //役職IDで一致するデータが存在するか
                flg = context.M_Positions.Any(x => x.PoName == PositionName);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
    }
}

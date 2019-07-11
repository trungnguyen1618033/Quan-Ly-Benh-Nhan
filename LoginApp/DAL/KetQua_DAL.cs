using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class KetQua_DAL 
    {
        private static KetQua_DAL instance;

        public static KetQua_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KetQua_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public bool AddKetQua( int MaLK, string KQ)
        {
            string query = "Exec AddKetQua @MALANKHAM , @KETQUA";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  MaLK , KQ});
            return result > 0;
        }
        public bool DeleteKetQua(int MaKQ)
        {
            string query = "Exec DeleteKetQua @MAKETQUA";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { MaKQ });
            return result > 0;
        }
        public bool UpdateKetQua(int MaKQ,  int MaLK, string KQ)
        {
            string query = "Exec UpdateKetQua @MAKETQUA ,  @KETQUA , @MALANKHAM ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaKQ, MaLK, KQ });
            return result > 0;
        }
        public DataTable GetListKetQua()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListKetQua");
        }

        public DataTable GetListKetQuaByKetQua(int id ,string ketqua)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListKetQuaByKetQua @id , @KETQUA", new object[] {id, ketqua });
        }
        public DataTable GetListKetQuaByLanKhamID(int LanKhamID)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListKetQuaByLanKhamID @LanKhamID", new object[] { LanKhamID});
        }
        public DataTable GetListKetQuaByBenhNhanID(int id)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListKetQuaByBenhNhanID @id", new object[] { id});
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ToaThuoc_DAL 
    {
        private static ToaThuoc_DAL instance;

        public static ToaThuoc_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ToaThuoc_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public bool AddToaThuoc( int KetQua, int SoNgay)
        {
            string query = "Exec AddToaThuoc @MALANKHAM , @SONGAY";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { KetQua, SoNgay});
            return result > 0;
        }
        public bool DeleteToaThuoc(int MaKetQua)
        {
            string query = "Exec DeleteToaThuoc @MAKETQUA";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaKetQua });
            return result > 0;
        }
        public bool UpdateToaThuoc(int MaToaThuoc, int MaKetQua, int SoNgay)
        {
            string query = "Exec UpdateToaThuoc @MAKETQUA , @MALANKHAM , @SONGAY";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaToaThuoc, MaKetQua, SoNgay });
            return result > 0;
        }

        public DataTable GetListToaThuoc()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListToaThuoc");
        }
        public DataTable GetListToaThuocByLanKhamID(int LanKhamID)      
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListToaThuocByL");
        }

        public DataTable GetListToaThuocByBenhNhanID(int id)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListToaThuocByBenhNhanID @id", new object[] { id });
        }

        public DataTable GetListToaThuocByTenBenhNhan(string name)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListToaThuocByTenBenhNhan @TEN", new object[] { name });
        }
    }
}

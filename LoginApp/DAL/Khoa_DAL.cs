using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Khoa_DAL 
    {
        private static Khoa_DAL instance;

        public static Khoa_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Khoa_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public Khoa GetLoaiKhoaByID(int id)
        {
            Khoa khoa = null;

            string query = "EXEC GetListKhoa";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                khoa = new Khoa(item);
                return khoa;
            }

            return khoa;

        }

        public bool AddKhoa( string TenKhoa)
        {
            string query = "Exec AddKhoa @TENKHOA";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenKhoa });
            return result > 0;
        }
        public bool DeleteKhoa(int MaKhoa)
        {
            string query = "Exec DeleteKhoa @MAKHOA ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaKhoa });
            return result > 0;
        }
        public bool UpdateKhoa(int MaKhoa, string TenKhoa)
        {
            string query = "Exec UpdateKhoa @MAKHOA , @TENKHOA";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaKhoa, TenKhoa });
            return result > 0;
        }
        
        public DataTable GetListKhoa()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListKhoa");
        }
        
    }
}

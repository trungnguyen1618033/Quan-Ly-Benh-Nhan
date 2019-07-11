using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Thuoc_DAL 
    {
        private static Thuoc_DAL instance;

        public static Thuoc_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Thuoc_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public DataTable GetListThuoc()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC GetListThuoc");
        }

        public DataTable GetListThuocByTen(string ten)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC GetListThuocByTen @TEN", new object[] { ten });
        }

        public bool AddThuoc(string tt, int dongia, int soluong)
        {
            string query = "EXEC AddThuoc @TENTHUOC , @DONGIA , @SOLUONG";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {tt, dongia, soluong});
            return result > 0;
        }



        public bool UpdateThuoc(int mt, string tt, int dongia, int soluong)
        {
            string query = "EXEC UpdateThuoc @MATHUOC , @TENTHUOC , @DONGIA , @SOLUONG";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mt, tt, dongia, soluong});
            return result > 0;
        }

        public bool DeleteThuoc(int mt)
        {
            string query = "EXEC DeleteThuoc @MATHUOC";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mt});
            return result > 0;
        }
    }
}

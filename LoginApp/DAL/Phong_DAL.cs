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
    public class Phong_DAL 
    {
        private static Phong_DAL instance;

        public static Phong_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Phong_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

      
        public bool AddPhong( int SoGiuong, int MaLoaiPhong)
        {
            string query = "EXEC AddPhong @SOGIUONG , @MALOAIPHONG";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  SoGiuong, MaLoaiPhong});

            return result > 0;
        }
        public bool DeletePhong(int MaPhong)
        {
            string query = "Exec DeletePhong @MAPHONG";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhong });
            return result > 0;
        }

        public bool UpdatePhong(int MaPhong, int SoGiuong, int MaLoaiPhong)
        {
            string query = "Exec UpdatePhong @MAPHONG , @SOGIUONG , @MALOAIPHONG";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhong, SoGiuong, MaLoaiPhong });

            return result > 0;
        }

        public DataTable GetListPhong()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListPhong");
        }
     
        public DataTable GetLisPhongByLoaiPhongID(int id)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListPhongByLoaiPhongID @id", new object[] { id });
        }

    }
}

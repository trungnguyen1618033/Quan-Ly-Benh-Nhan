using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class LanKham_DAL 
    {
        private static LanKham_DAL instance;

        public static LanKham_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LanKham_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private LanKham_DAL()
        { }
      

        public bool AddLanKham( int MaBenhNhan, int MaKhoa, DateTime NgayKham)
        {
            string query = "Exec AddLanKham @MABENHNHAN , @MAKHOA , @NGAYKHAM ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaBenhNhan, MaKhoa, NgayKham });
            return result > 0;
        }
        public bool DeleteLanKham(int MaLanKham)
        {
            string query = "Exec DeleteLanKham @MALANKHAM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLanKham });
            return result > 0;
        }
        public bool UpdateLanKham(int MaLanKham, int MaBenhNhan, int MaKhoa, DateTime NgayKham, string TinhTrang)
        {
            string query = "Exec UpdateLanKham @MALANKHAM , @MABENHNHAN , @MAKHOA , @NGAYKHAM , @TINHTRANG";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLanKham, MaBenhNhan, MaKhoa, NgayKham, TinhTrang });
            return result > 0;
        }

        public bool UpdateTinhTrangLanKham(int MaLanKham)
        {
            string query = "Exec UpdateTinhTrangLanKham @MALANKHAM ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLanKham});
            return result > 0;
        }

        public DataTable GetListLanKham()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListLanKham");
        }

        public DataTable GetListLanKhamByNgay(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListLanKhamByNgay @NGAY", new object[] { date});
        }
        public DataTable GetListLanKhamByBenhNhanID(int BenhNhanID)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListLanKhamByBenhNhanID @MABENHNHAN", new object[] { BenhNhanID});
        }

        public DataTable GetListLanKhamByKhoaAndNgay(int id, DateTime ngay)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC GetListLanKhamByKhoaAndNgay @Khoa , @Ngay ", new object[] { id, ngay });
        }

        public DataTable GetListLanKhamByTenBenhNhan(string TenBenhNhan)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListLanKhamByTenBenhNhan @TEN", new object[] { TenBenhNhan });
        }
       
    }
}

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
    public class NhapVien_DAL 
    {
        private static NhapVien_DAL instance;

        public static NhapVien_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhapVien_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public bool AddNhapVien(int MaKetQua, DateTime NgayNhap, DateTime NgayXuat)
        {
            string query = "Exec AddNhapVien @MAKETQUA , @NGAYNHAP , @NGAYXUAT ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaKetQua, NgayNhap, NgayXuat });
            return result > 0;

        }
        public bool DeleteNhapVien(int MaNhapVien)
        {
            string query = "Exec DeleteNhapVien @MANHAPVIEN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhapVien });
            return result > 0;
        }
        public bool UpdateNhapVien(int MaNhapVien, int MaKetQua, DateTime NgayNhap, DateTime NgayXuat)
        {
            string query = "Exec UpdateNhapVien @MANHAPVIEN , @MAKETQUA , @NGAYNHAP , @NGAYXUAT ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhapVien, MaKetQua, NgayNhap, NgayXuat});
            return result > 0;
        }
        public DataTable GetListNhapVien()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListNhapVien");
        }

        public DataTable GetListNhapVienByTen(string ten)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListNhapVienByTen @TEN", new object[] {ten });
        }
        public DataTable GetListNhapVienByKetQuaID(int KetQuaID)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListNhapVienByKetQuaID @MAKETQUA", new object[] { KetQuaID });
        }

        public DataTable GetListNhapVienByBenhNhanID(int BenhNhanID)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListNhapVienByBenhNhanID @MAKETQUA", new object[] { BenhNhanID });
        }

        public bool UpdateTinhTrangNhapVien(int id)
        {
            string query = "EXEC UpdateTinhTrangNhapVien @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
             
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ChiTietNhapVien_DAL
    {
        private static ChiTietNhapVien_DAL instance;
        public static ChiTietNhapVien_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietNhapVien_DAL();
                return instance;
            }
            set
            {
                instance = value;
            }
        }


        public bool AddChiTietNhapVien(int MaNhapVien,int MaPhong)
        {
            string query = "Exec AddChiTietNhapVien @MANHAPVIEN , @MAPHONG";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhapVien, MaPhong});
            return result > 0;
        }
        public bool DeleteChiTietNhapVien(int MaChiTietNhapVien)
        {
            string query = "Exec DeleteChiTietNhapVien @MACHITIETNHAPVIEN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {MaChiTietNhapVien });
            return result > 0;
        }
        public bool UpdateChiTietNhapVien(int MaChiTietNhapVien, int MaNhapVien , int MaPhong)
        {
            string query = "Exec UpdateChiTietNhapVien @MACHITIETNHAPVIEN , @MANHAPVIEN , @MAPHONG ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaChiTietNhapVien, MaNhapVien, MaPhong});
            return result > 0;
        }

        public DataTable GetListChiTietNhapVien()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListChiTietNhapVien");
        }

        public DataTable GetListChiTietNhapVienByNgayNhap(DateTime ngaynhap)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListChiTietNhapVienByNgayNhap");
        }

        public DataTable GetListChiTietNhapVienByNhapVienID(int NhapVienID)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListChiTietNhapVienByNhapVienID");
        }

        public DataTable GetListCTNVByTenBenhNhan(string TenBenhNhan)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListCTNVByTenBenhNhan @TEN", new object[] { TenBenhNhan });
        }
    }
}

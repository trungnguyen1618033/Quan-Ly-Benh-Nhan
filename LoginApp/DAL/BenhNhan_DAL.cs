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
    public class BenhNhan_DAL 
    {
        private static BenhNhan_DAL instance;

        public static BenhNhan_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BenhNhan_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
            
        }

     
        public bool AddBenhNhan(string HoTen, string GioiTinh, string NgheNghiep, DateTime NgaySinh, string DiaChi, string SDT)
        {
            string query = "Exec AddBenhNhan @HOTEN , @GIOITINH , @NGHENGHIEP , @NGAYSINH , @DIACHI , @SDT";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { HoTen, GioiTinh, NgheNghiep, NgaySinh, DiaChi, SDT });
            return result > 0;
        }
        public bool UpdateBenhNhan(int MaBenhNhan, string HoTen, string GioiTinh, string NgheNghiep, DateTime NgaySinh, string DiaChi, string SDT)
        {
            string query = "Exec UpdateBenhNhan  @MABENHNHAN , @HOTEN , @GIOITINH , @NGHENGHIEP , @NGAYSINH , @DIACHI , @SDT";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaBenhNhan, HoTen, GioiTinh, NgheNghiep, NgaySinh, DiaChi, SDT });
            return result > 0;
        }
        public bool DeleteBenhNhan(int MaBenhNhan)
        {
            string query = "Exec DeleteBenhNhan @MABENHNHAN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaBenhNhan });
            return result > 0;
        }

        public DataTable GetListBenhNhan()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListBenhNhan");
        }

        public DataTable GetListBenhNhanByTen(string name)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC GetListBenhNhanByTen @HoTen", new object[] { name });
        }

        public DataTable GetThongTinBenhNhan(int id)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetThongTinBenhNhan @id", new object[] {id });
        }


    }
}

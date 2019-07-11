using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class LoaiPhong_DAL 
    {
        private static LoaiPhong_DAL instance;

        public static LoaiPhong_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhong_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        
       


        public LoaiPhong GetIDLoaiPhong(int id)
        {
            LoaiPhong loaiphong = null;
            string query = "EXEC GetListLoaiPhongByPhongID @MALOAIPHONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                loaiphong = new LoaiPhong(item);
                return loaiphong;
            }

            return loaiphong;
        }
        

        public bool AddLoaiPhong( string TenLoaiPhong, int DonGia)
        {
            string query = "Exec AddLoaiPhong @TENLOAIPHONG , @DONGIA";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenLoaiPhong, DonGia });
            return result > 0;
        }
        public bool DeleteLoaiPhong(int MaLoaiPhong)
        {
            string query = "Exec DeleteLoaiPhong @MALOAIPHONG";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLoaiPhong });
            return result > 0;
        }
        public bool UpdateLoaiPhong(int MaLoaiPhong, string TenLoaiPhong, int DonGia)
        {
            string query = "Exec UpdateLoaiPhong @MALOAIPHONG , @TENLOAIPHONG , @DONGIA";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLoaiPhong, TenLoaiPhong, DonGia });
            return result > 0;
        }

        public DataTable GetListLoaiPhong()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListLoaiPhong");
        }
        
    }
}

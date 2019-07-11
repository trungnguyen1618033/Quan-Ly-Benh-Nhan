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
    public class CTTT_DAL 
    {
        private static CTTT_DAL instance;

        public static CTTT_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTTT_DAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public bool AddCTTT(int MaToaThuoc,int SoVien,int MaThuoc)
        {
            string query = "Exec AddCTTT @MATOATHUOC , @SOVIEN , @MATHUOC";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {   MaToaThuoc, SoVien, MaThuoc });
            return result > 0;
        }
        public bool DeleteCTTT(int MaChiTietToaThuoc)
        {
            string query = "Exec DeleteCTTT @MACTTT";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaChiTietToaThuoc });
            return result > 0;
        }
        public bool UpdateCTTT(int MaChiTietToaThuoc, int MaToaThuoc, int SoVien, int MaThuoc)
        {
            string query = "Exec UpdateCTTT @MACTTT , @MATOATHUOC , @SOVIEN , @MATHUOC";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {MaChiTietToaThuoc, MaToaThuoc, SoVien, MaThuoc});
            return result > 0;
        }
        public  DataTable GetListCTTT()
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListCTTT");
        }
        public DataTable GetListCTTTByMaToaThuocID(int MaToaThuocID)
        {
            return DataProvider.Instance.ExecuteQuery("Exec GetListCTTTByMaToaThuocID @MaToaThuocID", new object[] { MaToaThuocID});
        }
    }
}

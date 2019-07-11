using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa
    {
        private int _MaKhoa;
        public int MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
        private string _TenKhoa;
        public string TenKhoa
        {
            get { return _TenKhoa; }
            set { _TenKhoa = value; }
        }


        public Khoa(int MaKhoa, string TenKhoa)
        {
            this._TenKhoa = TenKhoa;
            this._MaKhoa = MaKhoa;
        }

        public Khoa(DataRow row)
        {
            this._MaKhoa = (int)row["MaKhoa"];
            this._TenKhoa = row["TenKhoa"].ToString();
           
        }
    }
}

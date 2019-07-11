using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LanKham
    {
        private int _MaLanKham;
        public int MaLanKham
        {
            get { return _MaLanKham; }
            set { _MaLanKham = value; }
        }
        private int _MaBenhNhan;
        public int MaBenhNhan
        {
            get { return _MaLanKham; }
            set { _MaLanKham = value; }
        }
        private int _MaKhoa;
        public int MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
        private DateTime _NgayKham;
        public DateTime NgayKham
        {
            get { return _NgayKham; }
            set { _NgayKham = value; }
        }
        private string _TinhTrang;
        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { TinhTrang = value; }
        }

       
        public LanKham(int MaLanKham, int MaBenhNhan, int MaKhoa, DateTime NgayKham, string TinhTrang)
        {
            this._MaLanKham = MaLanKham;
            this._MaBenhNhan = MaBenhNhan;
            this._MaKhoa = MaKhoa;
            this._NgayKham = NgayKham;
            this._TinhTrang = TinhTrang;
          
        }

        public LanKham(DataRow row)
        {
            this._MaLanKham = Convert.ToInt32(row["MaLanKham"]);
            this._MaBenhNhan = Convert.ToInt32(row["MaBenhNhan"]);
            this._MaKhoa = Convert.ToInt32(row["MaKhoa"]);
            this._NgayKham = (DateTime)row["NgayKham"];
            this._TinhTrang = row["TinhTrang"].ToString();
        }
    }
}

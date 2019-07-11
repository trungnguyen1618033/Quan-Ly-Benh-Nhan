using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong
    {
        private int _MaLoaiPhong;
        public int MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }
        private string _TenLoaiPhong;
        public string TenLoaiPhong
        {
            get { return _TenLoaiPhong; }
            set { _TenLoaiPhong = value; }
        }
        private int _DonGia;
        public int DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        public LoaiPhong(int MaLoaiPhong, string TenLoaiPhong, int DonGia)
        {
            this._MaLoaiPhong = MaLoaiPhong;
            this._TenLoaiPhong = TenLoaiPhong;
            this._DonGia = DonGia;
        }

        public LoaiPhong(DataRow row)
        {
            this._MaLoaiPhong = (int)row["MaLoaiPhong"];
            this._TenLoaiPhong = row["TenLoaiPhong"].ToString();
            this._DonGia = Convert.ToInt32(row["DonGia"]);
        }
        public LoaiPhong() { }

    }

}

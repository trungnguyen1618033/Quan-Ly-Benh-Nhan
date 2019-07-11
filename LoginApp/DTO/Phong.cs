using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private int _MaPhong;
        public int MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        private int _MaLoaiPhong;
        public int MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }
        private int _SoGiuong;
        public int SoGiuong
        {
            get { return _SoGiuong; }
            set { _SoGiuong = value; }
        }
        private int _SoBenhNhan;
        public int SoBenhNhan
        {
            get { return _SoBenhNhan; }
            set { _SoBenhNhan = value; }
        }
        public Phong(int MaPhong, int MaLoaiPhong, int SoGiuong, int SoBenhNhan)
        {
            this._MaPhong = MaPhong;
            this._MaLoaiPhong = MaLoaiPhong;
            this._SoGiuong = SoGiuong;
            this._SoBenhNhan = SoBenhNhan;
        }
        public Phong(DataRow row)
        {
            this._MaPhong = (int)row["MaPhong"];
            this._MaLoaiPhong = (int)row["MaLoaiPhong"];
            this._SoGiuong = (int)row["SoGiuong"];
            this._SoBenhNhan = (int)row["SoBenhNhan"];

        }
        public Phong() { }
    }
}

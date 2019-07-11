using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapVien
    {
        private int _MaNhapVien;
        public int MaNhapVien
        {
            get { return _MaNhapVien; }
            set { _MaNhapVien = value; }
        }
        private int _MaKetQua;
        public int MaKetQua
        {
            get { return _MaKetQua; }
            set { _MaKetQua = value; }
        }
        private DateTime _NgayNhap;
        public DateTime NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        private DateTime _NgayXuat;
        public DateTime NgayXuat
        {
            get { return _NgayXuat; }
            set { _NgayXuat = value; }
        }
       
        public NhapVien(int MaNhapVien, int MaBenhNhan, DateTime NgayNhap, DateTime NgayXuat)
        {
            this._MaKetQua = MaBenhNhan;
            this._MaNhapVien = MaNhapVien;
            this._NgayNhap = NgayNhap;
            this._NgayXuat = NgayXuat;
           
        }

        public NhapVien(DataRow row)
        {
            this._MaKetQua = (int)row["MaBenhNhan"];
            this._MaNhapVien = (int)row["MaNhapVien"];
            this._NgayNhap = (DateTime)row["NgayNhap"];
            this._NgayXuat = (DateTime)row["NgayXuat"];
         
        }
    }
}

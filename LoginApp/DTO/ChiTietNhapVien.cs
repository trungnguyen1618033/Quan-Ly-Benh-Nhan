using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietNhapVien
    {
        private int _MaChiTietNhapVien;
        private int _MaNhapVien;
        private int _MaPhong;

        public ChiTietNhapVien(int MaCTNV,int MaNV,int MaPhong)
        {
            this._MaChiTietNhapVien = MaCTNV;
            this._MaNhapVien = MaNV;
            this._MaPhong = MaPhong;
        }

        public int MaChiTietNhapVien
        {
            get
            {
                return _MaChiTietNhapVien;
            }

            set
            {
                _MaChiTietNhapVien = value;
            }
        }

        public int MaNhapVien
        {
            get
            {
                return _MaNhapVien;
            }

            set
            {
                _MaNhapVien = value;
            }
        }

        public int MaPhong
        {
            get
            {
                return _MaPhong;
            }

            set
            {
                _MaPhong = value;
            }
        }
    }
}

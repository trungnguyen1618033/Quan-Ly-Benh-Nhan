using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan
    {
        private int _MaBenhNhan;
        public int MaBenhNhan
        {
            get { return _MaBenhNhan; }
            set { _MaBenhNhan = value; }
        }
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _GioiTinh;
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        private string _NgheNghiep;
        public string NgheNghiep
        {
            get { return _NgheNghiep; }
            set { _NgheNghiep = value; }
        }
        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        public BenhNhan(int MaBenhNhan, string HoTen, string GioiTinh, string NgheNghiep, DateTime NgaySinh, string DiaChi, string SDT)
        {
            this._MaBenhNhan = MaBenhNhan;
            this._HoTen = HoTen;
            this._GioiTinh = GioiTinh;
            this._NgheNghiep = NgheNghiep;
            this._NgaySinh = NgaySinh;
            this._DiaChi = DiaChi;
            this.SDT = SDT;
        }


    }
}

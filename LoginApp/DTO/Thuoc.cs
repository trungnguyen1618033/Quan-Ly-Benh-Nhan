using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc
    {
        private int _MaThuoc;
        
        public int MaThuoc
        {
            get { return _MaThuoc; }
            set { _MaThuoc = value; }
        }
        private string _TenThuoc;
        public string TenThuoc
        {
            get { return _TenThuoc; }
            set { _TenThuoc = value; }
        }
        private int _DonGia;
        public int DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        private int _SoLuong;
        
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }


        public Thuoc(int MaThuoc, string TenThuoc, int DonGia, int SoLuong)
        {
            this._MaThuoc = MaThuoc;
            this._TenThuoc = TenThuoc;
            this._DonGia = DonGia;
        }

        public Thuoc(DataRow row)
        {
            this._MaThuoc = Convert.ToInt32(row["MaThuoc"]);
            this._TenThuoc = row["TenThuoc"].ToString();
            this._DonGia = Convert.ToInt32(row["DonGia"]);
            this._SoLuong = Convert.ToInt32(row["SoLuong"]);
        }
    }
}

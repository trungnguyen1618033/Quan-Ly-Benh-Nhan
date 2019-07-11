using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ToaThuoc
    {
        private int   _MaToaThuoc;
        public int MaToaThuoc
        {
            get { return _MaToaThuoc; }
            set { _MaToaThuoc = value; }
        }
        private int _MaKetQua;
        public int MaKetQua
        {
            get { return _MaKetQua; }
            set { _MaKetQua = value; }
        }
        private int _SoNgay;
        public int SoNgay
        {
            get { return _SoNgay; }
            set { _SoNgay = value; }
        }
        public ToaThuoc(int MaKetQua, int MaLanKham, int SoNgay)
        {
            this._MaKetQua = MaLanKham;
            this._MaToaThuoc = MaToaThuoc;
            this._SoNgay = SoNgay;
        }

        public ToaThuoc(DataRow row)
        {
            this._MaKetQua = Convert.ToInt32(row["MaLanKham"]);
            this._MaToaThuoc = Convert.ToInt32(row["MaToaThuoc"]);
            this._SoNgay = Convert.ToInt32(row["SoNgay"]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTTT
    {
        private int _MaCTTT;
        public int MaCTTT
        {
            get { return _MaCTTT; }
            set { _MaCTTT = value; }
        }
        private int _MaToaThuoc;
        public int MaToaThuoc
        {
            get { return _MaToaThuoc; }
            set { _MaToaThuoc = value; }
        }
        private string _SoVien;
        public string SoVien
        {
            get { return _SoVien; }
            set { _SoVien = value; }
        }
        private int _MaThuoc;
        public int MaThuoc
        {
            get { return _MaThuoc; }
            set { _MaThuoc = value; }
        }

        public CTTT(int MaCTTT, int MaToaThuoc, string SoVien, int MaThuoc)
        {
            this._MaCTTT = MaCTTT;
            this._MaToaThuoc = MaToaThuoc;
            this._MaThuoc = MaThuoc;
            this._SoVien = SoVien;
        }
    }
}

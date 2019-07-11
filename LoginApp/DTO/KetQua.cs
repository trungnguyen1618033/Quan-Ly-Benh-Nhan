using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KetQua
    {
        private int _MaKetQua;
        public int MaKetQua
        {
            get { return _MaKetQua; }
            set { _MaKetQua = value; }
        }

        private string _KetQua;
        public string KQ
        {
            get { return _KetQua; }
            set { _KetQua = value; }
        }

        public int _MaLanKham
        {
            get
            {
                return _MaLanKham;
            }

            set
            {
                _MaLanKham = value;
            }
        }

        public string TenBacSy
        {
            get
            {
                return _TenBacSy;
            }

            set
            {
                _TenBacSy = value;
            }
        }

        private string _TenBacSy;

 





        public KetQua(int MaKQ, string KQ,int MaLK, string tenBS)
        {
            this._MaKetQua = MaKQ;
            this._KetQua = KQ;
            this._MaLanKham = MaLK;
            this._TenBacSy = tenBS;
        }

        public KetQua(DataRow row)
        {
            this._MaKetQua = Convert.ToInt32(row["MaKetQua"]);
            this._KetQua = row["KetQua"].ToString();
            this._MaLanKham = Convert.ToInt32(row["MaLanKham"]);
            this._TenBacSy = row["TenBacSy"].ToString();
        }



    }
}

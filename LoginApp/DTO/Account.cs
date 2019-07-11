using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {

        public Account(string userName, string ten, string chucVu, int maKhoa, int type, string matKhau = null)
        {
      
            this.UserName = userName;
            this.Ten = ten;
            this.ChucVu = chucVu;
            this.MaKhoa = maKhoa;
            this.Type = type;
            this.MatKhau = matKhau;
        }

        public Account(DataRow row)
        {
            
            this.UserName = row["userName"].ToString();
            this.Ten = row["ten"].ToString();
            this.ChucVu = row["chucVu"].ToString();
            this.MaKhoa = Convert.ToInt32(row["maKhoa"]);
            this.Type = Convert.ToInt32(row["type"]);
            this.MatKhau = row["matKhau"].ToString();
        }

        private int type;

        private int maKhoa;

        private string chucVu;

        private string matKhau;

        private string ten;

        private string userName;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }

        public int MaKhoa
        {
            get
            {
                return maKhoa;
            }

            set
            {
                maKhoa = value;
            }
        }

 
    }
}

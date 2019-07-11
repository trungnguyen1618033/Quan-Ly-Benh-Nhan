using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class frmAccount : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }

            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount);
            }
        }
        public frmAccount(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUsername.Text = LoginAccount.UserName;
            txtTen.Text = LoginAccount.Ten;
            txtChucVu.Text = LoginAccount.ChucVu;
            txtKhoa.Text = LoginAccount.MaKhoa.ToString();
        }

       
     
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

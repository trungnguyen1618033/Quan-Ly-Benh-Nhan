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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

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
            }
        }

        void UpdatePassword()
        {
            string password = txtPassword.Text;
            string newpass = txtnewPassword.Text;
            string reenterPass = txtReEnterPass.Text;
            string userName = LoginAccount.UserName;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
            }
            else
            {
                if (AccountDAL.Instance.UpdatePassword(userName, password, newpass))
                    MessageBox.Show("Cập nhập thành công ");
                else
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePassword();
        }

       

       
    }
}

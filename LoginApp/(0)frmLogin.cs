 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 
using DAL;
using DTO;
namespace LoginApp

{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            if(Login(userName, passWord))
            {
                Account loginAccount = AccountDAL.Instance.GetAccountUserName(userName);
                fTableManage ft = new fTableManage(loginAccount);
                this.Hide();
                ft.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại Password hoặc Username");
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAL.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            frmConnection f = new frmConnection();
            f.ShowDialog();
        }
    }
}

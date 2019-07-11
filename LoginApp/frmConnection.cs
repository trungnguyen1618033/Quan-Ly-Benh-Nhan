using DAL;
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
    public partial class frmConnection : Form
    {

        public static string DataSource;
        public static string InitialCatalog;
        public static string UserID;
        public static string Password;
        public static string connectionSTR;
        public frmConnection()
        {
            InitializeComponent();
        }

        private void btLuuKetNoi_Click(object sender, EventArgs e)
        {
            btLuuKetNoi.Enabled = false;
            btClose.Enabled = false;
            if (txtPassword.Text != "")
            {
                connectionSTR = "Data Source=" + txtServer.Text
                    + ";Initial Catalog=" + txtDatabase.Text
                    + ";User ID=" + txtUsername.Text
                    + ";pwd=" + txtPassword.Text;
            }
            else
            {
                connectionSTR = "Data Source=" + txtServer.Text
                    + ";Initial Catalog=" + txtDatabase.Text
                    + ";Integrated Security=True";
            }

            Properties.Settings.Default.DataSource = txtServer.Text;
            Properties.Settings.Default.InitialCatalog = txtDatabase.Text;
            Properties.Settings.Default.UserID = txtUsername.Text;
            Properties.Settings.Default.Password= txtPassword.Text;
            Properties.Settings.Default.connectionSTR = connectionSTR;
           Properties.Settings.Default.Save();

            bool result = DataProvider.TestConnectionSQL(connectionSTR);
            if (result)
            {
                MessageBox.Show("KẾT NỐI THÀNH CÔNG", "THÔNG BÁO");
            }
            else
                MessageBox.Show("KẾT NỐI THẤT BẠI", "THÔNG BÁO");
            btLuuKetNoi.Enabled = true;
            btClose.Enabled = true;


        }

        private void frmConnection_Load(object sender, EventArgs e)
        {


            if (Properties.Settings.Default.DataSource != string.Empty && Properties.Settings.Default.InitialCatalog != string.Empty)
            {
                txtServer.Text = Properties.Settings.Default.DataSource;
                txtDatabase.Text = Properties.Settings.Default.InitialCatalog;
                txtUsername.Text = Properties.Settings.Default.UserID;
                txtPassword.Text =Properties.Settings.Default.Password;
            }
            

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

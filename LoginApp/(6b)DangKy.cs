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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
         
        }

        public string gioitinh;

        #region methods
       
       void DangKyBenhNhan(string hoten, string gioitinh, string nghenghiep, DateTime ngaysinh, string diachi,  string sdt )
        {
            if (BenhNhan_DAL.Instance.AddBenhNhan(hoten, gioitinh, nghenghiep, ngaysinh, diachi, sdt))
                MessageBox.Show("Đăng ký thành công");
            else
                MessageBox.Show("Đăng ký thất bại");
                
        }

        string GetGioiTinh()
        {
            RadioButton ckb = null;

            foreach(RadioButton item in pnGioiTinh.Controls)
            {
                if (item.Checked)
                {
                    ckb = item;
                    break;
                }
            }
            if (ckb.Checked == false)
                return "";

            return ckb.Text;
        }

        #endregion

        #region event
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {

            string hoten = txtHoTen.Text;  
            string nghenghiep = txtNgheNghiep.Text;
            DateTime date = dtNgaySinh.Value;
            string diachi = txtDiaChi.Text;
            string sdt = txtSoDienThoai.Text;
            if (hoten.Length == 0)
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (nghenghiep.Length == 0)
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (diachi.Length == 0)
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (sdt.Length == 0)
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (gioitinh.Length == 0)
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
                DangKyBenhNhan(hoten, gioitinh, nghenghiep, date, diachi, sdt);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
                gioitinh = radio.Text;
        }

        #endregion


    }
}

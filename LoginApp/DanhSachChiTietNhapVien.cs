using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;

namespace LoginApp
{
    public partial class DanhSachChiTietNhapVien : Form
    {
        public DanhSachChiTietNhapVien()
        {
            InitializeComponent();
            ChiTietNhapViendtgv.DataSource = ctnvlist;
            LoadCTNV();
            AddChiTietNhapVienBinding();

        }

        BindingSource ctnvlist = new BindingSource();

        #region Methods

        void LoadCTNV()
        {
            ctnvlist.DataSource = ChiTietNhapVien_DAL.Instance.GetListChiTietNhapVien();
        }

        void AddChiTietNhapVienBinding()
        {
            txtMaCTNV.DataBindings.Add(new Binding("Text", ChiTietNhapViendtgv.DataSource, "MACHITIETNHAPVIEN", true, DataSourceUpdateMode.Never));
            txtMaNhapVien.DataBindings.Add(new Binding("Text", ChiTietNhapViendtgv.DataSource, "MANHAPVIEN", true, DataSourceUpdateMode.Never));
            txtMaPhong.DataBindings.Add(new Binding("Text", ChiTietNhapViendtgv.DataSource, "MAPHONG", true, DataSourceUpdateMode.Never));
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", ctnvlist.DataSource, "MABENHNHAN", true, DataSourceUpdateMode.Never));
            txtTenBenhNhan.DataBindings.Add(new Binding("Text", ctnvlist.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            dtNgaySinh.DataBindings.Add(new Binding("Value", ctnvlist.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
           
        }

        void TimBenhNhan(string name)
        {
            ctnvlist.DataSource = ChiTietNhapVien_DAL.Instance.GetListCTNVByTenBenhNhan(name);
        }

        void UpdateCTNV(int mactnv, int manhapvien, int maphong)
        {
            if (ChiTietNhapVien_DAL.Instance.UpdateChiTietNhapVien(mactnv, manhapvien, maphong))
            {
                MessageBox.Show("Cập nhật chi tiết nhập viện thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật chi tiết nhập viện Lần Khám thất bại");
            }
            LoadCTNV();
        }

        void DeleteCTNV(int mactnv)
        {
            if (ChiTietNhapVien_DAL.Instance.DeleteChiTietNhapVien(mactnv))
            {
                MessageBox.Show("Xóa chi tiết nhập viện thành công");
            }
            else
            {
                MessageBox.Show("Xóa chi tiết nhập viện lần khám thất bại");
            }
            LoadCTNV();
        }
      


        #endregion

        #region Events

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadCTNV();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCTNV.Text.Length == 0)
                MessageBox.Show("Không có chi tiết nhập viện");
            else
            {
                int mactnv = Convert.ToInt32(txtMaCTNV.Text);
                int manhapvien = Convert.ToInt32(txtMaNhapVien.Text);
                int maphong = Convert.ToInt32(txtMaPhong.Text);

                UpdateCTNV(mactnv, manhapvien, maphong);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCTNV.Text.Length == 0)
                MessageBox.Show("Không có chi tiết nhập viện");
            else
            {
                int mactnv = Convert.ToInt32(txtMaCTNV.Text);
                DeleteCTNV(mactnv);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimBenhNhan(txtTim.Text);
        }

        private void txtMaCTNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCTNV.Text.Length == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        #endregion


    }
}

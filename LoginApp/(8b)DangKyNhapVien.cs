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
    public partial class DangKyNhapVien : Form
    {
        public DangKyNhapVien()
        {
            InitializeComponent();
            UpLoad();
        }

        BindingSource nhapvienList = new BindingSource();
        BindingSource phongList = new BindingSource();

        #region methods

        void UpLoad()
        {
            dtgvNhapVien.DataSource = nhapvienList;
            dtgvPhong.DataSource = phongList;
            GetListLoaiPhongIntoCbx(cbxLoaiPhong);
            LoadNhapVien();
            AddNhapVienBinding();
            LoadPhong();
            AddPhongBinding();
        }

        void AddNhapVienBinding()
        {
            txtMaNhapVien.DataBindings.Add(new Binding("Text", dtgvNhapVien.DataSource, "MANHAPVIEN", true, DataSourceUpdateMode.Never));
        }

        void AddPhongBinding()
        {
            txtMaPhong.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "MAPHONG", true, DataSourceUpdateMode.Never));
          
        }

        void LoadNhapVien()
        {
            nhapvienList.DataSource = NhapVien_DAL.Instance.GetListNhapVien();
        }

        void LoadPhong()
        {
            phongList.DataSource = Phong_DAL.Instance.GetLisPhongByLoaiPhongID(Convert.ToInt32(cbxLoaiPhong.SelectedValue));
        }

        void GetListLoaiPhongIntoCbx(ComboBox cb)
        {
            cb.DataSource = LoaiPhong_DAL.Instance.GetListLoaiPhong();
            cb.DisplayMember = "TENLOAIPHONG";
            cb.ValueMember = "MALOAIPHONG";
        }

        void AddCTNV(int manhapvien , int maphong)
        {
            if (ChiTietNhapVien_DAL.Instance.AddChiTietNhapVien(manhapvien, maphong))
                MessageBox.Show("Nhập viện thành công ");
            else
                MessageBox.Show("Nhập viện thất bại");
        }

        void TimNhapVien(string ten)
        {
            nhapvienList.DataSource = NhapVien_DAL.Instance.GetListNhapVienByTen(ten);
        }

        #endregion


        #region event

        private void btXemNhapVien_Click(object sender, EventArgs e)
        {
            LoadNhapVien();

        }

        private void btXemPhong_Click(object sender, EventArgs e)
        {
            LoadPhong();
            
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            if (txtMaNhapVien.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn chọn bệnh nhân");
            else if (txtMaPhong.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn chọn phòng");
            else
            {
                int manhapvien = Convert.ToInt32(txtMaNhapVien.Text);
                int maphong = Convert.ToInt32(txtMaPhong.Text);
                AddCTNV(manhapvien, maphong);
                NhapVien_DAL.Instance.UpdateTinhTrangNhapVien(manhapvien);
                
            }
            LoadNhapVien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimNhapVien(txtTim.Text);
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNhapVien.Text.Length == 0)
                btDangKy.Enabled = false;
            else
                btDangKy.Enabled = true;
        }

        private void txtMaNhapVien_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNhapVien.Text.Length == 0)
                btDangKy.Enabled = false;
            else
                btDangKy.Enabled = true;
        }



        #endregion


    }
}

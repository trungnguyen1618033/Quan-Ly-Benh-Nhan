using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace LoginApp
{
    public partial class DanhSachBenhNhan : Form
    {
        public DanhSachBenhNhan()
        {
            InitializeComponent();
            BenhNhandtgv.DataSource = BenhNhanList;
            LoadlistBenhNhan();
            AddBenhNhanBinding();
        }


        BindingSource BenhNhanList = new BindingSource();


        #region Methods
        void TimBenhNhan(string name)
        {
            BenhNhanList.DataSource = BenhNhan_DAL.Instance.GetListBenhNhanByTen(name);
        }
       

        void AddBenhNhanBinding()
        {
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", BenhNhandtgv.DataSource, "MABENHNHAN", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", BenhNhandtgv.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            txtGioiTinh.DataBindings.Add(new Binding("Text", BenhNhandtgv.DataSource, "GIOITINH", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", BenhNhandtgv.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txtNgheNghiep.DataBindings.Add(new Binding("Text", BenhNhandtgv.DataSource, "NGHENGHIEP", true, DataSourceUpdateMode.Never));
            txtSoDienThoai.DataBindings.Add(new Binding("Text", BenhNhandtgv.DataSource,"SDT", true, DataSourceUpdateMode.Never));
            dtNgaySinh.DataBindings.Add(new Binding("Value", BenhNhandtgv.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
        }

        void LoadlistBenhNhan() 
        {
            BenhNhanList.DataSource = BenhNhan_DAL.Instance.GetListBenhNhan();
        }

        void UpdateBenhNhan(int MaBenhNhan, string HoTen, string GioiTinh, string NgheNghiep, DateTime NgaySinh, string DiaChi, string SDT)
        {
            if (BenhNhan_DAL.Instance.UpdateBenhNhan(MaBenhNhan, HoTen, GioiTinh, NgheNghiep, NgaySinh, DiaChi, SDT))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            LoadlistBenhNhan();
        }

        void DeleteBenhNhan(int MaBenhNhan)
        {
            if (BenhNhan_DAL.Instance.DeleteBenhNhan(MaBenhNhan))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            LoadlistBenhNhan();
        }

        #endregion

        #region Events

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadlistBenhNhan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMaBenhNhan.Text);
            string b = txtHoTen.Text;
            string c = txtGioiTinh.Text;
            string d = txtNgheNghiep.Text;
            DateTime f = (DateTime)dtNgaySinh.Value;
            string g = txtDiaChi.Text;
            string h = txtSoDienThoai.Text;
            UpdateBenhNhan(a, b, c, d, f, g, h);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMaBenhNhan.Text);
            DeleteBenhNhan(a);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimBenhNhan(txtTim.Text);
        }

        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaBenhNhan.Text.Length == 0)
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

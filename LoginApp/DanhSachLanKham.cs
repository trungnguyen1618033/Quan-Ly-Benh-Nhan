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
    public partial class DanhSachLanKham : Form
    {
        public DanhSachLanKham()
        {
            InitializeComponent();
            LanKhamdtgv.DataSource = LanKhamList;
            LoadListLanKham();
            AddLanKhamBinding();
        }

        BindingSource LanKhamList = new BindingSource();

        #region Methods

     
        void AddLanKhamBinding()
        {

            txtMaLanKham.DataBindings.Add(new Binding("Text", LanKhamdtgv.DataSource, "MALANKHAM", true, DataSourceUpdateMode.Never));
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", LanKhamdtgv.DataSource, "MABENHNHAN", true, DataSourceUpdateMode.Never));
            txtMaKhoa.DataBindings.Add(new Binding("Text", LanKhamdtgv.DataSource, "MAKHOA", true, DataSourceUpdateMode.Never));
            txtTinhTrang.DataBindings.Add(new Binding("Text", LanKhamdtgv.DataSource,"TINHTRANG",true,DataSourceUpdateMode.Never));
            dtpkNgayKham.DataBindings.Add(new Binding("Value", LanKhamdtgv.DataSource, "NGAYKHAM", true, DataSourceUpdateMode.Never));
            txtTenBenhNhan.DataBindings.Add(new Binding("Text", LanKhamdtgv.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            dtNgaySinh.DataBindings.Add(new Binding("Value", LanKhamdtgv.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
        }

        void LoadListLanKham()
        {
            LanKhamList.DataSource = LanKham_DAL.Instance.GetListLanKham();
        }


        void UpdateLanKham(int MaLanKham, int MaBenhNhan, int MaKhoa, DateTime NgayKham, string TinhTrang)
        {
            if (LanKham_DAL.Instance.UpdateLanKham(MaLanKham, MaBenhNhan, MaKhoa, NgayKham, TinhTrang))
            {
                MessageBox.Show("Cập nhật lần khám thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật lần khám thất bại");
            }
            LoadListLanKham();
        }

        void DeleteLanKham(int MaLanKham)
        {
            if (LanKham_DAL.Instance.DeleteLanKham(MaLanKham))
            {
                MessageBox.Show("Xóa lần khám thành công");
            }
            else
            {
                MessageBox.Show("Xóa lần khám thất bại");
            }
            LoadListLanKham();
        }

        void TimBenhNhan(string name)
        {
            LanKhamList.DataSource = LanKham_DAL.Instance.GetListLanKhamByTenBenhNhan(name);
        }
        #endregion

        #region Events

        private void btnXoaLanKham_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text.Length == 7)
            {
                MessageBox.Show("Không thể xóa ");
               
            }

            else
            {
                int a = Convert.ToInt32(txtMaLanKham.Text);
                DeleteLanKham(a);
            }
        }

        private void btnSuaLanKham_Click(object sender, EventArgs e)
        {
            if (txtMaLanKham.Text.Length == 0)
                MessageBox.Show("Không có lần khám ");
            else
            {
                int a = Convert.ToInt32(txtMaLanKham.Text);
                int b = Convert.ToInt32(txtMaBenhNhan.Text);
                int c = Convert.ToInt32(txtMaKhoa.Text);
                DateTime d = (DateTime)dtpkNgayKham.Value;
                string f = txtTinhTrang.Text;

                UpdateLanKham(a, b, c, d, f);
            }
        }

        private void btnXemLanKham_Click(object sender, EventArgs e)
        {
            LoadListLanKham();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            TimBenhNhan(txtTim.Text);
        }
        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text.Length == 7)
                btnXoaLanKham.Enabled = false;
            else
                btnXoaLanKham.Enabled = true;
        }

        private void txtMaLanKham_TextChanged(object sender, EventArgs e)
        {
            if (txtMaLanKham.Text.Length == 0)
            {
                btnSuaLanKham.Enabled = false;
                btnXoaLanKham.Enabled = false;
            }
            else
            {
                btnSuaLanKham.Enabled = true;
                btnXoaLanKham.Enabled = true;
            }
        }

        #endregion


    }
}

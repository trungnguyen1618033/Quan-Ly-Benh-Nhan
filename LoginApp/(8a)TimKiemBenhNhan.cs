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
    public partial class TimKiemBenhNhan : Form
    {
        public TimKiemBenhNhan()
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
            txtSoDienThoai.DataBindings.Add(new Binding("Text", BenhNhandtgv.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            dtNgaySinh.DataBindings.Add(new Binding("Value", BenhNhandtgv.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
        }

        void LoadlistBenhNhan()
        {
            BenhNhanList.DataSource = BenhNhan_DAL.Instance.GetListBenhNhan();
        }
        #endregion

        #region events
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadlistBenhNhan();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimBenhNhan(txtTim.Text);
        }

        #endregion

        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaBenhNhan.Text.Length == 0)
                btnXemChiTiet.Enabled = false;
            else
                btnXemChiTiet.Enabled = true;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietBenhNhan c = new ChiTietBenhNhan(Convert.ToInt32(txtMaBenhNhan.Text));
            c.ShowDialog();
        }
    }
}

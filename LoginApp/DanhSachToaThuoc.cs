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
    public partial class DanhSachToaThuoc : Form
    {
        public DanhSachToaThuoc()
        {
            InitializeComponent();
            ToaThuocdtgv.DataSource = ListToaThuoc;
            LoadListToaThuoc();
            AddToaThuocBinding();
        }

        BindingSource ListToaThuoc = new BindingSource();

        

        #region Methods

        void AddToaThuocBinding()
        {
            txtMaToaThuoc.DataBindings.Add("Text", ToaThuocdtgv.DataSource, "MATOATHUOC", true, DataSourceUpdateMode.Never);
            txtMaKetQua.DataBindings.Add(new Binding("Text", ToaThuocdtgv.DataSource, "MAKETQUA", true, DataSourceUpdateMode.Never));
            txtSoNgay.DataBindings.Add(new Binding("Text", ToaThuocdtgv.DataSource, "SONGAY", true, DataSourceUpdateMode.Never));
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", ToaThuocdtgv.DataSource, "MABENHNHAN", true, DataSourceUpdateMode.Never));
            txtTenBenhNhan.DataBindings.Add(new Binding("Text", ToaThuocdtgv.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            dtNgaySinh.DataBindings.Add(new Binding("Value", ToaThuocdtgv.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
        }

        void LoadListToaThuoc()
        {
            ListToaThuoc.DataSource = ToaThuoc_DAL.Instance.GetListToaThuoc();
        }

        void TimToaThuoc(string TenBenhNhan)
        {
            ListToaThuoc.DataSource = ToaThuoc_DAL.Instance.GetListToaThuocByTenBenhNhan(TenBenhNhan);
        }
        #endregion

        #region Events

        private void btnXemToaThuoc_Click(object sender, EventArgs e)
        {
            LoadListToaThuoc();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimToaThuoc(txtTim.Text);
        }
        #endregion


    }
}

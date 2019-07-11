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

namespace LoginApp
{
    public partial class ChiTietToaThuoc : Form
    {
        public ChiTietToaThuoc()
        {
            InitializeComponent();
            Upload();
        }

        BindingSource toathuocList = new BindingSource();
        BindingSource chitiettoathuoclist = new BindingSource();


        #region methods
        void Upload()
        {
            
            LoadKetQuaIntoCbx(cbxMaKetQua);
            LoadThuocIntoCbx(cbxThuoc);
            LoadToaThuocIntoCbx(cbxMaToaThuoc);
            dtgvToaThuoc.DataSource = toathuocList;
            dtgvCTTT.DataSource = chitiettoathuoclist;
            LoadToaThuoc();
            AddToaThuocBinding();
          


        }

        void AddToaThuocBinding()
        {
            txtMaToaThuoc.DataBindings.Add(new Binding("Text", dtgvToaThuoc.DataSource, "MATOATHUOC", true, DataSourceUpdateMode.Never));
            cbxMaKetQua.DataBindings.Add(new Binding("SelectedValue", dtgvToaThuoc.DataSource, "MAKETQUA", true, DataSourceUpdateMode.Never));
            nmSoNgay.DataBindings.Add(new Binding("VALUE", dtgvToaThuoc.DataSource, "SONGAY", true, DataSourceUpdateMode.Never));
        }

        void AddCTTTBindding()
        {
            txtMaCTTT.DataBindings.Clear();
            cbxMaToaThuoc.DataBindings.Clear();
            cbxThuoc.DataBindings.Clear();
            nmSovien.DataBindings.Clear();
            txtMaCTTT.DataBindings.Add(new Binding("Text", dtgvCTTT.DataSource, "MACTTT", true, DataSourceUpdateMode.Never));
            cbxMaToaThuoc.DataBindings.Add(new Binding("SelectedValue", dtgvCTTT.DataSource, "MATOATHUOC", true, DataSourceUpdateMode.Never));
            cbxThuoc.DataBindings.Add(new Binding("SelectedValue", dtgvCTTT.DataSource, "MATHUOC", true, DataSourceUpdateMode.Never));
            nmSovien.DataBindings.Add(new Binding("Text", dtgvCTTT.DataSource, "SOVIEN", true, DataSourceUpdateMode.Never));
        }

        void LoadThuocIntoCbx(ComboBox cb)
        {
            cb.DataSource = Thuoc_DAL.Instance.GetListThuoc();
            cb.DisplayMember = "TENTHUOC";
            cb.ValueMember = "MATHUOC";
        }

        void LoadToaThuocIntoCbx(ComboBox cb)
        {
            cb.DataSource = ToaThuoc_DAL.Instance.GetListToaThuoc();
            cb.DisplayMember = "MATOATHUOC";
        }

        void LoadKetQuaIntoCbx(ComboBox cb)
        {
            cb.DataSource = KetQua_DAL.Instance.GetListKetQua();
            cb.DisplayMember = "MAKETQUA";
        }

        void LoadToaThuoc()
        {
            toathuocList.DataSource = ToaThuoc_DAL.Instance.GetListToaThuoc();
        }
  
        void TimToaThuoc(string ten)
        {
            toathuocList.DataSource = ToaThuoc_DAL.Instance.GetListToaThuocByTenBenhNhan(ten);
        }

        #endregion

        #region events
        private void btXemTT_Click(object sender, EventArgs e)
        {
            LoadToaThuoc();
        }

        void LoadCTTT(int id)
        {
            chitiettoathuoclist.DataSource = CTTT_DAL.Instance.GetListCTTTByMaToaThuocID(id);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimToaThuoc(txtTim.Text);
        }

        private void txtMaToaThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtMaToaThuoc.Text.Length == 0)
                MessageBox.Show("Không có toa thuốc ");
            else
            {
                LoadCTTT(Convert.ToInt32(txtMaToaThuoc.Text));
                AddCTTTBindding();
            }
        }
        #endregion
    }
}

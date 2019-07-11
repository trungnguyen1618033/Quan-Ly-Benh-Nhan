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
    public partial class ChiTietBenhNhan : Form
    {
        public ChiTietBenhNhan(int id)
        {
            InitializeComponent();
            IDBenhNhan = id;
            LoadThongTinBenhNhan();
            Upload();
        }

        public int IDBenhNhan;
        BindingSource ketquaList = new BindingSource();
        BindingSource nhapvienList = new BindingSource();
        BindingSource toathuocList = new BindingSource();
        BindingSource chitiettoathuoclist = new BindingSource();
        BindingSource lankhamList = new BindingSource();

        #region methods
        void Upload()
        {
            LoadLanKhamIntoCbx(cbxMaLanKham);
            LoadKetQuaIntoCbx(cbxMaKetQua);
            LoadKetQuaIntoCbx(cbxMaKetQuaByKetQua);
            LoadThuocIntoCbx(cbxThuoc);
            dtgvKetQua.DataSource = ketquaList;
            dtgvNhapVien.DataSource = nhapvienList;
            dtgvToaThuoc.DataSource = toathuocList;
            dtgvCTTT.DataSource = chitiettoathuoclist;
            dtgvLanKham.DataSource = lankhamList;
            LoadKetQua();
            AddKetQuaBinding();
            LoadToaThuoc();
            AddToaThuocBinding();
            LoadNhapVien();
            AddNhapVienBinding();
            LoadListLanKham();
            AddLanKhamBinding();

        }
        void AddLanKhamBinding()
        {

            txtMaLanKham.DataBindings.Add(new Binding("Text", dtgvLanKham.DataSource, "MALANKHAM", true, DataSourceUpdateMode.Never));
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", dtgvLanKham.DataSource, "MABENHNHAN", true, DataSourceUpdateMode.Never));
            txtMaKhoa.DataBindings.Add(new Binding("Text", dtgvLanKham.DataSource, "MAKHOA", true, DataSourceUpdateMode.Never));
            txtTinhTrang.DataBindings.Add(new Binding("Text", dtgvLanKham.DataSource, "TINHTRANG", true, DataSourceUpdateMode.Never));
            dtpkNgayKham.DataBindings.Add(new Binding("Value", dtgvLanKham.DataSource, "NGAYKHAM", true, DataSourceUpdateMode.Never));
        }

        void TimKetQua(int id ,string ketqua)
        {
            ketquaList.DataSource = KetQua_DAL.Instance.GetListKetQuaByKetQua(id ,ketqua);
        }

        void TimLanKham(DateTime date)
        {
            lankhamList.DataSource = LanKham_DAL.Instance.GetListLanKhamByNgay(date);
        }
        void LoadListLanKham()
        {
            lankhamList.DataSource = LanKham_DAL.Instance.GetListLanKhamByBenhNhanID(IDBenhNhan);
        }
        void LoadThongTinBenhNhan()
        {
            DataTable dt = BenhNhan_DAL.Instance.GetThongTinBenhNhan(IDBenhNhan);
            DataRow dr = dt.Rows[0];

            txtHoTen.Text = dr["HOTEN"].ToString();
            dtNgaySinh.Value = Convert.ToDateTime(dr["NGAYSINH"].ToString());
            txtDiaChi.Text = dr["DIACHI"].ToString();
            txtNgheNghiep.Text = dr["NGHENGHIEP"].ToString();
            txtGioiTinh.Text = dr["GIOITINH"].ToString();
            txtSoDienThoai.Text = dr["SDT"].ToString();
        }

        void AddKetQuaBinding()
        {
            txtMaKQ.DataBindings.Add(new Binding("Text", dtgvKetQua.DataSource, "MAKETQUA", true, DataSourceUpdateMode.Never));
            cbxMaLanKham.DataBindings.Add(new Binding("SelectedValue", dtgvKetQua.DataSource, "MALANKHAM", true, DataSourceUpdateMode.Never));
            txtKetQua.DataBindings.Add(new Binding("Text", dtgvKetQua.DataSource, "KETQUA", true, DataSourceUpdateMode.Never));
        }

        void AddNhapVienBinding()
        {
            txtMaNhapVien.DataBindings.Add(new Binding("Text", dtgvNhapVien.DataSource, "MANHAPVIEN", true, DataSourceUpdateMode.Never));
            cbxMaKetQua.DataBindings.Add(new Binding("SelectedValue", dtgvNhapVien.DataSource, "MAKETQUA", true, DataSourceUpdateMode.Never)); ;
            dtpkNgayNhap.DataBindings.Add(new Binding("Value", dtgvNhapVien.DataSource, "NGAYNHAP", true, DataSourceUpdateMode.Never));
            dtpkNgayXuat.DataBindings.Add(new Binding("Value", dtgvNhapVien.DataSource, "NGAYXUAT", true, DataSourceUpdateMode.Never));
            txtTinhTrangNV.DataBindings.Add(new Binding("Text", dtgvNhapVien.DataSource, "TINHTRANG", true, DataSourceUpdateMode.Never));
        }

        void AddToaThuocBinding()
        {
            txtMaToaThuoc.DataBindings.Add(new Binding("Text", dtgvToaThuoc.DataSource, "MATOATHUOC", true, DataSourceUpdateMode.Never));
            cbxMaKetQuaByKetQua.DataBindings.Add(new Binding("SelectedValue", dtgvToaThuoc.DataSource, "MAKETQUA", true, DataSourceUpdateMode.Never));
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

        void LoadToaThuocIntoCbx(ComboBox cb)
        {
            cb.DataSource = ToaThuoc_DAL.Instance.GetListToaThuocByBenhNhanID(IDBenhNhan);
            cb.DisplayMember = "MATOATHUOC";
            cb.ValueMember = "MATOATHUOC";

        }

        void LoadThuocIntoCbx(ComboBox cb)
        {
            cb.DataSource = Thuoc_DAL.Instance.GetListThuoc();
            cb.DisplayMember = "TENTHUOC";
            cb.ValueMember = "MATHUOC";
        }

        void LoadKetQuaIntoCbx(ComboBox cb)
        {
            cb.DataSource = KetQua_DAL.Instance.GetListKetQuaByBenhNhanID(IDBenhNhan);
            cb.DisplayMember = "MAKETQUA";
            cb.ValueMember = "MAKETQUA";
        }
        void LoadLanKhamIntoCbx(ComboBox cb)
        {
            cb.DataSource = LanKham_DAL.Instance.GetListLanKhamByBenhNhanID(IDBenhNhan);
            cb.DisplayMember = "MALANKHAM";
        }
        void LoadKetQua()
        {
            ketquaList.DataSource = KetQua_DAL.Instance.GetListKetQuaByBenhNhanID(IDBenhNhan);
        }

        void LoadToaThuoc()
        {
            toathuocList.DataSource = ToaThuoc_DAL.Instance.GetListToaThuocByBenhNhanID(IDBenhNhan);
        }

        void LoadCTTT(int id)
        {
            chitiettoathuoclist.DataSource = CTTT_DAL.Instance.GetListCTTTByMaToaThuocID(id);
        }

        void LoadNhapVien()
        {
            nhapvienList.DataSource = NhapVien_DAL.Instance.GetListNhapVienByBenhNhanID(IDBenhNhan);
        }
        #endregion

        #region events
        private void btnXemNV_Click(object sender, EventArgs e)
        {
            LoadNhapVien();
        }

        private void btXemKQ_Click(object sender, EventArgs e)
        {
            LoadKetQua();
        }

        private void btTimKetQua_Click(object sender, EventArgs e)
        {
            TimKetQua(IDBenhNhan ,txtTimKetQua.Text);
        }

        private void btnXemLanKham_Click(object sender, EventArgs e)
        {
            LoadListLanKham();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimLanKham(dtTimNgay.Value);
        }

        private void txtMaToaThuoc_TextChanged(object sender, EventArgs e)
        {
            LoadCTTT(Convert.ToInt32(txtMaToaThuoc.Text));
            AddCTTTBindding();
            LoadToaThuocIntoCbx(cbxMaToaThuoc);
        }

        #endregion






    }
}

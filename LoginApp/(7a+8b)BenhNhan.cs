using DAL;
using DTO;
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
    public partial class BenhNhan : Form
    {
        public int IDBenhNhan, MaKhoa;
        BindingSource ketquaList = new BindingSource();
        BindingSource nhapvienList = new BindingSource();
        BindingSource toathuocList = new BindingSource();
        BindingSource chitiettoathuoclist = new BindingSource();
        BindingSource lankhamList = new BindingSource();

        public LanKham lankham;
        public BenhNhan(int id, int makhoa)
        {
            InitializeComponent();
            IDBenhNhan = id;
            MaKhoa = makhoa;
            LoadThongTinBenhNhan();
            Upload();
        }



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

        void AddLanKham(int MaBenhNhan, int MaKhoa, DateTime NgayKham)
        {
            if (LanKham_DAL.Instance.AddLanKham(MaBenhNhan, MaKhoa, NgayKham))
            {
                MessageBox.Show("Thêm lần khám thành công");
            }
            else
                MessageBox.Show("Thêm lần khám thất bại ");
            LoadListLanKham();
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
        
        void TimKetQua(int id,string ketqua)
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


        void AddKetQua(int a,string b)
        {
            if (KetQua_DAL.Instance.AddKetQua(a, b))
            {
                MessageBox.Show("Thêm kết quả thành công");
            }
            else
            {
                MessageBox.Show("Thêm kết quả thất bại");
            }
            LoadKetQua();
        }

        void UpdateKetQua(int a, int b, string c)
        {
            if (KetQua_DAL.Instance.UpdateKetQua(a, b, c))
            {
                MessageBox.Show("Sửa kết quả thành công");
            }
            else
            {
                MessageBox.Show("Sửa kết quả thất bại");
            }
            LoadKetQua();
        }

        void DeleteKetQua(int d)
        {
            if (KetQua_DAL.Instance.DeleteKetQua(d))
            {
                MessageBox.Show("Xóa kết quả thành công");
            }
            else
            {
                MessageBox.Show("Xóa kết quả thất bại");
            }
            LoadKetQua();
        }

        void AddNhapVien(int a,DateTime b ,DateTime c)
        {
            if (NhapVien_DAL.Instance.AddNhapVien(a, b, c))
            {
                MessageBox.Show("Thêm nhập viện thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhập viện thất bại");
            }
            LoadNhapVien();
        }

        void UpdateNhapVien(int d,int a, DateTime b, DateTime c)
        {
            if (NhapVien_DAL.Instance.UpdateNhapVien(d,a, b, c))
            {
                MessageBox.Show("Sửa nhập viện thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhập viện thất bại");
            }
            LoadNhapVien();
        }

        void DeleteNhapVien(int d)
        {
            if(NhapVien_DAL.Instance.DeleteNhapVien(d))
            {
                MessageBox.Show("Xóa nhập viện thành công");
            }
            else
            {
                MessageBox.Show("Xóa nhập viện thất bại");
            }
            LoadNhapVien();
        }

        void AddToaThuoc(int maketqua, int songay)
        {
            if (ToaThuoc_DAL.Instance.AddToaThuoc( maketqua, songay))
            {
                MessageBox.Show("Thêm toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Thêm toa thuốc thất bại");
            }
            LoadToaThuoc();
        }

        void UpdateToaThuoc(int matoathuoc, int maketqua, int songay)
        {
            if (ToaThuoc_DAL.Instance.UpdateToaThuoc(matoathuoc, maketqua, songay))
            {
                MessageBox.Show("Sửa toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Sửa toa thuốc thất bại");
            }
            LoadToaThuoc();

        }

        void DeleteToaThuoc(int matoathuoc)
        {
            if (ToaThuoc_DAL.Instance.DeleteToaThuoc(matoathuoc)) 
            {
                MessageBox.Show("Xóa toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Xóa toa thuốc thất bại");
            }
            LoadToaThuoc();
        }

        void AddCTTT(int matoathuoc, int mathuoc, int soluong)
        {
            if (CTTT_DAL.Instance.AddCTTT( matoathuoc, soluong, mathuoc))
            {
                MessageBox.Show("Thêm chi tiết toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết toa thuốc thất bại");
            }
            LoadCTTT(Convert.ToInt32(txtMaToaThuoc.Text));
        }

        void UpdateCTTT(int maCTTT, int matoathuoc, int mathuoc, int soluong )
        {
            if (CTTT_DAL.Instance.UpdateCTTT(maCTTT, matoathuoc, soluong, mathuoc))
            {
                MessageBox.Show("Sửa chi tiết toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Sửa chi tiết toa thuốc thất bại");
            }
            LoadCTTT(Convert.ToInt32(txtMaToaThuoc.Text));
        }

        void DeleteCTTT(int maCTTT)
        {
            if (CTTT_DAL.Instance.DeleteCTTT(maCTTT))
            {
                MessageBox.Show("Xóa chi tiết toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Xóa chi tiết toa thuốc thất bại");
            }
            LoadCTTT(Convert.ToInt32(txtMaToaThuoc.Text));
        }






        #endregion

        #region event
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (cbxMaKetQua.Text.Length == 0)
                MessageBox.Show("Vui lòng nhập kết quả trước");
            else
            {
                int a = Convert.ToInt32(cbxMaKetQua.Text);
                DateTime b = (DateTime)dtpkNgayNhap.Value;
                DateTime c = (DateTime)dtpkNgayXuat.Value;
                AddNhapVien(a, b, c);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (cbxMaKetQua.Text.Length == 0)
                MessageBox.Show("Vui lòng thêm nhập viện trước");
            else
            {
                if (txtMaNhapVien.Text.Length == 0)
                { MessageBox.Show("Vui lòng thêm nhập viện "); }
                else
                { int a = Convert.ToInt32(txtMaNhapVien.Text);
                DeleteNhapVien(a);
                }
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (cbxMaKetQua.Text.Length == 0)
                MessageBox.Show("Vui lòng thêm nhập viện trước");
            else
            {
                if (txtMaNhapVien.Text.Length == 0)
                    MessageBox.Show("Không có lần nhập viện nào");
                else
                {
                    int a = Convert.ToInt32(cbxMaKetQua.SelectedValue);
                    DateTime b = (DateTime)dtpkNgayNhap.Value;
                    DateTime c = (DateTime)dtpkNgayXuat.Value;
                    int d = Convert.ToInt32(txtMaNhapVien.Text);
                    UpdateNhapVien(d, a, b, c);
                }
            }
        }

        private void btnXemNV_Click(object sender, EventArgs e)
        {
            LoadNhapVien();
          
        }

        private void btThemKQ_Click(object sender, EventArgs e)
        {
            
                int a = Convert.ToInt32(cbxMaLanKham.Text);
                string b = txtKetQua.Text;
                AddKetQua(a, b);
                LoadKetQuaIntoCbx(cbxMaKetQuaByKetQua);
            LoadKetQuaIntoCbx(cbxMaKetQua);
        }

        private void btXoaKQ_Click(object sender, EventArgs e)
        {
            if (txtMaKQ.Text.Length == 0)
                MessageBox.Show("Không có kết quả khám");
            else
            {
                int a = Convert.ToInt32(txtMaKQ.Text);
                DeleteKetQua(a);
            }
        }

        private void btSuaKQ_Click(object sender, EventArgs e)
        {
            if (txtMaKQ.Text.Length == 0)
                MessageBox.Show("Không có kết quả khám");
            else
            {
                int a = Convert.ToInt32(cbxMaLanKham.Text);
                int b = Convert.ToInt32(txtMaKQ.Text);
                string c = txtKetQua.Text;
                UpdateKetQua(a, b, c);
            }
           
           

        }

        private void btXemKQ_Click(object sender, EventArgs e)
        {
            LoadKetQua();
        }

      

        private void btXemTT_Click(object sender, EventArgs e)
        {
            LoadToaThuoc();
        }

        private void btThemTT_Click(object sender, EventArgs e)
        {
            if (cbxMaKetQuaByKetQua.Text.Length == 0)
                MessageBox.Show("Vui long thêm kết quả khám trước");
            else
            {
                LoadToaThuocIntoCbx(cbxMaToaThuoc);
                int maketqua = Convert.ToInt32(cbxMaKetQua.SelectedValue);
                int songay = Convert.ToInt32(nmSoNgay.Value);
                AddToaThuoc(maketqua, songay);
            }
        }

        private void btXoaTT_Click(object sender, EventArgs e)
        {
            if (cbxMaKetQuaByKetQua.Text.Length == 0)
                MessageBox.Show("Vui long thêm toa thuốc khám trước");
            else
            {
                int maTT = Convert.ToInt32(txtMaToaThuoc.Text);
                DeleteToaThuoc(maTT);
            }

        }

        private void btSuaTT_Click(object sender, EventArgs e)
        {
            if (cbxMaKetQuaByKetQua.Text.Length == 0)
                MessageBox.Show("Vui long thêm toa thuốc khám trước");
            else
            {
                int matoathuoc = Convert.ToInt32(txtMaToaThuoc.Text);
                int maketqua = Convert.ToInt32(cbxMaKetQua.Text);
                int songay = Convert.ToInt32(nmSoNgay.Value);
                UpdateToaThuoc(matoathuoc, maketqua, songay);
            }

        }

        private void btThemCTTT_Click(object sender, EventArgs e)
        {
            if (txtMaToaThuoc.Text.Length == 0)
                MessageBox.Show("Vui lòng thêm toa thuốc");
            else
            {
                int matoathuoc = Convert.ToInt32(txtMaToaThuoc.Text);
                int mathuoc = Convert.ToInt32(cbxThuoc.SelectedValue);
                int sovien = Convert.ToInt32(nmSovien.Value);
                AddCTTT(matoathuoc, mathuoc, sovien);
            }

        }

        private void btXoaCTTT_Click(object sender, EventArgs e)
        {
            if (txtMaCTTT.Text.Length == 0)
                MessageBox.Show("Không có chi tiết thuốc nào");
            else
            {
                int maCTTT = Convert.ToInt32(txtMaCTTT.Text);
                DeleteCTTT(maCTTT);
            }

        }

        private void btSuaCTTT_Click(object sender, EventArgs e)
        {
            if (txtMaCTTT.Text.Length == 0)
                MessageBox.Show("Không có chi tiết thuốc nào");
            else
            {
                int maCTTT = Convert.ToInt32(txtMaCTTT.Text);
                int matoathuoc = Convert.ToInt32(cbxMaToaThuoc.SelectedValue);
                int mathuoc = Convert.ToInt32(cbxThuoc.SelectedValue);
                int sovien = Convert.ToInt32(nmSovien.Value);
                UpdateCTTT(maCTTT, matoathuoc, mathuoc, sovien);
            }

        }

        private void btnXemLanKham_Click(object sender, EventArgs e)
        {
            LoadListLanKham();
        }

        private void btnSuaLanKham_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMaLanKham.Text);
            int b = Convert.ToInt32(txtMaBenhNhan.Text);
            int c = Convert.ToInt32(txtMaKhoa.Text);
            DateTime d = (DateTime)dtpkNgayKham.Value;
            string f = txtTinhTrang.Text;

            UpdateLanKham(a, b, c, d, f);
        }

        private void btnXoaLanKham_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMaLanKham.Text);
            DeleteLanKham(a);
        }

        private void btThêmLanKham_Click(object sender, EventArgs e)
        {

            DateTime d = (DateTime)dtpkNgayKham.Value;

            AddLanKham(IDBenhNhan, MaKhoa, d);

        }

        private void btTimKetQua_Click(object sender, EventArgs e)
        {
            TimKetQua(IDBenhNhan ,txtTimKetQua.Text);
        }

        private void txtMaToaThuoc_TextChanged(object sender, EventArgs e)
        {

            if (txtMaToaThuoc.Text.Length == 0)
            {
                btXoaTT.Enabled = false;
                btSuaTT.Enabled = false;
            }
            else
            {
                LoadCTTT(Convert.ToInt32(txtMaToaThuoc.Text));
                AddCTTTBindding();
                LoadToaThuocIntoCbx(cbxMaToaThuoc);
                btXoaTT.Enabled = true;
                btSuaTT.Enabled = true;
            }
        }

        private void txtMaKQ_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKQ.Text.Length == 0)
            {
                btXoaKQ.Enabled = false;
                btSuaKQ.Enabled = false;
                
            }
            else
            {
                btXoaKQ.Enabled = true;
                btSuaKQ.Enabled = true;
            }
        }

        private void txtMaNhapVien_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNhapVien.Text.Length == 0)
            {
                btnXoaNV.Enabled = false;
                btnSuaNV.Enabled = false;
            }
            else
            {
                btnXoaNV.Enabled = true;
                btnSuaNV.Enabled = true;
            }
        }

        private void txtMaCTTT_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCTTT.Text.Length == 0)
            {
                btXoaCTTT.Enabled = false;
                btSuaCTTT.Enabled = false;
            }
            else
            {
                btXoaCTTT.Enabled = true;
                btSuaCTTT.Enabled = true;
            }
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


        private void btnTim_Click(object sender, EventArgs e)
        {
            TimLanKham(dtTimNgay.Value);
        }



        #endregion


    }
}

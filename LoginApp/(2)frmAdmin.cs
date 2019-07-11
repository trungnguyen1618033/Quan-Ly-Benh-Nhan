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
    public partial class frmAdmin : Form
    {

        BindingSource accountList = new BindingSource();
        BindingSource PhongList = new BindingSource();
        BindingSource ThuocList = new BindingSource();

        public Account loginAccount;
        public frmAdmin()
        {
            InitializeComponent();
            UpLoad();
          
        }

        #region methods

        void UpLoad()
        {
            dtgvTaiKhoan.DataSource = accountList;
            dtgvPhongBenh.DataSource = PhongList;
            dtgvThuoc.DataSource = ThuocList;
  
            LoadLoaiPhongIntoCbx(cbxLoaiPhong);
            LoadTenKhoaIntoCombobox(cbxTenKhoa);
            LoadLoaiPhongIntoCbx(cbxTimLoaiPhong);
            LoadAccount();
            AddAccountBinding();
            LoadListThuoc();
            AddThuocBinding();
            LoadListPhong();
            AddPhongBinding();


        }


        void LoadLoaiPhongIntoCbx(ComboBox cb)
        {
            cb.DataSource = LoaiPhong_DAL.Instance.GetListLoaiPhong();
            cb.DisplayMember = "TENLOAIPHONG";
            cb.ValueMember = "MALOAIPHONG";

        }
        void AddPhongBinding()
        {
            txtMaPhong.DataBindings.Add(new Binding("Text", dtgvPhongBenh.DataSource, "MAPHONG", true, DataSourceUpdateMode.Never));
            cbxLoaiPhong.DataBindings.Add(new Binding("SelectedValue", dtgvPhongBenh.DataSource, "MALOAIPHONG", true, DataSourceUpdateMode.Never));
            nmSoGiuong.DataBindings.Add(new Binding("Value", dtgvPhongBenh.DataSource, "SOGIUONG", true, DataSourceUpdateMode.Never));
            txtSoBenhNhan.DataBindings.Add(new Binding("Text", dtgvPhongBenh.DataSource, "SOBENHNHAN", true, DataSourceUpdateMode.Never));
        }
        void LoadListPhong()
        {
            PhongList.DataSource = Phong_DAL.Instance.GetListPhong();
        }

        void AddThuocBinding()
        {
           
            txtMaThuoc.DataBindings.Add(new Binding("Text", dtgvThuoc.DataSource, "MATHUOC", true, DataSourceUpdateMode.Never));
            txtTenThuoc.DataBindings.Add(new Binding("Text", dtgvThuoc.DataSource, "TENTHUOC", true, DataSourceUpdateMode.Never));
            nmDonGia.DataBindings.Add(new Binding("Text", dtgvThuoc.DataSource, "DONGIA", true, DataSourceUpdateMode.Never));
            nmSoLuong.DataBindings.Add(new Binding("Text", dtgvThuoc.DataSource, "SOLUONG", true, DataSourceUpdateMode.Never));
        }
        void LoadListThuoc()
        {
            ThuocList.DataSource = Thuoc_DAL.Instance.GetListThuoc();
        }
     

        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "USERNAME",true, DataSourceUpdateMode.Never));
            txtTen.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "TEN", true, DataSourceUpdateMode.Never));
            txtChucVu.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "CHUCVU", true, DataSourceUpdateMode.Never));
            cbxTenKhoa.DataBindings.Add(new Binding("SelectedValue", dtgvTaiKhoan.DataSource, "MAKHOA", true, DataSourceUpdateMode.Never));
            nmLoaiTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "type", true, DataSourceUpdateMode.Never));
        }


        void LoadTenKhoaIntoCombobox(ComboBox cb)
        {
            cb.DataSource = Khoa_DAL.Instance.GetListKhoa();
            cb.DisplayMember = "TENKHOA";
            cb.ValueMember = "MAKHOA";
          
            
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAL.Instance.GetListAccount();
        }

        void AddAccount(string username, string ten, string chucvu, int makhoa, int type)
        {
            if (AccountDAL.Instance.InsertAccount(username, ten, chucvu, makhoa, type))
                MessageBox.Show("Thêm tài khoản thành công");
            else
                MessageBox.Show("Thêm tài khoản thất bại");
            LoadAccount();
        }

        void EditAccount(string username, string ten, string chucvu, int makhoa, int type)
        {
            if (AccountDAL.Instance.UpdateAccount(username, ten, chucvu, makhoa, type)) 
                MessageBox.Show("Cập nhập tài khoản thành công");
            else
                MessageBox.Show("Cập nhập tài khoản thất bại");
            LoadAccount();
        }

        void DeleteAccount(string id)
        {   
            if(loginAccount.UserName.Equals(id))
            {
                MessageBox.Show("Không thể xóa tài khoản hiện hành");
                return;
            }
            if (AccountDAL.Instance.DeleteAccount(id))
                MessageBox.Show("Xóa tài khoản thành công");
            else
                MessageBox.Show("Xóa tài khoản thất bại");
            LoadAccount();
        }

        void AddPhong(int  sg,  int mp)
        {
            if (Phong_DAL.Instance.AddPhong(sg,  mp))
            {
                MessageBox.Show("Thêm phòng thành công");
            }
            else
            {
                MessageBox.Show("Thêm phòng  thất bại");
            }
            LoadListPhong();
        }
        void UpdatePhong(int mp, int sg, int mlp)
        {
            if (Phong_DAL.Instance.UpdatePhong(mp, sg, mlp))
            {
                MessageBox.Show("Sửa phòng thành công");
            }
            else
            {
                MessageBox.Show("Sửa phòng thất bại");
            }
            LoadListPhong();
        }
        void DeletePhong(int mp)
        {
            if (Phong_DAL.Instance.DeletePhong(mp))
            {
                MessageBox.Show("Xóa phòng thành công");
            }
            else
            {
                MessageBox.Show("Xóa phong  thất bại");
            }
            LoadListPhong();
        }

        void AddThuoc( string tt, int dongia , int soluong)
        {
            if (Thuoc_DAL.Instance.AddThuoc( tt, dongia, soluong))
            {
                MessageBox.Show("Thêm thuốc thành công");
                LoadListThuoc();
            }
            else
            {
                MessageBox.Show("Thêm thuốc  thất bại");
            }
            
        }
        void UpdateThuoc(int mt, string tt, int dongia, int soluong)
        {
            if (Thuoc_DAL.Instance.UpdateThuoc(mt, tt, dongia, soluong))
            {
                MessageBox.Show("Sửa thuốc thành công");
                LoadListThuoc();
            }
            else
            {
                MessageBox.Show("Sửa thuốc  thất bại");
            }
           
        }
        void DeleteThuoc(int mt)
        {
            if (Thuoc_DAL.Instance.DeleteThuoc(mt))
            {
                MessageBox.Show("Xóa thuốc thành công");
                LoadListThuoc();
            }
            else
            {
                MessageBox.Show("Xóa Thuốc thất bại");
            }
            
        }


        void TimAccount(string name)
        {

            accountList.DataSource = AccountDAL.Instance.GetListAccountByTen(name);
        }

        void TimPhong(int loaiphong)
        {
            PhongList.DataSource = Phong_DAL.Instance.GetLisPhongByLoaiPhongID(loaiphong);
        }

        void TimThuoc(string name)
        {
            ThuocList.DataSource = Thuoc_DAL.Instance.GetListThuocByTen(name);
        }

        void ResetPassword(string name)
        {
            if (AccountDAL.Instance.ResetPassword(name))
                MessageBox.Show("Đặt lại mật khẩu tài khoản thành công");
            else
                MessageBox.Show("Đặt lại mật khẩu tài khoản thất bại");
        }

        #endregion



        #region events

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
           
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
                string username = txtUserName.Text;
                string ten = txtTen.Text;
                string chucvu = txtChucVu.Text;
                int type = Convert.ToInt32(nmLoaiTaiKhoan.Value);
                int makhoa = Convert.ToInt32(cbxTenKhoa.SelectedValue);
                AddAccount(username, ten, chucvu, makhoa, type);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string ten = txtTen.Text;
            string chucvu = txtChucVu.Text;
            int makhoa = Convert.ToInt32(cbxTenKhoa.SelectedValue);
            int type = Convert.ToInt32(nmLoaiTaiKhoan.Value);

            EditAccount(userName ,ten, chucvu, makhoa, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            DeleteAccount(userName);
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {      

            int maloaiphong = Convert.ToInt32(cbxLoaiPhong.SelectedValue.ToString());
            int sogiuong = (int)nmSoGiuong.Value;
           
            AddPhong(sogiuong, maloaiphong);

        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            int maphong = Convert.ToInt32(txtMaPhong.Text);

            DeletePhong(maphong);
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            int maphong = Convert.ToInt32(txtMaPhong.Text);
            int maloaiphong = Convert.ToInt32(cbxLoaiPhong.SelectedValue);
            int sogiuong = Convert.ToInt32(nmSoGiuong.Value);
          

            UpdatePhong(maphong, sogiuong, maloaiphong);
        }
        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
          
            string tenthuoc = txtTenThuoc.Text;
            int dongia = (int)nmDonGia.Value;
            int soluong = (int)nmSoLuong.Value;
            AddThuoc(tenthuoc, dongia, soluong);
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaThuoc.Text);
            DeleteThuoc(id);
        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaThuoc.Text);
            string tenthuoc = txtTenThuoc.Text;
            int dongia = (int)nmDonGia.Value;
            int soluong = (int)nmSoLuong.Value;
            UpdateThuoc(id, tenthuoc, dongia, soluong);
        }

        private void btnXemThuoc_Click(object sender, EventArgs e)
        {
            LoadListThuoc();
          
            
        }

        private void BtnXemPhong_Click(object sender, EventArgs e)
        {

            LoadListPhong();
         
        }





        private void btTimPhong_Click(object sender, EventArgs e)
        {
            TimPhong(Convert.ToInt32(cbxTimLoaiPhong.SelectedValue));
        }

        private void btTimThuoc_Click(object sender, EventArgs e)
        {
            TimThuoc(txtTimThuoc.Text);
        }

        private void btTimAccount_Click(object sender, EventArgs e)
        {
            TimAccount(txtTimAccount.Text);
        }

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword(txtUserName.Text);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                btnDeleteAccount.Enabled = false;
                btnUpdateAccount.Enabled = false;
            }
            else
            {
                btnDeleteAccount.Enabled = true;
                btnUpdateAccount.Enabled = true;
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Length == 0)
            {
                btnXoaPhong.Enabled = false;
                btnThemPhong.Enabled = false;
            }
            else
            {
                btnXoaPhong.Enabled = true;
                btnThemPhong.Enabled = true;
            }
        }

        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text.Length == 0)
            {
                btnSuaThuoc.Enabled = false;
                btnXoaThuoc.Enabled = false;
            }
            else
            {
                btnSuaThuoc.Enabled = true;
                btnXoaThuoc.Enabled = true;
            }
        }




        #endregion


    }
}

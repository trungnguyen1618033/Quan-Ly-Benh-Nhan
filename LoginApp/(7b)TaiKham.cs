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
    public partial class TaiKham : Form
    {
        public TaiKham()
        {
            InitializeComponent();
            
            UpLoad();

        }

        BindingSource benhnhanList = new BindingSource();
     
        #region methods

        void UpLoad()
        {
          
            dtgvBenhNhan.DataSource = benhnhanList;
            LoadBenhNhan();
            AddBenhNhanBinding();
            LoadKhoaIntoCbx(cbxKhoa);

        }

        void AddBenhNhanBinding()
        {
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", dtgvBenhNhan.DataSource, "MABENHNHAN", true, DataSourceUpdateMode.Never));
        }

        void TimBenhNhan(string name)
        {
            benhnhanList.DataSource = BenhNhan_DAL.Instance.GetListBenhNhanByTen(name);
        }

        void LoadKhoaIntoCbx(ComboBox cb)
        {
            cb.DataSource = Khoa_DAL.Instance.GetListKhoa();
            cb.DisplayMember = "TENKHOA";
            cb.ValueMember = "MAKHOA";
        }


        void LoadBenhNhan()
        {
            benhnhanList.DataSource = BenhNhan_DAL.Instance.GetListBenhNhan();
        }

      

        void DangKyTaiKham(int mabenhnhan, int makhoa, DateTime date)
        {
            if (LanKham_DAL.Instance.AddLanKham(mabenhnhan, makhoa, date))
                MessageBox.Show("Đăng ký thành công");
            else
                MessageBox.Show("Đăng ký thất bại");
        }

        #endregion

        #region event
        private void btDangKy_Click(object sender, EventArgs e)
        {
            int mabenhnhan = Convert.ToInt32(txtMaBenhNhan.Text);
            int makhoa = Convert.ToInt32(cbxKhoa.SelectedValue);
            DateTime date = dtNgay.Value;
            DangKyTaiKham(mabenhnhan, makhoa, date);


        }

        private void btXemBenhNhan_Click_1(object sender, EventArgs e)
        {
            LoadBenhNhan();

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            TimBenhNhan(txtTimBenhNhan.Text);
        }

        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaBenhNhan.Text.Length == 0)
                btDangKy.Enabled = false;
            else
                btDangKy.Enabled = true;
        }


        #endregion


    }
}

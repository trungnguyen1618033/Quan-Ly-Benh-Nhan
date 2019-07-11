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
    public partial class LichKhamTrongNgay : Form
    {

        BindingSource khambenhList = new BindingSource();

        private Account loginAccount;
        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }

            set
            {
                loginAccount = value;   
            }
        }

        Account a;


        #region methods
        void AddLanKhamBinding()
        {
            txtMaLanKham.DataBindings.Add(new Binding("Text", dtgvLichKham.DataSource, "MALANKHAM", true, DataSourceUpdateMode.Never));
            txtTenBenhNhan.DataBindings.Add(new Binding("Text", dtgvLichKham.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            txtMaBenhNhan.DataBindings.Add(new Binding("Text", dtgvLichKham.DataSource, "MABENHNHAN", true, DataSourceUpdateMode.Never));
            dtNgaySinh.DataBindings.Add(new Binding("Value", dtgvLichKham.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
          
        }

        public LichKhamTrongNgay(Account acc)
        {
            InitializeComponent();
            a = acc;
            dtgvLichKham.DataSource = khambenhList;
            LichKham();
            AddLanKhamBinding();
            
        }

        void LichKham()
        {
            khambenhList.DataSource = LanKham_DAL.Instance.GetListLanKhamByKhoaAndNgay(a.MaKhoa, DateTime.Now);
        }
        #endregion

        #region event

        private void btKhamBenh_Click(object sender, EventArgs e)
        {

            if (txtMaBenhNhan.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn bệnh nhân");
            else
            {
                LanKham_DAL.Instance.UpdateTinhTrangLanKham(Convert.ToInt32(txtMaLanKham.Text));
                BenhNhan t = new BenhNhan(Convert.ToInt32(txtMaBenhNhan.Text), a.MaKhoa);
                t.Show();
                LichKham();
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            LichKham();
        }

        private void txtMaLanKham_TextChanged(object sender, EventArgs e)
        {
            if (txtMaLanKham.Text.Length == 0)
                btKhamBenh.Enabled = false;
            else
                btKhamBenh.Enabled = true;
        }
        #endregion


    }
}

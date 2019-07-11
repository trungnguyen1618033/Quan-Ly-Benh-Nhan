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
    public partial class DanhSachPhong : Form
    {
        public DanhSachPhong()
        {
            InitializeComponent();
            Loadform();
            
        }

        BindingSource phonglist = new BindingSource();

        #region Methods

        

        void GetListLoaiPhongIntoCbx(ComboBox cb)
        {
            cb.DataSource = LoaiPhong_DAL.Instance.GetListLoaiPhong();
            cb.DisplayMember = "TENLOAIPHONG";
            cb.ValueMember = "MALOAIPHONG";
        }
        void Loadform()
        {
            phongdtgv.DataSource = phonglist;
            GetListLoaiPhongIntoCbx(cbxTenLoaiPhong);
            GetListLoaiPhongIntoCbx(cbxLoaiPhong);
            LoadListPhong();
            AddPhongBinding();
        }

        void AddPhongBinding()
        {
            txtMaPhong.DataBindings.Add(new Binding("Text", phongdtgv.DataSource, "MAPHONG", true, DataSourceUpdateMode.Never));
            txtSoGiuong.DataBindings.Add(new Binding("Text", phongdtgv.DataSource, "SOGIUONG", true, DataSourceUpdateMode.Never));
            txtSoBenhNhan.DataBindings.Add(new Binding("Text", phongdtgv.DataSource, "SOBENHNHAN", true, DataSourceUpdateMode.Never));
            cbxTenLoaiPhong.DataBindings.Add(new Binding("SelectedValue", phongdtgv.DataSource, "MALOAIPHONG", true, DataSourceUpdateMode.Never));
        }

        void LoadListPhong()
        {
            phonglist.DataSource = Phong_DAL.Instance.GetListPhong();
        }

        void TimPhong()
        {
            phonglist.DataSource = Phong_DAL.Instance.GetLisPhongByLoaiPhongID(Convert.ToInt32(cbxLoaiPhong.SelectedValue));
        }


        #endregion

        #region Events
        private void btTim_Click(object sender, EventArgs e)
        {
            TimPhong();
        }

        private void BtnXemPhong_Click(object sender, EventArgs e)
        {
            LoadListPhong();
        }


        #endregion


    }
}

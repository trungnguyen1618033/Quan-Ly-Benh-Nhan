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
    public partial class fTableManage : Form
    {
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
                ChangeAccount(LoginAccount.Type);
            }
        }

        public fTableManage(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 0;
            BacSy.Enabled = type == 1;
            YTa.Enabled = type == 2;
            thoToolStripMenuItem.Text += " (" + LoginAccount.Ten + ")";
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount(LoginAccount);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmAdmin f = new frmAdmin();
            f.loginAccount = LoginAccount;
            f.TopLevel = false;
            f.AutoScroll = true;
            pnMain.Controls.Add(f);
            f.Show();
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DoiMatKhau dmk = new DoiMatKhau(loginAccount);
            dmk.ShowDialog();
        }

        private void đăngKýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DangKy d = new DangKy();
            d.TopLevel = false;
            d.AutoScroll = true;
            pnMain.Controls.Add(d);
            d.Show();
        }

        private void đăngKýKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            TaiKham tk = new TaiKham();
            tk.TopLevel = false;
            tk.AutoScroll = true;
            pnMain.Controls.Add(tk);
            tk.Show();
        }

        private void đăngKýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DangKyNhapVien dknv = new DangKyNhapVien();
            dknv.TopLevel = false;
            dknv.AutoScroll = true;
            pnMain.Controls.Add(dknv);
            dknv.Show();
        }

      

        private void danhSáchLầnKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DanhSachLanKham dslk = new DanhSachLanKham();
            dslk.TopLevel = false;
            dslk.AutoScroll = true;
            pnMain.Controls.Add(dslk);
            dslk.Show();
        }

        private void danhSáchNhậpViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DanhSachChiTietNhapVien dsctnv = new DanhSachChiTietNhapVien();
            dsctnv.TopLevel = false;
            dsctnv.AutoScroll = true;
            pnMain.Controls.Add(dsctnv);
            dsctnv.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DanhSachToaThuoc dstt = new DanhSachToaThuoc();
            dstt.TopLevel = false;
            dstt.AutoScroll = true;
            pnMain.Controls.Add(dstt);
            dstt.Show();
        }

        private void DanhsachPhongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DanhSachPhong dsp = new DanhSachPhong();
            dsp.TopLevel = false;
            dsp.AutoScroll = true;
            pnMain.Controls.Add(dsp);
            dsp.Show();
        }

        private void danhsachBenhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DanhSachBenhNhan dsbn = new DanhSachBenhNhan();
            dsbn.TopLevel = false;
            dsbn.AutoScroll = true;
            pnMain.Controls.Add(dsbn);
            dsbn.Show();
        }

        

        private void chiTiếtToaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            ChiTietToaThuoc cttt = new ChiTietToaThuoc();
            cttt.TopLevel = false;
            cttt.AutoScroll = true;
            pnMain.Controls.Add(cttt);
            cttt.Show();
        }

        private void lịchKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            LichKhamTrongNgay l = new LichKhamTrongNgay(this.LoginAccount);
            l.TopLevel = false;
            l.AutoScroll = true;
            pnMain.Controls.Add(l);
            l.Show();
        }

        private void tìmKiếmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            TimKiemBenhNhan t = new TimKiemBenhNhan();
            t.TopLevel = false;
            t.AutoScroll = true;
            pnMain.Controls.Add(t);
            t.Show();
        }
    }
}

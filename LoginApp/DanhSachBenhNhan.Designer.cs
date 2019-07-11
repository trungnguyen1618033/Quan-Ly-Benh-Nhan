namespace LoginApp
{
    partial class DanhSachBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BenhNhandtgv = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MaBenhNhantxt = new System.Windows.Forms.TextBox();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BenhNhandtgv)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BenhNhandtgv);
            this.groupBox1.Location = new System.Drawing.Point(76, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // BenhNhandtgv
            // 
            this.BenhNhandtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BenhNhandtgv.Location = new System.Drawing.Point(6, 19);
            this.BenhNhandtgv.Name = "BenhNhandtgv";
            this.BenhNhandtgv.Size = new System.Drawing.Size(748, 401);
            this.BenhNhandtgv.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnXem);
            this.panel17.Controls.Add(this.btnSua);
            this.panel17.Controls.Add(this.btnXoa);
            this.panel17.Location = new System.Drawing.Point(82, 22);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(759, 63);
            this.panel17.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.BackgroundImage = global::LoginApp.Properties.Resources.IconView;
            this.btnXem.Location = new System.Drawing.Point(577, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 57);
            this.btnXem.TabIndex = 0;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::LoginApp.Properties.Resources.IconModify;
            this.btnSua.Location = new System.Drawing.Point(343, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 57);
            this.btnSua.TabIndex = 0;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::LoginApp.Properties.Resources.IconDelete;
            this.btnXoa.Location = new System.Drawing.Point(131, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 57);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel16);
            this.panel11.Controls.Add(this.panel4);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(858, 22);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(407, 492);
            this.panel11.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtTim);
            this.panel16.Controls.Add(this.btnTim);
            this.panel16.Location = new System.Drawing.Point(8, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(390, 63);
            this.panel16.TabIndex = 3;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(17, 19);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(203, 20);
            this.txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::LoginApp.Properties.Resources.IconSearch;
            this.btnTim.Location = new System.Drawing.Point(226, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 57);
            this.btnTim.TabIndex = 0;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMaBenhNhan);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(8, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 46);
            this.panel4.TabIndex = 2;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBenhNhan.Location = new System.Drawing.Point(124, 12);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.ReadOnly = true;
            this.txtMaBenhNhan.Size = new System.Drawing.Size(261, 22);
            this.txtMaBenhNhan.TabIndex = 1;
            this.txtMaBenhNhan.TextChanged += new System.EventHandler(this.txtMaBenhNhan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Bệnh Nhân:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MaBenhNhantxt);
            this.panel3.Controls.Add(this.lblMaBenhNhan);
            this.panel3.Location = new System.Drawing.Point(8, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 46);
            this.panel3.TabIndex = 2;
            // 
            // MaBenhNhantxt
            // 
            this.MaBenhNhantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaBenhNhantxt.Location = new System.Drawing.Point(117, 12);
            this.MaBenhNhantxt.Name = "MaBenhNhantxt";
            this.MaBenhNhantxt.Size = new System.Drawing.Size(222, 22);
            this.MaBenhNhantxt.TabIndex = 1;
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Enabled = false;
            this.lblMaBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBenhNhan.Location = new System.Drawing.Point(3, 12);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(119, 20);
            this.lblMaBenhNhan.TabIndex = 2;
            this.lblMaBenhNhan.Text = "Mã Bệnh Nhân:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dtNgaySinh);
            this.panel14.Controls.Add(this.lblNgaySinh);
            this.panel14.Location = new System.Drawing.Point(8, 298);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(393, 46);
            this.panel14.TabIndex = 1;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(126, 12);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtNgaySinh.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Enabled = false;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(3, 12);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Location = new System.Drawing.Point(8, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 92);
            this.panel1.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(124, 12);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(261, 68);
            this.txtDiaChi.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Enabled = false;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(3, 12);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(65, 20);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ: ";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtNgheNghiep);
            this.panel13.Controls.Add(this.lblNgheNghiep);
            this.panel13.Controls.Add(this.panel2);
            this.panel13.Location = new System.Drawing.Point(8, 246);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(393, 46);
            this.panel13.TabIndex = 1;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.Location = new System.Drawing.Point(124, 12);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(261, 22);
            this.txtNgheNghiep.TabIndex = 1;
            // 
            // lblNgheNghiep
            // 
            this.lblNgheNghiep.AutoSize = true;
            this.lblNgheNghiep.Enabled = false;
            this.lblNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgheNghiep.Location = new System.Drawing.Point(3, 12);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(103, 20);
            this.lblNgheNghiep.TabIndex = 2;
            this.lblNgheNghiep.Text = "Nghề nghiệp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSoDienThoai);
            this.panel2.Controls.Add(this.lblSoDienThoai);
            this.panel2.Location = new System.Drawing.Point(7, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 46);
            this.panel2.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(117, 12);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(222, 22);
            this.txtSoDienThoai.TabIndex = 1;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Enabled = false;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(3, 12);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(110, 20);
            this.lblSoDienThoai.TabIndex = 2;
            this.lblSoDienThoai.Text = "Số điện thoại: ";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtGioiTinh);
            this.panel12.Controls.Add(this.lblGioiTinh);
            this.panel12.Location = new System.Drawing.Point(8, 194);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(393, 46);
            this.panel12.TabIndex = 1;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(124, 12);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(261, 22);
            this.txtGioiTinh.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Enabled = false;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(3, 12);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtHoTen);
            this.panel15.Controls.Add(this.lblHoTen);
            this.panel15.Location = new System.Drawing.Point(8, 142);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(393, 46);
            this.panel15.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(124, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(261, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Enabled = false;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(3, 12);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 20);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // DanhSachBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 551);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachBenhNhan";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BenhNhandtgv)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView BenhNhandtgv;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.Label lblNgheNghiep;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox MaBenhNhantxt;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
    }
}
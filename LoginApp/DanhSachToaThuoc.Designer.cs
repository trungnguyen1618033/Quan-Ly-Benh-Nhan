namespace LoginApp
{
    partial class DanhSachToaThuoc
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
            this.ToaThuocdtgv = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnXemToaThuoc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaToaThuoc = new System.Windows.Forms.TextBox();
            this.lblMaToaThuoc = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtMaKetQua = new System.Windows.Forms.TextBox();
            this.lblMaKetQua = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToaThuocdtgv)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToaThuocdtgv);
            this.groupBox1.Location = new System.Drawing.Point(97, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 374);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách toa thuốc";
            // 
            // ToaThuocdtgv
            // 
            this.ToaThuocdtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToaThuocdtgv.Location = new System.Drawing.Point(8, 17);
            this.ToaThuocdtgv.Name = "ToaThuocdtgv";
            this.ToaThuocdtgv.Size = new System.Drawing.Size(643, 349);
            this.ToaThuocdtgv.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnXemToaThuoc);
            this.panel17.Location = new System.Drawing.Point(97, 19);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(649, 63);
            this.panel17.TabIndex = 36;
            // 
            // btnXemToaThuoc
            // 
            this.btnXemToaThuoc.BackgroundImage = global::LoginApp.Properties.Resources.IconView;
            this.btnXemToaThuoc.Location = new System.Drawing.Point(284, 3);
            this.btnXemToaThuoc.Name = "btnXemToaThuoc";
            this.btnXemToaThuoc.Size = new System.Drawing.Size(75, 57);
            this.btnXemToaThuoc.TabIndex = 0;
            this.btnXemToaThuoc.UseVisualStyleBackColor = true;
            this.btnXemToaThuoc.Click += new System.EventHandler(this.btnXemToaThuoc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Location = new System.Drawing.Point(785, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 374);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtNgaySinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 46);
            this.panel2.TabIndex = 43;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(117, 12);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtNgaySinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenBenhNhan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(21, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 46);
            this.panel3.TabIndex = 44;
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenhNhan.Location = new System.Drawing.Point(117, 12);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.ReadOnly = true;
            this.txtTenBenhNhan.Size = new System.Drawing.Size(222, 22);
            this.txtTenBenhNhan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bệnh nhân:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtMaBenhNhan);
            this.panel5.Controls.Add(this.lblMaBenhNhan);
            this.panel5.Location = new System.Drawing.Point(21, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 46);
            this.panel5.TabIndex = 45;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBenhNhan.Location = new System.Drawing.Point(117, 12);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.ReadOnly = true;
            this.txtMaBenhNhan.Size = new System.Drawing.Size(222, 22);
            this.txtMaBenhNhan.TabIndex = 1;
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Enabled = false;
            this.lblMaBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBenhNhan.Location = new System.Drawing.Point(3, 12);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(115, 20);
            this.lblMaBenhNhan.TabIndex = 2;
            this.lblMaBenhNhan.Text = "Mã bệnh nhân:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMaToaThuoc);
            this.panel4.Controls.Add(this.lblMaToaThuoc);
            this.panel4.Location = new System.Drawing.Point(21, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 46);
            this.panel4.TabIndex = 42;
            // 
            // txtMaToaThuoc
            // 
            this.txtMaToaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaToaThuoc.Location = new System.Drawing.Point(117, 12);
            this.txtMaToaThuoc.Name = "txtMaToaThuoc";
            this.txtMaToaThuoc.ReadOnly = true;
            this.txtMaToaThuoc.Size = new System.Drawing.Size(222, 22);
            this.txtMaToaThuoc.TabIndex = 1;
            // 
            // lblMaToaThuoc
            // 
            this.lblMaToaThuoc.AutoSize = true;
            this.lblMaToaThuoc.Enabled = false;
            this.lblMaToaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaToaThuoc.Location = new System.Drawing.Point(3, 12);
            this.lblMaToaThuoc.Name = "lblMaToaThuoc";
            this.lblMaToaThuoc.Size = new System.Drawing.Size(114, 20);
            this.lblMaToaThuoc.TabIndex = 2;
            this.lblMaToaThuoc.Text = "Mã Toa Thuốc:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtSoNgay);
            this.panel12.Controls.Add(this.lblSoNgay);
            this.panel12.Location = new System.Drawing.Point(21, 126);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(342, 46);
            this.panel12.TabIndex = 40;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgay.Location = new System.Drawing.Point(117, 12);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.ReadOnly = true;
            this.txtSoNgay.Size = new System.Drawing.Size(222, 22);
            this.txtSoNgay.TabIndex = 1;
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Enabled = false;
            this.lblSoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgay.Location = new System.Drawing.Point(3, 12);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(69, 20);
            this.lblSoNgay.TabIndex = 2;
            this.lblSoNgay.Text = "Số Ngày";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtMaKetQua);
            this.panel15.Controls.Add(this.lblMaKetQua);
            this.panel15.Location = new System.Drawing.Point(21, 74);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(342, 46);
            this.panel15.TabIndex = 41;
            // 
            // txtMaKetQua
            // 
            this.txtMaKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKetQua.Location = new System.Drawing.Point(117, 12);
            this.txtMaKetQua.Name = "txtMaKetQua";
            this.txtMaKetQua.ReadOnly = true;
            this.txtMaKetQua.Size = new System.Drawing.Size(222, 22);
            this.txtMaKetQua.TabIndex = 1;
            // 
            // lblMaKetQua
            // 
            this.lblMaKetQua.AutoSize = true;
            this.lblMaKetQua.Enabled = false;
            this.lblMaKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKetQua.Location = new System.Drawing.Point(3, 12);
            this.lblMaKetQua.Name = "lblMaKetQua";
            this.lblMaKetQua.Size = new System.Drawing.Size(93, 20);
            this.lblMaKetQua.TabIndex = 2;
            this.lblMaKetQua.Text = "Mã Kết Quả";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtTim);
            this.panel16.Controls.Add(this.btnTim);
            this.panel16.Location = new System.Drawing.Point(785, 19);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(387, 63);
            this.panel16.TabIndex = 37;
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
            this.btnTim.Location = new System.Drawing.Point(274, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 57);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // DanhSachToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 551);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachToaThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachToaThuoc";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToaThuocdtgv)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ToaThuocdtgv;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnXemToaThuoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaToaThuoc;
        private System.Windows.Forms.Label lblMaToaThuoc;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtMaKetQua;
        private System.Windows.Forms.Label lblMaKetQua;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label lblMaBenhNhan;
    }
}
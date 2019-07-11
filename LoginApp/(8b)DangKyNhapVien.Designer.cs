namespace LoginApp
{
    partial class DangKyNhapVien
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btXemNhapVien = new System.Windows.Forms.Button();
            this.txtMaNhapVien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvNhapVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btDangKy = new System.Windows.Forms.Button();
            this.btXemPhong = new System.Windows.Forms.Button();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel16.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhapVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel16);
            this.panel4.Controls.Add(this.btXemNhapVien);
            this.panel4.Controls.Add(this.txtMaNhapVien);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1244, 256);
            this.panel4.TabIndex = 18;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtTim);
            this.panel16.Controls.Add(this.btnTim);
            this.panel16.Location = new System.Drawing.Point(263, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(364, 47);
            this.panel16.TabIndex = 19;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(17, 12);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(203, 20);
            this.txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(258, 8);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(95, 36);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btXemNhapVien
            // 
            this.btXemNhapVien.Location = new System.Drawing.Point(664, 8);
            this.btXemNhapVien.Name = "btXemNhapVien";
            this.btXemNhapVien.Size = new System.Drawing.Size(152, 35);
            this.btXemNhapVien.TabIndex = 18;
            this.btXemNhapVien.Text = "Xem nhập viện";
            this.btXemNhapVien.UseVisualStyleBackColor = true;
            this.btXemNhapVien.Click += new System.EventHandler(this.btXemNhapVien_Click);
            // 
            // txtMaNhapVien
            // 
            this.txtMaNhapVien.Location = new System.Drawing.Point(130, 76);
            this.txtMaNhapVien.Name = "txtMaNhapVien";
            this.txtMaNhapVien.ReadOnly = true;
            this.txtMaNhapVien.Size = new System.Drawing.Size(100, 20);
            this.txtMaNhapVien.TabIndex = 18;
            this.txtMaNhapVien.TextChanged += new System.EventHandler(this.txtMaNhapVien_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvNhapVien);
            this.groupBox1.Location = new System.Drawing.Point(263, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 187);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhập viện";
            // 
            // dtgvNhapVien
            // 
            this.dtgvNhapVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhapVien.Location = new System.Drawing.Point(8, 19);
            this.dtgvNhapVien.Name = "dtgvNhapVien";
            this.dtgvNhapVien.Size = new System.Drawing.Size(745, 157);
            this.dtgvNhapVien.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã nhập viện:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxLoaiPhong);
            this.panel1.Controls.Add(this.btDangKy);
            this.panel1.Controls.Add(this.btXemPhong);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 275);
            this.panel1.TabIndex = 18;
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(362, 10);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cbxLoaiPhong.TabIndex = 19;
            // 
            // btDangKy
            // 
            this.btDangKy.Location = new System.Drawing.Point(521, 233);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(106, 39);
            this.btDangKy.TabIndex = 18;
            this.btDangKy.Text = "Đăng ký";
            this.btDangKy.UseVisualStyleBackColor = true;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btXemPhong
            // 
            this.btXemPhong.Location = new System.Drawing.Point(521, 3);
            this.btXemPhong.Name = "btXemPhong";
            this.btXemPhong.Size = new System.Drawing.Size(106, 32);
            this.btXemPhong.TabIndex = 18;
            this.btXemPhong.Text = "Xem phòng";
            this.btXemPhong.UseVisualStyleBackColor = true;
            this.btXemPhong.Click += new System.EventHandler(this.btXemPhong_Click);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(141, 60);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 18;
            this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaPhong_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvPhong);
            this.groupBox2.Location = new System.Drawing.Point(263, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 186);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng:";
            // 
            // dtgvPhong
            // 
            this.dtgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhong.Location = new System.Drawing.Point(6, 19);
            this.dtgvPhong.Name = "dtgvPhong";
            this.dtgvPhong.Size = new System.Drawing.Size(645, 157);
            this.dtgvPhong.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên loại phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã phòng:";
            // 
            // DangKyNhapVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangKyNhapVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKyNhapVien";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhapVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvNhapVien;
        private System.Windows.Forms.Button btXemNhapVien;
        private System.Windows.Forms.TextBox txtMaNhapVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.Button btXemPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDangKy;
    }
}
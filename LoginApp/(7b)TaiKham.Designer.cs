namespace LoginApp
{
    partial class TaiKham
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.btDangKy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimBenhNhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.btXemBenhNhan = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBenhNhan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã bệnh nhân";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Location = new System.Drawing.Point(492, 341);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.ReadOnly = true;
            this.txtMaBenhNhan.Size = new System.Drawing.Size(276, 20);
            this.txtMaBenhNhan.TabIndex = 6;
            this.txtMaBenhNhan.TextChanged += new System.EventHandler(this.txtMaBenhNhan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày";
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(492, 442);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 20);
            this.dtNgay.TabIndex = 9;
            // 
            // btDangKy
            // 
            this.btDangKy.Location = new System.Drawing.Point(539, 486);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(106, 54);
            this.btDangKy.TabIndex = 16;
            this.btDangKy.Text = "Đăng ký";
            this.btDangKy.UseVisualStyleBackColor = true;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Đăng ký khoa";
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(492, 390);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbxKhoa.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvBenhNhan);
            this.groupBox2.Location = new System.Drawing.Point(219, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 264);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bệnh nhân";
            // 
            // dtgvBenhNhan
            // 
            this.dtgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBenhNhan.Location = new System.Drawing.Point(12, 16);
            this.dtgvBenhNhan.Name = "dtgvBenhNhan";
            this.dtgvBenhNhan.Size = new System.Drawing.Size(745, 239);
            this.dtgvBenhNhan.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTimBenhNhan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(219, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 43);
            this.panel3.TabIndex = 34;
            // 
            // txtTimBenhNhan
            // 
            this.txtTimBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimBenhNhan.Location = new System.Drawing.Point(129, 10);
            this.txtTimBenhNhan.Name = "txtTimBenhNhan";
            this.txtTimBenhNhan.Size = new System.Drawing.Size(218, 22);
            this.txtTimBenhNhan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bệnh nhân";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(603, 22);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(197, 43);
            this.btTim.TabIndex = 33;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btXemBenhNhan
            // 
            this.btXemBenhNhan.Location = new System.Drawing.Point(813, 22);
            this.btXemBenhNhan.Name = "btXemBenhNhan";
            this.btXemBenhNhan.Size = new System.Drawing.Size(175, 43);
            this.btXemBenhNhan.TabIndex = 16;
            this.btXemBenhNhan.Text = "Xem bệnh nhân";
            this.btXemBenhNhan.UseVisualStyleBackColor = true;
            this.btXemBenhNhan.Click += new System.EventHandler(this.btXemBenhNhan_Click_1);
            // 
            // TaiKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btXemBenhNhan);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.txtMaBenhNhan);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKham";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBenhNhan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvBenhNhan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTimBenhNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btXemBenhNhan;
    }
}
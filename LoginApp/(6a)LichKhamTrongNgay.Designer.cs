namespace LoginApp
{
    partial class LichKhamTrongNgay
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
            this.btKhamBenh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvLichKham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.Ngay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaLanKham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichKham)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // btKhamBenh
            // 
            this.btKhamBenh.Location = new System.Drawing.Point(600, 446);
            this.btKhamBenh.Name = "btKhamBenh";
            this.btKhamBenh.Size = new System.Drawing.Size(98, 60);
            this.btKhamBenh.TabIndex = 2;
            this.btKhamBenh.Text = "Khám bệnh";
            this.btKhamBenh.UseVisualStyleBackColor = true;
            this.btKhamBenh.Click += new System.EventHandler(this.btKhamBenh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvLichKham);
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 415);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch khám:";
            // 
            // dtgvLichKham
            // 
            this.dtgvLichKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichKham.Location = new System.Drawing.Point(13, 19);
            this.dtgvLichKham.Name = "dtgvLichKham";
            this.dtgvLichKham.Size = new System.Drawing.Size(444, 382);
            this.dtgvLichKham.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(664, 12);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(350, 415);
            this.panel11.TabIndex = 34;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dtNgaySinh);
            this.panel13.Controls.Add(this.Ngay);
            this.panel13.Location = new System.Drawing.Point(5, 184);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(342, 46);
            this.panel13.TabIndex = 1;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(117, 12);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtNgaySinh.TabIndex = 3;
            // 
            // Ngay
            // 
            this.Ngay.AutoSize = true;
            this.Ngay.Enabled = false;
            this.Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngay.Location = new System.Drawing.Point(3, 12);
            this.Ngay.Name = "Ngay";
            this.Ngay.Size = new System.Drawing.Size(86, 20);
            this.Ngay.TabIndex = 2;
            this.Ngay.Text = "Ngày sinh: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenBenhNhan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 46);
            this.panel1.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bệnh nhân:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMaLanKham);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(8, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 46);
            this.panel3.TabIndex = 1;
            // 
            // txtMaLanKham
            // 
            this.txtMaLanKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLanKham.Location = new System.Drawing.Point(117, 12);
            this.txtMaLanKham.Name = "txtMaLanKham";
            this.txtMaLanKham.ReadOnly = true;
            this.txtMaLanKham.Size = new System.Drawing.Size(222, 22);
            this.txtMaLanKham.TabIndex = 1;
            this.txtMaLanKham.TextChanged += new System.EventHandler(this.txtMaLanKham_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Lần khám:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtMaBenhNhan);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Location = new System.Drawing.Point(8, 80);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(342, 46);
            this.panel15.TabIndex = 1;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã bệnh nhân:";
            // 
            // LichKhamTrongNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 551);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.btKhamBenh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LichKhamTrongNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichKhamTrongNgay";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichKham)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btKhamBenh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvLichKham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label Ngay;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMaLanKham;
        private System.Windows.Forms.Label label4;
    }
}
namespace LoginApp
{
    partial class DanhSachPhong
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
            this.phongdtgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSoBenhNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.MaPhong = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtSoGiuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.BtnXemPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phongdtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // phongdtgv
            // 
            this.phongdtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongdtgv.Location = new System.Drawing.Point(11, 16);
            this.phongdtgv.Name = "phongdtgv";
            this.phongdtgv.Size = new System.Drawing.Size(644, 345);
            this.phongdtgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phongdtgv);
            this.groupBox1.Location = new System.Drawing.Point(106, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 370);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel16);
            this.panel11.Controls.Add(this.panel2);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(776, 22);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(416, 449);
            this.panel11.TabIndex = 41;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.cbxLoaiPhong);
            this.panel16.Controls.Add(this.label2);
            this.panel16.Controls.Add(this.btTim);
            this.panel16.Location = new System.Drawing.Point(8, 6);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(392, 63);
            this.panel16.TabIndex = 20;
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(126, 20);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cbxLoaiPhong.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại phòng:";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(273, 24);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(106, 23);
            this.btTim.TabIndex = 21;
            this.btTim.Text = "Xem phòng";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxTenLoaiPhong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 46);
            this.panel2.TabIndex = 1;
            // 
            // cbxTenLoaiPhong
            // 
            this.cbxTenLoaiPhong.FormattingEnabled = true;
            this.cbxTenLoaiPhong.Location = new System.Drawing.Point(117, 12);
            this.cbxTenLoaiPhong.Name = "cbxTenLoaiPhong";
            this.cbxTenLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cbxTenLoaiPhong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên loại phòng:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtSoBenhNhan);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Location = new System.Drawing.Point(15, 199);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(342, 46);
            this.panel12.TabIndex = 1;
            // 
            // txtSoBenhNhan
            // 
            this.txtSoBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBenhNhan.Location = new System.Drawing.Point(117, 12);
            this.txtSoBenhNhan.Name = "txtSoBenhNhan";
            this.txtSoBenhNhan.Size = new System.Drawing.Size(222, 22);
            this.txtSoBenhNhan.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số bệnh nhân:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.MaPhong);
            this.panel1.Location = new System.Drawing.Point(15, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 46);
            this.panel1.TabIndex = 1;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(117, 12);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(222, 22);
            this.txtMaPhong.TabIndex = 1;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSize = true;
            this.MaPhong.Enabled = false;
            this.MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaPhong.Location = new System.Drawing.Point(3, 12);
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Size = new System.Drawing.Size(84, 20);
            this.MaPhong.TabIndex = 2;
            this.MaPhong.Text = "Mã phòng:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtSoGiuong);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Location = new System.Drawing.Point(15, 147);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(342, 46);
            this.panel15.TabIndex = 1;
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGiuong.Location = new System.Drawing.Point(117, 12);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Size = new System.Drawing.Size(222, 22);
            this.txtSoGiuong.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số giường:";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.BtnXemPhong);
            this.panel17.Location = new System.Drawing.Point(106, 25);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(664, 63);
            this.panel17.TabIndex = 42;
            // 
            // BtnXemPhong
            // 
            this.BtnXemPhong.BackgroundImage = global::LoginApp.Properties.Resources.IconView;
            this.BtnXemPhong.Location = new System.Drawing.Point(279, 3);
            this.BtnXemPhong.Name = "BtnXemPhong";
            this.BtnXemPhong.Size = new System.Drawing.Size(75, 57);
            this.BtnXemPhong.TabIndex = 0;
            this.BtnXemPhong.UseVisualStyleBackColor = true;
            this.BtnXemPhong.Click += new System.EventHandler(this.BtnXemPhong_Click);
            // 
            // DanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 551);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachPhong";
            ((System.ComponentModel.ISupportInitialize)(this.phongdtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView phongdtgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxTenLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtSoBenhNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label MaPhong;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtSoGiuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button BtnXemPhong;
    }
}
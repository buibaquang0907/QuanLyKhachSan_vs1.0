namespace QuanLyKhachSanDemo
{
    partial class frmDatPhong
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
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaPDP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThemSua = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCCCDKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThemKhachHang = new FontAwesome.Sharp.IconButton();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayTraDuKien = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDatPhong = new System.Windows.Forms.DataGridView();
            this.maPhieuChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picThoat = new FontAwesome.Sharp.IconPictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.cmbMaPhong.ForeColor = System.Drawing.Color.LightGray;
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(127, 225);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(278, 28);
            this.cmbMaPhong.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(123, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "_______________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(23, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(326, 25);
            this.label15.TabIndex = 23;
            this.label15.Text = "THÔNG TIN PHIẾU ĐẶT PHÒNG\r\n";
            // 
            // txtMaPDP
            // 
            this.txtMaPDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaPDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPDP.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaPDP.Location = new System.Drawing.Point(127, 44);
            this.txtMaPDP.Name = "txtMaPDP";
            this.txtMaPDP.Size = new System.Drawing.Size(278, 24);
            this.txtMaPDP.TabIndex = 25;
            this.txtMaPDP.TextChanged += new System.EventHandler(this.txtMaPDP_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(123, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "_______________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(16, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ngày TDK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(16, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày NP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(16, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số người";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(16, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã PDP";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThoat.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconSize = 16;
            this.btnThoat.Location = new System.Drawing.Point(330, 456);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Rotation = 0D;
            this.btnThoat.Size = new System.Drawing.Size(75, 47);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoa.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconSize = 16;
            this.btnXoa.Location = new System.Drawing.Point(245, 456);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Rotation = 0D;
            this.btnXoa.Size = new System.Drawing.Size(75, 47);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemSua.FlatAppearance.BorderSize = 0;
            this.btnThemSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemSua.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemSua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemSua.IconColor = System.Drawing.Color.Black;
            this.btnThemSua.IconSize = 16;
            this.btnThemSua.Location = new System.Drawing.Point(127, 456);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Rotation = 0D;
            this.btnThemSua.Size = new System.Drawing.Size(107, 47);
            this.btnThemSua.TabIndex = 5;
            this.btnThemSua.Text = "Thêm";
            this.btnThemSua.UseVisualStyleBackColor = false;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCCCDKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnThemKhachHang);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtSoNguoi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpNgayNhan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpNgayTraDuKien);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtTienCoc);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbMaPhong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaPDP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemSua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(648, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 510);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenKH.Location = new System.Drawing.Point(126, 143);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(278, 24);
            this.txtTenKH.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(122, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(288, 20);
            this.label13.TabIndex = 64;
            this.label13.Text = "_______________________________";
            // 
            // txtCCCDKH
            // 
            this.txtCCCDKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtCCCDKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCDKH.ForeColor = System.Drawing.Color.LightGray;
            this.txtCCCDKH.Location = new System.Drawing.Point(126, 94);
            this.txtCCCDKH.Name = "txtCCCDKH";
            this.txtCCCDKH.Size = new System.Drawing.Size(278, 24);
            this.txtCCCDKH.TabIndex = 61;
            this.txtCCCDKH.TextChanged += new System.EventHandler(this.txtCCCDKH_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(122, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "_______________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(15, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 22);
            this.label12.TabIndex = 60;
            this.label12.Text = "Tìm CCCD";
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemKhachHang.FlatAppearance.BorderSize = 0;
            this.btnThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhachHang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemKhachHang.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemKhachHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemKhachHang.IconColor = System.Drawing.Color.Black;
            this.btnThemKhachHang.IconSize = 16;
            this.btnThemKhachHang.Location = new System.Drawing.Point(128, 177);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Rotation = 0D;
            this.btnThemKhachHang.Size = new System.Drawing.Size(276, 35);
            this.btnThemKhachHang.TabIndex = 55;
            this.btnThemKhachHang.Text = "Nhập Thông Tin Khách Hàng";
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtSoNguoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoi.ForeColor = System.Drawing.Color.LightGray;
            this.txtSoNguoi.Location = new System.Drawing.Point(127, 277);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(278, 24);
            this.txtSoNguoi.TabIndex = 53;
            this.txtSoNguoi.TextChanged += new System.EventHandler(this.txtSoNguoi_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(123, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "_______________________________";
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dtpNgayNhan.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(128, 320);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(278, 27);
            this.dtpNgayNhan.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(123, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "_______________________________";
            // 
            // dtpNgayTraDuKien
            // 
            this.dtpNgayTraDuKien.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dtpNgayTraDuKien.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dtpNgayTraDuKien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTraDuKien.Location = new System.Drawing.Point(127, 367);
            this.dtpNgayTraDuKien.Name = "dtpNgayTraDuKien";
            this.dtpNgayTraDuKien.Size = new System.Drawing.Size(278, 27);
            this.dtpNgayTraDuKien.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(122, 379);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(288, 20);
            this.label21.TabIndex = 49;
            this.label21.Text = "_______________________________";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label20.Location = new System.Drawing.Point(14, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 22);
            this.label20.TabIndex = 46;
            this.label20.Text = "Khách hàng";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTienCoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.ForeColor = System.Drawing.Color.LightGray;
            this.txtTienCoc.Location = new System.Drawing.Point(127, 414);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(278, 24);
            this.txtTienCoc.TabIndex = 47;
            this.txtTienCoc.Text = "50000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(123, 421);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(288, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "_______________________________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label19.Location = new System.Drawing.Point(16, 414);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 22);
            this.label19.TabIndex = 45;
            this.label19.Text = "Tiền cọc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 43;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.Location = new System.Drawing.Point(407, 105);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(235, 23);
            this.txtTimKiem.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(404, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(238, 16);
            this.label16.TabIndex = 44;
            this.label16.Text = "_________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(344, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tìm";
            // 
            // dgvDatPhong
            // 
            this.dgvDatPhong.AllowUserToAddRows = false;
            this.dgvDatPhong.AllowUserToDeleteRows = false;
            this.dgvDatPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvDatPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuChuyen,
            this.Column2,
            this.Column1,
            this.lyDo,
            this.CCCD,
            this.GioiTinh,
            this.SDT,
            this.diaChi});
            this.dgvDatPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvDatPhong.Location = new System.Drawing.Point(25, 137);
            this.dgvDatPhong.Name = "dgvDatPhong";
            this.dgvDatPhong.ReadOnly = true;
            this.dgvDatPhong.RowHeadersWidth = 51;
            this.dgvDatPhong.RowTemplate.Height = 24;
            this.dgvDatPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatPhong.Size = new System.Drawing.Size(617, 505);
            this.dgvDatPhong.TabIndex = 40;
            this.dgvDatPhong.SelectionChanged += new System.EventHandler(this.dgvDatPhong_SelectionChanged);
            // 
            // maPhieuChuyen
            // 
            this.maPhieuChuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhieuChuyen.HeaderText = "Mã Phiếu Đặt Phòng";
            this.maPhieuChuyen.MinimumWidth = 6;
            this.maPhieuChuyen.Name = "maPhieuChuyen";
            this.maPhieuChuyen.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Mã phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Số người";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // lyDo
            // 
            this.lyDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lyDo.HeaderText = "Ngày nhận phòng";
            this.lyDo.MinimumWidth = 6;
            this.lyDo.Name = "lyDo";
            this.lyDo.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCCD.HeaderText = "Ngày trả dự kiến";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.HeaderText = "Tiền cọc";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.HeaderText = "Mã KH";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.HeaderText = "Mã Nhân Viên";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // picThoat
            // 
            this.picThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.picThoat.BackgroundImage = global::QuanLyKhachSanDemo.Properties.Resources.Lotus_luxury_logo_template__removebg_preview;
            this.picThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.picThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.picThoat.IconColor = System.Drawing.SystemColors.ControlText;
            this.picThoat.IconSize = 150;
            this.picThoat.Location = new System.Drawing.Point(889, -6);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(194, 150);
            this.picThoat.TabIndex = 46;
            this.picThoat.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label18.Location = new System.Drawing.Point(26, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(426, 50);
            this.label18.TabIndex = 45;
            this.label18.Text = "PHIẾU ĐẶT PHÒNG\r\n";
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1100, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDatPhong);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatPhong";
            this.Text = "ĐẶT PHÒNG";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaPDP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThemSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDatPhong;
        private FontAwesome.Sharp.IconPictureBox picThoat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayTraDuKien;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnThemKhachHang;
        private System.Windows.Forms.TextBox txtCCCDKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label13;
    }
}
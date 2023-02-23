namespace QuanLyKhachSanDemo
{
    partial class frmChuyenPhong
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
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.cmbMaPhieuDat = new System.Windows.Forms.ComboBox();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.dtpNgayChuyenPhong = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaPhieuChuyenPhong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picThoat = new FontAwesome.Sharp.IconPictureBox();
            this.dgvChuyenPhong = new System.Windows.Forms.DataGridView();
            this.maPhieuChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYCHUYENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEUDAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANHANVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label18.Location = new System.Drawing.Point(12, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(368, 50);
            this.label18.TabIndex = 38;
            this.label18.Text = "CHUYỂN PHÒNG";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(23, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(289, 25);
            this.label15.TabIndex = 23;
            this.label15.Text = "THÔNG TIN PHIẾU CHUYỂN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(123, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "_______________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmbMaPhieuDat);
            this.groupBox1.Controls.Add(this.cmbMaPhong);
            this.groupBox1.Controls.Add(this.dtpNgayChuyenPhong);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMaPhieuChuyenPhong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(643, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 471);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThem.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconSize = 16;
            this.btnThem.Location = new System.Drawing.Point(15, 405);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(107, 47);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbMaPhieuDat
            // 
            this.cmbMaPhieuDat.FormattingEnabled = true;
            this.cmbMaPhieuDat.Location = new System.Drawing.Point(127, 329);
            this.cmbMaPhieuDat.Name = "cmbMaPhieuDat";
            this.cmbMaPhieuDat.Size = new System.Drawing.Size(278, 28);
            this.cmbMaPhieuDat.TabIndex = 40;
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(127, 254);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(278, 28);
            this.cmbMaPhong.TabIndex = 38;
            // 
            // dtpNgayChuyenPhong
            // 
            this.dtpNgayChuyenPhong.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dtpNgayChuyenPhong.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dtpNgayChuyenPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChuyenPhong.Location = new System.Drawing.Point(127, 182);
            this.dtpNgayChuyenPhong.Name = "dtpNgayChuyenPhong";
            this.dtpNgayChuyenPhong.Size = new System.Drawing.Size(278, 27);
            this.dtpNgayChuyenPhong.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(122, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "_______________________________";
            // 
            // txtLyDo
            // 
            this.txtLyDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtLyDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.ForeColor = System.Drawing.Color.LightGray;
            this.txtLyDo.Location = new System.Drawing.Point(127, 114);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(278, 24);
            this.txtLyDo.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(123, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "_______________________________";
            // 
            // txtMaPhieuChuyenPhong
            // 
            this.txtMaPhieuChuyenPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaPhieuChuyenPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuChuyenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuChuyenPhong.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaPhieuChuyenPhong.Location = new System.Drawing.Point(127, 44);
            this.txtMaPhieuChuyenPhong.Name = "txtMaPhieuChuyenPhong";
            this.txtMaPhieuChuyenPhong.Size = new System.Drawing.Size(278, 24);
            this.txtMaPhieuChuyenPhong.TabIndex = 25;
            this.txtMaPhieuChuyenPhong.TextChanged += new System.EventHandler(this.txtMaPhieuChuyenPhong_TextChanged);
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
            this.label7.Location = new System.Drawing.Point(30, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã PĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(30, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mã Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(29, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lý do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã CP";
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
            this.btnThoat.Location = new System.Drawing.Point(330, 405);
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
            this.btnXoa.Location = new System.Drawing.Point(245, 405);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Rotation = 0D;
            this.btnXoa.Size = new System.Drawing.Size(75, 47);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSua.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconSize = 16;
            this.btnSua.Location = new System.Drawing.Point(127, 405);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(107, 47);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.Location = new System.Drawing.Point(402, 140);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(235, 23);
            this.txtTimKiem.TabIndex = 35;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(399, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(238, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "_________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(347, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tìm";
            // 
            // picThoat
            // 
            this.picThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.picThoat.BackgroundImage = global::QuanLyKhachSanDemo.Properties.Resources.Lotus_luxury_logo_template__removebg_preview;
            this.picThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.picThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.picThoat.IconColor = System.Drawing.SystemColors.ControlText;
            this.picThoat.IconSize = 168;
            this.picThoat.Location = new System.Drawing.Point(894, 24);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(194, 168);
            this.picThoat.TabIndex = 39;
            this.picThoat.TabStop = false;
            // 
            // dgvChuyenPhong
            // 
            this.dgvChuyenPhong.AllowUserToAddRows = false;
            this.dgvChuyenPhong.AllowUserToDeleteRows = false;
            this.dgvChuyenPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvChuyenPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChuyenPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuChuyen,
            this.lyDo,
            this.NGAYCHUYENPHONG,
            this.MAPHONG,
            this.MAPHIEUDAT,
            this.MANHANVIEN});
            this.dgvChuyenPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvChuyenPhong.Location = new System.Drawing.Point(20, 181);
            this.dgvChuyenPhong.Name = "dgvChuyenPhong";
            this.dgvChuyenPhong.ReadOnly = true;
            this.dgvChuyenPhong.RowHeadersWidth = 51;
            this.dgvChuyenPhong.RowTemplate.Height = 24;
            this.dgvChuyenPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenPhong.Size = new System.Drawing.Size(617, 459);
            this.dgvChuyenPhong.TabIndex = 33;
            this.dgvChuyenPhong.SelectionChanged += new System.EventHandler(this.dgvChuyenPhong_SelectionChanged);
            // 
            // maPhieuChuyen
            // 
            this.maPhieuChuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhieuChuyen.HeaderText = "Mã Chuyển Phòng";
            this.maPhieuChuyen.MinimumWidth = 6;
            this.maPhieuChuyen.Name = "maPhieuChuyen";
            this.maPhieuChuyen.ReadOnly = true;
            // 
            // lyDo
            // 
            this.lyDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lyDo.HeaderText = "Lý do";
            this.lyDo.MinimumWidth = 6;
            this.lyDo.Name = "lyDo";
            this.lyDo.ReadOnly = true;
            // 
            // NGAYCHUYENPHONG
            // 
            this.NGAYCHUYENPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYCHUYENPHONG.HeaderText = "Ngày Chuyển";
            this.NGAYCHUYENPHONG.MinimumWidth = 6;
            this.NGAYCHUYENPHONG.Name = "NGAYCHUYENPHONG";
            this.NGAYCHUYENPHONG.ReadOnly = true;
            // 
            // MAPHONG
            // 
            this.MAPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPHONG.HeaderText = "Mã Phòng";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            // 
            // MAPHIEUDAT
            // 
            this.MAPHIEUDAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPHIEUDAT.HeaderText = "Mã Phiếu Đặt";
            this.MAPHIEUDAT.MinimumWidth = 6;
            this.MAPHIEUDAT.Name = "MAPHIEUDAT";
            this.MAPHIEUDAT.ReadOnly = true;
            // 
            // MANHANVIEN
            // 
            this.MANHANVIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANHANVIEN.HeaderText = "Mã Nhân Viên";
            this.MANHANVIEN.MinimumWidth = 6;
            this.MANHANVIEN.Name = "MANHANVIEN";
            this.MANHANVIEN.ReadOnly = true;
            // 
            // frmChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1100, 683);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvChuyenPhong);
            this.Controls.Add(this.picThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChuyenPhong";
            this.Text = "ĐỔI PHÒNG";
            this.Load += new System.EventHandler(this.frmChuyenPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaPhieuChuyenPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox picThoat;
        private System.Windows.Forms.DataGridView dgvChuyenPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayChuyenPhong;
        private System.Windows.Forms.ComboBox cmbMaPhieuDat;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYCHUYENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUDAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHANVIEN;
    }
}
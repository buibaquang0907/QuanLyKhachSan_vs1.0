namespace QuanLyKhachSanDemo
{
    partial class frmPhong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.maLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPhong = new System.Windows.Forms.GroupBox();
            this.btnThemPhong = new FontAwesome.Sharp.IconButton();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbMaLoai = new System.Windows.Forms.ComboBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaPhong = new FontAwesome.Sharp.IconButton();
            this.btnSuaPhong = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimLoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemLoai = new FontAwesome.Sharp.IconButton();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnXoaLoai = new FontAwesome.Sharp.IconButton();
            this.btnSuaLoai = new FontAwesome.Sharp.IconButton();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTimPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picThoat = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.gbPhong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.tenPhong,
            this.soNguoi,
            this.tinhTrang,
            this.maLoaiPhong});
            this.dgvPhong.Location = new System.Drawing.Point(459, 12);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(611, 208);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            // 
            // maPhong
            // 
            this.maPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhong.HeaderText = "Mã Phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            this.maPhong.ReadOnly = true;
            // 
            // tenPhong
            // 
            this.tenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenPhong.HeaderText = "Tên Phòng";
            this.tenPhong.MinimumWidth = 6;
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.ReadOnly = true;
            // 
            // soNguoi
            // 
            this.soNguoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soNguoi.HeaderText = "Số Người";
            this.soNguoi.MinimumWidth = 6;
            this.soNguoi.Name = "soNguoi";
            this.soNguoi.ReadOnly = true;
            // 
            // tinhTrang
            // 
            this.tinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhTrang.HeaderText = "Tình Trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            // 
            // maLoaiPhong
            // 
            this.maLoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiPhong.HeaderText = "Mã Loại";
            this.maLoaiPhong.MinimumWidth = 6;
            this.maLoaiPhong.Name = "maLoaiPhong";
            this.maLoaiPhong.ReadOnly = true;
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AllowUserToAddRows = false;
            this.dgvLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoai,
            this.tenLoai,
            this.giaThue});
            this.dgvLoaiPhong.Location = new System.Drawing.Point(12, 323);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.RowHeadersWidth = 51;
            this.dgvLoaiPhong.RowTemplate.Height = 24;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(425, 301);
            this.dgvLoaiPhong.TabIndex = 1;
            this.dgvLoaiPhong.SelectionChanged += new System.EventHandler(this.dgvLoaiPhong_SelectionChanged);
            // 
            // maLoai
            // 
            this.maLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoai.HeaderText = "Mã Loại";
            this.maLoai.MinimumWidth = 6;
            this.maLoai.Name = "maLoai";
            this.maLoai.ReadOnly = true;
            // 
            // tenLoai
            // 
            this.tenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoai.HeaderText = "Tên Loại";
            this.tenLoai.MinimumWidth = 6;
            this.tenLoai.Name = "tenLoai";
            this.tenLoai.ReadOnly = true;
            // 
            // giaThue
            // 
            this.giaThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaThue.HeaderText = "Giá Thuê";
            this.giaThue.MinimumWidth = 6;
            this.giaThue.Name = "giaThue";
            this.giaThue.ReadOnly = true;
            // 
            // gbPhong
            // 
            this.gbPhong.Controls.Add(this.btnThemPhong);
            this.gbPhong.Controls.Add(this.txtMaPhong);
            this.gbPhong.Controls.Add(this.label21);
            this.gbPhong.Controls.Add(this.label23);
            this.gbPhong.Controls.Add(this.cmbMaLoai);
            this.gbPhong.Controls.Add(this.txtTinhTrang);
            this.gbPhong.Controls.Add(this.txtTenPhong);
            this.gbPhong.Controls.Add(this.label17);
            this.gbPhong.Controls.Add(this.label5);
            this.gbPhong.Controls.Add(this.txtSoNguoi);
            this.gbPhong.Controls.Add(this.label4);
            this.gbPhong.Controls.Add(this.label3);
            this.gbPhong.Controls.Add(this.label2);
            this.gbPhong.Controls.Add(this.btnXoaPhong);
            this.gbPhong.Controls.Add(this.btnSuaPhong);
            this.gbPhong.Controls.Add(this.label11);
            this.gbPhong.Controls.Add(this.label12);
            this.gbPhong.Controls.Add(this.label13);
            this.gbPhong.Controls.Add(this.label10);
            this.gbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbPhong.Location = new System.Drawing.Point(459, 226);
            this.gbPhong.Name = "gbPhong";
            this.gbPhong.Size = new System.Drawing.Size(355, 398);
            this.gbPhong.TabIndex = 22;
            this.gbPhong.TabStop = false;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemPhong.FlatAppearance.BorderSize = 0;
            this.btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhong.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemPhong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemPhong.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemPhong.IconColor = System.Drawing.Color.Black;
            this.btnThemPhong.IconSize = 16;
            this.btnThemPhong.Location = new System.Drawing.Point(20, 328);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Rotation = 0D;
            this.btnThemPhong.Size = new System.Drawing.Size(95, 47);
            this.btnThemPhong.TabIndex = 35;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaPhong.Location = new System.Drawing.Point(112, 59);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(210, 23);
            this.txtMaPhong.TabIndex = 32;
            this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaPhong_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label21.Location = new System.Drawing.Point(12, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 22);
            this.label21.TabIndex = 33;
            this.label21.Text = "Mã Phòng";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(108, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(216, 20);
            this.label23.TabIndex = 34;
            this.label23.Text = "_______________________";
            // 
            // cmbMaLoai
            // 
            this.cmbMaLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.cmbMaLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaLoai.ForeColor = System.Drawing.Color.LightGray;
            this.cmbMaLoai.FormattingEnabled = true;
            this.cmbMaLoai.Location = new System.Drawing.Point(112, 259);
            this.cmbMaLoai.Name = "cmbMaLoai";
            this.cmbMaLoai.Size = new System.Drawing.Size(210, 33);
            this.cmbMaLoai.TabIndex = 31;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.LightGray;
            this.txtTinhTrang.Location = new System.Drawing.Point(112, 209);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(210, 23);
            this.txtTinhTrang.TabIndex = 3;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenPhong.Location = new System.Drawing.Point(112, 108);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(210, 23);
            this.txtTenPhong.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(27, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 25);
            this.label17.TabIndex = 29;
            this.label17.Text = "THÔNG TIN PHÒNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số Người";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtSoNguoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoi.ForeColor = System.Drawing.Color.LightGray;
            this.txtSoNguoi.Location = new System.Drawing.Point(112, 157);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(210, 23);
            this.txtSoNguoi.TabIndex = 22;
            this.txtSoNguoi.TextChanged += new System.EventHandler(this.txtSoNguoi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(16, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tình Trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Phòng";
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaPhong.FlatAppearance.BorderSize = 0;
            this.btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhong.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaPhong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaPhong.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaPhong.IconColor = System.Drawing.Color.Black;
            this.btnXoaPhong.IconSize = 16;
            this.btnXoaPhong.Location = new System.Drawing.Point(225, 328);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Rotation = 0D;
            this.btnXoaPhong.Size = new System.Drawing.Size(97, 47);
            this.btnXoaPhong.TabIndex = 6;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaPhong.FlatAppearance.BorderSize = 0;
            this.btnSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPhong.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaPhong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaPhong.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaPhong.IconColor = System.Drawing.Color.Black;
            this.btnSuaPhong.IconSize = 16;
            this.btnSuaPhong.Location = new System.Drawing.Point(124, 328);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Rotation = 0D;
            this.btnSuaPhong.Size = new System.Drawing.Size(95, 47);
            this.btnSuaPhong.TabIndex = 5;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(108, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "_______________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(108, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "_______________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(108, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "_______________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(108, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "_______________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Loại";
            // 
            // txtTimLoai
            // 
            this.txtTimLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimLoai.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimLoai.Location = new System.Drawing.Point(16, 94);
            this.txtTimLoai.Name = "txtTimLoai";
            this.txtTimLoai.Size = new System.Drawing.Size(207, 23);
            this.txtTimLoai.TabIndex = 1;
            this.txtTimLoai.TextChanged += new System.EventHandler(this.txtTimLoai_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(13, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "__________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemLoai);
            this.groupBox1.Controls.Add(this.txtTenLoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGiaThue);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnXoaLoai);
            this.groupBox1.Controls.Add(this.btnSuaLoai);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 287);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemLoai.FlatAppearance.BorderSize = 0;
            this.btnThemLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoai.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemLoai.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemLoai.IconColor = System.Drawing.Color.Black;
            this.btnThemLoai.IconSize = 16;
            this.btnThemLoai.Location = new System.Drawing.Point(84, 214);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Rotation = 0D;
            this.btnThemLoai.Size = new System.Drawing.Size(95, 47);
            this.btnThemLoai.TabIndex = 30;
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.UseVisualStyleBackColor = false;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenLoai.Location = new System.Drawing.Point(128, 109);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(278, 23);
            this.txtTenLoai.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(18, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "THÔNG TIN LOẠI PHÒNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(31, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Giá Thuê";
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtGiaThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThue.ForeColor = System.Drawing.Color.LightGray;
            this.txtGiaThue.Location = new System.Drawing.Point(128, 158);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(278, 23);
            this.txtGiaThue.TabIndex = 22;
            this.txtGiaThue.TextChanged += new System.EventHandler(this.txtGiaThue_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Location = new System.Drawing.Point(28, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 22);
            this.label15.TabIndex = 14;
            this.label15.Text = "Tên Loại";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(31, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 22);
            this.label16.TabIndex = 13;
            this.label16.Text = "Mã Loại";
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaLoai.FlatAppearance.BorderSize = 0;
            this.btnXoaLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoai.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaLoai.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaLoai.IconColor = System.Drawing.Color.Black;
            this.btnXoaLoai.IconSize = 16;
            this.btnXoaLoai.Location = new System.Drawing.Point(310, 214);
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Rotation = 0D;
            this.btnXoaLoai.Size = new System.Drawing.Size(96, 47);
            this.btnXoaLoai.TabIndex = 6;
            this.btnXoaLoai.Text = "Xóa";
            this.btnXoaLoai.UseVisualStyleBackColor = false;
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaLoai.FlatAppearance.BorderSize = 0;
            this.btnSuaLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLoai.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaLoai.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaLoai.IconColor = System.Drawing.Color.Black;
            this.btnSuaLoai.IconSize = 16;
            this.btnSuaLoai.Location = new System.Drawing.Point(197, 214);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Rotation = 0D;
            this.btnSuaLoai.Size = new System.Drawing.Size(95, 47);
            this.btnSuaLoai.TabIndex = 5;
            this.btnSuaLoai.Text = "Sửa";
            this.btnSuaLoai.UseVisualStyleBackColor = false;
            this.btnSuaLoai.Click += new System.EventHandler(this.btnSuaLoai_Click);
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaLoai.Location = new System.Drawing.Point(128, 56);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(278, 23);
            this.txtMaLoai.TabIndex = 1;
            this.txtMaLoai.TextChanged += new System.EventHandler(this.txtMaLoai_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(124, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(288, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "_______________________________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(124, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(288, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "_______________________________";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(124, 116);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(288, 20);
            this.label22.TabIndex = 25;
            this.label22.Text = "_______________________________";
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.label20);
            this.groupBoxTimKiem.Controls.Add(this.label14);
            this.groupBoxTimKiem.Controls.Add(this.txtTimPhong);
            this.groupBoxTimKiem.Controls.Add(this.txtTimLoai);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.label9);
            this.groupBoxTimKiem.Controls.Add(this.label8);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(828, 228);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(241, 233);
            this.groupBoxTimKiem.TabIndex = 25;
            this.groupBoxTimKiem.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label20.Location = new System.Drawing.Point(20, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 25);
            this.label20.TabIndex = 30;
            this.label20.Text = "TÌM KIẾM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(21, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 22);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tên  Phòng";
            // 
            // txtTimPhong
            // 
            this.txtTimPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimPhong.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimPhong.Location = new System.Drawing.Point(16, 180);
            this.txtTimPhong.Name = "txtTimPhong";
            this.txtTimPhong.Size = new System.Drawing.Size(207, 23);
            this.txtTimPhong.TabIndex = 25;
            this.txtTimPhong.TextChanged += new System.EventHandler(this.txtTimPhong_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(13, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "__________________________";
            // 
            // picThoat
            // 
            this.picThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.picThoat.BackgroundImage = global::QuanLyKhachSanDemo.Properties.Resources.Lotus_luxury_logo_template__removebg_preview;
            this.picThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.picThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.picThoat.IconColor = System.Drawing.SystemColors.ControlText;
            this.picThoat.IconSize = 156;
            this.picThoat.Location = new System.Drawing.Point(826, 467);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(243, 156);
            this.picThoat.TabIndex = 26;
            this.picThoat.TabStop = false;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 636);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPhong);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.dgvPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhong";
            this.Text = "PHÒNG";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.gbPhong.ResumeLayout(false);
            this.gbPhong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.GroupBox gbPhong;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnXoaPhong;
        private FontAwesome.Sharp.IconButton btnSuaPhong;
        private System.Windows.Forms.TextBox txtTimLoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMaLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton btnXoaLoai;
        private FontAwesome.Sharp.IconButton btnSuaLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaThue;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTimPhong;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox picThoat;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private FontAwesome.Sharp.IconButton btnThemLoai;
        private FontAwesome.Sharp.IconButton btnThemPhong;
    }
}
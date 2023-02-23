namespace QuanLyKhachSanDemo
{
    partial class frmNhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxNhanVien = new System.Windows.Forms.GroupBox();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimNhanVien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.picThoat = new FontAwesome.Sharp.IconPictureBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.gBoxNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.namSinh,
            this.CCCD,
            this.chucVu,
            this.DT,
            this.diaChi});
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 153);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(627, 471);
            this.dgvNhanVien.TabIndex = 7;
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.dgvNhanVien_SelectionChanged);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // namSinh
            // 
            this.namSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namSinh.HeaderText = "Năm Sinh";
            this.namSinh.MinimumWidth = 6;
            this.namSinh.Name = "namSinh";
            this.namSinh.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // chucVu
            // 
            this.chucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chucVu.HeaderText = "Chức Vụ";
            this.chucVu.MinimumWidth = 6;
            this.chucVu.Name = "chucVu";
            this.chucVu.ReadOnly = true;
            // 
            // DT
            // 
            this.DT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DT.HeaderText = "DT";
            this.DT.MinimumWidth = 6;
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // gBoxNhanVien
            // 
            this.gBoxNhanVien.Controls.Add(this.btnThem);
            this.gBoxNhanVien.Controls.Add(this.label17);
            this.gBoxNhanVien.Controls.Add(this.label5);
            this.gBoxNhanVien.Controls.Add(this.txtNamSinh);
            this.gBoxNhanVien.Controls.Add(this.label4);
            this.gBoxNhanVien.Controls.Add(this.txtChucVu);
            this.gBoxNhanVien.Controls.Add(this.label7);
            this.gBoxNhanVien.Controls.Add(this.label6);
            this.gBoxNhanVien.Controls.Add(this.label3);
            this.gBoxNhanVien.Controls.Add(this.label2);
            this.gBoxNhanVien.Controls.Add(this.label1);
            this.gBoxNhanVien.Controls.Add(this.txtSDT);
            this.gBoxNhanVien.Controls.Add(this.txtDiaChi);
            this.gBoxNhanVien.Controls.Add(this.btnThoat);
            this.gBoxNhanVien.Controls.Add(this.btnXoa);
            this.gBoxNhanVien.Controls.Add(this.btnSua);
            this.gBoxNhanVien.Controls.Add(this.txtCCCD);
            this.gBoxNhanVien.Controls.Add(this.txtTenNV);
            this.gBoxNhanVien.Controls.Add(this.txtMaNV);
            this.gBoxNhanVien.Controls.Add(this.label9);
            this.gBoxNhanVien.Controls.Add(this.label10);
            this.gBoxNhanVien.Controls.Add(this.label11);
            this.gBoxNhanVien.Controls.Add(this.label12);
            this.gBoxNhanVien.Controls.Add(this.label13);
            this.gBoxNhanVien.Controls.Add(this.label14);
            this.gBoxNhanVien.Controls.Add(this.label15);
            this.gBoxNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxNhanVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gBoxNhanVien.Location = new System.Drawing.Point(645, 153);
            this.gBoxNhanVien.Name = "gBoxNhanVien";
            this.gBoxNhanVien.Size = new System.Drawing.Size(425, 471);
            this.gBoxNhanVien.TabIndex = 21;
            this.gBoxNhanVien.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconSize = 16;
            this.btnThem.Location = new System.Drawing.Point(47, 405);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(95, 47);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(26, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(250, 25);
            this.label17.TabIndex = 29;
            this.label17.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(30, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Năm Sinh";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtNamSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.ForeColor = System.Drawing.Color.LightGray;
            this.txtNamSinh.Location = new System.Drawing.Point(127, 149);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(278, 23);
            this.txtNamSinh.TabIndex = 22;
            this.txtNamSinh.TextChanged += new System.EventHandler(this.txtNamSinh_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(27, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chức Vụ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.ForeColor = System.Drawing.Color.LightGray;
            this.txtChucVu.Location = new System.Drawing.Point(127, 253);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(278, 23);
            this.txtChucVu.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(30, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "SDT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(31, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "CCCD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã NV";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.LightGray;
            this.txtSDT.Location = new System.Drawing.Point(127, 354);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(278, 23);
            this.txtSDT.TabIndex = 10;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.LightGray;
            this.txtDiaChi.Location = new System.Drawing.Point(127, 304);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(278, 23);
            this.txtDiaChi.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
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
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconSize = 16;
            this.btnXoa.Location = new System.Drawing.Point(249, 405);
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
            this.btnSua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconSize = 16;
            this.btnSua.Location = new System.Drawing.Point(148, 405);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(95, 47);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.Color.LightGray;
            this.txtCCCD.Location = new System.Drawing.Point(127, 201);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(278, 23);
            this.txtCCCD.TabIndex = 3;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenNV.Location = new System.Drawing.Point(127, 100);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(278, 23);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaNV.Location = new System.Drawing.Point(127, 47);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(278, 23);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(123, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "_______________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(123, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "_______________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(123, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "_______________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(123, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "_______________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(123, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(288, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "_______________________________";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(123, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "_______________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(123, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(288, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "_______________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(224, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tìm theo CCCD";
            // 
            // txtTimNhanVien
            // 
            this.txtTimNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNhanVien.Location = new System.Drawing.Point(395, 113);
            this.txtTimNhanVien.Name = "txtTimNhanVien";
            this.txtTimNhanVien.Size = new System.Drawing.Size(244, 23);
            this.txtTimNhanVien.TabIndex = 22;
            this.txtTimNhanVien.TextChanged += new System.EventHandler(this.txtTimNhanVien_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(392, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(252, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "___________________________________";
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
            this.picThoat.Location = new System.Drawing.Point(876, -2);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(194, 168);
            this.picThoat.TabIndex = 29;
            this.picThoat.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label18.Location = new System.Drawing.Point(12, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(525, 50);
            this.label18.TabIndex = 30;
            this.label18.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 636);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTimNhanVien);
            this.Controls.Add(this.gBoxNhanVien);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.picThoat);
            this.Name = "frmNhanVien";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.gBoxNhanVien.ResumeLayout(false);
            this.gBoxNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox gBoxNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconPictureBox picThoat;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton btnThem;
    }
}
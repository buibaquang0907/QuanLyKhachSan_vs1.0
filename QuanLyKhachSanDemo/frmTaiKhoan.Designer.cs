namespace QuanLyKhachSanDemo
{
    partial class frmTaiKhoan
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
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.maQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemQuyen = new FontAwesome.Sharp.IconButton();
            this.txtQuyenHan = new System.Windows.Forms.TextBox();
            this.txtTenQuyen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnXoaLoaiQuyen = new FontAwesome.Sharp.IconButton();
            this.btnSuaQuyen = new FontAwesome.Sharp.IconButton();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnThemTK = new FontAwesome.Sharp.IconButton();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.cmbMaQuyen = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaTK = new FontAwesome.Sharp.IconButton();
            this.btnSuaTK = new FontAwesome.Sharp.IconButton();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMaNVTimKiem = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenDNTimKiem = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaQuyenTimKiem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.picThoat = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToAddRows = false;
            this.dgvPhanQuyen.AllowUserToDeleteRows = false;
            this.dgvPhanQuyen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maQuyen,
            this.tenQuyen,
            this.quyenHan});
            this.dgvPhanQuyen.Location = new System.Drawing.Point(12, 303);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.ReadOnly = true;
            this.dgvPhanQuyen.RowHeadersWidth = 51;
            this.dgvPhanQuyen.RowTemplate.Height = 24;
            this.dgvPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(383, 309);
            this.dgvPhanQuyen.TabIndex = 21;
            this.dgvPhanQuyen.SelectionChanged += new System.EventHandler(this.dgvPhanQuyen_SelectionChanged);
            // 
            // maQuyen
            // 
            this.maQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maQuyen.HeaderText = "Mã Quyền";
            this.maQuyen.MinimumWidth = 6;
            this.maQuyen.Name = "maQuyen";
            this.maQuyen.ReadOnly = true;
            // 
            // tenQuyen
            // 
            this.tenQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenQuyen.HeaderText = "Tên Quyền";
            this.tenQuyen.MinimumWidth = 6;
            this.tenQuyen.Name = "tenQuyen";
            this.tenQuyen.ReadOnly = true;
            // 
            // quyenHan
            // 
            this.quyenHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quyenHan.HeaderText = "Quyền Hạn";
            this.quyenHan.MinimumWidth = 6;
            this.quyenHan.Name = "quyenHan";
            this.quyenHan.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemQuyen);
            this.groupBox1.Controls.Add(this.txtQuyenHan);
            this.groupBox1.Controls.Add(this.txtTenQuyen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnXoaLoaiQuyen);
            this.groupBox1.Controls.Add(this.btnSuaQuyen);
            this.groupBox1.Controls.Add(this.txtMaQuyen);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 287);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnThemQuyen
            // 
            this.btnThemQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemQuyen.FlatAppearance.BorderSize = 0;
            this.btnThemQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemQuyen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemQuyen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemQuyen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemQuyen.IconColor = System.Drawing.Color.Black;
            this.btnThemQuyen.IconSize = 16;
            this.btnThemQuyen.Location = new System.Drawing.Point(41, 210);
            this.btnThemQuyen.Name = "btnThemQuyen";
            this.btnThemQuyen.Rotation = 0D;
            this.btnThemQuyen.Size = new System.Drawing.Size(95, 47);
            this.btnThemQuyen.TabIndex = 30;
            this.btnThemQuyen.Text = "Thêm";
            this.btnThemQuyen.UseVisualStyleBackColor = false;
            this.btnThemQuyen.Click += new System.EventHandler(this.btnThemQuyen_Click);
            // 
            // txtQuyenHan
            // 
            this.txtQuyenHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtQuyenHan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyenHan.ForeColor = System.Drawing.Color.LightGray;
            this.txtQuyenHan.Location = new System.Drawing.Point(128, 158);
            this.txtQuyenHan.Name = "txtQuyenHan";
            this.txtQuyenHan.Size = new System.Drawing.Size(211, 23);
            this.txtQuyenHan.TabIndex = 22;
            // 
            // txtTenQuyen
            // 
            this.txtTenQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenQuyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQuyen.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenQuyen.Location = new System.Drawing.Point(128, 109);
            this.txtTenQuyen.Name = "txtTenQuyen";
            this.txtTenQuyen.Size = new System.Drawing.Size(211, 23);
            this.txtTenQuyen.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(18, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "THÔNG TIN PHÂN QUYỀN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(27, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quyền Hạn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Location = new System.Drawing.Point(27, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 22);
            this.label15.TabIndex = 14;
            this.label15.Text = "Tên Quyền";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(27, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 22);
            this.label16.TabIndex = 13;
            this.label16.Text = "Mã Quyền";
            // 
            // btnXoaLoaiQuyen
            // 
            this.btnXoaLoaiQuyen.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaLoaiQuyen.FlatAppearance.BorderSize = 0;
            this.btnXoaLoaiQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiQuyen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaLoaiQuyen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaLoaiQuyen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaLoaiQuyen.IconColor = System.Drawing.Color.Black;
            this.btnXoaLoaiQuyen.IconSize = 16;
            this.btnXoaLoaiQuyen.Location = new System.Drawing.Point(243, 210);
            this.btnXoaLoaiQuyen.Name = "btnXoaLoaiQuyen";
            this.btnXoaLoaiQuyen.Rotation = 0D;
            this.btnXoaLoaiQuyen.Size = new System.Drawing.Size(96, 47);
            this.btnXoaLoaiQuyen.TabIndex = 6;
            this.btnXoaLoaiQuyen.Text = "Xóa";
            this.btnXoaLoaiQuyen.UseVisualStyleBackColor = false;
            this.btnXoaLoaiQuyen.Click += new System.EventHandler(this.btnXoaLoaiQuyen_Click);
            // 
            // btnSuaQuyen
            // 
            this.btnSuaQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaQuyen.FlatAppearance.BorderSize = 0;
            this.btnSuaQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaQuyen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaQuyen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaQuyen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaQuyen.IconColor = System.Drawing.Color.Black;
            this.btnSuaQuyen.IconSize = 16;
            this.btnSuaQuyen.Location = new System.Drawing.Point(142, 210);
            this.btnSuaQuyen.Name = "btnSuaQuyen";
            this.btnSuaQuyen.Rotation = 0D;
            this.btnSuaQuyen.Size = new System.Drawing.Size(95, 47);
            this.btnSuaQuyen.TabIndex = 5;
            this.btnSuaQuyen.Text = "Sửa";
            this.btnSuaQuyen.UseVisualStyleBackColor = false;
            this.btnSuaQuyen.Click += new System.EventHandler(this.btnSuaQuyen_Click);
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaQuyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQuyen.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaQuyen.Location = new System.Drawing.Point(128, 56);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(211, 23);
            this.txtMaQuyen.TabIndex = 1;
            this.txtMaQuyen.TextChanged += new System.EventHandler(this.txtMaQuyen_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(124, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(216, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "_______________________";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(124, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(216, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "_______________________";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(124, 116);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(216, 20);
            this.label22.TabIndex = 25;
            this.label22.Text = "_______________________";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtXacNhan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.btnThemTK);
            this.groupBox2.Controls.Add(this.cmbMaNV);
            this.groupBox2.Controls.Add(this.cmbMaQuyen);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnXoaTK);
            this.groupBox2.Controls.Add(this.btnSuaTK);
            this.groupBox2.Controls.Add(this.txtTenDangNhap);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(401, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 348);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtXacNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhan.ForeColor = System.Drawing.Color.LightGray;
            this.txtXacNhan.Location = new System.Drawing.Point(187, 126);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Size = new System.Drawing.Size(213, 23);
            this.txtXacNhan.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(1, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Xác Nhận Mật Khẩu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.DimGray;
            this.label24.Location = new System.Drawing.Point(183, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(216, 20);
            this.label24.TabIndex = 38;
            this.label24.Text = "_______________________";
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemTK.FlatAppearance.BorderSize = 0;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemTK.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemTK.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemTK.IconColor = System.Drawing.Color.Black;
            this.btnThemTK.IconSize = 16;
            this.btnThemTK.Location = new System.Drawing.Point(96, 291);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Rotation = 0D;
            this.btnThemTK.Size = new System.Drawing.Size(95, 47);
            this.btnThemTK.TabIndex = 35;
            this.btnThemTK.Text = "Thêm";
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.cmbMaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaNV.ForeColor = System.Drawing.Color.LightGray;
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(186, 164);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(213, 33);
            this.cmbMaNV.TabIndex = 34;
            // 
            // cmbMaQuyen
            // 
            this.cmbMaQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.cmbMaQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaQuyen.ForeColor = System.Drawing.Color.LightGray;
            this.cmbMaQuyen.FormattingEnabled = true;
            this.cmbMaQuyen.Location = new System.Drawing.Point(186, 209);
            this.cmbMaQuyen.Name = "cmbMaQuyen";
            this.cmbMaQuyen.Size = new System.Drawing.Size(213, 33);
            this.cmbMaQuyen.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(182, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "_______________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(42, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mã Quyền";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.LightGray;
            this.txtMatKhau.Location = new System.Drawing.Point(187, 82);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(213, 23);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(18, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(42, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(43, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(39, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên Đăng Nhập";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaTK.FlatAppearance.BorderSize = 0;
            this.btnXoaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTK.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaTK.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaTK.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaTK.IconColor = System.Drawing.Color.Black;
            this.btnXoaTK.IconSize = 16;
            this.btnXoaTK.Location = new System.Drawing.Point(323, 291);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Rotation = 0D;
            this.btnXoaTK.Size = new System.Drawing.Size(96, 47);
            this.btnXoaTK.TabIndex = 6;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaTK.FlatAppearance.BorderSize = 0;
            this.btnSuaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTK.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaTK.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaTK.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaTK.IconColor = System.Drawing.Color.Black;
            this.btnSuaTK.IconSize = 16;
            this.btnSuaTK.Location = new System.Drawing.Point(210, 291);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Rotation = 0D;
            this.btnSuaTK.Size = new System.Drawing.Size(95, 47);
            this.btnSuaTK.TabIndex = 5;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.UseVisualStyleBackColor = false;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(187, 40);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(213, 23);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(183, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "_______________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(183, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "_______________________";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDangNhap,
            this.matKhau,
            this.maNV,
            this.maPhanQuyen});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(401, 366);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(449, 246);
            this.dgvTaiKhoan.TabIndex = 31;
            this.dgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dgvTaiKhoan_SelectionChanged);
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDangNhap.HeaderText = "Tên Đăng Nhâp";
            this.tenDangNhap.MinimumWidth = 6;
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.ReadOnly = true;
            // 
            // matKhau
            // 
            this.matKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matKhau.HeaderText = "Mật Khẩu";
            this.matKhau.MinimumWidth = 6;
            this.matKhau.Name = "matKhau";
            this.matKhau.ReadOnly = true;
            // 
            // maNV
            // 
            this.maNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNV.HeaderText = "Mã NV";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // maPhanQuyen
            // 
            this.maPhanQuyen.HeaderText = "Mã Quyền";
            this.maPhanQuyen.MinimumWidth = 6;
            this.maPhanQuyen.Name = "maPhanQuyen";
            this.maPhanQuyen.ReadOnly = true;
            this.maPhanQuyen.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtMaNVTimKiem);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtTenDNTimKiem);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtMaQuyenTimKiem);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(863, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 308);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label23.Location = new System.Drawing.Point(10, 230);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 22);
            this.label23.TabIndex = 39;
            this.label23.Text = "Mã NV";
            // 
            // txtMaNVTimKiem
            // 
            this.txtMaNVTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaNVTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNVTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVTimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaNVTimKiem.Location = new System.Drawing.Point(14, 262);
            this.txtMaNVTimKiem.Name = "txtMaNVTimKiem";
            this.txtMaNVTimKiem.Size = new System.Drawing.Size(165, 23);
            this.txtMaNVTimKiem.TabIndex = 37;
            this.txtMaNVTimKiem.TextChanged += new System.EventHandler(this.txtMaNVTimKiem_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(11, 274);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 16);
            this.label21.TabIndex = 38;
            this.label21.Text = "______________________";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label20.Location = new System.Drawing.Point(10, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 22);
            this.label20.TabIndex = 36;
            this.label20.Text = "Tên Đăng Nhập";
            // 
            // txtTenDNTimKiem
            // 
            this.txtTenDNTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenDNTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDNTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDNTimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenDNTimKiem.Location = new System.Drawing.Point(14, 188);
            this.txtTenDNTimKiem.Name = "txtTenDNTimKiem";
            this.txtTenDNTimKiem.Size = new System.Drawing.Size(165, 23);
            this.txtTenDNTimKiem.TabIndex = 34;
            this.txtTenDNTimKiem.TextChanged += new System.EventHandler(this.txtTenDNTimKiem_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(11, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "______________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(10, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 22);
            this.label13.TabIndex = 32;
            this.label13.Text = "Tên Quyền";
            // 
            // txtMaQuyenTimKiem
            // 
            this.txtMaQuyenTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaQuyenTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaQuyenTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQuyenTimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaQuyenTimKiem.Location = new System.Drawing.Point(14, 102);
            this.txtMaQuyenTimKiem.Name = "txtMaQuyenTimKiem";
            this.txtMaQuyenTimKiem.Size = new System.Drawing.Size(165, 23);
            this.txtMaQuyenTimKiem.TabIndex = 31;
            this.txtMaQuyenTimKiem.TextChanged += new System.EventHandler(this.txtMaQuyenTimKiem_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(11, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "______________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "TÌM KIẾM";
            // 
            // picThoat
            // 
            this.picThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.picThoat.BackgroundImage = global::QuanLyKhachSanDemo.Properties.Resources.Lotus_luxury_logo_template__removebg_preview;
            this.picThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.picThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.picThoat.IconColor = System.Drawing.SystemColors.ControlText;
            this.picThoat.IconSize = 207;
            this.picThoat.Location = new System.Drawing.Point(863, 328);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(207, 267);
            this.picThoat.TabIndex = 33;
            this.picThoat.TabStop = false;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 606);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhanQuyen);
            this.Name = "frmTaiKhoan";
            this.Text = "TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenQuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuyenHan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton btnXoaLoaiQuyen;
        private FontAwesome.Sharp.IconButton btnSuaQuyen;
        private System.Windows.Forms.TextBox txtMaQuyen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnXoaTK;
        private FontAwesome.Sharp.IconButton btnSuaTK;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenHan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhanQuyen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMaNVTimKiem;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTenDNTimKiem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaQuyenTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconPictureBox picThoat;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.ComboBox cmbMaQuyen;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnThemQuyen;
        private FontAwesome.Sharp.IconButton btnThemTK;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label24;
    }
}
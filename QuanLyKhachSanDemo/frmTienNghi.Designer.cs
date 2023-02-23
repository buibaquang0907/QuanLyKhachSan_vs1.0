namespace QuanLyKhachSanDemo
{
    partial class frmTienNghi
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
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.txtTenTN = new System.Windows.Forms.TextBox();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimTenLoaiTN = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTimTenTN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbMaLoaiTN = new System.Windows.Forms.ComboBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTienNghi = new System.Windows.Forms.DataGridView();
            this.maTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.maLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPhong = new System.Windows.Forms.GroupBox();
            this.btnThemTN = new FontAwesome.Sharp.IconButton();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaTN = new FontAwesome.Sharp.IconButton();
            this.btnSuaTN = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemLoai = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLoaiTN = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnXoaLoaiTN = new FontAwesome.Sharp.IconButton();
            this.btnSuaLoaiTN = new FontAwesome.Sharp.IconButton();
            this.txtMaLoaiTN = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.picThoat = new FontAwesome.Sharp.IconPictureBox();
            this.btnLapPhieuLD = new FontAwesome.Sharp.IconButton();
            this.groupBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.gbPhong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaTN
            // 
            this.txtMaTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaTN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTN.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaTN.Location = new System.Drawing.Point(130, 59);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(210, 23);
            this.txtMaTN.TabIndex = 32;
            this.txtMaTN.TextChanged += new System.EventHandler(this.txtMaTN_TextChanged);
            // 
            // txtTenTN
            // 
            this.txtTenTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenTN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTN.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenTN.Location = new System.Drawing.Point(130, 100);
            this.txtTenTN.Name = "txtTenTN";
            this.txtTenTN.Size = new System.Drawing.Size(210, 23);
            this.txtTenTN.TabIndex = 2;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.txtTimTenLoaiTN);
            this.groupBoxTimKiem.Controls.Add(this.label20);
            this.groupBoxTimKiem.Controls.Add(this.label14);
            this.groupBoxTimKiem.Controls.Add(this.txtTimTenTN);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.label9);
            this.groupBoxTimKiem.Controls.Add(this.label8);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(828, 228);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(241, 233);
            this.groupBoxTimKiem.TabIndex = 37;
            this.groupBoxTimKiem.TabStop = false;
            // 
            // txtTimTenLoaiTN
            // 
            this.txtTimTenLoaiTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimTenLoaiTN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimTenLoaiTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenLoaiTN.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimTenLoaiTN.Location = new System.Drawing.Point(16, 94);
            this.txtTimTenLoaiTN.Name = "txtTimTenLoaiTN";
            this.txtTimTenLoaiTN.Size = new System.Drawing.Size(207, 23);
            this.txtTimTenLoaiTN.TabIndex = 1;
            this.txtTimTenLoaiTN.TextChanged += new System.EventHandler(this.txtTimTenLoaiTN_TextChanged);
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
            this.label14.Size = new System.Drawing.Size(128, 22);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tên Tiện Nghi";
            // 
            // txtTimTenTN
            // 
            this.txtTimTenTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimTenTN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimTenTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenTN.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimTenTN.Location = new System.Drawing.Point(16, 180);
            this.txtTimTenTN.Name = "txtTimTenTN";
            this.txtTimTenTN.Size = new System.Drawing.Size(207, 23);
            this.txtTimTenTN.TabIndex = 25;
            this.txtTimTenTN.TextChanged += new System.EventHandler(this.txtTimTenTN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Loại TN";
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label21.Location = new System.Drawing.Point(16, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 22);
            this.label21.TabIndex = 33;
            this.label21.Text = "Mã TN";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(126, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(216, 20);
            this.label23.TabIndex = 34;
            this.label23.Text = "_______________________";
            // 
            // cmbMaLoaiTN
            // 
            this.cmbMaLoaiTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.cmbMaLoaiTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaLoaiTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaLoaiTN.ForeColor = System.Drawing.Color.LightGray;
            this.cmbMaLoaiTN.FormattingEnabled = true;
            this.cmbMaLoaiTN.Location = new System.Drawing.Point(130, 271);
            this.cmbMaLoaiTN.Name = "cmbMaLoaiTN";
            this.cmbMaLoaiTN.Size = new System.Drawing.Size(210, 33);
            this.cmbMaLoaiTN.TabIndex = 31;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtGiaThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThue.ForeColor = System.Drawing.Color.LightGray;
            this.txtGiaThue.Location = new System.Drawing.Point(130, 182);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(210, 23);
            this.txtGiaThue.TabIndex = 3;
            this.txtGiaThue.TextChanged += new System.EventHandler(this.txtGiaThue_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(27, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(244, 25);
            this.label17.TabIndex = 29;
            this.label17.Text = "THÔNG TIN TIỆN NGHI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "ĐV Tính";
            // 
            // dgvTienNghi
            // 
            this.dgvTienNghi.AllowUserToAddRows = false;
            this.dgvTienNghi.AllowUserToDeleteRows = false;
            this.dgvTienNghi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvTienNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienNghi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTN,
            this.tenTN,
            this.donViTinh,
            this.giaThue,
            this.tinhTrang,
            this.maLoaiTN});
            this.dgvTienNghi.Location = new System.Drawing.Point(459, 12);
            this.dgvTienNghi.Name = "dgvTienNghi";
            this.dgvTienNghi.ReadOnly = true;
            this.dgvTienNghi.RowHeadersWidth = 51;
            this.dgvTienNghi.RowTemplate.Height = 24;
            this.dgvTienNghi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTienNghi.Size = new System.Drawing.Size(611, 210);
            this.dgvTienNghi.TabIndex = 33;
            this.dgvTienNghi.SelectionChanged += new System.EventHandler(this.dgvTienNghi_SelectionChanged);
            // 
            // maTN
            // 
            this.maTN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maTN.HeaderText = "Mã Tiện Nghi";
            this.maTN.MinimumWidth = 6;
            this.maTN.Name = "maTN";
            this.maTN.ReadOnly = true;
            // 
            // tenTN
            // 
            this.tenTN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenTN.HeaderText = "Tên Dịch Vụ";
            this.tenTN.MinimumWidth = 6;
            this.tenTN.Name = "tenTN";
            this.tenTN.ReadOnly = true;
            // 
            // donViTinh
            // 
            this.donViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donViTinh.HeaderText = "Đơn Vị Tính";
            this.donViTinh.MinimumWidth = 6;
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.ReadOnly = true;
            // 
            // giaThue
            // 
            this.giaThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaThue.HeaderText = "Giá Thuê";
            this.giaThue.MinimumWidth = 6;
            this.giaThue.Name = "giaThue";
            this.giaThue.ReadOnly = true;
            // 
            // tinhTrang
            // 
            this.tinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhTrang.HeaderText = "Tình Trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            // 
            // maLoaiTN
            // 
            this.maLoaiTN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiTN.HeaderText = "Mã Loại TN";
            this.maLoaiTN.MinimumWidth = 6;
            this.maLoaiTN.Name = "maLoaiTN";
            this.maLoaiTN.ReadOnly = true;
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.AllowUserToAddRows = false;
            this.dgvLoaiTN.AllowUserToDeleteRows = false;
            this.dgvLoaiTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvLoaiTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiDV,
            this.tenLoaiDV});
            this.dgvLoaiTN.Location = new System.Drawing.Point(12, 242);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.ReadOnly = true;
            this.dgvLoaiTN.RowHeadersWidth = 51;
            this.dgvLoaiTN.RowTemplate.Height = 24;
            this.dgvLoaiTN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiTN.Size = new System.Drawing.Size(425, 382);
            this.dgvLoaiTN.TabIndex = 34;
            this.dgvLoaiTN.SelectionChanged += new System.EventHandler(this.dgvLoaiTN_SelectionChanged);
            // 
            // maLoaiDV
            // 
            this.maLoaiDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiDV.HeaderText = "Mã Loại Tiên Nghi";
            this.maLoaiDV.MinimumWidth = 6;
            this.maLoaiDV.Name = "maLoaiDV";
            this.maLoaiDV.ReadOnly = true;
            // 
            // tenLoaiDV
            // 
            this.tenLoaiDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaiDV.HeaderText = "Tên Loại Tiện Nghi";
            this.tenLoaiDV.MinimumWidth = 6;
            this.tenLoaiDV.Name = "tenLoaiDV";
            this.tenLoaiDV.ReadOnly = true;
            // 
            // gbPhong
            // 
            this.gbPhong.Controls.Add(this.btnThemTN);
            this.gbPhong.Controls.Add(this.txtTinhTrang);
            this.gbPhong.Controls.Add(this.label7);
            this.gbPhong.Controls.Add(this.label13);
            this.gbPhong.Controls.Add(this.label17);
            this.gbPhong.Controls.Add(this.txtMaTN);
            this.gbPhong.Controls.Add(this.label21);
            this.gbPhong.Controls.Add(this.label23);
            this.gbPhong.Controls.Add(this.cmbMaLoaiTN);
            this.gbPhong.Controls.Add(this.txtGiaThue);
            this.gbPhong.Controls.Add(this.txtTenTN);
            this.gbPhong.Controls.Add(this.label5);
            this.gbPhong.Controls.Add(this.txtDonViTinh);
            this.gbPhong.Controls.Add(this.label4);
            this.gbPhong.Controls.Add(this.label3);
            this.gbPhong.Controls.Add(this.btnXoaTN);
            this.gbPhong.Controls.Add(this.btnSuaTN);
            this.gbPhong.Controls.Add(this.label11);
            this.gbPhong.Controls.Add(this.label12);
            this.gbPhong.Controls.Add(this.label10);
            this.gbPhong.Controls.Add(this.label2);
            this.gbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbPhong.Location = new System.Drawing.Point(459, 228);
            this.gbPhong.Name = "gbPhong";
            this.gbPhong.Size = new System.Drawing.Size(355, 396);
            this.gbPhong.TabIndex = 35;
            this.gbPhong.TabStop = false;
            // 
            // btnThemTN
            // 
            this.btnThemTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemTN.FlatAppearance.BorderSize = 0;
            this.btnThemTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemTN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemTN.IconColor = System.Drawing.Color.Black;
            this.btnThemTN.IconSize = 16;
            this.btnThemTN.Location = new System.Drawing.Point(20, 328);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Rotation = 0D;
            this.btnThemTN.Size = new System.Drawing.Size(95, 47);
            this.btnThemTN.TabIndex = 38;
            this.btnThemTN.Text = "Thêm";
            this.btnThemTN.UseVisualStyleBackColor = false;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.LightGray;
            this.txtTinhTrang.Location = new System.Drawing.Point(130, 225);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(210, 23);
            this.txtTinhTrang.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(16, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tình Trạng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(126, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "_______________________";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.ForeColor = System.Drawing.Color.LightGray;
            this.txtDonViTinh.Location = new System.Drawing.Point(130, 142);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(210, 23);
            this.txtDonViTinh.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(16, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Loại TN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(16, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá Thuê";
            // 
            // btnXoaTN
            // 
            this.btnXoaTN.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaTN.FlatAppearance.BorderSize = 0;
            this.btnXoaTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaTN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaTN.IconColor = System.Drawing.Color.Black;
            this.btnXoaTN.IconSize = 16;
            this.btnXoaTN.Location = new System.Drawing.Point(245, 328);
            this.btnXoaTN.Name = "btnXoaTN";
            this.btnXoaTN.Rotation = 0D;
            this.btnXoaTN.Size = new System.Drawing.Size(97, 47);
            this.btnXoaTN.TabIndex = 6;
            this.btnXoaTN.Text = "Xóa";
            this.btnXoaTN.UseVisualStyleBackColor = false;
            this.btnXoaTN.Click += new System.EventHandler(this.btnXoaTN_Click);
            // 
            // btnSuaTN
            // 
            this.btnSuaTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaTN.FlatAppearance.BorderSize = 0;
            this.btnSuaTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaTN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaTN.IconColor = System.Drawing.Color.Black;
            this.btnSuaTN.IconSize = 16;
            this.btnSuaTN.Location = new System.Drawing.Point(130, 328);
            this.btnSuaTN.Name = "btnSuaTN";
            this.btnSuaTN.Rotation = 0D;
            this.btnSuaTN.Size = new System.Drawing.Size(95, 47);
            this.btnSuaTN.TabIndex = 5;
            this.btnSuaTN.Text = "Sửa";
            this.btnSuaTN.UseVisualStyleBackColor = false;
            this.btnSuaTN.Click += new System.EventHandler(this.btnSuaTN_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(126, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "_______________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(126, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "_______________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(126, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "_______________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên TN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemLoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenLoaiTN);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnXoaLoaiTN);
            this.groupBox1.Controls.Add(this.btnSuaLoaiTN);
            this.groupBox1.Controls.Add(this.txtMaLoaiTN);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 233);
            this.groupBox1.TabIndex = 36;
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
            this.btnThemLoai.Location = new System.Drawing.Point(81, 161);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Rotation = 0D;
            this.btnThemLoai.Size = new System.Drawing.Size(95, 47);
            this.btnThemLoai.TabIndex = 30;
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.UseVisualStyleBackColor = false;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(18, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "THÔNG TIN LOẠI TIỆN NGHI";
            // 
            // txtTenLoaiTN
            // 
            this.txtTenLoaiTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenLoaiTN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenLoaiTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiTN.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenLoaiTN.Location = new System.Drawing.Point(128, 109);
            this.txtTenLoaiTN.Name = "txtTenLoaiTN";
            this.txtTenLoaiTN.Size = new System.Drawing.Size(278, 23);
            this.txtTenLoaiTN.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(18, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 22);
            this.label16.TabIndex = 13;
            this.label16.Text = "Mã Loại TN";
            // 
            // btnXoaLoaiTN
            // 
            this.btnXoaLoaiTN.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaLoaiTN.FlatAppearance.BorderSize = 0;
            this.btnXoaLoaiTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiTN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaLoaiTN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaLoaiTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaLoaiTN.IconColor = System.Drawing.Color.Black;
            this.btnXoaLoaiTN.IconSize = 16;
            this.btnXoaLoaiTN.Location = new System.Drawing.Point(310, 161);
            this.btnXoaLoaiTN.Name = "btnXoaLoaiTN";
            this.btnXoaLoaiTN.Rotation = 0D;
            this.btnXoaLoaiTN.Size = new System.Drawing.Size(96, 47);
            this.btnXoaLoaiTN.TabIndex = 6;
            this.btnXoaLoaiTN.Text = "Xóa";
            this.btnXoaLoaiTN.UseVisualStyleBackColor = false;
            this.btnXoaLoaiTN.Click += new System.EventHandler(this.btnXoaLoaiTN_Click);
            // 
            // btnSuaLoaiTN
            // 
            this.btnSuaLoaiTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaLoaiTN.FlatAppearance.BorderSize = 0;
            this.btnSuaLoaiTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLoaiTN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaLoaiTN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaLoaiTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaLoaiTN.IconColor = System.Drawing.Color.Black;
            this.btnSuaLoaiTN.IconSize = 16;
            this.btnSuaLoaiTN.Location = new System.Drawing.Point(197, 161);
            this.btnSuaLoaiTN.Name = "btnSuaLoaiTN";
            this.btnSuaLoaiTN.Rotation = 0D;
            this.btnSuaLoaiTN.Size = new System.Drawing.Size(95, 47);
            this.btnSuaLoaiTN.TabIndex = 5;
            this.btnSuaLoaiTN.Text = "Sửa";
            this.btnSuaLoaiTN.UseVisualStyleBackColor = false;
            this.btnSuaLoaiTN.Click += new System.EventHandler(this.btnSuaLoaiTN_Click);
            // 
            // txtMaLoaiTN
            // 
            this.txtMaLoaiTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaLoaiTN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaLoaiTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiTN.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaLoaiTN.Location = new System.Drawing.Point(128, 56);
            this.txtMaLoaiTN.Name = "txtMaLoaiTN";
            this.txtMaLoaiTN.Size = new System.Drawing.Size(278, 23);
            this.txtMaLoaiTN.TabIndex = 1;
            this.txtMaLoaiTN.TextChanged += new System.EventHandler(this.txtMaLoaiTN_TextChanged);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Location = new System.Drawing.Point(19, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 22);
            this.label15.TabIndex = 14;
            this.label15.Text = "Tên Loại TN";
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
            this.picThoat.TabIndex = 38;
            this.picThoat.TabStop = false;
            // 
            // btnLapPhieuLD
            // 
            this.btnLapPhieuLD.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLapPhieuLD.FlatAppearance.BorderSize = 0;
            this.btnLapPhieuLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuLD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLapPhieuLD.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieuLD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLapPhieuLD.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnLapPhieuLD.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnLapPhieuLD.IconSize = 60;
            this.btnLapPhieuLD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLapPhieuLD.Location = new System.Drawing.Point(828, 467);
            this.btnLapPhieuLD.Name = "btnLapPhieuLD";
            this.btnLapPhieuLD.Rotation = 0D;
            this.btnLapPhieuLD.Size = new System.Drawing.Size(241, 156);
            this.btnLapPhieuLD.TabIndex = 39;
            this.btnLapPhieuLD.Text = "Lặp Phiếu Lắp Đặt";
            this.btnLapPhieuLD.UseVisualStyleBackColor = false;
            this.btnLapPhieuLD.Click += new System.EventHandler(this.btnLapPhieuLD_Click);
            // 
            // frmTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 636);
            this.Controls.Add(this.btnLapPhieuLD);
            this.Controls.Add(this.dgvTienNghi);
            this.Controls.Add(this.dgvLoaiTN);
            this.Controls.Add(this.gbPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Name = "frmTienNghi";
            this.Text = "TIỆN NGHI";
            this.Load += new System.EventHandler(this.frmTienNghi_Load);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienNghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.gbPhong.ResumeLayout(false);
            this.gbPhong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.TextBox txtTenTN;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTimTenTN;
        private System.Windows.Forms.TextBox txtTimTenLoaiTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbMaLoaiTN;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTienNghi;
        private System.Windows.Forms.DataGridView dgvLoaiTN;
        private System.Windows.Forms.GroupBox gbPhong;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnXoaTN;
        private FontAwesome.Sharp.IconButton btnSuaTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenLoaiTN;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton btnXoaLoaiTN;
        private FontAwesome.Sharp.IconButton btnSuaLoaiTN;
        private System.Windows.Forms.TextBox txtMaLoaiTN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconPictureBox picThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiTN;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnLapPhieuLD;
        private FontAwesome.Sharp.IconButton btnThemLoai;
        private FontAwesome.Sharp.IconButton btnThemTN;
    }
}
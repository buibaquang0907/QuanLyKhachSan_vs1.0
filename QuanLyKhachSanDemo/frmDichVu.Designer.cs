namespace QuanLyKhachSanDemo
{
    partial class frmDichVu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemLoai = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLoaiDV = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnXoaLoaiDV = new FontAwesome.Sharp.IconButton();
            this.btnSuaLoai = new FontAwesome.Sharp.IconButton();
            this.txtMaLoaiDV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbMaLoaiDV = new System.Windows.Forms.ComboBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTimTenDichVu = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimLoaiDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaDV = new FontAwesome.Sharp.IconButton();
            this.btnXoaDV = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.maDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoaiDV = new System.Windows.Forms.DataGridView();
            this.maLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPhong = new System.Windows.Forms.GroupBox();
            this.btnThemDV = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLapPhieuSDDV = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDV)).BeginInit();
            this.gbPhong.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemLoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenLoaiDV);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnXoaLoaiDV);
            this.groupBox1.Controls.Add(this.btnSuaLoai);
            this.groupBox1.Controls.Add(this.txtMaLoaiDV);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 224);
            this.groupBox1.TabIndex = 30;
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
            this.btnThemLoai.Location = new System.Drawing.Point(83, 161);
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
            this.label6.Size = new System.Drawing.Size(273, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "THÔNG TIN LOẠI DỊCH VỤ";
            // 
            // txtTenLoaiDV
            // 
            this.txtTenLoaiDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenLoaiDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiDV.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenLoaiDV.Location = new System.Drawing.Point(128, 109);
            this.txtTenLoaiDV.Name = "txtTenLoaiDV";
            this.txtTenLoaiDV.Size = new System.Drawing.Size(278, 23);
            this.txtTenLoaiDV.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(18, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 22);
            this.label16.TabIndex = 13;
            this.label16.Text = "Mã Loại DV";
            // 
            // btnXoaLoaiDV
            // 
            this.btnXoaLoaiDV.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaLoaiDV.FlatAppearance.BorderSize = 0;
            this.btnXoaLoaiDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiDV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaLoaiDV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaLoaiDV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaLoaiDV.IconColor = System.Drawing.Color.Black;
            this.btnXoaLoaiDV.IconSize = 16;
            this.btnXoaLoaiDV.Location = new System.Drawing.Point(310, 161);
            this.btnXoaLoaiDV.Name = "btnXoaLoaiDV";
            this.btnXoaLoaiDV.Rotation = 0D;
            this.btnXoaLoaiDV.Size = new System.Drawing.Size(96, 47);
            this.btnXoaLoaiDV.TabIndex = 6;
            this.btnXoaLoaiDV.Text = "Xóa";
            this.btnXoaLoaiDV.UseVisualStyleBackColor = false;
            this.btnXoaLoaiDV.Click += new System.EventHandler(this.btnXoaLoaiDV_Click);
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
            this.btnSuaLoai.Location = new System.Drawing.Point(197, 161);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Rotation = 0D;
            this.btnSuaLoai.Size = new System.Drawing.Size(95, 47);
            this.btnSuaLoai.TabIndex = 5;
            this.btnSuaLoai.Text = "Sửa";
            this.btnSuaLoai.UseVisualStyleBackColor = false;
            this.btnSuaLoai.Click += new System.EventHandler(this.btnSuaLoai_Click);
            // 
            // txtMaLoaiDV
            // 
            this.txtMaLoaiDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaLoaiDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiDV.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaLoaiDV.Location = new System.Drawing.Point(128, 56);
            this.txtMaLoaiDV.Name = "txtMaLoaiDV";
            this.txtMaLoaiDV.Size = new System.Drawing.Size(278, 23);
            this.txtMaLoaiDV.TabIndex = 1;
            this.txtMaLoaiDV.TextChanged += new System.EventHandler(this.txtMaLoaiDV_TextChanged);
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
            this.label15.Size = new System.Drawing.Size(112, 22);
            this.label15.TabIndex = 14;
            this.label15.Text = "Tên Loại DV";
            // 
            // txtMaDV
            // 
            this.txtMaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtMaDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaDV.Location = new System.Drawing.Point(130, 59);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(210, 23);
            this.txtMaDV.TabIndex = 32;
            this.txtMaDV.TextChanged += new System.EventHandler(this.txtMaDV_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label21.Location = new System.Drawing.Point(12, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 22);
            this.label21.TabIndex = 33;
            this.label21.Text = "Mã Dịch Vụ";
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
            // cmbMaLoaiDV
            // 
            this.cmbMaLoaiDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.cmbMaLoaiDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaLoaiDV.ForeColor = System.Drawing.Color.LightGray;
            this.cmbMaLoaiDV.FormattingEnabled = true;
            this.cmbMaLoaiDV.Location = new System.Drawing.Point(130, 259);
            this.cmbMaLoaiDV.Name = "cmbMaLoaiDV";
            this.cmbMaLoaiDV.Size = new System.Drawing.Size(210, 33);
            this.cmbMaLoaiDV.TabIndex = 31;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtGiaThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThue.ForeColor = System.Drawing.Color.LightGray;
            this.txtGiaThue.Location = new System.Drawing.Point(130, 209);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(210, 23);
            this.txtGiaThue.TabIndex = 3;
            this.txtGiaThue.TextChanged += new System.EventHandler(this.txtGiaThue_TextChanged);
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
            this.label14.Size = new System.Drawing.Size(113, 22);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tên Dịch Vụ";
            // 
            // txtTimTenDichVu
            // 
            this.txtTimTenDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimTenDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenDichVu.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimTenDichVu.Location = new System.Drawing.Point(16, 180);
            this.txtTimTenDichVu.Name = "txtTimTenDichVu";
            this.txtTimTenDichVu.Size = new System.Drawing.Size(207, 23);
            this.txtTimTenDichVu.TabIndex = 25;
            this.txtTimTenDichVu.TextChanged += new System.EventHandler(this.txtTimTenDichVu_TextChanged);
            // 
            // txtTenDV
            // 
            this.txtTenDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTenDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.ForeColor = System.Drawing.Color.LightGray;
            this.txtTenDV.Location = new System.Drawing.Point(130, 108);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(210, 23);
            this.txtTenDV.TabIndex = 2;
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
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "ĐV Tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.ForeColor = System.Drawing.Color.LightGray;
            this.txtDonViTinh.Location = new System.Drawing.Point(130, 157);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(210, 23);
            this.txtDonViTinh.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(16, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Loại DV";
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.label20);
            this.groupBoxTimKiem.Controls.Add(this.label14);
            this.groupBoxTimKiem.Controls.Add(this.txtTimTenDichVu);
            this.groupBoxTimKiem.Controls.Add(this.txtTimLoaiDV);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.label9);
            this.groupBoxTimKiem.Controls.Add(this.label8);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(828, 228);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(241, 233);
            this.groupBoxTimKiem.TabIndex = 31;
            this.groupBoxTimKiem.TabStop = false;
            // 
            // txtTimLoaiDV
            // 
            this.txtTimLoaiDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.txtTimLoaiDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimLoaiDV.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimLoaiDV.Location = new System.Drawing.Point(16, 94);
            this.txtTimLoaiDV.Name = "txtTimLoaiDV";
            this.txtTimLoaiDV.Size = new System.Drawing.Size(207, 23);
            this.txtTimLoaiDV.TabIndex = 1;
            this.txtTimLoaiDV.TextChanged += new System.EventHandler(this.txtTimLoaiDV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Loại DV";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá Thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaDV.FlatAppearance.BorderSize = 0;
            this.btnSuaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaDV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaDV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaDV.IconColor = System.Drawing.Color.Black;
            this.btnSuaDV.IconSize = 16;
            this.btnSuaDV.Location = new System.Drawing.Point(130, 328);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Rotation = 0D;
            this.btnSuaDV.Size = new System.Drawing.Size(95, 47);
            this.btnSuaDV.TabIndex = 5;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = false;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaDV.FlatAppearance.BorderSize = 0;
            this.btnXoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaDV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaDV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaDV.IconColor = System.Drawing.Color.Black;
            this.btnXoaDV.IconSize = 16;
            this.btnXoaDV.Location = new System.Drawing.Point(243, 328);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Rotation = 0D;
            this.btnXoaDV.Size = new System.Drawing.Size(97, 47);
            this.btnXoaDV.TabIndex = 6;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(126, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "_______________________";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDichVu,
            this.tenDichVu,
            this.donViTinh,
            this.giaThue,
            this.maLoaiDichVu});
            this.dgvDichVu.Location = new System.Drawing.Point(459, 12);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(611, 208);
            this.dgvDichVu.TabIndex = 27;
            this.dgvDichVu.SelectionChanged += new System.EventHandler(this.dgvDichVu_SelectionChanged);
            // 
            // maDichVu
            // 
            this.maDichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maDichVu.HeaderText = "Mã Dịch Vụ";
            this.maDichVu.MinimumWidth = 6;
            this.maDichVu.Name = "maDichVu";
            this.maDichVu.ReadOnly = true;
            // 
            // tenDichVu
            // 
            this.tenDichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDichVu.HeaderText = "Tên Dịch Vụ";
            this.tenDichVu.MinimumWidth = 6;
            this.tenDichVu.Name = "tenDichVu";
            this.tenDichVu.ReadOnly = true;
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
            // maLoaiDichVu
            // 
            this.maLoaiDichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiDichVu.HeaderText = "Mã Loại DV";
            this.maLoaiDichVu.MinimumWidth = 6;
            this.maLoaiDichVu.Name = "maLoaiDichVu";
            this.maLoaiDichVu.ReadOnly = true;
            // 
            // dgvLoaiDV
            // 
            this.dgvLoaiDV.AllowUserToAddRows = false;
            this.dgvLoaiDV.AllowUserToDeleteRows = false;
            this.dgvLoaiDV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dgvLoaiDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiDV,
            this.tenLoaiDV});
            this.dgvLoaiDV.Location = new System.Drawing.Point(12, 242);
            this.dgvLoaiDV.Name = "dgvLoaiDV";
            this.dgvLoaiDV.ReadOnly = true;
            this.dgvLoaiDV.RowHeadersWidth = 51;
            this.dgvLoaiDV.RowTemplate.Height = 24;
            this.dgvLoaiDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiDV.Size = new System.Drawing.Size(425, 382);
            this.dgvLoaiDV.TabIndex = 28;
            this.dgvLoaiDV.SelectionChanged += new System.EventHandler(this.dgvLoaiDV_SelectionChanged);
            // 
            // maLoaiDV
            // 
            this.maLoaiDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiDV.HeaderText = "Mã Loại ";
            this.maLoaiDV.MinimumWidth = 6;
            this.maLoaiDV.Name = "maLoaiDV";
            this.maLoaiDV.ReadOnly = true;
            // 
            // tenLoaiDV
            // 
            this.tenLoaiDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaiDV.HeaderText = "Tên Loại DV";
            this.tenLoaiDV.MinimumWidth = 6;
            this.tenLoaiDV.Name = "tenLoaiDV";
            this.tenLoaiDV.ReadOnly = true;
            // 
            // gbPhong
            // 
            this.gbPhong.Controls.Add(this.btnThemDV);
            this.gbPhong.Controls.Add(this.txtMaDV);
            this.gbPhong.Controls.Add(this.label21);
            this.gbPhong.Controls.Add(this.label23);
            this.gbPhong.Controls.Add(this.cmbMaLoaiDV);
            this.gbPhong.Controls.Add(this.txtGiaThue);
            this.gbPhong.Controls.Add(this.txtTenDV);
            this.gbPhong.Controls.Add(this.label17);
            this.gbPhong.Controls.Add(this.label5);
            this.gbPhong.Controls.Add(this.txtDonViTinh);
            this.gbPhong.Controls.Add(this.label4);
            this.gbPhong.Controls.Add(this.label3);
            this.gbPhong.Controls.Add(this.btnXoaDV);
            this.gbPhong.Controls.Add(this.btnSuaDV);
            this.gbPhong.Controls.Add(this.label11);
            this.gbPhong.Controls.Add(this.label12);
            this.gbPhong.Controls.Add(this.label10);
            this.gbPhong.Controls.Add(this.label2);
            this.gbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbPhong.Location = new System.Drawing.Point(459, 226);
            this.gbPhong.Name = "gbPhong";
            this.gbPhong.Size = new System.Drawing.Size(355, 398);
            this.gbPhong.TabIndex = 29;
            this.gbPhong.TabStop = false;
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemDV.FlatAppearance.BorderSize = 0;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemDV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemDV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemDV.IconColor = System.Drawing.Color.Black;
            this.btnThemDV.IconSize = 16;
            this.btnThemDV.Location = new System.Drawing.Point(16, 328);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Rotation = 0D;
            this.btnThemDV.Size = new System.Drawing.Size(95, 47);
            this.btnThemDV.TabIndex = 35;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(126, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "_______________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(126, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "_______________________";
            // 
            // btnLapPhieuSDDV
            // 
            this.btnLapPhieuSDDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLapPhieuSDDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLapPhieuSDDV.FlatAppearance.BorderSize = 0;
            this.btnLapPhieuSDDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuSDDV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLapPhieuSDDV.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieuSDDV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLapPhieuSDDV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLapPhieuSDDV.IconColor = System.Drawing.Color.Black;
            this.btnLapPhieuSDDV.IconSize = 16;
            this.btnLapPhieuSDDV.Location = new System.Drawing.Point(0, 0);
            this.btnLapPhieuSDDV.Name = "btnLapPhieuSDDV";
            this.btnLapPhieuSDDV.Rotation = 0D;
            this.btnLapPhieuSDDV.Size = new System.Drawing.Size(242, 148);
            this.btnLapPhieuSDDV.TabIndex = 36;
            this.btnLapPhieuSDDV.Text = "LẶP PHIẾU SỬ DỤNG DỊCH VỤ";
            this.btnLapPhieuSDDV.UseVisualStyleBackColor = false;
            this.btnLapPhieuSDDV.Click += new System.EventHandler(this.btnLapPhieuSDDV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLapPhieuSDDV);
            this.panel1.Location = new System.Drawing.Point(828, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 148);
            this.panel1.TabIndex = 32;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.dgvLoaiDV);
            this.Controls.Add(this.gbPhong);
            this.Name = "frmDichVu";
            this.Text = "DỊCH VỤ";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDV)).EndInit();
            this.gbPhong.ResumeLayout(false);
            this.gbPhong.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenLoaiDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton btnXoaLoaiDV;
        private FontAwesome.Sharp.IconButton btnSuaLoai;
        private System.Windows.Forms.TextBox txtMaLoaiDV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbMaLoaiDV;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTimTenDichVu;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.TextBox txtTimLoaiDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnSuaDV;
        private FontAwesome.Sharp.IconButton btnXoaDV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridView dgvLoaiDV;
        private System.Windows.Forms.GroupBox gbPhong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDichVu;
        private FontAwesome.Sharp.IconButton btnThemLoai;
        private FontAwesome.Sharp.IconButton btnThemDV;
        private FontAwesome.Sharp.IconButton btnLapPhieuSDDV;
        private System.Windows.Forms.Panel panel1;
    }
}
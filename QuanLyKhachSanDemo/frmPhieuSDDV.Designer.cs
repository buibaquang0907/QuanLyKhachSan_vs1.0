namespace QuanLyKhachSanDemo
{
    partial class frmPhieuSDDV
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
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnSuaSDDV = new FontAwesome.Sharp.IconButton();
            this.cmbMaChuyenPhong = new System.Windows.Forms.ComboBox();
            this.cmbMaPhieuDatPhong = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKH = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTimCCCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.cmbDichVu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNgaySDDV = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaSDDV = new FontAwesome.Sharp.IconButton();
            this.cmbThemSDDV = new FontAwesome.Sharp.IconButton();
            this.txtMaPhieuSDDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvPhieuSDDV = new System.Windows.Forms.DataGridView();
            this.maPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTienNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuSDDV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.IndianRed;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1025, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(48, 32);
            this.btnExit.TabIndex = 48;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSuaSDDV
            // 
            this.btnSuaSDDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaSDDV.FlatAppearance.BorderSize = 0;
            this.btnSuaSDDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSDDV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaSDDV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaSDDV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaSDDV.IconColor = System.Drawing.Color.Black;
            this.btnSuaSDDV.IconSize = 16;
            this.btnSuaSDDV.Location = new System.Drawing.Point(116, 438);
            this.btnSuaSDDV.Name = "btnSuaSDDV";
            this.btnSuaSDDV.Rotation = 0D;
            this.btnSuaSDDV.Size = new System.Drawing.Size(95, 47);
            this.btnSuaSDDV.TabIndex = 57;
            this.btnSuaSDDV.Text = "Sửa";
            this.btnSuaSDDV.UseVisualStyleBackColor = false;
            this.btnSuaSDDV.Click += new System.EventHandler(this.btnSuaSDDV_Click);
            // 
            // cmbMaChuyenPhong
            // 
            this.cmbMaChuyenPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cmbMaChuyenPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaChuyenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaChuyenPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMaChuyenPhong.FormattingEnabled = true;
            this.cmbMaChuyenPhong.Location = new System.Drawing.Point(185, 336);
            this.cmbMaChuyenPhong.Name = "cmbMaChuyenPhong";
            this.cmbMaChuyenPhong.Size = new System.Drawing.Size(213, 33);
            this.cmbMaChuyenPhong.TabIndex = 56;
            // 
            // cmbMaPhieuDatPhong
            // 
            this.cmbMaPhieuDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cmbMaPhieuDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaPhieuDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPhieuDatPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMaPhieuDatPhong.FormattingEnabled = true;
            this.cmbMaPhieuDatPhong.Location = new System.Drawing.Point(186, 284);
            this.cmbMaPhieuDatPhong.Name = "cmbMaPhieuDatPhong";
            this.cmbMaPhieuDatPhong.Size = new System.Drawing.Size(213, 33);
            this.cmbMaPhieuDatPhong.TabIndex = 55;
            this.cmbMaPhieuDatPhong.SelectedIndexChanged += new System.EventHandler(this.cmbMaPhieuDatPhong_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKH);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtTimCCCD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnSuaSDDV);
            this.groupBox2.Controls.Add(this.cmbMaChuyenPhong);
            this.groupBox2.Controls.Add(this.cmbMaPhieuDatPhong);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.cmbDichVu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtpNgaySDDV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnXoaSDDV);
            this.groupBox2.Controls.Add(this.cmbThemSDDV);
            this.groupBox2.Controls.Add(this.txtMaPhieuSDDV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(633, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 500);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // cmbKH
            // 
            this.cmbKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cmbKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKH.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbKH.FormattingEnabled = true;
            this.cmbKH.Location = new System.Drawing.Point(186, 233);
            this.cmbKH.Name = "cmbKH";
            this.cmbKH.Size = new System.Drawing.Size(213, 33);
            this.cmbKH.TabIndex = 63;
            this.cmbKH.SelectedIndexChanged += new System.EventHandler(this.cmbKH_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(186, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(216, 20);
            this.label16.TabIndex = 62;
            this.label16.Text = "_______________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(35, 237);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 22);
            this.label17.TabIndex = 61;
            this.label17.Text = "Khách hàng";
            // 
            // txtTimCCCD
            // 
            this.txtTimCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtTimCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimCCCD.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTimCCCD.Location = new System.Drawing.Point(186, 188);
            this.txtTimCCCD.Name = "txtTimCCCD";
            this.txtTimCCCD.Size = new System.Drawing.Size(213, 23);
            this.txtTimCCCD.TabIndex = 58;
            this.txtTimCCCD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(35, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "CCCD KH";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(186, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 20);
            this.label13.TabIndex = 60;
            this.label13.Text = "_______________________";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconSize = 16;
            this.btnThoat.Location = new System.Drawing.Point(319, 438);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Rotation = 0D;
            this.btnThoat.Size = new System.Drawing.Size(96, 47);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Trở Về";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbDichVu
            // 
            this.cmbDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cmbDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDichVu.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDichVu.FormattingEnabled = true;
            this.cmbDichVu.Location = new System.Drawing.Point(186, 386);
            this.cmbDichVu.Name = "cmbDichVu";
            this.cmbDichVu.Size = new System.Drawing.Size(213, 33);
            this.cmbDichVu.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(186, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "_______________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(35, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tên Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "THÔNG TIN PHIẾU SDDV";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(35, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 22);
            this.label14.TabIndex = 42;
            this.label14.Text = "Mã phiếu CP";
            // 
            // dtpNgaySDDV
            // 
            this.dtpNgaySDDV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySDDV.Location = new System.Drawing.Point(186, 141);
            this.dtpNgaySDDV.Name = "dtpNgaySDDV";
            this.dtpNgaySDDV.Size = new System.Drawing.Size(212, 27);
            this.dtpNgaySDDV.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(35, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ngày SDDV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(186, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "_______________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(186, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "_______________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(35, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mã phiếu ĐP";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSoLuong.Location = new System.Drawing.Point(186, 100);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(213, 23);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(35, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã phiếu SDDV";
            // 
            // btnXoaSDDV
            // 
            this.btnXoaSDDV.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaSDDV.FlatAppearance.BorderSize = 0;
            this.btnXoaSDDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSDDV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaSDDV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaSDDV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaSDDV.IconColor = System.Drawing.Color.Black;
            this.btnXoaSDDV.IconSize = 16;
            this.btnXoaSDDV.Location = new System.Drawing.Point(217, 438);
            this.btnXoaSDDV.Name = "btnXoaSDDV";
            this.btnXoaSDDV.Rotation = 0D;
            this.btnXoaSDDV.Size = new System.Drawing.Size(96, 47);
            this.btnXoaSDDV.TabIndex = 6;
            this.btnXoaSDDV.Text = "Xóa";
            this.btnXoaSDDV.UseVisualStyleBackColor = false;
            this.btnXoaSDDV.Click += new System.EventHandler(this.btnXoaSDDV_Click);
            // 
            // cmbThemSDDV
            // 
            this.cmbThemSDDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbThemSDDV.FlatAppearance.BorderSize = 0;
            this.cmbThemSDDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbThemSDDV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.cmbThemSDDV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmbThemSDDV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cmbThemSDDV.IconColor = System.Drawing.Color.Black;
            this.cmbThemSDDV.IconSize = 16;
            this.cmbThemSDDV.Location = new System.Drawing.Point(15, 438);
            this.cmbThemSDDV.Name = "cmbThemSDDV";
            this.cmbThemSDDV.Rotation = 0D;
            this.cmbThemSDDV.Size = new System.Drawing.Size(95, 47);
            this.cmbThemSDDV.TabIndex = 5;
            this.cmbThemSDDV.Text = "Thêm";
            this.cmbThemSDDV.UseVisualStyleBackColor = false;
            this.cmbThemSDDV.Click += new System.EventHandler(this.cmbThemSDDV_Click);
            // 
            // txtMaPhieuSDDV
            // 
            this.txtMaPhieuSDDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtMaPhieuSDDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuSDDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuSDDV.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMaPhieuSDDV.Location = new System.Drawing.Point(186, 58);
            this.txtMaPhieuSDDV.Name = "txtMaPhieuSDDV";
            this.txtMaPhieuSDDV.Size = new System.Drawing.Size(213, 23);
            this.txtMaPhieuSDDV.TabIndex = 1;
            this.txtMaPhieuSDDV.TextChanged += new System.EventHandler(this.txtMaPhieuSDDV_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(186, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "_______________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(186, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "_______________________";
            // 
            // dgvPhieuSDDV
            // 
            this.dgvPhieuSDDV.AllowUserToAddRows = false;
            this.dgvPhieuSDDV.AllowUserToDeleteRows = false;
            this.dgvPhieuSDDV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dgvPhieuSDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuSDDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieu,
            this.NgaySuDung,
            this.soluong,
            this.maTienNghi,
            this.maPhong,
            this.maNV,
            this.maPhieuDV});
            this.dgvPhieuSDDV.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvPhieuSDDV.Location = new System.Drawing.Point(10, 133);
            this.dgvPhieuSDDV.Name = "dgvPhieuSDDV";
            this.dgvPhieuSDDV.ReadOnly = true;
            this.dgvPhieuSDDV.RowHeadersWidth = 51;
            this.dgvPhieuSDDV.RowTemplate.Height = 24;
            this.dgvPhieuSDDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuSDDV.Size = new System.Drawing.Size(617, 491);
            this.dgvPhieuSDDV.TabIndex = 45;
            this.dgvPhieuSDDV.SelectionChanged += new System.EventHandler(this.dgvPhieuSDDV_SelectionChanged);
            // 
            // maPhieu
            // 
            this.maPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhieu.HeaderText = "Mã phiếu";
            this.maPhieu.MinimumWidth = 6;
            this.maPhieu.Name = "maPhieu";
            this.maPhieu.ReadOnly = true;
            // 
            // NgaySuDung
            // 
            this.NgaySuDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySuDung.HeaderText = "Ngày sử dụng";
            this.NgaySuDung.MinimumWidth = 6;
            this.NgaySuDung.Name = "NgaySuDung";
            this.NgaySuDung.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // maTienNghi
            // 
            this.maTienNghi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maTienNghi.HeaderText = "Mã NV";
            this.maTienNghi.MinimumWidth = 6;
            this.maTienNghi.Name = "maTienNghi";
            this.maTienNghi.ReadOnly = true;
            // 
            // maPhong
            // 
            this.maPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhong.HeaderText = "Mã Phiếu ĐP";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            this.maPhong.ReadOnly = true;
            // 
            // maNV
            // 
            this.maNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNV.HeaderText = "Mã Phiếu CP";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // maPhieuDV
            // 
            this.maPhieuDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhieuDV.HeaderText = "Mã Dịch Vụ";
            this.maPhieuDV.MinimumWidth = 6;
            this.maPhieuDV.Name = "maPhieuDV";
            this.maPhieuDV.ReadOnly = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(10, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(556, 50);
            this.label18.TabIndex = 47;
            this.label18.Text = "PHIẾU SỬ DỤNG DỊCH VỤ";
            // 
            // frmPhieuSDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 636);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPhieuSDDV);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuSDDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuSDDV";
            this.Load += new System.EventHandler(this.frmPhieuSDDV_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuSDDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSuaSDDV;
        private System.Windows.Forms.ComboBox cmbMaChuyenPhong;
        private System.Windows.Forms.ComboBox cmbMaPhieuDatPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.ComboBox cmbDichVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpNgaySDDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnXoaSDDV;
        private FontAwesome.Sharp.IconButton cmbThemSDDV;
        private System.Windows.Forms.TextBox txtMaPhieuSDDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvPhieuSDDV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTienNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDV;
        private System.Windows.Forms.TextBox txtTimCCCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}
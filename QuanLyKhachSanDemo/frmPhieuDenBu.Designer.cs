namespace QuanLyKhachSanDemo
{
    partial class frmPhieuDenBu
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
            this.btnSuaDB = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaPKT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaTN = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaDB = new FontAwesome.Sharp.IconButton();
            this.btnThemDB = new FontAwesome.Sharp.IconButton();
            this.txtMaPhieuDB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvPhieuDenBu = new System.Windows.Forms.DataGridView();
            this.maPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapPhieuDenBu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuKiemTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDenBu)).BeginInit();
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
            // btnSuaDB
            // 
            this.btnSuaDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaDB.FlatAppearance.BorderSize = 0;
            this.btnSuaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDB.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaDB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaDB.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaDB.IconColor = System.Drawing.Color.Black;
            this.btnSuaDB.IconSize = 16;
            this.btnSuaDB.Location = new System.Drawing.Point(116, 424);
            this.btnSuaDB.Name = "btnSuaDB";
            this.btnSuaDB.Rotation = 0D;
            this.btnSuaDB.Size = new System.Drawing.Size(95, 47);
            this.btnSuaDB.TabIndex = 57;
            this.btnSuaDB.Text = "Sửa";
            this.btnSuaDB.UseVisualStyleBackColor = false;
            this.btnSuaDB.Click += new System.EventHandler(this.btnSuaDB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaPKT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbMaTN);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnSuaDB);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpNgayLapPhieu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTienPhat);
            this.groupBox2.Controls.Add(this.txtNoiDung);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnXoaDB);
            this.groupBox2.Controls.Add(this.btnThemDB);
            this.groupBox2.Controls.Add(this.txtMaPhieuDB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(633, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 477);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // txtMaPKT
            // 
            this.txtMaPKT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtMaPKT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPKT.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMaPKT.Location = new System.Drawing.Point(178, 336);
            this.txtMaPKT.Name = "txtMaPKT";
            this.txtMaPKT.ReadOnly = true;
            this.txtMaPKT.Size = new System.Drawing.Size(213, 23);
            this.txtMaPKT.TabIndex = 62;
            this.txtMaPKT.TextChanged += new System.EventHandler(this.txtMaPKT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(178, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "_______________________";
            // 
            // cmbMaTN
            // 
            this.cmbMaTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cmbMaTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMaTN.FormattingEnabled = true;
            this.cmbMaTN.Location = new System.Drawing.Point(177, 272);
            this.cmbMaTN.Name = "cmbMaTN";
            this.cmbMaTN.Size = new System.Drawing.Size(213, 33);
            this.cmbMaTN.TabIndex = 61;
            this.cmbMaTN.SelectedValueChanged += new System.EventHandler(this.cmbMaTN_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(178, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "_______________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(38, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 22);
            this.label11.TabIndex = 59;
            this.label11.Text = "Mã Phiếu TN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(178, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "_______________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(38, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 22);
            this.label17.TabIndex = 52;
            this.label17.Text = "Mã Phiếu KT";
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
            this.btnThoat.Location = new System.Drawing.Point(319, 424);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Rotation = 0D;
            this.btnThoat.Size = new System.Drawing.Size(96, 47);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Trở Về";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Ngày Lập phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "THÔNG TIN PHIẾU ĐỀN BÙ";
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(178, 213);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(212, 27);
            this.dtpNgayLapPhieu.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(38, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tiền Phạt";
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtTienPhat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhat.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTienPhat.Location = new System.Drawing.Point(178, 159);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.ReadOnly = true;
            this.txtTienPhat.Size = new System.Drawing.Size(213, 23);
            this.txtTienPhat.TabIndex = 2;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNoiDung.Location = new System.Drawing.Point(178, 107);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(213, 23);
            this.txtNoiDung.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(38, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nội Dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(38, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã phiếu DB";
            // 
            // btnXoaDB
            // 
            this.btnXoaDB.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaDB.FlatAppearance.BorderSize = 0;
            this.btnXoaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDB.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaDB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaDB.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaDB.IconColor = System.Drawing.Color.Black;
            this.btnXoaDB.IconSize = 16;
            this.btnXoaDB.Location = new System.Drawing.Point(217, 424);
            this.btnXoaDB.Name = "btnXoaDB";
            this.btnXoaDB.Rotation = 0D;
            this.btnXoaDB.Size = new System.Drawing.Size(96, 47);
            this.btnXoaDB.TabIndex = 6;
            this.btnXoaDB.Text = "Xóa";
            this.btnXoaDB.UseVisualStyleBackColor = false;
            this.btnXoaDB.Click += new System.EventHandler(this.btnXoaDB_Click);
            // 
            // btnThemDB
            // 
            this.btnThemDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemDB.FlatAppearance.BorderSize = 0;
            this.btnThemDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDB.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemDB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemDB.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemDB.IconColor = System.Drawing.Color.Black;
            this.btnThemDB.IconSize = 16;
            this.btnThemDB.Location = new System.Drawing.Point(15, 424);
            this.btnThemDB.Name = "btnThemDB";
            this.btnThemDB.Rotation = 0D;
            this.btnThemDB.Size = new System.Drawing.Size(95, 47);
            this.btnThemDB.TabIndex = 5;
            this.btnThemDB.Text = "Thêm";
            this.btnThemDB.UseVisualStyleBackColor = false;
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            // 
            // txtMaPhieuDB
            // 
            this.txtMaPhieuDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtMaPhieuDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuDB.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMaPhieuDB.Location = new System.Drawing.Point(178, 62);
            this.txtMaPhieuDB.Name = "txtMaPhieuDB";
            this.txtMaPhieuDB.Size = new System.Drawing.Size(213, 23);
            this.txtMaPhieuDB.TabIndex = 1;
            this.txtMaPhieuDB.TextChanged += new System.EventHandler(this.txtMaPhieuDB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(178, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "_______________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(178, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "_______________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(178, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "_______________________";
            // 
            // dgvPhieuDenBu
            // 
            this.dgvPhieuDenBu.AllowUserToAddRows = false;
            this.dgvPhieuDenBu.AllowUserToDeleteRows = false;
            this.dgvPhieuDenBu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dgvPhieuDenBu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDenBu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieu,
            this.noiDung,
            this.tienPhat,
            this.ngayLapPhieuDenBu,
            this.maPhieuKiemTra});
            this.dgvPhieuDenBu.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvPhieuDenBu.Location = new System.Drawing.Point(10, 133);
            this.dgvPhieuDenBu.Name = "dgvPhieuDenBu";
            this.dgvPhieuDenBu.ReadOnly = true;
            this.dgvPhieuDenBu.RowHeadersWidth = 51;
            this.dgvPhieuDenBu.RowTemplate.Height = 24;
            this.dgvPhieuDenBu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDenBu.Size = new System.Drawing.Size(617, 468);
            this.dgvPhieuDenBu.TabIndex = 45;
            this.dgvPhieuDenBu.SelectionChanged += new System.EventHandler(this.dgvPhieuDenBu_SelectionChanged);
            // 
            // maPhieu
            // 
            this.maPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhieu.HeaderText = "Mã phiếu";
            this.maPhieu.MinimumWidth = 6;
            this.maPhieu.Name = "maPhieu";
            this.maPhieu.ReadOnly = true;
            // 
            // noiDung
            // 
            this.noiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiDung.HeaderText = "Nội dung";
            this.noiDung.MinimumWidth = 6;
            this.noiDung.Name = "noiDung";
            this.noiDung.ReadOnly = true;
            // 
            // tienPhat
            // 
            this.tienPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tienPhat.HeaderText = "Tiền Phạt";
            this.tienPhat.MinimumWidth = 6;
            this.tienPhat.Name = "tienPhat";
            this.tienPhat.ReadOnly = true;
            // 
            // ngayLapPhieuDenBu
            // 
            this.ngayLapPhieuDenBu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayLapPhieuDenBu.HeaderText = "Ngày lập phiếu";
            this.ngayLapPhieuDenBu.MinimumWidth = 6;
            this.ngayLapPhieuDenBu.Name = "ngayLapPhieuDenBu";
            this.ngayLapPhieuDenBu.ReadOnly = true;
            // 
            // maPhieuKiemTra
            // 
            this.maPhieuKiemTra.HeaderText = "Mã Phiếu Kiểm Tra";
            this.maPhieuKiemTra.MinimumWidth = 6;
            this.maPhieuKiemTra.Name = "maPhieuKiemTra";
            this.maPhieuKiemTra.ReadOnly = true;
            this.maPhieuKiemTra.Width = 125;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(10, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(338, 50);
            this.label18.TabIndex = 47;
            this.label18.Text = "PHIẾU ĐỀN BÙ";
            // 
            // frmPhieuDenBu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 636);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPhieuDenBu);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuDenBu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuDenBu";
            this.Load += new System.EventHandler(this.frmPhieuDenBu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDenBu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSuaDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnXoaDB;
        private FontAwesome.Sharp.IconButton btnThemDB;
        private System.Windows.Forms.TextBox txtMaPhieuDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvPhieuDenBu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapPhieuDenBu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuKiemTra;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMaTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaPKT;
        private System.Windows.Forms.Label label6;
    }
}
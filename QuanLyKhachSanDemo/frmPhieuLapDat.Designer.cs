namespace QuanLyKhachSanDemo
{
    partial class frmPhieuLapDat
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
            this.dgvPhieuLapDat = new System.Windows.Forms.DataGridView();
            this.maPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTienNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMaTN = new System.Windows.Forms.ComboBox();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.txtMaPhieuLD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuLapDat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuLapDat
            // 
            this.dgvPhieuLapDat.AllowUserToAddRows = false;
            this.dgvPhieuLapDat.AllowUserToDeleteRows = false;
            this.dgvPhieuLapDat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dgvPhieuLapDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuLapDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieu,
            this.soLuong,
            this.tinhTrang,
            this.ngayLap,
            this.maTienNghi,
            this.maPhong,
            this.maNV});
            this.dgvPhieuLapDat.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvPhieuLapDat.Location = new System.Drawing.Point(12, 98);
            this.dgvPhieuLapDat.Name = "dgvPhieuLapDat";
            this.dgvPhieuLapDat.ReadOnly = true;
            this.dgvPhieuLapDat.RowHeadersWidth = 51;
            this.dgvPhieuLapDat.RowTemplate.Height = 24;
            this.dgvPhieuLapDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuLapDat.Size = new System.Drawing.Size(589, 439);
            this.dgvPhieuLapDat.TabIndex = 0;
            this.dgvPhieuLapDat.SelectionChanged += new System.EventHandler(this.dgvPhieuLapDat_SelectionChanged);
            // 
            // maPhieu
            // 
            this.maPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhieu.HeaderText = "Mã phiếu";
            this.maPhieu.MinimumWidth = 6;
            this.maPhieu.Name = "maPhieu";
            this.maPhieu.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // tinhTrang
            // 
            this.tinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhTrang.HeaderText = "Tình trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            // 
            // ngayLap
            // 
            this.ngayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayLap.HeaderText = "Ngày Lặp";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.ReadOnly = true;
            // 
            // maTienNghi
            // 
            this.maTienNghi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maTienNghi.HeaderText = "Mã tiện nghi";
            this.maTienNghi.MinimumWidth = 6;
            this.maTienNghi.Name = "maTienNghi";
            this.maTienNghi.ReadOnly = true;
            this.maTienNghi.Width = 107;
            // 
            // maPhong
            // 
            this.maPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhong.HeaderText = "Mã phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            this.maPhong.ReadOnly = true;
            // 
            // maNV
            // 
            this.maNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNV.HeaderText = "Mã NV";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpNgayLap);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTinhTrang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbMaTN);
            this.groupBox2.Controls.Add(this.cmbMaPhong);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.txtMaPhieuLD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(607, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 450);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
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
            this.btnThem.Location = new System.Drawing.Point(76, 386);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(95, 47);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "THÔNG TIN PHIẾU LẮP ĐẶT";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(197, 219);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(212, 27);
            this.dtpNgayLap.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(51, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ngày LĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(194, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "_______________________";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtTinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTinhTrang.Location = new System.Drawing.Point(196, 164);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(213, 23);
            this.txtTinhTrang.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(52, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tình trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(192, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "_______________________";
            // 
            // cmbMaTN
            // 
            this.cmbMaTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cmbMaTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMaTN.FormattingEnabled = true;
            this.cmbMaTN.Location = new System.Drawing.Point(196, 270);
            this.cmbMaTN.Name = "cmbMaTN";
            this.cmbMaTN.Size = new System.Drawing.Size(213, 33);
            this.cmbMaTN.TabIndex = 34;
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cmbMaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(196, 324);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(213, 33);
            this.cmbMaPhong.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(192, 332);
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
            this.label10.Location = new System.Drawing.Point(52, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mã phòng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSoLuong.Location = new System.Drawing.Point(195, 115);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(213, 23);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã TN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(51, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(52, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã phiếu LĐ";
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
            this.btnXoa.Location = new System.Drawing.Point(313, 386);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Rotation = 0D;
            this.btnXoa.Size = new System.Drawing.Size(96, 47);
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
            this.btnSua.Location = new System.Drawing.Point(194, 386);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(95, 47);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaPhieuLD
            // 
            this.txtMaPhieuLD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtMaPhieuLD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuLD.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMaPhieuLD.Location = new System.Drawing.Point(196, 64);
            this.txtMaPhieuLD.Name = "txtMaPhieuLD";
            this.txtMaPhieuLD.Size = new System.Drawing.Size(213, 23);
            this.txtMaPhieuLD.TabIndex = 1;
            this.txtMaPhieuLD.TextChanged += new System.EventHandler(this.txtMaPhieuLD_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(192, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "_______________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(191, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "_______________________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(12, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(351, 50);
            this.label18.TabIndex = 39;
            this.label18.Text = "PHIẾU LẮP ĐẶT";
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
            this.btnExit.Location = new System.Drawing.Point(1020, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(48, 32);
            this.btnExit.TabIndex = 40;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPhieuLapDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1071, 549);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPhieuLapDat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuLapDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuLapDat";
            this.Load += new System.EventHandler(this.frmPhieuLapDat_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPhieuLapDat_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuLapDat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuLapDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTienNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMaTN;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.TextBox txtMaPhieuLD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnThem;
    }
}
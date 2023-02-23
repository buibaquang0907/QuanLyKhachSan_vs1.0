namespace QuanLyKhachSanDemo
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.linkLabelQuenMatKhai = new System.Windows.Forms.LinkLabel();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconTenDangNhap = new FontAwesome.Sharp.IconButton();
            this.icoMatKhau = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 370);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyKhachSanDemo.Properties.Resources.Lotus_luxury_logo_template__removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 214);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.IndianRed;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(494, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(48, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDown.IconColor = System.Drawing.Color.White;
            this.btnDown.IconSize = 30;
            this.btnDown.Location = new System.Drawing.Point(450, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Rotation = 0D;
            this.btnDown.Size = new System.Drawing.Size(48, 32);
            this.btnDown.TabIndex = 7;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelTop.Controls.Add(this.lblLogin);
            this.panelTop.Controls.Add(this.btnDown);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(218, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(544, 87);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLogin.Location = new System.Drawing.Point(184, 37);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(196, 40);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "ĐĂNG NHẬP";
            // 
            // linkLabelQuenMatKhai
            // 
            this.linkLabelQuenMatKhai.AutoSize = true;
            this.linkLabelQuenMatKhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelQuenMatKhai.Location = new System.Drawing.Point(425, 319);
            this.linkLabelQuenMatKhai.Name = "linkLabelQuenMatKhai";
            this.linkLabelQuenMatKhai.Size = new System.Drawing.Size(125, 16);
            this.linkLabelQuenMatKhai.TabIndex = 9;
            this.linkLabelQuenMatKhai.TabStop = true;
            this.linkLabelQuenMatKhai.Text = "QUÊN MẬT KHẨU?";
            this.linkLabelQuenMatKhai.Click += new System.EventHandler(this.linkLabelQuenMatKhai_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(409, 129);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(252, 31);
            this.txtTenDangNhap.TabIndex = 2;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhau.Location = new System.Drawing.Point(409, 187);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(168, 31);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDangNhap.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDangNhap.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDangNhap.IconSize = 16;
            this.btnDangNhap.Location = new System.Drawing.Point(315, 246);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Rotation = 0D;
            this.btnDangNhap.Size = new System.Drawing.Size(346, 58);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(364, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "____________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(364, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "____________________________________";
            // 
            // iconTenDangNhap
            // 
            this.iconTenDangNhap.Enabled = false;
            this.iconTenDangNhap.FlatAppearance.BorderSize = 0;
            this.iconTenDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTenDangNhap.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconTenDangNhap.IconChar = FontAwesome.Sharp.IconChar.Snowman;
            this.iconTenDangNhap.IconColor = System.Drawing.Color.DimGray;
            this.iconTenDangNhap.IconSize = 40;
            this.iconTenDangNhap.Location = new System.Drawing.Point(355, 129);
            this.iconTenDangNhap.Name = "iconTenDangNhap";
            this.iconTenDangNhap.Rotation = 0D;
            this.iconTenDangNhap.Size = new System.Drawing.Size(48, 36);
            this.iconTenDangNhap.TabIndex = 12;
            this.iconTenDangNhap.UseVisualStyleBackColor = true;
            // 
            // icoMatKhau
            // 
            this.icoMatKhau.Enabled = false;
            this.icoMatKhau.FlatAppearance.BorderSize = 0;
            this.icoMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoMatKhau.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoMatKhau.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.icoMatKhau.IconColor = System.Drawing.Color.DimGray;
            this.icoMatKhau.IconSize = 35;
            this.icoMatKhau.Location = new System.Drawing.Point(355, 190);
            this.icoMatKhau.Name = "icoMatKhau";
            this.icoMatKhau.Rotation = 0D;
            this.icoMatKhau.Size = new System.Drawing.Size(48, 36);
            this.icoMatKhau.TabIndex = 13;
            this.icoMatKhau.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton1.IconColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(613, 187);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(48, 39);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(762, 370);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.icoMatKhau);
            this.Controls.Add(this.iconTenDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.linkLabelQuenMatKhai);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "drmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDangNhap_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnDown;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.LinkLabel linkLabelQuenMatKhai;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private FontAwesome.Sharp.IconButton btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconTenDangNhap;
        private FontAwesome.Sharp.IconButton icoMatKhau;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
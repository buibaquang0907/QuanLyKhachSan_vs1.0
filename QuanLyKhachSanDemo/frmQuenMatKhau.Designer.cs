namespace QuanLyKhachSanDemo
{
    partial class frmQuenMatKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.icoMatKhau = new FontAwesome.Sharp.IconButton();
            this.iconTenDangNhap = new FontAwesome.Sharp.IconButton();
            this.btnDangNhap = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 15;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelTop.Controls.Add(this.lblLogin);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Location = new System.Drawing.Point(218, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(544, 87);
            this.panelTop.TabIndex = 16;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLogin.Location = new System.Drawing.Point(114, 24);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(270, 40);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "QUÊN MẬT KHẨU";
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.Color.DimGray;
            this.txtCCCD.Location = new System.Drawing.Point(381, 196);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(252, 29);
            this.txtCCCD.TabIndex = 18;
            this.txtCCCD.Text = "Căn Cước Công Dân";
            this.txtCCCD.Enter += new System.EventHandler(this.txtCCCD_Enter);
            this.txtCCCD.Leave += new System.EventHandler(this.txtCCCD_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(336, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "____________________________________";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(381, 138);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(252, 31);
            this.txtTenDangNhap.TabIndex = 17;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(336, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "____________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyKhachSanDemo.Properties.Resources.Lotus_luxury_logo_template__removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 237);
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
            // icoMatKhau
            // 
            this.icoMatKhau.Enabled = false;
            this.icoMatKhau.FlatAppearance.BorderSize = 0;
            this.icoMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoMatKhau.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoMatKhau.IconChar = FontAwesome.Sharp.IconChar.List;
            this.icoMatKhau.IconColor = System.Drawing.Color.DimGray;
            this.icoMatKhau.IconSize = 35;
            this.icoMatKhau.Location = new System.Drawing.Point(327, 199);
            this.icoMatKhau.Name = "icoMatKhau";
            this.icoMatKhau.Rotation = 0D;
            this.icoMatKhau.Size = new System.Drawing.Size(48, 36);
            this.icoMatKhau.TabIndex = 24;
            this.icoMatKhau.UseVisualStyleBackColor = true;
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
            this.iconTenDangNhap.Location = new System.Drawing.Point(327, 138);
            this.iconTenDangNhap.Name = "iconTenDangNhap";
            this.iconTenDangNhap.Rotation = 0D;
            this.iconTenDangNhap.Size = new System.Drawing.Size(48, 36);
            this.iconTenDangNhap.TabIndex = 23;
            this.iconTenDangNhap.UseVisualStyleBackColor = true;
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
            this.btnDangNhap.Location = new System.Drawing.Point(327, 271);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Rotation = 0D;
            this.btnDangNhap.Size = new System.Drawing.Size(346, 58);
            this.btnDangNhap.TabIndex = 19;
            this.btnDangNhap.Text = "XÁC NHẬN";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(762, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.icoMatKhau);
            this.Controls.Add(this.iconTenDangNhap);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuenMatKhau";
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblLogin;
        private FontAwesome.Sharp.IconButton icoMatKhau;
        private FontAwesome.Sharp.IconButton iconTenDangNhap;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDangNhap;
    }
}
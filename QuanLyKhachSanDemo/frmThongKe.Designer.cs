namespace QuanLyKhachSanDemo
{
    partial class frmThongKe
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemBC = new System.Windows.Forms.Button();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpKhoang2 = new System.Windows.Forms.DateTimePicker();
            this.dtpKhoang1 = new System.Windows.Forms.DateTimePicker();
            this.rdoKhoangTime = new System.Windows.Forms.RadioButton();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Gray;
            this.reportViewer1.Location = new System.Drawing.Point(12, 255);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1058, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnXemBC);
            this.groupBox1.Controls.Add(this.dtpThang);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpKhoang2);
            this.groupBox1.Controls.Add(this.dtpKhoang1);
            this.groupBox1.Controls.Add(this.rdoKhoangTime);
            this.groupBox1.Controls.Add(this.rdoThang);
            this.groupBox1.Controls.Add(this.rdoNgay);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(164, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "BÁO CÁO DOANH THU KHÁCH SẠN ";
            // 
            // btnXemBC
            // 
            this.btnXemBC.Location = new System.Drawing.Point(645, 204);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(154, 34);
            this.btnXemBC.TabIndex = 8;
            this.btnXemBC.Text = "Xem Bao Cao";
            this.btnXemBC.UseVisualStyleBackColor = true;
            this.btnXemBC.Click += new System.EventHandler(this.btnXemBC_Click);
            // 
            // dtpThang
            // 
            this.dtpThang.Location = new System.Drawing.Point(246, 123);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(200, 22);
            this.dtpThang.TabIndex = 7;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(246, 85);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpNgay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(469, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đến";
            // 
            // dtpKhoang2
            // 
            this.dtpKhoang2.Location = new System.Drawing.Point(519, 159);
            this.dtpKhoang2.Name = "dtpKhoang2";
            this.dtpKhoang2.Size = new System.Drawing.Size(200, 22);
            this.dtpKhoang2.TabIndex = 4;
            // 
            // dtpKhoang1
            // 
            this.dtpKhoang1.Location = new System.Drawing.Point(246, 158);
            this.dtpKhoang1.Name = "dtpKhoang1";
            this.dtpKhoang1.Size = new System.Drawing.Size(200, 22);
            this.dtpKhoang1.TabIndex = 3;
            // 
            // rdoKhoangTime
            // 
            this.rdoKhoangTime.AutoSize = true;
            this.rdoKhoangTime.ForeColor = System.Drawing.Color.LightGray;
            this.rdoKhoangTime.Location = new System.Drawing.Point(45, 161);
            this.rdoKhoangTime.Name = "rdoKhoangTime";
            this.rdoKhoangTime.Size = new System.Drawing.Size(195, 20);
            this.rdoKhoangTime.TabIndex = 2;
            this.rdoKhoangTime.Text = "Xem Báo Cáo Theo Khoảng";
            this.rdoKhoangTime.UseVisualStyleBackColor = true;
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.ForeColor = System.Drawing.Color.LightGray;
            this.rdoThang.Location = new System.Drawing.Point(45, 123);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(188, 20);
            this.rdoThang.TabIndex = 1;
            this.rdoThang.Text = "Xem Báo Cáo Theo Tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Checked = true;
            this.rdoNgay.ForeColor = System.Drawing.Color.LightGray;
            this.rdoNgay.Location = new System.Drawing.Point(45, 85);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(182, 20);
            this.rdoNgay.TabIndex = 0;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Text = "Xem Báo Cáo Theo Ngày";
            this.rdoNgay.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyKhachSanDemo.Properties.Resources.Lotus_luxury_logo_template__removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(823, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 244);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmThongKe";
            this.Text = " BÁO CÁO THỐNG KÊ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpKhoang2;
        private System.Windows.Forms.DateTimePicker dtpKhoang1;
        private System.Windows.Forms.RadioButton rdoKhoangTime;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnXemBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
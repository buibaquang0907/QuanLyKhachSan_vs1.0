using BUS;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QuanLyKhachSanDemo
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor= Color.LightGray;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.DimGray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.LightGray;
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.DimGray;
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text != null && txtMatKhau.Text != null && txtTenDangNhap.Text != "Tên đăng nhập" && txtMatKhau.Text != "Mật khẩu")
                {
                    switch (BUS.KiemTraDangNhapBUS.KiemTraThongTinTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text))
                    {
                        case "thanhcong":
                            MessageBox.Show("Đăng nhập thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 frmMain = new Form1();
                            frmMain.taiKhoanHienHanhFrmMain = txtTenDangNhap.Text;
                            frmMain.Show();
                            this.Hide();
                            return;
                        case "saimatkhau":
                            MessageBox.Show("Sai mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        case "saitendangnhap":
                            MessageBox.Show("Sai tên đăng nhập", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.UseSystemPasswordChar == false)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
            this.KeyPreview = true;
            this.KeyDown += FrmDangNhap_KeyDown;
        }

        private void FrmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void linkLabelQuenMatKhai_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau frmQuenMatKhau = new frmQuenMatKhau();
            frmQuenMatKhau.ShowDialog();
        }
    }
}

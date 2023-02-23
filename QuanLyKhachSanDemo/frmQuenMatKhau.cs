using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanDemo
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text != "" && txtCCCD.Text != "" && txtTenDangNhap.Text != "Tên đăng nhập" && txtCCCD.Text != "Căn Cước Công Dân")
                {
                    NhanVienDTO nhanVien = BUS.QuenMatKhauBUS.XacNhanMatKhau(txtTenDangNhap.Text);
                    if(nhanVien != null)
                    {
                        if (nhanVien.CCCD.ToString().Contains(txtCCCD.Text))
                        {
                            List<TaiKhoanDTO> listTaiKhoan = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
                            TaiKhoanDTO taiKhoan = listTaiKhoan.FirstOrDefault(p => p.MANHANVIEN == nhanVien.MANHANVIEN);

                            if (taiKhoan != null)
                            {
                                MessageBox.Show("MẬT KHẨU CỦA BẠN LÀ: " + taiKhoan.MATKHAU,"THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("KHÔNG TÌM THẤY TÀI KHOẢN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("CĂN CƯỚC CÔNG DÂN KHÔNG ĐÚNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("KHÔNG TÌM THẤY TÀI KHOẢN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.LightGray;
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

        private void txtCCCD_Enter(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "Căn Cước Công Dân")
            {
                txtCCCD.Text = "";
                txtCCCD.ForeColor = Color.LightGray;
                txtCCCD.UseSystemPasswordChar = true;
            }
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "")
            {
                txtCCCD.Text = "Căn Cước Công Dân";
                txtCCCD.ForeColor = Color.LightGray;
                txtCCCD.UseSystemPasswordChar = true;
            }
        }
    }
}

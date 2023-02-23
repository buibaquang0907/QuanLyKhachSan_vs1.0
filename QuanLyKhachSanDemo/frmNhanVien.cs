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
using QuanLyKhachSanDemo;
using System.Runtime.Remoting.Contexts;

namespace QuanLyKhachSanDemo
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            hienDSNhanVien();
        }

        public void hienDSNhanVien()
        {
            dgvNhanVien.Rows.Clear();
            List<NhanVienDTO> listNhanVien = BUS.NhanVienBUS.DanhSachNhanVien();
            foreach (var item in listNhanVien)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.MANHANVIEN;
                dgvNhanVien.Rows[index].Cells[1].Value = item.TENNHANVIEN;
                dgvNhanVien.Rows[index].Cells[2].Value = item.NAMSINH;
                dgvNhanVien.Rows[index].Cells[3].Value = item.CCCD;
                dgvNhanVien.Rows[index].Cells[4].Value = item.CHUCVU;
                dgvNhanVien.Rows[index].Cells[5].Value = item.DT;
                dgvNhanVien.Rows[index].Cells[6].Value = item.DIACHI;
            }
        }

        private void txtTimNhanVien_TextChanged(object sender, EventArgs e)
        {
            List<NhanVienDTO> listNhanVien = BUS.NhanVienBUS.DanhSachNhanVien();
            dgvNhanVien.Rows.Clear();
            foreach (NhanVienDTO item in listNhanVien)
            {
                if (txtTimNhanVien.Text.Length == 11)
                {
                    MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else if (item.CCCD.ToString().Contains(txtTimNhanVien.Text))
                {
                    int index = dgvNhanVien.Rows.Add();
                    dgvNhanVien.Rows[index].Cells[0].Value = item.MANHANVIEN;
                    dgvNhanVien.Rows[index].Cells[1].Value = item.TENNHANVIEN;
                    dgvNhanVien.Rows[index].Cells[2].Value = item.NAMSINH;
                    dgvNhanVien.Rows[index].Cells[3].Value = item.CCCD;
                    dgvNhanVien.Rows[index].Cells[4].Value = item.CHUCVU;
                    dgvNhanVien.Rows[index].Cells[5].Value = item.DT;
                    dgvNhanVien.Rows[index].Cells[5].Value = item.DIACHI;
                }
            }
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells[0].Value);
                txtTenNV.Text = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells[1].Value);
                txtNamSinh.Text = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells[2].Value);
                txtCCCD.Text = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells[3].Value);
                txtChucVu.Text = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells[4].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells[6].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.SelectedRows[0].Cells[5].Value);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" && txtCCCD.Text != "" && txtChucVu.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtNamSinh.Text != "")
            {
                if (txtSDT.Text.Length >= 10)
                {
                    NhanVienDTO new_NhanVien = new NhanVienDTO()
                    {
                        TENNHANVIEN = txtTenNV.Text,
                        CCCD = Convert.ToInt64(txtCCCD.Text),
                        DIACHI = txtDiaChi.Text,
                        CHUCVU = txtChucVu.Text,
                        DT = txtSDT.Text,
                        NAMSINH = short.Parse(txtNamSinh.Text),
                    };
                    string ketQua = BUS.NhanVienBUS.themNhanVien(new_NhanVien);

                    if (ketQua == "themthanhcong")
                    {
                        MessageBox.Show("THÊM NHÂN VIÊN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienDSNhanVien();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                }
                else
                {
                    MessageBox.Show("ĐỊNH DẠNG SỐ ĐIỆN THOẠI KHÔNG ĐÚNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<NhanVienDTO> listNV = BUS.NhanVienBUS.DanhSachNhanVien();
            if (txtCCCD.Text != "")
            {
                NhanVienDTO nhanVien_Delete = listNV.FirstOrDefault(p => p.CCCD == Convert.ToInt64(txtCCCD.Text));

                if (nhanVien_Delete != null)
                {
                    DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.NhanVienBUS.xoaNhanVien(nhanVien_Delete);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienDSNhanVien();
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY NHÂN VIÊN!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ CCCD KHÁCH HÀNG CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtCCCD.Text != "" && txtChucVu.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtNamSinh.Text != "")
            {
                NhanVienDTO new_NhanVien = new NhanVienDTO()
                {
                    MANHANVIEN = int.Parse(txtMaNV.Text),
                    TENNHANVIEN = txtTenNV.Text,
                    CCCD = Convert.ToInt64(txtCCCD.Text),
                    DIACHI = txtDiaChi.Text,
                    CHUCVU = txtChucVu.Text,
                    DT = txtSDT.Text,
                    NAMSINH = short.Parse(txtNamSinh.Text),
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN NHÂN VIÊN?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.NhanVienBUS.suaNhanVien(new_NhanVien);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN NHÂN VIÊN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienDSNhanVien();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN NHÂN VIÊN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaNV.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtNamSinh.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtCCCD.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSDT.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


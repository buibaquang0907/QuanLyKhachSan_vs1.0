using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanDemo
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiDSQuyen();
            HienThiDSTaiKhoan();

            List<NhanVienDTO> listNhanVien = BUS.NhanVienBUS.DanhSachNhanVien();

            cmbMaNV.Items.Clear();
            cmbMaNV.DataSource = listNhanVien;
            cmbMaNV.DisplayMember = "MANHANVIEN";

            List<PhanQuyenDTO> listPhanQuyen = BUS.TaiKhoanBUS.DanhSachQuyen();

            cmbMaQuyen.Items.Clear();
            cmbMaQuyen.DataSource = listPhanQuyen;
            cmbMaQuyen.DisplayMember = "MAPHANQUYEN";

            txtMatKhau.MaxLength = 8;
        }


        public void HienThiDSQuyen()
        {
            dgvPhanQuyen.Rows.Clear();
            List<PhanQuyenDTO> listPhanQuyen = BUS.TaiKhoanBUS.DanhSachQuyen();
            foreach (var item in listPhanQuyen)
            {
                int index = dgvPhanQuyen.Rows.Add();
                dgvPhanQuyen.Rows[index].Cells[0].Value = item.MAPHANQUYEN;
                dgvPhanQuyen.Rows[index].Cells[1].Value = item.TENPHANQUYEN;
                dgvPhanQuyen.Rows[index].Cells[2].Value = item.QUYENHAN;
            }
        }

        public void HienThiDSTaiKhoan()
        {
            dgvTaiKhoan.Rows.Clear();
            List<TaiKhoanDTO> listTaiKhoan = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            foreach (var item in listTaiKhoan)
            {
                int index = dgvTaiKhoan.Rows.Add();
                dgvTaiKhoan.Rows[index].Cells[0].Value = item.TENDANGNHAP;
                dgvTaiKhoan.Rows[index].Cells[1].Value = item.MATKHAU;
                dgvTaiKhoan.Rows[index].Cells[2].Value = item.MANHANVIEN;
                dgvTaiKhoan.Rows[index].Cells[3].Value = item.MAPHANQUYEN;
            }
        }

        private void dgvPhanQuyen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhanQuyen.SelectedRows.Count > 0)
            {
                txtMaQuyen.Text = Convert.ToString(dgvPhanQuyen.SelectedRows[0].Cells[0].Value);
                txtTenQuyen.Text = Convert.ToString(dgvPhanQuyen.SelectedRows[0].Cells[1].Value);
                txtQuyenHan.Text = Convert.ToString(dgvPhanQuyen.SelectedRows[0].Cells[2].Value);
            }
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                txtTenDangNhap.Text = Convert.ToString(dgvTaiKhoan.SelectedRows[0].Cells[0].Value);
                txtMatKhau.Text = Convert.ToString(dgvTaiKhoan.SelectedRows[0].Cells[1].Value);
                cmbMaNV.Text = Convert.ToString(dgvTaiKhoan.SelectedRows[0].Cells[2].Value);
                cmbMaQuyen.Text = Convert.ToString(dgvTaiKhoan.SelectedRows[0].Cells[3].Value);
            }
        }

        private void btnThemQuyen_Click(object sender, EventArgs e)
        {
            if (txtTenQuyen.Text != "" && txtQuyenHan.Text != "")
            {
                PhanQuyenDTO new_Quyen = new PhanQuyenDTO()
                {
                    TENPHANQUYEN = txtTenQuyen.Text,
                    QUYENHAN = txtQuyenHan.Text,
                };
                string ketQua = BUS.TaiKhoanBUS.themPhanQuyenBUS(new_Quyen);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM PHÂN QUYỀN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSQuyen();
                    HienThiDSTaiKhoan();

                    List<PhanQuyenDTO> listPhanQuyen = BUS.TaiKhoanBUS.DanhSachQuyen();

                   
                    cmbMaQuyen.DataSource = listPhanQuyen;
                    cmbMaQuyen.DisplayMember = "MAPHANQUYEN";
                }
                else
                {
                    MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaQuyen_Click(object sender, EventArgs e)
        {
            if (txtMaQuyen.Text != "" && txtTenQuyen.Text != "" && txtQuyenHan.Text != "")
            {
                PhanQuyenDTO new_PQ = new PhanQuyenDTO()
                {
                    MAPHANQUYEN = int.Parse(txtMaQuyen.Text),
                    TENPHANQUYEN = txtTenQuyen.Text,
                    QUYENHAN = txtQuyenHan.Text,
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN PHÂN QUYỀN?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.TaiKhoanBUS.suaPhanQuyenBUS(new_PQ);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN PHÂN QUYỀN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSQuyen();
                        HienThiDSTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN PHÂN QUYỀN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaLoaiQuyen_Click(object sender, EventArgs e)
        {
            List<PhanQuyenDTO> listPQ = BUS.TaiKhoanBUS.DanhSachQuyen();
            if (txtMaQuyen.Text != "")
            {
                PhanQuyenDTO PQ_Delete = listPQ.FirstOrDefault(p => p.MAPHANQUYEN == Convert.ToInt64(txtMaQuyen.Text));

                if (PQ_Delete != null)
                {
                    DialogResult re = MessageBox.Show("Nếu xoá, toàn bộ tài khoản có quyền này sẽ bị xóa, Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.TaiKhoanBUS.xoaPhanQuyenBUS(PQ_Delete);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA PHÂN QUYỀN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiDSQuyen();
                            HienThiDSTaiKhoan();

                            List<PhanQuyenDTO> listPhanQuyen = BUS.TaiKhoanBUS.DanhSachQuyen();

                            cmbMaQuyen.DataSource = listPhanQuyen;
                            cmbMaQuyen.DisplayMember = "MAPHANQUYEN";
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY PHÂN QUYỀN!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ PHÂN QUYỀN CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "")
            {
                if (txtMatKhau.Text.Length >=6)
                {
                    if (txtMatKhau.Text == txtXacNhan.Text)
                    {
                        TaiKhoanDTO new_TK = new TaiKhoanDTO()
                        {
                            TENDANGNHAP = txtTenDangNhap.Text,
                            MATKHAU = txtMatKhau.Text,
                            MANHANVIEN = int.Parse(cmbMaNV.Text),
                            MAPHANQUYEN = int.Parse(cmbMaQuyen.Text),
                        };
                        string ketQua = BUS.TaiKhoanBUS.themTaiKhoanBUS(new_TK);

                        if (ketQua == "themthanhcong")
                        {
                            MessageBox.Show("THÊM TÀI KHOẢN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiDSTaiKhoan();
                            HienThiDSQuyen();

                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("MẬT KHẨU XÁC NHẬN CHƯA CHÍNH XÁC", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                }
                else
                {
                    MessageBox.Show("MẬT KHẨU PHẢI CÓ ĐỘ DÀI LỚN HƠN 6 KÍ TỰ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "")
            {
                if (txtMatKhau.Text == txtXacNhan.Text)
                {
                    TaiKhoanDTO new_TK = new TaiKhoanDTO()
                    {
                        TENDANGNHAP = txtTenDangNhap.Text,
                        MAPHANQUYEN = int.Parse(cmbMaQuyen.Text),
                        MANHANVIEN = int.Parse(cmbMaNV.Text),
                        MATKHAU = txtMatKhau.Text,
                    };

                    DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN TÀI KHOẢN?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.TaiKhoanBUS.suaTaiKhoanBUS(new_TK);

                        if (ketQua == "suathanhcong")
                        {
                            MessageBox.Show("SỬA THÔNG TIN TÀI KHOẢN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiDSTaiKhoan();
                            HienThiDSQuyen();

                        }
                        else if (ketQua == "nhanviendacotaikhoan")
                        {
                            MessageBox.Show("NHÂN VIÊN ĐÃ CÓ TÀI KHOẢN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("MẬT KHẨU XÁC NHẬN CHƯA CHÍNH XÁC", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP TÊN ĐĂNG NHẬP TÀI KHOẢN CẦN SỬA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTK = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            if (txtTenDangNhap.Text != "")
            {
                TaiKhoanDTO TK_Delete = listTK.FirstOrDefault(p => p.TENDANGNHAP == txtTenDangNhap.Text);

                if (TK_Delete != null)
                {
                    DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.TaiKhoanBUS.xoaTaiKhoanBUS(TK_Delete);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA TÀI KHOẢN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiDSTaiKhoan();
                            HienThiDSQuyen();

                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY TÀI KHOẢN!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP TÊN ĐĂNG NHẬP CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaQuyenTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<PhanQuyenDTO> listPhanQuyen = BUS.TaiKhoanBUS.DanhSachQuyen();
            dgvPhanQuyen.Rows.Clear();

            List<TaiKhoanDTO> listTaiKhoan = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            dgvTaiKhoan.Rows.Clear();
            foreach (PhanQuyenDTO item in listPhanQuyen)
            {
                if (item.TENPHANQUYEN.ToString().ToUpper().Contains(txtMaQuyenTimKiem.Text.ToUpper()))
                {
                    int index = dgvPhanQuyen.Rows.Add();
                    dgvPhanQuyen.Rows[index].Cells[0].Value = item.MAPHANQUYEN;
                    dgvPhanQuyen.Rows[index].Cells[1].Value = item.TENPHANQUYEN;
                    dgvPhanQuyen.Rows[index].Cells[2].Value = item.QUYENHAN;

                    foreach (TaiKhoanDTO i in listTaiKhoan)
                    {
                        if (i.MAPHANQUYEN.ToString().Contains(item.MAPHANQUYEN.ToString()))
                        {
                            int indexs = dgvTaiKhoan.Rows.Add();
                            dgvTaiKhoan.Rows[indexs].Cells[0].Value = i.TENDANGNHAP;
                            dgvTaiKhoan.Rows[indexs].Cells[1].Value = i.MATKHAU;
                            dgvTaiKhoan.Rows[indexs].Cells[2].Value = i.MANHANVIEN;
                            dgvTaiKhoan.Rows[indexs].Cells[3].Value = i.MAPHANQUYEN;
                        }
                    }
                }
            }
        }

        private void txtTenDNTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoan = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            dgvTaiKhoan.Rows.Clear();

            foreach (TaiKhoanDTO i in listTaiKhoan)
            {
                if (i.TENDANGNHAP.ToString().ToUpper().Contains(txtTenDNTimKiem.Text.ToUpper()))
                {
                    int index = dgvTaiKhoan.Rows.Add();
                    dgvTaiKhoan.Rows[index].Cells[0].Value = i.TENDANGNHAP;
                    dgvTaiKhoan.Rows[index].Cells[1].Value = i.MATKHAU;
                    dgvTaiKhoan.Rows[index].Cells[2].Value = i.MANHANVIEN;
                    dgvTaiKhoan.Rows[index].Cells[3].Value = i.MAPHANQUYEN;
                }
            }

        }

        private void txtMaNVTimKiem_TextChanged(object sender, EventArgs e)
        {

            List<TaiKhoanDTO> listTaiKhoan = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            dgvTaiKhoan.Rows.Clear();

            foreach (TaiKhoanDTO i in listTaiKhoan)
            {
                if (i.MANHANVIEN.ToString().Contains(txtMaNVTimKiem.Text))
                {
                    int index = dgvTaiKhoan.Rows.Add();
                    dgvTaiKhoan.Rows[index].Cells[0].Value = i.TENDANGNHAP;
                    dgvTaiKhoan.Rows[index].Cells[1].Value = i.MATKHAU;
                    dgvTaiKhoan.Rows[index].Cells[2].Value = i.MANHANVIEN;
                    dgvTaiKhoan.Rows[index].Cells[3].Value = i.MAPHANQUYEN;
                }
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtMaQuyen_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaQuyen.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool kiemTraMatKhauDauVao(string matKhau, out string ketQua)
        {
            var input = matKhau;
            ketQua = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{6,8}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ketQua = "Mật khẩu phải có một kí tự chữ cái thường";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ketQua = "Mật khẩu phải có một kí tự chữ cái hoa";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ketQua = "Mật khẩu phải có ít nhất 8 kí tự đến 15 kí tự";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ketQua = "Mật khẩu phải có một kí tự số";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ketQua = "Mật khẩu phải có một kí tự đặc biệt";
                return false;
            }
            else
            {
                return true;
            }
        }


        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            string ketQua;
            if(txtMatKhau.Text.Length >= 6 && txtMatKhau.Text.Length <= 8)
            {
                if(kiemTraMatKhauDauVao(txtMatKhau.Text, out ketQua) == false)
                {
                    MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (txtMatKhau.Text.Length > 8)
            {
                MessageBox.Show("ĐÃ ĐỘ DÀI TỐI ĐA 8 KÍ TỰ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

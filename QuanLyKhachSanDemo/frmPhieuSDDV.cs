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
    public partial class frmPhieuSDDV : Form
    {

        public string taiKhoanHienHanh;
        public frmPhieuSDDV()
        {
            InitializeComponent();
        }

        private void frmPhieuSDDV_Load(object sender, EventArgs e)
        {
            hienThiDanhSachPhieuSDDV();
            hienThiComboBox();

        }

        private void hienThiComboBox()
        {
            List<DichVuDTO> listDichVu = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();

            if(listDichVu.Count() != 0)
            {
                cmbDichVu.DataSource = listDichVu;
                cmbDichVu.DisplayMember = "TENDICHVU";
                cmbDichVu.SelectedIndex = 0;
            }
            else
            {
                cmbDichVu.Text = "Không tìm thấy Dịch Vụ";
            }
        }

        public void hienThiDanhSachPhieuSDDV()
        {
            dgvPhieuSDDV.Rows.Clear();
            List<PhieuSDDVDTO> listPhieuSDDV = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();
            foreach (var item in listPhieuSDDV)
            {
                int index = dgvPhieuSDDV.Rows.Add();
                dgvPhieuSDDV.Rows[index].Cells[0].Value = item.MAPHIEUSDDV;
                dgvPhieuSDDV.Rows[index].Cells[1].Value = item.NGAYSUDUNG;
                dgvPhieuSDDV.Rows[index].Cells[2].Value = item.SOLUONG;
                dgvPhieuSDDV.Rows[index].Cells[3].Value = item.MANHANVIEN;
                dgvPhieuSDDV.Rows[index].Cells[4].Value = item.MAPHIEUDATPHONG;
                dgvPhieuSDDV.Rows[index].Cells[5].Value = item.MAPHIEUCHUYENPHONG;
                dgvPhieuSDDV.Rows[index].Cells[6].Value = item.MADICHVU;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbThemSDDV_Click(object sender, EventArgs e)
        {
            string stringngayLap = dtpNgaySDDV.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayLap = DateTime.Parse(stringngayLap);

            if (txtSoLuong.Text != "")
            {
                if (cmbDichVu.Text != "")
                {
                    List<DichVuDTO> listDichVu = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();

                    DichVuDTO dichVu_Them = listDichVu.Where(p => p.TENDICHVU == cmbDichVu.Text).FirstOrDefault();

                    PhieuSDDVDTO phieuSDDV = new PhieuSDDVDTO();

                    NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanh);

                    phieuSDDV.SOLUONG = int.Parse(txtSoLuong.Text);
                    phieuSDDV.MANHANVIEN = nhanVienDangNhap.MANHANVIEN;
                    phieuSDDV.NGAYSUDUNG = datatimeNgayLap;
                    phieuSDDV.MADICHVU = Convert.ToInt32(dichVu_Them.MADICHVU);
                    phieuSDDV.MAPHIEUDATPHONG = Convert.ToInt32(cmbMaPhieuDatPhong.Text);
                    if (cmbMaChuyenPhong.Text != "Không tìm thấy" && cmbMaChuyenPhong.Text != "")
                    { 
                        phieuSDDV.MAPHIEUCHUYENPHONG = Convert.ToInt32(cmbMaChuyenPhong.Text);
                    }
                    else
                    {
                        phieuSDDV.MAPHIEUCHUYENPHONG = null;
                    }
                    string ketQua = BUS.PhieuSDDVBUS.themPhieuSDDVBUS(phieuSDDV);

                    if (ketQua == "themthanhcong")
                    {
                        MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    hienThiDanhSachPhieuSDDV();
                }
                else
                {
                    MessageBox.Show("VUI LÒNG CHỌN DỊCH VỤ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaSDDV_Click(object sender, EventArgs e)
        {
            string stringngayLap = dtpNgaySDDV.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayLap = DateTime.Parse(stringngayLap);

            if (txtMaPhieuSDDV.Text != "" && txtSoLuong.Text != "")
            {
                if (cmbDichVu.Text != "")
                {
                    List<DichVuDTO> listDichVu = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();

                    DichVuDTO dichVu_Them = listDichVu.Where(p => p.TENDICHVU == cmbDichVu.Text).FirstOrDefault();
                    PhieuSDDVDTO phieuSDDV = new PhieuSDDVDTO();
                    NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanh);

                    phieuSDDV.MAPHIEUSDDV = int.Parse(txtMaPhieuSDDV.Text);
                    phieuSDDV.SOLUONG = int.Parse(txtSoLuong.Text);
                    phieuSDDV.MANHANVIEN = nhanVienDangNhap.MANHANVIEN;
                    phieuSDDV.NGAYSUDUNG = datatimeNgayLap;
                    phieuSDDV.MAPHIEUDATPHONG = Convert.ToInt32(cmbMaPhieuDatPhong.Text);
                    phieuSDDV.MADICHVU = dichVu_Them.MADICHVU;
                    if (cmbMaChuyenPhong.Text != "Không tìm thấy" && cmbMaChuyenPhong.Text != "")
                    {
                        phieuSDDV.MAPHIEUCHUYENPHONG = Convert.ToInt32(cmbMaChuyenPhong.Text);
                    }
                    else
                    {
                        phieuSDDV.MAPHIEUCHUYENPHONG = null;
                    }

                    DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN PHIẾU LẮP ĐẶT?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.PhieuSDDVBUS.suaPhieuSDDVBUS(phieuSDDV);

                        if (ketQua == "suathanhcong")
                        {
                            MessageBox.Show("SỬA THÔNG TIN PHIẾU LẮP ĐẶT THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        hienThiDanhSachPhieuSDDV();
                    }
                    else
                    {
                        MessageBox.Show("VUI LÒNG CHỌN DỊCH VỤ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    MessageBox.Show("VUI LÒNG CHỌN DỊCH VỤ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool kiemTraPhieuSDDV_phieuKT(int maPhieuSDDV)
        {
            List<PhieuKiemTraDTO> listPhieuKT = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            PhieuKiemTraDTO phieuKT = listPhieuKT.Where(p => p.MAPHIEUSDDV == maPhieuSDDV).FirstOrDefault();
            if (phieuKT != null)
            {
                return false;
            }
            return true;
        }

        private void btnXoaSDDV_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuSDDV.Text != "")
            {
                List<PhieuSDDVDTO> listSDDV = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();

                PhieuSDDVDTO phieuSDDV = listSDDV.FirstOrDefault(p => p.MAPHIEUSDDV == Int32.Parse(txtMaPhieuSDDV.Text));
                if (phieuSDDV != null)
                {
                    if (kiemTraPhieuSDDV_phieuKT(phieuSDDV.MAPHIEUSDDV))
                    {
                        DialogResult re = MessageBox.Show("BẠN MUỐN XÓA PHIẾU SDDV NÀY?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            string ketQua = BUS.PhieuSDDVBUS.xoaPhieuSDDVBUS(phieuSDDV);
                            if (ketQua == "xoathanhcong")
                            {
                                MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                hienThiDanhSachPhieuSDDV();
                            }
                            else
                            {
                                MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("CẦN XÓA PHIẾU KIỂM TRA", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY PHIẾU SDDV", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ PHIẾU CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPhieuSDDV_SelectionChanged(object sender, EventArgs e)
        {
            List<DichVuDTO> listDV = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();
            if (dgvPhieuSDDV.SelectedRows.Count > 0)
            {
                txtMaPhieuSDDV.Text = Convert.ToString(dgvPhieuSDDV.SelectedRows[0].Cells[0].Value);
                txtSoLuong.Text = Convert.ToString(dgvPhieuSDDV.SelectedRows[0].Cells[2].Value);
                dtpNgaySDDV.Text = Convert.ToString(dgvPhieuSDDV.SelectedRows[0].Cells[1].Value);
                cmbMaPhieuDatPhong.Text = Convert.ToString(dgvPhieuSDDV.SelectedRows[0].Cells[4].Value);
                cmbMaChuyenPhong.Text = Convert.ToString(dgvPhieuSDDV.SelectedRows[0].Cells[5].Value);
                DichVuDTO DichVu = listDV.Where(p => p.MADICHVU == Convert.ToInt16(dgvPhieuSDDV.SelectedRows[0].Cells[6].Value)).FirstOrDefault();
                if (DichVu != null)
                {
                    cmbDichVu.Text = DichVu.TENDICHVU;
                }
                else
                {
                    cmbDichVu.Text = "LỖI";
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

        private void txtMaPhieuSDDV_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPhieuSDDV.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSoLuong.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtTimCCCD.Text) == true)
            {
                List<KhachHangDTO> listKH = BUS.KhachHangBUS.DanhSachKhachHang();

                List<KhachHangDTO> listTemp = new List<KhachHangDTO>();
                listTemp.Clear();

                foreach (var item in listKH)
                {
                    if (item.CCCD.ToString().Contains(txtTimCCCD.Text))
                    {
                        listTemp.Add(item);
                    }
                }

                if (listTemp.Count > 0)
                {
                    cmbKH.DataSource = listTemp;
                    cmbKH.DisplayMember = "TENKH";
                }
                else
                {
                    cmbKH.Text = "Không tìm thấy";
                    cmbMaPhieuDatPhong.Text = "Không tìm thấy";
                    cmbMaChuyenPhong.Text = "Không tìm thấy";
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbMaPhieuDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PhieuChuyenPhongDTO> listChuyenPhong = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            List<PhieuChuyenPhongDTO> listTam_ChuyenPhong = new List<PhieuChuyenPhongDTO>();

            if (IsNumber(cmbMaPhieuDatPhong.Text))
            {
                PhieuChuyenPhongDTO phieuChuyen = listChuyenPhong.LastOrDefault(p => p.MAPHIEUDATPHONG == int.Parse(cmbMaPhieuDatPhong.Text));

                if (phieuChuyen != null)
                {
                    foreach (var item in listChuyenPhong)
                    {
                        if (item.MAPHIEUDATPHONG == phieuChuyen.MAPHIEUDATPHONG)
                        {
                            listTam_ChuyenPhong.Add(item);
                        }
                    }
                }
                if (listTam_ChuyenPhong.Count > 0)
                {
                    cmbMaChuyenPhong.DataSource = listTam_ChuyenPhong;
                    cmbMaChuyenPhong.DisplayMember = "MAPHIEUCHUYENPHONG";
                }
                else
                {
                    cmbMaChuyenPhong.Text = "Không tìm thấy";
                }
            }
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<KhachHangDTO> listKH = BUS.KhachHangBUS.DanhSachKhachHang();
            KhachHangDTO khachHang = listKH.FirstOrDefault(p => p.TENKH == cmbKH.Text);
            List<PhieuDatPhongDTO> listPDP = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();

            List<PhieuDatPhongDTO> listTam_PhieuDatPhong = new List<PhieuDatPhongDTO>();
            if (khachHang != null)
            {
                foreach (var item in listPDP)
                {
                    if (item.MAKH == khachHang.MAKH)
                    {
                        listTam_PhieuDatPhong.Add(item);
                    }
                }

                if (listTam_PhieuDatPhong.Count > 0)
                {
                    cmbMaPhieuDatPhong.DataSource = listTam_PhieuDatPhong;
                    cmbMaPhieuDatPhong.DisplayMember = "MAPHIEUDATPHONG";
                }
                else
                {
                    cmbMaPhieuDatPhong.Text = "Không tìm thấy";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

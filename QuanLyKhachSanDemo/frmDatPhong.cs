using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanDemo
{
    public partial class frmDatPhong : Form
    {

        public string taiKhoanHienHanh;
        public long soCCCD = 0;
        public string tenPhong = "";
        private decimal tienCocMacDinh = 50000;
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void datPhong_GiaoDien()
        {
            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();

            if (tenPhong != "")
            {
                PhongDTO phong = listPhong.FirstOrDefault(p => p.TENPHONG.Contains(tenPhong));
                cmbMaPhong.Text = phong.MAPHONG.ToString();
            }
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            hienThiDanhSachPhieuDat();
            danhSachPhongTrong();
            datPhong_GiaoDien();
        }

        private void danhSachPhongTrong()
        {
            List<PhongDTO> listPhongBUS = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            List<PhongDTO> listPhongTrong = new List<PhongDTO>();

            foreach(var phong in listPhongBUS)
            {
                if(phong.TINHTRANG == "Bình thường")
                {
                    listPhongTrong.Add(phong);
                }
            }

            if(listPhongTrong.Count() != 0)
            {
                cmbMaPhong.DataSource = listPhongTrong;
                cmbMaPhong.DisplayMember = "MAPHONG";
            }
        }

        public void hienThiComboBox()
        {
            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            cmbMaPhong.DataSource = listPhong;
            cmbMaPhong.DisplayMember = "MAPHONG";
            cmbMaPhong.Text = "";

            // txtTienCoc
            txtTienCoc.Text = tienCocMacDinh.ToString();
        }

        public void hienThiDanhSachPhieuDat()
        {
            dgvDatPhong.Rows.Clear();
            List<PhieuDatPhongDTO> listPhieuDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            foreach (var item in listPhieuDatPhong)
            {
                int index = dgvDatPhong.Rows.Add();
                dgvDatPhong.Rows[index].Cells[0].Value = item.MAPHIEUDATPHONG;
                dgvDatPhong.Rows[index].Cells[1].Value = item.MAPHONG;
                dgvDatPhong.Rows[index].Cells[2].Value = item.SONGUOI;
                dgvDatPhong.Rows[index].Cells[3].Value = item.NGAYNHANPHONG;
                dgvDatPhong.Rows[index].Cells[4].Value = item.NGAYTRADUKIEN;
                dgvDatPhong.Rows[index].Cells[5].Value = item.TIENCOC;
                dgvDatPhong.Rows[index].Cells[6].Value = item.MAKH;
                dgvDatPhong.Rows[index].Cells[7].Value = item.MANHANVIEN;
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            string stringngayThue = dtpNgayNhan.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayThue = DateTime.Parse(stringngayThue);

            string stringngayTraDuKien = dtpNgayTraDuKien.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayTraDuKien = DateTime.Parse(stringngayTraDuKien);

            NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanh);
            PhieuDatPhongDTO phieuDat = new PhieuDatPhongDTO();
            
            if (txtSoNguoi.Text != "" && txtTienCoc.Text != "")
            {
                if (datatimeNgayThue < datatimeNgayTraDuKien)
                {
                    if (soCCCD != 0)
                    {
                        List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();

                        PhongDTO phong = listPhong.FirstOrDefault(p => Convert.ToInt32(p.MAPHONG) == Convert.ToInt32(cmbMaPhong.Text));

                        if (int.Parse(txtSoNguoi.Text) > 0 && int.Parse(txtSoNguoi.Text) <= phong.SONGUOITOIDA)
                        {
                            List<KhachHangDTO> listKH = BUS.KhachHangBUS.DanhSachKhachHang();
                            KhachHangDTO khachHang = listKH.FirstOrDefault(p => p.CCCD == soCCCD);
                            phieuDat.MAKH = khachHang.MAKH;

                            phieuDat.SONGUOI = Convert.ToInt32(txtSoNguoi.Text);
                            phieuDat.NGAYNHANPHONG = datatimeNgayThue;
                            phieuDat.NGAYTRADUKIEN = datatimeNgayTraDuKien;
                            phieuDat.MAPHONG = Convert.ToInt32(cmbMaPhong.Text);
                            phieuDat.TIENCOC = Convert.ToInt32(txtTienCoc.Text);
                            phieuDat.MANHANVIEN = nhanVienDangNhap.MANHANVIEN;

                            string ketQua = BUS.PhieuDatPhongBUS.themPhieuDatPhongBUS(phieuDat);
                            if (ketQua == "thanhcong")
                            {
                                if (phong != null)
                                {
                                    PhongDTO new_Phong = new PhongDTO()
                                    {
                                        MAPHONG = phong.MAPHONG,
                                        TENPHONG = phong.TENPHONG,
                                        SONGUOITOIDA = phong.SONGUOITOIDA,
                                        TINHTRANG = "Đang được thuê",
                                        MALOAIPHONG = phong.MALOAIPHONG,
                                    };
                                    BUS.PhongvaLoaiPhongBUS.suaPhongBUS(new_Phong);
                                }
                                MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("SỐ NGƯỜI KHÔNG HỢP LỆ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("VUI LÒNG NHẬP THÔNG TIN KHÁCH HÀNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("NGÀY TRẢ PHẢI LỚN HƠN NGÀY ĐẶT", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                hienThiDanhSachPhieuDat();
                hienThiComboBox();
                danhSachPhongTrong();
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private bool kiemTraPhieuDP_phieuCP(int MAPHIEUDATPHONG)
        {
            List<PhieuChuyenPhongDTO> listPhieuCP = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            PhieuChuyenPhongDTO phieuChuyenPhong = listPhieuCP.Where(p => p.MAPHIEUDATPHONG == MAPHIEUDATPHONG).FirstOrDefault();
            if (phieuChuyenPhong != null)
            {
                return false;
            }
            return true;
        }
        private bool kiemTraPhieuDP_phieuSDDV(int MAPHIEUDATPHONG)
        {
            List<PhieuSDDVDTO> listPhieuSDDV = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();
            PhieuSDDVDTO phieuSDDV = listPhieuSDDV.Where(p => p.MAPHIEUDATPHONG == MAPHIEUDATPHONG).FirstOrDefault();
            if (phieuSDDV != null)
            {
                return false;
            }
            return true;
        }

        private bool kiemTraPhieuD_phieuKT(int MAPHIEUDATPHONG)
        {
            List<PhieuKiemTraDTO> listPhieuKT = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            PhieuKiemTraDTO phieuKT = listPhieuKT.Where(p => p.MAPHIEUDATPHONG == MAPHIEUDATPHONG).FirstOrDefault();
            if (phieuKT != null)
            {
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanh);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1)
            {
                List<PhieuDatPhongDTO> listPhieuDat = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
                if (txtMaPDP.Text != "")
                {
                    PhieuDatPhongDTO phieuDat = listPhieuDat.FirstOrDefault(p => p.MAPHIEUDATPHONG == Int32.Parse(txtMaPDP.Text));
                    if(phieuDat != null)
                    {
                        if (kiemTraPhieuDP_phieuCP(phieuDat.MAPHIEUDATPHONG))
                        {
                            if (kiemTraPhieuDP_phieuSDDV(phieuDat.MAPHIEUDATPHONG))
                            {
                                if (kiemTraPhieuD_phieuKT(phieuDat.MAPHIEUDATPHONG))
                                {
                                    List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();

                                    PhongDTO phong = listPhong.FirstOrDefault(p => Convert.ToInt32(p.MAPHONG) == Convert.ToInt32(phieuDat.MAPHONG));

                                    DialogResult re = MessageBox.Show("BẠN CÓ MUỐN XÓA PHIẾU ĐẶT PHÒNG?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (re == DialogResult.Yes)
                                    {
                                        string ketQua = BUS.PhieuDatPhongBUS.xoaPhieuDatPhongBUS(phieuDat);

                                        if (ketQua == "xoathanhcong")
                                        {
                                            MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            hienThiDanhSachPhieuDat();
                                            hienThiComboBox();
                                            danhSachPhongTrong();
                                            if (phong != null)
                                            {
                                                PhongDTO new_Phong = new PhongDTO()
                                                {
                                                    MAPHONG = phong.MAPHONG,
                                                    TENPHONG = phong.TENPHONG,
                                                    SONGUOITOIDA = phong.SONGUOITOIDA,
                                                    TINHTRANG = "Bình thường",
                                                    MALOAIPHONG = phong.MALOAIPHONG,
                                                };
                                                BUS.PhongvaLoaiPhongBUS.suaPhongBUS(new_Phong);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        } 
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("CẦN XÓA PHIẾU KIỂM TRA CỦA PHIẾU ĐẶT PHÒNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("CẦN XÓA PHIẾU SDDV CỦA PHIẾU ĐẶT PHÒNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("CẦN XÓA PHIẾU CHUYỂN PHÒNG CỦA PHIẾU ĐẶT PHÒNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("KHÔNG TÌM THẤY PHIẾU ĐẶT PHÒNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("VUI LÒNG NHẬP MÃ PHIẾU ĐẶT", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            using (frmKhachHang frmKH = new frmKhachHang())
            {
                if (frmKH.ShowDialog() == DialogResult.OK)
                {
                    soCCCD = frmKH.TheValue;
                }
            }

            if (soCCCD == 0)
            {
                MessageBox.Show("VUI LÒNG NHẬP THÔNG TIN KHÁCH HÀNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                List<KhachHangDTO> listKH = BUS.KhachHangBUS.DanhSachKhachHang();
                KhachHangDTO khachHang = listKH.FirstOrDefault(p => p.CCCD == soCCCD);
                txtTenKH.Text = khachHang.TENKH;
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

        private void txtCCCDKH_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtCCCDKH.Text))
            {
                if(txtCCCDKH.Text.Length == 12)
                {
                    List<KhachHangDTO> listKhachHang = BUS.KhachHangBUS.DanhSachKhachHang();
                    KhachHangDTO khachHang = listKhachHang.FirstOrDefault(p => p.CCCD == decimal.Parse(txtCCCDKH.Text));
                    if(khachHang != null)
                    {
                        soCCCD = khachHang.CCCD.GetValueOrDefault(); //getvalueordefautl is return long if true, then is 0
                        txtTenKH.Text = khachHang.TENKH;
                    }
                }
                else
                {
                    soCCCD = 0;
                    txtTenKH.Text = "KHÔNG TÌM THẤY";
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ CCCD KHÁCH HÀNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDatPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatPhong.SelectedRows.Count > 0)
            {
                txtMaPDP.Text = Convert.ToString(dgvDatPhong.SelectedRows[0].Cells[0].Value);
                cmbMaPhong.Text = Convert.ToString(dgvDatPhong.SelectedRows[0].Cells[1].Value);
                txtSoNguoi.Text = Convert.ToString(dgvDatPhong.SelectedRows[0].Cells[2].Value);
                dtpNgayNhan.Text = Convert.ToString(dgvDatPhong.SelectedRows[0].Cells[3].Value);
                dtpNgayTraDuKien.Text = Convert.ToString(dgvDatPhong.SelectedRows[0].Cells[4].Value);

                List<KhachHangDTO> listKhachHang = BUS.KhachHangBUS.DanhSachKhachHang();
                KhachHangDTO khachHang = listKhachHang.FirstOrDefault(p => p.MAKH == Convert.ToInt16(dgvDatPhong.SelectedRows[0].Cells[6].Value));

                if (khachHang != null)
                {
                    txtTenKH.Text = khachHang.TENKH;
                    txtCCCDKH.Text = khachHang.CCCD.ToString();
                }
                else
                {
                    txtTenKH.Text = "";
                    txtCCCDKH.Text = "";

                }
            }
        }

        private void txtSoNguoi_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSoNguoi.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaPDP_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPDP.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

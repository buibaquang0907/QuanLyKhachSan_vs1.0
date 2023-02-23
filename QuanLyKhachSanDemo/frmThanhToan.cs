using DAL;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frmThanhToan : Form
    {
        public string taiKhoanHienHanh;
        public string tenPhong = "";
        public int maPhieuKT = 0;

        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void btnPhieuKiemTra_Click(object sender, EventArgs e)
        {
            using (frmPhieuKiemTra frmKT = new frmPhieuKiemTra())
            {
                frmKT.taiKhoanHienHanh = taiKhoanHienHanh;
                if (frmKT.ShowDialog() == DialogResult.OK)
                {
                    maPhieuKT = frmKT.TheValue;
                }
            }
            MessageBox.Show(maPhieuKT.ToString());
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            hienThiDanhSachHoaDon();
            this.reportViewer1.RefreshReport();
        }

        private void hienThiDanhSachHoaDon()
        {
            dgvHoaDon.Rows.Clear();
            List<HoaDonDTO> listHD = BUS.ThanhToanBUS.DanhSachHoaDon();
            foreach (var item in listHD)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.MAHOADON;
                dgvHoaDon.Rows[index].Cells[1].Value = item.TONGTIEN;
                dgvHoaDon.Rows[index].Cells[2].Value = item.NGAYTHANHTOAN;
                dgvHoaDon.Rows[index].Cells[3].Value = item.MAPHIEUKIEMTRA;
                dgvHoaDon.Rows[index].Cells[4].Value = item.MANHANVIEN;
            }
        }

        private PhieuKiemTraDTO layPhieuKiemTra(int maPKT)
        {
            List<PhieuKiemTraDTO> listKT = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            foreach (var item in listKT)
            {
                if (item.MAPHIEUKIEMTRA == maPKT)
                {
                    return item;
                }
            }
            return null;
        }

        private PhieuChuyenPhongDTO layPhieuChuyenPhong(int maPhieuDP)
        {
            List<PhieuChuyenPhongDTO> listKT = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            foreach (var item in listKT)
            {
                if (item.MAPHIEUDATPHONG == maPhieuDP)
                {
                    return item;
                }
            }
            return null;
        }

        private decimal layGiaThue(int maPhong)
        {

            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            PhongDTO phong = new PhongDTO();
            foreach (var item in listPhong)
            {
                if (item.MAPHONG == maPhong)
                {
                    phong = item;
                }
            }

            List<LoaiPhongDTO> listLoaiPhong = BUS.PhongvaLoaiPhongBUS.DanhSachLoaiPhong();


            if (phong != null)
            {
                foreach (var item in listLoaiPhong)
                {
                    if (item.MALOAIPHONG == phong.MALOAIPHONG)
                    {
                        return Convert.ToDecimal(item.GIATHUE);
                    }
                }
                return -1;
            }
            else
            {
                return 0;
            }

        }

        private decimal tinhTienDatPhong(int maPKT) // tinh tien bang ma phieu dat
        {
            List<PhieuDatPhongDTO> listDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            PhieuKiemTraDTO phieuKT = layPhieuKiemTra(maPhieuKT);

            DateTime ngayDen = new DateTime();
            decimal tongTien = 0, giathue = 0, tienCoc = 0, tienPhat = 0, tienSDDV = 0, tienChuyenPhong = 0;

            if (phieuKT != null)
            {
                if (phieuKT.MAPHIEUCHUYENPHONG != null)
                {
                    PhieuChuyenPhongDTO phieuChuyen = layPhieuChuyenPhong(Convert.ToInt16(phieuKT.MAPHIEUDATPHONG));
                    foreach (var item in listDatPhong)
                    {
                        if (item.MAPHIEUDATPHONG == phieuKT.MAPHIEUDATPHONG)
                        {
                            giathue = layGiaThue(Convert.ToInt16(item.MAPHONG));
                            ngayDen = Convert.ToDateTime(item.NGAYNHANPHONG);
                            tienCoc = Convert.ToDecimal(item.TIENCOC);
                            tienPhat = layTienDenBu(phieuKT.MAPHIEUKIEMTRA);
                            tienSDDV = layTienSDDV(Convert.ToInt16(phieuKT.MAPHIEUDATPHONG));
                            tienChuyenPhong = layTienChuyenPhong(Convert.ToInt16(phieuKT.MAPHIEUDATPHONG));
                        }
                    }

                    TimeSpan tongNgayThue = Convert.ToDateTime(phieuChuyen.NGAYCHUYENPHONG) - ngayDen;
                    int tongSoNgay = tongNgayThue.Days;

                    return tongTien = (tongSoNgay * giathue) - tienCoc + tienPhat + tienSDDV + tienChuyenPhong;
                }
                else
                {
                    foreach (var item in listDatPhong)
                    {
                        if (item.MAPHIEUDATPHONG == phieuKT.MAPHIEUDATPHONG)
                        {
                            giathue = layGiaThue(Convert.ToInt16(item.MAPHONG));
                            ngayDen = Convert.ToDateTime(item.NGAYNHANPHONG);
                            tienCoc = Convert.ToDecimal(item.TIENCOC);
                            tienPhat = layTienDenBu(phieuKT.MAPHIEUKIEMTRA);
                            tienSDDV = layTienSDDV(Convert.ToInt16(phieuKT.MAPHIEUDATPHONG));
                        }
                    }

                    TimeSpan tongNgayThue = dtpNgayTT.Value - ngayDen;
                    int tongSoNgay = tongNgayThue.Days;

                    return tongTien = (tongSoNgay * giathue) - tienCoc + tienPhat + tienSDDV;
                }
            }
            else
            {
                return -1;
            }
        }

        private decimal layTienDenBu(int maPKT)
        {
            decimal tongTien = 0;

            List<PhieuDenBuDTO> listPhieuDenBu = BUS.PhieuDenBuBUS.DanhSachPhieuDenBu();

            foreach (var item in listPhieuDenBu)
            {
                if (item.MAPHIEUKIEMTRA == maPKT)
                {
                    tongTien = Convert.ToDecimal(item.TIENPHAT);
                }
            }
            return tongTien;
        }

        private decimal layTienChuyenPhong(int maPhieuDatPhong)
        {
            decimal tongTien = 0;
            decimal giaThue = 0;
            int tongSoNgay = 0;
            List<PhieuChuyenPhongDTO> listPhieuChuyenPhong = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();

            DateTime ngayChuyenPhong = new DateTime();
            foreach (var item in listPhieuChuyenPhong)
            {
                if (item.MAPHIEUDATPHONG == maPhieuDatPhong)
                {
                    giaThue = layGiaThue(Convert.ToInt32(item.MAPHONG));
                    ngayChuyenPhong = Convert.ToDateTime(item.NGAYCHUYENPHONG);

                    TimeSpan tongNgayThue = dtpNgayTT.Value - ngayChuyenPhong;
                    tongSoNgay = tongNgayThue.Days;
                }
            }
            return tongTien = (giaThue * tongSoNgay);
        }

        private decimal layTienSDDV(int maPhieuDP)
        {
            decimal donGia = 0;

            List<PhieuSDDVDTO> listPhieuSDDV = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();
            PhieuSDDVDTO phieuSDDV = new PhieuSDDVDTO();

            foreach (var item in listPhieuSDDV)
            {
                if (item.MAPHIEUDATPHONG == maPhieuDP)
                {
                    phieuSDDV.MAPHIEUSDDV = item.MAPHIEUSDDV;
                    phieuSDDV.NGAYSUDUNG = item.NGAYSUDUNG;
                    phieuSDDV.SOLUONG = item.SOLUONG;
                    phieuSDDV.MAPHIEUDATPHONG = item.MAPHIEUDATPHONG;
                    phieuSDDV.MAPHIEUCHUYENPHONG = item.MAPHIEUCHUYENPHONG;
                    phieuSDDV.MANHANVIEN = item.MANHANVIEN;
                    phieuSDDV.MADICHVU = item.MADICHVU;
                }
            }

            if (phieuSDDV != null)
            {
                List<DichVuDTO> listDichVu = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();
                foreach (var item in listDichVu)
                {
                    if (item.MADICHVU == phieuSDDV.MADICHVU)
                    {
                        donGia = Convert.ToDecimal(item.GIATHUEDICHVU);
                    }
                }
            }
            return Convert.ToDecimal(donGia * phieuSDDV.SOLUONG);
        }

        private bool kiemTraPhieuKT_phieuHD_Them(int maPhieuKT)
        {
            List<HoaDonDTO> listHoaDon= BUS.ThanhToanBUS.DanhSachHoaDon();
            HoaDonDTO HoaDon = listHoaDon.Where(p => p.MAPHIEUKIEMTRA == maPhieuKT).FirstOrDefault();
            if (HoaDon != null)
            {
                return false;
            }
            return true;
        }

        private decimal tienCoc_PhieuDatPhong(int maPKT)
        {
            List<PhieuKiemTraDTO> listPKT = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            PhieuKiemTraDTO phieuKT = listPKT.FirstOrDefault(p => p.MAPHIEUKIEMTRA == maPKT);
            List<PhieuDatPhongDTO> listDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            if (phieuKT != null)
            {
                PhieuDatPhongDTO phieuDatPhong = listDatPhong.FirstOrDefault(p => p.MAPHIEUDATPHONG == phieuKT.MAPHIEUDATPHONG);
                if (phieuDatPhong != null) 
                {
                    return Convert.ToDecimal(phieuDatPhong.TIENCOC);
                }
                return 0;
            }
            return 0;
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            // check lap phieu kiem tra
            if (maPhieuKT != 0)
            {
                if (kiemTraPhieuKT_phieuHD_Them(maPhieuKT))
                {
                    decimal tongTienThue_PhieuDP = tinhTienDatPhong(maPhieuKT);
                    txtTongTien.Text = tongTienThue_PhieuDP.ToString();

                    decimal tienCoc_PhieuDat = tienCoc_PhieuDatPhong(maPhieuKT);

                    string stringngayLap = dtpNgayTT.Value.ToString("dd-MM-yyyy");
                    DateTime datatimeThanhToan = DateTime.Parse(stringngayLap);

                    NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanh);
                    HoaDonDTO hoaDon_new = new HoaDonDTO()
                    {
                        NGAYTHANHTOAN = datatimeThanhToan,
                        TONGTIEN = tongTienThue_PhieuDP + tienCoc_PhieuDat,
                        MANHANVIEN = nhanVienDangNhap.MANHANVIEN,
                        MAPHIEUKIEMTRA = maPhieuKT,
                    };
                    string ketQua = BUS.ThanhToanBUS.themHoaDon(hoaDon_new);

                    if (ketQua == "themthanhcong")
                    {
                        MessageBox.Show("TIỀN CẦN THANH TOÁN: "+ tongTienThue_PhieuDP + " VND", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiHoaDon(maPhieuKT);
                        hienThiDanhSachHoaDon();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                }
                else
                {
                    MessageBox.Show("PHIẾU KIỂM TRA ĐÃ CÓ HÓA ĐƠN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG LẬP PHIẾU KIỂM TRA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // thuc hien viec tinh tien
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                txtMaHD.Text = Convert.ToString(dgvHoaDon.SelectedRows[0].Cells[0].Value);
                txtTongTien.Text = Convert.ToString(dgvHoaDon.SelectedRows[0].Cells[1].Value);
                dtpNgayTT.Text = Convert.ToString(dgvHoaDon.SelectedRows[0].Cells[2].Value);
                txtMaPhieuKT.Text = Convert.ToString(dgvHoaDon.SelectedRows[0].Cells[3].Value);
            }
        }

        private void hienThiHoaDon(int maPKT)
        {
            List<HoaDonDTO> listHoaDon = BUS.ThanhToanBUS.DanhSachHoaDon();
            HoaDonDTO hoaDon = listHoaDon.Where(p => p.MAPHIEUKIEMTRA == maPKT).FirstOrDefault();
            if (hoaDon != null)
            {

                List<PhieuKiemTraDTO> listPhieuKiemTra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
                PhieuKiemTraDTO phieuKiemTra = listPhieuKiemTra.Where(p => p.MAPHIEUKIEMTRA == maPKT).FirstOrDefault();
                List<NhanVienDTO> listNhanVien = BUS.NhanVienBUS.DanhSachNhanVien();
                NhanVienDTO nhanVienLapPhieu = listNhanVien.Where(p => p.MANHANVIEN == phieuKiemTra.MANHANVIEN).FirstOrDefault();
                List<PhieuDatPhongDTO> listPhieuDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
                PhieuDatPhongDTO phieuDatPhong = listPhieuDatPhong.Where(p => p.MAPHIEUDATPHONG == phieuKiemTra.MAPHIEUDATPHONG).FirstOrDefault();
                List<KhachHangDTO> listKhachHang = BUS.KhachHangBUS.DanhSachKhachHang();
                KhachHangDTO khachHang = listKhachHang.Where(p => p.MAKH == phieuDatPhong.MAKH).FirstOrDefault();

                List<HoaDonReport> listHoaDonReport = new List<HoaDonReport>();

                HoaDonReport hoaDonReport = new HoaDonReport()
                {
                    MAHOADON = hoaDon.MAHOADON,
                    MANHANVIEN = nhanVienLapPhieu.MANHANVIEN,
                    TENKHACHHANG = khachHang.TENKH,
                    NGAYTHANHTOAN = Convert.ToDateTime(hoaDon.NGAYTHANHTOAN),
                    TONGTIEN = Convert.ToDecimal(hoaDon.TONGTIEN),
                    TENNHANVIEN = nhanVienLapPhieu.TENNHANVIEN,
                };
                listHoaDonReport.Add(hoaDonReport);

                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("TenNhanVienReport", nhanVienLapPhieu.TENNHANVIEN);
                param[1] = new ReportParameter("stringDateTimeReport", Convert.ToString(hoaDon.NGAYTHANHTOAN));
                this.reportViewer1.LocalReport.ReportPath = "D:\\TaiLieuDaiHoc\\CNPM-QuanLyKhachSan\\SourceCode\\QuanLyKhachSanDemo\\QuanLyKhachSanDemo\\hoaDonRepott.rdlc";
                var reportDataSource = new ReportDataSource("HoaDonDataSet", listHoaDonReport);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.SetParameters(param);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("KHÔNG TÌM THẤY HÓA ĐƠN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaHD.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaPhieuKT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPhieuKT.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(maPhieuKT != 0)
            {
                decimal tongTienThue_PhieuDP = tinhTienDatPhong(maPhieuKT);
                txtTongTien.Text = tongTienThue_PhieuDP.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanh);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1)
            {
                List<HoaDonDTO> listHD = BUS.ThanhToanBUS.DanhSachHoaDon();
                if (txtMaHD.Text != "")
                {
                    HoaDonDTO HD_Delete = listHD.FirstOrDefault(p => p.MAHOADON == Convert.ToInt64(txtMaHD.Text));

                    if (HD_Delete != null)
                    {
                        // Lay ra phieu dat phong cua hoa don chuan bi xoa
                        List<PhieuKiemTraDTO> listPhieuKiemTra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
                        PhieuKiemTraDTO phieuKiemTra = listPhieuKiemTra.FirstOrDefault(p => p.MAPHIEUKIEMTRA == HD_Delete.MAPHIEUKIEMTRA);
                        DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            string ketQua = BUS.ThanhToanBUS.xoaHoaDon(HD_Delete);
                            if (ketQua == "xoathanhcong")
                            {
                                MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if(phieuKiemTra.MAPHIEUCHUYENPHONG != null)
                                {
                                    List<PhieuChuyenPhongDTO> listPhieuCP = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
                                    PhieuChuyenPhongDTO PhieuChuyenPhong = listPhieuCP.FirstOrDefault(p => p.MAPHIEUCHUYENPHONG == Convert.ToInt32(phieuKiemTra.MAPHIEUCHUYENPHONG));
                                    List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
                                    PhongDTO phongDuocTra = listPhong.FirstOrDefault(p => p.MAPHONG == Convert.ToInt32(PhieuChuyenPhong.MAPHONG));

                                    if (phongDuocTra != null)
                                    {
                                        PhongDTO Phong_Sua = new PhongDTO()
                                        {
                                            MAPHONG = phongDuocTra.MAPHONG,
                                            TENPHONG = phongDuocTra.TENPHONG,
                                            SONGUOITOIDA = phongDuocTra.SONGUOITOIDA,
                                            TINHTRANG = "Đang được thuê",
                                            MALOAIPHONG = phongDuocTra.MALOAIPHONG,
                                        };
                                        BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua);
                                    }
                                }
                                else
                                {
                                    List<PhieuDatPhongDTO> listPhieuDP = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
                                    PhieuDatPhongDTO phieuDatPhong = listPhieuDP.FirstOrDefault(p => p.MAPHIEUDATPHONG == Convert.ToInt32(phieuKiemTra.MAPHIEUDATPHONG));
                                    List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
                                    PhongDTO phongDuocTra = listPhong.FirstOrDefault(p => p.MAPHONG == Convert.ToInt32(phieuDatPhong.MAPHONG));

                                    if (phongDuocTra != null)
                                    {
                                        PhongDTO Phong_Sua = new PhongDTO()
                                        {
                                            MAPHONG = phongDuocTra.MAPHONG,
                                            TENPHONG = phongDuocTra.TENPHONG,
                                            SONGUOITOIDA = phongDuocTra.SONGUOITOIDA,
                                            TINHTRANG = "Đang được thuê",
                                            MALOAIPHONG = phongDuocTra.MALOAIPHONG,
                                        };
                                        BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua);
                                    }

                                }
                                
                                hienThiDanhSachHoaDon();
                            }
                            else
                            {
                                MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("KHÔNG TÌM THẤY HÓA ĐƠN!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("VUI LÒNG NHẬP MÃ HÓA ĐƠN CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLapPhieuKiemTra_Click(object sender, EventArgs e)
        {

            //tra ve ma phieu kiem tra
            using (frmPhieuKiemTra frmPhieuKiemTra = new frmPhieuKiemTra())
            {
                frmPhieuKiemTra.taiKhoanHienHanh = taiKhoanHienHanh;
                frmPhieuKiemTra.tenPhong = tenPhong;
                if (frmPhieuKiemTra.ShowDialog() == DialogResult.OK)
                {
                    maPhieuKT = frmPhieuKiemTra.TheValue;
                }

                if(maPhieuKT != 0)
                {
                    txtMaPhieuKT.Text = maPhieuKT.ToString();
                }
                else
                {
                    MessageBox.Show("CHƯA CÓ PHIẾU KIỂM TRA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (txtMaPKT_TimKiem.Text != "")
            {
                hienThiHoaDon(int.Parse(txtMaPKT_TimKiem.Text));
            }
            else
            {
                MessageBox.Show("KHÔNG TÌM THẤY PHIẾU KIỂM TRA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaPKT_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPKT_TimKiem.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

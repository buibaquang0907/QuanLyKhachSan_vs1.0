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
    public partial class frmChuyenPhong : Form
    {
        public string taiKhoanHienHanh;
        public string tenPhong = "";

        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        private bool kiemTraMaPhieuDat_PhieuKiemTra(int maPhieuDat)
        {
            List<PhieuKiemTraDTO> listPhieuKiemTra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();

            foreach (var item in listPhieuKiemTra)
            {
                if(item.MAPHIEUDATPHONG == maPhieuDat)
                {
                    return false;
                }
            }
            return true;
        }

        private void chuyenPhong_GiaoDien()
        {
            List<PhieuDatPhongDTO> listPhieuDat = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();

            if(tenPhong != "")
            {
                List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
                PhongDTO phong_PhieuDat = listPhong.LastOrDefault(p => p.TENPHONG.Contains(tenPhong));
                List<PhieuChuyenPhongDTO> listPhieuChuyen = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
                
                PhieuDatPhongDTO phieuDatPhong = listPhieuDat.LastOrDefault(p => Convert.ToInt16(p.MAPHONG) == phong_PhieuDat.MAPHONG);

                PhieuChuyenPhongDTO phieuChuyen = listPhieuChuyen.LastOrDefault(p => p.MAPHONG == phong_PhieuDat.MAPHONG);

                if (phieuChuyen != null)
                {
                    if (kiemTraMaPhieuDat_PhieuKiemTra(Convert.ToInt16(phieuChuyen.MAPHIEUDATPHONG)) == true)
                    {
                        txtMaPhieuChuyenPhong.Text = phieuChuyen.MAPHIEUCHUYENPHONG.ToString();
                        cmbMaPhieuDat.Text = phieuChuyen.MAPHIEUDATPHONG.ToString(); 
                    }
                    else
                    {
                        cmbMaPhieuDat.Text = phieuDatPhong.MAPHIEUDATPHONG.ToString();
                    }
                }
                else 
                {
                    cmbMaPhieuDat.Text = phieuDatPhong.MAPHIEUDATPHONG.ToString();
                }

            }
        }

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            hienDSPhieuChuyenPhong();
            hienThiComboBox();
            danhSachPhongTrong();
            chuyenPhong_GiaoDien();
        }

        private void danhSachPhongTrong()
        {
            List<PhongDTO> listPhongBUS = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            List<PhongDTO> listPhongTrong = new List<PhongDTO>();

            foreach (var phong in listPhongBUS)
            {
                if (phong.TINHTRANG == "Bình thường")
                {
                    listPhongTrong.Add(phong);
                }
            }

            if (listPhongTrong.Count() != 0)
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

            List<PhieuDatPhongDTO> listPhieuDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            cmbMaPhieuDat.DataSource = listPhieuDatPhong;
            cmbMaPhieuDat.DisplayMember = "MAPHIEUDATPHONG";
            cmbMaPhieuDat.Text = "";
        }

        public void hienDSPhieuChuyenPhong()
        {
            dgvChuyenPhong.Rows.Clear();
            List<PhieuChuyenPhongDTO> listPhieuChuyenPhong = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            foreach (var item in listPhieuChuyenPhong)
            {
                int index = dgvChuyenPhong.Rows.Add();
                dgvChuyenPhong.Rows[index].Cells[0].Value = item.MAPHIEUCHUYENPHONG;
                dgvChuyenPhong.Rows[index].Cells[1].Value = item.LYDO;
                dgvChuyenPhong.Rows[index].Cells[2].Value = item.NGAYCHUYENPHONG;
                dgvChuyenPhong.Rows[index].Cells[3].Value = item.MAPHONG;
                dgvChuyenPhong.Rows[index].Cells[4].Value = item.MAPHIEUDATPHONG;
                dgvChuyenPhong.Rows[index].Cells[5].Value = item.MANHANVIEN;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string stringngayChuyenPhong = dtpNgayChuyenPhong.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayChuyenPhong = DateTime.Parse(stringngayChuyenPhong);

            NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanh);

            if (txtLyDo.Text != "" && dtpNgayChuyenPhong.Text != "" && cmbMaPhong.Text != "" && cmbMaPhieuDat.Text != "")
            {
                List<PhieuChuyenPhongDTO> listPhieuChuyenPhong = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
                PhieuChuyenPhongDTO phieuChuyenPhong = new PhieuChuyenPhongDTO();
                phieuChuyenPhong.LYDO = txtLyDo.Text;
                phieuChuyenPhong.NGAYCHUYENPHONG = datatimeNgayChuyenPhong;
                phieuChuyenPhong.MAPHONG = Convert.ToInt32(cmbMaPhong.Text);
                phieuChuyenPhong.MAPHIEUDATPHONG = Convert.ToInt32(cmbMaPhieuDat.Text);
                phieuChuyenPhong.MANHANVIEN = nhanVienDangNhap.MANHANVIEN;
                ////////////////////////////////////////////////////////////////////////////////
                List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();

                PhongDTO phongDuocThue = listPhong.FirstOrDefault(p => Convert.ToInt32(p.MAPHONG) == Convert.ToInt32(cmbMaPhong.Text));

                if (phongDuocThue != null)
                {
                    PhongDTO Phong_Sua = new PhongDTO()
                    {
                        MAPHONG = phongDuocThue.MAPHONG,
                        TENPHONG = phongDuocThue.TENPHONG,
                        SONGUOITOIDA = phongDuocThue.SONGUOITOIDA,
                        TINHTRANG = "Đang được thuê",
                        MALOAIPHONG = phongDuocThue.MALOAIPHONG,
                    };
                    BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua);
                }

                // Lay Phieu Dat => Chuyen trang thai phong trong phieu dat
                List<PhieuDatPhongDTO> listPhieuDat = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
                PhieuDatPhongDTO phieuDatPhong = listPhieuDat.FirstOrDefault(p => Convert.ToInt32(p.MAPHIEUDATPHONG) == Convert.ToInt32(cmbMaPhieuDat.Text));
                PhongDTO phongDuocTra = listPhong.FirstOrDefault(p => Convert.ToInt32(p.MAPHONG) == Convert.ToInt32(phieuDatPhong.MAPHONG));

                if (phongDuocTra != null)
                {
                    PhongDTO Phong_Sua = new PhongDTO()
                    {
                        MAPHONG = phongDuocTra.MAPHONG,
                        TENPHONG = phongDuocTra.TENPHONG,
                        SONGUOITOIDA = phongDuocTra.SONGUOITOIDA,
                        TINHTRANG = "Bình thường",
                        MALOAIPHONG = phongDuocTra.MALOAIPHONG,
                    };
                    BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua);
                }
                //////////////////////////////////////////////////////////////////////////////

                string ketQua = BUS.PhieuChuyenPhongBUS.themPhieuChuyenPhongBUS(phieuChuyenPhong);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM PHIẾU CHUYỂN PHÒNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienDSPhieuChuyenPhong();
                }
                else
                {
                    MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                hienDSPhieuChuyenPhong();
                hienThiComboBox();
                danhSachPhongTrong();
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string stringngayChuyenPhong = dtpNgayChuyenPhong.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayChuyenPhong = DateTime.Parse(stringngayChuyenPhong);

            NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanh);

            if (txtMaPhieuChuyenPhong.Text != "" && txtLyDo.Text != "" )
            {
                PhieuChuyenPhongDTO phieuChuyenPhong = new PhieuChuyenPhongDTO();
                phieuChuyenPhong.MAPHIEUCHUYENPHONG = int.Parse(txtMaPhieuChuyenPhong.Text);
                phieuChuyenPhong.LYDO = txtLyDo.Text;
                phieuChuyenPhong.NGAYCHUYENPHONG = datatimeNgayChuyenPhong;
                phieuChuyenPhong.MAPHONG = int.Parse(cmbMaPhong.Text);
                phieuChuyenPhong.MAPHIEUDATPHONG = Convert.ToInt32(cmbMaPhieuDat.Text);
                phieuChuyenPhong.MANHANVIEN = nhanVienDangNhap.MANHANVIEN;

                List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();

                PhongDTO phongDuocThue = listPhong.FirstOrDefault(p => Convert.ToInt32(p.MAPHONG) == Convert.ToInt32(cmbMaPhong.Text));

                if (phongDuocThue != null)
                {
                    PhongDTO Phong_Sua = new PhongDTO()
                    {
                        MAPHONG = phongDuocThue.MAPHONG,
                        TENPHONG = phongDuocThue.TENPHONG,
                        SONGUOITOIDA = phongDuocThue.SONGUOITOIDA,
                        TINHTRANG = "Đang được thuê",
                        MALOAIPHONG = phongDuocThue.MALOAIPHONG,
                    };
                    BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua);
                }

                // Lay Phieu Dat => Chuyen trang thai phong trong phieu dat
                List<PhieuChuyenPhongDTO> listPhieuChuyen = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
                PhieuChuyenPhongDTO phieuChuyenPhong_Sua = listPhieuChuyen.FirstOrDefault(p => Convert.ToInt32(p.MAPHIEUCHUYENPHONG) == Convert.ToInt32(txtMaPhieuChuyenPhong.Text));
                PhongDTO phongDuocTra = listPhong.FirstOrDefault(p => Convert.ToInt32(p.MAPHONG) == Convert.ToInt32(phieuChuyenPhong_Sua.MAPHONG));

                if (phieuChuyenPhong_Sua != null)
                {
                    PhongDTO Phong_Sua = new PhongDTO()
                    {
                        MAPHONG = phongDuocTra.MAPHONG,
                        TENPHONG = phongDuocTra.TENPHONG,
                        SONGUOITOIDA = phongDuocTra.SONGUOITOIDA,
                        TINHTRANG = "Bình thường",
                        MALOAIPHONG = phongDuocTra.MALOAIPHONG,
                    };
                    BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua);
                }

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN PHIẾU CHUYỂN PHÒNG?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.PhieuChuyenPhongBUS.suaPhieuChuyenPhongBUS(phieuChuyenPhong);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN PHIÉU CHUYỂN PHÒNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienDSPhieuChuyenPhong();
                        hienThiComboBox();
                        danhSachPhongTrong();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool kiemTraChuyenPhong_phieuSDDV(int maPhieuCP)
        {
            List<PhieuSDDVDTO> listPhieuSDDV = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();
            PhieuSDDVDTO phieuSDDV = listPhieuSDDV.Where(p => p.MAPHIEUCHUYENPHONG == maPhieuCP).FirstOrDefault();
            if (phieuSDDV != null)
            {
                return false;
            }
            return true;
        }

        private bool kiemTraChuyenPhong_phieuKT(int maPhieuCP)
        {
            List<PhieuKiemTraDTO> listPhieuKT= BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            PhieuKiemTraDTO phieuKT = listPhieuKT.Where(p => p.MAPHIEUCHUYENPHONG == maPhieuCP).FirstOrDefault();
            if (phieuKT != null)
            {
                return false;
            }
            return true;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<PhieuChuyenPhongDTO> listPhieuDat = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            if (txtMaPhieuChuyenPhong.Text != "")
            {
                PhieuChuyenPhongDTO phieuChuyenPhong = listPhieuDat.FirstOrDefault(p => p.MAPHIEUCHUYENPHONG == Int32.Parse(txtMaPhieuChuyenPhong.Text));
                if (phieuChuyenPhong != null)
                {
                    if (kiemTraChuyenPhong_phieuSDDV(phieuChuyenPhong.MAPHIEUCHUYENPHONG))
                    {
                        if (kiemTraChuyenPhong_phieuKT(phieuChuyenPhong.MAPHIEUCHUYENPHONG))
                        {
                            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
                            PhongDTO phongDuocTra = listPhong.FirstOrDefault(p => p.MAPHONG == Convert.ToInt32(phieuChuyenPhong.MAPHONG));

                            if (phongDuocTra != null)
                            {
                                PhongDTO Phong_Sua = new PhongDTO()
                                {
                                    MAPHONG = phongDuocTra.MAPHONG,
                                    TENPHONG = phongDuocTra.TENPHONG,
                                    SONGUOITOIDA = phongDuocTra.SONGUOITOIDA,
                                    TINHTRANG = "Bình thường",
                                    MALOAIPHONG = phongDuocTra.MALOAIPHONG,
                                };
                                BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua);
                            }

                            List<PhieuDatPhongDTO> listPhieuDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
                            PhieuDatPhongDTO phieuDatPhong = listPhieuDatPhong.FirstOrDefault(p => p.MAPHIEUDATPHONG == Convert.ToInt32(phieuChuyenPhong.MAPHIEUDATPHONG));
                            PhongDTO phongDuocThue = listPhong.FirstOrDefault(p => p.MAPHONG == Convert.ToInt32(phieuDatPhong.MAPHONG));

                            if (phongDuocThue != null)
                            {
                                PhongDTO Phong_Sua = new PhongDTO()
                                {
                                    MAPHONG = phongDuocThue.MAPHONG,
                                    TENPHONG = phongDuocThue.TENPHONG,
                                    SONGUOITOIDA = phongDuocThue.SONGUOITOIDA,
                                    TINHTRANG = "Đang được thuê",
                                    MALOAIPHONG = phongDuocThue.MALOAIPHONG,
                                };
                                BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua);
                            }
                            DialogResult re = MessageBox.Show("BẠN CÓ MUỐN XÓA PHIẾU CHUYỂN PHÒNG?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (re == DialogResult.Yes)
                            {
                                string ketQua = BUS.PhieuChuyenPhongBUS.xoaPhieuChuyenPhongBUS(phieuChuyenPhong);
                                if (ketQua == "xoathanhcong")
                                {
                                    MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    hienDSPhieuChuyenPhong();
                                    hienThiComboBox();
                                    danhSachPhongTrong();
                                }
                                else
                                {
                                    MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }  
                        }
                        else
                        {
                            MessageBox.Show("CẦN PHẢI XÓA PHIẾU KIỂM TRA", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CẦN PHẢI XÓA PHIẾU SỬ DỤNG DỊCH VỤ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY PHIẾU CHUYỂN PHÒNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvChuyenPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChuyenPhong.SelectedRows.Count > 0)
            {
                txtMaPhieuChuyenPhong.Text = Convert.ToString(dgvChuyenPhong.SelectedRows[0].Cells[0].Value);
                txtLyDo.Text = Convert.ToString(dgvChuyenPhong.SelectedRows[0].Cells[1].Value);
                dtpNgayChuyenPhong.Text = Convert.ToString(dgvChuyenPhong.SelectedRows[0].Cells[2].Value);
                cmbMaPhong.Text = Convert.ToString(dgvChuyenPhong.SelectedRows[0].Cells[3].Value);
                cmbMaPhieuDat.Text = Convert.ToString(dgvChuyenPhong.SelectedRows[0].Cells[4].Value);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<PhieuChuyenPhongDTO> listPhieuChuyenPhong = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            dgvChuyenPhong.Rows.Clear();
            foreach (var item in listPhieuChuyenPhong)
            {
                if (item.MAPHIEUCHUYENPHONG.ToString().Contains(txtTimKiem.Text))
                {
                    int index = dgvChuyenPhong.Rows.Add();
                    dgvChuyenPhong.Rows[index].Cells[0].Value = item.MAPHIEUCHUYENPHONG;
                    dgvChuyenPhong.Rows[index].Cells[1].Value = item.LYDO;
                    dgvChuyenPhong.Rows[index].Cells[2].Value = item.NGAYCHUYENPHONG;
                    dgvChuyenPhong.Rows[index].Cells[3].Value = item.MAPHONG;
                    dgvChuyenPhong.Rows[index].Cells[4].Value = item.MAPHIEUDATPHONG;
                    dgvChuyenPhong.Rows[index].Cells[5].Value = item.MANHANVIEN;
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

        private void txtMaPhieuChuyenPhong_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPhieuChuyenPhong.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

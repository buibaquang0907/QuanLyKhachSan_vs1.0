using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace QuanLyKhachSanDemo
{
    public partial class frmPhieuKiemTra : Form
    {
        public string taiKhoanHienHanh;
        public string tenPhong = "";
        public int maPhieuKT = 0;
        public frmPhieuKiemTra()
        {
            InitializeComponent();
        }
        private bool kiemTraMaPhieuDat_PhieuKiemTra(int maPhieuDat)
        {
            List<PhieuKiemTraDTO> listPhieuKiemTra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();

            foreach (var item in listPhieuKiemTra)
            {
                if (item.MAPHIEUDATPHONG == maPhieuDat)
                {
                    return false;
                }
            }
            return true;
        }

        private void chuyenPhong_GiaoDien()
        {

            if (tenPhong != "")
            {
                List<PhieuDatPhongDTO> listPhieuDat = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();

                if (tenPhong != "")
                {
                    List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
                    List<PhieuSDDVDTO> listphieuSDDV = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();
                    PhongDTO phong_PhieuDat = listPhong.LastOrDefault(p => p.TENPHONG.Contains(tenPhong));
                    List<PhieuChuyenPhongDTO> listPhieuChuyen = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();

                    PhieuDatPhongDTO phieuDatPhong = listPhieuDat.LastOrDefault(p => Convert.ToInt16(p.MAPHONG) == phong_PhieuDat.MAPHONG);

                    PhieuChuyenPhongDTO phieuChuyen = listPhieuChuyen.LastOrDefault(p => p.MAPHONG == phong_PhieuDat.MAPHONG);
                    PhieuSDDVDTO phieuSDDV = new PhieuSDDVDTO();


                    if (phieuChuyen != null)
                    {
                        if (kiemTraMaPhieuDat_PhieuKiemTra(Convert.ToInt16(phieuChuyen.MAPHIEUDATPHONG)) == true)
                        {
                            phieuSDDV = listphieuSDDV.LastOrDefault(p => p.MAPHIEUDATPHONG == phieuChuyen.MAPHIEUDATPHONG);
                            cmbMaChuyenPhong.Text = phieuChuyen.MAPHIEUCHUYENPHONG.ToString();
                            cmbMaPhieuDatPhong.Text = phieuChuyen.MAPHIEUDATPHONG.ToString();
                        }
                        else
                        {
                            phieuSDDV = listphieuSDDV.LastOrDefault(p => p.MAPHIEUDATPHONG == phieuDatPhong.MAPHIEUDATPHONG);
                            cmbMaPhieuDatPhong.Text = phieuDatPhong.MAPHIEUDATPHONG.ToString();
                        }
                        
                    }
                    else
                    {
                        phieuSDDV = listphieuSDDV.LastOrDefault(p => p.MAPHIEUDATPHONG == phieuDatPhong.MAPHIEUDATPHONG);
                        cmbMaPhieuDatPhong.Text = phieuDatPhong.MAPHIEUDATPHONG.ToString();
                    }

                    if(phieuSDDV != null)
                    {
                        cmbPhieuSDDV.Text = phieuSDDV.MAPHIEUSDDV.ToString();
                    }

                }
            }
        }

        public int TheValue  // them code vao click them => tcong
        {
            get
            {
               return maPhieuKT; 
            }
        }

        private void frmPhieuKiemTra_Load(object sender, EventArgs e)
        {
            hienThiDanhSachPhieuKT();
            cmbTinhTrang.SelectedIndex = 0;
            chuyenPhong_GiaoDien();
        }

        private void hienThiComboBox()
        {

        }

        public void hienThiDanhSachPhieuKT()
        {
            dgvPhieuKiemTra.Rows.Clear();
            List<PhieuKiemTraDTO> listPhieuKiemTra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            foreach (var item in listPhieuKiemTra)
            {
                int index = dgvPhieuKiemTra.Rows.Add();
                dgvPhieuKiemTra.Rows[index].Cells[0].Value = item.MAPHIEUKIEMTRA;
                dgvPhieuKiemTra.Rows[index].Cells[1].Value = item.TINHTRANGSAUKIEMTRA;
                dgvPhieuKiemTra.Rows[index].Cells[2].Value = item.NGAYKIEMTRA;
                dgvPhieuKiemTra.Rows[index].Cells[3].Value = item.MANHANVIEN;
                dgvPhieuKiemTra.Rows[index].Cells[4].Value = item.MAPHIEUDATPHONG;
                dgvPhieuKiemTra.Rows[index].Cells[5].Value = item.MAPHIEUCHUYENPHONG;
                dgvPhieuKiemTra.Rows[index].Cells[6].Value = item.MAPHIEUSDDV;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int kiemTraPhieuKT_PhieuDP(int maPhieuDatPhong)
        {
            List<PhieuKiemTraDTO> listPKT = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            PhieuKiemTraDTO phieuKT = listPKT.Where(p => p.MAPHIEUDATPHONG == maPhieuDatPhong).LastOrDefault();
            if(phieuKT != null)
            {
                return phieuKT.MAPHIEUKIEMTRA;
            }
            return -1;
        }


        private void btnThemKT_Click(object sender, EventArgs e)
        {
            string stringngayLap = dtpNgayKiemTra.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayLap = DateTime.Parse(stringngayLap);

            NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanh);

            if (cmbTinhTrang.Text != "" && cmbMaPhieuDatPhong.Text != "")
            {
                if (kiemTraPhieuKT_PhieuDP(int.Parse(cmbMaPhieuDatPhong.Text)) == -1)
                {
                    PhieuKiemTraDTO phieuKT = new PhieuKiemTraDTO();
                    List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
                    phieuKT.TINHTRANGSAUKIEMTRA = cmbTinhTrang.Text;
                    phieuKT.MANHANVIEN = nhanVienDangNhap.MANHANVIEN;
                    phieuKT.NGAYKIEMTRA = datatimeNgayLap;
                    if (cmbMaChuyenPhong.Text == "Không tìm thấy" || cmbMaChuyenPhong.Text == "")
                    {
                        phieuKT.MAPHIEUCHUYENPHONG = null;
                    }
                    else
                    {
                        phieuKT.MAPHIEUCHUYENPHONG = int.Parse(cmbMaChuyenPhong.Text);
                        List<PhieuChuyenPhongDTO> listPhieuChuyen = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
                        PhieuChuyenPhongDTO phieuChuyenPhong_Sua = listPhieuChuyen.LastOrDefault(p => p.MAPHIEUCHUYENPHONG == Convert.ToInt32(cmbMaChuyenPhong.Text));


                        if (phieuChuyenPhong_Sua != null)
                        {
                            PhongDTO phongDuocTra_PhieuChuyen = listPhong.LastOrDefault(p => p.MAPHONG == Convert.ToInt32(phieuChuyenPhong_Sua.MAPHONG));
                            PhongDTO Phong_Sua_CP = new PhongDTO()
                            {
                                MAPHONG = phongDuocTra_PhieuChuyen.MAPHONG,
                                TENPHONG = phongDuocTra_PhieuChuyen.TENPHONG,
                                SONGUOITOIDA = phongDuocTra_PhieuChuyen.SONGUOITOIDA,
                                TINHTRANG = "Bình thường",
                                MALOAIPHONG = phongDuocTra_PhieuChuyen.MALOAIPHONG,
                            };
                            BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua_CP);
                        }
                    }
                    phieuKT.MAPHIEUDATPHONG = int.Parse(cmbMaPhieuDatPhong.Text);

                    List<PhieuDatPhongDTO> listPhieuDat = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
                    PhieuDatPhongDTO phieuDatPhong = listPhieuDat.LastOrDefault(p => p.MAPHIEUDATPHONG == Convert.ToInt32(cmbMaPhieuDatPhong.Text));
                    PhongDTO phongDuocTra = listPhong.LastOrDefault(p => p.MAPHONG == Convert.ToInt32(phieuDatPhong.MAPHONG));

                    if (phongDuocTra != null)
                    {
                        PhongDTO Phong_Sua_DP = new PhongDTO()
                        {
                            MAPHONG = phongDuocTra.MAPHONG,
                            TENPHONG = phongDuocTra.TENPHONG,
                            SONGUOITOIDA = phongDuocTra.SONGUOITOIDA,
                            TINHTRANG = "Bình thường",
                            MALOAIPHONG = phongDuocTra.MALOAIPHONG,
                        };
                        BUS.PhongvaLoaiPhongBUS.suaPhongBUS(Phong_Sua_DP);
                    }

                    //
                    if (cmbPhieuSDDV.Text == "" || cmbPhieuSDDV.Text == "Không tìm thấy")
                    {
                        phieuKT.MAPHIEUSDDV = null;
                    }
                    else
                    {
                        phieuKT.MAPHIEUSDDV = int.Parse(cmbPhieuSDDV.Text);
                    }

                    // binh thuong
                    if (cmbTinhTrang.Text == "Bình thường")
                    {
                        string ketQua = BUS.PhieuKiemTraBUS.themPhieuKiemTraBUS(phieuKT);

                        if (ketQua == "themthanhcong")
                        {
                            MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            List<PhieuKiemTraDTO> listPhieuKT = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
                            foreach (var item in listPhieuKT)
                            {
                                if (item.TINHTRANGSAUKIEMTRA == phieuKT.TINHTRANGSAUKIEMTRA &&
                                    item.NGAYKIEMTRA == phieuKT.NGAYKIEMTRA &&
                                    item.MAPHIEUSDDV == phieuKT.MAPHIEUSDDV &&
                                    item.MAPHIEUCHUYENPHONG == phieuKT.MAPHIEUCHUYENPHONG &&
                                    item.MAPHIEUDATPHONG == phieuKT.MAPHIEUDATPHONG)
                                {
                                    maPhieuKT = item.MAPHIEUKIEMTRA;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // co hu hai
                    else if (cmbTinhTrang.Text == "Có hư hại")
                    {
                        string ketQua = BUS.PhieuKiemTraBUS.themPhieuKiemTraBUS(phieuKT);

                        if (ketQua == "themthanhcong")
                        {
                            MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            List<PhieuKiemTraDTO> listPhieuKT = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
                            foreach (var item in listPhieuKT)
                            {
                                if (item.TINHTRANGSAUKIEMTRA == phieuKT.TINHTRANGSAUKIEMTRA &&
                                    item.NGAYKIEMTRA == phieuKT.NGAYKIEMTRA &&
                                    item.MAPHIEUSDDV == phieuKT.MAPHIEUSDDV &&
                                    item.MAPHIEUCHUYENPHONG == phieuKT.MAPHIEUCHUYENPHONG &&
                                    item.MAPHIEUDATPHONG == phieuKT.MAPHIEUDATPHONG)
                                {
                                    maPhieuKT = item.MAPHIEUKIEMTRA;
                                }
                            }

                            frmPhieuDenBu frmPhieuDenBu = new frmPhieuDenBu();
                            frmPhieuDenBu.maPKT = maPhieuKT;
                            frmPhieuDenBu.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    hienThiDanhSachPhieuKT();
                    hienThiComboBox();
                }
                else
                {
                    MessageBox.Show("PHIẾU ĐẶT PHÒNG ĐÃ CÓ PHIẾU KIỂM TRA CÓ MÃ: " + kiemTraPhieuKT_PhieuDP(int.Parse(cmbMaPhieuDatPhong.Text)), "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<KhachHangDTO> listKH = BUS.KhachHangBUS.DanhSachKhachHang();
            
            List<KhachHangDTO> listTemp = new List<KhachHangDTO >();

            listTemp.Clear();

            foreach(var item in listKH)
            {
                if (item.CCCD.ToString().Contains(txtCCCDTim.Text))
                {
                    listTemp.Add(item);
                }
            }

            if(listTemp.Count > 0)
            {
                cmbKH.DataSource = listTemp;
                cmbKH.DisplayMember = "TENKH";
            }
            else
            {
                cmbKH.Text = "Không tìm thấy";
                cmbPhieuSDDV.Text = "Không tìm thấy";
                cmbMaPhieuDatPhong.Text = "Không tìm thấy";
                cmbMaChuyenPhong.Text = "Không tìm thấy";
            }
        }

        private void btnSuaPKT_Click(object sender, EventArgs e)
        {
            string stringngayKiemTra = dtpNgayKiemTra.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayKiemTra = DateTime.Parse(stringngayKiemTra);

            NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanh);


            if (cmbTinhTrang.Text != "" && txtMaPhieuKT.Text != "")
            {
                PhieuKiemTraDTO phieuKT = new PhieuKiemTraDTO();
                phieuKT.MAPHIEUKIEMTRA = int.Parse(txtMaPhieuKT.Text);
                phieuKT.TINHTRANGSAUKIEMTRA = cmbTinhTrang.Text;
                phieuKT.MANHANVIEN = nhanVienDangNhap.MANHANVIEN;
                phieuKT.NGAYKIEMTRA = datatimeNgayKiemTra;
                phieuKT.MAPHIEUCHUYENPHONG = int.Parse(cmbMaChuyenPhong.Text);
                phieuKT.MAPHIEUDATPHONG = int.Parse(cmbMaPhieuDatPhong.Text);

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN PHIẾU KIỂM TRA?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.PhieuKiemTraBUS.suaPhieuKiemTraBUS(phieuKT);

                    maPhieuKT = phieuKT.MAPHIEUKIEMTRA;
                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN PHIẾU KIỂM TRA PHÒNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDanhSachPhieuKT();
                        hienThiComboBox();
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



        private bool kiemTraPKT_HoaDon(int maPTK)
        {
            List<HoaDonDTO> listHoaDon = BUS.ThanhToanBUS.DanhSachHoaDon();
            HoaDonDTO hoaDon_MaPTK = listHoaDon.Where(p => p.MAPHIEUKIEMTRA == maPTK).FirstOrDefault();
            if(hoaDon_MaPTK != null)
            {
                return false;
            }
            return true;
        }

        private bool kiemTraPKT_PhieuDenBu(int maPTK)
        {
            List<PhieuDenBuDTO> listDenBu = BUS.PhieuDenBuBUS.DanhSachPhieuDenBu();
            PhieuDenBuDTO denBu_MaPTK = listDenBu.Where(p => p.MAPHIEUKIEMTRA == maPTK).FirstOrDefault();
            if (denBu_MaPTK != null)
            {
                return false;
            }
            return true;
        }
        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            List<PhieuKiemTraDTO> listKiemTra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            if (txtMaPhieuKT.Text != "")
            {
                PhieuKiemTraDTO phieuKiemTra = listKiemTra.FirstOrDefault(p => p.MAPHIEUKIEMTRA == Int32.Parse(txtMaPhieuKT.Text));
                if (phieuKiemTra != null)
                {
                    if (kiemTraPKT_HoaDon(phieuKiemTra.MAPHIEUKIEMTRA))
                    {
                        if (kiemTraPKT_PhieuDenBu(phieuKiemTra.MAPHIEUKIEMTRA))
                        {
                            DialogResult re = MessageBox.Show("BẠN CÓ MUỐN XÓA PHIẾU KIỂM TRA?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (re == DialogResult.Yes)
                            {
                                string ketQua = BUS.PhieuKiemTraBUS.xoaPhieuKiemTraBUS(phieuKiemTra);
                                if (ketQua == "xoathanhcong")
                                {
                                    MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    hienThiDanhSachPhieuKT();
                                    hienThiComboBox();
                                }
                                else
                                {
                                    MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("CẦN PHẢI XÓA HÓA ĐƠN CÓ MÃ PHIẾU ĐỀN BÙ: " + phieuKiemTra.MAPHIEUKIEMTRA, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CẦN PHẢI XÓA HÓA ĐƠN CÓ MÃ PHIẾU KIỂM TRA: " + phieuKiemTra.MAPHIEUKIEMTRA , "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY PHIẾU KIỂM TRA", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ PHIẾU CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhieuDenBu_Click(object sender, EventArgs e)
        {
            frmPhieuDenBu frmPhieuDenBu = new frmPhieuDenBu();
            frmPhieuDenBu.ShowDialog();
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

        private void cmbMaPhieuDatPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            List<PhieuChuyenPhongDTO> listChuyenPhong = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            List<PhieuChuyenPhongDTO> listTam_ChuyenPhong = new List<PhieuChuyenPhongDTO>();
            
            if (IsNumber(cmbMaPhieuDatPhong.Text))
            {
                PhieuChuyenPhongDTO phieuChuyen = listChuyenPhong.FirstOrDefault(p => p.MAPHIEUDATPHONG == int.Parse(cmbMaPhieuDatPhong.Text));

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
            List<PhieuSDDVDTO> listPhieuSDDV = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();
            List<PhieuSDDVDTO> listTam_PhieuSDDV = new List<PhieuSDDVDTO>();

            if (IsNumber(cmbMaPhieuDatPhong.Text))
            {
                PhieuSDDVDTO phieuSDDV = listPhieuSDDV.FirstOrDefault(p => p.MAPHIEUDATPHONG == int.Parse(cmbMaPhieuDatPhong.Text));

                if (phieuSDDV != null)
                {
                    foreach (var item in listPhieuSDDV)
                    {
                        if (item.MAPHIEUDATPHONG == int.Parse(cmbMaPhieuDatPhong.Text))
                        {
                            listTam_PhieuSDDV.Add(item);
                        }
                    }
                }
                if (listTam_PhieuSDDV.Count > 0)
                {
                    cmbPhieuSDDV.DataSource = listTam_PhieuSDDV;
                    cmbPhieuSDDV.DisplayMember = "MAPHIEUSDDV";
                }
                else
                {
                    cmbPhieuSDDV.Text = "Không tìm thấy";
                }
            }
        }

        private void cmbKH_SelectedValueChanged(object sender, EventArgs e)
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

        private void dgvPhieuKiemTra_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuKiemTra.SelectedRows.Count > 0)
            {
                txtMaPhieuKT.Text = Convert.ToString(dgvPhieuKiemTra.SelectedRows[0].Cells[0].Value);
                cmbTinhTrang.Text = Convert.ToString(dgvPhieuKiemTra.SelectedRows[0].Cells[1].Value);
                dtpNgayKiemTra.Text = Convert.ToString(dgvPhieuKiemTra.SelectedRows[0].Cells[2].Value);
                cmbMaPhieuDatPhong.Text = Convert.ToString(dgvPhieuKiemTra.SelectedRows[0].Cells[4].Value);
                cmbMaChuyenPhong.Text = Convert.ToString(dgvPhieuKiemTra.SelectedRows[0].Cells[5].Value);
                cmbPhieuSDDV.Text = Convert.ToString(dgvPhieuKiemTra.SelectedRows[0].Cells[6].Value);
            }
        }

        private void txtMaPhieuKT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPhieuKT.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

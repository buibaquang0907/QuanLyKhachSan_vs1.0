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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyKhachSanDemo
{
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiPhong();
            HienThiDSPhong();

            List<LoaiPhongDTO> listLoaiPhong = BUS.PhongvaLoaiPhongBUS.DanhSachLoaiPhong();
            cmbMaLoai.DataSource = listLoaiPhong;
            cmbMaLoai.DisplayMember = "MALOAIPHONG";
        }

        public void HienThiDSLoaiPhong()
        {
            dgvLoaiPhong.Rows.Clear();
            List<LoaiPhongDTO> listLoaiPhong = BUS.PhongvaLoaiPhongBUS.DanhSachLoaiPhong();
            foreach (var item in listLoaiPhong)
            {
                int index = dgvLoaiPhong.Rows.Add();
                dgvLoaiPhong.Rows[index].Cells[0].Value = item.MALOAIPHONG;
                dgvLoaiPhong.Rows[index].Cells[1].Value = item.TENLOAIPHONG;
                dgvLoaiPhong.Rows[index].Cells[2].Value = item.GIATHUE;
            }
        }

        public void HienThiDSPhong()
        {
            dgvPhong.Rows.Clear();
            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            foreach (var item in listPhong)
            {
                int index = dgvPhong.Rows.Add();
                dgvPhong.Rows[index].Cells[0].Value = item.MAPHONG;
                dgvPhong.Rows[index].Cells[1].Value = item.TENPHONG;
                dgvPhong.Rows[index].Cells[2].Value = item.SONGUOITOIDA;
                dgvPhong.Rows[index].Cells[3].Value = item.TINHTRANG;
                dgvPhong.Rows[index].Cells[4].Value = item.MALOAIPHONG;
            }
        }

        private void txtTimLoai_TextChanged(object sender, EventArgs e)
        {
            List<LoaiPhongDTO> listLoaiPhong = BUS.PhongvaLoaiPhongBUS.DanhSachLoaiPhong();
            dgvLoaiPhong.Rows.Clear();

            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            dgvPhong.Rows.Clear();

            foreach (LoaiPhongDTO item in listLoaiPhong)
            {
                if (item.TENLOAIPHONG.ToString().ToUpper().Contains(txtTimLoai.Text.ToUpper()))
                {
                    int index = dgvLoaiPhong.Rows.Add();
                    dgvLoaiPhong.Rows[index].Cells[0].Value = item.MALOAIPHONG;
                    dgvLoaiPhong.Rows[index].Cells[1].Value = item.TENLOAIPHONG;
                    dgvLoaiPhong.Rows[index].Cells[2].Value = item.GIATHUE;

                    foreach (PhongDTO i in listPhong)
                    {
                        if (i.MALOAIPHONG.ToString().Contains(item.MALOAIPHONG.ToString()))
                        {
                            int indexs = dgvPhong.Rows.Add();
                            dgvPhong.Rows[indexs].Cells[0].Value = i.MAPHONG;
                            dgvPhong.Rows[indexs].Cells[1].Value = i.TENPHONG;
                            dgvPhong.Rows[indexs].Cells[2].Value = i.SONGUOITOIDA;
                            dgvPhong.Rows[indexs].Cells[3].Value = i.TINHTRANG;
                            dgvPhong.Rows[indexs].Cells[4].Value = i.MALOAIPHONG;
                        }
                    }
                }
            }

            
            
        }

        private void txtTimPhong_TextChanged(object sender, EventArgs e)
        {
            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            dgvPhong.Rows.Clear();
            foreach (PhongDTO item in listPhong)
            {
                if (item.TENPHONG.ToString().ToUpper().Contains(txtTimPhong.Text.ToUpper()))
                {
                    int index = dgvPhong.Rows.Add();
                    dgvPhong.Rows[index].Cells[0].Value = item.MAPHONG;
                    dgvPhong.Rows[index].Cells[1].Value = item.TENPHONG;
                    dgvPhong.Rows[index].Cells[2].Value = item.SONGUOITOIDA;
                    dgvPhong.Rows[index].Cells[3].Value = item.TINHTRANG;
                    dgvPhong.Rows[index].Cells[4].Value = item.MALOAIPHONG;
                }
            }

            //if (dgvPhong.DataSource == null)
            //{
            //    MessageBox.Show("Không tìm thấy phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text != "" && txtGiaThue.Text != "")
            {
                LoaiPhongDTO new_loaiPhong = new LoaiPhongDTO()
                {
                    TENLOAIPHONG = txtTenLoai.Text,
                    GIATHUE = decimal.Parse(txtGiaThue.Text),
                };
                string ketQua = BUS.PhongvaLoaiPhongBUS.themLoaiPhongBUS(new_loaiPhong);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM LOẠI PHÒNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSPhong();
                    HienThiDSLoaiPhong();

                    List<LoaiPhongDTO> listLoaiPhong = BUS.PhongvaLoaiPhongBUS.DanhSachLoaiPhong();
                    cmbMaLoai.DataSource = listLoaiPhong;
                    cmbMaLoai.DisplayMember = "MALOAIPHONG";
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

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text != "" && txtGiaThue.Text != "" && txtMaLoai.Text != "")
            {
                LoaiPhongDTO new_LoaiPhong = new LoaiPhongDTO()
                {
                    MALOAIPHONG = int.Parse(txtMaLoai.Text),
                    TENLOAIPHONG = txtTenLoai.Text,
                    GIATHUE = Convert.ToDecimal(txtGiaThue.Text),
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN LOẠI PHÒNG?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.PhongvaLoaiPhongBUS.suaLoaiPhongBUS(new_LoaiPhong);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN LOẠI PHÒNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSPhong();
                        HienThiDSLoaiPhong();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN LOẠI PHÒNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            List<LoaiPhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachLoaiPhong();
            if (txtMaLoai.Text != "")
            {
                LoaiPhongDTO loaiPhong_Delete = listPhong.FirstOrDefault(p => p.MALOAIPHONG == Convert.ToInt64(txtMaLoai.Text));

                if (loaiPhong_Delete != null)
                {
                    DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.PhongvaLoaiPhongBUS.xoaLoaiPhongBUS(loaiPhong_Delete);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA LOẠI PHÒNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiDSPhong();
                            HienThiDSLoaiPhong();

                            List<LoaiPhongDTO> listLoaiPhong = BUS.PhongvaLoaiPhongBUS.DanhSachLoaiPhong();
                            cmbMaLoai.DataSource = listLoaiPhong;
                            cmbMaLoai.DisplayMember = "MALOAIPHONG";
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY LOẠI PHÒNG!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ LOẠI PHÒNG CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (txtTenPhong.Text != "" && txtTinhTrang.Text != "" && txtSoNguoi.Text != "")
            {
                PhongDTO new_Phong = new PhongDTO()
                {
                    TENPHONG = txtTenPhong.Text,
                    SONGUOITOIDA = int.Parse(txtSoNguoi.Text),
                    TINHTRANG = txtTinhTrang.Text,
                    MALOAIPHONG = int.Parse(cmbMaLoai.Text),
                };

                string ketQua = BUS.PhongvaLoaiPhongBUS.themPhongBUS(new_Phong);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM PHÒNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSPhong();
                    HienThiDSLoaiPhong();
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

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (txtTenPhong.Text != "" && txtTinhTrang.Text != "" && txtSoNguoi.Text != "" && txtMaPhong.Text != "")
            {
                PhongDTO new_Phong = new PhongDTO()
                {
                    MAPHONG = int.Parse(txtMaPhong.Text),
                    TENPHONG = txtTenPhong.Text,
                    SONGUOITOIDA = int.Parse(txtSoNguoi.Text),
                    TINHTRANG = txtTinhTrang.Text,
                    MALOAIPHONG = int.Parse(cmbMaLoai.Text),
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN PHÒNG?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.PhongvaLoaiPhongBUS.suaPhongBUS(new_Phong);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN PHÒNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSPhong();
                        HienThiDSLoaiPhong();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN PHÒNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool kiemTraPhong_phieuDP(int MAPHONG)
        {
            List<PhieuDatPhongDTO> listPhieuDP = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            PhieuDatPhongDTO phieuDatPhong = listPhieuDP.Where(p => p.MAPHONG == MAPHONG).FirstOrDefault();
            if (phieuDatPhong != null)
            {
                return false;
            }
            return true;
        }

        private bool kiemTraPhong_phieuCP(int MAPHONG)
        {
            List<PhieuChuyenPhongDTO> listPhieuCP = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            PhieuChuyenPhongDTO phieuChuyenPhong = listPhieuCP.Where(p => p.MAPHONG == MAPHONG).FirstOrDefault();
            if (phieuChuyenPhong != null)
            {
                return false;
            }
            return true;
        }

        private bool kiemTraPhong_phieuLD(int MAPHONG)
        {
            List<PhieuLapDatDTO> listPhieuLD = BUS.PhieuLapDatBUS.DanhSachPhieuLapDat();
            PhieuLapDatDTO phieuLapDat = listPhieuLD.Where(p => p.MAPHONG == MAPHONG).FirstOrDefault();
            if (phieuLapDat != null)
            {
                return false;
            }
            return true;
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            if (txtMaPhong.Text != "")
            {
                PhongDTO Phong_Delete = listPhong.FirstOrDefault(p => p.MAPHONG == Convert.ToInt32(txtMaPhong.Text));

                if (Phong_Delete != null)
                {
                    if (kiemTraPhong_phieuDP(Phong_Delete.MAPHONG))
                    {
                        if (kiemTraPhong_phieuCP(Phong_Delete.MAPHONG))
                        {
                            if (kiemTraPhong_phieuLD(Phong_Delete.MAPHONG))
                            {
                                DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (re == DialogResult.Yes)
                                {
                                    string ketQua = BUS.PhongvaLoaiPhongBUS.xoaPhongBUS(Phong_Delete);
                                    if (ketQua == "xoathanhcong")
                                    {
                                        MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        HienThiDSPhong();
                                        HienThiDSLoaiPhong();
                                    }
                                    else
                                    {
                                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }   
                            }
                            else
                            {
                                MessageBox.Show("CẦN XÓA PHIẾU LẮP ĐẶT CỦA PHÒNG ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("CẦN XÓA PHIẾU CHUYỂN PHÒNG CỦA PHÒNG ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CẦN XÓA PHIẾU ĐẶT PHÒNG CỦA PHÒNG ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY PHÒNG!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ PHÒNG CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count > 0)
            {
                txtMaPhong.Text = Convert.ToString(dgvPhong.SelectedRows[0].Cells[0].Value);
                txtTenPhong.Text = Convert.ToString(dgvPhong.SelectedRows[0].Cells[1].Value);
                txtSoNguoi.Text = Convert.ToString(dgvPhong.SelectedRows[0].Cells[2].Value);
                txtTinhTrang.Text = Convert.ToString(dgvPhong.SelectedRows[0].Cells[3].Value);
                cmbMaLoai.Text = Convert.ToString(dgvPhong.SelectedRows[0].Cells[4].Value);
            }
        }

        private void dgvLoaiPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.SelectedRows.Count > 0)
            {
                txtMaLoai.Text = Convert.ToString(dgvLoaiPhong.SelectedRows[0].Cells[0].Value);
                txtTenLoai.Text = Convert.ToString(dgvLoaiPhong.SelectedRows[0].Cells[1].Value);
                decimal giaThue = Math.Round(Convert.ToDecimal(dgvLoaiPhong.SelectedRows[0].Cells[2].Value));
                txtGiaThue.Text = Convert.ToString(giaThue);
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

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaLoai.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtGiaThue_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtGiaThue.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPhong.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSoNguoi_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSoNguoi.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

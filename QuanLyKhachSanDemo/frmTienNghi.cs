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
    public partial class frmTienNghi : Form
    {
        public string maPLD;
        public string taiKhoanHienHanh;

        public frmTienNghi()
        {
            InitializeComponent();
        }

        private void frmTienNghi_Load(object sender, EventArgs e)
        {
            hienThiDanhSachLoaiTN();
            hienThiDanhSachTN();
        }

        public void hienThiDanhSachLoaiTN()
        {
            dgvLoaiTN.Rows.Clear();
            List<LoaiTienNghiDTO> listLoaiTN = BUS.TienNghivaLoaiTienNghiBUS.DanhSachLoaiTienNghi();
            foreach (var item in listLoaiTN)
            {
                int index = dgvLoaiTN.Rows.Add();
                dgvLoaiTN.Rows[index].Cells[0].Value = item.MALOAITIENNGHI;
                dgvLoaiTN.Rows[index].Cells[1].Value = item.TENLOAITIENNGHI;
            }
        }

        public void hienThiDanhSachTN()
        {
            dgvTienNghi.Rows.Clear();
            List<TienNghiDTO> listTienNghi = BUS.TienNghivaLoaiTienNghiBUS.DanhSachTienNghi();
            foreach (var item in listTienNghi)
            {
                int index = dgvTienNghi.Rows.Add();
                dgvTienNghi.Rows[index].Cells[0].Value = item.MATIENNGHI;
                dgvTienNghi.Rows[index].Cells[1].Value = item.TENTIENNGHI;
                dgvTienNghi.Rows[index].Cells[2].Value = item.DONVITINH;
                dgvTienNghi.Rows[index].Cells[3].Value = item.DONGIA;
                dgvTienNghi.Rows[index].Cells[4].Value = item.TINHTRANG;
                dgvTienNghi.Rows[index].Cells[5].Value = item.MALOAITIENNGHI;
            }
        }

        private void btnLapPhieuLD_Click(object sender, EventArgs e)
        {
            using (frmPhieuLapDat frmLapDat = new frmPhieuLapDat())
            {
                if (frmLapDat.ShowDialog() == DialogResult.OK)
                {
                    maPLD = frmLapDat.TheValue;
                }
            }
            MessageBox.Show(maPLD);
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiTN.Text != "")
            {
                LoaiTienNghiDTO new_loaiTN = new LoaiTienNghiDTO()
                {
                    TENLOAITIENNGHI = txtTenLoaiTN.Text,
                };
                string ketQua = BUS.TienNghivaLoaiTienNghiBUS.themLoaiTNBUS(new_loaiTN);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM LOẠI TIỆN NGHI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiDanhSachLoaiTN();
                    hienThiDanhSachTN();
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

        private void btnSuaLoaiTN_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiTN.Text != "" && txtMaLoaiTN.Text != "")
            {
                LoaiTienNghiDTO new_loaiDV = new LoaiTienNghiDTO()
                {
                    MALOAITIENNGHI = int.Parse(txtMaLoaiTN.Text),
                    TENLOAITIENNGHI = txtTenLoaiTN.Text,
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN LOẠI TIỆN NGHI?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.TienNghivaLoaiTienNghiBUS.suaLoaiTNBUS(new_loaiDV);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN LOẠI TIỆN NGHI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDanhSachLoaiTN();
                        hienThiDanhSachTN();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN TIỆN NGHI VỤ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaLoaiTN_Click(object sender, EventArgs e)
        {
            List<LoaiTienNghiDTO> listTN = BUS.TienNghivaLoaiTienNghiBUS.DanhSachLoaiTienNghi();
            if (txtMaLoaiTN.Text != "")
            {
                LoaiTienNghiDTO loaiTN_Delete = listTN.FirstOrDefault(p => p.MALOAITIENNGHI == Convert.ToInt64(txtMaLoaiTN.Text));

                if (loaiTN_Delete != null)
                {
                    DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.TienNghivaLoaiTienNghiBUS.xoaLoaiTNBUS(loaiTN_Delete);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA LOẠI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienThiDanhSachLoaiTN();
                            hienThiDanhSachTN();
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY LOẠI TIỆN NGHI!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ LOẠI CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemTN_Click(object sender, EventArgs e)
        {
            if (txtDonViTinh.Text != "" && txtTinhTrang.Text != "" && txtGiaThue.Text != "")
            {
                TienNghiDTO new_TN = new TienNghiDTO()
                {
                    TENTIENNGHI = txtTenTN.Text,
                    DONVITINH = txtDonViTinh.Text,
                    TINHTRANG = txtTinhTrang.Text,
                    DONGIA = decimal.Parse(txtGiaThue.Text),
                    MALOAITIENNGHI = int.Parse(cmbMaLoaiTN.Text),
                };
                string ketQua = BUS.TienNghivaLoaiTienNghiBUS.themTNBUS(new_TN);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM TIỆN NGHI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiDanhSachLoaiTN();
                    hienThiDanhSachTN();
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

        private void btnSuaTN_Click(object sender, EventArgs e)
        {
            if (txtMaTN.Text != "" && txtTenTN.Text != "" && txtDonViTinh.Text != "" && txtTinhTrang.Text != "" && txtGiaThue.Text != "")
            {
                TienNghiDTO new_TN = new TienNghiDTO()
                {
                    MATIENNGHI = int.Parse(txtMaTN.Text),
                    TENTIENNGHI = txtTenTN.Text,
                    DONVITINH = txtDonViTinh.Text,
                    TINHTRANG = txtTinhTrang.Text,
                    DONGIA = decimal.Parse(txtGiaThue.Text),
                    MALOAITIENNGHI = int.Parse(cmbMaLoaiTN.Text),
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN TIỆN NGHI?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.TienNghivaLoaiTienNghiBUS.suaTNBUS(new_TN);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN TIỆN NGHI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDanhSachLoaiTN();
                        hienThiDanhSachTN();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN TIỆN NGHI", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaTN_Click(object sender, EventArgs e)
        {
            List<TienNghiDTO> listTN = BUS.TienNghivaLoaiTienNghiBUS.DanhSachTienNghi();
            if (txtMaTN.Text != "")
            {
                TienNghiDTO TN_Delete = listTN.FirstOrDefault(p => p.MATIENNGHI == Convert.ToInt64(txtMaTN.Text));

                if (TN_Delete != null)
                {
                    DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.TienNghivaLoaiTienNghiBUS.xoaTNBUS(TN_Delete);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA LOẠI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienThiDanhSachLoaiTN();
                            hienThiDanhSachTN();
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY LOẠI TIỆN NGHI!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimTenLoaiTN_TextChanged(object sender, EventArgs e)
        {
             List<LoaiTienNghiDTO> listLoaiTienNghi = BUS.TienNghivaLoaiTienNghiBUS.DanhSachLoaiTienNghi();
             dgvLoaiTN.Rows.Clear();

            List<TienNghiDTO> listTienNghi = BUS.TienNghivaLoaiTienNghiBUS.DanhSachTienNghi();
            dgvTienNghi.Rows.Clear();
            foreach (LoaiTienNghiDTO item in listLoaiTienNghi)
            {
                if (item.TENLOAITIENNGHI.ToString().ToUpper().Contains(txtTimTenLoaiTN.Text.ToUpper()))
                {
                    int index = dgvLoaiTN.Rows.Add();
                    dgvLoaiTN.Rows[index].Cells[0].Value = item.MALOAITIENNGHI;
                    dgvLoaiTN.Rows[index].Cells[1].Value = item.TENLOAITIENNGHI;


                    foreach (TienNghiDTO i in listTienNghi)
                    {
                        if (i.MALOAITIENNGHI.ToString().Contains(item.MALOAITIENNGHI.ToString()))
                        {
                            int indexs = dgvTienNghi.Rows.Add();
                            dgvTienNghi.Rows[indexs].Cells[0].Value = i.MATIENNGHI;
                            dgvTienNghi.Rows[indexs].Cells[1].Value = i.TENTIENNGHI;
                            dgvTienNghi.Rows[indexs].Cells[2].Value = i.DONVITINH;
                            dgvTienNghi.Rows[indexs].Cells[3].Value = i.DONGIA;
                            dgvTienNghi.Rows[indexs].Cells[4].Value = i.TINHTRANG;
                            dgvTienNghi.Rows[indexs].Cells[5].Value = i.MALOAITIENNGHI;
                        }
                    }
                }
            }
        }

        private void txtTimTenTN_TextChanged(object sender, EventArgs e)
        {
            List<TienNghiDTO> listTienNghi = BUS.TienNghivaLoaiTienNghiBUS.DanhSachTienNghi();
            dgvTienNghi.Rows.Clear();
            foreach (TienNghiDTO i in listTienNghi)
            {
                if (i.TENTIENNGHI.ToString().ToUpper().Contains(txtTimTenTN.Text.ToUpper()))
                {
                    int indexs = dgvTienNghi.Rows.Add();
                    dgvTienNghi.Rows[indexs].Cells[0].Value = i.MATIENNGHI;
                    dgvTienNghi.Rows[indexs].Cells[1].Value = i.TENTIENNGHI;
                    dgvTienNghi.Rows[indexs].Cells[2].Value = i.DONVITINH;
                    dgvTienNghi.Rows[indexs].Cells[3].Value = i.DONGIA;
                    dgvTienNghi.Rows[indexs].Cells[4].Value = i.TINHTRANG;
                    dgvTienNghi.Rows[indexs].Cells[5].Value = i.MALOAITIENNGHI;
                }
            }
        }

        private void dgvLoaiTN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiTN.SelectedRows.Count > 0)
            {
                txtMaLoaiTN.Text = Convert.ToString(dgvLoaiTN.SelectedRows[0].Cells[0].Value);
                txtTenLoaiTN.Text = Convert.ToString(dgvLoaiTN.SelectedRows[0].Cells[1].Value);
            }
        }

        private void dgvTienNghi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTienNghi.SelectedRows.Count > 0)
            {
                txtMaTN.Text = Convert.ToString(dgvTienNghi.SelectedRows[0].Cells[0].Value);
                txtTenTN.Text = Convert.ToString(dgvTienNghi.SelectedRows[0].Cells[1].Value);
                txtDonViTinh.Text = Convert.ToString(dgvTienNghi.SelectedRows[0].Cells[2].Value);
                txtGiaThue.Text = Convert.ToString(dgvTienNghi.SelectedRows[0].Cells[3].Value);
                txtTinhTrang.Text = Convert.ToString(dgvTienNghi.SelectedRows[0].Cells[4].Value);
                cmbMaLoaiTN.Text = Convert.ToString(dgvTienNghi.SelectedRows[0].Cells[5].Value);
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

        private void txtMaLoaiTN_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaLoaiTN.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaTN_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaTN.Text) != true)
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
    }
}

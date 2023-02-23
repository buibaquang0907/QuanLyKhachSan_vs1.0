using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace QuanLyKhachSanDemo
{
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        public string taiKhoanHienHanh;

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            hienThiDanhSachLoaiDV();
            hienThiDanhSachDV();
            hienComboBox();
        }

        public void hienThiDanhSachLoaiDV()
        {
            dgvLoaiDV.Rows.Clear();
            List<LoaiDichVuDTO> listLoaiDV = BUS.DichVuvaLoaiDichVuBUS.DanhSachLoaiDichVu();
            foreach (var item in listLoaiDV)
            {
                int index = dgvLoaiDV.Rows.Add();
                dgvLoaiDV.Rows[index].Cells[0].Value = item.MALOAIDICHVU;
                dgvLoaiDV.Rows[index].Cells[1].Value = item.TENLOAIDICHVU;
            }
        }

        public void hienThiDanhSachDV()
        {
            dgvDichVu.Rows.Clear();
            List<DichVuDTO> listDichVu = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();
            foreach (var item in listDichVu)
            {
                int index = dgvDichVu.Rows.Add();
                dgvDichVu.Rows[index].Cells[0].Value = item.MADICHVU;
                dgvDichVu.Rows[index].Cells[1].Value = item.TENDICHVU;
                dgvDichVu.Rows[index].Cells[2].Value = item.DONVITINH;
                dgvDichVu.Rows[index].Cells[3].Value = item.GIATHUEDICHVU;
                dgvDichVu.Rows[index].Cells[4].Value = item.MALOAIDICHVU;
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDV.Text != "")
            {
                LoaiDichVuDTO new_loaiDV = new LoaiDichVuDTO()
                {
                    TENLOAIDICHVU = txtTenLoaiDV.Text,
                };
                string ketQua = BUS.DichVuvaLoaiDichVuBUS.themLoaiDvBUS(new_loaiDV);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM LOẠI DỊCH VỤ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiDanhSachLoaiDV();
                    hienComboBox();
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

        private void btnXoaLoaiDV_Click(object sender, EventArgs e)
        {
            List<LoaiDichVuDTO> listKH = BUS.DichVuvaLoaiDichVuBUS.DanhSachLoaiDichVu();
            if (txtMaLoaiDV.Text != "")
            {
                LoaiDichVuDTO loaiDV_Delete = listKH.FirstOrDefault(p => p.MALOAIDICHVU == Convert.ToInt64(txtMaLoaiDV.Text));

                if (loaiDV_Delete != null)
                {
                    DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.DichVuvaLoaiDichVuBUS.xoaLoaiDvBUS(loaiDV_Delete);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA LOẠI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienThiDanhSachLoaiDV();
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY LOẠI DỊCH VỤ!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ LOẠI CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDV.Text != "" && txtMaLoaiDV.Text != "")
            {
                LoaiDichVuDTO new_loaiDV = new LoaiDichVuDTO()
                {
                    MALOAIDICHVU = int.Parse(txtMaLoaiDV.Text),
                    TENLOAIDICHVU = txtTenLoaiDV.Text,
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN LOẠI DỊCH VỤ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.DichVuvaLoaiDichVuBUS.suaLoaiDvBUS(new_loaiDV);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN LOẠI DỊCH VỤ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDanhSachLoaiDV();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN LOẠI DỊCH VỤ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (txtDonViTinh.Text != "" && txtGiaThue.Text != "" && txtTenDV.Text !="")
            {
                DichVuDTO new_DV = new DichVuDTO()
                {
                    TENDICHVU = txtTenDV.Text,
                    GIATHUEDICHVU = decimal.Parse(txtGiaThue.Text),
                    DONVITINH = txtDonViTinh.Text,
                    MALOAIDICHVU = int.Parse(cmbMaLoaiDV.Text),
                };

                string ketQua = BUS.DichVuvaLoaiDichVuBUS.themDvBUS(new_DV);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM DỊCH VỤ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiDanhSachLoaiDV();
                    hienThiDanhSachDV();
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

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (txtDonViTinh.Text != "" && txtGiaThue.Text != "" && txtTenDV.Text != "" && txtMaDV.Text != "")
            {
                DichVuDTO new_DV = new DichVuDTO()
                {
                    MADICHVU = int.Parse(txtMaDV.Text),
                    TENDICHVU = txtTenDV.Text,
                    GIATHUEDICHVU = decimal.Parse(txtGiaThue.Text),
                    DONVITINH = txtDonViTinh.Text,
                    MALOAIDICHVU = int.Parse(cmbMaLoaiDV.Text),
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN DỊCH VỤ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.DichVuvaLoaiDichVuBUS.suaDvBUS(new_DV);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN DỊCH VỤ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDanhSachLoaiDV();
                        hienThiDanhSachDV();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN DỊCH VỤ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            List<DichVuDTO> listKH = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();
            if (txtMaDV.Text != "")
            {
                DichVuDTO DV_Delete = listKH.FirstOrDefault(p => p.MADICHVU == Convert.ToInt64(txtMaDV.Text));

                if (DV_Delete != null)
                {
                    DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.DichVuvaLoaiDichVuBUS.xoaDvBUS(DV_Delete);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienThiDanhSachLoaiDV();
                            hienThiDanhSachDV();
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY DỊCH VỤ!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ DỊCH VỤ CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimLoaiDV_TextChanged(object sender, EventArgs e)
        {
            List<LoaiDichVuDTO> listLoaiDV = BUS.DichVuvaLoaiDichVuBUS.DanhSachLoaiDichVu();
            dgvLoaiDV.Rows.Clear();

            List<DichVuDTO> listDV = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();
            dgvDichVu.Rows.Clear();
            foreach (LoaiDichVuDTO item in listLoaiDV)
            {
                if (item.TENLOAIDICHVU.ToString().ToUpper().Contains(txtTimLoaiDV.Text.ToUpper()))
                {
                    int index = dgvLoaiDV.Rows.Add();
                    dgvLoaiDV.Rows[index].Cells[0].Value = item.MALOAIDICHVU;
                    dgvLoaiDV.Rows[index].Cells[1].Value = item.TENLOAIDICHVU;

                    foreach (DichVuDTO i in listDV)
                    {
                        if (i.MALOAIDICHVU.ToString().Contains(item.MALOAIDICHVU.ToString()))
                        {
                            int indexs = dgvDichVu.Rows.Add();
                            dgvDichVu.Rows[indexs].Cells[0].Value = i.MADICHVU;
                            dgvDichVu.Rows[indexs].Cells[1].Value = i.TENDICHVU;
                            dgvDichVu.Rows[indexs].Cells[2].Value = i.DONVITINH;
                            dgvDichVu.Rows[indexs].Cells[3].Value = i.GIATHUEDICHVU;
                            dgvDichVu.Rows[indexs].Cells[4].Value = i.MALOAIDICHVU;
                        }
                    }
                }
            }
        }

        private void txtTimTenDichVu_TextChanged(object sender, EventArgs e)
        {
            List<DichVuDTO> listDV = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();
            dgvDichVu.Rows.Clear();

            foreach (DichVuDTO i in listDV)
            {
                if (i.TENDICHVU.ToString().ToUpper().Contains(txtTimTenDichVu.Text.ToUpper()))
                {
                    int indexs = dgvDichVu.Rows.Add();
                    dgvDichVu.Rows[indexs].Cells[0].Value = i.MADICHVU;
                    dgvDichVu.Rows[indexs].Cells[1].Value = i.TENDICHVU;
                    dgvDichVu.Rows[indexs].Cells[2].Value = i.DONVITINH;
                    dgvDichVu.Rows[indexs].Cells[3].Value = i.GIATHUEDICHVU;
                    dgvDichVu.Rows[indexs].Cells[4].Value = i.MALOAIDICHVU;
                }
            }
        }

        private void hienComboBox()
        {
            List<LoaiDichVuDTO> listLoaiDV = BUS.DichVuvaLoaiDichVuBUS.DanhSachLoaiDichVu();

            cmbMaLoaiDV.DataSource = listLoaiDV;
            cmbMaLoaiDV.DisplayMember = "MALOAIDICHVU";
            cmbMaLoaiDV.Text = "";
        }

        private void btnLapPhieuSDDV_Click(object sender, EventArgs e)
        {
            frmPhieuSDDV frmSDDV = new frmPhieuSDDV();
            frmSDDV.taiKhoanHienHanh = taiKhoanHienHanh;
            frmSDDV.ShowDialog();
        }

        private void dgvLoaiDV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiDV.SelectedRows.Count > 0)
            {
                txtMaLoaiDV.Text = Convert.ToString(dgvLoaiDV.SelectedRows[0].Cells[0].Value);
                txtTenLoaiDV.Text = Convert.ToString(dgvLoaiDV.SelectedRows[0].Cells[1].Value);
            }
        }

        private void dgvDichVu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                txtMaDV.Text = Convert.ToString(dgvDichVu.SelectedRows[0].Cells[0].Value);
                txtTenDV.Text = Convert.ToString(dgvDichVu.SelectedRows[0].Cells[1].Value);
                txtDonViTinh.Text = Convert.ToString(dgvDichVu.SelectedRows[0].Cells[2].Value);
                decimal giaThue = Math.Round(Convert.ToDecimal(dgvDichVu.SelectedRows[0].Cells[3].Value));
                txtGiaThue.Text = Convert.ToString(giaThue);
                txtMaLoaiDV.Text = Convert.ToString(dgvDichVu.SelectedRows[0].Cells[4].Value);

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

        private void txtMaLoaiDV_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaLoaiDV.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaDV_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaDV.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

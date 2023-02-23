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
using BUS;
using QuanLyKhachSanDemo;

namespace QuanLyKhachSanDemo
{
    public partial class frmKhachHang : Form
    {
        public long soCCCD = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }

        public void HienThiDSKhachHang()
        {
            dgvKhachHang.Rows.Clear();
            List<KhachHangDTO> listKhachHang = BUS.KhachHangBUS.DanhSachKhachHang();
            foreach (var item in listKhachHang)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.MAKH;
                dgvKhachHang.Rows[index].Cells[1].Value = item.TENKH;
                dgvKhachHang.Rows[index].Cells[2].Value = item.CCCD;
                dgvKhachHang.Rows[index].Cells[3].Value = item.GIOITINH;
                dgvKhachHang.Rows[index].Cells[4].Value = item.DT;
                dgvKhachHang.Rows[index].Cells[5].Value = item.DIACHI;
                dgvKhachHang.Rows[index].Cells[6].Value = item.QUOCTICH;
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
        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                txtMaKH.Text = Convert.ToString(dgvKhachHang.SelectedRows[0].Cells[0].Value);
                txtTenKH.Text = Convert.ToString(dgvKhachHang.SelectedRows[0].Cells[1].Value);
                if (Convert.ToString(dgvKhachHang.SelectedRows[0].Cells[3].Value) == "False")
                {
                    radioNu.Checked = true;
                }
                else
                {
                    radioNam.Checked = true;
                }
                txtCCCD.Text = Convert.ToString(dgvKhachHang.SelectedRows[0].Cells[2].Value);
                txtDiaChi.Text = Convert.ToString(dgvKhachHang.SelectedRows[0].Cells[5].Value);
                txtSDT.Text = Convert.ToString(dgvKhachHang.SelectedRows[0].Cells[4].Value);
                txtQuocTich.Text = Convert.ToString(dgvKhachHang.SelectedRows[0].Cells[6].Value);
            }
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<KhachHangDTO> listKhachHang = BUS.KhachHangBUS.DanhSachKhachHang();
            dgvKhachHang.Rows.Clear();
            foreach (KhachHangDTO item in listKhachHang)
            {
                if (item.CCCD.ToString().Contains(txtTimKiem.Text))
                {
                    int index = dgvKhachHang.Rows.Add();
                    dgvKhachHang.Rows[index].Cells[0].Value = item.MAKH;
                    dgvKhachHang.Rows[index].Cells[1].Value = item.TENKH;
                    dgvKhachHang.Rows[index].Cells[2].Value = item.CCCD;
                    if (item.GIOITINH == false)
                    {
                        dgvKhachHang.Rows[index].Cells[3].Value = "False";
                    }
                    else
                    {
                        dgvKhachHang.Rows[index].Cells[3].Value = "True";

                    }
                    dgvKhachHang.Rows[index].Cells[4].Value = item.DT;
                    dgvKhachHang.Rows[index].Cells[5].Value = item.DIACHI;
                    dgvKhachHang.Rows[index].Cells[6].Value = item.QUOCTICH;
                }
            }
        }

        private bool kiemTraKH_PhieuDP(int maKH)
        {
            List<PhieuDatPhongDTO> listPhieuDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            PhieuDatPhongDTO phieuDP = listPhieuDatPhong.Where(p => Convert.ToInt32(p.MAKH) == maKH).FirstOrDefault();
            if(phieuDP != null )
            {
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<KhachHangDTO> listKH = BUS.KhachHangBUS.DanhSachKhachHang();
            if(txtCCCD.Text != "")
            {
                KhachHangDTO khachHang_Delete = listKH.FirstOrDefault(p => p.CCCD == Convert.ToInt64(txtCCCD.Text));

                if (khachHang_Delete != null)
                {
                    if (kiemTraKH_PhieuDP(khachHang_Delete.MAKH))
                    {
                        DialogResult re = MessageBox.Show("Bạn Có Muốn Xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            string ketQua = BUS.KhachHangBUS.xoaKhachHang(khachHang_Delete);
                            if (ketQua == "xoathanhcong")
                            {
                                MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HienThiDSKhachHang();
                            }
                            else
                            {
                                MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        } 
                    }
                    else
                    {
                        MessageBox.Show("CẦN XÓA PHIẾU ĐẶT PHÒNG CỦA KHÁCH HÀNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY KHÁCH HÀNG!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ CCCD KHÁCH HÀNG CẦN XÓA", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtCCCD.Text != "" && txtQuocTich.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                if (txtSDT.Text.Length == 10 || txtSDT.Text.Length == 11)
                {
                    if (txtCCCD.Text.Length == 12)
                    {
                        KhachHangDTO new_KhachHang = new KhachHangDTO()
                        {
                            TENKH = txtTenKH.Text,
                            CCCD = Convert.ToInt64(txtCCCD.Text),
                            DIACHI = txtDiaChi.Text,
                            QUOCTICH = txtQuocTich.Text,
                            DT = txtSDT.Text,
                            GIOITINH = radioNu.Checked == true ? false : true
                        };
                        string ketQua = BUS.KhachHangBUS.themKhachHang(new_KhachHang);

                        if (ketQua == "themthanhcong")
                        {
                            soCCCD = long.Parse(txtCCCD.Text);
                            MessageBox.Show("THÊM KHÁCH HÀNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiDSKhachHang();
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }  
                    }
                    else
                    {
                        MessageBox.Show("CCCD KHÔNG ĐÚNG ĐỊNH DẠNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtCCCD.Text != "" && txtQuocTich.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                KhachHangDTO new_KhachHang = new KhachHangDTO()
                {
                    MAKH = int.Parse(txtMaKH.Text),
                    TENKH = txtTenKH.Text,
                    CCCD = Convert.ToInt64(txtCCCD.Text),
                    DIACHI = txtDiaChi.Text,
                    QUOCTICH = txtQuocTich.Text,
                    DT = txtSDT.Text,
                    GIOITINH = radioNu.Checked == true ? false : true
                };

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN KHÁCH HÀNG?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.KhachHangBUS.suaKhachHangBUS(new_KhachHang);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN KHÁCH HÀNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSKhachHang();

                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN KHÁCH HÀNG", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public long TheValue  // them code vao click them => tcong
        {
            get
            {
                return soCCCD;
            }
        }


        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaKH.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


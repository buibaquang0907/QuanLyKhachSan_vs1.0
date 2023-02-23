using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanDemo
{
    public partial class frmPhieuLapDat : Form
    {
        public string taiKhoanHienHanh;
        public frmPhieuLapDat()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmPhieuLapDat_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmPhieuLapDat_Load(object sender, EventArgs e)
        {
            hienThiDanhSachPhieuLD();
            hienThiComboBox();
            
        }

        public void hienThiComboBox()
        {
            List<TienNghiDTO> listTienNghi = BUS.TienNghivaLoaiTienNghiBUS.DanhSachTienNghi();
            cmbMaTN.DataSource = listTienNghi;
            cmbMaTN.DisplayMember = "MATIENNGHI";
            cmbMaTN.SelectedIndex = 0;

            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            cmbMaPhong.DataSource = listPhong;
            cmbMaPhong.DisplayMember = "MAPHONG";
            cmbMaPhong.SelectedIndex = 0;
        }

        public void hienThiDanhSachPhieuLD()
        {
            List<PhieuLapDatDTO> listPhieuLapDat = BUS.PhieuLapDatBUS.DanhSachPhieuLapDat();
            foreach (var item in listPhieuLapDat)
            {
                int index = dgvPhieuLapDat.Rows.Add();
                dgvPhieuLapDat.Rows[index].Cells[0].Value = item.MAPHIEULAPDAT;
                dgvPhieuLapDat.Rows[index].Cells[1].Value = item.SOLUONG;
                dgvPhieuLapDat.Rows[index].Cells[2].Value = item.TINHTRANG;
                dgvPhieuLapDat.Rows[index].Cells[3].Value = item.NGAYLAPDAT;
                dgvPhieuLapDat.Rows[index].Cells[4].Value = item.MATIENNGHI;
                dgvPhieuLapDat.Rows[index].Cells[5].Value = item.MAPHONG;
                dgvPhieuLapDat.Rows[index].Cells[6].Value = item.MANHANVIEN;
            }
        }

        public string TheValue
        {
            get { return txtMaPhieuLD.Text; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvPhieuLapDat.Rows.Clear();
            string stringngayLap = dtpNgayLap.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayLap = DateTime.Parse(stringngayLap);

            if (txtSoLuong.Text != "" && txtTinhTrang.Text != "" )
            {
                List<PhieuLapDatDTO> listPhieuLapDat = BUS.PhieuLapDatBUS.DanhSachPhieuLapDat();
                PhieuLapDatDTO phieuLapDat = new PhieuLapDatDTO();

                phieuLapDat.SOLUONG = int.Parse(txtSoLuong.Text);
                phieuLapDat.TINHTRANG = txtTinhTrang.Text;
                phieuLapDat.NGAYLAPDAT = datatimeNgayLap;
                phieuLapDat.MATIENNGHI = Convert.ToInt32(cmbMaTN.Text);
                phieuLapDat.MAPHONG = Convert.ToInt32(cmbMaPhong.Text);

                string ketQua = BUS.PhieuLapDatBUS.themPhieuLapDatBUS(phieuLapDat);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                hienThiDanhSachPhieuLD();
                hienThiComboBox();
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvPhieuLapDat.Rows.Clear();
            string stringngayLap = dtpNgayLap.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayLap = DateTime.Parse(stringngayLap);

            if (txtMaPhieuLD.Text != "" && txtSoLuong.Text != "" && txtTinhTrang.Text != "")
            {
                PhieuLapDatDTO phieuLapDat = new PhieuLapDatDTO();

                phieuLapDat.MAPHIEULAPDAT = int.Parse(txtMaPhieuLD.Text);
                phieuLapDat.SOLUONG = int.Parse(txtSoLuong.Text);
                phieuLapDat.TINHTRANG = txtTinhTrang.Text;
                phieuLapDat.NGAYLAPDAT = datatimeNgayLap;
                phieuLapDat.MATIENNGHI = Convert.ToInt32(cmbMaTN.Text);
                phieuLapDat.MAPHONG = Convert.ToInt32(cmbMaPhong.Text);

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN PHIẾU LẮP ĐẶT?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.PhieuLapDatBUS.suaPhieuLapDatBUS(phieuLapDat);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN PHIẾU LẮP ĐẶT THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    hienThiDanhSachPhieuLD();
                    hienThiComboBox();
                }

            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvPhieuLapDat.Rows.Clear();

            if (txtMaPhieuLD.Text != null)
            {
                List<PhieuLapDatDTO> listPhieuDat = BUS.PhieuLapDatBUS.DanhSachPhieuLapDat();
                if (txtMaPhieuLD.Text != "")
                {
                    PhieuLapDatDTO phieuLapDat = listPhieuDat.FirstOrDefault(p => p.MAPHIEULAPDAT == Int32.Parse(txtMaPhieuLD.Text));
                    if (phieuLapDat != null)
                    {
                        DialogResult re = MessageBox.Show("BẠN CÓ MUỐN XÓA PHIẾU LẮP ĐẶT?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            string ketQua = BUS.PhieuLapDatBUS.xoaPhieuLapDatBUS(phieuLapDat);
                            if (ketQua == "xoathanhcong")
                            {
                                MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                hienThiDanhSachPhieuLD();
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
                        MessageBox.Show("KHÔNG TÌM THẤY PHIẾU LẮP ĐẶT", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }


        private void dgvPhieuLapDat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuLapDat.SelectedRows.Count > 0)
            {
                txtMaPhieuLD.Text = Convert.ToString(dgvPhieuLapDat.SelectedRows[0].Cells[0].Value);
                txtSoLuong.Text = Convert.ToString(dgvPhieuLapDat.SelectedRows[0].Cells[1].Value);
                txtTinhTrang.Text = Convert.ToString(dgvPhieuLapDat.SelectedRows[0].Cells[2].Value);
                dtpNgayLap.Text = Convert.ToString(dgvPhieuLapDat.SelectedRows[0].Cells[3].Value);
                cmbMaTN.Text = Convert.ToString(dgvPhieuLapDat.SelectedRows[0].Cells[4].Value);
                cmbMaPhong.Text = Convert.ToString(dgvPhieuLapDat.SelectedRows[0].Cells[5].Value);
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

        private void txtMaPhieuLD_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPhieuLD.Text) != true)
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
    }
}

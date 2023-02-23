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
    public partial class frmPhieuDenBu : Form
    {
        public int maPKT = 0;
        public frmPhieuDenBu()
        {
            InitializeComponent();
        }

        private void frmPhieuDenBu_Load(object sender, EventArgs e)
        {
            hienThiDanhSachPhieuDB();
            hienThiComboBox();
            txtMaPKT.Text = maPKT.ToString();
        }

        public void hienThiComboBox()
        {
            List<TienNghiDTO> listMaTN = BUS.TienNghivaLoaiTienNghiBUS.DanhSachTienNghi();
            List<int> listMaTN_int = new List<int>(); 

            foreach(var item in listMaTN)
            {
                listMaTN_int.Add(item.MATIENNGHI);
            }

            cmbMaTN.Items.Clear();
            cmbMaTN.DataSource = listMaTN_int;
        }

        public void hienThiDanhSachPhieuDB()
        {
            dgvPhieuDenBu.Rows.Clear();
            List<PhieuDenBuDTO> listPhieuDenBu = BUS.PhieuDenBuBUS.DanhSachPhieuDenBu();
            foreach (var item in listPhieuDenBu)
            {
                int index = dgvPhieuDenBu.Rows.Add();
                dgvPhieuDenBu.Rows[index].Cells[0].Value = item.MAPHIEUDENBU;
                dgvPhieuDenBu.Rows[index].Cells[1].Value = item.NOIDUNG;
                dgvPhieuDenBu.Rows[index].Cells[2].Value = item.TIENPHAT;
                dgvPhieuDenBu.Rows[index].Cells[3].Value = item.NGAYLAPDENBU;
                dgvPhieuDenBu.Rows[index].Cells[4].Value = item.MAPHIEUKIEMTRA;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemDB_Click(object sender, EventArgs e)
        {
            string stringngayLap = dtpNgayLapPhieu.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayLap = DateTime.Parse(stringngayLap);

            if (txtNoiDung.Text != "")
            {
                PhieuDenBuDTO phieuDB = new PhieuDenBuDTO();

                phieuDB.NOIDUNG = txtNoiDung.Text;
                phieuDB.NGAYLAPDENBU = datatimeNgayLap;
                phieuDB.TIENPHAT = Convert.ToDecimal(txtTienPhat.Text);
                phieuDB.MAPHIEUKIEMTRA = maPKT;


                string ketQua = BUS.PhieuDenBuBUS.themPhieuDenBuBUS(phieuDB);

                if (ketQua == "themthanhcong")
                {
                    MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                hienThiDanhSachPhieuDB();
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaDB_Click(object sender, EventArgs e)
        {
            string stringngayDenBu = dtpNgayLapPhieu.Value.ToString("dd-MM-yyyy");
            DateTime datatimeNgayDenBu = DateTime.Parse(stringngayDenBu);


            if (txtNoiDung.Text != "" && txtMaPhieuDB.Text != "" && txtTienPhat.Text != "")
            {
                PhieuDenBuDTO phieuDB = new PhieuDenBuDTO();
                phieuDB.MAPHIEUDENBU = int.Parse(txtMaPhieuDB.Text);
                phieuDB.NOIDUNG = txtNoiDung.Text;
                phieuDB.NGAYLAPDENBU = datatimeNgayDenBu;
                phieuDB.TIENPHAT = Decimal.Parse(txtTienPhat.Text);
                phieuDB.MAPHIEUKIEMTRA = maPKT;

                DialogResult re = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN PHIẾU ĐỀN BÙ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    string ketQua = BUS.PhieuDenBuBUS.suaPhieuDenBuBUS(phieuDB);

                    if (ketQua == "suathanhcong")
                    {
                        MessageBox.Show("SỬA THÔNG TIN PHIẾU ĐỀN BÙ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDanhSachPhieuDB();
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

        private void btnXoaDB_Click(object sender, EventArgs e)
        {
            List<PhieuDenBuDTO> listDenBu = BUS.PhieuDenBuBUS.DanhSachPhieuDenBu();
            if (txtMaPhieuDB.Text != "")
            {
                PhieuDenBuDTO phieuDenBu = listDenBu.FirstOrDefault(p => p.MAPHIEUDENBU == Int32.Parse(txtMaPhieuDB.Text));
                if (phieuDenBu != null)
                {
                    DialogResult re = MessageBox.Show("BẠN CÓ MUỐN XÓA PHIẾU ĐỀN BÙ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (re == DialogResult.Yes)
                    {
                        string ketQua = BUS.PhieuDenBuBUS.xoaPhieuDenBuBUS(phieuDenBu);
                        if (ketQua == "xoathanhcong")
                        {
                            MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienThiDanhSachPhieuDB();
                        }
                        else
                        {
                            MessageBox.Show(ketQua, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY PHIẾU ĐỀN BÙ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ PHIẾU ĐỀN BÙ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaTN_SelectedValueChanged(object sender, EventArgs e)
        {
            List<TienNghiDTO> listTienNghi = BUS.TienNghivaLoaiTienNghiBUS.DanhSachTienNghi();
            int maTN = Convert.ToInt32(cmbMaTN.Text);
            foreach (var item in listTienNghi)
            {
                if (item.MATIENNGHI == maTN)
                {
                    txtTienPhat.Text = item.DONGIA.ToString();
                }
            }
        }

        private void dgvPhieuDenBu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuDenBu.SelectedRows.Count > 0)
            {
                txtMaPhieuDB.Text = Convert.ToString(dgvPhieuDenBu.SelectedRows[0].Cells[0].Value);
                txtNoiDung.Text = Convert.ToString(dgvPhieuDenBu.SelectedRows[0].Cells[1].Value);
                txtTienPhat.Text = Convert.ToString(dgvPhieuDenBu.SelectedRows[0].Cells[2].Value);
                dtpNgayLapPhieu.Text = Convert.ToString(dgvPhieuDenBu.SelectedRows[0].Cells[3].Value);
                txtMaPKT.Text = Convert.ToString(dgvPhieuDenBu.SelectedRows[0].Cells[4].Value);
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

        private void txtMaPhieuDB_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPhieuDB.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaPKT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtMaPKT.Text) != true)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

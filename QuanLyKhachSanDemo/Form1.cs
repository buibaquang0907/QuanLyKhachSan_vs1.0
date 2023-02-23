using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media;
using BUS;
using DTO;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace QuanLyKhachSanDemo
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public string taiKhoanHienHanhFrmMain;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            createArrayButton();
        }

        private void createArrayButton()
        {
            int Top = 3;
            for(int i = 0; i < 4; i++)
            {
                int left = 3;
                for(int j = 0; j < 5; j++)
                {
                    FontAwesome.Sharp.IconButton button = new FontAwesome.Sharp.IconButton();
                    // them thuoc tinh
                    button.Name = string.Format("Phong{0}{1}", i + 1, j + 1);
                    button.Text = string.Format("Phòng {0}{1}", i + 1, j + 1);
                    button.Size = new Size(85, 85);
                    button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.IconChar = IconChar.Home;
                    button.IconSize = 60;
                    button.ImageAlign = ContentAlignment.TopCenter;
                    button.TextAlign = ContentAlignment.BottomCenter;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Top = Top;
                    button.Left = left;

                    left += 90;

                    button.MouseDown += new MouseEventHandler(Button_MouseDown);

                    panelRoom.Controls.Add(button);

                    if (kiemTraTinhTrang(button.Text))
                    {
                        button.BackColor = Color.MediumSpringGreen;
                    }
                    else
                    {
                        button.BackColor = Color.Red;
                    }
                }
                Top += 90;
            }
        }

        private bool kiemTraTinhTrang(string tenPhong)
        {
            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            PhongDTO phong = listPhong.FirstOrDefault(p => p.TENPHONG.Contains(tenPhong));

            if (phong.TINHTRANG == "Bình thường")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string tenPhong = "";

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button bt = (Button) sender;
            if (bt.BackColor == Color.MediumSpringGreen)
            {
                frmDatPhong frmDatPhong = new frmDatPhong();
                frmDatPhong.tenPhong = bt.Text;
                frmDatPhong.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                openChildForm(frmDatPhong);
            }
            else
            {
                tenPhong = bt.Text;
                ctxThanhToanOrDoiPhong.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        // Struct
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(255, 0, 0);
            public static Color color2 = Color.FromArgb(0, 255, 0);
            public static Color color3 = Color.FromArgb(255, 255, 0);
            public static Color color4 = Color.FromArgb(0, 255, 255);
            public static Color color5 = Color.FromArgb(255, 0, 255);
            public static Color color6 = Color.FromArgb(153, 50, 204);
            public static Color color7 = Color.FromArgb(0, 255, 255);
            public static Color color8 = Color.FromArgb(255,140, 0);
        }

        //Methods

        private void activateButton(object senderBtn, Color color)
        {
            disableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 32, 71);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1 || taiKhoanDangNhap.MAPHANQUYEN == 2)
            {
                activateButton(sender, RGBColor.color1);
                frmDatPhong frmDatPhong = new frmDatPhong();
                frmDatPhong.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                openChildForm(frmDatPhong);
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1 || taiKhoanDangNhap.MAPHANQUYEN == 2)
            {
                activateButton(sender, RGBColor.color2);
                openChildForm(new frmKhachHang());
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1 || taiKhoanDangNhap.MAPHANQUYEN == 2 || taiKhoanDangNhap.MAPHANQUYEN == 3)
            {
                activateButton(sender, RGBColor.color3);
                frmThanhToan frmThanhToan = new frmThanhToan();
                frmThanhToan.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                openChildForm(frmThanhToan);
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1)
            {
                activateButton(sender, RGBColor.color4);
                frmNhanVien frmNhanVien = new frmNhanVien();
                openChildForm(frmNhanVien);
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1 || taiKhoanDangNhap.MAPHANQUYEN == 2)
            {
                activateButton(sender, RGBColor.color5);
                frmDichVu frmDichVu = new frmDichVu();
                frmDichVu.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                openChildForm(frmDichVu);
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
             
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1)
            {
                activateButton(sender, RGBColor.color6);
                openChildForm(new frmTaiKhoan());
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1 || taiKhoanDangNhap.MAPHANQUYEN == 3)
            {
                frmThongKe frmThongKe = new frmThongKe();
                frmThongKe.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                openChildForm(frmThongKe);
                activateButton(sender, RGBColor.color7);
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1 || taiKhoanDangNhap.MAPHANQUYEN == 2)
            {
                frmChuyenPhong frmChuyenPhong = new frmChuyenPhong();
                frmChuyenPhong.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                openChildForm(frmChuyenPhong);
                activateButton(sender, RGBColor.color8);

            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconSize = 60;
            iconCurrentChildForm.IconColor = Color.Aqua;
            lblChildForm.Text = "TRANG CHỦ";

            panelDesktop.Controls.Add(groupBox1);
            panelDesktop.Controls.Add(groupBox2);
            panelDesktop.Controls.Add(groupBox3);
            panelDesktop.Controls.Add(groupBox4);
            hienThongTinNhanVien();
            hienThiThongTinPhieuDat();
            hienThiThongTinPhongDenHan();
            createArrayButton();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Anchor = AnchorStyles.None;
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            panelDesktop.BringToFront();
            childForm.Show();
            lblChildForm.Text = childForm.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState= FormWindowState.Normal;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            panelRoom.Controls.Clear();
            Reset();
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1 || taiKhoanDangNhap.MAPHANQUYEN == 2)
            {
                activateButton(sender, RGBColor.color2);

                frmTienNghi frmTienNghi = new frmTienNghi();
                frmTienNghi.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                openChildForm(frmTienNghi);
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hienThongTinNhanVien()
        {
            NhanVienDTO nhanVienDangNhap = BUS.LayThongTinNhanVienDangNhapBUS.ThongTinNhanVienDNBUS(taiKhoanHienHanhFrmMain);
            lblTenNhanVien.Text = nhanVienDangNhap.TENNHANVIEN;
            lblChucVu.Text = nhanVienDangNhap.CHUCVU;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienThongTinNhanVien();
            hienThiThongTinPhieuDat();
            hienThiThongTinPhongDenHan();
        }

        private bool kiemTraPhieuDat_HoaDon(int maPD)
        {
            List<PhieuKiemTraDTO> listPhieuKiemTra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            List<HoaDonDTO> listHoaDon = BUS.ThanhToanBUS.DanhSachHoaDon();
            PhieuKiemTraDTO phieuKiemTra = listPhieuKiemTra.Where(p => p.MAPHIEUDATPHONG == maPD).FirstOrDefault();

            if(phieuKiemTra != null)
            {
                HoaDonDTO hoaDon = listHoaDon.Where(p => p.MAPHIEUKIEMTRA == phieuKiemTra.MAPHIEUKIEMTRA).FirstOrDefault();
                if(hoaDon != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private void hienThiThongTinPhongDenHan()
        {
            List<PhieuDatPhongDTO> listPhieuDatPhongBUS = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            List<PhieuChuyenPhongDTO> listPhieuChuyenPhongBUS = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            List<PhieuDatPhongDTO> listPhieuDatPhong = new List<PhieuDatPhongDTO>();

            foreach (var item in listPhieuDatPhongBUS)
            {
                if (kiemTraPhieuDat_HoaDon(item.MAPHIEUDATPHONG))
                {
                    listPhieuDatPhong.Add(item);
                }
            }

            dgvPhongDenHan.Rows.Clear();
            foreach (var item in listPhieuDatPhong)
            {
                if (item.NGAYTRADUKIEN == DateTime.Today)
                {
                    int index = dgvPhongDenHan.Rows.Add();
                    dgvPhongDenHan.Rows[index].Cells[0].Value = item.MAPHIEUDATPHONG;
                    PhieuChuyenPhongDTO phieuChuyenPhong = listPhieuChuyenPhongBUS.FirstOrDefault(p => p.MAPHIEUDATPHONG == item.MAPHIEUDATPHONG);

                    if (phieuChuyenPhong != null)
                    {
                        dgvPhongDenHan.Rows[index].Cells[1].Value = phieuChuyenPhong.MAPHIEUCHUYENPHONG;
                    }
                    else
                    {
                        dgvPhongDenHan.Rows[index].Cells[1].Value = "NULL";
                    }
                    dgvPhongDenHan.Rows[index].Cells[2].Value = item.MAKH;
                    dgvPhongDenHan.Rows[index].Cells[3].Value = item.NGAYTRADUKIEN; 
                }

            }
        }

        private void hienThiThongTinPhieuDat()
        {
            List<PhieuDatPhongDTO> listPhieuDatPhongBUS= BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            List<PhieuChuyenPhongDTO> listPhieuChuyenPhongBUS= BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();
            List<PhieuSDDVDTO> listPhieuSDDVBUS = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();
            List<PhieuDatPhongDTO> listPhieuDatPhong = new List<PhieuDatPhongDTO>();

            foreach(var item in listPhieuDatPhongBUS)
            {
                if (kiemTraPhieuDat_HoaDon(item.MAPHIEUDATPHONG))
                {
                    listPhieuDatPhong.Add(item);
                }
            }

            dgvThongTinPhieuDat.Rows.Clear();
            foreach (var item in listPhieuDatPhong)
            {
                int index = dgvThongTinPhieuDat.Rows.Add();
                dgvThongTinPhieuDat.Rows[index].Cells[0].Value = item.MAPHIEUDATPHONG;
                dgvThongTinPhieuDat.Rows[index].Cells[1].Value = item.MAKH;

                PhieuChuyenPhongDTO phieuChuyenPhong = listPhieuChuyenPhongBUS.FirstOrDefault(p => p.MAPHIEUDATPHONG == item.MAPHIEUDATPHONG);

                if (phieuChuyenPhong != null)
                {
                    dgvThongTinPhieuDat.Rows[index].Cells[2].Value = phieuChuyenPhong.MAPHIEUCHUYENPHONG;
                }
                else
                {
                    dgvThongTinPhieuDat.Rows[index].Cells[2].Value = "NULL";
                }

                PhieuSDDVDTO phieuSDDV = listPhieuSDDVBUS.FirstOrDefault(p => p.MAPHIEUDATPHONG == item.MAPHIEUDATPHONG);

                if (phieuSDDV != null)
                {
                    dgvThongTinPhieuDat.Rows[index].Cells[3].Value = phieuSDDV.MAPHIEUSDDV;
                }
                else
                {
                    dgvThongTinPhieuDat.Rows[index].Cells[3].Value = "NULL";
                }

                dgvThongTinPhieuDat.Rows[index].Cells[4].Value = item.NGAYNHANPHONG;

            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            DialogResult re = MessageBox.Show("Bạn có muốn đăng xuất?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                activateButton(sender, RGBColor.color6);
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
                this.Hide();
            }
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
            TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanhFrmMain);
            if (taiKhoanDangNhap.MAPHANQUYEN == 1)
            {
                activateButton(sender, RGBColor.color8);
                openChildForm(new frmPhong());
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timerThoiGianThuc_Tick(object sender, EventArgs e)
        {
            lbThoiGianMenu.Text = String.Format(DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void ctxThanhToanOrDoiPhong_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "Thanh Toán")
            {
                frmThanhToan frmThanhToan = new frmThanhToan();
                frmThanhToan.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                frmThanhToan.tenPhong = tenPhong;
                openChildForm(frmThanhToan);
            }else if(e.ClickedItem.Text == "Chuyển Phòng")
            {
                frmChuyenPhong frmChuyenPhong = new frmChuyenPhong();
                frmChuyenPhong.taiKhoanHienHanh = taiKhoanHienHanhFrmMain;
                frmChuyenPhong.tenPhong = tenPhong;
                openChildForm(frmChuyenPhong);
            }
        }
    }
}

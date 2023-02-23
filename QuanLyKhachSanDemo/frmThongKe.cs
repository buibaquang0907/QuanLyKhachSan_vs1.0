using DAL;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanDemo
{
    public partial class frmThongKe : Form
    {
        public string taiKhoanHienHanh;
        private double tongTien = 0;

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            List<ThongKeReport> listReport = BUS.LoadThongke.ThongKe_Data();
            if (rdoNgay.Checked == true)
            {
                List<ThongKeReport> listThongKe_Ngay = listReport.Where(p =>p.NGAYTHANHTOAN.Value.Day == Convert.ToInt16(dtpNgay.Value.Day ) &&
                                                                            p.NGAYTHANHTOAN.Value.Month == Convert.ToInt16(dtpNgay.Value.Month) &&
                                                                            p.NGAYTHANHTOAN.Value.Year == Convert.ToInt16(dtpNgay.Value.Year)).ToList();
                if (listThongKe_Ngay.Count() != 0)
                {
                    foreach (var report in listThongKe_Ngay)
                    {
                        tongTien += Convert.ToDouble(report.TONGTIEN);
                    }

                    List<TaiKhoanDTO> listTaiKhoa = BUS.TaiKhoanBUS.DanhSachTaiKhoan();
                    TaiKhoanDTO taiKhoanDangNhap = listTaiKhoa.FirstOrDefault(p => p.TENDANGNHAP == taiKhoanHienHanh);
                    List<NhanVienDTO> listNhanVien = BUS.NhanVienBUS.DanhSachNhanVien();
                    NhanVienDTO nhanVien = listNhanVien.FirstOrDefault(p => p.MANHANVIEN == taiKhoanDangNhap.MANHANVIEN);

                    ReportParameter[] param = new ReportParameter[3];
                    param[0] = new ReportParameter("tongTien", tongTien.ToString());
                    param[1] = new ReportParameter("ngayLap", DateTime.Today.ToString());
                    param[2] = new ReportParameter("tenNhanVien", nhanVien.TENNHANVIEN);

                    this.reportViewer1.LocalReport.ReportPath = "D:\\TaiLieuDaiHoc\\CNPM-QuanLyKhachSan\\SourceCode\\QuanLyKhachSanDemo\\QuanLyKhachSanDemo\\rptThongkeReport.rdlc";
                    var reportDataSource = new ReportDataSource("ThongKeDataSet", listThongKe_Ngay);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.LocalReport.SetParameters(param);

                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("KHÔNG CÓ HÓA ĐƠN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (rdoThang.Checked == true)
            {
                List<ThongKeReport> listThongKe_Thang = listReport.Where(p => p.NGAYTHANHTOAN.Value.Month == Convert.ToInt16(dtpThang.Value.Month) && p.NGAYTHANHTOAN.Value.Year == Convert.ToInt16(dtpThang.Value.Year)).ToList();

                if (listThongKe_Thang.Count() != 0)
                {
                    foreach (var report in listThongKe_Thang)
                    {
                        tongTien += Convert.ToDouble(report.TONGTIEN);
                    }
                    ReportParameter param = new ReportParameter();
                    param = new ReportParameter("tongTien", tongTien.ToString());
                    this.reportViewer1.LocalReport.ReportPath = "D:\\TaiLieuDaiHoc\\CNPM-QuanLyKhachSan\\SourceCode\\QuanLyKhachSanDemo\\QuanLyKhachSanDemo\\rptThongkeReport.rdlc";
                    var reportDataSource = new ReportDataSource("ThongKeDataSet", listThongKe_Thang);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.LocalReport.SetParameters(param);

                    this.reportViewer1.RefreshReport(); 
                }
                else
                {
                    MessageBox.Show("KHÔNG CÓ HÓA ĐƠN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }   
            else
            {
                List<ThongKeReport> listThongKe_Doan = listReport.Where(p => p.NGAYTHANHTOAN.Value >= dtpKhoang1.Value && p.NGAYTHANHTOAN.Value <= dtpKhoang2.Value).ToList();
                double tongTien = 0;

                if (listThongKe_Doan.Count() != 0)
                {
                    foreach (var report in listThongKe_Doan)
                    {
                        tongTien += Convert.ToDouble(report.TONGTIEN);
                    }
                    ReportParameter param = new ReportParameter();
                    param = new ReportParameter("tongTien", tongTien.ToString());
                    this.reportViewer1.LocalReport.ReportPath = "D:\\TaiLieuDaiHoc\\CNPM-QuanLyKhachSan\\SourceCode\\QuanLyKhachSanDemo\\QuanLyKhachSanDemo\\rptThongkeReport.rdlc";
                    var reportDataSource = new ReportDataSource("ThongKeDataSet", listThongKe_Doan);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.LocalReport.SetParameters(param);

                    this.reportViewer1.RefreshReport(); 
                }
                else
                {
                    MessageBox.Show("KHÔNG CÓ HÓA ĐƠN", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}

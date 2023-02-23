using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoadThongke
    {
        public static List<ThongKeReport> ThongKe_Data() 
        {
            List<HoaDonDTO> listhoaDon = BUS.ThanhToanBUS.DanhSachHoaDon();
            List<NhanVienDTO> listnhanVien = BUS.NhanVienBUS.DanhSachNhanVien();
            List<KhachHangDTO> listKhachHang = BUS.KhachHangBUS.DanhSachKhachHang();
            List<PhongDTO> listPhong = BUS.PhongvaLoaiPhongBUS.DanhSachPhong();
            List<DichVuDTO> listDichVu = BUS.DichVuvaLoaiDichVuBUS.DanhSachDichVu();
            List<PhieuKiemTraDTO> listPhieuKiemtra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            List<PhieuDatPhongDTO> listPhieuDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            List<PhieuSDDVDTO> listPhieuSDDV = BUS.PhieuSDDVBUS.DanhSachPhieuSDDV();

            List<ThongKeReport> listTkeReport = new List<ThongKeReport>();
            foreach(var item in listhoaDon)
            {
                ThongKeReport tKeReport = new ThongKeReport();
                tKeReport.MAHOADON = item.MAHOADON;

                PhieuKiemTraDTO phieuKiem = listPhieuKiemtra.FirstOrDefault(p => Convert.ToInt32(p.MAPHIEUKIEMTRA) == item.MAPHIEUKIEMTRA);
                tKeReport.MANHANVIEN = Convert.ToInt32(phieuKiem.MANHANVIEN);

                NhanVienDTO nhanVien = listnhanVien.FirstOrDefault(p => p.MANHANVIEN == Convert.ToInt32(phieuKiem.MANHANVIEN));
                tKeReport.TENNHANVIEN = nhanVien.TENNHANVIEN;

                PhieuDatPhongDTO phieuDatPhong = listPhieuDatPhong.FirstOrDefault(p => p.MAPHIEUDATPHONG == Convert.ToInt32(phieuKiem.MAPHIEUDATPHONG));
                tKeReport.MAKH = Convert.ToInt32(phieuDatPhong.MAKH);

                KhachHangDTO khachHang = listKhachHang.FirstOrDefault(p => p.MAKH == Convert.ToInt32(phieuDatPhong.MAKH));
                tKeReport.TENKH = khachHang.TENKH;
                tKeReport.MAPHONG = Convert.ToInt32(phieuDatPhong.MAPHONG);
                PhongDTO phong = listPhong.FirstOrDefault(p => p.MAPHONG == Convert.ToInt32(phieuDatPhong.MAPHONG));
                tKeReport.TENPHONG = phong.TENPHONG;
                

                if (phieuKiem.MAPHIEUSDDV != null)
                {
                    PhieuSDDVDTO phieuSDDV = listPhieuSDDV.FirstOrDefault(p => p.MAPHIEUSDDV == Convert.ToInt32(phieuKiem.MAPHIEUSDDV));
                    tKeReport.MADICHVU = Convert.ToInt32(phieuSDDV.MADICHVU);
                    DichVuDTO dichVu = listDichVu.FirstOrDefault(p => p.MADICHVU == Convert.ToInt32(phieuSDDV.MADICHVU));
                    tKeReport.TENDICHVU = dichVu.TENDICHVU;
                }
                else
                {
                    tKeReport.TENDICHVU = null;
                }

                              

                tKeReport.NGAYTHANHTOAN = Convert.ToDateTime(item.NGAYTHANHTOAN);
                tKeReport.TONGTIEN = Convert.ToDecimal( item.TONGTIEN);
                listTkeReport.Add(tKeReport);
            }
            return listTkeReport;
        }
        
    }
}

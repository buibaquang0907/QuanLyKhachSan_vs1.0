using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KiemTraPhongTrongBUS
    {

        

        public static bool KiemTraPhong_PhieuChuyen(int maPhong)
        {
            List<PhieuKiemTraDTO> listKiemTraBUS = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            List<HoaDonDTO> listHoaDonBUS = BUS.ThanhToanBUS.DanhSachHoaDon();
            List<PhieuChuyenPhongDTO> listChuyenPhongBUS = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();

            PhieuKiemTraDTO PhieuKiemTra = new PhieuKiemTraDTO();
            HoaDonDTO HoaDon = new HoaDonDTO();
            PhieuChuyenPhongDTO phieuChuyenPhong = listChuyenPhongBUS.LastOrDefault(p => Convert.ToInt32(p.MAPHONG) == maPhong);

            if (phieuChuyenPhong != null)
            {
                PhieuKiemTra = listKiemTraBUS.LastOrDefault(p => Convert.ToInt32(p.MAPHIEUCHUYENPHONG) == phieuChuyenPhong.MAPHIEUCHUYENPHONG);
            }
            else
            {
                return true;
            }

            if (PhieuKiemTra != null)
            {
                HoaDon = listHoaDonBUS.LastOrDefault(p => Convert.ToInt32(p.MAPHIEUKIEMTRA) == PhieuKiemTra.MAPHIEUKIEMTRA);
                if (HoaDon != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool KiemTraPhongTrong(int maPhong)
        {
            List<PhieuDatPhongDTO> listPhieuDatPhongBUS = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();
            List<PhieuKiemTraDTO> listKiemTraBUS = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            List<HoaDonDTO> listHoaDonBUS = BUS.ThanhToanBUS.DanhSachHoaDon();
            List<PhieuChuyenPhongDTO> listChuyenPhongBUS = BUS.PhieuChuyenPhongBUS.DanhSachPhieuChuyenPhong();

            PhieuDatPhongDTO PhieuDatPhong = listPhieuDatPhongBUS.LastOrDefault(p => Convert.ToInt32(p.MAPHONG) == maPhong);
            PhieuKiemTraDTO PhieuKiemTra = new PhieuKiemTraDTO();
            HoaDonDTO HoaDon = new HoaDonDTO();
            PhieuChuyenPhongDTO phieuChuyenPhong = new PhieuChuyenPhongDTO();


            if (PhieuDatPhong != null)
            {
                //phieuChuyenPhong = listChuyenPhongBUS.LastOrDefault(p => Convert.ToInt32(p.MAPHIEUDATPHONG) == PhieuDatPhong.MAPHIEUDATPHONG);

                //if(phieuChuyenPhong != null)
                //{
                //    return true;
                //}
                //else
                //{
                    PhieuKiemTra = listKiemTraBUS.LastOrDefault(p => p.MAPHIEUDATPHONG == PhieuDatPhong.MAPHIEUDATPHONG);
                //}
                
            }
            else
            {
                return true;
            }

            if (PhieuKiemTra != null)
            {
                HoaDon = listHoaDonBUS.LastOrDefault(p => p.MAPHIEUKIEMTRA == PhieuKiemTra.MAPHIEUKIEMTRA);
                if (HoaDon != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static PhieuDatPhongDTO KiemTraPhong_PhieuDat(int maPhong)
        {
            PhieuDatPhongDTO phieuDatPhong = new PhieuDatPhongDTO();
            List<PhieuDatPhongDTO> listPhieuDatPhong = BUS.PhieuDatPhongBUS.DanhSachPhieuDatPhong();

            foreach(var phieu in listPhieuDatPhong)
            {
                if(phieu.MAPHONG == maPhong)
                {
                    phieuDatPhong = phieu;
                }
            }
            return phieuDatPhong;
        }

        public static PhieuKiemTraDTO KiemTraPhieuDat_PhieuKiemTra(PhieuDatPhongDTO phieuDatPhong)
        {
            List<PhieuKiemTraDTO> listKiemTra = BUS.PhieuKiemTraBUS.DanhSachPhieuKiemTra();
            PhieuKiemTraDTO phieuKiemTra = new PhieuKiemTraDTO();

            foreach (var phieuKT in listKiemTra)
            {
                if (phieuKT.MAPHIEUDATPHONG == phieuDatPhong.MAPHIEUDATPHONG)
                {
                    phieuKiemTra = phieuKT;
                }
            }
            return phieuKiemTra;
        }

        public static HoaDonDTO KiemTraPhieuKiemTra_HoaDon(PhieuKiemTraDTO phieuKiemTra)
        {
            List<HoaDonDTO> listHoaDon = BUS.ThanhToanBUS.DanhSachHoaDon();
            HoaDonDTO hoaDon = new HoaDonDTO();

            foreach (var _hoaDon in listHoaDon)
            {
                if (_hoaDon.MAPHIEUKIEMTRA == phieuKiemTra.MAPHIEUKIEMTRA)
                {
                    hoaDon = _hoaDon;
                }
            }
            return hoaDon;
        }
    }
}

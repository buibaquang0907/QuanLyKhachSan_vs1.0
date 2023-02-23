using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThanhToanBUS
    {
        public static List<HoaDonDTO> DanhSachHoaDon()
        {
            List<HOADON> listHoaDonDAL = DAL.ThanhToanDAL.layDanhSachHoaDon();
            List<HoaDonDTO> listHoaDonDTO = new List<HoaDonDTO>();
            foreach (var item in listHoaDonDAL)
            {
                HoaDonDTO hoaDon = new HoaDonDTO();
                hoaDon.MAHOADON = item.MAHOADON;
                hoaDon.TONGTIEN = item.TONGTIEN;
                hoaDon.NGAYTHANHTOAN = item.NGAYTHANHTOAN;
                hoaDon.MANHANVIEN = item.MANHANVIEN;
                hoaDon.MAPHIEUKIEMTRA = item.MAPHIEUKIEMTRA;

                listHoaDonDTO.Add(hoaDon);
            }
            return listHoaDonDTO;
        }
        public static string themHoaDon(HoaDonDTO hoaDon)
        {
            List<HOADON> listHoaDon = DAL.ThanhToanDAL.layDanhSachHoaDon();
            HOADON kiemtraHD = listHoaDon.FirstOrDefault(p => p.MAPHIEUKIEMTRA == hoaDon.MAPHIEUKIEMTRA);
            try
            {
                if (kiemtraHD == null)
                {
                    HOADON hoaDon_new = new HOADON()
                    {
                        TONGTIEN = hoaDon.TONGTIEN,
                        NGAYTHANHTOAN = hoaDon.NGAYTHANHTOAN,
                        MANHANVIEN = hoaDon.MANHANVIEN,
                        MAPHIEUKIEMTRA = hoaDon.MAPHIEUKIEMTRA,
                    };
                    DAL.ThanhToanDAL.themHoaDonDAL(hoaDon_new);
                    return "themthanhcong";
                }
                else
                {
                    return "Khách hàng đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaHoaDon(HoaDonDTO hoaDon)
        {
            List<HOADON> listThanhToan = DAL.ThanhToanDAL.layDanhSachHoaDon();
            HOADON hoaDon_Delete = listThanhToan.FirstOrDefault(p => p.MAHOADON == hoaDon.MAHOADON);
            try
            {
                ThanhToanDAL.xoaHoaDonDAL(hoaDon_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }
    }
}

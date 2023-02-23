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
    public class KhachHangBUS
    {
        public static List<KhachHangDTO> DanhSachKhachHang()
        {
            List<KHACHHANG> listKhachHangDAL = DAL.KhachHangDAL.layDanhSachKhachHang();
            List<KhachHangDTO> listKhachHangDTO = new List<KhachHangDTO>();
            foreach (var item in listKhachHangDAL)
            {
                KhachHangDTO khachhang = new KhachHangDTO();
                khachhang.MAKH = item.MAKH;
                khachhang.TENKH = item.TENKH;
                khachhang.CCCD = item.CCCD;
                khachhang.GIOITINH = item.GIOITINH;
                khachhang.DIACHI = item.DIACHI;
                khachhang.DT = item.DT;
                khachhang.QUOCTICH = item.QUOCTICH;

                listKhachHangDTO.Add(khachhang);
            }
            return listKhachHangDTO;
        }
        public static string themKhachHang(KhachHangDTO khachHang)
        {
            List<KHACHHANG> listKhachHang = DAL.KhachHangDAL.layDanhSachKhachHang();
            KHACHHANG kiemtraKH = listKhachHang.FirstOrDefault(p => p.CCCD == khachHang.CCCD);
            try
            {
                if (kiemtraKH == null)
                {
                    KHACHHANG khachHang_new = new KHACHHANG()
                    {
                        MAKH = khachHang.MAKH,
                        TENKH = khachHang.TENKH,
                        CCCD = khachHang.CCCD,
                        GIOITINH = khachHang.GIOITINH,
                        DIACHI = khachHang.DIACHI,
                        DT = khachHang.DT,
                        QUOCTICH = khachHang.QUOCTICH,
                    };
                    DAL.KhachHangDAL.themKhachHangDAL(khachHang_new);
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

        public static string xoaKhachHang(KhachHangDTO khachHang)
        {
            List<KHACHHANG> listKH = DAL.KhachHangDAL.layDanhSachKhachHang();
            KHACHHANG khachHang_Delete = listKH.FirstOrDefault(p => p.CCCD == khachHang.CCCD);

            try
            {
                KhachHangDAL.xoaKhachHangDAL(khachHang_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaKhachHangBUS(KhachHangDTO khachHang)
        {
            List<KHACHHANG> listKHDAL = KhachHangDAL.layDanhSachKhachHang();
            KHACHHANG khachHang_KiemTra = listKHDAL.FirstOrDefault(p => p.MAKH == khachHang.MAKH);
            
            if (khachHang_KiemTra != null)
            {
                try
                {
                    khachHang_KiemTra.TENKH = khachHang.TENKH;
                    khachHang_KiemTra.CCCD = khachHang.CCCD;
                    khachHang_KiemTra.DIACHI = khachHang.DIACHI;
                    khachHang_KiemTra.DT = khachHang.DT;
                    khachHang_KiemTra.GIOITINH = khachHang.GIOITINH;

                    DAL.KhachHangDAL.suaKhachHangDAL(khachHang_KiemTra);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }else
            {
                return "khongtimthaykhachhang";
            }
        }
    }
}

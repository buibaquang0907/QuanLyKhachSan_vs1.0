using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class ThanhToanDAL
    {
        public static List<HOADON> layDanhSachHoaDon()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<HOADON> listHoaDon = context.HOADON.ToList();
            return listHoaDon;
        }

        public static void themHoaDonDAL(HOADON hoaDon)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.HOADON.Add(hoaDon);
            context.SaveChanges();
        }

        public static void xoaHoaDonDAL(HOADON hoaDon)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            HOADON hoaDon_Delete = context.HOADON.FirstOrDefault(p => p.MAHOADON == hoaDon.MAHOADON);
            try
            {
                context.HOADON.Remove(hoaDon_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.HOADON.Remove(hoaDon_Delete);
                context.SaveChanges();
            }
        }

        /*
        public static void suaHoaDonDAL(KHACHHANG khachHang)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<KHACHHANG> listKH = context.KHACHHANG.ToList();
            KHACHHANG khachHang_Sua = listKH.FirstOrDefault(p => p.MAKH == khachHang.MAKH);
            khachHang_Sua.TENKH = khachHang.TENKH;
            khachHang_Sua.CCCD = khachHang.CCCD;
            khachHang_Sua.DIACHI = khachHang.DIACHI;
            khachHang_Sua.DT = khachHang.DT;
            khachHang_Sua.GIOITINH = khachHang.GIOITINH;
            context.SaveChanges();
        }
        */
    }
}

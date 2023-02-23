using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace DAL
{
    public  class KhachHangDAL
    {
        public static List<KHACHHANG> layDanhSachKhachHang()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<KHACHHANG> listKhachHangDAL = context.KHACHHANG.ToList();           
            return listKhachHangDAL;
        }

        public static void themKhachHangDAL(KHACHHANG khachHang)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.KHACHHANG.Add(khachHang);
            context.SaveChanges();
        }

        public static  void xoaKhachHangDAL(KHACHHANG khachHang)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            KHACHHANG khachHang_Delete = context.KHACHHANG.FirstOrDefault(p => p.CCCD == khachHang.CCCD);
            try
            {
                context.KHACHHANG.Remove(khachHang_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.KHACHHANG.Remove(khachHang_Delete);
                context.SaveChanges();
            }
        }

        public static void suaKhachHangDAL(KHACHHANG khachHang)
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
    }
}

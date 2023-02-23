using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Data.Entity.Infrastructure;

namespace DAL
{
    public class NhanVienDAL
    {
        public static List<NHANVIEN> layDanhSachNhanVien()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<NHANVIEN> listNhanVienDAL = context.NHANVIEN.ToList();
            return listNhanVienDAL;
        }

        public static void themNhanVienDAL(NHANVIEN nhanVien)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.NHANVIEN.Add(nhanVien);
            context.SaveChanges();
        }

        public static void xoaNhanVienDAL(NHANVIEN nhanVien)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            NHANVIEN nhanVien_Delete = context.NHANVIEN.FirstOrDefault(p => p.CCCD == nhanVien.CCCD);
            try
            {
                context.NHANVIEN.Remove(nhanVien_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.NHANVIEN.Remove(nhanVien_Delete);
                context.SaveChanges();
            }
        }

        public static void suaNhanVienDAL(NHANVIEN nhanVien)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<NHANVIEN> listNV = context.NHANVIEN.ToList();
            NHANVIEN nhanVien_Sua = listNV.FirstOrDefault(p => p.CCCD == nhanVien.CCCD);
            nhanVien_Sua.TENNHANVIEN = nhanVien.TENNHANVIEN;
            nhanVien_Sua.CCCD = nhanVien.CCCD;
            nhanVien_Sua.DIACHI = nhanVien.DIACHI;
            nhanVien_Sua.DT = nhanVien.DT;
            nhanVien_Sua.CHUCVU = nhanVien.CHUCVU;
            context.SaveChanges();
        }
    }
}

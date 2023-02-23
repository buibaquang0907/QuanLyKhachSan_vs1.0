using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;

namespace DAL
{
    public class TaiKhoanvaPhanQuyenDAL
    {
      
        public static TAIKHOAN layTaiKhoanDAL(string tendangnhap)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            TAIKHOAN taikhoandangnhap = context.TAIKHOAN.FirstOrDefault(p => p.TENDANGNHAP == tendangnhap);

            if (taikhoandangnhap != null)
            {
                return taikhoandangnhap;
            }
            else
            {
                return null;
            }
        }
        public static NHANVIEN layNhanVienDAL(string tendangnhap)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            TAIKHOAN taikhoandangnhap = context.TAIKHOAN.FirstOrDefault(p => p.TENDANGNHAP == tendangnhap);
            NHANVIEN nhanVienDangNhap = context.NHANVIEN.FirstOrDefault(p => p.MANHANVIEN == taikhoandangnhap.MANHANVIEN);

            if (nhanVienDangNhap != null)
            {
                return nhanVienDangNhap;
            }
            else
            {
                return null;
            }
        }

        public static List<TAIKHOAN> layDanhSachTaiKhoanDAL()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<TAIKHOAN> listTaiKhoan = context.TAIKHOAN.ToList();
            return listTaiKhoan;
        }

        public static List<PHANQUYEN> layDanhSachPhanQuyenDAL()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHANQUYEN> listPhanQuyen = context.PHANQUYEN.ToList();
            return listPhanQuyen;
        }

        public static void themPhanQuyenDAL(PHANQUYEN quyen)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.PHANQUYEN.Add(quyen);
            context.SaveChanges();
        }

        public static void xoaPhanQuyenDAL(PHANQUYEN quyen)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            PHANQUYEN PQ_Delete = context.PHANQUYEN.FirstOrDefault(p => p.MAPHANQUYEN == quyen.MAPHANQUYEN);
            try
            {
                context.PHANQUYEN.Remove(PQ_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.PHANQUYEN.Remove(PQ_Delete);
                context.SaveChanges();
            }
        }

        public static void suaPhanQuyenDAL(PHANQUYEN quyen)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHANQUYEN> listPhanQuyen = context.PHANQUYEN.ToList(); // gọi list phân quyền

            PHANQUYEN PQ_Sua = listPhanQuyen.FirstOrDefault(p => p.MAPHANQUYEN == quyen.MAPHANQUYEN); // lấy ra quyền cần sửa

            PQ_Sua.TENPHANQUYEN = quyen.TENPHANQUYEN;
            PQ_Sua.QUYENHAN = quyen.QUYENHAN;

            context.SaveChanges();
        }

        public static void themTaiKhoanDAL(TAIKHOAN taiKhoan)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.TAIKHOAN.Add(taiKhoan);
            context.SaveChanges();
        }

        public static void xoaTaiKhoanDAL(TAIKHOAN taiKhoan)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            TAIKHOAN TK_Delete = context.TAIKHOAN.FirstOrDefault(p => p.TENDANGNHAP == taiKhoan.TENDANGNHAP);
            try
            {
                context.TAIKHOAN.Remove(TK_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.TAIKHOAN.Remove(TK_Delete);
                context.SaveChanges();
            }
        }

        public static void suaTaiKhoanDAL(TAIKHOAN taiKhoan)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<TAIKHOAN> listTaiKhoan = context.TAIKHOAN.ToList();
            TAIKHOAN TK_Sua = listTaiKhoan.FirstOrDefault(p => p.TENDANGNHAP == taiKhoan.TENDANGNHAP);
            TK_Sua.MATKHAU = taiKhoan.MATKHAU;
            TK_Sua.MANHANVIEN = taiKhoan.MANHANVIEN;
            TK_Sua.MAPHANQUYEN = taiKhoan.MAPHANQUYEN;
            context.SaveChanges();
        }
    }
}

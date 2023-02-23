using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KiemTraTaiKhoanDataAccess
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
    }
}

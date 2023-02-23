using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuenMatKhauBUS
    {
        public static NhanVienDTO XacNhanMatKhau(string tenDangNhap)
        {
            TAIKHOAN taiKhoan_QuenMatKhau = DAL.TaiKhoanvaPhanQuyenDAL.layTaiKhoanDAL(tenDangNhap);
            List<NhanVienDTO> listNhanVien = BUS.NhanVienBUS.DanhSachNhanVien();
            if (taiKhoan_QuenMatKhau != null)
            {
                NhanVienDTO nhanVien_QuenMatKhau = listNhanVien.FirstOrDefault(p => p.MANHANVIEN == taiKhoan_QuenMatKhau.MANHANVIEN);
                if (nhanVien_QuenMatKhau != null)
                {
                    return nhanVien_QuenMatKhau;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            
        }

    }
}

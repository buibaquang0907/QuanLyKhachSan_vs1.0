using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class LayThongTinNhanVienDangNhapBUS
    {
        public static NhanVienDTO ThongTinNhanVienDNBUS(string tendangnhap)
        {
            NHANVIEN ketquakiemtra = DAL.TaiKhoanvaPhanQuyenDAL.layNhanVienDAL(tendangnhap);
            NhanVienDTO nhanVienDangNhap = new NhanVienDTO();
            try
            {
                if(ketquakiemtra != null)
                {
                    nhanVienDangNhap.MANHANVIEN = ketquakiemtra.MANHANVIEN;
                    nhanVienDangNhap.TENNHANVIEN = ketquakiemtra.TENNHANVIEN;
                    nhanVienDangNhap.NAMSINH = ketquakiemtra.NAMSINH;
                    nhanVienDangNhap.CCCD = ketquakiemtra.CCCD;
                    nhanVienDangNhap.CHUCVU = ketquakiemtra.CHUCVU;
                    nhanVienDangNhap.DIACHI = ketquakiemtra.DIACHI;
                    nhanVienDangNhap.DT = ketquakiemtra.DT;
                    return nhanVienDangNhap;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

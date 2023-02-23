using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;



namespace BUS
{
    public static class KiemTraDangNhapBUS
    {
        public static string KiemTraThongTinTaiKhoan(string tendangnhap, string matkhau)
        {
            TAIKHOAN ketquakiemtra = DAL.TaiKhoanvaPhanQuyenDAL.layTaiKhoanDAL(tendangnhap);
            if (ketquakiemtra != null)
            {
                if(ketquakiemtra.MATKHAU == matkhau)
                {
                    return "thanhcong";
                }
                else
                {
                    return "saimatkhau";
                }
            }
            else
            {
                return "saitendangnhap";
            }
        }
    }
}

using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BUS
{
    public static class TaiKhoanBUS
    {
        public static List<TaiKhoanDTO> DanhSachTaiKhoan()
        {
            List<TAIKHOAN> listTaiKhoanDAL = DAL.TaiKhoanvaPhanQuyenDAL.layDanhSachTaiKhoanDAL();
            List<TaiKhoanDTO> listTaiKhoanBUS = new List<TaiKhoanDTO>();
            foreach (var item in listTaiKhoanDAL)
            {
                TaiKhoanDTO taikhoan = new TaiKhoanDTO();
                taikhoan.TENDANGNHAP = item.TENDANGNHAP;
                taikhoan.MATKHAU = item.MATKHAU;
                taikhoan.MANHANVIEN = item.MANHANVIEN;
                taikhoan.MAPHANQUYEN = item.MAPHANQUYEN;

                listTaiKhoanBUS.Add(taikhoan);
            }
            return listTaiKhoanBUS;
        }

        public static List<PhanQuyenDTO> DanhSachQuyen()
        {
            List<PHANQUYEN> listPhanQuyenDAL = DAL.TaiKhoanvaPhanQuyenDAL.layDanhSachPhanQuyenDAL();
            List<PhanQuyenDTO> listPhanQuyenBUS = new List<PhanQuyenDTO>();
            foreach (var item in listPhanQuyenDAL)
            {
                PhanQuyenDTO quyen = new PhanQuyenDTO();
                quyen.MAPHANQUYEN = item.MAPHANQUYEN;
                quyen.TENPHANQUYEN = item.TENPHANQUYEN;
                quyen.QUYENHAN = item.QUYENHAN;

                listPhanQuyenBUS.Add(quyen);
            }
            return listPhanQuyenBUS;
        }

        public static string themPhanQuyenBUS(PhanQuyenDTO phanQuyen)
        {
            List<PHANQUYEN> listPQ = DAL.TaiKhoanvaPhanQuyenDAL.layDanhSachPhanQuyenDAL();
            PHANQUYEN kiemtraPQ = listPQ.FirstOrDefault(p => p.TENPHANQUYEN == phanQuyen.TENPHANQUYEN);
            try
            {
                if (kiemtraPQ == null)
                {
                    PHANQUYEN PQ_new = new PHANQUYEN()
                    {
                        TENPHANQUYEN = phanQuyen.TENPHANQUYEN,
                        QUYENHAN = phanQuyen.QUYENHAN,
                    };
                    DAL.TaiKhoanvaPhanQuyenDAL.themPhanQuyenDAL(PQ_new);
                    return "themthanhcong";
                }
                else
                {
                    return "Quyền đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaPhanQuyenBUS(PhanQuyenDTO phanQuyen)
        {
            List<PHANQUYEN> listPQ = DAL.TaiKhoanvaPhanQuyenDAL.layDanhSachPhanQuyenDAL();
            PHANQUYEN PQ_Delete = listPQ.FirstOrDefault(p => p.MAPHANQUYEN == phanQuyen.MAPHANQUYEN);

            try
            {
                DAL.TaiKhoanvaPhanQuyenDAL.xoaPhanQuyenDAL(PQ_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaPhanQuyenBUS(PhanQuyenDTO phanQuyen)
        {
            List<PHANQUYEN> listPQ = DAL.TaiKhoanvaPhanQuyenDAL.layDanhSachPhanQuyenDAL();
            PHANQUYEN PQ_Sua = listPQ.FirstOrDefault(p => p.MAPHANQUYEN == phanQuyen.MAPHANQUYEN);

            if (PQ_Sua != null)
            {
                try
                {
                    PQ_Sua.TENPHANQUYEN = phanQuyen.TENPHANQUYEN; // 99 100 => chuyển từ phanquyenDTO => PHANQUYEN của DATABASE
                    PQ_Sua.QUYENHAN = phanQuyen.QUYENHAN;

                    DAL.TaiKhoanvaPhanQuyenDAL.suaPhanQuyenDAL(PQ_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthaytaikhoan";
            }
        }

        public static string themTaiKhoanBUS(TaiKhoanDTO taiKhoan)
        {
            List<TAIKHOAN> listTK = DAL.TaiKhoanvaPhanQuyenDAL.layDanhSachTaiKhoanDAL();
            TAIKHOAN kiemtraTK = listTK.FirstOrDefault(p => p.TENDANGNHAP == taiKhoan.TENDANGNHAP);
            try
            {
                if (kiemtraTK == null)
                {
                    foreach (var item in listTK)
                    {
                        if (taiKhoan.MANHANVIEN == item.MANHANVIEN)
                        {
                            return "nhanviendacotaikhoan";
                        }
                    }

                    TAIKHOAN TK_new = new TAIKHOAN()
                    {
                        TENDANGNHAP = taiKhoan.TENDANGNHAP,
                        MATKHAU = taiKhoan.MATKHAU,
                        MANHANVIEN = taiKhoan.MANHANVIEN,
                        MAPHANQUYEN = taiKhoan.MAPHANQUYEN,
                    };
                    DAL.TaiKhoanvaPhanQuyenDAL.themTaiKhoanDAL(TK_new);
                    return "themthanhcong";
                }
                else
                {
                    return "Tài khoản đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaTaiKhoanBUS(TaiKhoanDTO taiKhoan)
        {
            List<TAIKHOAN> listTK = DAL.TaiKhoanvaPhanQuyenDAL.layDanhSachTaiKhoanDAL();
            TAIKHOAN TK_Delete = listTK.FirstOrDefault(p => p.TENDANGNHAP == taiKhoan.TENDANGNHAP);

            try
            {
                DAL.TaiKhoanvaPhanQuyenDAL.xoaTaiKhoanDAL(TK_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaTaiKhoanBUS(TaiKhoanDTO taiKhoan)
        {
            List<TAIKHOAN> listTK = DAL.TaiKhoanvaPhanQuyenDAL.layDanhSachTaiKhoanDAL();
            TAIKHOAN TK_Sua = listTK.FirstOrDefault(p => p.TENDANGNHAP == taiKhoan.TENDANGNHAP);

            if (TK_Sua != null)
            {
                try
                {
                    TK_Sua.MATKHAU = taiKhoan.MATKHAU; // 99 100 => chuyển từ phanquyenDTO => PHANQUYEN của DATABASE
                    TK_Sua.MANHANVIEN = taiKhoan.MANHANVIEN;
                    TK_Sua.MAPHANQUYEN = taiKhoan.MAPHANQUYEN;

                    DAL.TaiKhoanvaPhanQuyenDAL.suaTaiKhoanDAL(TK_Sua);

                    return "suathanhcong"; 
                  
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthaytaikhoan";
            }
        }
    }
}

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
    public class TienNghivaLoaiTienNghiBUS
    {
        public static List<LoaiTienNghiDTO> DanhSachLoaiTienNghi()
        {
            List<LOAITIENNGHI> listLoaiTienNghiDAL = DAL.TienNghivaLoaiTienNghiDAL.layDanhSachLoaiTienNghi();
            List<LoaiTienNghiDTO> listLoaiTienNghiBUS = new List<LoaiTienNghiDTO>();

            foreach(var item in listLoaiTienNghiDAL)
            {
                LoaiTienNghiDTO loai = new LoaiTienNghiDTO();

                loai.MALOAITIENNGHI = item.MALOAITIENNGHI;
                loai.TENLOAITIENNGHI = item.TENLOAITIENNGHI;

                listLoaiTienNghiBUS.Add(loai);
            }

            return listLoaiTienNghiBUS;
        }
        public static List<TienNghiDTO> DanhSachTienNghi()
        {
            List<TIENNGHI> listTienNghiDAL = DAL.TienNghivaLoaiTienNghiDAL.layDanhSachTienNghi();
            List<TienNghiDTO> listTienNghiBUS = new List<TienNghiDTO>();

            foreach (var item in listTienNghiDAL)
            {
                TienNghiDTO tienNghi = new TienNghiDTO();

                tienNghi.MATIENNGHI = item.MATIENNGHI;
                tienNghi.TENTIENNGHI = item.TENTIENNGHI;
                tienNghi.DONVITINH = item.DONVITINH;
                tienNghi.DONGIA = item.DONGIA;
                tienNghi.TINHTRANG = item.TINHTRANG;
                tienNghi.MALOAITIENNGHI = item.MALOAITIENNGHI;

                listTienNghiBUS.Add(tienNghi);
            }

            return listTienNghiBUS;
        }

        public static string themLoaiTNBUS(LoaiTienNghiDTO loaiTN)
        {
            List<LOAITIENNGHI> listLoaiTN = DAL.TienNghivaLoaiTienNghiDAL.layDanhSachLoaiTienNghi();
            LOAITIENNGHI kiemtraTN = listLoaiTN.FirstOrDefault(p => p.MALOAITIENNGHI == loaiTN.MALOAITIENNGHI);
            try
            {
                if (kiemtraTN == null)
                {
                    LOAITIENNGHI loaiTN_new = new LOAITIENNGHI()
                    {
                        TENLOAITIENNGHI = loaiTN.TENLOAITIENNGHI,
                    };
                    DAL.TienNghivaLoaiTienNghiDAL.themLoaiTienNghiDAL(loaiTN_new);
                    return "themthanhcong";
                }
                else
                {
                    return "Loại tiện nghi đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaLoaiTNBUS(LoaiTienNghiDTO loaiTN)
        {
            List<LOAITIENNGHI> listLoaiTN = DAL.TienNghivaLoaiTienNghiDAL.layDanhSachLoaiTienNghi();
            LOAITIENNGHI loaiTN_Delete = listLoaiTN.FirstOrDefault(p => p.MALOAITIENNGHI == loaiTN.MALOAITIENNGHI);

            try
            {
                DAL.TienNghivaLoaiTienNghiDAL.xoaLoaiTienNghiDAL(loaiTN_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaLoaiTNBUS(LoaiTienNghiDTO loaiTN)
        {
            List<LOAITIENNGHI> listLoaiTN = DAL.TienNghivaLoaiTienNghiDAL.layDanhSachLoaiTienNghi();
            LOAITIENNGHI loaiTN_Sua = listLoaiTN.FirstOrDefault(p => p.MALOAITIENNGHI == loaiTN.MALOAITIENNGHI);

            if (loaiTN_Sua != null)
            {
                try
                {
                    loaiTN_Sua.MALOAITIENNGHI = loaiTN.MALOAITIENNGHI;
                    loaiTN_Sua.TENLOAITIENNGHI = loaiTN.TENLOAITIENNGHI;

                    DAL.TienNghivaLoaiTienNghiDAL.suaLoaiTienNghiDAL(loaiTN_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthayloaitiennghi";
            }
        }

        public static string themTNBUS(TienNghiDTO tienNghi)
        {
            List<TIENNGHI> listTN = DAL.TienNghivaLoaiTienNghiDAL.layDanhSachTienNghi();
            TIENNGHI kiemtraTN = listTN.FirstOrDefault(p => p.TENTIENNGHI == tienNghi.TENTIENNGHI);
            try
            {
                if (kiemtraTN == null)
                {
                    TIENNGHI TN_new = new TIENNGHI()
                    {
                        TENTIENNGHI = tienNghi.TENTIENNGHI,
                        DONVITINH = tienNghi.DONVITINH,
                        DONGIA = tienNghi.DONGIA,
                        TINHTRANG = tienNghi.TINHTRANG,
                        MALOAITIENNGHI = tienNghi.MALOAITIENNGHI,
                    };
                    DAL.TienNghivaLoaiTienNghiDAL.themTienNghiDAL(TN_new);
                    return "themthanhcong";
                }
                else
                {
                    return "Tiện nghi đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaTNBUS(TienNghiDTO tienNghi)
        {
            List<TIENNGHI> listTN = DAL.TienNghivaLoaiTienNghiDAL.layDanhSachTienNghi();
            TIENNGHI TN_Delete = listTN.FirstOrDefault(p => p.MATIENNGHI == tienNghi.MATIENNGHI);

            try
            {
                DAL.TienNghivaLoaiTienNghiDAL.xoaTienNghiDAL(TN_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaTNBUS(TienNghiDTO tienNghi)
        {
            List<TIENNGHI> listTN = DAL.TienNghivaLoaiTienNghiDAL.layDanhSachTienNghi();
            TIENNGHI TN_Sua = listTN.FirstOrDefault(p => p.MATIENNGHI == tienNghi.MATIENNGHI);

            if (TN_Sua != null)
            {
                try
                {
                    TN_Sua.TENTIENNGHI = tienNghi.TENTIENNGHI;
                    TN_Sua.DONVITINH = tienNghi.DONVITINH;
                    TN_Sua.DONGIA = tienNghi.DONGIA;
                    TN_Sua.TINHTRANG = tienNghi.TINHTRANG;
                    TN_Sua.MALOAITIENNGHI = tienNghi.MALOAITIENNGHI;

                    DAL.TienNghivaLoaiTienNghiDAL.suaTienNghiDAL(TN_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthaytiennghien";
            }
        }
    }
}

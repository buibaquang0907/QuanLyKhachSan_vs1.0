using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public static class PhongvaLoaiPhongBUS
    {
        public static List<LoaiPhongDTO> DanhSachLoaiPhong()
        {
            List<LOAIPHONG> listLoaiPhongDAL = DAL.PhongvaLoaiPhongDAL.layDanhSachLoaiPhong();
            List<LoaiPhongDTO> listLoaiPhongBUS = new List<LoaiPhongDTO>();

            foreach(var item in listLoaiPhongDAL)
            {
                LoaiPhongDTO loaiPhong = new LoaiPhongDTO();

                loaiPhong.MALOAIPHONG = item.MALOAIPHONG;
                loaiPhong.TENLOAIPHONG = item.TENLOAIPHONG;
                loaiPhong.GIATHUE = item.GIATHUE;

                listLoaiPhongBUS.Add(loaiPhong);
            }

            return listLoaiPhongBUS;
        }

        public static List<PhongDTO> DanhSachPhong()
        {
            List<PHONG> listPhongDAL = DAL.PhongvaLoaiPhongDAL.layDanhSachPhong();
            List<PhongDTO> listPhongBUS = new List<PhongDTO>();

            foreach (var item in listPhongDAL)
            {
                PhongDTO phong = new PhongDTO();

                phong.MAPHONG = item.MAPHONG;
                phong.TENPHONG = item.TENPHONG;
                phong.SONGUOITOIDA = item.SONGUOITOIDA;
                phong.TINHTRANG = item.TINHTRANG;
                phong.MALOAIPHONG = item.MALOAIPHONG;

                listPhongBUS.Add(phong);
            }

            return listPhongBUS;
        }

        public static string xoaLoaiPhongBUS(LoaiPhongDTO loaiPhong)
        {
            List<LOAIPHONG> listLoaiPhong = DAL.PhongvaLoaiPhongDAL.layDanhSachLoaiPhong();
            LOAIPHONG loaiPhong_Delete = listLoaiPhong.FirstOrDefault(p => p.MALOAIPHONG == loaiPhong.MALOAIPHONG);

            try
            {
                DAL.PhongvaLoaiPhongDAL.xoaLoaiPhongDAL(loaiPhong_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaLoaiPhongBUS(LoaiPhongDTO loaiPhong)
        {
            List<LOAIPHONG> listLoaiPhong = DAL.PhongvaLoaiPhongDAL.layDanhSachLoaiPhong();
            LOAIPHONG loaiPhong_Sua = listLoaiPhong.FirstOrDefault(p => p.MALOAIPHONG == loaiPhong.MALOAIPHONG);

            if (loaiPhong_Sua != null)
            {
                try
                {
                    loaiPhong_Sua.MALOAIPHONG = loaiPhong.MALOAIPHONG;
                    loaiPhong_Sua.TENLOAIPHONG = loaiPhong.TENLOAIPHONG;
                    loaiPhong_Sua.GIATHUE = loaiPhong.GIATHUE;

                    DAL.PhongvaLoaiPhongDAL.suaLoaiPhongDAL(loaiPhong_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "KHÔNG TÌM THẤY LOẠI PHÒNG";
            }
        }

        public static string themLoaiPhongBUS(LoaiPhongDTO loaiPhong)
        {
            List<LOAIPHONG> listLoaiPhong = DAL.PhongvaLoaiPhongDAL.layDanhSachLoaiPhong();
            LOAIPHONG kiemtraLoaiPhong = listLoaiPhong.FirstOrDefault(p => p.TENLOAIPHONG == loaiPhong.TENLOAIPHONG);
            try
            {
                if (kiemtraLoaiPhong == null)
                {
                    LOAIPHONG loaiDV_new = new LOAIPHONG()
                    {
                        TENLOAIPHONG = loaiPhong.TENLOAIPHONG,
                        GIATHUE = loaiPhong.GIATHUE,
                    };
                    DAL.PhongvaLoaiPhongDAL.themLoaiPhongDAL(loaiDV_new);
                    return "themthanhcong";
                }
                else
                {
                    return "LOẠI PHÒNG ĐÃ CÓ TRÊN HỆ THỐNG";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string themPhongBUS(PhongDTO Phong)
        {
            List <PHONG> listPhong = DAL.PhongvaLoaiPhongDAL.layDanhSachPhong();
            PHONG kiemtraPhong = listPhong.FirstOrDefault(p => p.TENPHONG == Phong.TENPHONG);
            try
            {
                if (kiemtraPhong == null)
                {
                    PHONG Phong_new = new PHONG()
                    {
                        TENPHONG = Phong.TENPHONG,
                        SONGUOITOIDA = Phong.SONGUOITOIDA,
                        MALOAIPHONG = Phong.MALOAIPHONG,
                        TINHTRANG = Phong.TINHTRANG,
                    };
                    DAL.PhongvaLoaiPhongDAL.themPhongDAL(Phong_new);
                    return "themthanhcong";
                }
                else
                {
                    return "PHÒNG ĐÃ CÓ TRÊN HỆ THỐNG!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaPhongBUS(PhongDTO Phong)
        {
            List<PHONG> listPhong = DAL.PhongvaLoaiPhongDAL.layDanhSachPhong();
            PHONG Phong_Delete = listPhong.FirstOrDefault(p => p.MAPHONG == Phong.MAPHONG);

            try
            {
                DAL.PhongvaLoaiPhongDAL.xoaPhongDAL(Phong_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaPhongBUS(PhongDTO Phong)
        {
            List<PHONG> listPhong = DAL.PhongvaLoaiPhongDAL.layDanhSachPhong();
            PHONG Phong_Sua = listPhong.FirstOrDefault(p => p.MAPHONG == Phong.MAPHONG);

            if (Phong_Sua != null)
            {
                try
                {
                    Phong_Sua.MAPHONG = Phong.MAPHONG;
                    Phong_Sua.MALOAIPHONG = Phong.MALOAIPHONG;
                    Phong_Sua.TENPHONG = Phong.TENPHONG;
                    Phong_Sua.SONGUOITOIDA = Phong.SONGUOITOIDA;
                    Phong_Sua.TINHTRANG = Phong.TINHTRANG;
                    Phong_Sua.MALOAIPHONG = Phong.MALOAIPHONG;


                    DAL.PhongvaLoaiPhongDAL.suaPhongDAL(Phong_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "KHÔNG TÌM THẤY PHÒNG";
            }
        }
    }
}

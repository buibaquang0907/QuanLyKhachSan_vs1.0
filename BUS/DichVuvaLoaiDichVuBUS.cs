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
    public class DichVuvaLoaiDichVuBUS
    {
        public static List<LoaiDichVuDTO> DanhSachLoaiDichVu()
        {
            List<LOAIDICHVU> listLoaiDichVuDAL = DAL.DichVuvaLoaiDichVuDAL.layDanhSachLoaiDichVu();
            List<LoaiDichVuDTO> listLoaiDichVuBUS = new List<LoaiDichVuDTO>();

            foreach (var item in listLoaiDichVuDAL)
            {
                LoaiDichVuDTO loai = new LoaiDichVuDTO();

                loai.MALOAIDICHVU = item.MALOAIDICHVU;
                loai.TENLOAIDICHVU = item.TENLOAIDICHVU;

                listLoaiDichVuBUS.Add(loai);
            }

            return listLoaiDichVuBUS;
        }
        public static List<DichVuDTO> DanhSachDichVu()
        {
            List<DICHVU> listDichVuDAL = DAL.DichVuvaLoaiDichVuDAL.layDanhSachDichVu();
            List<DichVuDTO> listDichVuBUS = new List<DichVuDTO>();

            foreach (var item in listDichVuDAL)
            {
                DichVuDTO dichVu = new DichVuDTO();

                dichVu.MADICHVU = item.MADICHVU;
                dichVu.TENDICHVU = item.TENDICHVU;
                dichVu.DONVITINH = item.DONVITINH;
                dichVu.GIATHUEDICHVU = item.GIATHUEDICHVU;
                dichVu.MALOAIDICHVU = item.MALOAIDICHVU;

                listDichVuBUS.Add(dichVu);
            }

            return listDichVuBUS;
        }

        public static string themLoaiDvBUS(LoaiDichVuDTO loai)
        {
            List<LOAIDICHVU> listLoaiDV = DAL.DichVuvaLoaiDichVuDAL.layDanhSachLoaiDichVu();
            LOAIDICHVU kiemtraDV = listLoaiDV.FirstOrDefault(p => p.MALOAIDICHVU == loai.MALOAIDICHVU);
            try
            {
                if (kiemtraDV == null)
                {
                    LOAIDICHVU loaiDV_new = new LOAIDICHVU()
                    {
                        TENLOAIDICHVU = loai.TENLOAIDICHVU,
                    };
                    DAL.DichVuvaLoaiDichVuDAL.themLoaiDichVuDAL(loaiDV_new);
                    return "themthanhcong";
                }
                else
                {
                    return "Loại dịch vụ đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaLoaiDvBUS(LoaiDichVuDTO loai)
        {
            List<LOAIDICHVU> listLoaiDV = DAL.DichVuvaLoaiDichVuDAL.layDanhSachLoaiDichVu();
            LOAIDICHVU loaiDV_Delete = listLoaiDV.FirstOrDefault(p => p.MALOAIDICHVU == loai.MALOAIDICHVU);

            try
            {
                DAL.DichVuvaLoaiDichVuDAL.xoaLoaiDichVuDAL(loaiDV_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaLoaiDvBUS(LoaiDichVuDTO loai)
        {
            List<LOAIDICHVU> listLoaiDV = DAL.DichVuvaLoaiDichVuDAL.layDanhSachLoaiDichVu();
            LOAIDICHVU loaiDV_Sua = listLoaiDV.FirstOrDefault(p => p.MALOAIDICHVU == loai.MALOAIDICHVU);

            if (loaiDV_Sua != null)
            {
                try
                {
                    loaiDV_Sua.TENLOAIDICHVU = loai.TENLOAIDICHVU;

                    DAL.DichVuvaLoaiDichVuDAL.suaLoaiDichVuDAL(loaiDV_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthaykhachhang";
            }
        }

        public static string themDvBUS(DichVuDTO dichvu)
        {
            List<DICHVU> listDV = DAL.DichVuvaLoaiDichVuDAL.layDanhSachDichVu();
            DICHVU kiemtraDV = listDV.FirstOrDefault(p => p.MADICHVU == dichvu.MADICHVU);
            try
            {
                if (kiemtraDV == null)
                {
                    DICHVU DV_new = new DICHVU()
                    {
                        TENDICHVU = dichvu.TENDICHVU,
                        GIATHUEDICHVU = dichvu.GIATHUEDICHVU,
                        MADICHVU = dichvu.MADICHVU,
                        DONVITINH = dichvu.DONVITINH,
                        MALOAIDICHVU = dichvu.MALOAIDICHVU,
                    };
                    DAL.DichVuvaLoaiDichVuDAL.themDichVuDAL(DV_new);
                    return "themthanhcong";
                }
                else
                {
                    return "Dịch vụ đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaDvBUS(DichVuDTO dichvu)
        {
            List<DICHVU> listDV = DAL.DichVuvaLoaiDichVuDAL.layDanhSachDichVu();
            DICHVU DV_Delete = listDV.FirstOrDefault(p => p.MADICHVU == dichvu.MADICHVU);

            try
            {
                DAL.DichVuvaLoaiDichVuDAL.xoaDichVuDAL(DV_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaDvBUS(DichVuDTO dichvu)
        {
            List<DICHVU> listDV = DAL.DichVuvaLoaiDichVuDAL.layDanhSachDichVu();
            DICHVU DV_Sua = listDV.FirstOrDefault(p => p.MADICHVU == dichvu.MADICHVU);

            if (DV_Sua != null)
            {
                try
                {
                    DV_Sua.TENDICHVU = dichvu.TENDICHVU;
                    DV_Sua.GIATHUEDICHVU = dichvu.GIATHUEDICHVU;
                    DV_Sua.MADICHVU = dichvu.MADICHVU;
                    DV_Sua.DONVITINH = dichvu.DONVITINH;
                    DV_Sua.MALOAIDICHVU = dichvu.MALOAIDICHVU;


                    DAL.DichVuvaLoaiDichVuDAL.suaDichVuDAL(DV_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthaykhachhang";
            }
        }
    }
}

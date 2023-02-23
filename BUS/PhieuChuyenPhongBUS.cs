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
    public class PhieuChuyenPhongBUS
    {
        public static List<PhieuChuyenPhongDTO> DanhSachPhieuChuyenPhong()
        {
            List<PHIEUCHUYENPHONG> listPhieuChuyenPhong = DAL.PhieuChuyenPhongDAL.layDanhSachPhieuChuyenPhong();
            List<PhieuChuyenPhongDTO> listPhieuChuyenPhongDTO = new List<PhieuChuyenPhongDTO>();

            foreach (var item in listPhieuChuyenPhong)
            {
                PhieuChuyenPhongDTO phieuChuyenPhong = new PhieuChuyenPhongDTO();
                phieuChuyenPhong.MAPHIEUCHUYENPHONG = item.MAPHIEUCHUYENPHONG;
                phieuChuyenPhong.LYDO = item.LYDO;
                phieuChuyenPhong.NGAYCHUYENPHONG = item.NGAYCHUYENPHONG;
                phieuChuyenPhong.MAPHONG = item.MAPHONG;
                phieuChuyenPhong.MAPHIEUDATPHONG = item.MAPHIEUDATPHONG;
                phieuChuyenPhong.MANHANVIEN = item.MANHANVIEN;
                listPhieuChuyenPhongDTO.Add(phieuChuyenPhong);
            }
            return listPhieuChuyenPhongDTO;
        }

        public static string themPhieuChuyenPhongBUS(PhieuChuyenPhongDTO phieuChuyenPhong)
        {
            List<PHIEUCHUYENPHONG> listPhieuChuyenPhong = DAL.PhieuChuyenPhongDAL.layDanhSachPhieuChuyenPhong();
            PHIEUCHUYENPHONG phieuChuyenPhong_them = listPhieuChuyenPhong.FirstOrDefault(p => p.MAPHIEUCHUYENPHONG == phieuChuyenPhong.MAPHIEUCHUYENPHONG);
            try
            {
                if (phieuChuyenPhong_them == null)
                {
                    PHIEUCHUYENPHONG phieuChuyenPhongnew = new PHIEUCHUYENPHONG()
                    {
                        MAPHIEUCHUYENPHONG = phieuChuyenPhong.MAPHIEUCHUYENPHONG,
                        LYDO = phieuChuyenPhong.LYDO,
                        NGAYCHUYENPHONG = phieuChuyenPhong.NGAYCHUYENPHONG,
                        MAPHONG = phieuChuyenPhong.MAPHONG,
                        MAPHIEUDATPHONG = phieuChuyenPhong.MAPHIEUDATPHONG,
                        MANHANVIEN = phieuChuyenPhong.MANHANVIEN,
                    };
                    DAL.PhieuChuyenPhongDAL.themPhieuChuyenPhongDAL(phieuChuyenPhongnew);
                    return "themthanhcong";
                }
                else
                {
                    return "Phiếu chuyển phòng đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaPhieuChuyenPhongBUS(PhieuChuyenPhongDTO phieuChuyenPhong)
        {
            List<PHIEUCHUYENPHONG> listPhieuChuyenPhong = DAL.PhieuChuyenPhongDAL.layDanhSachPhieuChuyenPhong();
            PHIEUCHUYENPHONG phieuChuyenPhong_Delete = listPhieuChuyenPhong.FirstOrDefault(p => p.MAPHIEUCHUYENPHONG == phieuChuyenPhong.MAPHIEUCHUYENPHONG);

            try
            {
                PhieuChuyenPhongDAL.xoaPhieuChuyenPhongDAL(phieuChuyenPhong_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaPhieuChuyenPhongBUS(PhieuChuyenPhongDTO phieuChuyenPhong)
        {
            List<PHIEUCHUYENPHONG> listPhieuChuyenPhong = DAL.PhieuChuyenPhongDAL.layDanhSachPhieuChuyenPhong();
            PHIEUCHUYENPHONG phieuChuyenPhong_Sua = listPhieuChuyenPhong.FirstOrDefault(p => p.MAPHIEUCHUYENPHONG == phieuChuyenPhong.MAPHIEUCHUYENPHONG);

            if (phieuChuyenPhong_Sua != null)
            {
                try
                {
                    phieuChuyenPhong.MAPHIEUCHUYENPHONG = phieuChuyenPhong.MAPHIEUCHUYENPHONG;
                    phieuChuyenPhong_Sua.LYDO = phieuChuyenPhong.LYDO;
                    phieuChuyenPhong_Sua.NGAYCHUYENPHONG = phieuChuyenPhong.NGAYCHUYENPHONG;
                    phieuChuyenPhong_Sua.MAPHONG = phieuChuyenPhong.MAPHONG;
                    phieuChuyenPhong_Sua.MAPHIEUDATPHONG = phieuChuyenPhong.MAPHIEUDATPHONG;
                    phieuChuyenPhong_Sua.MANHANVIEN = phieuChuyenPhong.MANHANVIEN;

                    DAL.PhieuChuyenPhongDAL.suaPhieuChuyenPhongDAL(phieuChuyenPhong_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthayphieudatphong";
            }
        }
    }
}

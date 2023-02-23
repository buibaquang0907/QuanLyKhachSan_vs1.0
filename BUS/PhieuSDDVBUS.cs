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
    public class PhieuSDDVBUS
    {
        public static List<PhieuSDDVDTO> DanhSachPhieuSDDV()
        {
            List<PHIEUSDDV> listPhieuSDDVDAL = DAL.PhieuSDDVDAL.layDanhSachPhieuSDDV();
            List<PhieuSDDVDTO> listPhieuSDDVBUS = new List<PhieuSDDVDTO>();

            foreach (var item in listPhieuSDDVDAL)
            {
                PhieuSDDVDTO phieu = new PhieuSDDVDTO();

                phieu.MAPHIEUSDDV = item.MAPHIEUSDDV;
                phieu.NGAYSUDUNG = item.NGAYSUDUNG;
                phieu.SOLUONG = item.SOLUONG;
                phieu.MANHANVIEN = item.MANHANVIEN;
                phieu.MAPHIEUDATPHONG = item.MAPHIEUDATPHONG;
                phieu.MAPHIEUCHUYENPHONG = item.MAPHIEUCHUYENPHONG;
                phieu.MADICHVU = item.MADICHVU;

                listPhieuSDDVBUS.Add(phieu);
            }

            return listPhieuSDDVBUS;
        }

        public static string themPhieuSDDVBUS(PhieuSDDVDTO phieuSDDV)
        {
            List<PHIEUSDDV> listPhieuSDDV = DAL.PhieuSDDVDAL.layDanhSachPhieuSDDV();
            PHIEUSDDV phieuSDDV_them = listPhieuSDDV.FirstOrDefault(p => p.MAPHIEUSDDV == phieuSDDV.MAPHIEUSDDV);
            try
            {
                if (phieuSDDV_them == null)
                {
                    PHIEUSDDV phieuSDDV_New = new PHIEUSDDV()
                    {
                        NGAYSUDUNG = phieuSDDV.NGAYSUDUNG,
                        SOLUONG = phieuSDDV.SOLUONG,
                        MANHANVIEN = phieuSDDV.MANHANVIEN,
                        MAPHIEUDATPHONG = phieuSDDV.MAPHIEUDATPHONG,
                        MAPHIEUCHUYENPHONG = phieuSDDV.MAPHIEUCHUYENPHONG,
                        MADICHVU = phieuSDDV.MADICHVU,
                    };
                    DAL.PhieuSDDVDAL.themPhieuSDDVDAL(phieuSDDV_New);
                    return "themthanhcong";
                }
                else
                {
                    return "Phiếu Sử dụng dịch vụ đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaPhieuSDDVBUS(PhieuSDDVDTO phieuSDDV)
        {
            List<PHIEUSDDV> listPhieuSDDV = DAL.PhieuSDDVDAL.layDanhSachPhieuSDDV();
            PHIEUSDDV phieuSDDV_Delete = listPhieuSDDV.FirstOrDefault(p => p.MAPHIEUSDDV == phieuSDDV.MAPHIEUSDDV);

            try
            {
                PhieuSDDVDAL.xoaPhieuSDDVDAL(phieuSDDV_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaPhieuSDDVBUS(PhieuSDDVDTO phieuSDDV)
        {
            List<PHIEUSDDV> listPhieuSDDV = DAL.PhieuSDDVDAL.layDanhSachPhieuSDDV();
            PHIEUSDDV phieuSDDV_Sua = listPhieuSDDV.FirstOrDefault(p => p.MAPHIEUSDDV == phieuSDDV.MAPHIEUSDDV);

            if (phieuSDDV_Sua != null)
            {
                try
                {
                    phieuSDDV_Sua.MAPHIEUSDDV = phieuSDDV.MAPHIEUSDDV;
                    phieuSDDV_Sua.MADICHVU = phieuSDDV.MADICHVU;
                    phieuSDDV.NGAYSUDUNG = phieuSDDV.NGAYSUDUNG;
                    phieuSDDV_Sua.SOLUONG = phieuSDDV.SOLUONG;
                    phieuSDDV_Sua.MANHANVIEN = phieuSDDV.MANHANVIEN;
                    phieuSDDV_Sua.MAPHIEUDATPHONG = phieuSDDV.MAPHIEUDATPHONG;
                    phieuSDDV_Sua.MAPHIEUCHUYENPHONG = phieuSDDV.MAPHIEUCHUYENPHONG;
                    phieuSDDV_Sua.MAPHIEUSDDV = phieuSDDV.MAPHIEUSDDV;

                    DAL.PhieuSDDVDAL.suaPhieuSDDVDAL(phieuSDDV_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthayphieukiemtra";
            }
        }
    }
}


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
    public class PhieuKiemTraBUS
    {
        public static List<PhieuKiemTraDTO> DanhSachPhieuKiemTra()
        {
            List<PHIEUKIEMTRA> listPhieuKiemTraDAL = DAL.PhieuKiemTraDAL.layDanhSachPhieuKiemTra();
            List<PhieuKiemTraDTO> listPhieuKiemTraBUS = new List<PhieuKiemTraDTO>();

            foreach (var item in listPhieuKiemTraDAL)
            {
                PhieuKiemTraDTO phieu = new PhieuKiemTraDTO();

                phieu.MAPHIEUKIEMTRA = item.MAPHIEUKIEMTRA;
                phieu.TINHTRANGSAUKIEMTRA = item.TINHTRANGSAUKIEMTRA;
                phieu.NGAYKIEMTRA = item.NGAYKIEMTRA;
                phieu.MANHANVIEN = item.MANHANVIEN;
                phieu.MAPHIEUDATPHONG = item.MAPHIEUDATPHONG;
                phieu.MAPHIEUCHUYENPHONG = item.MAPHIEUCHUYENPHONG;
                phieu.MAPHIEUSDDV = item.MAPHIEUSDDV;

                listPhieuKiemTraBUS.Add(phieu);
            }

            return listPhieuKiemTraBUS;
        }

        public static string themPhieuKiemTraBUS(PhieuKiemTraDTO phieuKiemTra)
        {
            List<PHIEUKIEMTRA> listPhieuLapDat = DAL.PhieuKiemTraDAL.layDanhSachPhieuKiemTra();
            PHIEUKIEMTRA phieuKiemTra_them = listPhieuLapDat.FirstOrDefault(p => p.MAPHIEUKIEMTRA == phieuKiemTra.MAPHIEUKIEMTRA);
            try
            {
                if (phieuKiemTra_them == null)
                {
                    PHIEUKIEMTRA phieuKiemTra_New = new PHIEUKIEMTRA()
                    {
                        TINHTRANGSAUKIEMTRA = phieuKiemTra.TINHTRANGSAUKIEMTRA,
                        NGAYKIEMTRA = phieuKiemTra.NGAYKIEMTRA,
                        MANHANVIEN = phieuKiemTra.MANHANVIEN,
                        MAPHIEUDATPHONG = phieuKiemTra.MAPHIEUDATPHONG,
                        MAPHIEUCHUYENPHONG = phieuKiemTra.MAPHIEUCHUYENPHONG,
                        MAPHIEUSDDV = phieuKiemTra.MAPHIEUSDDV,
                    };
                    DAL.PhieuKiemTraDAL.themPhieuKiemTraDAL(phieuKiemTra_New);
                    return "themthanhcong";
                }
                else
                {
                    return "Phiếu kiểm tra đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaPhieuKiemTraBUS(PhieuKiemTraDTO phieuKiemTra)
        {
            List<PHIEUKIEMTRA> listPhieuKiemTra = DAL.PhieuKiemTraDAL.layDanhSachPhieuKiemTra();
            PHIEUKIEMTRA phieuKiemTra_Delete = listPhieuKiemTra.FirstOrDefault(p => p.MAPHIEUKIEMTRA == phieuKiemTra.MAPHIEUKIEMTRA);

            try
            {
                PhieuKiemTraDAL.xoaPhieuKiemTraDAL(phieuKiemTra_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaPhieuKiemTraBUS(PhieuKiemTraDTO phieuKiemTra)
        {
            List<PHIEUKIEMTRA> listPhieuKiemTra = DAL.PhieuKiemTraDAL.layDanhSachPhieuKiemTra();
            PHIEUKIEMTRA phieuKiemTra_Sua = listPhieuKiemTra.FirstOrDefault(p => p.MAPHIEUKIEMTRA == phieuKiemTra.MAPHIEUKIEMTRA);

            if (phieuKiemTra_Sua != null)
            {
                try
                {
                    phieuKiemTra_Sua.MAPHIEUKIEMTRA = phieuKiemTra.MAPHIEUKIEMTRA;
                    phieuKiemTra_Sua.TINHTRANGSAUKIEMTRA = phieuKiemTra.TINHTRANGSAUKIEMTRA;
                    phieuKiemTra.NGAYKIEMTRA = phieuKiemTra.NGAYKIEMTRA;
                    phieuKiemTra_Sua.MANHANVIEN = phieuKiemTra.MANHANVIEN;
                    phieuKiemTra_Sua.MAPHIEUDATPHONG = phieuKiemTra.MAPHIEUDATPHONG;
                    phieuKiemTra_Sua.MAPHIEUCHUYENPHONG = phieuKiemTra.MAPHIEUCHUYENPHONG;
                    phieuKiemTra_Sua.MAPHIEUSDDV = phieuKiemTra.MAPHIEUSDDV;

                    DAL.PhieuKiemTraDAL.suaPhieuKiemTraDAL(phieuKiemTra_Sua);

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

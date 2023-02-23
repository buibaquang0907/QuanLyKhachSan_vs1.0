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
    public class PhieuLapDatBUS
    {
        public static List<PhieuLapDatDTO> DanhSachPhieuLapDat()
        {
            List<PHIEULAPDAT> listPhieuLapDatDAL = DAL.PhieuLapDatDAL.layDanhSachPhieuLapDat();
            List<PhieuLapDatDTO> listPhieuLapDatBUS = new List<PhieuLapDatDTO>();

            foreach (var item in listPhieuLapDatDAL)
            {
                PhieuLapDatDTO phieu = new PhieuLapDatDTO();

                phieu.MAPHIEULAPDAT = item.MAPHIEULAPDAT;
                phieu.SOLUONG = item.SOLUONG;
                phieu.TINHTRANG = item.TINHTRANG;
                phieu.NGAYLAPDAT = item.NGAYLAPDAT;
                phieu.MATIENNGHI = item.MATIENNGHI;
                phieu.MAPHONG = item.MAPHONG;
                phieu.MANHANVIEN = item.MANHANVIEN;

                listPhieuLapDatBUS.Add(phieu);
            }

            return listPhieuLapDatBUS;
        }

        public static string themPhieuLapDatBUS(PhieuLapDatDTO phieuLapDat)
        {
            List<PHIEULAPDAT> listPhieuLapDat = DAL.PhieuLapDatDAL.layDanhSachPhieuLapDat();
            PHIEULAPDAT phieuLapDat_them = listPhieuLapDat.FirstOrDefault(p => p.MAPHIEULAPDAT == phieuLapDat.MAPHIEULAPDAT);
            try
            {
                if (phieuLapDat_them == null)
                {
                    PHIEULAPDAT phieulapDatnew = new PHIEULAPDAT()
                    {
                        MAPHIEULAPDAT = phieuLapDat.MAPHIEULAPDAT,
                        SOLUONG = phieuLapDat.SOLUONG,
                        TINHTRANG = phieuLapDat.TINHTRANG,
                        NGAYLAPDAT = phieuLapDat.NGAYLAPDAT,
                        MATIENNGHI = phieuLapDat.MATIENNGHI,
                        MAPHONG = phieuLapDat.MAPHONG,
                        MANHANVIEN = phieuLapDat.MANHANVIEN,
                    };
                    DAL.PhieuLapDatDAL.themPhieuLapDatDAL(phieulapDatnew);
                    return "themthanhcong";
                }
                else
                {
                    return "Phiếu lắp đặt đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaPhieuLapDatBUS(PhieuLapDatDTO phieuLapDat)
        {
            List<PHIEULAPDAT> listPhieuLapDat = DAL.PhieuLapDatDAL.layDanhSachPhieuLapDat();
            PHIEULAPDAT phieuLapDat_Delete = listPhieuLapDat.FirstOrDefault(p => p.MAPHIEULAPDAT == phieuLapDat.MAPHIEULAPDAT);

            try
            {
                PhieuLapDatDAL.xoaPhieuLapDatDAL(phieuLapDat_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaPhieuLapDatBUS(PhieuLapDatDTO phieuLapDat)
        {
            List<PHIEULAPDAT> listPhieuLapDat = DAL.PhieuLapDatDAL.layDanhSachPhieuLapDat();
            PHIEULAPDAT phieuLapDat_Sua = listPhieuLapDat.FirstOrDefault(p => p.MAPHIEULAPDAT == phieuLapDat.MAPHIEULAPDAT);

            if (phieuLapDat_Sua != null)
            {
                try
                {
                    phieuLapDat_Sua.MAPHIEULAPDAT = phieuLapDat.MAPHIEULAPDAT;
                    phieuLapDat_Sua.SOLUONG = phieuLapDat.SOLUONG;
                    phieuLapDat_Sua.TINHTRANG = phieuLapDat.TINHTRANG;
                    phieuLapDat_Sua.NGAYLAPDAT = phieuLapDat.NGAYLAPDAT;
                    phieuLapDat_Sua.MATIENNGHI = phieuLapDat.MATIENNGHI;
                    phieuLapDat_Sua.MAPHONG = phieuLapDat.MAPHONG;
                    phieuLapDat_Sua.MANHANVIEN = phieuLapDat.MANHANVIEN;

                    DAL.PhieuLapDatDAL.suaPhieuLapDatDAL(phieuLapDat_Sua);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthayphieulapdat";
            }
        }
    }
}

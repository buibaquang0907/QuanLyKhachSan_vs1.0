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
    public class PhieuDenBuBUS
    {
        public static List<PhieuDenBuDTO> DanhSachPhieuDenBu()
        {
            List<PHIEUDENBU> listPhieuDenBuDAL = DAL.PhieuDenBuDAL.layDanhSachPhieuDenBu();
            List<PhieuDenBuDTO> listPhieuDenBuBUS = new List<PhieuDenBuDTO>();

            foreach (var item in listPhieuDenBuDAL)
            {
                PhieuDenBuDTO phieu = new PhieuDenBuDTO();

                phieu.MAPHIEUDENBU = item.MAPHIEUDENBU;
                phieu.NOIDUNG = item.NOIDUNG;
                phieu.NGAYLAPDENBU = item.NGAYLAPDENBU;
                phieu.TIENPHAT = item.TIENPHAT;
                phieu.MAPHIEUKIEMTRA = item.MAPHIEUKIEMTRA;

                listPhieuDenBuBUS.Add(phieu);
            }

            return listPhieuDenBuBUS;
        }

        public static string themPhieuDenBuBUS(PhieuDenBuDTO phieuDenBu)
        {
            List<PHIEUDENBU> listPhieuDenBu = DAL.PhieuDenBuDAL.layDanhSachPhieuDenBu();
            PHIEUDENBU phieuDenBu_them = listPhieuDenBu.FirstOrDefault(p => p.MAPHIEUDENBU == phieuDenBu.MAPHIEUDENBU);
            try
            {
                if (phieuDenBu_them == null)
                {
                    PHIEUDENBU phieuDenBu_New = new PHIEUDENBU()
                    {
                        MAPHIEUDENBU = phieuDenBu.MAPHIEUDENBU,
                        NOIDUNG = phieuDenBu.NOIDUNG,
                        NGAYLAPDENBU = phieuDenBu.NGAYLAPDENBU,
                        TIENPHAT = phieuDenBu.TIENPHAT,
                        MAPHIEUKIEMTRA = phieuDenBu.MAPHIEUKIEMTRA,
                    };
                    DAL.PhieuDenBuDAL.themPhieuDenBuDAL(phieuDenBu_New);
                    return "themthanhcong";
                }
                else
                {
                    return "Phiếu đền bù đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaPhieuDenBuBUS(PhieuDenBuDTO phieuDenBu)
        {
            List<PHIEUDENBU> listPhieuDenBu = DAL.PhieuDenBuDAL.layDanhSachPhieuDenBu();
            PHIEUDENBU phieuDenBu_Delete = listPhieuDenBu.FirstOrDefault(p => p.MAPHIEUDENBU == phieuDenBu.MAPHIEUDENBU);

            try
            {
                PhieuDenBuDAL.xoaPhieuDenBuDAL(phieuDenBu_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaPhieuDenBuBUS(PhieuDenBuDTO phieuDenBu)
        {
            List<PHIEUDENBU> listPhieuDenBu = DAL.PhieuDenBuDAL.layDanhSachPhieuDenBu();
            PHIEUDENBU phieuDenBu_Sua = listPhieuDenBu.FirstOrDefault(p => p.MAPHIEUDENBU == phieuDenBu.MAPHIEUDENBU);

            if (phieuDenBu_Sua != null)
            {
                try
                {
                    phieuDenBu_Sua.MAPHIEUDENBU = phieuDenBu.MAPHIEUDENBU;
                    phieuDenBu_Sua.NOIDUNG = phieuDenBu.NOIDUNG;
                    phieuDenBu_Sua.NGAYLAPDENBU = phieuDenBu.NGAYLAPDENBU;
                    phieuDenBu_Sua.TIENPHAT = phieuDenBu.TIENPHAT;
                    phieuDenBu_Sua.MAPHIEUKIEMTRA = phieuDenBu.MAPHIEUKIEMTRA;

                    DAL.PhieuDenBuDAL.suaPhieuDenBuDAL(phieuDenBu_Sua);

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

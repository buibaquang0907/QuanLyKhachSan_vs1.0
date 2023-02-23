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
    public class PhieuDatPhongBUS
    {
        public static List<PhieuDatPhongDTO> DanhSachPhieuDatPhong()
        {
            List<PHIEUDATPHONG> listPhieuDatPhongDAL = DAL.PhieuDatPhongDAL.layDanhSachPhieuDatPhong();
            List<PhieuDatPhongDTO> listPhieuDatPhongBUS = new List<PhieuDatPhongDTO>();

            foreach (var item in listPhieuDatPhongDAL)
            {
                PhieuDatPhongDTO phieuDatPhong = new PhieuDatPhongDTO();

                phieuDatPhong.MAPHIEUDATPHONG = item.MAPHIEUDATPHONG;
                phieuDatPhong.SONGUOI = item.SONGUOI;
                phieuDatPhong.NGAYNHANPHONG = item.NGAYNHANPHONG;
                phieuDatPhong.NGAYTRADUKIEN = item.NGAYTRADUKIEN;
                phieuDatPhong.TIENCOC = item.TIENCOC;
                phieuDatPhong.MAPHONG = item.MAPHONG;
                phieuDatPhong.MAKH = item.MAKH;
                phieuDatPhong.MANHANVIEN = item.MANHANVIEN;

                listPhieuDatPhongBUS.Add(phieuDatPhong);
            }

            return listPhieuDatPhongBUS;
        }

        public static string themPhieuDatPhongBUS(PhieuDatPhongDTO phieuDat)
        {
            List<PHIEUDATPHONG> listPhieuDatPhongDAL = DAL.PhieuDatPhongDAL.layDanhSachPhieuDatPhong();
            PHIEUDATPHONG phieuDatPhong = new PHIEUDATPHONG()
            {
                SONGUOI = phieuDat.SONGUOI,
                NGAYNHANPHONG = phieuDat.NGAYNHANPHONG,
                NGAYTRADUKIEN = phieuDat.NGAYTRADUKIEN,
                TIENCOC = phieuDat.TIENCOC,
                MAPHONG = phieuDat.MAPHONG,
                MAKH = phieuDat.MAKH,
                MANHANVIEN = phieuDat.MANHANVIEN,
            };
            try
            {
                PhieuDatPhongDAL.themPhieuDatPhongDAL(phieuDatPhong);
                return "thanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string xoaPhieuDatPhongBUS(PhieuDatPhongDTO phieuDat)
        {
            List<PHIEUDATPHONG> listPhieuDatPhongDAL = DAL.PhieuDatPhongDAL.layDanhSachPhieuDatPhong();
            PHIEUDATPHONG phieuDatPhong = listPhieuDatPhongDAL.FirstOrDefault(p => p.MAPHIEUDATPHONG == phieuDat.MAPHIEUDATPHONG);

            try
            {
                PhieuDatPhongDAL.xoaPhieuDatPhongDAL(phieuDatPhong);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

    }
}

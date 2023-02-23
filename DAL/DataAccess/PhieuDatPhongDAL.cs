using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDatPhongDAL
    {
        public static List<PHIEUDATPHONG> layDanhSachPhieuDatPhong()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUDATPHONG> listPhieuDatPhong = context.PHIEUDATPHONG.ToList();
            return listPhieuDatPhong;
        }

        public static void themPhieuDatPhongDAL(PHIEUDATPHONG phieuDat)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.PHIEUDATPHONG.Add(phieuDat);
            context.SaveChanges();
        }
        //public static void suaPhieuDatPhongDAL(PHIEUDATPHONG phieuDat)
        //{
        //    KhachSanDBContext context = new KhachSanDBContext();
        //    List<PHIEUDATPHONG> listPhieuDatPhong = context.PHIEUDATPHONG.ToList();
        //    PHIEUDATPHONG suaPhieuDat = listPhieuDatPhong.FirstOrDefault(p => p.MAPHIEUDATPHONG == phieuDat.MAPHIEUDATPHONG);

        //    if (suaPhieuDat != null)
        //    {
        //        suaPhieuDat.SONGUOI = phieuDat.SONGUOI;
        //        suaPhieuDat.NGAYNHANPHONG = phieuDat.NGAYNHANPHONG;
        //        suaPhieuDat.NGAYTRADUKIEN = phieuDat.NGAYTRADUKIEN;
        //        suaPhieuDat.TIENCOC = phieuDat.TIENCOC;
        //        suaPhieuDat.MAPHONG = phieuDat.MAPHONG;
        //        suaPhieuDat.MAKH = phieuDat.MAKH;
        //        suaPhieuDat.MANHANVIEN = phieuDat.MANHANVIEN; 
        //    }
        //    context.SaveChanges();
        //}
        public static void xoaPhieuDatPhongDAL(PHIEUDATPHONG phieuDat)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            PHIEUDATPHONG phieuDatPhong = context.PHIEUDATPHONG.FirstOrDefault(p => p.MAPHIEUDATPHONG == phieuDat.MAPHIEUDATPHONG);
            try
            {
                context.PHIEUDATPHONG.Remove(phieuDatPhong);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.PHIEUDATPHONG.Remove(phieuDatPhong);
                context.SaveChanges();
            }
        }
    }
}

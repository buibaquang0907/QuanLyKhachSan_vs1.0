using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuLapDatDAL
    {
        public static List<PHIEULAPDAT> layDanhSachPhieuLapDat()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEULAPDAT> listPhieuLapDat = context.PHIEULAPDAT.ToList();
            return listPhieuLapDat;
        }

        public static void themPhieuLapDatDAL(PHIEULAPDAT phieuLapDat)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.PHIEULAPDAT.Add(phieuLapDat);
            context.SaveChanges();
        }

        public static void xoaPhieuLapDatDAL(PHIEULAPDAT phieuLapDat)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            PHIEULAPDAT phieuLapDat_Delete = context.PHIEULAPDAT.FirstOrDefault(p => p.MAPHIEULAPDAT == phieuLapDat.MAPHIEULAPDAT);
            try
            {
                context.PHIEULAPDAT.Remove(phieuLapDat_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.PHIEULAPDAT.Remove(phieuLapDat_Delete);
                context.SaveChanges();
            }
        }

        public static void suaPhieuLapDatDAL(PHIEULAPDAT phieuLapDat)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEULAPDAT> listPhieuDat = context.PHIEULAPDAT.ToList();
            PHIEULAPDAT phieuLapDat_Sua = listPhieuDat.FirstOrDefault(p => p.MAPHIEULAPDAT == phieuLapDat.MAPHIEULAPDAT);
            phieuLapDat_Sua.MAPHIEULAPDAT = phieuLapDat.MAPHIEULAPDAT;
            phieuLapDat_Sua.SOLUONG = phieuLapDat.SOLUONG;
            phieuLapDat_Sua.TINHTRANG = phieuLapDat.TINHTRANG;
            phieuLapDat_Sua.NGAYLAPDAT = phieuLapDat.NGAYLAPDAT;
            phieuLapDat_Sua.MATIENNGHI = phieuLapDat.MATIENNGHI;
            phieuLapDat_Sua.MAPHONG = phieuLapDat.MAPHONG;
            phieuLapDat_Sua.MANHANVIEN = phieuLapDat.MANHANVIEN;

            context.SaveChanges();
        }
    }
}

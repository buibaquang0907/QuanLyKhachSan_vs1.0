using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDenBuDAL
    {
        public static List<PHIEUDENBU> layDanhSachPhieuDenBu()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUDENBU> listPhieuDenBu = context.PHIEUDENBU.ToList();
            return listPhieuDenBu;
        }

        public static void themPhieuDenBuDAL(PHIEUDENBU phieuDenBu)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.PHIEUDENBU.Add(phieuDenBu);
            context.SaveChanges();
        }

        public static void suaPhieuDenBuDAL(PHIEUDENBU phieuDenBu)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUDENBU> listDB = context.PHIEUDENBU.ToList();
            PHIEUDENBU phieuDenBu_Sua = listDB.FirstOrDefault(p => p.MAPHIEUDENBU == phieuDenBu.MAPHIEUDENBU);

            phieuDenBu_Sua.MAPHIEUDENBU = phieuDenBu.MAPHIEUDENBU;
            phieuDenBu_Sua.NOIDUNG = phieuDenBu.NOIDUNG;
            phieuDenBu_Sua.NGAYLAPDENBU = phieuDenBu.NGAYLAPDENBU;
            phieuDenBu_Sua.TIENPHAT = phieuDenBu.TIENPHAT;
            phieuDenBu_Sua.MAPHIEUKIEMTRA = phieuDenBu.MAPHIEUKIEMTRA;
            context.SaveChanges();
        }

        public static void xoaPhieuDenBuDAL(PHIEUDENBU phieuDenBu)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            PHIEUDENBU phieuDen = context.PHIEUDENBU.FirstOrDefault(p => p.MAPHIEUDENBU == phieuDenBu.MAPHIEUDENBU);
            try
            {
                context.PHIEUDENBU.Remove(phieuDen);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.PHIEUDENBU.Remove(phieuDen);
                context.SaveChanges();
            }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuSDDVDAL
    {
        public static List<PHIEUSDDV> layDanhSachPhieuSDDV()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUSDDV> listPhieuSDDV = context.PHIEUSDDV.ToList();
            return listPhieuSDDV;
        }

        public static void themPhieuSDDVDAL(PHIEUSDDV phieuSDDV)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.PHIEUSDDV.Add(phieuSDDV);
            context.SaveChanges();
        }

        public static void suaPhieuSDDVDAL(PHIEUSDDV phieuSDDV)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUSDDV> listSSDV = context.PHIEUSDDV.ToList();
            PHIEUSDDV phieuSDDV_Sua = listSSDV.FirstOrDefault(p => p.MAPHIEUSDDV == phieuSDDV.MAPHIEUSDDV);

            phieuSDDV_Sua.NGAYSUDUNG = phieuSDDV.NGAYSUDUNG;
            phieuSDDV_Sua.SOLUONG = phieuSDDV.SOLUONG;
            phieuSDDV_Sua.MANHANVIEN = phieuSDDV.MANHANVIEN;
            phieuSDDV_Sua.MAPHIEUDATPHONG = phieuSDDV.MAPHIEUDATPHONG;
            phieuSDDV_Sua.MAPHIEUCHUYENPHONG = phieuSDDV.MAPHIEUCHUYENPHONG;
            phieuSDDV_Sua.MADICHVU = phieuSDDV.MADICHVU;
            context.SaveChanges();
        }

        public static void xoaPhieuSDDVDAL(PHIEUSDDV phieuSDDV)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            PHIEUSDDV phieuSD = context.PHIEUSDDV.FirstOrDefault(p => p.MAPHIEUSDDV == phieuSDDV.MAPHIEUSDDV);
            try
            {
                context.PHIEUSDDV.Remove(phieuSD);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.PHIEUSDDV.Remove(phieuSD);
                context.SaveChanges();
            }
        }
    }
}

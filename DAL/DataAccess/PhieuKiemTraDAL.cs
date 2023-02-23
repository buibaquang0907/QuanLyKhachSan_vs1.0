using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuKiemTraDAL
    {
        public static List<PHIEUKIEMTRA> layDanhSachPhieuKiemTra()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUKIEMTRA> listPhieuKiemTra = context.PHIEUKIEMTRA.ToList();
            return listPhieuKiemTra;
        }

        public static void themPhieuKiemTraDAL(PHIEUKIEMTRA phieuKiemTra)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.PHIEUKIEMTRA.Add(phieuKiemTra);
            context.SaveChanges();
        }

        public static void suaPhieuKiemTraDAL(PHIEUKIEMTRA phieuKiemTra)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUKIEMTRA> listKT = context.PHIEUKIEMTRA.ToList();
            PHIEUKIEMTRA phieuKiemTra_Sua = listKT.FirstOrDefault(p => p.MAPHIEUKIEMTRA == phieuKiemTra.MAPHIEUKIEMTRA);
            
            phieuKiemTra_Sua.TINHTRANGSAUKIEMTRA = phieuKiemTra.TINHTRANGSAUKIEMTRA;
            phieuKiemTra_Sua.NGAYKIEMTRA = phieuKiemTra.NGAYKIEMTRA;
            phieuKiemTra_Sua.MAPHIEUDATPHONG = phieuKiemTra.MAPHIEUDATPHONG;
            phieuKiemTra_Sua.MAPHIEUCHUYENPHONG = phieuKiemTra.MAPHIEUCHUYENPHONG;
            phieuKiemTra_Sua.MAPHIEUSDDV = phieuKiemTra.MAPHIEUSDDV;
            context.SaveChanges();
        }

        public static void xoaPhieuKiemTraDAL(PHIEUKIEMTRA phieuKiemTra)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            PHIEUKIEMTRA phieuKiem = context.PHIEUKIEMTRA.FirstOrDefault(p => p.MAPHIEUKIEMTRA == phieuKiemTra.MAPHIEUKIEMTRA);
            try
            {
                context.PHIEUKIEMTRA.Remove(phieuKiem);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.PHIEUKIEMTRA.Remove(phieuKiem);
                context.SaveChanges();
            }
        }
    }
}

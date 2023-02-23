using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuChuyenPhongDAL
    {
        public static List<PHIEUCHUYENPHONG> layDanhSachPhieuChuyenPhong()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUCHUYENPHONG> listPhieuChuyenPhongDAL = context.PHIEUCHUYENPHONG.ToList();
            return listPhieuChuyenPhongDAL;
        }

        public static void themPhieuChuyenPhongDAL(PHIEUCHUYENPHONG phieuChuyenPhong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.PHIEUCHUYENPHONG.Add(phieuChuyenPhong);
            context.SaveChanges();
        }

        public static void xoaPhieuChuyenPhongDAL(PHIEUCHUYENPHONG phieuChuyenPhong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            PHIEUCHUYENPHONG phieuChuyenPhong_Delete = context.PHIEUCHUYENPHONG.FirstOrDefault(p => p.MAPHIEUCHUYENPHONG == phieuChuyenPhong.MAPHIEUCHUYENPHONG);
            try
            {
                context.PHIEUCHUYENPHONG.Remove(phieuChuyenPhong_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.PHIEUCHUYENPHONG.Remove(phieuChuyenPhong_Delete);
                context.SaveChanges();
            }
        }

        public static void suaPhieuChuyenPhongDAL(PHIEUCHUYENPHONG phieuChuyenPhong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHIEUCHUYENPHONG> listNV = context.PHIEUCHUYENPHONG.ToList();
            PHIEUCHUYENPHONG phieuChuyenPhong_Sua = listNV.FirstOrDefault(p => p.MAPHIEUCHUYENPHONG == phieuChuyenPhong.MAPHIEUCHUYENPHONG);
            phieuChuyenPhong_Sua.MAPHIEUCHUYENPHONG = phieuChuyenPhong.MAPHIEUCHUYENPHONG;
            phieuChuyenPhong_Sua.LYDO = phieuChuyenPhong.LYDO;
            phieuChuyenPhong_Sua.NGAYCHUYENPHONG = phieuChuyenPhong.NGAYCHUYENPHONG;
            phieuChuyenPhong_Sua.MAPHONG = phieuChuyenPhong.MAPHONG;
            phieuChuyenPhong_Sua.MAPHIEUDATPHONG = phieuChuyenPhong.MAPHIEUDATPHONG;
            phieuChuyenPhong_Sua.MANHANVIEN = phieuChuyenPhong.MANHANVIEN;
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DichVuvaLoaiDichVuDAL
    {
        public static List<LOAIDICHVU> layDanhSachLoaiDichVu()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<LOAIDICHVU> listLoaiDichVu = context.LOAIDICHVU.ToList();
            return listLoaiDichVu;
        }

        public static List<DICHVU> layDanhSachDichVu()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<DICHVU> listDichVu = context.DICHVU.ToList();
            return listDichVu;
        }

        public static void themLoaiDichVuDAL(LOAIDICHVU loai)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.LOAIDICHVU.Add(loai);
            context.SaveChanges();
        }

        public static void xoaLoaiDichVuDAL(LOAIDICHVU loai)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            LOAIDICHVU loaiDV_Delete = context.LOAIDICHVU.FirstOrDefault(p => p.MALOAIDICHVU == loai.MALOAIDICHVU);
            try
            {
                context.LOAIDICHVU.Remove(loaiDV_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.LOAIDICHVU.Remove(loaiDV_Delete);
                context.SaveChanges();
            }
        }

        public static void suaLoaiDichVuDAL(LOAIDICHVU loai)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<LOAIDICHVU> listLoaiDV = context.LOAIDICHVU.ToList();
            LOAIDICHVU LoaiDV_Sua = listLoaiDV.FirstOrDefault(p => p.MALOAIDICHVU == loai.MALOAIDICHVU);
            LoaiDV_Sua.TENLOAIDICHVU = loai.TENLOAIDICHVU;
            context.SaveChanges();
        }

        public static void themDichVuDAL(DICHVU dichvu)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.DICHVU.Add(dichvu);
            context.SaveChanges();
        }

        public static void xoaDichVuDAL(DICHVU dichvu)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            DICHVU DV_Delete = context.DICHVU.FirstOrDefault(p => p.MADICHVU == dichvu.MADICHVU);
            try
            {
                context.DICHVU.Remove(DV_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.DICHVU.Remove(DV_Delete);
                context.SaveChanges();
            }
        }

        public static void suaDichVuDAL(DICHVU dichvu)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<DICHVU> listDV = context.DICHVU.ToList();
            DICHVU DV_Sua = listDV.FirstOrDefault(p => p.MADICHVU == dichvu.MADICHVU);
            DV_Sua.TENDICHVU = dichvu.TENDICHVU;
            DV_Sua.GIATHUEDICHVU = dichvu.GIATHUEDICHVU;
            DV_Sua.MADICHVU = dichvu.MADICHVU;
            DV_Sua.DONVITINH = dichvu.DONVITINH;
            DV_Sua.MALOAIDICHVU = dichvu.MALOAIDICHVU;
            context.SaveChanges();
        }
    }
}

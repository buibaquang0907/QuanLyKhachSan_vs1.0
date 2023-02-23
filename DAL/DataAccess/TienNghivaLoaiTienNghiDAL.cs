using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TienNghivaLoaiTienNghiDAL
    {
        public static List<LOAITIENNGHI> layDanhSachLoaiTienNghi()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<LOAITIENNGHI> listLoaiTienNghi = context.LOAITIENNGHI.ToList();
            return listLoaiTienNghi;
        }

        public static List<TIENNGHI> layDanhSachTienNghi()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<TIENNGHI> listTienNghi = context.TIENNGHI.ToList();
            return listTienNghi;
        }

        public static void themLoaiTienNghiDAL(LOAITIENNGHI loaiTN)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.LOAITIENNGHI.Add(loaiTN);
            context.SaveChanges();
        }

        public static void xoaLoaiTienNghiDAL(LOAITIENNGHI loaiTN)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            LOAITIENNGHI loaiTN_Delete = context.LOAITIENNGHI.FirstOrDefault(p => p.MALOAITIENNGHI == loaiTN.MALOAITIENNGHI);
            try
            {
                context.LOAITIENNGHI.Remove(loaiTN_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.LOAITIENNGHI.Remove(loaiTN_Delete);
                context.SaveChanges();
            }
        }

        public static void suaLoaiTienNghiDAL(LOAITIENNGHI loaiTN)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<LOAITIENNGHI> listLoaiTN = context.LOAITIENNGHI.ToList();
            LOAITIENNGHI LoaiTN_Sua = listLoaiTN.FirstOrDefault(p => p.MALOAITIENNGHI == loaiTN.MALOAITIENNGHI);
            LoaiTN_Sua.TENLOAITIENNGHI = loaiTN.TENLOAITIENNGHI;
            context.SaveChanges();
        }

        public static void themTienNghiDAL(TIENNGHI tienNghi)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.TIENNGHI.Add(tienNghi);
            context.SaveChanges();
        }

        public static void xoaTienNghiDAL(TIENNGHI tienNghi)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            TIENNGHI TN_Delete = context.TIENNGHI.FirstOrDefault(p => p.MATIENNGHI == tienNghi.MATIENNGHI);
            try
            {
                context.TIENNGHI.Remove(TN_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.TIENNGHI.Remove(TN_Delete);
                context.SaveChanges();
            }
        }

        public static void suaTienNghiDAL(TIENNGHI tienNghi)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<TIENNGHI> listTN = context.TIENNGHI.ToList();
            TIENNGHI TN_Sua = listTN.FirstOrDefault(p => p.MATIENNGHI == tienNghi.MATIENNGHI);
            TN_Sua.TENTIENNGHI = tienNghi.TENTIENNGHI;
            TN_Sua.DONVITINH = tienNghi.DONVITINH;
            TN_Sua.DONGIA = tienNghi.DONGIA;
            TN_Sua.TINHTRANG = tienNghi.TINHTRANG;
            TN_Sua.MALOAITIENNGHI = tienNghi.MALOAITIENNGHI;
            context.SaveChanges();
        }
    }
}

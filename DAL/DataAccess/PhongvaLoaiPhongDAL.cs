using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhongvaLoaiPhongDAL
    {
        public static List<LOAIPHONG> layDanhSachLoaiPhong()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<LOAIPHONG> listLoaiPhongDAL = context.LOAIPHONG.ToList();
            return listLoaiPhongDAL;
        }

        public static List<PHONG> layDanhSachPhong()
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHONG> listPhongDAL = context.PHONG.ToList();
            return listPhongDAL;
        }

        public static void themLoaiPhongDAL(LOAIPHONG loaiPhong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.LOAIPHONG.Add(loaiPhong);
            context.SaveChanges();
        }

        public static void xoaLoaiPhongDAL(LOAIPHONG loaiPhong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            LOAIPHONG loaiPhong_Delete = context.LOAIPHONG.FirstOrDefault(p => p.MALOAIPHONG == loaiPhong.MALOAIPHONG);
            try
            {
                context.LOAIPHONG.Remove(loaiPhong_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.LOAIPHONG.Remove(loaiPhong_Delete);
                context.SaveChanges();
            }
        }

        public static void suaLoaiPhongDAL(LOAIPHONG loaiPhong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<LOAIPHONG> listLoaiPhong = context.LOAIPHONG.ToList();
            LOAIPHONG LoaiPhong_Sua = listLoaiPhong.FirstOrDefault(p => p.MALOAIPHONG == loaiPhong.MALOAIPHONG);
            LoaiPhong_Sua.TENLOAIPHONG = loaiPhong.TENLOAIPHONG;
            LoaiPhong_Sua.GIATHUE = loaiPhong.GIATHUE;
            context.SaveChanges();
        }

        public static void themPhongDAL(PHONG phong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            context.PHONG.Add(phong);
            context.SaveChanges();
        }

        public static void xoaPhongDAL(PHONG phong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            PHONG Phong_Delete = context.PHONG.FirstOrDefault(p => p.MAPHONG == phong.MAPHONG);
            try
            {
                context.PHONG.Remove(Phong_Delete);
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                context.PHONG.Remove(Phong_Delete);
                context.SaveChanges();
            }
        }

        public static void suaPhongDAL(PHONG phong)
        {
            KhachSanDBContext context = new KhachSanDBContext();
            List<PHONG> listPhong = context.PHONG.ToList();
            PHONG Phong_Sua = listPhong.FirstOrDefault(p => p.MAPHONG == phong.MAPHONG);
            Phong_Sua.TENPHONG = phong.TENPHONG;
            Phong_Sua.MALOAIPHONG = phong.MALOAIPHONG;
            Phong_Sua.TINHTRANG = phong.TINHTRANG;
            Phong_Sua.SONGUOITOIDA = phong.SONGUOITOIDA;
            context.SaveChanges();
        }
    }
}

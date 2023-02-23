using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Security.Policy;
using System.Data.SqlClient;

namespace BUS
{
    public class NhanVienBUS
    {
        public static List<NhanVienDTO> DanhSachNhanVien()
        {
            List<NHANVIEN> listNhanVien = DAL.NhanVienDAL.layDanhSachNhanVien();
            List<NhanVienDTO> listNhanVienDTO = new List<NhanVienDTO>();
            
            foreach (var item in listNhanVien)
            {
                NhanVienDTO nhanvien = new NhanVienDTO();
                nhanvien.MANHANVIEN = item.MANHANVIEN;
                nhanvien.TENNHANVIEN = item.TENNHANVIEN;
                nhanvien.NAMSINH = item.NAMSINH;
                nhanvien.DIACHI = item.DIACHI;
                nhanvien.CCCD = item.CCCD;
                nhanvien.CHUCVU = item.CHUCVU;
                nhanvien.DT = item.DT;
                listNhanVienDTO.Add(nhanvien);
            }
            return listNhanVienDTO;
        }

        public static string themNhanVien(NhanVienDTO nhanVien)
        {
            List<NHANVIEN> listNhanVien = DAL.NhanVienDAL.layDanhSachNhanVien();
            NHANVIEN kiemtraNV = listNhanVien.FirstOrDefault(p => p.CCCD == nhanVien.CCCD);
            try
            {
                if (kiemtraNV == null)
                {
                    NHANVIEN nhanVien_new = new NHANVIEN()
                    {
                        TENNHANVIEN = nhanVien.TENNHANVIEN,
                        CCCD = nhanVien.CCCD,
                        DIACHI = nhanVien.DIACHI,
                        DT = nhanVien.DT,
                        CHUCVU = nhanVien.CHUCVU,
                        NAMSINH = nhanVien.NAMSINH,
                    };
                    DAL.NhanVienDAL.themNhanVienDAL(nhanVien_new);
                    return "themthanhcong";
                }
                else
                {
                    return "Nhân viên đã có trên hệ thống!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string xoaNhanVien(NhanVienDTO nhanVien)
        {
            List<NHANVIEN> listKH = DAL.NhanVienDAL.layDanhSachNhanVien();
            NHANVIEN nhanVien_Delete = listKH.FirstOrDefault(p => p.CCCD == nhanVien.CCCD);

            try
            {
                NhanVienDAL.xoaNhanVienDAL(nhanVien_Delete);
                return "xoathanhcong";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public static string suaNhanVien(NhanVienDTO nhanVien)
        {
            List<NHANVIEN> listNVDAL = DAL.NhanVienDAL.layDanhSachNhanVien();
            NHANVIEN nhanVien_KiemTra = listNVDAL.FirstOrDefault(p => p.CCCD == nhanVien.CCCD);

            if (nhanVien_KiemTra != null)
            {
                try
                {
                    nhanVien_KiemTra.TENNHANVIEN = nhanVien.TENNHANVIEN;
                    nhanVien_KiemTra.CCCD = nhanVien.CCCD;
                    nhanVien_KiemTra.DIACHI = nhanVien.DIACHI;
                    nhanVien_KiemTra.DT = nhanVien.DT;
                    nhanVien_KiemTra.CHUCVU = nhanVien.CHUCVU;

                    DAL.NhanVienDAL.suaNhanVienDAL(nhanVien_KiemTra);

                    return "suathanhcong";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "khongtimthaykhachhang";
            }
        }
    }
}

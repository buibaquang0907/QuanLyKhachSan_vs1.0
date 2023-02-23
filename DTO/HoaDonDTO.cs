using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int MAHOADON { get; set; }
        public decimal? TONGTIEN { get; set; }
        public DateTime? NGAYTHANHTOAN { get; set; }
        public int? MAPHIEUKIEMTRA { get; set; }
        public int? MANHANVIEN { get; set; }
    }
}

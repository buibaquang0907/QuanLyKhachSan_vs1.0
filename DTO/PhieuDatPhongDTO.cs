using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatPhongDTO
    {
        public int MAPHIEUDATPHONG { get; set; }

        public int? SONGUOI { get; set; }
        public DateTime? NGAYNHANPHONG { get; set; }
        public DateTime? NGAYTRADUKIEN { get; set; }
        public decimal? TIENCOC { get; set; }

        public int? MAPHONG { get; set; }

        public int? MAKH { get; set; }

        public int? MANHANVIEN { get; set; }
    }
}

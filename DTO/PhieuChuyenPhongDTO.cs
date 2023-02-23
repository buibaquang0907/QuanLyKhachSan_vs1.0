using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuChuyenPhongDTO
    {
        public int MAPHIEUCHUYENPHONG { get; set; }
        public string LYDO { get; set; }
        public DateTime? NGAYCHUYENPHONG { get; set; }
        public int? MAPHONG { get; set; }
        public int? MAPHIEUDATPHONG { get; set; }
        public int? MANHANVIEN { get; set; }
    }
}

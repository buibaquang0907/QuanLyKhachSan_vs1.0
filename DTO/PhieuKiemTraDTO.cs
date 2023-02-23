using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuKiemTraDTO
    {
        public int MAPHIEUKIEMTRA { get; set; }
        public string TINHTRANGSAUKIEMTRA { get; set; }
        public DateTime? NGAYKIEMTRA { get; set; }

        public int? MANHANVIEN { get; set; }

        public int? MAPHIEUDATPHONG { get; set; }

        public int? MAPHIEUCHUYENPHONG { get; set; }

        public int? MAPHIEUSDDV { get; set; }
    }
}

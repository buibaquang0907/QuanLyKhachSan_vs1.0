using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuSDDVDTO
    {
        public int MAPHIEUSDDV { get; set; }

        public DateTime? NGAYSUDUNG { get; set; }

        public int? SOLUONG { get; set; }

        public int? MADICHVU { get; set; }

        public int? MAPHIEUDATPHONG { get; set; }

        public int? MANHANVIEN { get; set; }

        public int? MAPHIEUCHUYENPHONG { get; set; }
    }
}

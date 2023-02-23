using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuLapDatDTO
    {
        public int MAPHIEULAPDAT { get; set; }

        public int? SOLUONG { get; set; }
        public string TINHTRANG { get; set; }
        public DateTime? NGAYLAPDAT { get; set; }

        public int? MATIENNGHI { get; set; }

        public int? MAPHONG { get; set; }

        public int? MANHANVIEN { get; set; }
    }
}

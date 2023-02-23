using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienNghiDTO
    {
        public int MATIENNGHI { get; set; }
        public string TENTIENNGHI { get; set; }
        public string DONVITINH { get; set; }
        public decimal? DONGIA { get; set; }
        public string TINHTRANG { get; set; }
        public int? MALOAITIENNGHI { get; set; }
    }
}

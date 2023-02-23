using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDTO
    {
        public int MADICHVU { get; set; }
        public string TENDICHVU { get; set; }
        public string DONVITINH { get; set; }
        public decimal? GIATHUEDICHVU { get; set; }
        public int? MALOAIDICHVU { get; set; }
    }
}

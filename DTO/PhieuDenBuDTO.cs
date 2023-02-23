using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDenBuDTO
    {
        public int MAPHIEUDENBU { get; set; }

        public string NOIDUNG { get; set; }

        public decimal? TIENPHAT { get; set; }

        public DateTime? NGAYLAPDENBU { get; set; }

        public int? MAPHIEUKIEMTRA { get; set; }
    }
}

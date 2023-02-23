using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        public int MAPHONG { get; set; }
        public string TENPHONG { get; set; }
        public int? SONGUOITOIDA { get; set; }
        public string TINHTRANG { get; set; }
        public int? MALOAIPHONG { get; set; }
    }
}

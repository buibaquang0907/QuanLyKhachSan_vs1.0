using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int MAKH { get; set; }
        public string TENKH { get; set; }
        public long? CCCD { get; set; }
        public bool? GIOITINH { get; set; }
        public string DIACHI { get; set; }
        public string DT { get; set; }
        public string QUOCTICH { get; set; }
    }
}

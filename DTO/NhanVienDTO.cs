using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int MANHANVIEN { get; set; }
        public string TENNHANVIEN { get; set; }
        public short? NAMSINH { get; set; }
        public long? CCCD { get; set; }
        public string CHUCVU { get; set; }
        public string DIACHI { get; set; }
        public string DT { get; set; }
    }
}

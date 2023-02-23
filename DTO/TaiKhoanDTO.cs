using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public string TENDANGNHAP { get; set; }

        public string MATKHAU { get; set; }

        public int? MANHANVIEN { get; set; }

        public int? MAPHANQUYEN { get; set; }
    }
}

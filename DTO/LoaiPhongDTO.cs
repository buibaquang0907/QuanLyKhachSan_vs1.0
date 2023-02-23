using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongDTO
    {
        public int MALOAIPHONG { get; set; }
        public string TENLOAIPHONG { get; set; }
        public decimal? GIATHUE { get; set; }
    }
}

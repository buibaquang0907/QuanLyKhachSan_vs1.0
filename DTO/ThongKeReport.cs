using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeReport
    {
        public int MAHOADON { get; set; }

        public int MAKH { get; set; }

        public string TENKH { get; set; }

        public int MANHANVIEN { get; set; }

        public string TENNHANVIEN { get; set; }

        public int MAPHONG { get; set; }

        public string TENPHONG { get; set; }

        public DateTime? NGAYTHANHTOAN { get; set; }

        public int MADICHVU { get; set; }

        public string TENDICHVU { get; set; }

        public decimal? TONGTIEN { get; set; }

    }
}

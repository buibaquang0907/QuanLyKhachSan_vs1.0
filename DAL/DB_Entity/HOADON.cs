namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        public int MAHOADON { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTHANHTOAN { get; set; }

        public int? MAPHIEUKIEMTRA { get; set; }

        public int? MANHANVIEN { get; set; }

        public virtual PHIEUKIEMTRA PHIEUKIEMTRA { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}

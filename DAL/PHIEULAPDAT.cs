namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEULAPDAT")]
    public partial class PHIEULAPDAT
    {
        [Key]
        public int MAPHIEULAPDAT { get; set; }

        public int? SOLUONG { get; set; }

        [StringLength(30)]
        public string TINHTRANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYLAPDAT { get; set; }

        public int? MATIENNGHI { get; set; }

        public int? MAPHONG { get; set; }

        public int? MANHANVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual TIENNGHI TIENNGHI { get; set; }
    }
}

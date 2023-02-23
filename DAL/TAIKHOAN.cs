namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(30)]
        public string TENDANGNHAP { get; set; }

        [Required]
        [StringLength(30)]
        public string MATKHAU { get; set; }

        public int? MANHANVIEN { get; set; }

        public int? MAPHANQUYEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHANQUYEN PHANQUYEN { get; set; }
    }
}

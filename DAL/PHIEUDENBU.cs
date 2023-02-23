namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDENBU")]
    public partial class PHIEUDENBU
    {
        [Key]
        public int MAPHIEUDENBU { get; set; }

        [StringLength(200)]
        public string NOIDUNG { get; set; }

        [Column(TypeName = "money")]
        public decimal? TIENPHAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYLAPDENBU { get; set; }

        public int? MAPHIEUKIEMTRA { get; set; }

        public virtual PHIEUKIEMTRA PHIEUKIEMTRA { get; set; }
    }
}

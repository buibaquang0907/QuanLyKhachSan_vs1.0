namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDATPHONG")]
    public partial class PHIEUDATPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATPHONG()
        {
            PHIEUCHUYENPHONG = new HashSet<PHIEUCHUYENPHONG>();
            PHIEUKIEMTRA = new HashSet<PHIEUKIEMTRA>();
            PHIEUSDDV = new HashSet<PHIEUSDDV>();
        }

        [Key]
        public int MAPHIEUDATPHONG { get; set; }

        public int? SONGUOI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYNHANPHONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTRADUKIEN { get; set; }

        [Column(TypeName = "money")]
        public decimal? TIENCOC { get; set; }

        public int? MAPHONG { get; set; }

        public int? MAKH { get; set; }

        public int? MANHANVIEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHUYENPHONG> PHIEUCHUYENPHONG { get; set; }

        public virtual PHONG PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKIEMTRA> PHIEUKIEMTRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSDDV> PHIEUSDDV { get; set; }
    }
}

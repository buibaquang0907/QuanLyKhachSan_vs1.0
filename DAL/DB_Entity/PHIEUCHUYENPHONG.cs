namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUCHUYENPHONG")]
    public partial class PHIEUCHUYENPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUCHUYENPHONG()
        {
            PHIEUKIEMTRA = new HashSet<PHIEUKIEMTRA>();
            PHIEUSDDV = new HashSet<PHIEUSDDV>();
        }

        [Key]
        public int MAPHIEUCHUYENPHONG { get; set; }

        [StringLength(100)]
        public string LYDO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYCHUYENPHONG { get; set; }

        public int? MAPHONG { get; set; }

        public int? MAPHIEUDATPHONG { get; set; }

        public int? MANHANVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKIEMTRA> PHIEUKIEMTRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSDDV> PHIEUSDDV { get; set; }
    }
}

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUSDDV")]
    public partial class PHIEUSDDV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUSDDV()
        {
            PHIEUKIEMTRA = new HashSet<PHIEUKIEMTRA>();
        }

        [Key]
        public int MAPHIEUSDDV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSUDUNG { get; set; }

        public int? SOLUONG { get; set; }

        public int? MADICHVU { get; set; }

        public int? MAPHIEUDATPHONG { get; set; }

        public int? MANHANVIEN { get; set; }

        public int? MAPHIEUCHUYENPHONG { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHIEUCHUYENPHONG PHIEUCHUYENPHONG { get; set; }

        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKIEMTRA> PHIEUKIEMTRA { get; set; }
    }
}

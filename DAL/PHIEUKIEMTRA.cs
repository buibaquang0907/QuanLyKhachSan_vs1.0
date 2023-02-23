namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUKIEMTRA")]
    public partial class PHIEUKIEMTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUKIEMTRA()
        {
            HOADON = new HashSet<HOADON>();
            PHIEUDENBU = new HashSet<PHIEUDENBU>();
        }

        [Key]
        public int MAPHIEUKIEMTRA { get; set; }

        [StringLength(200)]
        public string TINHTRANGSAUKIEMTRA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYKIEMTRA { get; set; }

        public int? MANHANVIEN { get; set; }

        public int? MAPHIEUDATPHONG { get; set; }

        public int? MAPHIEUCHUYENPHONG { get; set; }

        public int? MAPHIEUSDDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHIEUCHUYENPHONG PHIEUCHUYENPHONG { get; set; }

        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDENBU> PHIEUDENBU { get; set; }

        public virtual PHIEUSDDV PHIEUSDDV { get; set; }
    }
}

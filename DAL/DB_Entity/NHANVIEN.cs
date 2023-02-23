namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADON = new HashSet<HOADON>();
            TAIKHOAN = new HashSet<TAIKHOAN>();
            PHIEUCHUYENPHONG = new HashSet<PHIEUCHUYENPHONG>();
            PHIEUDATPHONG = new HashSet<PHIEUDATPHONG>();
            PHIEUKIEMTRA = new HashSet<PHIEUKIEMTRA>();
            PHIEULAPDAT = new HashSet<PHIEULAPDAT>();
            PHIEUSDDV = new HashSet<PHIEUSDDV>();
        }

        [Key]
        public int MANHANVIEN { get; set; }

        [Required]
        [StringLength(30)]
        public string TENNHANVIEN { get; set; }

        public short? NAMSINH { get; set; }

        public long? CCCD { get; set; }

        [StringLength(50)]
        public string CHUCVU { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(11)]
        public string DT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHUYENPHONG> PHIEUCHUYENPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKIEMTRA> PHIEUKIEMTRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEULAPDAT> PHIEULAPDAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSDDV> PHIEUSDDV { get; set; }
    }
}

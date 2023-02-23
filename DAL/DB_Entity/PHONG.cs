namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            PHIEUCHUYENPHONG = new HashSet<PHIEUCHUYENPHONG>();
            PHIEUDATPHONG = new HashSet<PHIEUDATPHONG>();
            PHIEULAPDAT = new HashSet<PHIEULAPDAT>();
        }

        [Key]
        public int MAPHONG { get; set; }

        [Required]
        [StringLength(30)]
        public string TENPHONG { get; set; }

        public int? SONGUOITOIDA { get; set; }

        [StringLength(30)]
        public string TINHTRANG { get; set; }

        public int? MALOAIPHONG { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHUYENPHONG> PHIEUCHUYENPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEULAPDAT> PHIEULAPDAT { get; set; }
    }
}

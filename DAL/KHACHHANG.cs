namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            PHIEUDATPHONG = new HashSet<PHIEUDATPHONG>();
        }

        [Key]
        public int MAKH { get; set; }

        [Required]
        [StringLength(30)]
        public string TENKH { get; set; }

        public long? CCCD { get; set; }

        public bool? GIOITINH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(11)]
        public string DT { get; set; }

        [StringLength(20)]
        public string QUOCTICH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONG { get; set; }
    }
}

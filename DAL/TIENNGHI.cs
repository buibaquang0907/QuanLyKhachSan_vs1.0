namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIENNGHI")]
    public partial class TIENNGHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIENNGHI()
        {
            PHIEULAPDAT = new HashSet<PHIEULAPDAT>();
        }

        [Key]
        public int MATIENNGHI { get; set; }

        [Required]
        [StringLength(30)]
        public string TENTIENNGHI { get; set; }

        [StringLength(20)]
        public string DONVITINH { get; set; }

        [Column(TypeName = "money")]
        public decimal? DONGIA { get; set; }

        [StringLength(30)]
        public string TINHTRANG { get; set; }

        public int? MALOAITIENNGHI { get; set; }

        public virtual LOAITIENNGHI LOAITIENNGHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEULAPDAT> PHIEULAPDAT { get; set; }
    }
}

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            PHIEUSDDV = new HashSet<PHIEUSDDV>();
        }

        [Key]
        public int MADICHVU { get; set; }

        [Required]
        [StringLength(30)]
        public string TENDICHVU { get; set; }

        [StringLength(20)]
        public string DONVITINH { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIATHUEDICHVU { get; set; }

        public int? MALOAIDICHVU { get; set; }

        public virtual LOAIDICHVU LOAIDICHVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSDDV> PHIEUSDDV { get; set; }
    }
}

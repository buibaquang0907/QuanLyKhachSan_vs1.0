namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAITIENNGHI")]
    public partial class LOAITIENNGHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAITIENNGHI()
        {
            TIENNGHI = new HashSet<TIENNGHI>();
        }

        [Key]
        public int MALOAITIENNGHI { get; set; }

        [Required]
        [StringLength(30)]
        public string TENLOAITIENNGHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIENNGHI> TIENNGHI { get; set; }
    }
}

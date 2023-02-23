namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHONG")]
    public partial class LOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG()
        {
            PHONG = new HashSet<PHONG>();
        }

        [Key]
        public int MALOAIPHONG { get; set; }

        [Required]
        [StringLength(30)]
        public string TENLOAIPHONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIATHUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONG { get; set; }
    }
}

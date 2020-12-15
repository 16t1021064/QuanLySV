namespace AppQLSV.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLASSROOM")]
    public partial class CLASSROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASSROOM()
        {
            STUDENT = new HashSet<STUDENT>();
        }

        [Key]
        [StringLength(50)]
        public string IDCLASS { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT> STUDENT { get; set; }
    }
}

namespace AppQLSV.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string FIRSTNAME { get; set; }

        [StringLength(50)]
        public string LASTNAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATEOFBIRTH { get; set; }

        [StringLength(250)]
        public string PLACEOFBIRTH { get; set; }

        public int? GENDER { get; set; }

        [StringLength(50)]
        public string IDCLASS { get; set; }

        public virtual CLASSROOM CLASSROOM { get; set; }

    }
}

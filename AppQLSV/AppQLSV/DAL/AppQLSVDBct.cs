namespace AppQLSV.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppQLSVDBct : DbContext
    {
        public AppQLSVDBct()
            : base("name=AppQLSVDBct")
        {
        }

        public virtual DbSet<CLASSROOM> CLASSROOM { get; set; }
        public virtual DbSet<STUDENT> STUDENT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

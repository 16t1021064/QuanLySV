using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppQLSV.DAL
{
    public partial class AppQLSVDBContext : DbContext
    {
        public AppQLSVDBContext()
            : base("name=AppQLSVDBContext")
        {
            
        }

        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Classroom)
                .HasForeignKey(e => e.IDClassroom);
        }
    }
}

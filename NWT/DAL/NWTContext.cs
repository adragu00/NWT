using NWT.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NWT.DAL
{
    public class NWTContext: DbContext
    {
        public NWTContext() : base ("NWTContext")
        {
            Database.SetInitializer<NWTContext>(new NWTInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Study> Studies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        // DODANO
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;

namespace MVCWithEFCF3.Models
{
    public class SchoolDbContext : DbContext
    {
       public SchoolDbContext() : base("Constr")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SchoolDbContext>());
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().MapToStoredProcedures();
        }

    }
}
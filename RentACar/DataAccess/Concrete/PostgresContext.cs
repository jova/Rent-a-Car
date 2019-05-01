using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class PostgresContext : DbContext
    {

        public PostgresContext() : base(nameOrConnectionString: "PostgresContext") { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rentalinformation> Rentalinformations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VehicleInformation> VehicleInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //    modelBuilder.Entity<Company>().ToTable("Company", "public");
            //    modelBuilder.Entity<Customer>().ToTable("Customer", "public");
            //    modelBuilder.Entity<Rentalinformation>().ToTable("Rentalinformation", "public");
            //    modelBuilder.Entity<Role>().ToTable("Role", "public");
            //    modelBuilder.Entity<User>().ToTable("User", "public");
            //    modelBuilder.Entity<VehicleInformation>().ToTable("VehicleInformation", "public");

            //    modelBuilder.Conventions.Remove<StoreGeneratedIdentityKeyConvention>();

            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

    }
}

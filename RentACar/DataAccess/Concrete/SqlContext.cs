using Entities;
using System.Data.Entity;

namespace DataAccess.Concrete
{
    public class SqlContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rentalinformation> Rentalinformations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VehicleInformation> VehicleInformations { get; set; }

        public SqlContext() :  base("Name=soaDB")
        {

        }
    }
}

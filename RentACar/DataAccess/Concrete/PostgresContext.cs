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
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rentalinformation> Rentalinformations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VehicleInformation> VehicleInformations { get; set; }
    }
}

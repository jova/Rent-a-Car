
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int VehiclesNumber { get; set; }
        public int Point { get; set; }

        public virtual List<Customer> Customers { get; set; }
        public virtual List<VehicleInformation> VehicleInformations { get; set; }
    }
}

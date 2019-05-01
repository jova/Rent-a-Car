
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int TCNumber { get; set; }

        public virtual List<Rentalinformation> Rentalinformations { get; set; }
        public virtual List<VehicleInformation> vehicleInformations { get; set; }

        public virtual Company Company { get; set; }



    }
}

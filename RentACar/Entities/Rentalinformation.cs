
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rentalinformation 
    {
        public int ID { get; set; }
        public DateTime RentalRange { get; set; }
        public int StartKm { get; set; }
        public int LastKm { get; set; }
        public int Payment { get; set; }
        public bool IsActive { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual VehicleInformation VehicleInformation { get; set; }

    }
}

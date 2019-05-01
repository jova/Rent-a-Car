
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class VehicleInformation 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Address { get; set; }
        public int LicenseAge { get; set; }
        public int MinLicenseAge { get; set; }
        public int DailyBorderKm { get; set; }
        public bool Airbag { get; set; }
        public int BaggageVolume { get; set; }
        public int SeatingCapacity { get; set; }
        public int DailyRentalPrice { get; set; }

        public virtual List<Rentalinformation> Rentalinformations { get; set; }
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

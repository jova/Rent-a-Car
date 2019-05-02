using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class VehicleInformation : IEntity
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Address { get; set; }
        public int MinLicenseAge { get; set; }
        public int MinAge { get; set; }
        public int DailyBorderKm { get; set; }
        public bool Airbag { get; set; }
        public int BaggageVolume { get; set; }
        public int SeatingCapacity { get; set; }
        public int DailyRentalPrice { get; set; }
        public int CompanyID { get; set; }
        public int CustomerID { get; set; }
        public bool isRentaled { get; set; }
    }
}

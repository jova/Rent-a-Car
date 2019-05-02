using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rentalinformation : IEntity
    {
        public int Id { get; set; }
        public DateTime RentalRange { get; set; }
        public int StartKm { get; set; }
        public int LastKm { get; set; }
        public int Payment { get; set; }
        public bool IsActive { get; set; }
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
    }
}

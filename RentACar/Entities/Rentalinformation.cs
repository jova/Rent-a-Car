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
        public int HowManyDays { get; set; }
        public int StartKm { get; set; }
        public int LastKmId { get; set; }
        public int Payment { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequest { get; set; }
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}

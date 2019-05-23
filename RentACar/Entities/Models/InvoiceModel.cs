using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class InvoiceModel
    {
        public Customer customer { get; set; }
        public int Rents { get; set; }
        public int Spent { get; set; }
        public int RentedDays { get; set; }
        public List<VehicleInformation> RentedVehicles { get; set; }
    }
}

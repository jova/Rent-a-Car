using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class RentModel
    {
        public Rentalinformation rent { get; set; }
        public int vehicleId { get; set; }
        public int customerId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desktop.Models
{
    public class RentRequestViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int TCNumber { get; set; }
        public int HowManyDays { get; set; }
        public string VehicleName { get; set; }
    }
}
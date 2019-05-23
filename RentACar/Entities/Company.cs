using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int VehiclesNumber { get; set; }
        public int Star { get; set; }
        public int Earning { get; set; }
        public int Expense { get; set; }
    }
}

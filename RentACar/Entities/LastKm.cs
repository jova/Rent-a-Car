using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LastKm : IEntity
    {
        public int Id { get; set; }
        public int vehicleId { get; set; }
        public DateTime? Date { get; set; }
        public int Km { get; set; }
    }
}

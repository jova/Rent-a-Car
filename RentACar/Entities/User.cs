
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class User 
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public virtual Role Role { get; set; }

    }
}

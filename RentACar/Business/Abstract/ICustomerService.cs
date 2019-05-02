using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        Customer Get(int customerId);
        Rentalinformation RentRequest(int TCNumber, int vehicleId, int howManyDays);
    }
}

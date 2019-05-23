using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal customerDal;
        IVehicleInformationDal vehicleDal;
        IRentalinformationDal rentDal;

        public CustomerManager()
        {
            customerDal = IOCUtil.Resolve<ICustomerDal>();
            vehicleDal  = IOCUtil.Resolve<IVehicleInformationDal>();
            rentDal     = IOCUtil.Resolve<IRentalinformationDal>();
        }

        public void Add(Customer customer)
        {
            Customer checkCustom = customerDal.Get(x => x.TCNumber == customer.TCNumber);
            if (checkCustom == null) customerDal.Add(customer);
        }

        public Customer Get(int customerId)
        {
            return customerDal.Get(x => x.Id == customerId);
        }

        public List<Customer> GetList()
        {
            return customerDal.GetList();
        }

        public Rentalinformation RentRequest(int TCNumber, int vehicleId, int howManyDays)
        {
            Customer customer = customerDal.Get(x => x.TCNumber == TCNumber);
            VehicleInformation vehicle = vehicleDal.Get(x => x.Id == vehicleId);

            Rentalinformation rental = new Rentalinformation();
            rental.CustomerID  = customer.Id;
            rental.VehicleID   = vehicleId;
            rental.HowManyDays = howManyDays;
            rental.Payment = vehicle.DailyRentalPrice * howManyDays;
            rental.StartKm = vehicle.DailyBorderKm;
            rental.IsRequest = true;
            rental.IsActive = false;

            rentDal.Add(rental);

            return rental;
        }
    }
}

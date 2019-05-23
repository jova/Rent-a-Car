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
    public class VehicleManager : IVehicleService
    {
        IVehicleInformationDal vehicleDal;
        IRentalinformationDal rentalDal;
        ICompanyDal companyDal;

        public VehicleManager()
        {
            vehicleDal = IOCUtil.Resolve<IVehicleInformationDal>();
            rentalDal = IOCUtil.Resolve<IRentalinformationDal>();
            companyDal = IOCUtil.Resolve<ICompanyDal>();
        }

        public VehicleInformation Get(int vehicleId)
        {
            return vehicleDal.Get(x => x.Id == vehicleId);
        }

        public List<VehicleInformation> GetAll()
        {
            return vehicleDal.GetList();
        }

        public List<VehicleInformation> GetRentaledVehicles()
        {
            return vehicleDal.GetList(x => x.isRentaled == true);
        }

        public bool RentACar(int vehicleId, int customerId, Rentalinformation rental)
        {
            VehicleInformation vehicle = Get(vehicleId);
            if (vehicle == null) return false;

            rental.IsActive = true;
            rental.IsRequest = false;
            rental.StartDate = DateTime.Now;
            rentalDal.Update(rental);

            List<Rentalinformation> rents = rentalDal.GetList(x => x.Id != rental.Id && x.VehicleID == vehicle.Id);
            foreach (var rent in rents)
            {
                rent.IsActive = false;
                rent.IsRequest = false;
                rent.FinishDate = DateTime.Now;

                rentalDal.Update(rent);
            }

            Company company = companyDal.Get(x => x.Id == 1);
            company.Earning += rental.Payment;
            company.Expense -= (100 * rental.HowManyDays);

            companyDal.Update(company);

            vehicle.CustomerID = customerId;
            vehicle.isRentaled = true;

            vehicleDal.Update(vehicle);
            return true;
        }

        public bool UnRentACar(int rentId)
        {
            Rentalinformation rental = rentalDal.Get(x => x.Id == rentId);
            if (rental.IsRequest) rental.CustomerID = 0; //istek reddedilirse aracın customeri sıfırla.
            rental.IsActive = false;
            rental.IsRequest = false;
            rental.FinishDate = DateTime.Now;
            rentalDal.Update(rental);

            VehicleInformation vehicle = Get(rental.VehicleID);

            vehicle.CustomerID = 0;
            vehicle.isRentaled = false;

            vehicleDal.Update(vehicle);
            return true;
        }
    }
}

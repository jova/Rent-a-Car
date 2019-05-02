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

        public VehicleManager()
        {
            vehicleDal = IOCUtil.Resolve<IVehicleInformationDal>();
            rentalDal = IOCUtil.Resolve<IRentalinformationDal>();
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
            rentalDal.Update(rental);

            vehicle.CustomerID = customerId;
            vehicle.isRentaled = true;
            return true;
        }

        public bool UnRentACar(int vehicleId)
        {
            VehicleInformation vehicle = Get(vehicleId);
            if (vehicle == null) return false;

            Rentalinformation rental = rentalDal.Get(x => x.VehicleID == vehicleId);
            rentalDal.Delete(rental);

            vehicle.CustomerID = 0;
            vehicle.isRentaled = false;

            return true;
        }
    }
}

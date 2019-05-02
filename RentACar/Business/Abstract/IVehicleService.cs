using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVehicleService
    {
        List<VehicleInformation> GetAll();
        List<VehicleInformation> GetRentaledVehicles();
        VehicleInformation Get(int vehicleId);
        bool RentACar(int vehicleId, int customerId, Rentalinformation rental);
        bool UnRentACar(int vehicleId);
    }
}

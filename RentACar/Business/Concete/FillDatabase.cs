using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concete
{
    public class FillDatabase
    {
        public void Fill() {

            Company company = new Company();
            company.ID = 1;
            company.Name = "ESEM";
            company.City = "Manisa";
            company.Address = "İstiklal Mahallesi, Piyaleoğlu Cd. D:137, 45410 Turgutlu/Manisa";
            company.VehiclesNumber = 5;
            company.Point = 10;

            User user = new User();
            user.ID = 1;
            user.UserName = "denizkilinc";
            user.UserPassword = "5916";

            VehicleInformation vehicleInformation = new VehicleInformation();
            vehicleInformation.ID = 1;
            vehicleInformation.Name = "BMW";
            vehicleInformation.Model=""
        }
    }
}

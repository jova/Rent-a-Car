using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using System.Web.Security;

namespace Business.Concete
{
    public class FillDatabase : IFillDatabaseService
    {
        ICompanyDal companyDal;
        IUserDal userDal;
        IVehicleInformationDal vehicleDal;

        public FillDatabase()
        {
            companyDal = IOCUtil.Resolve<ICompanyDal>();
            userDal = IOCUtil.Resolve<IUserDal>();
            vehicleDal = IOCUtil.Resolve<IVehicleInformationDal>();
        }

        public void Fill() {

            Company company = new Company();
            company.Id = 1;
            company.Name = "Bayram Galeri";
            company.City = "Manisa";
            company.Address = "İstiklal Mahallesi, Piyaleoğlu Cd. D:137, 45410 Turgutlu/Manisa";
            company.VehiclesNumber = 5;
            company.Star = 10;

            User user = new User();
            user.Id = 1;
            user.UserName = "admin";
            user.UserPassword = FormsAuthentication.HashPasswordForStoringInConfigFile("admin", "MD5");

            VehicleInformation vehicleInformation1 = new VehicleInformation();
            vehicleInformation1.Id = 1;
            vehicleInformation1.Name = "BMW";
            vehicleInformation1.Model = "X6";
            vehicleInformation1.Address = "Saadetdere Mahallesi 84. Sokak No:2/4 Avcılar/İstanbul";
            vehicleInformation1.MinLicenseAge = 2;
            vehicleInformation1.MinAge = 20;
            vehicleInformation1.DailyBorderKm = 13350;
            vehicleInformation1.DailyLimitKm = 5000;
            vehicleInformation1.Airbag = true;
            vehicleInformation1.BaggageVolume = 400;
            vehicleInformation1.SeatingCapacity = 5;
            vehicleInformation1.DailyRentalPrice = 240;
            vehicleInformation1.CompanyID = 1;
            vehicleInformation1.CustomerID = 0;
            vehicleInformation1.isRentaled = false;

            VehicleInformation vehicleInformation2 = new VehicleInformation();
            vehicleInformation2.Id = 2;
            vehicleInformation2.Name = "Mercedes";
            vehicleInformation2.Model = "AMG G63";
            vehicleInformation2.Address = "Mustafa Kemal Paşa Mahallesi Anafartalar Sokak No:80/40 Turgutlu/Manisa";
            vehicleInformation2.MinLicenseAge = 2;
            vehicleInformation2.MinAge = 20;
            vehicleInformation2.DailyBorderKm = 25451;
            vehicleInformation1.DailyLimitKm = 2000;
            vehicleInformation2.Airbag = true;
            vehicleInformation2.BaggageVolume = 380;
            vehicleInformation2.SeatingCapacity = 5;
            vehicleInformation2.DailyRentalPrice = 220;
            vehicleInformation2.CompanyID = 1;
            vehicleInformation2.CustomerID = 0;
            vehicleInformation2.isRentaled = false;

            VehicleInformation vehicleInformation3 = new VehicleInformation();
            vehicleInformation3.Id = 3;
            vehicleInformation3.Name = "Porsche";
            vehicleInformation3.Model = "911 Turbo S Exclusive Series";
            vehicleInformation3.Address = "Süleyman Seba Mahallesi Şeref Sokak No:19/03 Beşiktaş/İstanbul";
            vehicleInformation3.MinLicenseAge = 2;
            vehicleInformation3.MinAge = 20;
            vehicleInformation3.DailyBorderKm = 4582;
            vehicleInformation1.DailyLimitKm = 750;
            vehicleInformation3.Airbag = true;
            vehicleInformation3.BaggageVolume = 180;
            vehicleInformation3.SeatingCapacity = 2;
            vehicleInformation3.DailyRentalPrice = 340;
            vehicleInformation3.CompanyID = 1;
            vehicleInformation3.CustomerID = 0;
            vehicleInformation3.isRentaled = false;

            VehicleInformation vehicleInformation4 = new VehicleInformation();
            vehicleInformation4.Id = 4;
            vehicleInformation4.Name = "Lamborghini";
            vehicleInformation4.Model = "Veneno";
            vehicleInformation4.Address = "Şenol Güneş Mahallesi Şampiyon Sokak No:59/16 Konak/İzmir";
            vehicleInformation4.MinLicenseAge = 2;
            vehicleInformation4.MinAge = 20;
            vehicleInformation4.DailyBorderKm = 1400;
            vehicleInformation1.DailyLimitKm = 500;
            vehicleInformation4.Airbag = true;
            vehicleInformation4.BaggageVolume = 140;
            vehicleInformation4.SeatingCapacity = 2;
            vehicleInformation4.DailyRentalPrice = 540;
            vehicleInformation4.CompanyID = 1;
            vehicleInformation4.CustomerID = 0;
            vehicleInformation4.isRentaled = false;

            VehicleInformation vehicleInformation5 = new VehicleInformation();
            vehicleInformation5.Id = 5;
            vehicleInformation5.Name = "Tofaş";
            vehicleInformation5.Model = "Şahin";
            vehicleInformation5.Address = "Su Mahallesi 4. Sokak No:8/2 Kızılay/Ankara";
            vehicleInformation5.MinLicenseAge = 0;
            vehicleInformation5.MinAge = 18;
            vehicleInformation5.DailyBorderKm = 85052;
            vehicleInformation1.DailyLimitKm = 7000;
            vehicleInformation5.Airbag = false;
            vehicleInformation5.BaggageVolume = 200;
            vehicleInformation5.SeatingCapacity = 5;
            vehicleInformation5.DailyRentalPrice = 50;
            vehicleInformation5.CompanyID = 1;
            vehicleInformation5.CustomerID = 0;
            vehicleInformation5.isRentaled = false;

            companyDal.Add(company);
            userDal.Add(user);
            vehicleDal.Add(vehicleInformation1);
            vehicleDal.Add(vehicleInformation2);
            vehicleDal.Add(vehicleInformation3);
            vehicleDal.Add(vehicleInformation4);
            vehicleDal.Add(vehicleInformation5);

        }
    }
}

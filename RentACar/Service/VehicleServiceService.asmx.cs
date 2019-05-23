using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for VehicleServiceService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VehicleServiceService : System.Web.Services.WebService
    {
       
        IVehicleService VehicleService;

        public VehicleServiceService()
        {
            VehicleService = Business.IOCUtil.Resolve<IVehicleService>();
        }

        [WebMethod]
        public List<VehicleInformation> GetAll()
        {
            List<VehicleInformation> vehicleInformation = VehicleService.GetAll();

            return vehicleInformation;
        }



        [WebMethod]
        public List<VehicleInformation> GetRentaledVehicles()
        {
            List<VehicleInformation> getRentaledVehicles = VehicleService.GetRentaledVehicles();

            return getRentaledVehicles;
        }


        [WebMethod]
        public VehicleInformation Get(int vehicleId)
        {
            VehicleInformation vehicleInformation = VehicleService.Get(vehicleId);

            return vehicleInformation;
        }


        [WebMethod]
        public bool RentACar(int vehicleId, int customerId, Rentalinformation rental)
        {
            bool rentACar = VehicleService.RentACar(vehicleId, customerId, rental);

            return rentACar;
        }



        [WebMethod]
        public bool UnRentACar(int vehicleId)
        {
            bool unRentACar = VehicleService.UnRentACar(vehicleId);

            return unRentACar;
        }


    }
}

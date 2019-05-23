using Business.Abstract;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace API.Controllers
{
    [EnableCors(origins: "http://localhost:60170", headers: "*", methods: "*")]
    public class VehiclesController : ApiController
    {
        IVehicleService vehicleService;
        IRentService rentService;
        ILastKmService lastKmService;

        private string[] colors = new string[] { "rgba(191, 240, 142, 0.5)", "rgba(241, 146, 193, 0.5)", "rgba(146, 146, 241, 0.5)", "rgba(245, 15, 15, 0.5)", "rgba(245, 130, 15, 0.5)" };

        public VehiclesController()
        {
            vehicleService = Business.IOCUtil.Resolve<IVehicleService>();
            rentService    = Business.IOCUtil.Resolve<IRentService>();
            lastKmService  = Business.IOCUtil.Resolve<ILastKmService>();
        }

        // GET api/vehicles
        [Route("api/vehicles")]
        [System.Web.Http.HttpGet]
        public List<VehicleInformation> Get()
        {
            List<VehicleInformation> vehicleInformation = vehicleService.GetAll();

            return vehicleInformation;
        }

        // GET api/GetRenteds
        [Route("api/Vehicles/GetRenteds")]
        [System.Web.Http.HttpGet]
        public List<VehicleInformation> GetRenteds()
        {
            List<VehicleInformation> getRentaledVehicles = vehicleService.GetRentaledVehicles();

            return getRentaledVehicles;
        }

        // GET api/vehicles/5
        public VehicleInformation Get(int id)
        {
            VehicleInformation vehicleInformation = vehicleService.Get(id);

            return vehicleInformation;
        }

        //POST api/vehicles/RentACar
        public bool RentACar([FromBody]RentModel model)
        {
            bool rentACar = vehicleService.RentACar(model.vehicleId, model.customerId, model.rent);

            return rentACar;
        }

        //GET api/vehicles/UnRentACar/5
        [Route("api/vehicles/UnRentACar")]
        [System.Web.Http.HttpGet]
        public bool UnRentACar(int id)
        {
            bool unRentACar = vehicleService.UnRentACar(id);

            return unRentACar;
        }

        //GET api/vehicles/HowManyRented
        [Route("api/vehicles/HowManyRented")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult HowManyRented()
        {
            List<Rentalinformation> rents = rentService.GetAll().Where(x => x.IsRequest == false && x.CustomerID != 0 && x.StartDate < DateTime.Now.AddMonths(1)).ToList();
            List<VehicleInformation> vehicles = vehicleService.GetAll();

            List<string> vehicleNames = new List<string>();
            List<int> rentCount = new List<int>();

            foreach (VehicleInformation vehicle in vehicles)
            {
                vehicleNames.Add(vehicle.Name + " " + vehicle.Model);

                int sum = rents.Count(x => x.VehicleID == vehicle.Id);

                rentCount.Add(sum);
            }

            return Ok( new { label = vehicleNames.ToArray(), data = rentCount.ToArray(), bgColor = colors, title = "Son 30 günde kiralanma sayısı" } );
        }

        //GET api/vehicles/AllKmForVehicles
        [Route("api/vehicles/AllKmForVehicles")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult AllKmForVehicles()
        {
            List<Rentalinformation> rents = rentService.GetAll().Where(x => x.IsRequest == false && x.CustomerID != 0 && x.StartDate < DateTime.Now.AddMonths(1)).ToList();
            List<VehicleInformation> vehicles = vehicleService.GetAll();

            List<string> vehicleNames = new List<string>();
            List<int> rentCount = new List<int>();

            foreach (VehicleInformation vehicle in vehicles)
            {
                vehicleNames.Add(vehicle.Name + " " + vehicle.Model);

                int sum = lastKmService.GetVehicleKms(vehicle.Id).Where(x => x.Date < DateTime.Now.AddMonths(1)).Sum(x => x.Km);

                rentCount.Add(sum);
            }

            return Ok( new { label = vehicleNames.ToArray(), data = rentCount.ToArray(), bgColor = colors, title = "Son 30 günde yapılan toplam km" } );
        }

        //GET api/vehicles/GetLastKms
        [Route("api/vehicles/GetLastKms")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetLastKms(int id)
        {
            List<LastKm> lastKms = lastKmService.GetVehicleKms(id).Where(x => x.Date < DateTime.Now.AddMonths(1)).ToList();

            List<string> vehicleNames = new List<string>();
            List<int> rentCount = new List<int>();

            foreach (LastKm lastKm in lastKms)
            {
                vehicleNames.Add(lastKm.Date.Value.ToShortDateString());
                rentCount.Add(lastKm.Km);
            }

            return Ok(new { label = vehicleNames.ToArray(), data = rentCount.ToArray(), bgColor = colors, title = "Son 30 günde yapılan günlük km" });
        }

    }
}
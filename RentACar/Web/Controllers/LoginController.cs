using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.LoginReference;
using Web.VehicleReference;
using Web.CustomerReference;
using Web.RentService;
using Web.Models;
using System.Web.Security;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private LoginServiceSoapClient loginService;
        private VehicleServiceServiceSoapClient vehicleService;
        private CustomerServiceSoapClient customerService;
        private RentServiceSoapClient rentService;

        public LoginController()
        {
            loginService = new LoginServiceSoapClient();
            vehicleService = new VehicleServiceServiceSoapClient();
            customerService = new CustomerServiceSoapClient();
            rentService = new RentServiceSoapClient();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            user.UserPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(user.UserPassword, "MD5");
            bool result = loginService.Login(user.UserName, user.UserPassword);

            if (result)
            {
                Response.SetCookie(new HttpCookie("loggedIn", "true"));
                return RedirectToAction("Admin");
            }
            else return Redirect("/");
        }

        public ActionResult Admin()
        {
            if (Request.Cookies.AllKeys.Contains("loggedIn"))
            {
                List<VehicleReference.VehicleInformation> vehicles = vehicleService.GetAll().ToList();
                TempData["vehicles"] = vehicles;

                List<RentService.Rentalinformation> rents = rentService.GetAll().ToList();

                List<RentRequestViewModel> requests = new List<RentRequestViewModel>();
                List<RentRequestViewModel> renteds = new List<RentRequestViewModel>();

                foreach (var rent in rents)
                {
                    CustomerReference.Customer cust = customerService.Get(rent.CustomerID);
                    VehicleReference.VehicleInformation vehicle = vehicleService.Get(rent.VehicleID);

                    RentRequestViewModel req = new RentRequestViewModel();
                    req.Id = rent.Id;
                    req.CustomerName = cust.Name + " " + cust.Surname;
                    req.TCNumber = cust.TCNumber;
                    req.HowManyDays = rent.HowManyDays;
                    req.VehicleName = vehicle.Name + " " + vehicle.Model;


                    if (rent.IsActive) renteds.Add(req);
                    else requests.Add(req);
                }

                TempData["rentRequests"] = requests;
                TempData["rents"] = renteds;

                return View();
            }
            else
            {
                return Redirect("/");
            }
        }

        [HttpPost]
        public ActionResult Admin(int rentId, int response)
        {
            RentService.Rentalinformation rent = rentService.Get(rentId);

            if (response == 1)
            {
                VehicleReference.Rentalinformation tempRent = new VehicleReference.Rentalinformation()
                {
                    CustomerID = rent.CustomerID,
                    ExtensionData = rent.ExtensionData,
                    VehicleID = rent.VehicleID,
                    HowManyDays = rent.HowManyDays,
                    Id = rent.Id,
                    IsActive = rent.IsActive,
                    LastKm = rent.LastKm,
                    Payment = rent.Payment,
                    StartKm = rent.StartKm
                };

                //kirala
                vehicleService.RentACar(rent.VehicleID, rent.CustomerID, tempRent);
            }
            else if (response == 0)
            {
                vehicleService.UnRentACar(rent.Id);
            }

            return Redirect("/Login/Admin");
        }

    }
}

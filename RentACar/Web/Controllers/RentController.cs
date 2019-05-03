using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.CustomerReference;
using Web.VehicleReference;

namespace Web.Controllers
{
    public class RentController : Controller
    {
        VehicleServiceServiceSoapClient vehicleService;
        CustomerServiceSoapClient customerService;

        public RentController()
        {
            vehicleService  = new VehicleServiceServiceSoapClient();
            customerService = new CustomerServiceSoapClient();
        }

        public ActionResult Index(int vehicleId)
        {
            VehicleInformation vehicle = vehicleService.Get(vehicleId);
            TempData["vehicle"] = vehicle;

            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer customer, int vehicleId, int howManyDays)
        {
            customerService.Add(customer);
            customerService.RentRequest(customer.TCNumber, vehicleId, howManyDays);

            return Redirect("/");
        }
    }
}
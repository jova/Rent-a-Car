using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.VehicleReference;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        VehicleServiceServiceSoapClient vehicleService;

        public HomeController()
        {
            vehicleService = new VehicleServiceServiceSoapClient();
        }

        public ActionResult Index()
        {
            List<VehicleInformation> vehicles = vehicleService.GetAll().ToList();
            return View(vehicles);
        }
    }
}

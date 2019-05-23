using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Web.Models;
using System.Web.Security;
using Entities.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        HttpClient client = new HttpClient();

        public LoginController()
        {
            client.BaseAddress = new Uri("http://localhost:52935/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if(string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.UserName)) return Redirect("/");

            HttpResponseMessage response = client.PostAsJsonAsync("api/login", user).Result;

            bool result = response.Content.ReadAsAsync<bool>().Result;

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
                HttpResponseMessage response = client.GetAsync("api/vehicles").Result;
                List<VehicleInformation> vehicles = response.Content.ReadAsAsync<List<VehicleInformation>>().Result;
                TempData["vehicles"] = vehicles;

                response = client.GetAsync("api/rents").Result;
                List<Rentalinformation> rents = response.Content.ReadAsAsync<List<Rentalinformation>>().Result;

                List<RentRequestViewModel> requests = new List<RentRequestViewModel>();
                List<RentRequestViewModel> renteds = new List<RentRequestViewModel>();

                foreach (var rent in rents)
                {
                    if (rent.CustomerID == 0) continue;

                    response = client.GetAsync("api/customers/" + rent.CustomerID).Result;
                    Customer cust = response.Content.ReadAsAsync<Customer>().Result;

                    response = client.GetAsync("api/vehicles/" + rent.VehicleID).Result;
                    VehicleInformation vehicle = response.Content.ReadAsAsync<VehicleInformation>().Result;

                    RentRequestViewModel req = new RentRequestViewModel();
                    req.Id = rent.Id;
                    req.CustomerName = cust.Name + " " + cust.Surname;
                    req.TCNumber = cust.TCNumber;
                    req.HowManyDays = rent.HowManyDays;
                    req.VehicleName = vehicle.Name + " " + vehicle.Model;

                    if (rent.IsRequest && !rent.IsActive) requests.Add(req);
                    else if(rent.IsActive) renteds.Add(req);
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
        public ActionResult Admin(int rentId, int res)
        {
            HttpResponseMessage response = client.GetAsync("api/rents/" + rentId).Result;
            Rentalinformation rent = response.Content.ReadAsAsync<Rentalinformation>().Result;

            if (res == 1)
            {
                Rentalinformation tempRent = new Rentalinformation()
                {
                    CustomerID = rent.CustomerID,
                    VehicleID = rent.VehicleID,
                    HowManyDays = rent.HowManyDays,
                    Id = rent.Id,
                    IsRequest = rent.IsRequest,
                    IsActive = rent.IsActive,
                    LastKmId = rent.LastKmId,
                    Payment = rent.Payment,
                    StartKm = rent.StartKm
                };

                RentModel model = new RentModel();
                model.rent = tempRent;
                model.vehicleId = rent.VehicleID;
                model.customerId = rent.CustomerID;

                //kirala
                response = client.PostAsJsonAsync("api/vehicles/RentACar", model).Result;
            }
            else if (res == 0)
            {
                response = client.GetAsync("api/vehicles/UnRentACar?id=" + rent.Id).Result;
            }

            return Redirect("/Login/Admin");
        }

        public ActionResult Invoice(int tc)
        {
            HttpResponseMessage response = client.GetAsync("api/Customers/Invoice?tc=" + tc).Result;
            InvoiceModel invoiceModel = response.Content.ReadAsAsync<InvoiceModel>().Result;

            if (invoiceModel ==  null) return HttpNotFound();

            return View(invoiceModel);
        }
    }
}

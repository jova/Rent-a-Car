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

namespace API.Controllers
{
    [EnableCors(origins: "http://localhost:60170", headers: "*", methods: "*")]
    public class CustomersController : ApiController
    {
        ICustomerService customerService;
        IRentService rentService;
        IVehicleService vehicleService;
        ILastKmService lastKmService;

        public CustomersController()
        {
            customerService = Business.IOCUtil.Resolve<ICustomerService>();
            rentService = Business.IOCUtil.Resolve<IRentService>();
            vehicleService = Business.IOCUtil.Resolve<IVehicleService>();
            lastKmService = Business.IOCUtil.Resolve<ILastKmService>();
        }

        // GET api/customers/5
        public Customer Get(int id)
        {
            return customerService.Get(id);
        }


        // GET api/customers
        public List<Customer> Get()
        {
            return customerService.GetList();
        }

        // POST api/customers
        public void Post([FromBody]Customer customer)
        {
            customerService.Add(customer);
        }

        // GET api/Customers/RentRequest?TCNumber=5&vehicleId=5&howManyDays=5
        [System.Web.Http.Route("api/Customers/RentRequest")]
        [System.Web.Http.HttpGet]
        public Rentalinformation RentRequest(int TCNumber, int vehicleId, int howManyDays)
        {
            Rentalinformation rentalinformation = customerService.RentRequest(TCNumber, vehicleId, howManyDays);

            return rentalinformation;
        }

        // GET api/Customers/Invoice?tc=
        [System.Web.Http.Route("api/Customers/Invoice")]
        [System.Web.Http.HttpGet]
        public InvoiceModel Invoice(int tc)
        {
            Customer customer = customerService.GetList().SingleOrDefault(x => x.TCNumber == tc);

            if (customer == null) return null;

            InvoiceModel invoiceModel = new InvoiceModel();
            List<Rentalinformation> rents = rentService.GetAll().Where(x => x.CustomerID == customer.Id).ToList();

            invoiceModel.customer = customer;
            invoiceModel.Rents = rents.Count;
            invoiceModel.RentedDays = rents.Sum(x => x.HowManyDays);
            invoiceModel.Spent = rents.Sum(x => x.Payment);
            invoiceModel.RentedVehicles = new List<VehicleInformation>();

            foreach (Rentalinformation rent in rents)
            {
                VehicleInformation vehicle = vehicleService.Get(rent.VehicleID);
                invoiceModel.RentedVehicles.Add(vehicle);
            }

            return invoiceModel;
        }
    }
}
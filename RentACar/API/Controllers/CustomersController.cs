using Business.Abstract;
using Entities;
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

        public CustomersController()
        {
            customerService = Business.IOCUtil.Resolve<ICustomerService>();
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
    }
}
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using Business.Abstract;

namespace Service
{
    /// <summary>
    /// Summary description for CustomerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerService : System.Web.Services.WebService
    {
        ICustomerService customerService;

        public CustomerService()
        {
            customerService = Business.IOCUtil.Resolve<ICustomerService>();
        }
   
        [WebMethod]
        public Rentalinformation RentRequest(int TCNumber, int vehicleId, int howManyDays)
        {
            Rentalinformation rentalinformation = customerService.RentRequest(TCNumber, vehicleId, howManyDays);

            return rentalinformation;
        }

        [WebMethod]
        public void Add(Customer customer)
        {
            customerService.Add(customer);      
        }

        [WebMethod]
        public Customer Get(int customerId)
        {
           return customerService.Get(customerId);
        }
    }
}

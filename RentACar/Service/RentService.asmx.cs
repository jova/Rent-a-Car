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
    /// Summary description for RentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RentService : System.Web.Services.WebService
    {
        IRentService rentService;
        public RentService()
        {
            rentService= Business.IOCUtil.Resolve<IRentService>();
        }

       
       
        

        [WebMethod]
        public Rentalinformation Get(int rentalId)
        {
            Rentalinformation rentalinformation = rentService.Get(rentalId);
            return rentalinformation;
        }

        [WebMethod]
        public List<Rentalinformation> GetAll()
        {
            List<Rentalinformation> rentalinformations = rentService.GetAll();
            return rentalinformations;
        }


    }
}

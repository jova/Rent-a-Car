using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(origins: "http://localhost:60170", headers: "*", methods: "*")]
    public class CompanyController : ApiController
    {
        ICompanyService companyService;

        public CompanyController()
        {
            companyService = Business.IOCUtil.Resolve<ICompanyService>();
        }

        // GET api/company?id=5
        public Company Get(int id)
        {
            return companyService.Get(id);
        }

        // GET api/company/EarningExpense?id=5
        [Route("api/company/EarningExpense")]
        [HttpGet]
        public IHttpActionResult EarningExpense(int id)
        {
            Company company = companyService.Get(id);

            return Ok( new { label = new string[] { "Gelir", "Gider" }, data = new int[] { company.Earning, company.Expense }, bgColor = new string[] { "rgba(255, 99, 132, 0.3)", "rgba(54, 162, 235, 0.3)" }, title = "Gelir / Gider" } );
        }

    }
}

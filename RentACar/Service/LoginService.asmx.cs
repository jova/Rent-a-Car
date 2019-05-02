using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Business.Abstract;

namespace Service
{
    /// <summary>
    /// Summary description for LoginService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginService : System.Web.Services.WebService
    {
        ILoginService loginService;
        public LoginService()
        {
            loginService = Business.IOCUtil.Resolve<ILoginService>();
        }

        [WebMethod]
        public bool Login(string kullanici,string sifre)
        { 
            bool secenek =loginService.Login(kullanici, sifre);

            return secenek;
        }

         

    }
}

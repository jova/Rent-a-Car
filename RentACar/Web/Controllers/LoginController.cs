using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.LoginReference;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private LoginServiceSoapClient loginService;

        public LoginController()
        {
            loginService = new LoginServiceSoapClient();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
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
                return View();
            }
            else
            {
                return Redirect("/");
            }
        }
    }
}
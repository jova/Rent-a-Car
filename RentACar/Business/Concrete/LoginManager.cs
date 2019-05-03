using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Business.Concete
{
    public class LoginManager : ILoginService
    {
        private IUserDal UserDal;

        public LoginManager(IUserDal accountDal)
        {
            this.UserDal = accountDal;
        }

        public bool Login(string username, string password)
        {
            User user = UserDal.Get(x => x.UserName == username);

            if (user == null) return false;

            user.UserPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
            if (user.UserPassword == password) return true;
            else return false;
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concete
{
    public class LoginManager : ILoginService
    {
        private IUserDal UserDal;

        public LoginManager(IUserDal accountDal)
        {
            this.UserDal = accountDal;
        }

        public bool Login(string username, string password, int roleID)
        {
            User user = UserDal.Get(x => x.UserName == username);

            if (user == null) return false;
            if (user.RoleID != roleID) return false;

            if (user.UserPassword == password) return true;
            else return false;
        }
    }
}

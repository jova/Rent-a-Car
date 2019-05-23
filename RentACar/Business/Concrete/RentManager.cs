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
    public class RentManager : IRentService
    {
        IRentalinformationDal rentalDal;

        public RentManager()
        {
            rentalDal = IOCUtil.Resolve<IRentalinformationDal>();
        }

        public Rentalinformation Get(int rentalId)
        {
            return rentalDal.Get(x=> x.Id == rentalId);
        }

        public List<Rentalinformation> GetAll()
        {
            return rentalDal.GetList();
        }

        public List<Rentalinformation> GetActives()
        {
            return rentalDal.GetList(x => x.IsActive == true || x.IsRequest == true);
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            this.companyDal = companyDal;
        }

        public Company Get(int id)
        {
            return companyDal.Get(x => x.Id == id);
        }
    }
}

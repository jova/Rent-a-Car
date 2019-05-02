using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business
{
    public static class IOCUtil
    {
        private static IWindsorContainer _container;
        private static IWindsorContainer Container { get { if (_container == null) _container = BootstrapContainer(); return _container; } }

        private static IWindsorContainer BootstrapContainer()
        {
            return new WindsorContainer().Register(

                Component.For<ICompanyDal>().ImplementedBy<CompanyDal>(),
                Component.For<ICustomerDal>().ImplementedBy<CustomerDal>(),
                Component.For<IRentalinformationDal>().ImplementedBy<RentalinformationDal>(),
                Component.For<IRoleDal>().ImplementedBy<RoleDal>(),
                Component.For<IUserDal>().ImplementedBy<UserDal>(),
                Component.For<IVehicleInformationDal>().ImplementedBy<VehicleInformationDal>(),

                );
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}

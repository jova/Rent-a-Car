using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concete;
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
                Component.For<IUserDal>().ImplementedBy<UserDal>(),
                Component.For<IVehicleInformationDal>().ImplementedBy<VehicleInformationDal>(),
                Component.For<IFillDatabaseService>().ImplementedBy<FillDatabase>(),
                Component.For<ILoginService>().ImplementedBy<LoginManager>()

                );
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}

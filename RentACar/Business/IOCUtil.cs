using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Business
{
    public static class IOCUtil
    {
        private static IWindsorContainer _container;
        private static IWindsorContainer Container { get { if (_container == null) _container = BootstrapContainer(); return _container; } }

        private static IWindsorContainer BootstrapContainer()
        {
            //return new WindsorContainer().Register(

            //   Component.For< /*interface*/ >().ImplementedBy< /* class */ >());
            return null;
            //TODO: Return DUZELT
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}

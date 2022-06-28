using Castle.Windsor;
using ListasDeCompras.Application;
using ListasDeCompras.Domain.Repositories;
using ListasDeCompras.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public class DependencyInjectionManager
    {
        private WindsorContainer container;

        public DependencyInjectionManager()
        {
            this.container = new WindsorContainer();

            this.container.Register(Castle.MicroKernel.Registration.Component.For<BuyListCreator>());
            this.container.Register(Castle.MicroKernel.Registration.Component.For<BuyListDetails>());
            this.container.Register(Castle.MicroKernel.Registration.Component.For<ProductCreator>());
            this.container.Register(Castle.MicroKernel.Registration.Component.For<ExistingLists>());
            this.container.Register(Castle.MicroKernel.Registration.Component.For<ProductRemover>());

            this.container.Register(Castle.MicroKernel.Registration.Component.For<BuyListRepository>().ImplementedBy<BuyListMySQLRepository>());
            this.container.Register(Castle.MicroKernel.Registration.Component.For<ProductRepository>().ImplementedBy<ProductMySQLRepository>());
        }

        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }
    }
}

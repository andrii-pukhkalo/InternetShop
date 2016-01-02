using System;
using Ninject.Modules;
using InternetShop.DAL.Interfaces;
using InternetShop.DAL.Repositories;

namespace InternetShop.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;

        public ServiceModule(string connection) {
            this.connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}

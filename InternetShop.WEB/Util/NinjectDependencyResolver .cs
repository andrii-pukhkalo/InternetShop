using InternetShop.BLL.Services;
using System.Web.Mvc;
using Ninject;
using System.Collections.Generic;
using System;
using InternetShop.BLL.Interfaces;

namespace InternetShop.WEB.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelPapam) {
            this.kernel = kernelPapam;
            AddBinding();
        }

        private void AddBinding()
        {
            kernel.Bind<IProductService>().To<ProductService>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}
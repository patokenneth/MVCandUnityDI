using MVCandUnityDI.Repository.Interface;
using MVCandUnityDI.Repository.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVCandUnityDI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //Registered my dependency here
            container.RegisterType<IProductRepository, ProductRepository>();

            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
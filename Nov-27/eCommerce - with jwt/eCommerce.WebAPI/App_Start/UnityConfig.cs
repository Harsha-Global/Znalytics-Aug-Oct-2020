using eCommerce.BusinessLogicLayer;
using eCommerce.DataAccessLayer;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace eCommerce.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICustomersBusinessLogic, CustomersBusinessLogic>();
            container.RegisterType<ICustomersDataAccess, CustomersDataAccess>();
            container.RegisterType<IUsersBusinessLogic, UsersBusinessLogic>();
            container.RegisterType<IUsersDataAccess, UsersDataAccess>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
using AspNetMvcApi_BLL.ContractBLL;
using AspNetMvcApi_BLL.ImplementationBLL;
using AspNetMvcApi_DAL.Contracts;
using AspNetMvcApi_DAL.Implementations;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace AspNetMvcApi_PL
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStudentService, StudentService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
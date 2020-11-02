using Holtz_BookStore.API.Data;
using Holtz_BookStore.API.Repositories;
using Holtz_BookStore.API.Repositories.Contracts;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Holtz_BookStore.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<Datacontext, Datacontext>();
            container.RegisterType<IAuthorRepository, AuthorRepository>();
            container.RegisterType<IBookRepository, BookRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            UnityConfig.RegisterComponents();
        }
    }
}
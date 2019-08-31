namespace StudentSystem.Clients.Web
{
    using System.Reflection;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    using SimpleInjector.Packaging;
    using StudentSystem.Infrastructure.Clients.Web.Mapping;
    using StudentSystem.IoCContainer.Packages.Common;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Container container = new Container();

            IPackage[] packages = new IPackage[]
            {
                new ApiPackage(),
                new CommonPackage()
            };

            foreach (var package in packages)
            {
                package.RegisterServices(container);
            }

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            AutoMapperConfig.RegisterMappings(Assembly.GetExecutingAssembly());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
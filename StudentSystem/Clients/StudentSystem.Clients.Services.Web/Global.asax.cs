namespace StudentSystem.Clients.Services.Web
{
    using System.Reflection;

    using SimpleInjector;
    using SimpleInjector.Integration.Wcf;
    using SimpleInjector.Packaging;

    using StudentSystem.IoCContainer.Packages.Common;
    using StudentSystem.IoCContainer.Packages.Data;
    using StudentSystem.IoCContainer.Packages.Services;

    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            Container container = new Container();
            container.RegisterWcfServices(Assembly.GetExecutingAssembly());

            IPackage[] packages = new IPackage[]
            {
                new DataMappersPackage(),
                new QueryHandlersPackage(),
                new WebMappersPackage(),
                new WebServicesPackage(),
                new CommonPackage()
            };

            foreach (var package in packages)
            {
                package.RegisterServices(container);
            }

            SimpleInjectorServiceHostFactory.SetContainer(container);
        }
    }
}
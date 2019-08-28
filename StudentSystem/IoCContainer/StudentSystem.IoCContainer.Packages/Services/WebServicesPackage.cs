namespace StudentSystem.IoCContainer.Packages.Services
{
    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Services.Web;
    using StudentSystem.Services.Web.Contracts;

    public sealed class WebServicesPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IStudentsService, StudentsService>(Lifestyle.Transient);
        }
    }
}
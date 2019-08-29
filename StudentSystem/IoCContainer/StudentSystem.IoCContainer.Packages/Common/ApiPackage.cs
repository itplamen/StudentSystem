namespace StudentSystem.IoCContainer.Packages.Common
{
    using System.Net.Http;

    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Services.Api;
    using StudentSystem.Services.Api.Contracts;

    public sealed class ApiPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IStudentSystemApi, StudentSystemApi>(Lifestyle.Singleton);
            container.RegisterDecorator<IStudentSystemApi, StudentSystemApiLoggingDecorator>(Lifestyle.Singleton);

            container.Register(() => new HttpClient(), Lifestyle.Singleton);
        }
    }
}
namespace StudentSystem.IoCContainer.Packages.Common
{
    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Services.Api;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public sealed class ApiPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IRequestsExecutor, RequestsExecutor>(Lifestyle.Singleton);
            container.RegisterDecorator<IRequestsExecutor, RequestsExecutorLoggingDecorator>(Lifestyle.Singleton);

            container.Register<IStudentSystemApi, StudentSystemApi>(Lifestyle.Singleton);
            container.Register(() => new ProfessorsServiceClient(), Lifestyle.Singleton);
            container.Register(() => new StudentsServiceClient(), Lifestyle.Singleton);
        }
    }
}
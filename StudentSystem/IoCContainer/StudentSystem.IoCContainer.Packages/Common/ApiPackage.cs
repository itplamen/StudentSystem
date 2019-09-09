namespace StudentSystem.IoCContainer.Packages.Common
{
    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Services.Api;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.DisciplinesServiceSoap;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;
    using StudentSystem.Services.Api.ReportsServiceSoap;
    using StudentSystem.Services.Api.ScoresServiceSoap;
    using StudentSystem.Services.Api.SemestersServiceSoap;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public sealed class ApiPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IStudentSystemApi, StudentSystemApi>(Lifestyle.Singleton);
            container.RegisterDecorator<IStudentSystemApi, StudentSystemApiLoggingDecorator>(Lifestyle.Singleton);

            container.Register(() => new ScoresServiceClient(), Lifestyle.Singleton);
            container.Register(() => new StudentsServiceClient(), Lifestyle.Singleton);
            container.Register(() => new SemestersServiceClient(), Lifestyle.Singleton);
            container.Register(() => new ProfessorsServiceClient(), Lifestyle.Singleton);
            container.Register(() => new DisciplinesServiceClient(), Lifestyle.Singleton);
            container.Register(() => new ReportsServiceClient(), Lifestyle.Singleton);
        }
    }
}
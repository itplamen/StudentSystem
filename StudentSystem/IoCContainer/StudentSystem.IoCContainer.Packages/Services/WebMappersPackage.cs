namespace StudentSystem.IoCContainer.Packages.Services
{
    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web;
    using StudentSystem.Services.Web.Mappers;

    public sealed class WebMappersPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register(typeof(IMapper<Student, StudentModel>), typeof(StudentsMapper), Lifestyle.Singleton);
        }
    }
}
namespace StudentSystem.IoCContainer.Packages.Data
{
    using System.Collections.Generic;

    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Packaging;

    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Data.Queries.Students;

    public sealed class QueryHandlersPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IQueryHandler<IEnumerable<Student>>, AllStudentsQueryHandler>(new WebRequestLifestyle());
        }
    }
}
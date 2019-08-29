namespace StudentSystem.IoCContainer.Packages.Data
{
    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Data;
    using StudentSystem.Data.Contracts;

    public sealed class ExecutorsPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<ISqlQueryExecutor, SqlQueryExecutor>(Lifestyle.Transient);
        }
    }
}
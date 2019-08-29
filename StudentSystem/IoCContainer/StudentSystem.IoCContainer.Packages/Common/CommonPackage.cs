namespace StudentSystem.IoCContainer.Packages.Common
{
    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Common.Loggers;

    public sealed class CommonPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<ILoggerFactory, LoggerFactory>(Lifestyle.Singleton);
        }
    }
}
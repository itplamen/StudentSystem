﻿namespace StudentSystem.IoCContainer.Packages.Data
{
    using System.Data.SqlClient;

    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Mappers;
    using StudentSystem.Data.Models;

    public sealed class DataMappersPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register(typeof(IMapper<SqlDataReader, Student>), typeof(StudentsMapper), Lifestyle.Singleton);
        }
    }
}
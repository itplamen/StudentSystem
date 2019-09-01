﻿namespace StudentSystem.IoCContainer.Packages.Services
{
    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Models.Web.Scores;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Models.Web.Students;
    using StudentSystem.Services.Web;
    using StudentSystem.Services.Web.Contracts;
    using StudentSystem.Services.Web.Mappers;

    public sealed class WebServicesPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            RegisterWebServices(container);
            RegisterMappers(container);
        }

        public void RegisterWebServices(Container container)
        {
            container.Register<IStudentsService, StudentsService>(Lifestyle.Transient);
        }

        public void RegisterMappers(Container container)
        {
            container.Register(typeof(IMapper<Score, ScoreResponseModel>), typeof(ScoresMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<Student, StudentResponseModel>), typeof(StudentsMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<Semester, SemesterResponseModel>), typeof(SemestersMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<Professor, ProfessorResponseModel>), typeof(ProfessorsMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<Discipline, DisciplineResponseModel>), typeof(DisciplinesMapper), Lifestyle.Singleton);
        }
    }
}
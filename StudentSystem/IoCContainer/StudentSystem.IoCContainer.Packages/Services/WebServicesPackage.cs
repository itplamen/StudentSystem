namespace StudentSystem.IoCContainer.Packages.Services
{
    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Common.Validators;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Models.Web.Scores;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Models.Web.Students;
    using StudentSystem.Services.Web.Builders;
    using StudentSystem.Services.Web.Mappers;
    using StudentSystem.Services.Web.Validators.Students;

    public sealed class WebServicesPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            RegisterMappers(container);
            RegisterValidators(container);
            RegisterBuilders(container);
        }

        public void RegisterMappers(Container container)
        {
            container.Register(typeof(IMapper<Score, ScoreResponseModel>), typeof(ScoresMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<Student, StudentResponseModel>), typeof(StudentsMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<Semester, SemesterResponseModel>), typeof(SemestersMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<Professor, ProfessorResponseModel>), typeof(ProfessorsMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<Discipline, DisciplineResponseModel>), typeof(DisciplinesMapper), Lifestyle.Singleton);
        }

        public void RegisterValidators(Container container)
        {
            container.Register(typeof(IValidator<StudentRequestModel>), typeof(ValidatorComposite<StudentRequestModel>), Lifestyle.Singleton);
            container.Collection.Append(typeof(IValidator<StudentRequestModel>), typeof(StudentNameValidator), Lifestyle.Singleton);
            container.Collection.Append(typeof(IValidator<StudentRequestModel>), typeof(StudentEmailValidator), Lifestyle.Singleton);
        }

        public void RegisterBuilders(Container container)
        {
            container.Register(typeof(IBuilder<Semester, SemesterResponseModel>), typeof(SemestersBuilder), Lifestyle.Singleton);
            container.Register(typeof(IBuilder<Discipline, DisciplineResponseModel>), typeof(DisciplinesBuilder), Lifestyle.Singleton);
        }
    }
}
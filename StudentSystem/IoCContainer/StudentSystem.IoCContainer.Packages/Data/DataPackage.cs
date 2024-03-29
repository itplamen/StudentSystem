﻿namespace StudentSystem.IoCContainer.Packages.Data
{
    using System.Collections.Generic;
    using System.Data.SqlClient;

    using SimpleInjector;
    using SimpleInjector.Packaging;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data;
    using StudentSystem.Data.Builders.StudentDetails;
    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Commands.Disciplines;
    using StudentSystem.Data.Commands.Professors;
    using StudentSystem.Data.Commands.Scores;
    using StudentSystem.Data.Commands.Semesters;
    using StudentSystem.Data.Commands.Students;
    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Mappers;
    using StudentSystem.Data.Models;
    using StudentSystem.Data.Queries.Common;
    using StudentSystem.Data.Queries.Professors;
    using StudentSystem.Data.Queries.Reports;

    public sealed class DataPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            RegisterBuildrs(container);
            RegisterMappers(container);
            RegisterExecutors(container);
            RegisterQueryHandlers(container);
            RegisterCommandHandlers(container);
        }

        private void RegisterBuildrs(Container container)
        {
            container.Register(typeof(IBuilder<SqlDataReader, Student>), typeof(StudentsBuilder), Lifestyle.Singleton);
            container.Register(typeof(IBuilder<SqlDataReader, Semester>), typeof(SemestersBuilder), Lifestyle.Singleton);
            container.Register(typeof(IBuilder<SqlDataReader, Discipline>), typeof(DisciplinesBuilder), Lifestyle.Singleton);
            container.Register(typeof(IBuilder<SqlDataReader, Professor>), typeof(ProfessorsBuilder), Lifestyle.Singleton);
            container.Register(typeof(IBuilder<SqlDataReader, Score>), typeof(ScoresBuilder), Lifestyle.Singleton);
        }

        private void RegisterMappers(Container container)
        {
            container.Register(typeof(IMapper<SqlDataReader, Student>), typeof(StudentsMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<SqlDataReader, Semester>), typeof(SemestersMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<SqlDataReader, Discipline>), typeof(DisciplinesMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<SqlDataReader, Professor>), typeof(ProfessorsMapper), Lifestyle.Singleton);
            container.Register(typeof(IMapper<SqlDataReader, Score>), typeof(ScoresMapper), Lifestyle.Singleton);
        }

        private void RegisterExecutors(Container container)
        {
            container.Register<ISqlQueryExecutor, SqlQueryExecutor>(Lifestyle.Transient);
        }

        private void RegisterQueryHandlers(Container container)
        {
            container.Register(typeof(IQueryHandler<,>), typeof(AllEntitiesQueryHandler<>), Lifestyle.Transient);
            container.Register(typeof(IQueryHandler<,>), typeof(EntityByIdQueryHandler<>), Lifestyle.Transient);
            container.Register<IQueryHandler<IEnumerable<Semester>>, SemestersReportQueryHandler>(Lifestyle.Transient);

            container.Register<IQueryHandler<ProfessorByIdQuery, Professor>, ProfessorByIdQueryHandler>(Lifestyle.Transient);
        }

        private void RegisterCommandHandlers(Container container)
        {
            container.Register<ICommandHandler<EntityCommand, int>, CreateEntityCommandHandler>(Lifestyle.Transient);
            container.Register<ICommandHandler<UpdateEntityCommand, bool>, UpdateEntityCommandHandler> (Lifestyle.Transient);
            container.Register<ICommandHandler<DeleteEntityCommand, bool>, DeleteEntityCommandHandler>(Lifestyle.Transient);

            container.Register<ICommandHandler<ScoreCommand, Score>, CreateScoreCommandHandler>(Lifestyle.Transient);
            container.Register<ICommandHandler<UpdateScoreCommand, Score>, UpdateScoreCommandHandler>(Lifestyle.Transient);

            container.Register<ICommandHandler<StudentCommand, Student>, CreateStudentCommandHandler>(Lifestyle.Transient);
            container.Register<ICommandHandler<UpdateStudentCommand, Student>, UpdateStudentCommandHandler>(Lifestyle.Transient);

            container.Register<ICommandHandler<SemesterCommand, Semester>, CreateSemesterCommandHandler>(Lifestyle.Transient);
            container.Register<ICommandHandler<UpdateSemesterCommand, Semester>, UpdateSemesterCommandHander>(Lifestyle.Transient);

            container.Register<ICommandHandler<ProfessorCommand, Professor>, CreateProfessorCommandHandler>(Lifestyle.Transient);
            container.Register<ICommandHandler<UpdateProfessorCommand, Professor>, UpdateProfessorCommandHandler>(Lifestyle.Transient);

            container.Register<ICommandHandler<DisciplineCommand, Discipline>, CreateDisciplineCommandHandler>(Lifestyle.Transient);
            container.Register<ICommandHandler<UpdateDisciplineCommand, Discipline>, UpdateDisciplineCommandHandler>(Lifestyle.Transient);
        }
    }
}
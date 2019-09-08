namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Commands.Semesters;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Data.Queries.Common;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Web.Contracts;

    public class SemestersService : ISemestersService
    {
        private const string TABLE_NAME = "Semesters";

        private readonly IMapper<Semester, SemesterResponseModel> semestersMapper;
        private readonly ICommandHandler<SemesterCommand, Semester> createSemesterHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteSemesterHandler;
        private readonly ICommandHandler<UpdateSemesterCommand, Semester> updateSemesterHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Semester>, IEnumerable<Semester>> getAllSemestersHandler;

        public SemestersService(
            IMapper<Semester, SemesterResponseModel> semestersMapper,
            ICommandHandler<SemesterCommand, Semester> createSemesterHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteSemesterHandler,
            ICommandHandler<UpdateSemesterCommand, Semester> updateSemesterHandler,
            IQueryHandler<AllEntitiesQuery<Semester>, IEnumerable<Semester>> getAllSemestersHandler)
        {
            this.semestersMapper = semestersMapper;
            this.createSemesterHandler = createSemesterHandler;
            this.deleteSemesterHandler = deleteSemesterHandler;
            this.updateSemesterHandler = updateSemesterHandler;
            this.getAllSemestersHandler = getAllSemestersHandler;
        }

        public SemesterResponseModel Create(SemesterRequestModel request)
        {
            SemesterCommand command = new SemesterCommand(request.Name, request.StartDate, request.EndDate);
            Semester semester = createSemesterHandler.Handle(command);

            SemesterResponseModel response = semestersMapper.Map(semester);

            return response;
        }

        public IEnumerable<SemesterResponseModel> All()
        {
            AllEntitiesQuery<Semester> query = new AllEntitiesQuery<Semester>(TABLE_NAME, false);
            IEnumerable<Semester> semesters = getAllSemestersHandler.Handle(query);

            IEnumerable<SemesterResponseModel> responseModels = semestersMapper.Map(semesters);

            return responseModels;
        }

        public SemesterResponseModel Update(int id, SemesterRequestModel request)
        {
            UpdateSemesterCommand command = new UpdateSemesterCommand(id, request.Name, request.StartDate, request.EndDate);
            Semester semester = updateSemesterHandler.Handle(command);

            SemesterResponseModel response = semestersMapper.Map(semester);

            return response;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteSemesterHandler.Handle(command);

            return isDeleted;
        }
    }
}
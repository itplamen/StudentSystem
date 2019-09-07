namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Commands.Common;
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
        private readonly ICommandHandler<EntityCommand, int> createSemesterHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteSemesterHandler;
        private readonly ICommandHandler<UpdateEntityCommand, bool> updateSemesterHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Semester>, IEnumerable<Semester>> getAllSemestersHandler;

        public SemestersService(
            IMapper<Semester, SemesterResponseModel> semestersMapper,
            ICommandHandler<EntityCommand, int> createSemesterHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteSemesterHandler,
            ICommandHandler<UpdateEntityCommand, bool> updateSemesterHandler,
            IQueryHandler<AllEntitiesQuery<Semester>, IEnumerable<Semester>> getAllSemestersHandler)
        {
            this.semestersMapper = semestersMapper;
            this.createSemesterHandler = createSemesterHandler;
            this.deleteSemesterHandler = deleteSemesterHandler;
            this.updateSemesterHandler = updateSemesterHandler;
            this.getAllSemestersHandler = getAllSemestersHandler;
        }

        public bool Create(SemesterRequestModel request)
        {
            EntityCommand command = new EntityCommand(TABLE_NAME);
            command.Columns.Add(nameof(request.Name), request.Name);
            command.Columns.Add(nameof(request.StartDate), request.StartDate);
            command.Columns.Add(nameof(request.EndDate), request.EndDate);

            int id = createSemesterHandler.Handle(command);

            return id > 0;
        }

        public IEnumerable<SemesterResponseModel> All()
        {
            AllEntitiesQuery<Semester> query = new AllEntitiesQuery<Semester>(TABLE_NAME, false);
            IEnumerable<Semester> semesters = getAllSemestersHandler.Handle(query);

            IEnumerable<SemesterResponseModel> responseModels = semestersMapper.Map(semesters);

            return responseModels;
        }

        public bool Update(UpdateSemesterRequestModel request)
        {
            UpdateEntityCommand command = new UpdateEntityCommand(TABLE_NAME, request.Id);
            command.Columns.Add(nameof(request.Name), request.Name);
            command.Columns.Add(nameof(request.StartDate), request.StartDate);
            command.Columns.Add(nameof(request.EndDate), request.EndDate);

            bool isUpdated = updateSemesterHandler.Handle(command);

            return isUpdated;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteSemesterHandler.Handle(command);

            return isDeleted;
        }
    }
}
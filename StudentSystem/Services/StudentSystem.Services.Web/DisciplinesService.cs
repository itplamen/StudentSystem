namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Data.Queries.Common;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Web.Contracts;

    public class DisciplinesService : IDisciplinesService
    {
        private const string TABLE_NAME = "Disciplines";

        private readonly IMapper<Discipline, DisciplineResponseModel> disciplinesMapper;
        private readonly ICommandHandler<EntityCommand, int> createDisciplineHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteDisciplineHandler;
        private readonly ICommandHandler<UpdateEntityCommand, bool> updateDisciplineHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Discipline>, IEnumerable<Discipline>> getAllDisciplinesHandler;

        public DisciplinesService(
            IMapper<Discipline, DisciplineResponseModel> disciplinesMapper,
            ICommandHandler<EntityCommand, int> createDisciplineHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteDisciplineHandler,
            ICommandHandler<UpdateEntityCommand, bool> updateDisciplineHandler,
            IQueryHandler<AllEntitiesQuery<Discipline>, IEnumerable<Discipline>> getAllDisciplinesHandler)
        {
            this.disciplinesMapper = disciplinesMapper;
            this.createDisciplineHandler = createDisciplineHandler;
            this.deleteDisciplineHandler = deleteDisciplineHandler;
            this.updateDisciplineHandler = updateDisciplineHandler;
            this.getAllDisciplinesHandler = getAllDisciplinesHandler;
        }

        public bool Create(DisciplineRequestModel request)
        {
            EntityCommand command = new EntityCommand(TABLE_NAME);
            command.Columns.Add(nameof(request.Name), request.Name);
            command.Columns.Add(nameof(request.SemesterId), request.SemesterId);
            command.Columns.Add(nameof(request.ProfessorId), request.ProfessorId);

            int id = createDisciplineHandler.Handle(command);

            return id > 0;
        }

        public IEnumerable<DisciplineResponseModel> Get()
        {
            AllEntitiesQuery<Discipline> query = new AllEntitiesQuery<Discipline>(TABLE_NAME, false);
            IEnumerable<Discipline> disciplines = getAllDisciplinesHandler.Handle(query);

            IEnumerable<DisciplineResponseModel> responseModels = disciplinesMapper.Map(disciplines);

            return responseModels;
        }

        public bool Update(UpdateDisciplineRequestModel request)
        {
            UpdateEntityCommand command = new UpdateEntityCommand(TABLE_NAME, request.Id);
            command.Columns.Add(nameof(request.Name), request.Name);
            command.Columns.Add(nameof(request.SemesterId), request.SemesterId);
            command.Columns.Add(nameof(request.ProfessorId), request.ProfessorId);

            bool isUpdated = updateDisciplineHandler.Handle(command);

            return isUpdated;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteDisciplineHandler.Handle(command);

            return isDeleted;
        }
    }
}
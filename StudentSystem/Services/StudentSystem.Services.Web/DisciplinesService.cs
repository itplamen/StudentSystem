namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Commands.Disciplines;
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
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteDisciplineHandler;
        private readonly ICommandHandler<DisciplineCommand, Discipline> createDisciplineHandler;
        private readonly ICommandHandler<UpdateDisciplineCommand, Discipline> updateDisciplineHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Discipline>, IEnumerable<Discipline>> getAllDisciplinesHandler;

        public DisciplinesService(
            IMapper<Discipline, DisciplineResponseModel> disciplinesMapper,
            ICommandHandler<DeleteEntityCommand, bool> deleteDisciplineHandler,
            ICommandHandler<DisciplineCommand, Discipline> createDisciplineHandler,
            ICommandHandler<UpdateDisciplineCommand, Discipline> updateDisciplineHandler,
            IQueryHandler<AllEntitiesQuery<Discipline>, IEnumerable<Discipline>> getAllDisciplinesHandler)
        {
            this.disciplinesMapper = disciplinesMapper;
            this.createDisciplineHandler = createDisciplineHandler;
            this.deleteDisciplineHandler = deleteDisciplineHandler;
            this.updateDisciplineHandler = updateDisciplineHandler;
            this.getAllDisciplinesHandler = getAllDisciplinesHandler;
        }

        public DisciplineResponseModel Create(DisciplineRequestModel request)
        {
            DisciplineCommand command = new DisciplineCommand(request.Name, request.SemesterId, request.ProfessorId);
            Discipline discipline = createDisciplineHandler.Handle(command);

            DisciplineResponseModel response = disciplinesMapper.Map(discipline);

            return response;
        }

        public IEnumerable<DisciplineResponseModel> All()
        {
            AllEntitiesQuery<Discipline> query = new AllEntitiesQuery<Discipline>(TABLE_NAME, false);
            IEnumerable<Discipline> disciplines = getAllDisciplinesHandler.Handle(query);

            IEnumerable<DisciplineResponseModel> responseModels = disciplinesMapper.Map(disciplines);

            return responseModels;
        }

        public DisciplineResponseModel Update(UpdateDisciplineRequestModel request)
        {
            UpdateDisciplineCommand command = new UpdateDisciplineCommand(request.Id, request.Name, request.SemesterId, request.ProfessorId);
            Discipline discipline = updateDisciplineHandler.Handle(command);

            DisciplineResponseModel response = disciplinesMapper.Map(discipline);

            return response;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteDisciplineHandler.Handle(command);

            return isDeleted;
        }
    }
}
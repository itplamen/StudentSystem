namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Commands.Professors;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Data.Queries.Common;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Web.Contracts;

    public class ProfessorsService : IProfessorsService
    {
        private const string TABLE_NAME = "Professors";

        private readonly IMapper<Professor, ProfessorResponseModel> professorsMapper;
        private readonly ICommandHandler<EntityCommand, int> createProfessorHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteProfessorHandler;
        private readonly ICommandHandler<UpdateProfessorCommand, bool> updateProfessorHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Professor>, IEnumerable<Professor>> getAllProfessorsHandler;

        public ProfessorsService(
            IMapper<Professor, ProfessorResponseModel> professorsMapper,
            ICommandHandler<EntityCommand, int> createProfessorHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteProfessorHandler,
            ICommandHandler<UpdateProfessorCommand, bool> updateProfessorHandler,
            IQueryHandler<AllEntitiesQuery<Professor>, IEnumerable<Professor>> getAllProfessorsHandler)
        {
            this.professorsMapper = professorsMapper;
            this.createProfessorHandler = createProfessorHandler;
            this.deleteProfessorHandler = deleteProfessorHandler;
            this.updateProfessorHandler = updateProfessorHandler;
            this.getAllProfessorsHandler = getAllProfessorsHandler;
        }

        public bool Create(ProfessorRequestModel request)
        {
            EntityCommand command = new EntityCommand(TABLE_NAME);
            command.Columns.Add(nameof(request.FirstName), request.FirstName);
            command.Columns.Add(nameof(request.LastName), request.LastName);

            int id = createProfessorHandler.Handle(command);

            return id > 0;
        }

        public IEnumerable<ProfessorResponseModel> GetAll()
        {
            AllEntitiesQuery<Professor> query = new AllEntitiesQuery<Professor>(TABLE_NAME, false);
            IEnumerable <Professor> professors = getAllProfessorsHandler.Handle(query);

            IEnumerable<ProfessorResponseModel> responseModels = professorsMapper.Map(professors);

            return responseModels;
        }

        public bool Update(UpdateProfessorRequestModel request)
        {
            UpdateProfessorCommand command = new UpdateProfessorCommand(request.Id, request.FirstName, request.LastName);
            bool isUpdated = updateProfessorHandler.Handle(command);

            return isUpdated;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteProfessorHandler.Handle(command);

            return isDeleted;
        }
    }
}
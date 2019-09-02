namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Commands.Professors;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Web.Contracts;

    public class ProfessorsService : IProfessorsService
    {
        private readonly IMapper<Professor, ProfessorResponseModel> professorsMapper;
        private readonly IQueryHandler<IEnumerable<Professor>> getAllProfessorsHandler;
        private readonly ICommandHandler<ProfessorCommand, int> createProfessorHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteProfessorHandler;
        private readonly ICommandHandler<UpdateProfessorCommand, bool> updateProfessorHandler;

        public ProfessorsService(
            IMapper<Professor, ProfessorResponseModel> professorsMapper,
            IQueryHandler<IEnumerable<Professor>> getAllProfessorsHandler,
            ICommandHandler<ProfessorCommand, int> createProfessorHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteProfessorHandler,
            ICommandHandler<UpdateProfessorCommand, bool> updateProfessorHandler)
        {
            this.professorsMapper = professorsMapper;
            this.getAllProfessorsHandler = getAllProfessorsHandler;
            this.createProfessorHandler = createProfessorHandler;
            this.deleteProfessorHandler = deleteProfessorHandler;
            this.updateProfessorHandler = updateProfessorHandler;
        }

        public bool Create(ProfessorRequestModel request)
        {
            ProfessorCommand command = new ProfessorCommand(request.FirstName, request.LastName);
            int id = createProfessorHandler.Handle(command);

            return id > 0;
        }

        public IEnumerable<ProfessorResponseModel> GetAll()
        {
            IEnumerable<Professor> professors = getAllProfessorsHandler.Handle();
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
            DeleteEntityCommand command = new DeleteEntityCommand(id, "Professors");
            bool isDeleted = deleteProfessorHandler.Handle(command);

            return isDeleted;
        }
    }
}
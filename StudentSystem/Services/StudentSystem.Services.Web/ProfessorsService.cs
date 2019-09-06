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
    using StudentSystem.Data.Queries.Professors;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Web.Contracts;

    public class ProfessorsService : IProfessorsService
    {
        private const string TABLE_NAME = "Professors";

        private readonly IMapper<Professor, ProfessorResponseModel> professorsMapper;
        private readonly IQueryHandler<ProfessorByIdQuery, Professor> professorByIdHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteProfessorHandler;
        private readonly ICommandHandler<ProfessorCommand, Professor> createProfessorHandler;
        private readonly ICommandHandler<UpdateProfessorCommand, Professor> updateProfessorHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Professor>, IEnumerable<Professor>> allProfessorsHandler;

        public ProfessorsService(
            IMapper<Professor, ProfessorResponseModel> professorsMapper,
            IQueryHandler<ProfessorByIdQuery, Professor> professorByIdHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteProfessorHandler,
            ICommandHandler<ProfessorCommand, Professor> createProfessorHandler,
            ICommandHandler<UpdateProfessorCommand, Professor> updateProfessorHandler,
            IQueryHandler<AllEntitiesQuery<Professor>, IEnumerable<Professor>> allProfessorsHandler)
        {
            this.professorsMapper = professorsMapper;
            this.professorByIdHandler = professorByIdHandler;
            this.createProfessorHandler = createProfessorHandler;
            this.deleteProfessorHandler = deleteProfessorHandler;
            this.updateProfessorHandler = updateProfessorHandler;
            this.allProfessorsHandler = allProfessorsHandler;
        }

        public ProfessorResponseModel Create(ProfessorRequestModel request)
        {
            ProfessorCommand command = new ProfessorCommand(request.FirstName, request.LastName);
            Professor professor = createProfessorHandler.Handle(command);

            ProfessorResponseModel response = professorsMapper.Map(professor);

            return response;
        }

        public ProfessorResponseModel Get(int id)
        {
            ProfessorByIdQuery query = new ProfessorByIdQuery(id);
            Professor professor = professorByIdHandler.Handle(query);

            ProfessorResponseModel response = professorsMapper.Map(professor);

            return response;
        }

        public IEnumerable<ProfessorResponseModel> All()
        {
            AllEntitiesQuery<Professor> query = new AllEntitiesQuery<Professor>(TABLE_NAME, false);
            IEnumerable<Professor> professors = allProfessorsHandler.Handle(query);

            IEnumerable<ProfessorResponseModel> responseModels = professorsMapper.Map(professors);

            return responseModels;
        }

        public ProfessorResponseModel Update(int id, ProfessorRequestModel request)
        {
            UpdateProfessorCommand command = new UpdateProfessorCommand(id, request.FirstName, request.LastName);
            Professor professor = updateProfessorHandler.Handle(command);

            ProfessorResponseModel response = professorsMapper.Map(professor);

            return response;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteProfessorHandler.Handle(command);

            return isDeleted;
        }
    }
}
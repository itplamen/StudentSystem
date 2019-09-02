namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
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

        public ProfessorsService(
            IMapper<Professor, ProfessorResponseModel> professorsMapper,
            IQueryHandler<IEnumerable<Professor>> getAllProfessorsHandler,
            ICommandHandler<ProfessorCommand, int> createProfessorHandler)
        {
            this.professorsMapper = professorsMapper;
            this.getAllProfessorsHandler = getAllProfessorsHandler;
            this.createProfessorHandler = createProfessorHandler;
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
    }
}
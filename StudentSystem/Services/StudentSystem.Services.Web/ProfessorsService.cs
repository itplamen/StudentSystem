namespace StudentSystem.Services.Web
{
    using StudentSystem.Data.Commands.Professors;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Web.Contracts;

    public class ProfessorsService : IProfessorsService
    {
        private readonly ICommandHandler<ProfessorCommand, int> createProfessorHandler;

        public ProfessorsService(ICommandHandler<ProfessorCommand, int> createProfessorHandler)
        {
            this.createProfessorHandler = createProfessorHandler;
        }

        public bool Create(ProfessorRequestModel request)
        {
            ProfessorCommand command = new ProfessorCommand(request.FirstName, request.LastName);
            int id = createProfessorHandler.Handle(command);

            return id > 0;
        }
    }
}
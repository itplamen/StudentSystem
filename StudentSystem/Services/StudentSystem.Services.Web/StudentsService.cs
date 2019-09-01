namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Common.Validators;
    using StudentSystem.Data.Commands.Students;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Models.Web.Students;
    using StudentSystem.Services.Web.Contracts;

    public class StudentsService : IStudentsService
    {
        private readonly IValidator<StudentRequestModel> validator;
        private readonly IMapper<Semester, SemesterResponseModel> semestersMapper;
        private readonly IQueryHandler<IEnumerable<Semester>> studentDetailsHandler;
        private readonly ICommandHandler<CreateStudentCommand, int> createStudentHandler;

        public StudentsService(
            IValidator<StudentRequestModel> validator,
            IMapper<Semester, SemesterResponseModel> semestersMapper, 
            IQueryHandler<IEnumerable<Semester>> studentDetailsHandler,
            ICommandHandler<CreateStudentCommand, int> createStudentHandler)
        {
            this.validator = validator;
            this.semestersMapper = semestersMapper;
            this.studentDetailsHandler = studentDetailsHandler;
            this.createStudentHandler = createStudentHandler;
        }

        public bool Create(StudentRequestModel request)
        {
            ValidationResult validationResult = validator.Validate(request);

            if (validationResult.HasErrors)
            {
                return false;
            }

            CreateStudentCommand command = new CreateStudentCommand(request.FirstName, request.LastName, request.Email, request.DateOfBirth);
            int id = createStudentHandler.Handle(command);

            return id > 0;
        }

        public IEnumerable<SemesterResponseModel> Get()
        {
            IEnumerable<Semester> studentDetails = studentDetailsHandler.Handle();
            IEnumerable<SemesterResponseModel> semestersResponse = semestersMapper.Map(studentDetails);

            return semestersResponse;
        }
    }
}
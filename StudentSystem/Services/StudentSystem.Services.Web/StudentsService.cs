namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Common.Validators;
    using StudentSystem.Data.Commands.Common;
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
        private readonly ICommandHandler<StudentCommand, int> createStudentHandler;
        private readonly ICommandHandler<UpdateStudentCommand, bool> updateStudentHandler;
        private readonly IQueryHandler<IEnumerable<Semester>> studentDetailsHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteStudentHandler;

        public StudentsService(
            IValidator<StudentRequestModel> validator,
            IMapper<Semester, SemesterResponseModel> semestersMapper, 
            ICommandHandler<StudentCommand, int> createStudentHandler,
            ICommandHandler<UpdateStudentCommand, bool> updateStudentHandler,
            IQueryHandler<IEnumerable<Semester>> studentDetailsHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteStudentHandler)
        {
            this.validator = validator;
            this.semestersMapper = semestersMapper;
            this.createStudentHandler = createStudentHandler;
            this.updateStudentHandler = updateStudentHandler;
            this.studentDetailsHandler = studentDetailsHandler;
            this.deleteStudentHandler = deleteStudentHandler;
        }

        public bool Create(StudentRequestModel request)
        {
            ValidationResult validationResult = validator.Validate(request);

            if (validationResult.HasErrors)
            {
                return false;
            }

            StudentCommand command = new StudentCommand(request.FirstName, request.LastName, request.Email, request.DateOfBirth);
            int id = createStudentHandler.Handle(command);

            return id > 0;
        }

        public IEnumerable<SemesterResponseModel> Get()
        {
            IEnumerable<Semester> studentDetails = studentDetailsHandler.Handle();
            IEnumerable<SemesterResponseModel> semestersResponse = semestersMapper.Map(studentDetails);

            return semestersResponse;
        }

        public bool Update(StudentRequestModel request)
        {
            ValidationResult validationResult = validator.Validate(request);

            if (validationResult.HasErrors)
            {
                return false;
            }

            UpdateStudentCommand command = new UpdateStudentCommand(
                request.Id, 
                request.FirstName, 
                request.LastName, 
                request.Email, 
                request.DateOfBirth);

            bool isUpdated = updateStudentHandler.Handle(command);

            return isUpdated;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, "Students");
            bool isDeleted = deleteStudentHandler.Handle(command);

            return isDeleted;
        }
    }
}
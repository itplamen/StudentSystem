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
    using StudentSystem.Data.Queries.Common;
    using StudentSystem.Services.Models.Web.Students;
    using StudentSystem.Services.Web.Contracts;

    public class StudentsService : IStudentsService
    {
        private const string TABLE_NAME = "Students";

        private readonly IValidator<StudentRequestModel> validator;
        private readonly IMapper<Student, StudentResponseModel> studentsMapper;
        private readonly ICommandHandler<StudentCommand, Student> createStudentHandler;
        private readonly ICommandHandler<UpdateStudentCommand, Student> updateStudentHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Student>, IEnumerable<Student>> getAllStudentsHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteStudentHandler;

        public StudentsService(
            IValidator<StudentRequestModel> validator,
            IMapper<Student, StudentResponseModel> studentsMapper,
            ICommandHandler<StudentCommand, Student> createStudentHandler,
            ICommandHandler<UpdateStudentCommand, Student> updateStudentHandler,
            IQueryHandler<AllEntitiesQuery<Student>, IEnumerable<Student>> getAllStudentsHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteStudentHandler)
        {
            this.validator = validator;
            this.studentsMapper = studentsMapper;
            this.createStudentHandler = createStudentHandler;
            this.updateStudentHandler = updateStudentHandler;
            this.getAllStudentsHandler = getAllStudentsHandler;
            this.deleteStudentHandler = deleteStudentHandler;
        }

        public StudentResponseModel Create(StudentRequestModel request)
        {
            ValidationResult validationResult = validator.Validate(request);

            if (validationResult.HasErrors)
            {
                return null;
            }

            StudentCommand command = new StudentCommand(request.FirstName, request.LastName, request.Email, request.DateOfBirth);
            Student student = createStudentHandler.Handle(command);

            StudentResponseModel response = studentsMapper.Map(student);

            return response;
        }

        public IEnumerable<StudentResponseModel> All()
        {
            AllEntitiesQuery<Student> query = new AllEntitiesQuery<Student>(TABLE_NAME, false);
            IEnumerable<Student> students = getAllStudentsHandler.Handle(query);

            IEnumerable<StudentResponseModel> response = studentsMapper.Map(students);

            return response;
        }

        public StudentResponseModel Update(int id, StudentRequestModel request)
        {
            ValidationResult validationResult = validator.Validate(request);

            if (validationResult.HasErrors)
            {
                return null;
            }

            UpdateStudentCommand command = new UpdateStudentCommand(id, request.FirstName, request.LastName, request.Email, request.DateOfBirth);
            Student student = updateStudentHandler.Handle(command);

            StudentResponseModel response = studentsMapper.Map(student);

            return response;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteStudentHandler.Handle(command);

            return isDeleted;
        }
    }
}
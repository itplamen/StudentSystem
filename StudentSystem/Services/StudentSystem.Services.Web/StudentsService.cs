namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Students;
    using StudentSystem.Services.Web.Contracts;

    public class StudentsService : IStudentsService
    {
        private readonly IMapper<Student, StudentResponseModel> studentsMapper;
        private readonly IQueryHandler<IEnumerable<Student>> allStudentsHandler;

        public StudentsService(IMapper<Student, StudentResponseModel> studentsMapper, IQueryHandler<IEnumerable<Student>> allStudentsHandler)
        {
            this.studentsMapper = studentsMapper;
            this.allStudentsHandler = allStudentsHandler;
        }

        public IEnumerable<StudentResponseModel> GetAll()
        {
            IEnumerable<Student> students = allStudentsHandler.Handle();
            IEnumerable<StudentResponseModel> studentModels = studentsMapper.Map(students);

            return studentModels;
        }
    }
}
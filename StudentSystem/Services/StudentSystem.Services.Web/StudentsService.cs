namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web;
    using StudentSystem.Services.Web.Contracts;

    public class StudentsService : IStudentsService
    {
        private readonly IMapper<Student, StudentModel> studentsMapper;
        private readonly IQueryHandler<IEnumerable<Student>> allStudentsHandler;

        public StudentsService(IMapper<Student, StudentModel> studentsMapper, IQueryHandler<IEnumerable<Student>> allStudentsHandler)
        {
            this.studentsMapper = studentsMapper;
            this.allStudentsHandler = allStudentsHandler;
        }

        public IEnumerable<StudentModel> GetAll()
        {
            IEnumerable<Student> students = allStudentsHandler.Handle();
            IEnumerable<StudentModel> studentModels = studentsMapper.Map(students);

            return studentModels;
        }
    }
}
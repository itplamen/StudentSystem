namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;
    using System.Linq;
    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Students;
    using StudentSystem.Services.Web.Contracts;

    public class StudentsService : IStudentsService
    {
        private readonly IMapper<Student, StudentResponseModel> studentsMapper;
        private readonly IQueryHandler<IEnumerable<Semester>> activeStudentDetailsHandler;

        public StudentsService(
            IMapper<Student, StudentResponseModel> studentsMapper, 
            IQueryHandler<IEnumerable<Semester>> activeStudentDetailsHandler)
        {
            this.studentsMapper = studentsMapper;
            this.activeStudentDetailsHandler = activeStudentDetailsHandler;
        }

        public IEnumerable<StudentResponseModel> GetAll()
        {
            IEnumerable<Semester> studentDetails = activeStudentDetailsHandler.Handle();
            IEnumerable<Score> scores = studentDetails.SelectMany(x => x.Disciplines.SelectMany(y => y.Scores));

            return null;
        }
    }
}
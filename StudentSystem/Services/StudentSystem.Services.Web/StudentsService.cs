namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Web.Contracts;

    public class StudentsService : IStudentsService
    {
        private readonly IMapper<Semester, SemesterResponseModel> semestersMapper;
        private readonly IQueryHandler<IEnumerable<Semester>> studentDetailsHandler;

        public StudentsService(IMapper<Semester, SemesterResponseModel> semestersMapper, IQueryHandler<IEnumerable<Semester>> studentDetailsHandler)
        {
            this.semestersMapper = semestersMapper;
            this.studentDetailsHandler = studentDetailsHandler;
        }

        public IEnumerable<SemesterResponseModel> Get()
        {
            IEnumerable<Semester> studentDetails = studentDetailsHandler.Handle();
            IEnumerable<SemesterResponseModel> semestersResponse = semestersMapper.Map(studentDetails);

            return semestersResponse;
        }
    }
}
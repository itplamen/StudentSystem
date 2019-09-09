namespace StudentSystem.Services.Web.Builders
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Models.Web.Semesters;

    public class SemestersBuilder : IBuilder<Semester, SemesterResponseModel>
    {
        private readonly IMapper<Semester, SemesterResponseModel> semestersMapper;
        private readonly IBuilder<Discipline, DisciplineResponseModel> disciplinesBuilder;

        public SemestersBuilder(
            IMapper<Semester, SemesterResponseModel> semestersMapper,
            IBuilder<Discipline, DisciplineResponseModel> disciplinesBuilder)
        {
            this.semestersMapper = semestersMapper;
            this.disciplinesBuilder = disciplinesBuilder;
        }

        public IEnumerable<SemesterResponseModel> Build(IEnumerable<Semester> from)
        {
            ICollection<SemesterResponseModel> semestersResponse = new List<SemesterResponseModel>();

            foreach (var semester in from)
            {
                SemesterResponseModel semesterResponse = semestersMapper.Map(semester);
                semesterResponse.Disciplines = disciplinesBuilder.Build(semester.Disciplines);

                semestersResponse.Add(semesterResponse);
            }

            return semestersResponse;
        }
    }
}
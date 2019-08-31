namespace StudentSystem.Data.Builders.StudentDetails
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;

    public class SemestersBuilder : IBuilder<SqlDataReader, Semester>
    {        
        private readonly IMapper<SqlDataReader, Semester> semestersMapper;
        private readonly IBuilder<SqlDataReader, Discipline> disciplinesBuilder;

        public SemestersBuilder(IMapper<SqlDataReader, Semester> semestersMapper, IBuilder<SqlDataReader, Discipline> disciplinesBuilder)
        {
            this.semestersMapper = semestersMapper;
            this.disciplinesBuilder = disciplinesBuilder;
        }

        public IEnumerable<Semester> Build(IEnumerable<SqlDataReader> from)
        {
            IEnumerable<Semester> semesters = semestersMapper.Map(from);
            IEnumerable<Discipline> disciplines = disciplinesBuilder.Build(from);

            foreach (var semester in semesters)
            {
                semester.Disciplines = disciplines.Where(x => x.SemesterId == semester.Id);
            }

            return semesters;
        }
    }
}
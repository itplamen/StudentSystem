namespace StudentSystem.Data.Builders.StudentDetails
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;

    public class DisciplinesBuilder : IBuilder<SqlDataReader, Discipline>
    {
        private readonly IBuilder<SqlDataReader, Score> scoresBuilder;
        private readonly IBuilder<SqlDataReader, Professor> professorsBuilder;
        private readonly IMapper<SqlDataReader, Discipline> disciplinesMapper;

        public DisciplinesBuilder(
            IBuilder<SqlDataReader, Score> scoresBuilder,
            IBuilder<SqlDataReader, Professor> professorsBuilder,
            IMapper<SqlDataReader, Discipline> disciplinesMapper)
        {
            this.scoresBuilder = scoresBuilder;
            this.professorsBuilder = professorsBuilder;
            this.disciplinesMapper = disciplinesMapper;
        }

        public IEnumerable<Discipline> Build(IEnumerable<SqlDataReader> from)
        {
            if (from.First().NextResult())
            {
                IEnumerable<Discipline> disciplines = disciplinesMapper.Map(from);
                IEnumerable<Professor> professors = professorsBuilder.Build(from);
                IEnumerable<Score> scores = scoresBuilder.Build(from);

                foreach (var discipline in disciplines)
                {
                    discipline.Professor = professors.FirstOrDefault(x => x.Id == discipline.ProfessorId);
                }

                return disciplines;
            }

            return Enumerable.Empty<Discipline>();
        }
    }
}
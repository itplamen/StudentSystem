namespace StudentSystem.Data.Builders.StudentDetails
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Builders;
    using StudentSystem.Data.Models;

    public class ScoresBuilder : IBuilder<SqlDataReader, Score>
    {
        private readonly IMapper<SqlDataReader, Score> scoresMapper;
        private readonly IBuilder<SqlDataReader, Student> studentsBuilder;

        public ScoresBuilder(IMapper<SqlDataReader, Score> scoresMapper, IBuilder<SqlDataReader, Student> studentsBuilder)
        {
            this.scoresMapper = scoresMapper;
            this.studentsBuilder = studentsBuilder;
        }

        public IEnumerable<Score> Build(IEnumerable<SqlDataReader> from)
        {
            if (from.First().NextResult())
            {
                IEnumerable<Score> scores = scoresMapper.Map(from);
                IEnumerable<Student> students = studentsBuilder.Build(from);

                foreach (var score in scores)
                {
                    score.Student = students.FirstOrDefault(x => x.Id == score.StudentId);
                }

                return scores;
            }

            return Enumerable.Empty<Score>();
        }
    }
}
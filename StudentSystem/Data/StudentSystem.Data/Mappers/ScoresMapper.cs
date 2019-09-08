namespace StudentSystem.Data.Mappers
{
    using System.Data.SqlClient;

    using StudentSystem.Data.Mappers.Base;
    using StudentSystem.Data.Models;

    public class ScoresMapper : BaseMapper<SqlDataReader, Score>
    {
        public override Score Map(SqlDataReader from)
        {
            Score score = base.Map(from);
            score.Mark = float.Parse(from[nameof(score.Mark)].ToString());
            score.StudentId = Map<int>(from, nameof(score.StudentId));
            score.DisciplineId = Map<int>(from, nameof(score.DisciplineId));

            return score;
        }
    }
}
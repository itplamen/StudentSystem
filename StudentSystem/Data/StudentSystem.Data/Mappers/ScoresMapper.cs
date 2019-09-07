namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Mappers.Base;
    using StudentSystem.Data.Models;

    public class ScoresMapper : BaseMapper<SqlDataReader, Score>
    {
        public override Score Map(SqlDataReader from)
        {
            Score score = base.Map(from);
            score.Mark = float.Parse(from["Mark"].ToString());
            score.StudentId = Convert.ToInt32(from["StudentId"]);
            score.DisciplineId = Convert.ToInt32(from["DisciplineId"]);

            return score;
        }
    }
}
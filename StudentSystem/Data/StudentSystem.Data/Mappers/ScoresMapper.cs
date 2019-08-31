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
            Score score = new Score()
            {
                Mark = float.Parse(from["Mark"].ToString()),
                StudentId = Convert.ToInt32(from["StudentId"]),
                DisciplineId = Convert.ToInt32(from["DisciplineId"])
            };

            return score;
        }
    }
}
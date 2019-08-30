namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;

    public class ScoresMapper : IMapper<SqlDataReader, Score>
    {
        public Score Map(SqlDataReader from)
        {
            Score score = new Score()
            {
                Mark = float.Parse(from["Mark"].ToString()),
                StudentId = Convert.ToInt32(from["StudentId"]),
                DisciplineId = Convert.ToInt32(from["DisciplineId"])
            };

            return score;
        }

        public IEnumerable<Score> Map(IEnumerable<SqlDataReader> from)
        {
            SqlDataReader reader = from.FirstOrDefault();

            if (reader != null)
            {
                ICollection<Score> scores = new List<Score>();

                while (reader.Read())
                {
                    Score score = Map(reader);

                    scores.Add(score);
                }

                return scores;
            }

            return Enumerable.Empty<Score>();
        }
    }
}
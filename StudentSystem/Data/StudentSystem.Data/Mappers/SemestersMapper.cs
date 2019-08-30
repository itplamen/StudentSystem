namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;

    public class SemestersMapper : IMapper<SqlDataReader, Semester>
    {
        public Semester Map(SqlDataReader from)
        {
            Semester semester = new Semester()
            {
                Id = Convert.ToInt32(from["Id"]),
                Name = Convert.ToString(from["Name"]),
                StartDate = Convert.ToDateTime(from["StartDate"]),
                EndDate = Convert.ToDateTime(from["EndDate"])
            };

            return semester;
        }

        public IEnumerable<Semester> Map(IEnumerable<SqlDataReader> from)
        {
            SqlDataReader reader = from.FirstOrDefault();

            if (reader != null)
            {
                ICollection<Semester> semesters = new List<Semester>();

                while (reader.Read())
                {
                    Semester semester = Map(reader);

                    semesters.Add(semester);
                }

                return semesters;
            }

            return Enumerable.Empty<Semester>();
        }
    }
}
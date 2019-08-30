namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;

    public class DisciplinesMapper : IMapper<SqlDataReader, Discipline>
    {
        public Discipline Map(SqlDataReader from)
        {
            Discipline discipline = new Discipline()
            {
                Id = Convert.ToInt32(from["Id"]),
                Name = Convert.ToString(from["Name"]),
                SemesterId = Convert.ToInt32(from["SemesterId"]),
                ProfessorId = Convert.ToInt32(from["ProfessorId"])
            };

            return discipline;
        }

        public IEnumerable<Discipline> Map(IEnumerable<SqlDataReader> from)
        {
            SqlDataReader reader = from.FirstOrDefault();

            if (reader != null)
            {
                ICollection<Discipline> disciplines = new List<Discipline>();

                while (reader.Read())
                {
                    Discipline discipline = Map(reader);

                    disciplines.Add(discipline);
                }

                return disciplines;
            }

            return Enumerable.Empty<Discipline>();
        }
    }
}
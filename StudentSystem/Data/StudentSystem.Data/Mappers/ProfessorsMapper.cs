namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;

    public class ProfessorsMapper : IMapper<SqlDataReader, Professor>
    {
        public Professor Map(SqlDataReader from)
        {
            Professor professor = new Professor()
            {
                Id = Convert.ToInt32(from["Id"]),
                FirstName = Convert.ToString(from["FirstName"]),
                LastName = Convert.ToString(from["LastName"])
            };

            return professor;
        }

        public IEnumerable<Professor> Map(IEnumerable<SqlDataReader> from)
        {
            SqlDataReader reader = from.FirstOrDefault();

            if (reader != null)
            {
                ICollection<Professor> professors = new List<Professor>();

                while (reader.Read())
                {
                    Professor professor = Map(reader);

                    professors.Add(professor);
                }

                return professors;
            }

            return Enumerable.Empty<Professor>();
        }
    }
}
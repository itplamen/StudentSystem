namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;

    public class StudentsMapper : IMapper<SqlDataReader, Student>
    {
        public Student Map(SqlDataReader from)
        {
            Student student = new Student()
            {
                Id = Convert.ToInt32(from["Id"]),
                CreatedOn = Convert.ToDateTime(from["CreatedOn"]),
                ModifiedOn = Map(from, "ModifiedOn"),
                IsDeleted = Convert.ToBoolean(from["IsDeleted"]),
                DeletedOn = Map(from, "DeletedOn"),
                FirstName = Convert.ToString(from["FirstName"]),
                LastName = Convert.ToString(from["LastName"]),
                Email = Convert.ToString(from["Email"]),
                DateOfBirth = Convert.ToDateTime(from["DateOfBirth"])
            };

            return student;
        }

        public IEnumerable<Student> Map(IEnumerable<SqlDataReader> from)
        {
            SqlDataReader reader = from.FirstOrDefault();

            if (reader != null)
            {
                ICollection<Student> students = new List<Student>();

                while (reader.Read())
                {
                    Student student = Map(reader);

                    students.Add(student);
                }

                return students;
            }

            return Enumerable.Empty<Student>();
        }

        private DateTime? Map(SqlDataReader reader, string columnName)
        {
            int columnOrdinal = reader.GetOrdinal(columnName);

            if (reader.IsDBNull(columnOrdinal))
            {
                return (DateTime?)null;
            }

            return (DateTime?)reader.GetDateTime(columnOrdinal);
        }
    }
}
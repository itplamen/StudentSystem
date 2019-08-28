namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Data.SqlClient;

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
                ModifiedOn = Convert.ToDateTime(from["ModifiedOn"]),
                IsDeleted = Convert.ToBoolean(from["IsDeleted"]),
                DeletedOn = Convert.ToDateTime(from["DeletedOn"]),
                FirstName = Convert.ToString(from["FirstName"]),
                LastName = Convert.ToString(from["LastName"]),
                Email = Convert.ToString(from["Email"]),
                DateOfBirth = Convert.ToDateTime(from["DateOfBirth"])
            };

            return student;
        }
    }
}
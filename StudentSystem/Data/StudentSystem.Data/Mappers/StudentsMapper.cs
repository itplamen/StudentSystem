namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Mappers.Base;
    using StudentSystem.Data.Models;

    public class StudentsMapper : BaseMapper<SqlDataReader, Student>
    {
        public override Student Map(SqlDataReader from)
        {
            Student student = new Student()
            {
                Id = Convert.ToInt32(from["Id"]),
                CreatedOn = Convert.ToDateTime(from["CreatedOn"]),
                ModifiedOn = Map(from, "ModifiedOn"),
                FirstName = Convert.ToString(from["FirstName"]),
                LastName = Convert.ToString(from["LastName"]),
                Email = Convert.ToString(from["Email"]),
                DateOfBirth = Convert.ToDateTime(from["DateOfBirth"])
            };

            return student;
        }
    }
}
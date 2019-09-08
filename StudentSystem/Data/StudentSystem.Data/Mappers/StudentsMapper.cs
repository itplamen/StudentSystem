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
            Student student = base.Map(from);
            student.FirstName = Map<string>(from, nameof(student.FirstName));
            student.LastName = Map<string>(from, nameof(student.LastName));
            student.Email = Map<string>(from, nameof(student.Email));
            student.DateOfBirth = Map<DateTime>(from, nameof(student.DateOfBirth));

            return student;
        }
    }
}
namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Mappers.Base;
    using StudentSystem.Data.Models;

    public class DisciplinesMapper : BaseMapper<SqlDataReader, Discipline>
    {
        public override Discipline Map(SqlDataReader from)
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
    }
}
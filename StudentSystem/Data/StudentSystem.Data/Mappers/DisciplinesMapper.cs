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
            Discipline discipline = base.Map(from);
            discipline.Name = Convert.ToString(from["Name"]);
            discipline.SemesterId = Convert.ToInt32(from["SemesterId"]);
            discipline.ProfessorId = Convert.ToInt32(from["ProfessorId"]);

            return discipline;
        }
    }
}
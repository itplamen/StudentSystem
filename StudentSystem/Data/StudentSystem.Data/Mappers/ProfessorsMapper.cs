namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Mappers.Base;
    using StudentSystem.Data.Models;

    public class ProfessorsMapper : BaseMapper<SqlDataReader, Professor>
    {
        public override Professor Map(SqlDataReader from)
        {
            Professor professor = base.Map(from);
            professor.FirstName = Convert.ToString(from["FirstName"]);
            professor.LastName = Convert.ToString(from["LastName"]);

            return professor;
        }
    }
}
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
            Professor professor = new Professor()
            {
                Id = Convert.ToInt32(from["Id"]),
                FirstName = Convert.ToString(from["FirstName"]),
                LastName = Convert.ToString(from["LastName"])
            };
            
            return professor;
        }
    }
}
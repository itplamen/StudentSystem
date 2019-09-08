namespace StudentSystem.Data.Mappers
{
    using System.Data.SqlClient;

    using StudentSystem.Data.Mappers.Base;
    using StudentSystem.Data.Models;

    public class ProfessorsMapper : BaseMapper<SqlDataReader, Professor>
    {
        public override Professor Map(SqlDataReader from)
        {
            Professor professor = base.Map(from);
            professor.FirstName = Map<string>(from, nameof(professor.FirstName));
            professor.LastName = Map<string>(from, nameof(professor.LastName));

            return professor;
        }
    }
}
namespace StudentSystem.Data.Mappers
{
    using System.Data.SqlClient;

    using StudentSystem.Data.Mappers.Base;
    using StudentSystem.Data.Models;

    public class DisciplinesMapper : BaseMapper<SqlDataReader, Discipline>
    {
        public override Discipline Map(SqlDataReader from)
        {
            Discipline discipline = base.Map(from);
            discipline.Name = Map<string>(from, nameof(discipline.Name));
            discipline.SemesterId = Map<int>(from, nameof(discipline.SemesterId));
            discipline.ProfessorId = Map<int>(from, nameof(discipline.ProfessorId));

            return discipline;
        }
    }
}
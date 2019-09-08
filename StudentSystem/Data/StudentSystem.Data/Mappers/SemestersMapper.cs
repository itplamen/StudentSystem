namespace StudentSystem.Data.Mappers
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Mappers.Base;
    using StudentSystem.Data.Models;

    public class SemestersMapper : BaseMapper<SqlDataReader, Semester>
    {
        public override Semester Map(SqlDataReader from)
        {
            Semester semester = base.Map(from);
            semester.Name = Map<string>(from, nameof(semester.Name));
            semester.StartDate = Map<DateTime>(from, nameof(semester.StartDate));
            semester.EndDate = Map<DateTime>(from, nameof(semester.EndDate));

            return semester;
        }
    }
}
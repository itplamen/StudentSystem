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
            semester.Name = Convert.ToString(from["Name"]);
            semester.StartDate = Convert.ToDateTime(from["StartDate"]);
            semester.EndDate = Convert.ToDateTime(from["EndDate"]);

            return semester;
        }
    }
}
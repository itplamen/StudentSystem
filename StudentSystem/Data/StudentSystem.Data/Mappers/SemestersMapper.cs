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
            Semester semester = new Semester()
            {
                Id = Convert.ToInt32(from["Id"]),
                Name = Convert.ToString(from["Name"]),
                StartDate = Convert.ToDateTime(from["StartDate"]),
                EndDate = Convert.ToDateTime(from["EndDate"])
            };

            return semester;
        }
    }
}
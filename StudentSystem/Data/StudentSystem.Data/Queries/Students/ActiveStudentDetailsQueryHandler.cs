namespace StudentSystem.Data.Queries.Students
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Builders;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;

    public class ActiveStudentDetailsQueryHandler : IQueryHandler<IEnumerable<Semester>>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;
        private readonly IBuilder<SqlDataReader, Semester> studentDetailsBuilder;

        public ActiveStudentDetailsQueryHandler(ISqlQueryExecutor sqlQueryExecutor, IBuilder<SqlDataReader, Semester> studentDetailsBuilder)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
            this.studentDetailsBuilder = studentDetailsBuilder;
        }

        public IEnumerable<Semester> Handle()
        {
            string query = "sp_GetActiveStudentDetails";
            IEnumerable<Semester> students = sqlQueryExecutor.Execute(query, GetDetails);

            return students;
        }

        private IEnumerable<Semester> GetDetails(SqlCommand sqlCommand)
        {
            sqlCommand.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                IEnumerable<SqlDataReader> readers = new List<SqlDataReader>() { reader };
                IEnumerable<Semester> studentDetails = studentDetailsBuilder.Build(readers);

                return studentDetails;
            }
        }
    }
}
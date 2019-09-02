namespace StudentSystem.Data.Queries.Semesters
{
    using System.Collections.Generic;
    using System.Data.SqlClient;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;

    public class AllSemestersQueryHandler : IQueryHandler<IEnumerable<Semester>>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;
        private readonly IMapper<SqlDataReader, Semester> semestersMapper;

        public AllSemestersQueryHandler(ISqlQueryExecutor sqlQueryExecutor, IMapper<SqlDataReader, Semester> semestersMapper)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
            this.semestersMapper = semestersMapper;
        }

        public IEnumerable<Semester> Handle()
        {
            string query = @"SELECT * FROM Semester WHERE IsDeleted = 0";
            IEnumerable<Semester> semesters = sqlQueryExecutor.Execute(query, GetAll);

            return semesters;
        }

        private IEnumerable<Semester> GetAll(SqlCommand sqlCommand)
        {
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                IEnumerable<SqlDataReader> readers = new List<SqlDataReader>() { reader };
                IEnumerable<Semester> semesters = semestersMapper.Map(readers);

                return semesters;
            }
        }
    }
}
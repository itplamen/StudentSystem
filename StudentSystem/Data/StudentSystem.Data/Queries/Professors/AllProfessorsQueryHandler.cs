namespace StudentSystem.Data.Queries.Professors
{
    using System.Collections.Generic;
    using System.Data.SqlClient;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;

    public class AllProfessorsQueryHandler : IQueryHandler<IEnumerable<Professor>>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;
        private readonly IMapper<SqlDataReader, Professor> professorsMapper;

        public AllProfessorsQueryHandler(ISqlQueryExecutor sqlQueryExecutor, IMapper<SqlDataReader, Professor> professorsMapper)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
            this.professorsMapper = professorsMapper;
        }

        public IEnumerable<Professor> Handle()
        {
            string query = @"SELECT * FROM Professors WHERE IsDeleted = 0";
            IEnumerable<Professor> professors = sqlQueryExecutor.Execute(query, GetAll);

            return professors;
        }

        private IEnumerable<Professor> GetAll(SqlCommand sqlCommand)
        {
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                IEnumerable<SqlDataReader> readers = new List<SqlDataReader>() { reader };
                IEnumerable<Professor> professors = professorsMapper.Map(readers);

                return professors;
            }
        }
    }
}
namespace StudentSystem.Data.Queries.Common
{
    using System.Collections.Generic;
    using System.Data.SqlClient;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models.Base;

    public class AllEntitiesQueryHandler<TEntity> : IQueryHandler<AllEntitiesQuery<TEntity>, IEnumerable<TEntity>>
        where TEntity : BaseModel
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;
        private readonly IMapper<SqlDataReader, TEntity> entitiesMapper;

        private SqlParameter[] sqlParameters;

        public AllEntitiesQueryHandler(ISqlQueryExecutor sqlQueryExecutor, IMapper<SqlDataReader, TEntity> entitiesMapper)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
            this.entitiesMapper = entitiesMapper;
        }

        public IEnumerable<TEntity> Handle(AllEntitiesQuery<TEntity> query)
        {
            string sqlQuery = $@"SELECT * FROM {query.Table} WHERE IsDeleted = @withDeleted";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@withDeleted", $"{query.WithDeleted}")
            };

            IEnumerable<TEntity> entities = sqlQueryExecutor.Execute(sqlQuery, GetAll);

            return entities;
        }

        private IEnumerable<TEntity> GetAll(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddRange(sqlParameters);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                IEnumerable<SqlDataReader> readers = new List<SqlDataReader>() { reader };
                IEnumerable<TEntity> entities = entitiesMapper.Map(readers);

                return entities;
            }
        }
    }
}
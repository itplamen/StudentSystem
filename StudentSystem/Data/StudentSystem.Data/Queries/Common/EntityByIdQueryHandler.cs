namespace StudentSystem.Data.Queries.Common
{
    using System.Data.SqlClient;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models.Base;

    public class EntityByIdQueryHandler<TEntity> : IQueryHandler<EntityByIdQuery<TEntity>, TEntity>
        where TEntity : BaseModel
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;
        private readonly IMapper<SqlDataReader, TEntity> entitiesMapper;

        private SqlParameter[] sqlParameters;

        public EntityByIdQueryHandler(ISqlQueryExecutor sqlQueryExecutor, IMapper<SqlDataReader, TEntity> entitiesMapper)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
            this.entitiesMapper = entitiesMapper;
        }

        public TEntity Handle(EntityByIdQuery<TEntity> query)
        {
            string sqlQuery = $@"SELECT * FROM {query.Table} WHERE Id = @id";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", $"{query.Id}")
            };

            TEntity entity = sqlQueryExecutor.Execute(sqlQuery, GetById);

            return entity;
        }

        private TEntity GetById(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddRange(sqlParameters);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                TEntity entity = entitiesMapper.Map(reader);

                return entity;
            }
        }
    }
}
namespace StudentSystem.Data.Commands.Common
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;

    public class DeleteEntityCommandHandler : ICommandHandler<DeleteEntityCommand, bool>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private SqlParameter[] sqlParameters;

        public DeleteEntityCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public bool Handle(DeleteEntityCommand command)
        {
            string query = $@"UPDATE {command.Table}
                            SET IsDeleted = @isDeleted, DeletedOn = @deletedOn
                            WHERE Id = @id";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", command.Id),
                new SqlParameter("@isDeleted", true),
                new SqlParameter("@deletedOn", DateTime.UtcNow)
            };

            bool isDeleted = sqlQueryExecutor.Execute(query, Delete);

            return isDeleted;
        }

        private bool Delete(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddRange(sqlParameters);
            int affectedRows = sqlCommand.ExecuteNonQuery();

            return affectedRows > 0;
        }
    }
}
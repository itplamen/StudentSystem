namespace StudentSystem.Data.Commands.Common
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;

    public class UpdateEntityCommandHandler : ICommandHandler<UpdateEntityCommand, bool>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private ICollection<SqlParameter> sqlParameters;

        public UpdateEntityCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public bool Handle(UpdateEntityCommand command)
        {
            try
            {
                string setQuery = string.Join(", ", command.Columns.Keys.Select(x => x + " = @" + x));

                string query = $@"UPDATE {command.Table}
                            SET {setQuery}
                            WHERE Id = @id";

                sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@id", command.Id));
                
                foreach (var column in command.Columns)
                {
                    sqlParameters.Add(new SqlParameter($"@{column.Key}", column.Value));
                }

                bool isUpdated = sqlQueryExecutor.Execute(query, Update);

                return isUpdated;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        private bool Update(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddRange(sqlParameters.ToArray());
            int affectedRows = sqlCommand.ExecuteNonQuery();

            return affectedRows > 0;
        }
    }
}
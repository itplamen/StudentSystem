namespace StudentSystem.Data.Commands.Common
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;

    public class CreateEntityCommandHandler : ICommandHandler<EntityCommand, int>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private ICollection<SqlParameter> sqlParameters;

        public CreateEntityCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public int Handle(EntityCommand command)
        {
            string columnKeys = string.Join(", ", command.Columns.Keys);
            string columnVariables = string.Join(", ", command.Columns.Keys.Select(x => "@" + x));

            string query = $@"INSERT INTO {command.Table}({columnKeys})
                            OUTPUT INSERTED.ID
                            VALUES({columnVariables})";

            sqlParameters = new List<SqlParameter>();

            foreach (var column in command.Columns)
            {
                sqlParameters.Add(new SqlParameter($"@{column.Key}", column.Value));
            }

            int id = sqlQueryExecutor.Execute(query, Create);

            return id;
        }

        private int Create(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddRange(sqlParameters.ToArray());
            int id = (int)sqlCommand.ExecuteScalar();

            return id;
        }
    }
}
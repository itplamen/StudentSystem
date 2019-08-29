namespace StudentSystem.Data
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts;

    public class SqlQueryExecutor : ISqlQueryExecutor
    {
        private readonly IConfigurationManager configurationManager;

        public SqlQueryExecutor(IConfigurationManager configurationManager)
        {
            this.configurationManager = configurationManager;
        }

        public T Execute<T>(string sqlQuery, Func<SqlCommand, T> funcQuery)
        {
            using (SqlConnection connection = new SqlConnection(configurationManager.ConnectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection))
                {
                    return funcQuery(sqlCommand);
                }
            }
        }
    }
}
namespace StudentSystem.Data.Contracts
{
    using System;
    using System.Data.SqlClient;

    public interface ISqlQueryExecutor
    {
        T Execute<T>(string sqlQuery, Func<SqlCommand, T> funcQuery);
    }
}
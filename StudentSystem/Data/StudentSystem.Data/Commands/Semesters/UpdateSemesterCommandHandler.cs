namespace StudentSystem.Data.Commands.Semesters
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;

    public class UpdateSemesterCommandHandler : ICommandHandler<UpdateSemesterCommand, bool>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private SqlParameter[] sqlParameters;

        public UpdateSemesterCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public bool Handle(UpdateSemesterCommand command)
        {
            string query = @"UPDATE Semesters
                            SET Name = @name, StartDate = @startDate, EndDate = @endDate, ModifiedOn = @modifiedOn
                            WHERE Id = @id";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name", command.Name),
                new SqlParameter("@startDate", command.StartDate),
                new SqlParameter("@endDate", command.EndDate),
                new SqlParameter("@modifiedOn", DateTime.UtcNow),
                new SqlParameter("@id", command.Id)
            };

            bool isUpdated = sqlQueryExecutor.Execute(query, Update);

            return isUpdated;
        }

        private bool Update(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddRange(sqlParameters);
            int affectedRows = sqlCommand.ExecuteNonQuery();

            return affectedRows > 0;
        }
    }
}
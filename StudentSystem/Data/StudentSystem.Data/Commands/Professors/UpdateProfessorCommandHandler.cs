namespace StudentSystem.Data.Commands.Professors
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;

    public class UpdateProfessorCommandHandler : ICommandHandler<UpdateProfessorCommand, bool>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private SqlParameter[] sqlParameters;

        public UpdateProfessorCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public bool Handle(UpdateProfessorCommand command)
        {
            string query = @"UPDATE Professors
                            SET FirstName = @firstName, LastName = @lastName, ModifiedOn = @modifiedOn
                            WHERE Id = @id";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstName", $"{command.FirstName}"),
                new SqlParameter("@lastName", $"{command.LastName}"),
                new SqlParameter("@modifiedOn", $"{DateTime.UtcNow}"),
                new SqlParameter("@id", $"{command.Id}")
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
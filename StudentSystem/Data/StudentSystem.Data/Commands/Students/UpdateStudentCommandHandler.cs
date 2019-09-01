namespace StudentSystem.Data.Commands.Students
{
    using System;
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;

    public class UpdateStudentCommandHandler : ICommandHandler<StudentCommand, bool>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private SqlParameter[] sqlParameters;

        public UpdateStudentCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public bool Handle(StudentCommand command)
        {
            string query = @"UPDATE Students
                            SET FirstName = @firstName, LastName = @lastName, Email = @email, DateOfBirth = @dateOfBirth, ModifiedOn = @modifiedOn
                            WHERE Id = @id";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstName", $"{command.FirstName}"),
                new SqlParameter("@lastName", $"{command.LastName}"),
                new SqlParameter("@email", $"{command.Email}"),
                new SqlParameter("@dateOfBirth", $"{command.DateOfBirth}"),
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
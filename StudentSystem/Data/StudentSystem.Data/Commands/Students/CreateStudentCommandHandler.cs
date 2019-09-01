namespace StudentSystem.Data.Commands.Students
{
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;
    
    public class CreateStudentCommandHandler : ICommandHandler<CreateStudentCommand, bool>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;
        private SqlParameter[] sqlParameters;

        public CreateStudentCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public bool Handle(CreateStudentCommand command)
        {
            string query = @"INSERT INTO Students(FirstName, LastName, Email, DateOfBirth) 
                            VALUES(@firstName, @lastName, @email, @dateOfBirth)";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstName", $"{command.FirstName}"),
                new SqlParameter("@lastName", $"{command.LastName}"),
                new SqlParameter("@email", $"{command.Email}"),
                new SqlParameter("@dateOfBirth", $"{command.DateOfBirth}")
            };

            int affectedRows = sqlQueryExecutor.Execute(query, Create);

            return affectedRows > 0;
        }

        private int Create(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddRange(sqlParameters);
            int affectedRows = sqlCommand.ExecuteNonQuery();

            return affectedRows;
        }
    }
}
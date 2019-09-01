namespace StudentSystem.Data.Commands.Students
{
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;
    
    public class CreateStudentCommandHandler : ICommandHandler<StudentCommand, int>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private SqlParameter[] sqlParameters;

        public CreateStudentCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public int Handle(StudentCommand command)
        {
            string query = @"INSERT INTO Students(FirstName, LastName, Email, DateOfBirth)
                            OUTPUT INSERTED.ID
                            VALUES(@firstName, @lastName, @email, @dateOfBirth)";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstName", $"{command.FirstName}"),
                new SqlParameter("@lastName", $"{command.LastName}"),
                new SqlParameter("@email", $"{command.Email}"),
                new SqlParameter("@dateOfBirth", $"{command.DateOfBirth}")
            };

            int id = sqlQueryExecutor.Execute(query, Create);

            return id;
        }

        private int Create(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddRange(sqlParameters);
            int id = (int)sqlCommand.ExecuteScalar();

            return id;
        }
    }
}
namespace StudentSystem.Data.Commands.Professors
{
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;

    public class CreateProfessorCommandHandler : ICommandHandler<ProfessorCommand, int>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private SqlParameter[] sqlParameters;

        public CreateProfessorCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public int Handle(ProfessorCommand command)
        {
            string query = @"INSERT INTO Professors(FirstName, LastName)
                            OUTPUT INSERTED.ID
                            VALUES(@firstName, @lastName)";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstName", $"{command.FirstName}"),
                new SqlParameter("@lastName", $"{command.LastName}")
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
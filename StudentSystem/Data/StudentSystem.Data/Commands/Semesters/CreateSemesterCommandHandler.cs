namespace StudentSystem.Data.Commands.Semesters
{
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Commands;

    public class CreateSemesterCommandHandler : ICommandHandler<SemesterCommand, int>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private SqlParameter[] sqlParameters;

        public CreateSemesterCommandHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public int Handle(SemesterCommand command)
        {
            string query = @"INSERT INTO Semesters(Name, StartDate, EndDate)
                            OUTPUT INSERTED.ID
                            VALUES(@name, @startDate, @endDate)";

            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name", command.Name),
                new SqlParameter("@startDate", command.StartDate),
                new SqlParameter("@endDate", command.EndDate)
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
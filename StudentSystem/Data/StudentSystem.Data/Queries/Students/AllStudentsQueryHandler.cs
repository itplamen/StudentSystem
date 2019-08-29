namespace StudentSystem.Data.Queries.Students
{
    using System.Collections.Generic;
    using System.Data.SqlClient;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;

    public class AllStudentsQueryHandler : IQueryHandler<IEnumerable<Student>>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;
        private readonly IMapper<SqlDataReader, Student> studentsMapper;

        public AllStudentsQueryHandler(ISqlQueryExecutor sqlQueryExecutor, IMapper<SqlDataReader, Student> studentsMapper)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
            this.studentsMapper = studentsMapper;
        }

        public IEnumerable<Student> Handle()
        {
            string query = "SELECT * FROM Students";
            IEnumerable<Student> students = sqlQueryExecutor.Execute(query, GetStudents);

            return students;
        }

        private IEnumerable<Student> GetStudents(SqlCommand sqlCommand)
        {
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                IEnumerable<SqlDataReader> readers = new List<SqlDataReader>() { reader };

                return studentsMapper.Map(readers);
            }
        }
    }
}
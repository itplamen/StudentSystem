namespace StudentSystem.Data.Queries.Students
{
    using System.Collections.Generic;
    using System.Data.SqlClient;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;

    public class AllStudentsQueryHandler : IQueryHandler<IEnumerable<Student>>
    {
        private readonly IMapper<SqlDataReader, Student> studentsMapper;

        public AllStudentsQueryHandler(IMapper<SqlDataReader, Student> studentsMapper)
        {
            this.studentsMapper = studentsMapper;
        }

        public IEnumerable<Student> Handle()
        {
            using (SqlConnection connection = new SqlConnection(Data.Default.ConnectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Students", connection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        IEnumerable<SqlDataReader> readers = new List<SqlDataReader>() { reader };

                        return studentsMapper.Map(readers);
                    }
                }
            }
        }
    }
}
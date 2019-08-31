namespace StudentSystem.Data.Builders.StudentDetails
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Builders;
    using StudentSystem.Data.Models;

    public class StudentsBuilder : IBuilder<SqlDataReader, Student>
    {
        private readonly IMapper<SqlDataReader, Student> studentsMapper;

        public StudentsBuilder(IMapper<SqlDataReader, Student> studentsMapper)
        {
            this.studentsMapper = studentsMapper;
        }

        public IEnumerable<Student> Build(IEnumerable<SqlDataReader> from)
        {
            if (from.First().NextResult())
            {
                IEnumerable<Student> students = studentsMapper.Map(from);

                return students;
            }

            return Enumerable.Empty<Student>();
        }
    }
}
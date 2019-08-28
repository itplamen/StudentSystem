namespace StudentSystem.Data.Queries.Students
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;

    public class AllStudentsQueryHandler : IQueryHandler<IEnumerable<Student>>
    {
        public IEnumerable<Student> Handle()
        {
            ICollection<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(Data.Default.ConnectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Students", connection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                CreatedOn = Convert.ToDateTime(reader["CreatedOn"]),
                                ModifiedOn = Convert.ToDateTime(reader["ModifiedOn"]),
                                IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                                DeletedOn = Convert.ToDateTime(reader["DeletedOn"]),
                                FirstName = Convert.ToString(reader["FirstName"]),
                                LastName = Convert.ToString(reader["LastName"]),
                                Email = Convert.ToString(reader["Email"]),
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"])
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }
    }
}
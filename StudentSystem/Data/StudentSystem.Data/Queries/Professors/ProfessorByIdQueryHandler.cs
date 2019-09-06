namespace StudentSystem.Data.Queries.Professors
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;

    public class ProfessorByIdQueryHandler : IQueryHandler<ProfessorByIdQuery, Professor>
    {
        private readonly ISqlQueryExecutor sqlQueryExecutor;

        private SqlParameter professorIdParameter;

        public ProfessorByIdQueryHandler(ISqlQueryExecutor sqlQueryExecutor)
        {
            this.sqlQueryExecutor = sqlQueryExecutor;
        }

        public Professor Handle(ProfessorByIdQuery query)
        {
            string spQuery = "sp_GetProfessorDetails";
            professorIdParameter = new SqlParameter("@professorId", query.Id);

            Professor professor = sqlQueryExecutor.Execute(spQuery, Get);

            return professor;
        }

        private Professor Get(SqlCommand sqlCommand)
        {
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(professorIdParameter);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Professor professor = null;

                while (reader.Read())
                {
                    if (professor == null)
                    {
                        professor = new Professor()
                        {
                            Id = Convert.ToInt32(reader["ProfessorId"]),
                            FirstName = Convert.ToString(reader["ProfessorFirstName"]),
                            LastName = Convert.ToString(reader["ProfessorLastName"])
                        };
                    }

                    Semester semester = new Semester()
                    {
                        Id = Convert.ToInt32(reader["SemesterId"]),
                        Name = Convert.ToString(reader["SemesterName"])
                    };

                    Discipline discipline = new Discipline()
                    {
                        Id = Convert.ToInt32(reader["DisciplineId"]),
                        Name = Convert.ToString(reader["DisciplineName"]),
                        Semester = semester
                    };

                    professor.Disciplines.Add(discipline);
                }

                return professor;
            }
        }
    }
}
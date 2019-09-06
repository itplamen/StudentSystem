namespace StudentSystem.Data.Queries.Professors
{
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;

    public class ProfessorByIdQuery : IQuery<Professor>
    {
        public ProfessorByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
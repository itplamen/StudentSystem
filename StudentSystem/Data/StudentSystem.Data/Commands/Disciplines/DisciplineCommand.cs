namespace StudentSystem.Data.Commands.Disciplines
{
    using StudentSystem.Data.Contracts.Commands;

    public class DisciplineCommand : ICommand
    {
        public string Name { get; set; }

        public int SemesterId { get; set; }

        public int ProfessorId { get; set; }
    }
}
namespace StudentSystem.Data.Commands.Professors
{
    public class UpdateProfessorCommand : ProfessorCommand
    {
        public UpdateProfessorCommand(int id, string firstName, string lastName)
            : base(firstName, lastName)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
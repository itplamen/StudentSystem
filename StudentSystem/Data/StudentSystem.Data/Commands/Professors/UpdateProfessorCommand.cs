namespace StudentSystem.Data.Commands.Professors
{
    using StudentSystem.Data.Contracts.Commands;

    public class UpdateProfessorCommand : ICommand
    {
        public UpdateProfessorCommand(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
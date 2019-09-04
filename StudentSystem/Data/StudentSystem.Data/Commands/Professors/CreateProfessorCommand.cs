namespace StudentSystem.Data.Commands.Professors
{
    using StudentSystem.Data.Contracts.Commands;

    public class CreateProfessorCommand : ICommand
    {
        public CreateProfessorCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
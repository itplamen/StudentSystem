namespace StudentSystem.Data.Commands.Professors
{
    using StudentSystem.Data.Contracts.Commands;

    public class ProfessorCommand : ICommand
    {
        public ProfessorCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
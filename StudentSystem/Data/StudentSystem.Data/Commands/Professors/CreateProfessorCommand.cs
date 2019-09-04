namespace StudentSystem.Data.Commands.Professors
{
    using StudentSystem.Data.Contracts.Commands;

    public class CreateProfessorCommand : ICommand
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
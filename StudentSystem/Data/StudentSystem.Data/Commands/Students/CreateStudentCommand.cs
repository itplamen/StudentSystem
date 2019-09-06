namespace StudentSystem.Data.Commands.Students
{
    using System;

    using StudentSystem.Data.Contracts.Commands;

    public class CreateStudentCommand : ICommand
    {
        public CreateStudentCommand(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
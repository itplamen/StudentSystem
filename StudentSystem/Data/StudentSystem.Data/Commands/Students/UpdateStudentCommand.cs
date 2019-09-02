namespace StudentSystem.Data.Commands.Students
{
    using System;

    public class UpdateStudentCommand : StudentCommand
    {
        public UpdateStudentCommand(int id, string firstName, string lastName, string email, DateTime dateOfBirth)
            : base(firstName, lastName, email, dateOfBirth)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
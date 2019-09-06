namespace StudentSystem.Data.Commands.Students
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;
    
    public class CreateStudentCommandHandler : ICommandHandler<CreateStudentCommand, Student>
    {
        private const string TABLE_NAME = "Students";

        private readonly ICommandHandler<EntityCommand, int> createEntityHandler;

        public CreateStudentCommandHandler(ICommandHandler<EntityCommand, int> createEntityHandler)
        {
            this.createEntityHandler = createEntityHandler;
        }

        public Student Handle(CreateStudentCommand command)
        {
            DateTime createdOn = DateTime.UtcNow;

            EntityCommand entityCommand = new EntityCommand(TABLE_NAME);
            entityCommand.Columns.Add(nameof(command.FirstName), command.FirstName);
            entityCommand.Columns.Add(nameof(command.LastName), command.LastName);
            entityCommand.Columns.Add(nameof(command.Email), command.Email);
            entityCommand.Columns.Add(nameof(command.DateOfBirth), command.DateOfBirth);
            entityCommand.Columns.Add("CreatedOn", createdOn);

            int id = createEntityHandler.Handle(entityCommand);

            Student student = new Student()
            {
                Id = id,
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                DateOfBirth = command.DateOfBirth,
                CreatedOn = createdOn
            };

            return student;
        }
    }
}
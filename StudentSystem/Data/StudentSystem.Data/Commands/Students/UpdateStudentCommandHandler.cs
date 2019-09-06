namespace StudentSystem.Data.Commands.Students
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class UpdateStudentCommandHandler : ICommandHandler<UpdateStudentCommand, Student>
    {
        private const string TABLE_NAME = "Students";

        private readonly ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler;

        public UpdateStudentCommandHandler(ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler)
        {
            this.updateEntityHandler = updateEntityHandler;
        }

        public Student Handle(UpdateStudentCommand command)
        {
            DateTime modifiedOn = DateTime.UtcNow;

            UpdateEntityCommand entityCommand = new UpdateEntityCommand(TABLE_NAME, command.Id);
            entityCommand.Columns.Add(nameof(command.FirstName), command.FirstName);
            entityCommand.Columns.Add(nameof(command.LastName), command.LastName);
            entityCommand.Columns.Add(nameof(command.Email), command.Email);
            entityCommand.Columns.Add(nameof(command.DateOfBirth), command.DateOfBirth);
            entityCommand.Columns.Add("ModifiedOn", modifiedOn);

            bool isUpdated = updateEntityHandler.Handle(entityCommand);

            if (isUpdated)
            {
                Student student = new Student()
                {
                    Id = command.Id,
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Email = command.Email,
                    DateOfBirth = command.DateOfBirth,
                    ModifiedOn = modifiedOn
                };

                return student;
            }

            return null;
        }
    }
}
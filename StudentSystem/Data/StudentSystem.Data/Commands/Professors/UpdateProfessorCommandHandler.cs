namespace StudentSystem.Data.Commands.Professors
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class UpdateProfessorCommandHandler : ICommandHandler<UpdateProfessorCommand, Professor>
    {
        private const string TABLE_NAME = "Professors";

        private readonly ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler;

        public UpdateProfessorCommandHandler(ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler)
        {
            this.updateEntityHandler = updateEntityHandler;
        }

        public Professor Handle(UpdateProfessorCommand command)
        {
            DateTime modifiedOn = DateTime.UtcNow;

            UpdateEntityCommand entityCommand = new UpdateEntityCommand(TABLE_NAME, command.Id);
            entityCommand.Columns.Add(nameof(command.FirstName), command.FirstName);
            entityCommand.Columns.Add(nameof(command.LastName), command.LastName);
            entityCommand.Columns.Add("ModifiedOn", modifiedOn);

            bool isUpdated = updateEntityHandler.Handle(entityCommand);

            if (isUpdated)
            {
                Professor professor = new Professor()
                {
                    Id = command.Id,
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    ModifiedOn = modifiedOn
                };

                return professor;
            }

            return null;
        }
    }
}
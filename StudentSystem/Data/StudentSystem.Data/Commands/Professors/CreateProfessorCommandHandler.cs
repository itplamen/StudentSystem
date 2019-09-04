namespace StudentSystem.Data.Commands.Professors
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class CreateProfessorCommandHandler : ICommandHandler<CreateProfessorCommand, Professor>
    {
        private const string TABLE_NAME = "Professors";

        private readonly ICommandHandler<EntityCommand, int> createEntityHandler;

        public CreateProfessorCommandHandler(ICommandHandler<EntityCommand, int> createEntityHandler)
        {
            this.createEntityHandler = createEntityHandler;
        }

        public Professor Handle(CreateProfessorCommand command)
        {
            DateTime createdOn = DateTime.UtcNow;

            EntityCommand entityCommand = new EntityCommand(TABLE_NAME);
            entityCommand.Columns.Add(nameof(command.FirstName), command.FirstName);
            entityCommand.Columns.Add(nameof(command.LastName), command.LastName);
            entityCommand.Columns.Add("CreatedOn", createdOn);

            int id = createEntityHandler.Handle(entityCommand);

            Professor professor = new Professor()
            {
                Id = id,
                FirstName = command.FirstName,
                LastName = command.LastName,
                CreatedOn = createdOn
            };

            return professor;
        }
    }
}
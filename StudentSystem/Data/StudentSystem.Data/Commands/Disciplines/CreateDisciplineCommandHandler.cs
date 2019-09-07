namespace StudentSystem.Data.Commands.Disciplines
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class CreateDisciplineCommandHandler : ICommandHandler<DisciplineCommand, Discipline>
    {
        private const string TABLE_NAME = "Disciplines";

        private readonly ICommandHandler<EntityCommand, int> createEntityHandler;

        public CreateDisciplineCommandHandler(ICommandHandler<EntityCommand, int> createEntityHandler)
        {
            this.createEntityHandler = createEntityHandler;
        }

        public Discipline Handle(DisciplineCommand command)
        {
            DateTime createdOn = DateTime.UtcNow;

            EntityCommand entityCommand = new EntityCommand(TABLE_NAME);
            entityCommand.Columns.Add(nameof(command.Name), command.Name);
            entityCommand.Columns.Add(nameof(command.ProfessorId), command.ProfessorId);
            entityCommand.Columns.Add(nameof(command.SemesterId), command.SemesterId);
            entityCommand.Columns.Add("CreatedOn", createdOn);

            int id = createEntityHandler.Handle(entityCommand);

            Discipline discipline = new Discipline()
            {
                Id = id,
                Name = command.Name,
                ProfessorId = command.ProfessorId,
                SemesterId = command.SemesterId,
                CreatedOn = createdOn
            };

            return discipline;
        }
    }
}
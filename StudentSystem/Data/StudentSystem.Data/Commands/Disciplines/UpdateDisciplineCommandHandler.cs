namespace StudentSystem.Data.Commands.Disciplines
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class UpdateDisciplineCommandHandler : ICommandHandler<UpdateDisciplineCommand, Discipline>
    {
        private const string TABLE_NAME = "Disciplines";

        private readonly ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler;

        public UpdateDisciplineCommandHandler(ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler)
        {
            this.updateEntityHandler = updateEntityHandler;
        }

        public Discipline Handle(UpdateDisciplineCommand command)
        {
            DateTime modifiedOn = DateTime.UtcNow;

            UpdateEntityCommand entityCommand = new UpdateEntityCommand(TABLE_NAME, command.Id);
            entityCommand.Columns.Add(nameof(command.Name), command.Name);
            entityCommand.Columns.Add(nameof(command.SemesterId), command.SemesterId);
            entityCommand.Columns.Add(nameof(command.ProfessorId), command.ProfessorId);
            entityCommand.Columns.Add("ModifiedOn", modifiedOn);

            bool isUpdated = updateEntityHandler.Handle(entityCommand);

            if (isUpdated)
            {
                Discipline discipline = new Discipline()
                {
                    Id = command.Id,
                    Name = command.Name,
                    SemesterId = command.SemesterId,
                    ProfessorId = command.ProfessorId,
                    ModifiedOn = modifiedOn
                };

                return discipline;
            }

            return null;
        }
    }
}
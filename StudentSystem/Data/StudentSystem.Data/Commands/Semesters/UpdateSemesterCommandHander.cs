namespace StudentSystem.Data.Commands.Semesters
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class UpdateSemesterCommandHander : ICommandHandler<UpdateSemesterCommand, Semester>
    {
        private const string TABLE_NAME = "Semesters";

        private readonly ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler;

        public UpdateSemesterCommandHander(ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler)
        {
            this.updateEntityHandler = updateEntityHandler;
        }

        public Semester Handle(UpdateSemesterCommand command)
        {
            DateTime modifiedOn = DateTime.UtcNow;

            UpdateEntityCommand entityCommand = new UpdateEntityCommand(TABLE_NAME, command.Id);
            entityCommand.Columns.Add(nameof(command.Name), command.Name);
            entityCommand.Columns.Add(nameof(command.StartDate), command.StartDate);
            entityCommand.Columns.Add(nameof(command.EndDate), command.EndDate);
            entityCommand.Columns.Add("ModifiedOn", modifiedOn);

            bool isUpdated = updateEntityHandler.Handle(entityCommand);

            if (isUpdated)
            {
                Semester semester = new Semester()
                {
                    Id = command.Id,
                    Name = command.Name,
                    StartDate = command.StartDate,
                    EndDate = command.EndDate,
                    ModifiedOn = modifiedOn
                };

                return semester;
            }

            return null;
        }
    }
}
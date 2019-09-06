namespace StudentSystem.Data.Commands.Semesters
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class CreateSemesterCommandHandler : ICommandHandler<SemesterCommand, Semester>
    {
        private const string TABLE_NAME = "Semesters";

        private readonly ICommandHandler<EntityCommand, int> createEntityHandler;

        public CreateSemesterCommandHandler(ICommandHandler<EntityCommand, int> createEntityHandler)
        {
            this.createEntityHandler = createEntityHandler;
        }

        public Semester Handle(SemesterCommand command)
        {
            DateTime createdOn = DateTime.UtcNow;

            EntityCommand entityCommand = new EntityCommand(TABLE_NAME);
            entityCommand.Columns.Add(nameof(command.Name), command.Name);
            entityCommand.Columns.Add(nameof(command.StartDate), command.StartDate);
            entityCommand.Columns.Add(nameof(command.EndDate), command.EndDate);
            entityCommand.Columns.Add("CreatedOn", createdOn);

            int id = createEntityHandler.Handle(entityCommand);

            Semester student = new Semester()
            {
                Id = id,
                Name = command.Name,
                StartDate = command.StartDate,
                EndDate = command.EndDate,
                CreatedOn = createdOn
            };

            return student;
        }
    }
}
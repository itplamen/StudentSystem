namespace StudentSystem.Data.Commands.Scores
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class CreateScoreCommandHandler : ICommandHandler<ScoreCommand, Score>
    {
        private const string TABLE_NAME = "Scores";

        private readonly ICommandHandler<EntityCommand, int> createEntityHandler;

        public CreateScoreCommandHandler(ICommandHandler<EntityCommand, int> createEntityHandler)
        {
            this.createEntityHandler = createEntityHandler;
        }

        public Score Handle(ScoreCommand command)
        {
            DateTime createdOn = DateTime.UtcNow;

            EntityCommand entityCommand = new EntityCommand(TABLE_NAME);
            entityCommand.Columns.Add(nameof(command.Mark), command.Mark);
            entityCommand.Columns.Add(nameof(command.StudentId), command.StudentId);
            entityCommand.Columns.Add(nameof(command.DisciplineId), command.DisciplineId);
            entityCommand.Columns.Add("CreatedOn", createdOn);

            int id = createEntityHandler.Handle(entityCommand);

            Score score = new Score()
            {
                Id = id,
                Mark = command.Mark,
                StudentId = command.StudentId,
                DisciplineId = command.DisciplineId,
                CreatedOn = createdOn
            };

            return score;
        }
    }
}
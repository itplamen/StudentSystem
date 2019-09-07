namespace StudentSystem.Data.Commands.Scores
{
    using System;

    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Models;

    public class UpdateScoreCommandHandler : ICommandHandler<UpdateScoreCommand, Score>
    {
        private const string TABLE_NAME = "Scores";

        private readonly ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler;

        public UpdateScoreCommandHandler(ICommandHandler<UpdateEntityCommand, bool> updateEntityHandler)
        {
            this.updateEntityHandler = updateEntityHandler;
        }

        public Score Handle(UpdateScoreCommand command)
        {
            DateTime modifiedOn = DateTime.UtcNow;

            UpdateEntityCommand entityCommand = new UpdateEntityCommand(TABLE_NAME, command.Id);
            entityCommand.Columns.Add(nameof(command.Mark), command.Mark);
            entityCommand.Columns.Add(nameof(command.StudentId), command.StudentId);
            entityCommand.Columns.Add(nameof(command.DisciplineId), command.DisciplineId);
            entityCommand.Columns.Add("ModifiedOn", modifiedOn);

            bool isUpdated = updateEntityHandler.Handle(entityCommand);

            if (isUpdated)
            {
                Score score = new Score()
                {
                    Id = command.Id,
                    Mark = command.Mark,
                    StudentId = command.StudentId,
                    DisciplineId = command.DisciplineId,
                    ModifiedOn = modifiedOn
                };

                return score;
            }

            return null;
        }
    }
}
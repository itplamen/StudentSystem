namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Contracts.Commands;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Data.Queries.Common;
    using StudentSystem.Services.Models.Web.Scores;
    using StudentSystem.Services.Web.Contracts;

    public class ScoresService : IScoresService
    {
        private const string TABLE_NAME = "Scores";

        private readonly IMapper<Score, ScoreResponseModel> scoresMapper;
        private readonly ICommandHandler<EntityCommand, int> createScoreHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteScoreHandler;
        private readonly ICommandHandler<UpdateEntityCommand, bool> updateScoreHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Score>, IEnumerable<Score>> getAllScoresHandler;

        public ScoresService(
            IMapper<Score, ScoreResponseModel> scoresMapper,
            ICommandHandler<EntityCommand, int> createScoreHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteScoreHandler,
            ICommandHandler<UpdateEntityCommand, bool> updateScoreHandler,
            IQueryHandler<AllEntitiesQuery<Score>, IEnumerable<Score>> getAllScoresHandler)
        {
            this.scoresMapper = scoresMapper;
            this.createScoreHandler = createScoreHandler;
            this.deleteScoreHandler = deleteScoreHandler;
            this.updateScoreHandler = updateScoreHandler;
            this.getAllScoresHandler = getAllScoresHandler;
        }

        public bool Create(ScoreRequestModel request)
        {
            EntityCommand command = new EntityCommand(TABLE_NAME);
            command.Columns.Add(nameof(request.Mark), request.Mark);
            command.Columns.Add(nameof(request.StudentId), request.StudentId);
            command.Columns.Add(nameof(request.DisciplineId), request.DisciplineId);

            int id = createScoreHandler.Handle(command);

            return id > 0;
        }

        public IEnumerable<ScoreResponseModel> Get()
        {
            AllEntitiesQuery<Score> query = new AllEntitiesQuery<Score>(TABLE_NAME, false);
            IEnumerable<Score> scores = getAllScoresHandler.Handle(query);

            IEnumerable<ScoreResponseModel> responseModels = scoresMapper.Map(scores);

            return responseModels;
        }

        public bool Update(UpdateScoreRequestModel request)
        {
            UpdateEntityCommand command = new UpdateEntityCommand(TABLE_NAME, request.Id);
            command.Columns.Add(nameof(request.Mark), request.Mark);
            command.Columns.Add(nameof(request.StudentId), request.StudentId);
            command.Columns.Add(nameof(request.DisciplineId), request.DisciplineId);

            bool isUpdated = updateScoreHandler.Handle(command);

            return isUpdated;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteScoreHandler.Handle(command);

            return isDeleted;
        }
    }
}
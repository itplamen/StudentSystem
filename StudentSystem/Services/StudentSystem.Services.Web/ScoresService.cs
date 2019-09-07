namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Commands.Common;
    using StudentSystem.Data.Commands.Scores;
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
        private readonly ICommandHandler<ScoreCommand, Score> createScoreHandler;
        private readonly ICommandHandler<DeleteEntityCommand, bool> deleteScoreHandler;
        private readonly ICommandHandler<UpdateScoreCommand, Score> updateScoreHandler;
        private readonly IQueryHandler<AllEntitiesQuery<Score>, IEnumerable<Score>> getAllScoresHandler;

        public ScoresService(
            IMapper<Score, ScoreResponseModel> scoresMapper,
            ICommandHandler<ScoreCommand, Score> createScoreHandler,
            ICommandHandler<DeleteEntityCommand, bool> deleteScoreHandler,
            ICommandHandler<UpdateScoreCommand, Score> updateScoreHandler,
            IQueryHandler<AllEntitiesQuery<Score>, IEnumerable<Score>> getAllScoresHandler)
        {
            this.scoresMapper = scoresMapper;
            this.createScoreHandler = createScoreHandler;
            this.deleteScoreHandler = deleteScoreHandler;
            this.updateScoreHandler = updateScoreHandler;
            this.getAllScoresHandler = getAllScoresHandler;
        }

        public ScoreResponseModel Create(ScoreRequestModel request)
        {
            ScoreCommand command = new ScoreCommand(request.Mark, request.StudentId, request.DisciplineId);
            Score score = createScoreHandler.Handle(command);

            ScoreResponseModel response = scoresMapper.Map(score);

            return response;
        }

        public IEnumerable<ScoreResponseModel> All()
        {
            AllEntitiesQuery<Score> query = new AllEntitiesQuery<Score>(TABLE_NAME, false);
            IEnumerable<Score> scores = getAllScoresHandler.Handle(query);

            IEnumerable<ScoreResponseModel> responseModels = scoresMapper.Map(scores);

            return responseModels;
        }

        public ScoreResponseModel Update(int id, ScoreRequestModel request)
        {
            UpdateScoreCommand command = new UpdateScoreCommand(id, request.Mark, request.StudentId, request.DisciplineId);
            Score score = updateScoreHandler.Handle(command);

            ScoreResponseModel response = scoresMapper.Map(score);

            return response;
        }

        public bool Delete(int id)
        {
            DeleteEntityCommand command = new DeleteEntityCommand(id, TABLE_NAME);
            bool isDeleted = deleteScoreHandler.Handle(command);

            return isDeleted;
        }
    }
}
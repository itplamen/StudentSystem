namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Scores;

    [ServiceContract]
    public interface IScoresService
    {
        [OperationContract]
        bool Create(ScoreRequestModel request);

        [OperationContract]
        IEnumerable<ScoreResponseModel> Get();

        [OperationContract]
        bool Update(UpdateScoreRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Scores;

    [ServiceContract]
    public interface IScoresService
    {
        [OperationContract]
        ScoreResponseModel Create(ScoreRequestModel request);

        [OperationContract]
        IEnumerable<ScoreResponseModel> All();

        [OperationContract]
        ScoreResponseModel Update(int id, ScoreRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
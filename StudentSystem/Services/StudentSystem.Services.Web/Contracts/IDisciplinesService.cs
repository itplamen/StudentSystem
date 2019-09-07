namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Disciplines;

    [ServiceContract]
    public interface IDisciplinesService
    {
        [OperationContract]
        DisciplineResponseModel Create(DisciplineRequestModel request);

        [OperationContract]
        IEnumerable<DisciplineResponseModel> Get();

        [OperationContract]
        DisciplineResponseModel Update(UpdateDisciplineRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
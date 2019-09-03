namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Disciplines;

    [ServiceContract]
    public interface IDisciplinesService
    {
        [OperationContract]
        bool Create(DisciplineRequestModel request);

        [OperationContract]
        IEnumerable<DisciplineResponseModel> Get();

        [OperationContract]
        bool Update(UpdateDisciplineRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
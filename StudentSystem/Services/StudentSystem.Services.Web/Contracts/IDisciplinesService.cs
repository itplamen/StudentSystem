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
        IEnumerable<DisciplineResponseModel> All();

        [OperationContract]
        DisciplineResponseModel Update(int id, DisciplineRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
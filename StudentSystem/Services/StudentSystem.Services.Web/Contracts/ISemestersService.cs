namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Semesters;

    [ServiceContract]
    public interface ISemestersService
    {
        [OperationContract]
        bool Create(SemesterRequestModel request);

        [OperationContract]
        IEnumerable<SemesterResponseModel> Get();

        [OperationContract]
        bool Update(UpdateSemesterRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
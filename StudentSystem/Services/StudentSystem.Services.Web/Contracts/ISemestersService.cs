namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Semesters;

    [ServiceContract]
    public interface ISemestersService
    {
        [OperationContract]
        SemesterResponseModel Create(SemesterRequestModel request);

        [OperationContract]
        IEnumerable<SemesterResponseModel> All();

        [OperationContract]
        SemesterResponseModel Update(int id, SemesterRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
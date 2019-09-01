namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Models.Web.Students;

    [ServiceContract]
    public interface IStudentsService
    {
        [OperationContract]
        bool Create(StudentRequestModel request);

        [OperationContract]
        IEnumerable<SemesterResponseModel> Get();
    }
}
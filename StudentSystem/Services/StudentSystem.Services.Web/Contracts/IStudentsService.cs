namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Students;

    [ServiceContract]
    public interface IStudentsService
    {
        [OperationContract]
        StudentResponseModel Create(StudentRequestModel request);

        [OperationContract]
        IEnumerable<StudentResponseModel> All();

        [OperationContract]
        StudentResponseModel Update(int id, StudentRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
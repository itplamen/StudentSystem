namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web;

    [ServiceContract]
    public interface IStudentsService
    {
        [OperationContract]
        IEnumerable<StudentModel> GetAll();
    }
}
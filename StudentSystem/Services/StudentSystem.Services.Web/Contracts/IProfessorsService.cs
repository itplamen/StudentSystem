namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Professors;

    [ServiceContract]
    public interface IProfessorsService
    {
        [OperationContract]
        ProfessorResponseModel Create(ProfessorRequestModel request);

        [OperationContract]
        IEnumerable<ProfessorResponseModel> Get();

        [OperationContract]
        bool Update(UpdateProfessorRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
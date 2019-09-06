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
        ProfessorResponseModel Get(int id);

        [OperationContract]
        IEnumerable<ProfessorResponseModel> All();

        [OperationContract]
        ProfessorResponseModel Update(int id, ProfessorRequestModel request);

        [OperationContract]
        bool Delete(int id);
    }
}
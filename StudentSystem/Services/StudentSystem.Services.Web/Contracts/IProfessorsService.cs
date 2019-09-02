namespace StudentSystem.Services.Web.Contracts
{
    using System.ServiceModel;

    using StudentSystem.Services.Models.Web.Professors;

    [ServiceContract]
    public interface IProfessorsService
    {
        [OperationContract]
        bool Create(ProfessorRequestModel request);
    }
}
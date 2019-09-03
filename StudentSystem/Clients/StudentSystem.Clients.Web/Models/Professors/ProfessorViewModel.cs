namespace StudentSystem.Clients.Web.Models.Professors
{
    using StudentSystem.Clients.Web.Models.Base;
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;

    public class ProfessorViewModel : BaseViewModel, IMapFrom<ProfessorResponseModel>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
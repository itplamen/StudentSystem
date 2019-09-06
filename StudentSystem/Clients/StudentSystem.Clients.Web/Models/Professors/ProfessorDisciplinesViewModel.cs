namespace StudentSystem.Clients.Web.Models.Professors
{
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;

    public class ProfessorDisciplinesViewModel : IMapFrom<DisciplineResponseModel>
    {
        public string Name { get; set; }

        public int SemesterId { get; set; }

        public ProfessorSemestersViewModel Semester { get; set; }
    }
}
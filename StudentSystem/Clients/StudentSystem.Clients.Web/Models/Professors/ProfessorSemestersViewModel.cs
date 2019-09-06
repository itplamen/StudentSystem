namespace StudentSystem.Clients.Web.Models.Professors
{
    using System;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;

    public class ProfessorSemestersViewModel : IMapFrom<SemesterResponseModel>
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
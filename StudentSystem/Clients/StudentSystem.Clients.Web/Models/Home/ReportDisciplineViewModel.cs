namespace StudentSystem.Clients.Web.Models.Home
{
    using System.Collections.Generic;

    using AutoMapper;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ReportsServiceSoap;

    public class ReportDisciplineViewModel : IMapFrom<DisciplineResponseModel>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public int ProfessorId { get; set; }

        public string ProfessorName { get; set; }

        public IEnumerable<ReportScoreViewModel> Scores { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<DisciplineResponseModel, ReportDisciplineViewModel>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.ProfessorId, opt => opt.MapFrom(x => x.ProfessorId))
                .ForMember(x => x.ProfessorName, opt => opt.MapFrom(x => x.Professor.FirstName + " " + x.Professor.LastName));
        }
    }
}
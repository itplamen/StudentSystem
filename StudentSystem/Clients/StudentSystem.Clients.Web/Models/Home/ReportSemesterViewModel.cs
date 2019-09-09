namespace StudentSystem.Clients.Web.Models.Home
{
    using System.Collections.Generic;

    using AutoMapper;

    using StudentSystem.Clients.Web.Mappers;
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ReportsServiceSoap;

    public class ReportSemesterViewModel : IMapFrom<SemesterResponseModel>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public IEnumerable<ReportDisciplineViewModel> Disciplines { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<SemesterResponseModel, ReportSemesterViewModel>()
                .ForMember(x => x.StartDate, opt => opt.MapFrom(x => DateTimeMapper.Map(x.StartDate)))
                .ForMember(x => x.EndDate, opt => opt.MapFrom(x => DateTimeMapper.Map(x.EndDate)));
        }
    }
}
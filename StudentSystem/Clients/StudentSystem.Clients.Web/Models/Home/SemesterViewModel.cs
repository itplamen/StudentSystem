namespace StudentSystem.Clients.Web.Models.Home
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using StudentSystem.Infrastructure.Clients.Web.Mapping;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class SemesterViewModel : IMapFrom<SemesterResponseModel>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<ScoreViewModel> Scores { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<SemesterResponseModel, SemesterViewModel>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.StartDate, opt => opt.MapFrom(x => x.StartDate))
                .ForMember(x => x.EndDate, opt => opt.MapFrom(x => x.EndDate));
        }
    }
}
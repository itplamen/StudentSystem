namespace StudentSystem.Clients.Web.Models.Semesters
{
    using System;

    using AutoMapper;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;

    public class SemesterViewModel : IMapFrom<SemesterResponseModel>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<SemesterResponseModel, SemesterViewModel>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.StartDate, opt => opt.MapFrom(x => x.StartDate))
                .ForMember(x => x.EndDate, opt => opt.MapFrom(x => x.EndDate));
        }
    }
}
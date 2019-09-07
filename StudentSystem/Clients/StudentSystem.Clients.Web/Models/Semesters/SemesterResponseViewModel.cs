namespace StudentSystem.Clients.Web.Models.Semesters
{
    using AutoMapper;

    using StudentSystem.Clients.Web.Mappers;
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.SemestersServiceSoap;

    public class SemesterResponseViewModel : IMapFrom<SemesterResponseModel>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string CreatedOn { get; set; }

        public string ModifiedOn { get; set; }

        public string Name { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<SemesterResponseModel, SemesterResponseViewModel>()
                .ForMember(x => x.CreatedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.CreatedOn)))
                .ForMember(x => x.ModifiedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.ModifiedOn)))
                .ForMember(x => x.StartDate, opt => opt.MapFrom(x => DateTimeMapper.Map(x.StartDate)))
                .ForMember(x => x.EndDate, opt => opt.MapFrom(x => DateTimeMapper.Map(x.EndDate)));
        }
    }
}
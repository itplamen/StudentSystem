namespace StudentSystem.Clients.Web.Models.Disciplines
{
    using AutoMapper;

    using StudentSystem.Clients.Web.Mappers;
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.DisciplinesServiceSoap;

    public class DisciplineResponseViewModel : IMapFrom<DisciplineResponseModel>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string CreatedOn { get; set; }

        public string ModifiedOn { get; set; }

        public string Name { get; set; }

        public int SemesterId { get; set; }

        public int ProfessorId { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<DisciplineResponseModel, DisciplineResponseViewModel>()
                .ForMember(x => x.CreatedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.CreatedOn)))
                .ForMember(x => x.ModifiedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.ModifiedOn)));
        }
    }
}
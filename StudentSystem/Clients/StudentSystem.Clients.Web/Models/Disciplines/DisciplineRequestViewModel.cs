namespace StudentSystem.Clients.Web.Models.Disciplines
{
    using AutoMapper;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.DisciplinesServiceSoap;

    public class DisciplineRequestViewModel : IMapTo<DisciplineRequestModel>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public int SemesterId { get; set; }

        public int ProfessorId { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<DisciplineRequestViewModel, DisciplineRequestModel>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.SemesterId, opt => opt.MapFrom(x => x.SemesterId))
                .ForMember(x => x.ProfessorId, opt => opt.MapFrom(x => x.ProfessorId));
        }
    }
}
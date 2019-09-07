namespace StudentSystem.Clients.Web.Models.Scores
{
    using AutoMapper;

    using StudentSystem.Clients.Web.Mappers;
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ScoresServiceSoap;

    public class ScoreResponseViewModel : IMapFrom<ScoreResponseModel>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string CreatedOn { get; set; }

        public string ModifiedOn { get; set; }

        public float Mark { get; set; }

        public int StudentId { get; set; }

        public int DisciplineId { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ScoreResponseModel, ScoreResponseViewModel>()
                .ForMember(x => x.CreatedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.CreatedOn)))
                .ForMember(x => x.ModifiedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.ModifiedOn)));
        }
    }
}
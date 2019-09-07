namespace StudentSystem.Clients.Web.Models.Scores
{
    using AutoMapper;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ScoresServiceSoap;

    public class ScoreRequestViewModel : IMapTo<ScoreRequestModel>, IHaveCustomMappings
    {
        public float Mark { get; set; }

        public int StudentId { get; set; }

        public int DisciplineId { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ScoreRequestViewModel, ScoreRequestModel>()
                .ForMember(x => x.Mark, opt => opt.MapFrom(x => x.Mark))
                .ForMember(x => x.StudentId, opt => opt.MapFrom(x => x.StudentId))
                .ForMember(x => x.DisciplineId, opt => opt.MapFrom(x => x.DisciplineId));
        }
    }
}
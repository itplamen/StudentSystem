namespace StudentSystem.Clients.Web.Models.Home
{
    using AutoMapper;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ReportsServiceSoap;

    public class ReportScoreViewModel : IMapFrom<ScoreResponseModel>, IHaveCustomMappings
    {
        public float Mark { get; set; }

        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ScoreResponseModel, ReportScoreViewModel>()
                .ForMember(x => x.Mark, opt => opt.MapFrom(x => x.Mark))
                .ForMember(x => x.StudentId, opt => opt.MapFrom(x => x.StudentId))
                .ForMember(x => x.StudentName, opt => opt.MapFrom(x => x.Student.FirstName + " " + x.Student.LastName));
        }
    }
}
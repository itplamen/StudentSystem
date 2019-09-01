namespace StudentSystem.Clients.Web.Models.Home
{
    using AutoMapper;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class ScoreViewModel : IMapFrom<DisciplineResponseModel>, IHaveCustomMappings
    {
        public string DisciplineName { get; set; }

        public string ProfessorName { get; set; }

        public float Score { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<DisciplineResponseModel, ScoreViewModel>()
                .ForMember(x => x.DisciplineName, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.ProfessorName, opt => opt.MapFrom(x => x.Professor.FirstName + " " + x.Professor.LastName));
        }
    }
}
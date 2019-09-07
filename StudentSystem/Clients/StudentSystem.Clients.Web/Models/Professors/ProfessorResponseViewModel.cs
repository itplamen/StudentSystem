namespace StudentSystem.Clients.Web.Models.Professors
{
    using System.Collections.Generic;

    using AutoMapper;

    using StudentSystem.Clients.Web.Mappers;
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;

    public class ProfessorResponseViewModel : IMapFrom<ProfessorResponseModel>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string CreatedOn { get; set; }

        public string ModifiedOn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<ProfessorDisciplinesViewModel> Disciplines { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ProfessorResponseModel, ProfessorResponseViewModel>()
                .ForMember(x => x.CreatedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.CreatedOn)))
                .ForMember(x => x.ModifiedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.ModifiedOn)));
        }
    }
}
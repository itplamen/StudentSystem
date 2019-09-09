namespace StudentSystem.Clients.Web.Models.Students
{
    using AutoMapper;

    using StudentSystem.Clients.Web.Mappers;
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentResponseViewModel : IMapFrom<StudentResponseModel>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string CreatedOn { get; set; }

        public string ModifiedOn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string DateOfBirth { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<StudentResponseModel, StudentResponseViewModel>()
                .ForMember(x => x.CreatedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.CreatedOn)))
                .ForMember(x => x.ModifiedOn, opt => opt.MapFrom(x => DateTimeMapper.Map(x.ModifiedOn)))
                .ForMember(x => x.DateOfBirth, opt => opt.MapFrom(x => DateTimeMapper.Map(x.DateOfBirth)));
        }
    }
}
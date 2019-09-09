namespace StudentSystem.Clients.Web.Models.Students
{
    using System;

    using AutoMapper;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentRequestViewModel : IMapTo<StudentRequestModel>, IHaveCustomMappings
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<StudentRequestViewModel, StudentRequestModel>()
                .ForMember(x => x.FirstName, opt => opt.MapFrom(x => x.FirstName))
                .ForMember(x => x.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(x => x.DateOfBirth, opt => opt.MapFrom(x => x.DateOfBirth));
        }
    }
}
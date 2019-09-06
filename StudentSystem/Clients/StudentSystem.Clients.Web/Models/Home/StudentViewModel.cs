namespace StudentSystem.Clients.Web.Models.Home
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentViewModel/* : IMapFrom<StudentResponseModel>, IHaveCustomMappings*/
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public IEnumerable<SemesterViewModel> Semesters { get; set; }

        //public void CreateMappings(IProfileExpression configuration)
        //{
        //    configuration.CreateMap<StudentResponseModel, StudentViewModel>()
        //        .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
        //        .ForMember(x => x.FirstName, opt => opt.MapFrom(x => x.FirstName))
        //        .ForMember(x => x.LastName, opt => opt.MapFrom(x => x.LastName))
        //        .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
        //        .ForMember(x => x.DateOfBirth, opt => opt.MapFrom(x => x.DateOfBirth));
        //}
    }
}
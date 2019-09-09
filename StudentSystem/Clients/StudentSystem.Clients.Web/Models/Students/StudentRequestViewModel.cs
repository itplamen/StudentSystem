namespace StudentSystem.Clients.Web.Models.Students
{
    using System;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentRequestViewModel : IMapTo<StudentRequestModel>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
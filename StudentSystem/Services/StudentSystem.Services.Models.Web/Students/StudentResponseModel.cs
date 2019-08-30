namespace StudentSystem.Services.Models.Web.Students
{
    using System;
    using System.Runtime.Serialization;

    using StudentSystem.Services.Models.Web.Base;

    [DataContract]
    public class StudentResponseModel : BaseResponseModel
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
}
namespace StudentSystem.Services.Models.Web.Students
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class StudentRequestModel
    {
        [DataMember]
        public int Id { get; set; }

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
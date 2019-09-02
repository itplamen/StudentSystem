namespace StudentSystem.Services.Models.Web.Semesters
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class SemesterRequestModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }
    }
}
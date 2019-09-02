namespace StudentSystem.Services.Models.Web.Professors
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ProfessorRequestModel
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}
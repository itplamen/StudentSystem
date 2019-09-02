namespace StudentSystem.Services.Models.Web.Professors
{
    using System.Runtime.Serialization;

    [DataContract]
    public class UpdateProfessorRequestModel : ProfessorRequestModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}
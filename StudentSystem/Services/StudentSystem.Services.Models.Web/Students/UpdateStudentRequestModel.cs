namespace StudentSystem.Services.Models.Web.Students
{
    using System.Runtime.Serialization;

    [DataContract]
    public class UpdateStudentRequestModel : StudentRequestModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}
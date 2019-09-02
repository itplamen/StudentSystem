namespace StudentSystem.Services.Models.Web.Semesters
{
    using System.Runtime.Serialization;

    [DataContract]
    public class UpdateSemesterRequestModel : SemesterRequestModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}
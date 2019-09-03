namespace StudentSystem.Services.Models.Web.Disciplines
{
    using System.Runtime.Serialization;

    [DataContract]
    public class UpdateDisciplineRequestModel : DisciplineRequestModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}
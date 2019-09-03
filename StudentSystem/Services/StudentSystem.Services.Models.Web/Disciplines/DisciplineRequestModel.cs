namespace StudentSystem.Services.Models.Web.Disciplines
{
    using System.Runtime.Serialization;

    [DataContract]
    public class DisciplineRequestModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int SemesterId { get; set; }

        [DataMember]
        public int ProfessorId { get; set; }
    }
}
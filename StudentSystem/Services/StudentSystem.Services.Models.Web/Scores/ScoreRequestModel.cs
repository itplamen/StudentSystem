namespace StudentSystem.Services.Models.Web.Scores
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ScoreRequestModel
    {
        [DataMember]
        public float Mark { get; set; }

        [DataMember]
        public int StudentId { get; set; }

        [DataMember]
        public int DisciplineId { get; set; }
    }
}
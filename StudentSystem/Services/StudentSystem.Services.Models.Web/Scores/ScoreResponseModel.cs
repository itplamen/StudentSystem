namespace StudentSystem.Services.Models.Web.Scores
{
    using System.Runtime.Serialization;

    using StudentSystem.Services.Models.Web.Base;
    using StudentSystem.Services.Models.Web.Students;

    [DataContract]
    public class ScoreResponseModel : BaseResponseModel
    {
        [DataMember]
        public float Mark { get; set; }

        [DataMember]
        public int StudentId { get; set; }

        [DataMember]
        public int DisciplineId { get; set; }

        [DataMember]
        public StudentResponseModel Student { get; set; }
    }
}
namespace StudentSystem.Services.Models.Web.Scores
{
    using System.Runtime.Serialization;

    using StudentSystem.Services.Models.Web.Base;

    [DataContract]
    public class ScoreResponseModel : BaseResponseModel
    {
        [DataMember]
        public string Discipline { get; set; }

        [DataMember]
        public string Professor { get; set; }

        [DataMember]
        public float Score { get; set; }
    }
}
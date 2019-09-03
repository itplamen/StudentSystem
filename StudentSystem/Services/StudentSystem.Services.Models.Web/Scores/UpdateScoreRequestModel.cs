namespace StudentSystem.Services.Models.Web.Scores
{
    using System.Runtime.Serialization;

    [DataContract]
    public class UpdateScoreRequestModel : ScoreRequestModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}
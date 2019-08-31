namespace StudentSystem.Services.Models.Web.Disciplines
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using StudentSystem.Services.Models.Web.Base;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Models.Web.Scores;

    [DataContract]
    public class DisciplineResponseModel : BaseResponseModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int SemesterId { get; set; }

        [DataMember]
        public int ProfessorId { get; set; }

        [DataMember]
        public ProfessorResponseModel Professor { get; set; }

        [DataMember]
        public IEnumerable<ScoreResponseModel> Scores { get; set; }
    }
}
namespace StudentSystem.Services.Models.Web.Semesters
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using StudentSystem.Services.Models.Web.Base;
    using StudentSystem.Services.Models.Web.Scores;

    [DataContract]
    public class SemesterResponseModel : BaseResponseModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }

        [DataMember]
        public IEnumerable<ScoreResponseModel> Scores { get; set; }
    }
}
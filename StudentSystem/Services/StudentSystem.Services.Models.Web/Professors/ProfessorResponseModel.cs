namespace StudentSystem.Services.Models.Web.Professors
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using StudentSystem.Services.Models.Web.Base;
    using StudentSystem.Services.Models.Web.Disciplines;

    [DataContract]
    public class ProfessorResponseModel : BaseResponseModel
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public IEnumerable<DisciplineResponseModel> Disciplines { get; set; }
    }
}
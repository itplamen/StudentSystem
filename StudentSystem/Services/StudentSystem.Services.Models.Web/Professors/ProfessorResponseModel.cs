namespace StudentSystem.Services.Models.Web.Professors
{
    using System.Runtime.Serialization;

    using StudentSystem.Services.Models.Web.Base;

    [DataContract]
    public class ProfessorResponseModel : BaseResponseModel
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}
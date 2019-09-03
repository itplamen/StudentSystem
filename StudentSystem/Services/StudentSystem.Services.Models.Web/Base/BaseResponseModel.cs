namespace StudentSystem.Services.Models.Web.Base
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public abstract class BaseResponseModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public DateTime? ModifiedOn { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public DateTime? DeletedOn { get; set; }
    }
}
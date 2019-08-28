namespace StudentSystem.Services.Models.Web
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class StudentModel
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

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
}
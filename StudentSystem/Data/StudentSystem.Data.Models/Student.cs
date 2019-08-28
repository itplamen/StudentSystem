namespace StudentSystem.Data.Models
{
    using System;

    using StudentSystem.Data.Models.Base;
    
    public class Student : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
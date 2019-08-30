namespace StudentSystem.Data.Models
{
    using StudentSystem.Data.Models.Base;

    public class Professor : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
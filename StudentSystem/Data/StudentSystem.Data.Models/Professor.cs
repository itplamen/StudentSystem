namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;

    using StudentSystem.Data.Models.Base;

    public class Professor : BaseModel
    {
        public Professor()
        {
            Disciplines = new HashSet<Discipline>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Discipline> Disciplines { get; set; }
    }
}
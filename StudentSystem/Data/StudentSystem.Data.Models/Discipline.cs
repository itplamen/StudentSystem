namespace StudentSystem.Data.Models
{
    using System.Collections.Generic;

    using StudentSystem.Data.Models.Base;

    public class Discipline : BaseModel
    {
        public string Name { get; set; }

        public int SemesterId { get; set; }

        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public IEnumerable<Score> Scores { get; set; }
    }
}
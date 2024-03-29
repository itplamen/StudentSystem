﻿namespace StudentSystem.Data.Models
{
    using StudentSystem.Data.Models.Base;
    using System.Collections.Generic;

    public class Discipline : BaseModel
    {
        public string Name { get; set; }

        public int SemesterId { get; set; }

        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public Semester Semester { get; set; }

        public IEnumerable<Score> Scores { get; set; }
    }
}
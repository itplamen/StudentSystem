﻿namespace StudentSystem.Data.Models
{
    using System;
    using System.Collections.Generic;

    using StudentSystem.Data.Models.Base;

    public class Semester : BaseModel
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        
        public IEnumerable<Discipline> Disciplines { get; set; }
    }
}
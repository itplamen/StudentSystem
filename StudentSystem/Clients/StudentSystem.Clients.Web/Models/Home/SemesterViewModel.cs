namespace StudentSystem.Clients.Web.Models.Home
{
    using System;
    using System.Collections.Generic;

    public class SemesterViewModel
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<ScoreViewModel> Scores { get; set; }
    }
}
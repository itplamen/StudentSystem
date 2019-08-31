namespace StudentSystem.Clients.Web.Models.Home
{
    using System;
    using System.Collections.Generic;

    public class StudentViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public IEnumerable<SemesterViewModel> Semesters { get; set; }
    }
}
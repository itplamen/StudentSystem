namespace StudentSystem.Data.Commands.Semesters
{
    using System;

    using StudentSystem.Data.Contracts.Commands;

    public class SemesterCommand : ICommand
    {
        public SemesterCommand(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
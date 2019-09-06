namespace StudentSystem.Data.Commands.Semesters
{
    using System;

    public class UpdateSemesterCommand : SemesterCommand
    {
        public UpdateSemesterCommand(int id, string name, DateTime startDate, DateTime endDate) 
            : base(name, startDate, endDate)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
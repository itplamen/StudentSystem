namespace StudentSystem.Data.Commands.Scores
{
    using StudentSystem.Data.Contracts.Commands;

    public class ScoreCommand : ICommand
    {
        public ScoreCommand(float mark, int studentId, int desciplineId)
        {
            Mark = mark;
            StudentId = studentId;
            DisciplineId = desciplineId;
        }

        public float Mark { get; set; }

        public int StudentId { get; set; }

        public int DisciplineId { get; set; }
    }
}
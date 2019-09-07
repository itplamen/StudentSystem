namespace StudentSystem.Data.Commands.Scores
{
    public class UpdateScoreCommand : ScoreCommand
    {
        public UpdateScoreCommand(int id, float mark, int studentId, int desciplineId) 
            : base(mark, studentId, desciplineId)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
namespace StudentSystem.Data.Models
{
    using StudentSystem.Data.Models.Base;

    public class Score : BaseModel
    {
        public float Mark { get; set; }

        public int StudentId { get; set; }

        public int DisciplineId { get; set; }

        public Student Student { get; set; }
    }
}
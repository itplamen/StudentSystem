namespace StudentSystem.Services.Web.Mappers
{
    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Scores;
    using StudentSystem.Services.Models.Web.Students;
    using StudentSystem.Services.Web.Mappers.Base;

    public class ScoresMapper : BaseMapper<Score, ScoreResponseModel>
    {
        private readonly IMapper<Student, StudentResponseModel> studentsMapper;

        public ScoresMapper(IMapper<Student, StudentResponseModel> studentsMapper)
        {
            this.studentsMapper = studentsMapper;
        }

        public override ScoreResponseModel Map(Score from)
        {
            ScoreResponseModel score = new ScoreResponseModel()
            {
                Id = from.Id,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                Mark = from.Mark,
                DisciplineId = from.DisciplineId,
                StudentId = from.StudentId,
                Student = studentsMapper.Map(from.Student)
            };

            return score;
        }
    }
}
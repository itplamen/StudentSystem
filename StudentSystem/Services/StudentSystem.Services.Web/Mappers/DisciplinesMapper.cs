namespace StudentSystem.Services.Web.Mappers
{
    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Models.Web.Scores;
    using StudentSystem.Services.Web.Mappers.Base;

    public class DisciplinesMapper : BaseMapper<Discipline, DisciplineResponseModel>
    {
        private readonly IMapper<Score, ScoreResponseModel> scoresMapper;
        private readonly IMapper<Professor, ProfessorResponseModel> professorsMapper;

        public DisciplinesMapper(IMapper<Score, ScoreResponseModel> scoresMapper, IMapper<Professor, ProfessorResponseModel> professorsMapper)
        {
            this.scoresMapper = scoresMapper;
            this.professorsMapper = professorsMapper;
        }

        public override DisciplineResponseModel Map(Discipline from)
        {
            DisciplineResponseModel discipline = new DisciplineResponseModel()
            {
                Id = from.Id,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                Name = from.Name,
                SemesterId = from.SemesterId,
                ProfessorId = from.ProfessorId,
                Professor = professorsMapper.Map(from.Professor),
                Scores = scoresMapper.Map(from.Scores)
            };

            return discipline;
        }
    }
}
namespace StudentSystem.Services.Web.Builders
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Models.Web.Scores;

    public class DisciplinesBuilder : IBuilder<Discipline, DisciplineResponseModel>
    {
        private readonly IMapper<Score, ScoreResponseModel> scoresMapper;
        private readonly IMapper<Professor, ProfessorResponseModel> professorsMapper;
        private readonly IMapper<Discipline, DisciplineResponseModel> disciplineMapper;

        public DisciplinesBuilder(
            IMapper<Score, ScoreResponseModel> scoresMapper,
            IMapper<Professor, ProfessorResponseModel> professorsMapper,
            IMapper<Discipline, DisciplineResponseModel> disciplineMapper)
        {
            this.scoresMapper = scoresMapper;
            this.professorsMapper = professorsMapper;
            this.disciplineMapper = disciplineMapper;
        }

        public IEnumerable<DisciplineResponseModel> Build(IEnumerable<Discipline> from)
        {
            ICollection<DisciplineResponseModel> disciplineResponses = new List<DisciplineResponseModel>();

            foreach (var discipline in from)
            {
                DisciplineResponseModel disciplineResponse = disciplineMapper.Map(discipline);
                disciplineResponse.Professor = professorsMapper.Map(discipline.Professor);
                disciplineResponse.Scores = scoresMapper.Map(discipline.Scores);

                disciplineResponses.Add(disciplineResponse);
            }

            return disciplineResponses;
        }
    }
}
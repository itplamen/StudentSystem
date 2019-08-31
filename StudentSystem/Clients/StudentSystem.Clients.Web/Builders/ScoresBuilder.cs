namespace StudentSystem.Clients.Web.Builders
{
    using System.Collections.Generic;

    using AutoMapper;

    using StudentSystem.Clients.Web.Models.Home;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class ScoresBuilder
    {
        public static IEnumerable<ScoreViewModel> Build(IEnumerable<DisciplineResponseModel> disciplines)
        {
            ICollection<ScoreViewModel> viewModels = new List<ScoreViewModel>();

            foreach (var discipline in disciplines)
            {
                foreach (var score in discipline.Scores)
                {
                    ScoreViewModel viewModel = Mapper.Map<ScoreViewModel>(discipline);
                    viewModel.Score = score.Mark;
                }
            }

            return viewModels;
        }
    }
}
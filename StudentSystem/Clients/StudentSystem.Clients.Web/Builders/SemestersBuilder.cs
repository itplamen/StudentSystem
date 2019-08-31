namespace StudentSystem.Clients.Web.Builders
{
    using System.Collections.Generic;

    using AutoMapper;

    using StudentSystem.Clients.Web.Models.Home;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class SemestersBuilder
    {
        public static IEnumerable<SemesterViewModel> Build(IEnumerable<SemesterResponseModel> semesters)
        {
            ICollection<SemesterViewModel> viewModels = new List<SemesterViewModel>();

            foreach (var semester in semesters)
            {
                SemesterViewModel viewModel = Mapper.Map<SemesterViewModel>(semester);
                viewModel.Scores = ScoresBuilder.Build(semester.Disciplines);

                viewModels.Add(viewModel);
            }

            return viewModels;
        }
    }
}
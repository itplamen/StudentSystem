namespace StudentSystem.Clients.Web.Builders
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using StudentSystem.Clients.Web.Models.Home;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentsBuilder
    {
        public static IEnumerable<StudentViewModel> Build(IEnumerable<SemesterResponseModel> semesters)
        {
            ICollection<StudentViewModel> viewModels = new List<StudentViewModel>();

            //IEnumerable<StudentResponseModel> studentResponses = semesters.SelectMany(x => 
            //        x.Disciplines.SelectMany(y => 
            //        y.Scores.Select(z => 
            //        z.Student)))
            //    .GroupBy(x => x.Id)
            //    .Select(x => x.First());

            //foreach (var studentResponse in studentResponses)
            //{
            //    IEnumerable<SemesterResponseModel> studentSemesters = semesters.Where(x => 
            //        x.Disciplines.Any(y => 
            //        y.Scores.Any(z => 
            //        z.StudentId == studentResponse.Id)));

            //    StudentViewModel viewModel = Mapper.Map<StudentViewModel>(studentResponse);
            //    viewModel.Semesters = SemestersBuilder.Build(studentSemesters);

            //    viewModels.Add(viewModel);
            //}

            return viewModels;
        }
    }
}
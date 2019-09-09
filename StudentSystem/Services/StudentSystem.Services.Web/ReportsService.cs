namespace StudentSystem.Services.Web
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Web.Contracts;

    public class ReportsService : IReportsService
    {
        private readonly IQueryHandler<IEnumerable<Semester>> semestersHandler;
        private readonly IBuilder<Semester, SemesterResponseModel> semestersBuilder;

        public ReportsService(
            IQueryHandler<IEnumerable<Semester>> semestersHandler,
            IBuilder<Semester, SemesterResponseModel> semestersBuilder)
        {
            this.semestersHandler = semestersHandler;
            this.semestersBuilder = semestersBuilder;
        }

        public IEnumerable<SemesterResponseModel> GetStemesters()
        {
            IEnumerable<Semester> semesters = semestersHandler.Handle();
            IEnumerable<SemesterResponseModel> response = semestersBuilder.Build(semesters);

            return response;
        }
    }
}